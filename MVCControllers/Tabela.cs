using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Models;
namespace MVC_Controllers
{
   public class Tabela
    {
       // IModel Model { get; set; }
        List<Karta> KarteURuci { get; set; }
         
        public Tabela(List<Karta> karte)
        {
            KarteURuci = new List<Karta>();
            KarteURuci = karte;
            vrtaPobede = "";
        }
        #region Pomocne
        private List<Karta> UzastopneKarte() //nije obradjeno da moze A a da pre njega bude K i da su to i dalje uzastopne
        {
            int i = 0;
            Karta minK = new Karta();
            int min = Int32.Parse(KarteURuci[0].Broj);
            minK =KarteURuci[0];
            for (int j = i + 1; j < KarteURuci.Count(); j++)
            {
                if (min > Int32.Parse(KarteURuci[j].Broj))
                {
                    min = Int32.Parse(KarteURuci[j].Broj);
                    minK = KarteURuci[j];
                }

            }
            List<Karta> list = new List<Karta>();
            list.Add(minK);
            for (int k = 1; k < KarteURuci.Count(); k++)
            {
                if (Int32.Parse(KarteURuci[k].Broj) == Int32.Parse(list[list.Count - 1].Broj) + 1)
                    list.Add(KarteURuci[k]);

            }
            return list;
        }

        #endregion

        #region seteri za multiplikatore
        int mStraightFlush { get; set; }
        int mFourofKind { get; set; }
        int mBigDog { get; set; }
        int mFlush { get; set; }
        int mStraight { get; set; }
        int mLittleDog { get; set; }
        int mBobtailStraight { get; set; }
        int mTwoPair { get; set; }
        int mOnePair { get; set; }
        int mThreeOfKind { get; set; }

        #endregion
        #region Multiplikator postava
        public void PostaviMultiplikatore(int strFlu,int fourofkind, 
            int bigDog, int flush, int straight, int littleDog, int bobtail, int threeeofkind,
            int twoPair,int OnePair)
        {
            mStraightFlush = strFlu;
            mFourofKind = fourofkind;
            mBigDog = bigDog;
            mFlush = flush;
            mStraight = straight;
            mLittleDog = littleDog;
            mBobtailStraight = bobtail;
            mTwoPair = twoPair;
            mOnePair = OnePair;
            mThreeOfKind = threeeofkind;

        }

        public string vrtaPobede { get; set; }
        
        public int Pregled()
        {
            if (Straight_flush())
            {
                vrtaPobede = "Straight_flush";
                return mStraightFlush;
            }
            if (Four_of_a_kind())
            { vrtaPobede = "Four of Kind"; return mFourofKind; }
            if (Big_dog())
            { vrtaPobede = "Big dog"; return mBigDog; }
            if (Flush())
            { vrtaPobede = "Flush"; return mFlush; }

            if (Straight())
            { vrtaPobede = "Straight"; return mStraight; }
            if (Little_Dog())
            { vrtaPobede = "Little dog"; return mLittleDog; }
            if (Bobtail_straight())
            { vrtaPobede = "Bobtail straight"; return mBobtailStraight; }
            if (Three_of_kind())
            { vrtaPobede = "Three of kind"; return mThreeOfKind; }
            if (Two_pair())
            { vrtaPobede = "Two pair"; return mTwoPair; }
            if (One_pair())
            { vrtaPobede = "one pair"; return mOnePair; }
            else
            { vrtaPobede = "nista specijalno"; return 1; }

        }
        #endregion

        #region fje za Pobedu
        public bool Straight_flush() //karte iste boje i u nizu
        {
            int i = 0;
            for (int j = i + 1; j < 5; j++)
            {
                if (KarteURuci[i].Boja==KarteURuci[j].Boja)
                    return false;
            }
            List<Karta> list = new List<Karta>();
            list = UzastopneKarte();
            if (list.Count() == 5)
                return true;
            else return false;
        }
        

       public bool Four_of_a_kind()
        {
            return false;
        }

        public bool Big_dog()
        {
            return false;
        }

        public bool Flush()
        {
            int pom = 1;
            for(int i=0;i<4;i++)
            {
                if (KarteURuci[i].Boja == KarteURuci[i + 1].Boja)
                    pom++;
            }
            if (pom == 5)
                return true;
            else return false;
        }

        public bool Straight()
        {
            if (UzastopneKarte().Count() == 5)
                return true;
            else return false;
        }

        public bool Little_Dog()// 7 je najveci br a 2 je najmanji
        {
            
                return false;

        }
        public bool Bobtail_straight() //4 karte u redosledu
        {
            List<Karta> list = new List<Karta>();
            list = UzastopneKarte();
            if (list.Count() == 4)
                return true;
            else return false;
        }

        public bool Three_of_kind()
        {
            for (int i = 0; i < KarteURuci.Count() - 2; i++)
            {
                int k = 0;
                for (int j = i + 1; j < KarteURuci.Count() - 1; j++)
                {
                    if (KarteURuci[i].Boja == KarteURuci[j].Boja)
                        k++;
                }
                if (k == 3)
                    return true;
            }
             return false;
        }

        public bool Two_pair()
        {
            int par = 0;
            for (int i = 0; i < KarteURuci.Count() - 2; i++)
            {
                int k = 0;
                for (int j = i + 1; j < KarteURuci.Count() - 1; j++)
                {
                    if (Int32.Parse(KarteURuci[i].Broj)==Int32.Parse( KarteURuci[j].Broj))
                        k++;
                }
                if (k == 2)
                    par++;


            }
            if (par == 2)
                return true;
            else return false;
        }
        public bool One_pair()
        {
            int j = 0;
            int par = 0;
            for(int i=0;i<KarteURuci.Count()-2;i++)
            {
                int k = 0;
                for( j=i+1;j<KarteURuci.Count()-1;j++)
                {
                    if (Int32.Parse(KarteURuci[i].Broj )== Int32.Parse(KarteURuci[j].Broj))
                        k++;
                }
                if (k == 2)
                    par++;
                
               
            }
            if (par == 1)
                return true;
            else return false;
        }
        #endregion

     /*  private List<Karta> MinKaMax()
        {
           
        }*/


        /*
        public int OneTWOpair(int one,int two,int triling, int ) 
        {
          
            int oneTWO = 0; //ako ima jedan par vraca 1 ako ima dvapara dobija vrednost 2
            int multiplikator = -1;
            
          for(int i=0;i<4; i++)
            {
               int kolikoIhJe = 0;
                for (int j = i + 1; j < 5; j++)
                {
                    if (Model.KarteURuci[i].Broj == Model.KarteURuci[j].Broj)
                        kolikoIhJe++;
                            
                }
                if(kolikoIhJe==4)
                {
                    multiplikator=
                }
            }
            if (oneTWO == 1)
                multiplikator = one;
            else if (oneTWO == 2)
                multiplikator = two;

            return multiplikator;
        }

     
    */
    }
}
