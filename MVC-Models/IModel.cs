using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models
{
    public abstract class IModel
    {
     public   List<Karta> KarteURuci { get; set; }
       public  List<Karta> Spil { get; set; }



      public  void Izmesaj()
        {
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < Spil.Count(); j++)
                {

                    int pom = r.Next(Spil.Count() - 1);
                    Karta a = Spil[j];
                    Spil[j] = Spil[pom];
                    Spil[pom] = a;
                }
        }
        public Karta IzvuciKartu()
        {
            Karta k = Spil[Spil.Count - 1];
            Spil.Remove(k);
            return k;

        }

        public Karta Zameni(Karta k)
        {
            Izmesaj();
            Karta nova = IzvuciKartu();
            //Spil.Add(k);
            return nova;
        }

      public  void KreirajSpil(int poc,int jj)
        {
            for (int i = 0; i < 4; i++)
                for (int j = poc; j <= jj; j++)
                {
                    if (j > 10) j++;
                    switch (i)
                    {
                        case 0:
                            {
                                Karta nova = new Karta(Boja.karo, j.ToString());
                                Spil.Add(nova);
                                break;
                            }
                        case 1:
                            {
                                Karta nova = new Karta(Boja.pik, j.ToString());
                                Spil.Add(nova);
                                break;
                            }
                        case 2:
                            {
                                Karta nova = new Karta(Boja.tref, j.ToString());
                                Spil.Add(nova);
                                break;
                            }
                        case 3:
                            {
                                Karta nova = new Karta(Boja.herc, j.ToString());
                                Spil.Add(nova);
                                break;
                            }
                    }
                }
        }
    }

}

