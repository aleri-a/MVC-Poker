namespace MVC_poker
{
    partial class FormKarte
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
            this.btnKarta1 = new System.Windows.Forms.Button();
            this.btnKarta3 = new System.Windows.Forms.Button();
            this.btnKarta2 = new System.Windows.Forms.Button();
            this.btnKarta4 = new System.Windows.Forms.Button();
            this.btnKarta5 = new System.Windows.Forms.Button();
            this.btnKraj = new System.Windows.Forms.Button();
            this.lblBrPoena = new System.Windows.Forms.Label();
            this.lblPrethodniPoeni = new System.Windows.Forms.Label();
            this.lblVrstPobede = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKarta1
            // 
            this.btnKarta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarta1.Location = new System.Drawing.Point(21, 118);
            this.btnKarta1.Name = "btnKarta1";
            this.btnKarta1.Size = new System.Drawing.Size(100, 147);
            this.btnKarta1.TabIndex = 0;
            this.btnKarta1.UseVisualStyleBackColor = true;
            this.btnKarta1.Click += new System.EventHandler(this.btnKarta1_Click);
            // 
            // btnKarta3
            // 
            this.btnKarta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarta3.Location = new System.Drawing.Point(233, 118);
            this.btnKarta3.Name = "btnKarta3";
            this.btnKarta3.Size = new System.Drawing.Size(100, 147);
            this.btnKarta3.TabIndex = 1;
            this.btnKarta3.UseVisualStyleBackColor = true;
            this.btnKarta3.Click += new System.EventHandler(this.btnKarta3_Click);
            // 
            // btnKarta2
            // 
            this.btnKarta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarta2.Location = new System.Drawing.Point(127, 118);
            this.btnKarta2.Name = "btnKarta2";
            this.btnKarta2.Size = new System.Drawing.Size(100, 147);
            this.btnKarta2.TabIndex = 2;
            this.btnKarta2.UseVisualStyleBackColor = true;
            this.btnKarta2.Click += new System.EventHandler(this.btnKarta2_Click);
            // 
            // btnKarta4
            // 
            this.btnKarta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarta4.Location = new System.Drawing.Point(339, 118);
            this.btnKarta4.Name = "btnKarta4";
            this.btnKarta4.Size = new System.Drawing.Size(100, 147);
            this.btnKarta4.TabIndex = 3;
            this.btnKarta4.UseVisualStyleBackColor = true;
            this.btnKarta4.Click += new System.EventHandler(this.btnKarta4_Click);
            // 
            // btnKarta5
            // 
            this.btnKarta5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarta5.Location = new System.Drawing.Point(445, 118);
            this.btnKarta5.Name = "btnKarta5";
            this.btnKarta5.Size = new System.Drawing.Size(100, 147);
            this.btnKarta5.TabIndex = 4;
            this.btnKarta5.UseVisualStyleBackColor = true;
            this.btnKarta5.Click += new System.EventHandler(this.btnKarta5_Click);
            // 
            // btnKraj
            // 
            this.btnKraj.Location = new System.Drawing.Point(21, 47);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(111, 40);
            this.btnKraj.TabIndex = 6;
            this.btnKraj.Text = "Kraj poteza";
            this.btnKraj.UseVisualStyleBackColor = true;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // lblBrPoena
            // 
            this.lblBrPoena.AutoSize = true;
            this.lblBrPoena.Location = new System.Drawing.Point(264, 47);
            this.lblBrPoena.Name = "lblBrPoena";
            this.lblBrPoena.Size = new System.Drawing.Size(49, 13);
            this.lblBrPoena.TabIndex = 7;
            this.lblBrPoena.Text = "br poena";
            // 
            // lblPrethodniPoeni
            // 
            this.lblPrethodniPoeni.AutoSize = true;
            this.lblPrethodniPoeni.Location = new System.Drawing.Point(264, 23);
            this.lblPrethodniPoeni.Name = "lblPrethodniPoeni";
            this.lblPrethodniPoeni.Size = new System.Drawing.Size(80, 13);
            this.lblPrethodniPoeni.TabIndex = 8;
            this.lblPrethodniPoeni.Text = "prethodni poeni";
            // 
            // lblVrstPobede
            // 
            this.lblVrstPobede.AutoSize = true;
            this.lblVrstPobede.Location = new System.Drawing.Point(264, 74);
            this.lblVrstPobede.Name = "lblVrstPobede";
            this.lblVrstPobede.Size = new System.Drawing.Size(69, 13);
            this.lblVrstPobede.TabIndex = 9;
            this.lblVrstPobede.Text = "vrsta pobede";
            // 
            // FormKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MVC_poker.Properties.Resources.deskGreen;
            this.ClientSize = new System.Drawing.Size(629, 305);
            this.Controls.Add(this.lblVrstPobede);
            this.Controls.Add(this.lblPrethodniPoeni);
            this.Controls.Add(this.lblBrPoena);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.btnKarta5);
            this.Controls.Add(this.btnKarta4);
            this.Controls.Add(this.btnKarta2);
            this.Controls.Add(this.btnKarta3);
            this.Controls.Add(this.btnKarta1);
            this.Name = "FormKarte";
            this.Text = "FormKarte";
            this.Load += new System.EventHandler(this.FormKarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKarta1;
        private System.Windows.Forms.Button btnKarta3;
        private System.Windows.Forms.Button btnKarta2;
        private System.Windows.Forms.Button btnKarta4;
        private System.Windows.Forms.Button btnKarta5;
        private System.Windows.Forms.Button btnKraj;
        private System.Windows.Forms.Label lblBrPoena;
        private System.Windows.Forms.Label lblPrethodniPoeni;
        private System.Windows.Forms.Label lblVrstPobede;
    }
}