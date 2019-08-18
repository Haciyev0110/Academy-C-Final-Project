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
    public partial class Form1 : Form
    {
        Entities db = new Entities();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool asAdmin = chkAdmin.Checked;

            if (asAdmin)
            {
                Admin adm =db.Admins.FirstOrDefault(a => a.Username == username);
                
                if (adm != null)
                {
                    if (Extension.CheckPassword(password, adm.Password))
                    {
                        AdminPanel admForm = new AdminPanel();
                        admForm.Show();
                        this.Hide();

                        admForm.FormClosed += (sender2, e2) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is wrong");
                }
            }
            else
            {
                Waiter waiter = db.Waiters.FirstOrDefault(s => s.Username == username );

                if (waiter != null && Extension.CheckPassword(password, waiter.Password))
                {
                    WaiterPanel WaiterForm = new WaiterPanel();
                    WaiterForm.Show();
                    this.Hide();

                    WaiterForm.FormClosed += (sender2, e2) => this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong");
                }
            }
        }
    }
}
