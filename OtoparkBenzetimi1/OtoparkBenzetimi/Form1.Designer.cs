namespace OtoparkBenzetimi
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
            this.cmbKuyrukTipi = new System.Windows.Forms.ComboBox();
            this.lblKuyrukTipi = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.lstListele = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOtoparkAdi
            // 
            this.lblOtoparkAdi.AutoSize = true;
            this.lblOtoparkAdi.Font = new System.Drawing.Font("Vladimir Script", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtoparkAdi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblOtoparkAdi.Location = new System.Drawing.Point(24, 7);
            this.lblOtoparkAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtoparkAdi.Name = "lblOtoparkAdi";
            this.lblOtoparkAdi.Size = new System.Drawing.Size(322, 46);
            this.lblOtoparkAdi.TabIndex = 0;
            this.lblOtoparkAdi.Text = "ONAN OTOPARK";
            // 
            // cmbKuyrukTipi
            // 
            this.cmbKuyrukTipi.BackColor = System.Drawing.Color.LightGray;
            this.cmbKuyrukTipi.FormattingEnabled = true;
            this.cmbKuyrukTipi.Items.AddRange(new object[] {
            "Basit Kuyruk Yapısı",
            "Öncelikli Kuyruk Yapısı"});
            this.cmbKuyrukTipi.Location = new System.Drawing.Point(210, 102);
            this.cmbKuyrukTipi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKuyrukTipi.Name = "cmbKuyrukTipi";
            this.cmbKuyrukTipi.Size = new System.Drawing.Size(164, 21);
            this.cmbKuyrukTipi.TabIndex = 1;
            this.cmbKuyrukTipi.SelectedIndexChanged += new System.EventHandler(this.cmbKuyrukTipi_SelectedIndexChanged);
            // 
            // lblKuyrukTipi
            // 
            this.lblKuyrukTipi.AutoSize = true;
            this.lblKuyrukTipi.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuyrukTipi.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblKuyrukTipi.Location = new System.Drawing.Point(9, 95);
            this.lblKuyrukTipi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKuyrukTipi.Name = "lblKuyrukTipi";
            this.lblKuyrukTipi.Size = new System.Drawing.Size(194, 26);
            this.lblKuyrukTipi.TabIndex = 2;
            this.lblKuyrukTipi.Text = "Kuyruk Tipi Seçiniz:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LightGray;
            this.btnListele.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnListele.Location = new System.Drawing.Point(83, 162);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(202, 62);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lstListele
            // 
            this.lstListele.BackColor = System.Drawing.Color.LightGray;
            this.lstListele.FormattingEnabled = true;
            this.lstListele.Location = new System.Drawing.Point(-4, 249);
            this.lstListele.Margin = new System.Windows.Forms.Padding(2);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(581, 199);
            this.lstListele.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(581, 444);
            this.Controls.Add(this.lstListele);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblKuyrukTipi);
            this.Controls.Add(this.cmbKuyrukTipi);
            this.Controls.Add(this.lblOtoparkAdi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "OTOPARK SİSTEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtoparkAdi;
        private System.Windows.Forms.ComboBox cmbKuyrukTipi;
        private System.Windows.Forms.Label lblKuyrukTipi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lstListele;
    }
}

