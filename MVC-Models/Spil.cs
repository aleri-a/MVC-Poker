using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models
{
    public enum Boja
    {
        pik,
        karo,
        tref,
        herc,
        unknown
    }

    public class Karta
    {

       /// public bool Izabran { get; set; }

        public Boja Boja{get; set ;}
        public string Broj { get; set; }

        public Karta()
        {
            ///Izabran = false;
            Broj = null;
            Boja = Boja.unknown;
        }
        public Karta(Boja b, string br)
        {
            this.Boja = b;
            this.Broj = br;
        }
    }
}




   