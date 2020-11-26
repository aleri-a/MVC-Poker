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
    public partial class Form1 : Form,IView
    {
        private int PrethodniPoeni { get; set; }
        public IModel Model { get ; set; }
        public IControllers Controllers { get ; set; }
        //public List<Karta> KarteURuci { get ; set ; } pristupas sa controller.kartauruci

        public Form1()
        {
            InitializeComponent();
            txtUlog.Text = "10";
            txtPoeni.Text = "100";
            rbtnPoker.Checked = true;
            rbtnSpilStandardni.Checked = true;
            PrethodniPoeni = 100;
            
        }


      



        private void lblUlog_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    MessageBox.Show(txtPoeni.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MessageBox.Show(txtUlog.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (rbtnSpilFrancuski.Checked)
                Model = new Model_Francuski();
            else
            
                if (rbtnMojSpil.Checked)
                    Model = new MojSpil();
           
            else Model = new Model_Standardni();
                if (rbtnPoker.Checked)
                    Controllers = new Controller_Poker(Model);
                else
                    Controllers = new Controller_TexasHoldem(Model);

            if (Validacija(txtPoeni))
            {
                Controllers.BrPoena = Int32.Parse(txtPoeni.Text);
                PrethodniPoeni = Int32.Parse(txtPoeni.Text);
            }
            if (Validacija(txtUlog))
            {
                Controllers.Ulog = Int32.Parse(txtUlog.Text);

            }

            Controllers.BrPoena = Int32.Parse(txtPoeni.Text);
            Controllers.PodeliKarte(Int32.Parse(txtUlog.Text));
            

            FormKarte fK = new FormKarte(Controllers,PrethodniPoeni);

            fK.Show();



        }

      private bool Validacija(TextBox tb)
        {
            if(String.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show("Popunite sva polja", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

       

        private void btnKarta_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPoeni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoeni_Validating(object sender, CancelEventArgs e)
        {
            //    if(String.IsNullOrEmpty(txtPoeni.Text))
            //    {
            //        e.Cancel = true;
            //        txtPoeni.Focus();
            //        errorProvider1.SetError(txtPoeni, "Unesite poene!");
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //        errorProvider1.SetError(txtPoeni, null);
            //    }
        }

    private void txtUlog_Validating(object sender, CancelEventArgs e)
    {

    //    if (String.IsNullOrEmpty(txtUlog.Text))
    //    {
    //        e.Cancel = true;
    //        txtPoeni.Focus();
    //        errorProvider1.SetError(txtPoeni, "Unesite ulog!");
    //    }
    //    else
    //    {
    //        e.Cancel = true;
    //        errorProvider1.SetError(txtUlog, null);
    //    }
    }

        private void txtPoeni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUlog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void rbtnTexasHoldem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbxVrstaSpila_Enter(object sender, EventArgs e)
        {

        }
    }
}
