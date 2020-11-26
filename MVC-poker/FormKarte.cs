using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Controllers;
using MVC_Models;
namespace MVC_poker
{
    public partial class FormKarte : Form
    {
        IControllers kontrole { get; set; }
        List<Button> dugmiciZaZamenu { get; set; }

        int BrojacZamenjenihKarata { get; set; }
        int PrethodniPoeni { get; set; }


        public FormKarte(IControllers kont,int poeni)
        {
            dugmiciZaZamenu = new List<Button>();
            InitializeComponent();
            kontrole = kont;
            string a = Environment.CurrentDirectory + @"\Karte\backSideOfCards.jpg";

            List<Button> listDugmica = new List<Button>();
            listDugmica.Add(btnKarta1);
            listDugmica.Add(btnKarta2);
            listDugmica.Add(btnKarta3);
            listDugmica.Add(btnKarta4);
            listDugmica.Add(btnKarta5);

            foreach(Button b in listDugmica)
            {
                b.BackgroundImage = Image.FromFile(a);
            }
            int j = 0;
            foreach(Karta k in kontrole.Ruka)
            {
                PostaviSliku(k, listDugmica[j]);
                j++;
            }

            PrethodniPoeni = poeni;
            BrojacZamenjenihKarata = 0;
        }
      private void PostaviSliku(Karta k, Button btn)
        {
             string putanja = PutanjaDoSlike(k);
              btn.BackgroundImage = Image.FromFile(putanja);
            return;
        }

        private string PutanjaDoSlike(Karta k)
        {
            string p0 = @"_";
            string p1 = "";
            string p4 = @".png";

            if (k.Boja == Boja.herc)
                    p1 = @"H";
                else if (k.Boja == Boja.tref)
                    p1 = @"C";
                else if (k.Boja == Boja.karo)
                    p1 = @"D";
                else if (k.Boja == Boja.pik)
                    p1 = @"S";


            string a = "";
             a = Environment.CurrentDirectory + @"\Karte2\" + p0 + (k.Broj).ToString()+p1 +p4;
            return a;
          
        }

        private void FormKarte_Load(object sender, EventArgs e)
        {

        }

      
     

        private void Igra(Button btn)
        {
           
            dugmiciZaZamenu.Add(btn);
            List<Karta> karteZamenu = new List<Karta>();
           
            foreach(Button b in dugmiciZaZamenu)
            {
                if(b==btnKarta1)
                {
                    karteZamenu.Add(kontrole.RukaSve[0]);
                }
                if (b == btnKarta2)
                {
                    karteZamenu.Add(kontrole.RukaSve[1]);
                }
                if (b == btnKarta3)
                {
                    karteZamenu.Add(kontrole.RukaSve[2]);
                }
                if (b == btnKarta4)
                {
                     karteZamenu.Add(kontrole.RukaSve[3]);
                   
                }
                if (b == btnKarta5)
                {
                    karteZamenu.Add(kontrole.RukaSve[4]);
                }

                int kolikoNjihMenjamo = dugmiciZaZamenu.Count();

                kontrole.Igraj(karteZamenu);




                foreach (Button t in dugmiciZaZamenu)
                {
                    Karta k = kontrole.Ruka[kontrole.Ruka.Count()-1];
                    PostaviSliku(k ,t);
                    kolikoNjihMenjamo--;
                }
              
                dugmiciZaZamenu = new List<Button>();
            }


              
            
        }

        #region Karte koje se otvaraju/menjaju


        private void AkrivirajDugme(Button b)
        {
            BrojacZamenjenihKarata++;
            if (DaLiJeTexassHoldem() && !KartaNijeOtvorena(b))
            {
                PrikaziPoruku("Ne mozete otvoriti tu kart, vec je otvoren");
                return;
            }
            if (!DaLiJeTexassHoldem() && BrojacZamenjenihKarata > 3)
            {
                PrikaziPoruku("Zamenili ste vise od 3 karata. Kraj Igre");
                KrajIgre();
            }
            Igra(b);
        }

        private void btnKarta3_Click(object sender, EventArgs e)
        {
            AkrivirajDugme(btnKarta3);
        }

        

        private void btnKarta5_Click(object sender, EventArgs e)
        {
            AkrivirajDugme(btnKarta5);
        }

        private void btnKarta4_Click(object sender, EventArgs e)
        {
            AkrivirajDugme(btnKarta4);
        }

        private void btnKarta2_Click(object sender, EventArgs e)
        {
            AkrivirajDugme(btnKarta2);
        }

        private void btnKarta1_Click(object sender, EventArgs e)
        {
            AkrivirajDugme(btnKarta1);
        }

        #endregion

        #region Pomocne metode tokom igre
       

        private bool DaLiJeTexassHoldem()
        {
            Controller_TexasHoldem tx = new Controller_TexasHoldem();
            if (tx.GetType() == kontrole.GetType())
                return true;
            else return false;
        }
        private bool KartaNijeOtvorena(Button btn) //to koristi za holdem tj ako je zaklopljena onda moze
        {
            string a = Environment.CurrentDirectory + @"\Karte\backSideOfCards.jpg";
            if (btn.BackgroundImage == Image.FromFile(a))
                return false;
            else return true;
        }

        private void PrikaziPoruku(string poruka)
        {
            MessageBox.Show(poruka, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region metode za Kraj igre +dugme

        private void btnKraj_Click(object sender, EventArgs e)
        {
            KrajIgre();
        }

        public void   KrajIgre()
        {
            OtvoriOstaleKarte();
            kontrole.Kraj();
            int brPoena = kontrole.BrPoena;
            lblPrethodniPoeni.Text = "Imali ste " + PrethodniPoeni.ToString() + " poena ";
            lblBrPoena.Text = "Na stanju trenutno imate: " + kontrole.BrPoena.ToString() + " poena ";
            PrethodniPoeni = brPoena;
            lblVrstPobede.Text = kontrole.VrstaPobede;
        }

        public void OtvoriOstaleKarte()
        {
            if (!DaLiJeTexassHoldem())
                return;
        //    kontrole.Ruka = kontrole.RukaSve;
            List<Button> listDugmica = new List<Button>();
            listDugmica.Add(btnKarta1);
            listDugmica.Add(btnKarta2);
            listDugmica.Add(btnKarta3);
            listDugmica.Add(btnKarta4);
            listDugmica.Add(btnKarta5);
            int j = 0;
            foreach (Karta k in kontrole.RukaSve)
            {
                PostaviSliku(k, listDugmica[j]);
                j++;
            }
           //ako namestis da ti se poeni racunaju na osnovu otvorenih karata onda ti ova linija ne treba
        }

      
    }
    #endregion


}
