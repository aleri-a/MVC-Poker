using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models
{
   public class MojSpil: IModel
    {

     

      public  MojSpil()
        {
            Spil = new List<Karta>();
            KarteURuci = new List<Karta>();
            KreirajSpil(1,10);
            Izmesaj();
            for (int i = 0; i < 5; i++)
            {
                Karta k = new Karta();
                k = IzvuciKartu();
                KarteURuci.Add(k);
            }
        }

       


    }
}
