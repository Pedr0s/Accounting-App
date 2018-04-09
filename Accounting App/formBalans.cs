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

namespace Accounting_App
{
    public partial class formBalance : Form
    {
        public formBalance()
        {
            InitializeComponent();
        }

        private void formBalance_Load(object sender, EventArgs e)
        {
            Balans balans = new Balans();
            Dictionary<string, int> Activa = balans.GetActiva();
            Dictionary<string, int> Passiva = balans.GetPassiva();

            DataGridViewCellStyle bold = new DataGridViewCellStyle();
            bold.Font = new Font(gridviewBalans.Font, FontStyle.Bold);

            int BalansLength = Activa.Count();
            if (Passiva.Count() > BalansLength) { BalansLength = Passiva.Count(); }
            for (int i = 0; i < BalansLength; i++)
            {
                int Rownumber = gridviewBalans.Rows.Add();
          
                if (i< Activa.Count())
                {
                gridviewBalans.Rows[Rownumber].Cells[colActiva.Index].Value = Activa.Keys.ElementAt(i);
                gridviewBalans.Rows[Rownumber].Cells[colActivaN.Index].Value = "€" + Activa.Values.ElementAt(i) ;
                    if (Activa.Values.ElementAt(i) < 0)
                    {
                        gridviewBalans.Rows[Rownumber].Cells[colActiva.Index].Style = bold;
                        gridviewBalans.Rows[Rownumber].Cells[colActivaN.Index].Value = "";
                    }
                }
                if (i < Passiva.Count())
                {

                gridviewBalans.Rows[Rownumber].Cells[colPassiva.Index].Value = Passiva.Keys.ElementAt(i);
                gridviewBalans.Rows[Rownumber].Cells[colPassivaN.Index].Value = "€" + Passiva.Values.ElementAt(i);
                    if (Passiva.Values.ElementAt(i) < 0)
                    {
                        gridviewBalans.Rows[Rownumber].Cells[colPassiva.Index].Style = bold;
                        gridviewBalans.Rows[Rownumber].Cells[colPassivaN.Index].Value = "";
                    }
                }


            }       
        }
    }
}
