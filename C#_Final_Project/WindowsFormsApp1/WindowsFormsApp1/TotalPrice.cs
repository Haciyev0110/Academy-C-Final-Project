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
    public partial class TotalPrice : Form
    {
        Entities db = new Entities();
        public TotalPrice()
        {
            InitializeComponent();



        }

    }
}
