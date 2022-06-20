namespace KutuphaneOtomasyonu
{
    partial class frm_OgrenciIslemleri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ogrID = new System.Windows.Forms.TextBox();
            this.txt_OgrBorcu = new System.Windows.Forms.TextBox();
            this.txt_OgrAdres = new System.Windows.Forms.TextBox();
            this.txt_OgrMail = new System.Windows.Forms.TextBox();
            this.txt_OgrTel = new System.Windows.Forms.TextBox();
            this.txt_OgrSoyadi = new System.Windows.Forms.TextBox();
            this.txt_OgrAdi = new System.Windows.Forms.TextBox();
            this.btn_ogrenci_guncelle = new System.Windows.Forms.Button();
            this.btn_ogrenci_sil = new System.Windows.Forms.Button();
            this.btn_ogrenci_ekle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DG_ogr_Listesi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ogr_Listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(269, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "₺";
            // 
            // txt_ogrID
            // 
            this.txt_ogrID.Location = new System.Drawing.Point(129, 26);
            this.txt_ogrID.Name = "txt_ogrID";
            this.txt_ogrID.Size = new System.Drawing.Size(153, 20);
            this.txt_ogrID.TabIndex = 55;
            this.txt_ogrID.TextChanged += new System.EventHandler(this.txt_ogrID_TextChanged);
            // 
            // txt_OgrBorcu
            // 
            this.txt_OgrBorcu.Location = new System.Drawing.Point(129, 290);
            this.txt_OgrBorcu.Name = "txt_OgrBorcu";
            this.txt_OgrBorcu.Size = new System.Drawing.Size(134, 20);
            this.txt_OgrBorcu.TabIndex = 51;
            // 
            // txt_OgrAdres
            // 
            this.txt_OgrAdres.Location = new System.Drawing.Point(129, 245);
            this.txt_OgrAdres.Name = "txt_OgrAdres";
            this.txt_OgrAdres.Size = new System.Drawing.Size(153, 20);
            this.txt_OgrAdres.TabIndex = 48;
            // 
            // txt_OgrMail
            // 
            this.txt_OgrMail.Location = new System.Drawing.Point(129, 202);
            this.txt_OgrMail.Name = "txt_OgrMail";
            this.txt_OgrMail.Size = new System.Drawing.Size(153, 20);
            this.txt_OgrMail.TabIndex = 47;
            this.txt_OgrMail.Validating += new System.ComponentModel.CancelEventHandler(this.txt_OgrMail_Validating);
            // 
            // txt_OgrTel
            // 
            this.txt_OgrTel.Location = new System.Drawing.Point(129, 158);
            this.txt_OgrTel.Name = "txt_OgrTel";
            this.txt_OgrTel.Size = new System.Drawing.Size(153, 20);
            this.txt_OgrTel.TabIndex = 46;
            this.txt_OgrTel.Validating += new System.ComponentModel.CancelEventHandler(this.txt_OgrTel_Validating);
            // 
            // txt_OgrSoyadi
            // 
            this.txt_OgrSoyadi.Location = new System.Drawing.Point(129, 114);
            this.txt_OgrSoyadi.Name = "txt_OgrSoyadi";
            this.txt_OgrSoyadi.Size = new System.Drawing.Size(153, 20);
            this.txt_OgrSoyadi.TabIndex = 45;
            // 
            // txt_OgrAdi
            // 
            this.txt_OgrAdi.Location = new System.Drawing.Point(129, 70);
            this.txt_OgrAdi.Name = "txt_OgrAdi";
            this.txt_OgrAdi.Size = new System.Drawing.Size(153, 20);
            this.txt_OgrAdi.TabIndex = 44;
            // 
            // btn_ogrenci_guncelle
            // 
            this.btn_ogrenci_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_ogrenci_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenci_guncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ogrenci_guncelle.Location = new System.Drawing.Point(35, 487);
            this.btn_ogrenci_guncelle.Name = "btn_ogrenci_guncelle";
            this.btn_ogrenci_guncelle.Size = new System.Drawing.Size(247, 51);
            this.btn_ogrenci_guncelle.TabIndex = 54;
            this.btn_ogrenci_guncelle.Text = "Öğrenci Güncelle";
            this.btn_ogrenci_guncelle.UseVisualStyleBackColor = false;
            this.btn_ogrenci_guncelle.Click += new System.EventHandler(this.btn_ogrenci_guncelle_Click);
            // 
            // btn_ogrenci_sil
            // 
            this.btn_ogrenci_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_ogrenci_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenci_sil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ogrenci_sil.Location = new System.Drawing.Point(35, 413);
            this.btn_ogrenci_sil.Name = "btn_ogrenci_sil";
            this.btn_ogrenci_sil.Size = new System.Drawing.Size(247, 51);
            this.btn_ogrenci_sil.TabIndex = 53;
            this.btn_ogrenci_sil.Text = "Öğrenci Sil";
            this.btn_ogrenci_sil.UseVisualStyleBackColor = false;
            this.btn_ogrenci_sil.Click += new System.EventHandler(this.btn_ogrenci_sil_Click);
            // 
            // btn_ogrenci_ekle
            // 
            this.btn_ogrenci_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_ogrenci_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenci_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ogrenci_ekle.Location = new System.Drawing.Point(35, 336);
            this.btn_ogrenci_ekle.Name = "btn_ogrenci_ekle";
            this.btn_ogrenci_ekle.Size = new System.Drawing.Size(247, 51);
            this.btn_ogrenci_ekle.TabIndex = 52;
            this.btn_ogrenci_ekle.Text = "Öğrenci Ekle";
            this.btn_ogrenci_ekle.UseVisualStyleBackColor = false;
            this.btn_ogrenci_ekle.Click += new System.EventHandler(this.btn_ogrenci_ekle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(56, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Öğrenci ID";
            // 
            // DG_ogr_Listesi
            // 
            this.DG_ogr_Listesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.DG_ogr_Listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ogr_Listesi.Location = new System.Drawing.Point(318, 26);
            this.DG_ogr_Listesi.Name = "DG_ogr_Listesi";
            this.DG_ogr_Listesi.RowHeadersWidth = 51;
            this.DG_ogr_Listesi.Size = new System.Drawing.Size(944, 512);
            this.DG_ogr_Listesi.TabIndex = 49;
            this.DG_ogr_Listesi.SelectionChanged += new System.EventHandler(this.DG_ogr_Listesi_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(39, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Öğrenci Borcu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(40, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Öğrenci Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Öğrenci Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Öğrenci Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Öğrenci Adı";
            // 
            // frm_OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1302, 564);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_ogrID);
            this.Controls.Add(this.txt_OgrBorcu);
            this.Controls.Add(this.txt_OgrAdres);
            this.Controls.Add(this.txt_OgrMail);
            this.Controls.Add(this.txt_OgrTel);
            this.Controls.Add(this.txt_OgrSoyadi);
            this.Controls.Add(this.txt_OgrAdi);
            this.Controls.Add(this.btn_ogrenci_guncelle);
            this.Controls.Add(this.btn_ogrenci_sil);
            this.Controls.Add(this.btn_ogrenci_ekle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DG_ogr_Listesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_OgrenciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.frm_OgrenciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ogr_Listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ogrID;
        private System.Windows.Forms.TextBox txt_OgrBorcu;
        private System.Windows.Forms.TextBox txt_OgrAdres;
        private System.Windows.Forms.TextBox txt_OgrMail;
        private System.Windows.Forms.TextBox txt_OgrTel;
        private System.Windows.Forms.TextBox txt_OgrSoyadi;
        private System.Windows.Forms.TextBox txt_OgrAdi;
        private System.Windows.Forms.Button btn_ogrenci_guncelle;
        private System.Windows.Forms.Button btn_ogrenci_sil;
        private System.Windows.Forms.Button btn_ogrenci_ekle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DG_ogr_Listesi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

