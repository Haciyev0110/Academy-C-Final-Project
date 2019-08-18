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
    public partial class Waiters : Form
    {
        Entities db = new Entities();
        public Waiters()
        {
            InitializeComponent();
        }

        void UpdateWaiter()
        {
            dtgShowWaiters.DataSource = db.Waiters.Select(w => new
            {
                w.ID,
                w.Firstname,
                w.Lastname,
                w.Username
            }).ToList();
        }
        private void Waiters_Load(object sender, EventArgs e)
        {
            UpdateWaiter();
        }

        private void dtgShowWaiters_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
            int ID = Convert.ToInt32(dtgShowWaiters.Rows[e.RowIndex].Cells[0].Value);
            lblWaiterId.Text = ID.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Waiters.Remove(db.Waiters.Find(Convert.ToInt32(lblWaiterId.Text)));
            db.SaveChanges();
            UpdateWaiter();
        }
    }
}
