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


namespace WindowsFormsApp1
{
    public partial class ReportForm : Form
    {
        Entities db = new Entities();
        public ReportForm()
        {
            InitializeComponent();
        }
         
        void UpdateTable()
        {
            comboBox1.Items.Clear();

            foreach (var item in db.Tables.OrderBy(c => c.Table_Number).ToList())
            {
                CategoryCombo com = new CategoryCombo
                {
                    Text = item.Table_Number.ToString(),
                    Value = item.ID
                };
                comboBox1.Items.Add(com);
            }
        }
        void UpdateOrder()
        {
            int CmbNumber = Convert.ToInt32(comboBox1.Text);

            dtgShowReport.DataSource = db.Clients.Where(c=>c.TableID==CmbNumber).Select(s => new
            {
                ClientNumber = s.ID,
                TableNumber = s.TableID,
                s.TotalPrice,
                s.Status
                

            }).ToList();

            dtgShowReport.ReadOnly = true;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            UpdateOrder();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }
    }
}
