using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataLayer
{
    public class Balans
    {
        public VasteActiva vasteActiva { get; set; }
        public VlottendeActiva vlottendeActiva { get; set; }
        public int TotaleAciva { get; set; }

        public EigenVermogen eigenVermogen { get; set; }
        public KortVreemdVermogen kortVreemdVermogen { get; set; }
        public LangVreemdVermogen langVreemdVermogen { get; set; }
        public int TotalePassiva { get; set; }

        public Balans()
        {
            vasteActiva = new VasteActiva();
            vlottendeActiva = new VlottendeActiva();

            eigenVermogen = new EigenVermogen();
            kortVreemdVermogen = new KortVreemdVermogen();
            langVreemdVermogen = new LangVreemdVermogen();

        }
        public Dictionary<string, int> GetPassiva()
        {
            Dictionary<string, int> Passiva = new Dictionary<string, int>();
            using (BalansContext context = new BalansContext())
            {

                Passiva.Add("Eigenvermogen", -1);
                foreach (EigenVermogen EigenVermogen  in context.EigenVermogen) {Passiva.Add(EigenVermogen.Name, EigenVermogen.Value);}
                Passiva.Add("Langvreemdvermogen", -1);
                foreach (LangVreemdVermogen LangVreemdVermogen in context.LangVreemdVermogen) {Passiva.Add(LangVreemdVermogen.Name, LangVreemdVermogen.Value); }
                Passiva.Add("Kortvreemdvermogen", -1);
                foreach (KortVreemdVermogen KortVreemdVermogen in context.KortVreemdVermogen) {Passiva.Add(KortVreemdVermogen.Name, KortVreemdVermogen.Value); }
            }
            return Passiva;
        }
        public Dictionary<string, int> GetActiva()
        {
            Dictionary<string, int> Activa = new Dictionary<string, int>();
            using (BalansContext context = new BalansContext())
            {
                Activa.Add("Vaste activa", -1);
                foreach (VasteActiva VasteActiva in context.VasteActiva) { Activa.Add(VasteActiva.Name, VasteActiva.Value); }
                Activa.Add("Vlottende activa", -1);
                foreach (VlottendeActiva VlottendeActiva in context.VlottendeActiva) { Activa.Add(VlottendeActiva.Name, VlottendeActiva.Value); }
            }
            return Activa;
        }
    }

    public class VasteActiva
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public void AddEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {

                bool Entryexists = context.VasteActiva.Where(e => e.Name == name).Any();
                if (Entryexists)
                {
                    MessageBox.Show("This entry already exits");
                }
                context.VasteActiva.Add(new VasteActiva { Name = name });
                context.SaveChanges();
            }
        }
        public List<VasteActiva> GetListObjects()
        {
            using (BalansContext context = new BalansContext())
            {
                return  context.VasteActiva.ToList();
            }
        }
    }
    public class VlottendeActiva
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public void AddEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {

                bool Entryexists = context.VlottendeActiva.Where(e => e.Name == name).Any();
                if (Entryexists)
                {
                    MessageBox.Show("This entry already exits");
                }
                context.VlottendeActiva.Add(new VlottendeActiva { Name = name });
                context.SaveChanges();
            }
        }
        public List<string> GetListName()
        {
            using (BalansContext context = new BalansContext())
            {
                return context.VlottendeActiva.Select(Entry => Entry.Name).ToList();
            }
        }
    }
    public class EigenVermogen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public void AddEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {

                bool Entryexists = context.EigenVermogen.Where(e => e.Name == name).Any();
                if (Entryexists)
                {
                    MessageBox.Show("This entry already exits");
                }
                context.EigenVermogen.Add(new EigenVermogen { Name = name });
                context.SaveChanges();
            }
        }
        public List<string> GetListName()
        {
            using (BalansContext context = new BalansContext())
            {
                return context.EigenVermogen.Select(Entry => Entry.Name).ToList();
            }
        }
    }
    public class KortVreemdVermogen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public void AddEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {

                bool Entryexists = context.KortVreemdVermogen.Where(e => e.Name == name).Any();
                if (Entryexists)
                {
                    MessageBox.Show("This entry already exits");
                }
                context.KortVreemdVermogen.Add(new KortVreemdVermogen { Name = name });
                context.SaveChanges();
            }
        }
        public List<string> GetListName()
        {
            using (BalansContext context = new BalansContext())
            {
                return context.KortVreemdVermogen.Select(Entry => Entry.Name).ToList();
            }
        }
    }
    public class LangVreemdVermogen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public void AddEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {
                
                bool Entryexists = context.LangVreemdVermogen.Where(e => e.Name == name).Any();
                if (Entryexists)
                {
                    MessageBox.Show("This entry already exits");
                }
                context.LangVreemdVermogen.Add(new LangVreemdVermogen { Name = name });
                context.SaveChanges();
            }
        }
        public List<string> GetListName()
        {
            using (BalansContext context = new BalansContext())
            {
                return context.LangVreemdVermogen.Select(Entry => Entry.Name).ToList();
            }
        }
        public void RemoveEntry(string name)
        {
            using (BalansContext context = new BalansContext())
            {
                var EntrytoRemove = context.LangVreemdVermogen.Where(e => e.Name == name).FirstOrDefault();
                context.LangVreemdVermogen.Remove(EntrytoRemove);
                context.SaveChanges();
            }
        }
    }



}
