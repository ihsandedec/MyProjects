namespace KutuphaneOtomasyonu
{
    partial class frm_KitapIslemleri
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Emanet_Tablosu = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_kitap_adedi = new System.Windows.Forms.TextBox();
            this.btn_kitap_guncelle = new System.Windows.Forms.Button();
            this.btn_kitap_sil = new System.Windows.Forms.Button();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.DG_kitap_Listesi = new System.Windows.Forms.DataGridView();
            this.txt_kitap_sayfa_sayisi = new System.Windows.Forms.TextBox();
            this.txt_kitap_aciklama = new System.Windows.Forms.TextBox();
            this.txt_kitap_turu = new System.Windows.Forms.TextBox();
            this.txt_kitap_basim_yili = new System.Windows.Forms.TextBox();
            this.txt_kitap_adi = new System.Windows.Forms.TextBox();
            this.txt_kitap_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_kitap_Listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(328, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Seçili Kitabı Kiralayanlar Tablosu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(328, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Kitap Tablosu";
            // 
            // DG_Emanet_Tablosu
            // 
            this.DG_Emanet_Tablosu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.DG_Emanet_Tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Emanet_Tablosu.Location = new System.Drawing.Point(328, 358);
            this.DG_Emanet_Tablosu.Name = "DG_Emanet_Tablosu";
            this.DG_Emanet_Tablosu.RowHeadersWidth = 51;
            this.DG_Emanet_Tablosu.Size = new System.Drawing.Size(934, 201);
            this.DG_Emanet_Tablosu.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(47, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Kitap Adedi";
            // 
            // txt_kitap_adedi
            // 
            this.txt_kitap_adedi.Location = new System.Drawing.Point(125, 312);
            this.txt_kitap_adedi.Name = "txt_kitap_adedi";
            this.txt_kitap_adedi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_adedi.TabIndex = 67;
            // 
            // btn_kitap_guncelle
            // 
            this.btn_kitap_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_kitap_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_guncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kitap_guncelle.Location = new System.Drawing.Point(32, 508);
            this.btn_kitap_guncelle.Name = "btn_kitap_guncelle";
            this.btn_kitap_guncelle.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_guncelle.TabIndex = 66;
            this.btn_kitap_guncelle.Text = "Kitap Güncelle";
            this.btn_kitap_guncelle.UseVisualStyleBackColor = false;
            this.btn_kitap_guncelle.Click += new System.EventHandler(this.btn_kitap_guncelle_Click);
            // 
            // btn_kitap_sil
            // 
            this.btn_kitap_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_kitap_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_sil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kitap_sil.Location = new System.Drawing.Point(32, 434);
            this.btn_kitap_sil.Name = "btn_kitap_sil";
            this.btn_kitap_sil.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_sil.TabIndex = 65;
            this.btn_kitap_sil.Text = "Kitap Sil";
            this.btn_kitap_sil.UseVisualStyleBackColor = false;
            this.btn_kitap_sil.Click += new System.EventHandler(this.btn_kitap_sil_Click);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.btn_kitap_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kitap_ekle.Location = new System.Drawing.Point(32, 358);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_ekle.TabIndex = 64;
            this.btn_kitap_ekle.Text = "Kitap Ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = false;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // DG_kitap_Listesi
            // 
            this.DG_kitap_Listesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.DG_kitap_Listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_kitap_Listesi.Location = new System.Drawing.Point(328, 48);
            this.DG_kitap_Listesi.Name = "DG_kitap_Listesi";
            this.DG_kitap_Listesi.RowHeadersWidth = 51;
            this.DG_kitap_Listesi.Size = new System.Drawing.Size(934, 284);
            this.DG_kitap_Listesi.TabIndex = 63;
            this.DG_kitap_Listesi.SelectionChanged += new System.EventHandler(this.DG_kitap_Listesi_SelectionChanged);
            // 
            // txt_kitap_sayfa_sayisi
            // 
            this.txt_kitap_sayfa_sayisi.Location = new System.Drawing.Point(125, 268);
            this.txt_kitap_sayfa_sayisi.Name = "txt_kitap_sayfa_sayisi";
            this.txt_kitap_sayfa_sayisi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_sayfa_sayisi.TabIndex = 62;
            // 
            // txt_kitap_aciklama
            // 
            this.txt_kitap_aciklama.Location = new System.Drawing.Point(125, 224);
            this.txt_kitap_aciklama.Name = "txt_kitap_aciklama";
            this.txt_kitap_aciklama.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_aciklama.TabIndex = 61;
            // 
            // txt_kitap_turu
            // 
            this.txt_kitap_turu.Location = new System.Drawing.Point(125, 180);
            this.txt_kitap_turu.Name = "txt_kitap_turu";
            this.txt_kitap_turu.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_turu.TabIndex = 60;
            // 
            // txt_kitap_basim_yili
            // 
            this.txt_kitap_basim_yili.Location = new System.Drawing.Point(125, 136);
            this.txt_kitap_basim_yili.Name = "txt_kitap_basim_yili";
            this.txt_kitap_basim_yili.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_basim_yili.TabIndex = 59;
            // 
            // txt_kitap_adi
            // 
            this.txt_kitap_adi.Location = new System.Drawing.Point(125, 92);
            this.txt_kitap_adi.Name = "txt_kitap_adi";
            this.txt_kitap_adi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_adi.TabIndex = 58;
            // 
            // txt_kitap_id
            // 
            this.txt_kitap_id.Location = new System.Drawing.Point(125, 48);
            this.txt_kitap_id.Name = "txt_kitap_id";
            this.txt_kitap_id.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_id.TabIndex = 57;
            this.txt_kitap_id.TextChanged += new System.EventHandler(this.txt_kitap_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Kitap Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(52, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Kitap Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(32, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Kitap Açıklama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(31, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Kitap Basım Yılı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(59, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Kitap Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(64, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Kitap ID";
            // 
            // frm_KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1303, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Emanet_Tablosu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_kitap_adedi);
            this.Controls.Add(this.btn_kitap_guncelle);
            this.Controls.Add(this.btn_kitap_sil);
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.DG_kitap_Listesi);
            this.Controls.Add(this.txt_kitap_sayfa_sayisi);
            this.Controls.Add(this.txt_kitap_aciklama);
            this.Controls.Add(this.txt_kitap_turu);
            this.Controls.Add(this.txt_kitap_basim_yili);
            this.Controls.Add(this.txt_kitap_adi);
            this.Controls.Add(this.txt_kitap_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_KitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.frm_KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_kitap_Listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Emanet_Tablosu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_kitap_adedi;
        private System.Windows.Forms.Button btn_kitap_guncelle;
        private System.Windows.Forms.Button btn_kitap_sil;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private System.Windows.Forms.DataGridView DG_kitap_Listesi;
        private System.Windows.Forms.TextBox txt_kitap_sayfa_sayisi;
        private System.Windows.Forms.TextBox txt_kitap_aciklama;
        private System.Windows.Forms.TextBox txt_kitap_turu;
        private System.Windows.Forms.TextBox txt_kitap_basim_yili;
        private System.Windows.Forms.TextBox txt_kitap_adi;
        private System.Windows.Forms.TextBox txt_kitap_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}