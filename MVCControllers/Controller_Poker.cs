using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC_Models;
namespace MVC_Controllers
{
    
    public class Controller_Poker : IControllers
    {
        #region interfejs
        public List<Karta> Ruka { get; set; }
        public IModel Model { get; set; }
        public  int BrPoena { get ; set ; }
        public List<Karta> RukaSve { get; set; }
        public int Ulog { get; set; }
        private Tabela tabela { get; set; }
        public string VrstaPobede { get; set; }

        #endregion
        public Controller_Poker(IModel mod)
        {
            Model = mod;
            BrPoena = 0;
            RukaSve = new List<Karta>();
            }
    

        public void PodeliKarte(int ulog)
        {
            if (BrPoena < ulog)
                return;
            Ulog = ulog;
            BrPoena -= ulog;
            Ruka = Model.KarteURuci;
            RukaSve = Ruka;

        }

        public void Start(int brPoena)
        {
            BrPoena = brPoena;
        }

       public void Kraj()
        {
            tabela = new Tabela(Ruka);
            tabela.PostaviMultiplikatore(100, 60, 40, 24, 16, 12, 9, 6, 4, 2);

            int multiplikator = tabela.Pregled();
            BrPoena += multiplikator * Ulog;
            VrstaPobede = tabela.vrtaPobede;

        }
        public bool Igraj(List<Karta> kMenjaju)
        {
            return Zameni(kMenjaju);
        }
      


        public bool Zameni(List<Karta> kMenjaju) 
        {
            if (kMenjaju.Count > 3)
                return false;
            else
            {
                foreach(Karta k in kMenjaju)
                {
                    RukaSve.Remove(k);
                    RukaSve.Add(Model.Zameni(k));
                    
                }
                RukaSve = Ruka;
                
                return true;
            }

           


        }





    }
}
