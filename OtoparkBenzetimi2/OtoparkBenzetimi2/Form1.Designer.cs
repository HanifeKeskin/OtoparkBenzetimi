namespace OtoparkBenzetimi2
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
            this.lblOtoparkAdi = new System.Windows.Forms.Label();
            this.lblTurSayisi = new System.Windows.Forms.Label();
            this.txtTurSayisi = new System.Windows.Forms.TextBox();
            this.btnSecilenListele = new System.Windows.Forms.Button();
            this.lblGirisListesi = new System.Windows.Forms.Label();
            this.lblSecilenListe = new System.Windows.Forms.Label();
            this.lstGirisListesi = new System.Windows.Forms.ListBox();
            this.lstSecilenListe = new System.Windows.Forms.ListBox();
            this.btnGirisListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtoparkAdi
            // 
            this.lblOtoparkAdi.AutoSize = true;
            this.lblOtoparkAdi.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtoparkAdi.ForeColor = System.Drawing.Color.Red;
            this.lblOtoparkAdi.Location = new System.Drawing.Point(196, -6);
            this.lblOtoparkAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtoparkAdi.Name = "lblOtoparkAdi";
            this.lblOtoparkAdi.Size = new System.Drawing.Size(294, 57);
            this.lblOtoparkAdi.TabIndex = 0;
            this.lblOtoparkAdi.Text = "ONAN OTOPARK";
            // 
            // lblTurSayisi
            // 
            this.lblTurSayisi.AutoSize = true;
            this.lblTurSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblTurSayisi.Location = new System.Drawing.Point(146, 83);
            this.lblTurSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurSayisi.Name = "lblTurSayisi";
            this.lblTurSayisi.Size = new System.Drawing.Size(206, 20);
            this.lblTurSayisi.TabIndex = 1;
            this.lblTurSayisi.Text = "TUR SAYISINI GİRİNİZ:";
            // 
            // txtTurSayisi
            // 
            this.txtTurSayisi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTurSayisi.Location = new System.Drawing.Point(366, 85);
            this.txtTurSayisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTurSayisi.Name = "txtTurSayisi";
            this.txtTurSayisi.Size = new System.Drawing.Size(111, 20);
            this.txtTurSayisi.TabIndex = 2;
            // 
            // btnSecilenListele
            // 
            this.btnSecilenListele.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSecilenListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenListele.ForeColor = System.Drawing.Color.Red;
            this.btnSecilenListele.Location = new System.Drawing.Point(461, 412);
            this.btnSecilenListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSecilenListele.Name = "btnSecilenListele";
            this.btnSecilenListele.Size = new System.Drawing.Size(161, 45);
            this.btnSecilenListele.TabIndex = 3;
            this.btnSecilenListele.Text = "LİSTELE";
            this.btnSecilenListele.UseVisualStyleBackColor = false;
            this.btnSecilenListele.Click += new System.EventHandler(this.btnSecilenListele_Click);
            // 
            // lblGirisListesi
            // 
            this.lblGirisListesi.AutoSize = true;
            this.lblGirisListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisListesi.ForeColor = System.Drawing.Color.Red;
            this.lblGirisListesi.Location = new System.Drawing.Point(37, 135);
            this.lblGirisListesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisListesi.Name = "lblGirisListesi";
            this.lblGirisListesi.Size = new System.Drawing.Size(188, 18);
            this.lblGirisListesi.TabIndex = 4;
            this.lblGirisListesi.Text = "Giriş Yapan Araç Listesi\r\n";
            // 
            // lblSecilenListe
            // 
            this.lblSecilenListe.AutoSize = true;
            this.lblSecilenListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenListe.ForeColor = System.Drawing.Color.Red;
            this.lblSecilenListe.Location = new System.Drawing.Point(418, 135);
            this.lblSecilenListe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecilenListe.Name = "lblSecilenListe";
            this.lblSecilenListe.Size = new System.Drawing.Size(204, 18);
            this.lblSecilenListe.TabIndex = 5;
            this.lblSecilenListe.Text = "Seçilen Turda Araç Listesi";
            // 
            // lstGirisListesi
            // 
            this.lstGirisListesi.FormattingEnabled = true;
            this.lstGirisListesi.Location = new System.Drawing.Point(-1, 157);
            this.lstGirisListesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstGirisListesi.Name = "lstGirisListesi";
            this.lstGirisListesi.Size = new System.Drawing.Size(272, 251);
            this.lstGirisListesi.TabIndex = 6;
            // 
            // lstSecilenListe
            // 
            this.lstSecilenListe.FormattingEnabled = true;
            this.lstSecilenListe.Location = new System.Drawing.Point(375, 157);
            this.lstSecilenListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSecilenListe.Name = "lstSecilenListe";
            this.lstSecilenListe.Size = new System.Drawing.Size(272, 251);
            this.lstSecilenListe.TabIndex = 7;
            // 
            // btnGirisListe
            // 
            this.btnGirisListe.BackColor = System.Drawing.SystemColors.Menu;
            this.btnGirisListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisListe.ForeColor = System.Drawing.Color.Red;
            this.btnGirisListe.Location = new System.Drawing.Point(75, 412);
            this.btnGirisListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGirisListe.Name = "btnGirisListe";
            this.btnGirisListe.Size = new System.Drawing.Size(150, 45);
            this.btnGirisListe.TabIndex = 8;
            this.btnGirisListe.Text = "LİSTELE";
            this.btnGirisListe.UseVisualStyleBackColor = false;
            this.btnGirisListe.Click += new System.EventHandler(this.btnGirisListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 526);
            this.Controls.Add(this.btnGirisListe);
            this.Controls.Add(this.lstSecilenListe);
            this.Controls.Add(this.lstGirisListesi);
            this.Controls.Add(this.lblSecilenListe);
            this.Controls.Add(this.lblGirisListesi);
            this.Controls.Add(this.btnSecilenListele);
            this.Controls.Add(this.txtTurSayisi);
            this.Controls.Add(this.lblTurSayisi);
            this.Controls.Add(this.lblOtoparkAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "OTOPARK SİSTEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtoparkAdi;
        private System.Windows.Forms.Label lblTurSayisi;
        private System.Windows.Forms.TextBox txtTurSayisi;
        private System.Windows.Forms.Button btnSecilenListele;
        private System.Windows.Forms.Label lblGirisListesi;
        private System.Windows.Forms.Label lblSecilenListe;
        private System.Windows.Forms.ListBox lstGirisListesi;
        private System.Windows.Forms.ListBox lstSecilenListe;
        private System.Windows.Forms.Button btnGirisListe;
    }
}

