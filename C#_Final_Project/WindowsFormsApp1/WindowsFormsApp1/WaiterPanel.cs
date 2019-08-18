using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class WaiterPanel : Form
    {
        private Waiter LoggedWaiter { get; set; }
        Entities db = new Entities();
        public WaiterPanel()
        {
            
            InitializeComponent();
        }
        int TableID;
        int ClientID;
        
        List<Button> formbutton = new List<Button>();
        List<Client> orderlist;

        
        private void WaiterPanel_Load(object sender, EventArgs e)
        {           
            formbutton.Add(btnTable1);
            formbutton.Add(btnTable2);
            formbutton.Add(btnTable3);
            formbutton.Add(btnTable4);
            formbutton.Add(btnTable5);
            formbutton.Add(btnTable6);
            formbutton.Add(btnTable7);
            formbutton.Add(btnTable8);
            formbutton.Add(btnTable9);
            formbutton.Add(btnTable10);
            formbutton.Add(btnTable11);
            formbutton.Add(btnTable12);           

            Buttoncolor();

        }


        void Buttoncolor()
        {
            orderlist = db.Clients.Where(s => s.Status == true).ToList();
            foreach (var item in formbutton)
            {
                var itemid = Convert.ToInt32(item.Tag);
                foreach (var itemorder in orderlist)
                {
                    if (itemid == itemorder.TableID)
                    {
                        item.BackColor = Color.Red;
                    }
                }
            }
        }
        void UpdateMenu()
        {
            dtgmenu.DataSource = db.Menus.Where(s=>s.Category.Name==cmbCategorySelect.Text).Select(m => new
            {
                m.ID,
                m.Name,
                Category = m.Category.Name,
                m.Price_AZN,
                m.Prepation_time
            }).ToList();

            dtgmenu.Columns[0].Visible = true;
            
        }
        void EnableClientBtn()
        {
            btnAddClient.Visible = true;
        }
        void DisableClientBtn()
        {
            btnAddClient.Visible = false;
            btnTotal.Visible = true;
        }
        void MenuCategoryNull()
        {
            dtgmenu.DataSource = null;
            cmbCategorySelect.Text = "";
            cmbCategorySelect.Items.Clear();
        }
        void UpdateCategory()
        {
            cmbCategorySelect.Items.Clear();

            foreach (var item in db.Categories.OrderBy(c => c.Name).ToList())
            {
                CategoryCombo com = new CategoryCombo
                {
                    Text = item.Name,
                    Value = item.ID
                };
                cmbCategorySelect.Items.Add(com);
            }
        }
        void EnableClient()
        {

            try 
            {
                Client orderclient= db.Clients.Where(s => s.Status == true && s.TableID == TableID).First();
                ClientID = orderclient.ID;
                UpdateMenu();
                UpdateCategory();
                DisableClientBtn();
                UpdateOrdersShow();
                btnAddOrder.Enabled = true;
                btnTotal.Visible = true;
            }
           catch
            {
                dtgOrdersShow.DataSource = null;
                EnableClientBtn();
                MenuCategoryNull();
                btnAddOrder.Enabled = false;
                btnTotal.Visible = false;

            }

            
        }
        void UpdateOrdersShow()
        {
            dtgOrdersShow.DataSource = null;
            dtgOrdersShow.DataSource = db.Orders.Where(s => s.ClientID == ClientID && s.Client.Status == true).Select(o => new
            {
                o.ClientID,
                o.Menu.Name,
                o.Menu.Price_AZN,
            }).ToList();
        }



        private void cmbCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbCategorySelect_TextChanged(object sender, EventArgs e)
        {
            UpdateMenu();
        }



        private void btnTable1_Click(object sender, EventArgs e)
        {
            TableID = Convert.ToInt32(btnTable1.Tag);
            EnableClient();

        }
        private void btnTable2_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable2.Tag);
            EnableClient();
        }
        private void btnTable3_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable3.Tag);
            EnableClient();
        }
        private void btnTable4_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable4.Tag);
            EnableClient();
        }
        private void btnTable5_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable5.Tag);
            EnableClient();
        }
        private void btnTable6_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable6.Tag);
            EnableClient();
        }
        private void btnTable7_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable7.Tag);
            EnableClient();
        }
        private void btnTable8_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable8.Tag);
            EnableClient();
        }
        private void btnTable9_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable9.Tag);
            EnableClient();
        }
        private void btnTable10_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable10.Tag);
            EnableClient();
        }
        private void btnTable11_Click(object sender, EventArgs e)
        {

            TableID = Convert.ToInt32(btnTable11.Tag);
            EnableClient();
        }
        private void btnTable12_Click(object sender, EventArgs e)
        {
            TableID = Convert.ToInt32(btnTable12.Tag);
            EnableClient();
        }



        private void bntAddClient_Click(object sender, EventArgs e)
        {


            db.Clients.Add(new Client
            {
                TableID = TableID,
                Status = true,
                TotalPrice = 0
            });
            db.SaveChanges(); 
            
            
            DisableClientBtn();
            Buttoncolor();
            EnableClient();



        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            bool select = false;
            for(var i = 0; i < dtgmenu.Rows.Count; i++)
            {
                if (dtgmenu.Rows[i].Cells[0]?.Value?.ToString() == "True")
                {
                    int SelectedID = (int)dtgmenu.Rows[i].Cells[1].Value;


                    Task ts = Task.Run(() =>
                    {
                        db.Orders.Add(new Order
                        {
                            ClientID = ClientID,
                            MenuID = SelectedID,
                        });

                    });
                    ts.Wait();
                    if (ts.IsCompleted)
                    {
                        db.SaveChanges();
                        UpdateOrdersShow();
                    }
                    


                }
                
                select = true;
            }
            if (!select)
            {
                MessageBox.Show("Please,choose something from menu");
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();
            LoginForm.FormClosed += (sender2, e2) => this.Close();
        }


       

        private void btnTotal_Click(object sender, EventArgs e)
        {
            List<Order> ShowOrdersList;
            decimal TotalPrice = 0;
            
            ShowOrdersList = db.Orders.Where(s => s.ClientID == ClientID).ToList();

            
            foreach (var item in ShowOrdersList)
            {
                TotalPrice += (decimal)item.Menu.Price_AZN;
            }

            Client cl = db.Clients.Find(ClientID);
            cl.TotalPrice = TotalPrice;
            cl.Status = false;
            db.SaveChanges();
            MessageBox.Show($"Total Price : {TotalPrice}");
            EnableClient();
            Buttoncolor();
            foreach (var item in formbutton)
            {
                var itemid = Convert.ToInt32(item.Tag);
                if (itemid == TableID)
                {
                    item.BackColor = Color.Green;
                }
            }
            btnTotal.Visible = false;

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }
       
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
