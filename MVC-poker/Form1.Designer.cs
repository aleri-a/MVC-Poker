namespace MVC_poker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.rbtnPoker = new System.Windows.Forms.RadioButton();
            this.txtPoeni = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbxVrstaIgre = new System.Windows.Forms.GroupBox();
            this.rbtnTexasHoldem = new System.Windows.Forms.RadioButton();
            this.gbxVrstaSpila = new System.Windows.Forms.GroupBox();
            this.rbtnMojSpil = new System.Windows.Forms.RadioButton();
            this.rbtnSpilFrancuski = new System.Windows.Forms.RadioButton();
            this.rbtnSpilStandardni = new System.Windows.Forms.RadioButton();
            this.txtUlog = new System.Windows.Forms.TextBox();
            this.lblUlog = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxVrstaIgre.SuspendLayout();
            this.gbxVrstaSpila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPoeni.Image = global::MVC_poker.Properties.Resources.crvena;
            this.lblPoeni.Location = new System.Drawing.Point(112, 133);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(40, 13);
            this.lblPoeni.TabIndex = 5;
            this.lblPoeni.Text = "Poeni: ";
            // 
            // rbtnPoker
            // 
            this.rbtnPoker.AutoSize = true;
            this.rbtnPoker.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.rbtnPoker.Location = new System.Drawing.Point(15, 19);
            this.rbtnPoker.Name = "rbtnPoker";
            this.rbtnPoker.Size = new System.Drawing.Size(53, 17);
            this.rbtnPoker.TabIndex = 6;
            this.rbtnPoker.TabStop = true;
            this.rbtnPoker.Text = "Poker";
            this.rbtnPoker.UseVisualStyleBackColor = true;
            // 
            // txtPoeni
            // 
            this.txtPoeni.Location = new System.Drawing.Point(158, 133);
            this.txtPoeni.Name = "txtPoeni";
            this.txtPoeni.Size = new System.Drawing.Size(100, 20);
            this.txtPoeni.TabIndex = 7;
            this.txtPoeni.TextChanged += new System.EventHandler(this.txtPoeni_TextChanged);
            this.txtPoeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoeni_KeyPress);
            this.txtPoeni.Validating += new System.ComponentModel.CancelEventHandler(this.txtPoeni_Validating);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(115, 222);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 51);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbxVrstaIgre
            // 
            this.gbxVrstaIgre.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.gbxVrstaIgre.Controls.Add(this.rbtnTexasHoldem);
            this.gbxVrstaIgre.Controls.Add(this.rbtnPoker);
            this.gbxVrstaIgre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxVrstaIgre.Location = new System.Drawing.Point(12, 12);
            this.gbxVrstaIgre.Name = "gbxVrstaIgre";
            this.gbxVrstaIgre.Size = new System.Drawing.Size(281, 50);
            this.gbxVrstaIgre.TabIndex = 9;
            this.gbxVrstaIgre.TabStop = false;
            this.gbxVrstaIgre.Text = "Vrsta igre";
            // 
            // rbtnTexasHoldem
            // 
            this.rbtnTexasHoldem.AutoSize = true;
            this.rbtnTexasHoldem.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.rbtnTexasHoldem.Location = new System.Drawing.Point(74, 19);
            this.rbtnTexasHoldem.Name = "rbtnTexasHoldem";
            this.rbtnTexasHoldem.Size = new System.Drawing.Size(94, 17);
            this.rbtnTexasHoldem.TabIndex = 7;
            this.rbtnTexasHoldem.TabStop = true;
            this.rbtnTexasHoldem.Text = "Texas hold’em";
            this.rbtnTexasHoldem.UseVisualStyleBackColor = true;
            this.rbtnTexasHoldem.CheckedChanged += new System.EventHandler(this.rbtnTexasHoldem_CheckedChanged);
            // 
            // gbxVrstaSpila
            // 
            this.gbxVrstaSpila.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.gbxVrstaSpila.Controls.Add(this.rbtnMojSpil);
            this.gbxVrstaSpila.Controls.Add(this.rbtnSpilFrancuski);
            this.gbxVrstaSpila.Controls.Add(this.rbtnSpilStandardni);
            this.gbxVrstaSpila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxVrstaSpila.Location = new System.Drawing.Point(58, 69);
            this.gbxVrstaSpila.Name = "gbxVrstaSpila";
            this.gbxVrstaSpila.Size = new System.Drawing.Size(308, 50);
            this.gbxVrstaSpila.TabIndex = 10;
            this.gbxVrstaSpila.TabStop = false;
            this.gbxVrstaSpila.Text = "Vrsta spila";
            this.gbxVrstaSpila.Enter += new System.EventHandler(this.gbxVrstaSpila_Enter);
            // 
            // rbtnMojSpil
            // 
            this.rbtnMojSpil.AutoSize = true;
            this.rbtnMojSpil.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.rbtnMojSpil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnMojSpil.Location = new System.Drawing.Point(193, 19);
            this.rbtnMojSpil.Name = "rbtnMojSpil";
            this.rbtnMojSpil.Size = new System.Drawing.Size(60, 17);
            this.rbtnMojSpil.TabIndex = 8;
            this.rbtnMojSpil.TabStop = true;
            this.rbtnMojSpil.Text = "Moj spil";
            this.rbtnMojSpil.UseVisualStyleBackColor = true;
            // 
            // rbtnSpilFrancuski
            // 
            this.rbtnSpilFrancuski.AutoSize = true;
            this.rbtnSpilFrancuski.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.rbtnSpilFrancuski.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSpilFrancuski.Location = new System.Drawing.Point(97, 19);
            this.rbtnSpilFrancuski.Name = "rbtnSpilFrancuski";
            this.rbtnSpilFrancuski.Size = new System.Drawing.Size(71, 17);
            this.rbtnSpilFrancuski.TabIndex = 7;
            this.rbtnSpilFrancuski.TabStop = true;
            this.rbtnSpilFrancuski.Text = "Francuski";
            this.rbtnSpilFrancuski.UseVisualStyleBackColor = true;
            // 
            // rbtnSpilStandardni
            // 
            this.rbtnSpilStandardni.AutoSize = true;
            this.rbtnSpilStandardni.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.rbtnSpilStandardni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSpilStandardni.Location = new System.Drawing.Point(6, 19);
            this.rbtnSpilStandardni.Name = "rbtnSpilStandardni";
            this.rbtnSpilStandardni.Size = new System.Drawing.Size(79, 17);
            this.rbtnSpilStandardni.TabIndex = 6;
            this.rbtnSpilStandardni.TabStop = true;
            this.rbtnSpilStandardni.Text = "Standardni ";
            this.rbtnSpilStandardni.UseVisualStyleBackColor = true;
            // 
            // txtUlog
            // 
            this.txtUlog.Location = new System.Drawing.Point(158, 162);
            this.txtUlog.Name = "txtUlog";
            this.txtUlog.Size = new System.Drawing.Size(100, 20);
            this.txtUlog.TabIndex = 12;
            this.txtUlog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUlog_KeyPress);
            this.txtUlog.Validating += new System.ComponentModel.CancelEventHandler(this.txtUlog_Validating);
            // 
            // lblUlog
            // 
            this.lblUlog.AutoSize = true;
            this.lblUlog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUlog.Image = global::MVC_poker.Properties.Resources.crvena;
            this.lblUlog.Location = new System.Drawing.Point(120, 165);
            this.lblUlog.Name = "lblUlog";
            this.lblUlog.Size = new System.Drawing.Size(32, 13);
            this.lblUlog.TabIndex = 13;
            this.lblUlog.Text = "Ulog:";
            this.lblUlog.Click += new System.EventHandler(this.lblUlog_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVC_poker.Properties.Resources.crvena;
            this.ClientSize = new System.Drawing.Size(378, 285);
            this.Controls.Add(this.lblUlog);
            this.Controls.Add(this.txtUlog);
            this.Controls.Add(this.gbxVrstaSpila);
            this.Controls.Add(this.gbxVrstaIgre);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPoeni);
            this.Controls.Add(this.lblPoeni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxVrstaIgre.ResumeLayout(false);
            this.gbxVrstaIgre.PerformLayout();
            this.gbxVrstaSpila.ResumeLayout(false);
            this.gbxVrstaSpila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.RadioButton rbtnPoker;
        private System.Windows.Forms.TextBox txtPoeni;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbxVrstaIgre;
        private System.Windows.Forms.RadioButton rbtnTexasHoldem;
        private System.Windows.Forms.GroupBox gbxVrstaSpila;
        private System.Windows.Forms.RadioButton rbtnSpilFrancuski;
        private System.Windows.Forms.RadioButton rbtnSpilStandardni;
        private System.Windows.Forms.TextBox txtUlog;
        private System.Windows.Forms.Label lblUlog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbtnMojSpil;
    }
}

