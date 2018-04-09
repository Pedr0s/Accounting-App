using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;



namespace BusinessLayer
{
    public class Balanscontrols
    {
        public bool AddEntry(string Entryname, string Label)
        {
            Balans balans = new Balans();

            switch (Label)
            {
                case "Vaste activa":
                    balans.vasteActiva.AddEntry(Entryname);
                    return true;
                case "Vlottende activa":
                    balans.vlottendeActiva.AddEntry(Entryname);
                    return true;
                case "Eigenvermogen":
                    balans.eigenVermogen.AddEntry(Entryname);
                    return true;
                case "Langvreendvermogen":
                    balans.langVreemdVermogen.AddEntry(Entryname);
                    return true;
                case "Kortvreemdvermogen":
                    balans.kortVreemdVermogen.AddEntry(Entryname);
                    return true;
                default:
                    // did not select an item
                    return false;
            }
        }
}
}
