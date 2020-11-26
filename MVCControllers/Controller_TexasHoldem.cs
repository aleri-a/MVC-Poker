using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Models;

namespace MVC_Controllers
{
   public  class Controller_TexasHoldem : IControllers
    {
        public int BrPoena { get; set; }
        public IModel Model { get; set; }
        private Tabela tabela { get; set; }
        public int Ulog { get; set; }
        public List<Karta> RukaSve { get; set; }
        public List<Karta> Ruka { get; set; }//ruka su otkrivene karte, rukasve su sve karte i one zaklopljene
       public string VrstaPobede { get; set; }
        public Controller_TexasHoldem()
        {

        }

        public Controller_TexasHoldem(IModel mod)
        {
            Ruka = new List<Karta>();
            Model = mod;
            BrPoena = 0;
            RukaSve = new List<Karta>();
            
        }
           
        public bool Igraj(List<Karta> kOtkri)
        {
           
            return OtkriKartu(kOtkri);
        }
       
        public void Kraj()
        {
            tabela = new Tabela(RukaSve);
            tabela.PostaviMultiplikatore(150, 90, 60, 40, 26, 18, 12, 8, 5, 1);

            int bonus = 0;
            int multiplikator = tabela.Pregled();
            if (Ruka.Count == 2)
                bonus = 5;
            else if (Ruka.Count == 3)
                bonus = 2;
            else if (Ruka.Count == 4)
                bonus = -Ulog;
            else if (Ruka.Count == 5)
                bonus = -2 * Ulog;


            if (bonus > 0)
                BrPoena = Ulog * multiplikator * bonus;
            else BrPoena = BrPoena + bonus;
            VrstaPobede = tabela.vrtaPobede;
        }

        public void PodeliKarte(int ulog)
        {
            if (BrPoena < ulog)
                return;
            Ulog = ulog;
            BrPoena -= ulog;
            RukaSve = Model.KarteURuci;
            Ruka.Add(RukaSve[0]);
            Ruka.Add(RukaSve[1]);
        }

       

        public void Start(int brPoena)
        {
            BrPoena = brPoena;
        }

        
        private bool OtkriKartu(List<Karta> kOtkri)
        {
            if (BrPoena < Ulog && Ruka.Count>=3)
            {
                return false;
            }
            foreach (Karta k in kOtkri)
                Ruka.Add(k);
             return true;
        }

        
      

       
    }
}
