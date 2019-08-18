using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Extensions;

namespace WindowsFormsApp1
{
    public partial class AdminPanel : Form
    {
        Entities db = new Entities();
        public AdminPanel()
        {
            InitializeComponent();
        }
        void  updateMenu()
        {
            dtgMenu.DataSource = db.Menus.Select(m => new
            {
                m.ID,
                m.Name,
                Category = m.Category.Name,
                m.Price_AZN,
                m.Prepation_time
            }).ToList();
        }
        void updateMenuCategories()
        {
            cmbMenuCategory.Items.Clear();

            foreach (var item in db.Categories.OrderBy(c => c.Name).ToList())
            {
                CategoryCombo com = new CategoryCombo
                {
                    Text = item.Name,
                    Value = item.ID
                };
                cmbMenuCategory.Items.Add(com);
            }
            
        }
        void ClearBoxWaiter()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        void ClearAddMenu()
        {
            txtMenuName.Text = "";
            nmMenuPrice.Value = 0;
            nmMenuTime.Value = 0;
            cmbMenuCategory.Text = "";
            btnAddMenu.Enabled = true;
            btnSaveMenu.Enabled = false;
            btnRemoveMenu.Enabled = false;

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            updateMenu();
            updateMenuCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Waiters ShowWaiter = new Waiters();
            ShowWaiter.ShowDialog();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            string name = txtMenuName.Text;
            decimal price = nmMenuPrice.Value;
            int time =Convert.ToInt32(nmMenuTime.Value);
            string categoryname = cmbMenuCategory.Text;

            if (Extension.CheckTextValues(name, 3) &&
               
               Extension.CheckTextValues(categoryname, 2))
            {
                int categoryId = 0;

                try
                {
                    categoryId = ((CategoryCombo)cmbMenuCategory.SelectedItem).Value;
                }
                catch
                {
                    Category newAdded = null;

                    Task t = Task.Run(() => {
                        newAdded = db.Categories.Add(new Category
                        {
                            Name = categoryname,
                        });

                        db.SaveChanges();
                    });

                    t.Wait();

                    if (t.IsCompleted)
                    {
                        categoryId = newAdded.ID;
                    }
                }

                db.Menus.Add(new Model.Menu
                {
                    Name = name,
                    CategoryID = categoryId,
                    Price_AZN = price,
                    Prepation_time = time
                });
                db.SaveChanges();

                MessageBox.Show($"{name} was added successfully.");
                updateMenu();
                updateMenuCategories();
            }
            else
            {
                MessageBox.Show("Some values are not valid.");
            }
            txtMenuName.Text = "";
            nmMenuPrice.Value = 0;
            nmMenuTime.Value = 0;
            cmbMenuCategory.Text = "";

        }

        private void dtgMenu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            btnAddMenu.Enabled = false;
            btnSaveMenu.Enabled = true;
            btnRemoveMenu.Enabled = true;
            int SelectedID = Convert.ToInt32(dtgMenu.Rows[e.RowIndex].Cells[0].Value);
            txtMenuName.Text = dtgMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmMenuPrice.Value = Convert.ToDecimal(dtgMenu.Rows[e.RowIndex].Cells[3].Value);
            nmMenuTime.Value = Convert.ToDecimal(dtgMenu.Rows[e.RowIndex].Cells[4].Value);
            cmbMenuCategory.Text = dtgMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblID.Text = SelectedID.ToString();
        }
        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string username = txtUsername.Text;
            string password = Extension.HashPassword(txtPassword.Text);

            if(Extension.CheckTextValues(firstname,3)&&
                Extension.CheckTextValues(lastname,3)&&
                Extension.CheckTextValues(username,2)&&
                Extension.CheckTextValues(password, 8)&&
                db.Waiters.Count(w=>w.Username==username)==0)
            {
                db.Waiters.Add(new Waiter
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    Username = username,
                    Password = password
                });
            }
            else
            {
                MessageBox.Show("Some values are not valid OR this username already exists for somebody else.");
            }

            
            db.SaveChanges();
            ClearBoxWaiter();
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            int slctID = Convert.ToInt32(lblID.Text);

            Model.Menu mn = db.Menus.Find(slctID);

            string name = txtMenuName.Text;
            decimal price = nmMenuPrice.Value;
            int time = (int)nmMenuTime.Value;
            int ctgrID = ((CategoryCombo)cmbMenuCategory.SelectedItem).Value;

            mn.Name = name;
            mn.Price_AZN = price;
            mn.Prepation_time = time;
            mn.CategoryID = ctgrID;

            db.SaveChanges();
            updateMenu();
            ClearAddMenu();
        }

        private void btnRemoveMenu_Click(object sender, EventArgs e)
        {
            int slctID = Convert.ToInt32(lblID.Text);
            Model.Menu mn = db.Menus.Find(slctID);
            db.Menus.Remove(mn);
            db.SaveChanges();
            updateMenu();
            ClearAddMenu();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();

            LoginForm.FormClosed += (sender2, e2) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }
    }
}
