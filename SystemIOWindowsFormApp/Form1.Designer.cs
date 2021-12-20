
namespace SystemIOWindowsFormApp
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
            this.groupBoxPersonelListe = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonelDetay = new System.Windows.Forms.GroupBox();
            this.listBoxPersoneller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBoxPersonelListe.SuspendLayout();
            this.groupBoxPersonelDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonelListe
            // 
            this.groupBoxPersonelListe.Controls.Add(this.listBoxPersoneller);
            this.groupBoxPersonelListe.Location = new System.Drawing.Point(12, 25);
            this.groupBoxPersonelListe.Name = "groupBoxPersonelListe";
            this.groupBoxPersonelListe.Size = new System.Drawing.Size(285, 486);
            this.groupBoxPersonelListe.TabIndex = 0;
            this.groupBoxPersonelListe.TabStop = false;
            this.groupBoxPersonelListe.Text = "Personel Listesi";
            // 
            // groupBoxPersonelDetay
            // 
            this.groupBoxPersonelDetay.Controls.Add(this.txtAd);
            this.groupBoxPersonelDetay.Controls.Add(this.txtSoyad);
            this.groupBoxPersonelDetay.Controls.Add(this.txtEmail);
            this.groupBoxPersonelDetay.Controls.Add(this.txtUlke);
            this.groupBoxPersonelDetay.Controls.Add(this.txtFirma);
            this.groupBoxPersonelDetay.Controls.Add(this.label1);
            this.groupBoxPersonelDetay.Controls.Add(this.label2);
            this.groupBoxPersonelDetay.Controls.Add(this.label3);
            this.groupBoxPersonelDetay.Controls.Add(this.label4);
            this.groupBoxPersonelDetay.Controls.Add(this.label5);
            this.groupBoxPersonelDetay.Location = new System.Drawing.Point(323, 36);
            this.groupBoxPersonelDetay.Name = "groupBoxPersonelDetay";
            this.groupBoxPersonelDetay.Size = new System.Drawing.Size(445, 301);
            this.groupBoxPersonelDetay.TabIndex = 0;
            this.groupBoxPersonelDetay.TabStop = false;
            this.groupBoxPersonelDetay.Text = "Personel Detayları";
            // 
            // listBoxPersoneller
            // 
            this.listBoxPersoneller.FormattingEnabled = true;
            this.listBoxPersoneller.ItemHeight = 16;
            this.listBoxPersoneller.Location = new System.Drawing.Point(6, 43);
            this.listBoxPersoneller.Name = "listBoxPersoneller";
            this.listBoxPersoneller.Size = new System.Drawing.Size(273, 420);
            this.listBoxPersoneller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ülke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyisim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "İsim:";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(107, 174);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(311, 22);
            this.txtFirma.TabIndex = 6;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(107, 223);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(311, 22);
            this.txtUlke.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(107, 81);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(311, 22);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(311, 22);
            this.txtAd.TabIndex = 10;
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(18, 534);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(241, 60);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "PERSONEL GETİR";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(363, 374);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(378, 62);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "PERSONELİ BİLGİSAYARIMA KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBoxPersonelDetay);
            this.Controls.Add(this.groupBoxPersonelListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonelListe.ResumeLayout(false);
            this.groupBoxPersonelDetay.ResumeLayout(false);
            this.groupBoxPersonelDetay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonelListe;
        private System.Windows.Forms.ListBox listBoxPersoneller;
        private System.Windows.Forms.GroupBox groupBoxPersonelDetay;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnKaydet;
    }
}

