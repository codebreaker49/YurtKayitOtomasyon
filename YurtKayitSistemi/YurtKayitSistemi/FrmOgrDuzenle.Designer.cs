namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.mskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOgrenciBolumu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskOgrDogTar = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID:";
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrenciSoyadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(354, -51);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(260, 30);
            this.txtOgrenciSoyadi.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, -45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci Soyadı:";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrenciAdi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAdi.Location = new System.Drawing.Point(354, -96);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(260, 30);
            this.txtOgrenciAdi.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(227, -90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Öğrenci Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 591);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(89, 672);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(187, 51);
            this.btnGuncelle.TabIndex = 51;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // mskVeliTel
            // 
            this.mskVeliTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskVeliTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTel.Location = new System.Drawing.Point(206, 502);
            this.mskVeliTel.Mask = "(999) 000-0000";
            this.mskVeliTel.Name = "mskVeliTel";
            this.mskVeliTel.Size = new System.Drawing.Size(259, 30);
            this.mskVeliTel.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(133, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Adres:";
            // 
            // rchAdres
            // 
            this.rchAdres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdres.Location = new System.Drawing.Point(207, 548);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(260, 119);
            this.rchAdres.TabIndex = 48;
            this.rchAdres.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(75, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Veli Telefon:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(205, 457);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(260, 30);
            this.txtVeliAdSoyad.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(49, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Veli Adı Soyadı:";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(206, 410);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(259, 32);
            this.cmbOdaNo.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(116, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Oda No:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(205, 365);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(260, 30);
            this.txtMail.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(142, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mail:";
            // 
            // cmbOgrenciBolumu
            // 
            this.cmbOgrenciBolumu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOgrenciBolumu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrenciBolumu.FormattingEnabled = true;
            this.cmbOgrenciBolumu.Location = new System.Drawing.Point(207, 318);
            this.cmbOgrenciBolumu.Name = "cmbOgrenciBolumu";
            this.cmbOgrenciBolumu.Size = new System.Drawing.Size(259, 32);
            this.cmbOgrenciBolumu.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Öğrenci Bölümü:";
            // 
            // mskOgrDogTar
            // 
            this.mskOgrDogTar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrDogTar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrDogTar.Location = new System.Drawing.Point(206, 273);
            this.mskOgrDogTar.Mask = "00/00/0000";
            this.mskOgrDogTar.Name = "mskOgrDogTar";
            this.mskOgrDogTar.Size = new System.Drawing.Size(259, 30);
            this.mskOgrDogTar.TabIndex = 38;
            this.mskOgrDogTar.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // mskOgrTelefon
            // 
            this.mskOgrTelefon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrTelefon.Location = new System.Drawing.Point(206, 227);
            this.mskOgrTelefon.Mask = "(999) 000-0000";
            this.mskOgrTelefon.Name = "mskOgrTelefon";
            this.mskOgrTelefon.Size = new System.Drawing.Size(259, 30);
            this.mskOgrTelefon.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefon:";
            // 
            // mskOgrTC
            // 
            this.mskOgrTC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mskOgrTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrTC.Location = new System.Drawing.Point(206, 180);
            this.mskOgrTC.Mask = "00000000000";
            this.mskOgrTC.Name = "mskOgrTC";
            this.mskOgrTC.Size = new System.Drawing.Size(259, 30);
            this.mskOgrTC.TabIndex = 34;
            this.mskOgrTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(158, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "TC:";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(206, 127);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(260, 30);
            this.txtOgrSoyad.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(50, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 24);
            this.label14.TabIndex = 31;
            this.label14.Text = "Öğrenci Soyadı:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(206, 82);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(260, 30);
            this.txtOgrAd.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(79, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Öğrenci Adı:";
            // 
            // txtOgrID
            // 
            this.txtOgrID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOgrID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrID.Location = new System.Drawing.Point(207, 39);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(260, 30);
            this.txtOgrID.TabIndex = 53;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(308, 672);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 51);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(507, 735);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtOgrID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.mskVeliTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOgrenciBolumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskOgrDogTar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskOgrTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskOgrTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtOgrenciSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrDuzenle";
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MaskedTextBox mskVeliTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOgrenciBolumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskOgrDogTar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskOgrTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskOgrTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Button btnSil;
    }
}