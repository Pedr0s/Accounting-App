using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace Accounting_App
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddEntry d = new formAddEntry();
            d.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formBalance b = new formBalance();
            b.Show();

        }

        private void btnJournal_Click(object sender, EventArgs e)
        {

        }
    }
}
