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
    public partial class formAddEntry : Form
    {
        public formAddEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balanscontrols balanscontrols = new Balanscontrols();
            balanscontrols.AddEntry(textBox1.Text, cbbBalans.SelectedItem.ToString());
        }
    }
}
