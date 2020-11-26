using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC_Models
{
    public class Model_Francuski : IModel
    {

      
       

        
    
    
        public Model_Francuski()
        {
            Spil = new List<Karta>();
            KarteURuci = new List<Karta>();
            KreirajSpil(7,14);
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
