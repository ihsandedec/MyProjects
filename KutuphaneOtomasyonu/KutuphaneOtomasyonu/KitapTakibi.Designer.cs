namespace KutuphaneOtomasyonu
{
    partial class frm_KitapTakibi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_Emanet_Tablosu = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_kitap_adedi = new System.Windows.Forms.TextBox();
            this.txt_kitap_sayfa_sayisi = new System.Windows.Forms.TextBox();
            this.txt_kitap_aciklama = new System.Windows.Forms.TextBox();
            this.txt_kitap_turu = new System.Windows.Forms.TextBox();
            this.txt_kitap_basim_yili = new System.Windows.Forms.TextBox();
            this.txt_kitap_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kitap_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Kitap_Listesi = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Kitap_Listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(834, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Kitap Adetleri";
            // 
            // DG_Emanet_Tablosu
            // 
            this.DG_Emanet_Tablosu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.DG_Emanet_Tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Emanet_Tablosu.Location = new System.Drawing.Point(787, 11);
            this.DG_Emanet_Tablosu.Name = "DG_Emanet_Tablosu";
            this.DG_Emanet_Tablosu.RowHeadersWidth = 51;
            this.DG_Emanet_Tablosu.Size = new System.Drawing.Size(512, 299);
            this.DG_Emanet_Tablosu.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(39, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Kitap Adedi";
            // 
            // txt_kitap_adedi
            // 
            this.txt_kitap_adedi.Location = new System.Drawing.Point(115, 263);
            this.txt_kitap_adedi.Name = "txt_kitap_adedi";
            this.txt_kitap_adedi.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_adedi.TabIndex = 42;
            // 
            // txt_kitap_sayfa_sayisi
            // 
            this.txt_kitap_sayfa_sayisi.Location = new System.Drawing.Point(115, 224);
            this.txt_kitap_sayfa_sayisi.Name = "txt_kitap_sayfa_sayisi";
            this.txt_kitap_sayfa_sayisi.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_sayfa_sayisi.TabIndex = 41;
            // 
            // txt_kitap_aciklama
            // 
            this.txt_kitap_aciklama.Location = new System.Drawing.Point(115, 185);
            this.txt_kitap_aciklama.Name = "txt_kitap_aciklama";
            this.txt_kitap_aciklama.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_aciklama.TabIndex = 40;
            // 
            // txt_kitap_turu
            // 
            this.txt_kitap_turu.Location = new System.Drawing.Point(115, 146);
            this.txt_kitap_turu.Name = "txt_kitap_turu";
            this.txt_kitap_turu.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_turu.TabIndex = 39;
            // 
            // txt_kitap_basim_yili
            // 
            this.txt_kitap_basim_yili.Location = new System.Drawing.Point(114, 107);
            this.txt_kitap_basim_yili.Name = "txt_kitap_basim_yili";
            this.txt_kitap_basim_yili.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_basim_yili.TabIndex = 38;
            // 
            // txt_kitap_id
            // 
            this.txt_kitap_id.Location = new System.Drawing.Point(114, 29);
            this.txt_kitap_id.Name = "txt_kitap_id";
            this.txt_kitap_id.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_id.TabIndex = 36;
            this.txt_kitap_id.TextChanged += new System.EventHandler(this.txt_kitap_id_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_kitap_id);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_kitap_adedi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_kitap_sayfa_sayisi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_kitap_aciklama);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_kitap_turu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_kitap_basim_yili);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_kitap_adi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 299);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(55, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Kitap ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(51, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Kitap Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(22, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Kitap Basım Yılı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Kitap Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(44, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kitap Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(9, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kitap Sayfa Sayısı";
            // 
            // txt_kitap_adi
            // 
            this.txt_kitap_adi.Location = new System.Drawing.Point(114, 68);
            this.txt_kitap_adi.Name = "txt_kitap_adi";
            this.txt_kitap_adi.Size = new System.Drawing.Size(125, 19);
            this.txt_kitap_adi.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Genel Kitap Durum Bilgileri";
            // 
            // DG_Kitap_Listesi
            // 
            this.DG_Kitap_Listesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.DG_Kitap_Listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Kitap_Listesi.Location = new System.Drawing.Point(261, 11);
            this.DG_Kitap_Listesi.Name = "DG_Kitap_Listesi";
            this.DG_Kitap_Listesi.RowHeadersWidth = 51;
            this.DG_Kitap_Listesi.Size = new System.Drawing.Size(1038, 299);
            this.DG_Kitap_Listesi.TabIndex = 49;
            this.DG_Kitap_Listesi.SelectionChanged += new System.EventHandler(this.DG_Kitap_Listesi_SelectionChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(837, 357);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kitap Stoğu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(406, 367);
            this.chart1.TabIndex = 54;
            this.chart1.Text = "chart1";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(168)))));
            this.zedGraphControl1.Location = new System.Drawing.Point(22, 357);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(678, 367);
            this.zedGraphControl1.TabIndex = 55;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // frm_KitapTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_Emanet_Tablosu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Kitap_Listesi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_KitapTakibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Takibi";
            this.Load += new System.EventHandler(this.frm_KitapTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Kitap_Listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_Emanet_Tablosu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_kitap_adedi;
        private System.Windows.Forms.TextBox txt_kitap_sayfa_sayisi;
        private System.Windows.Forms.TextBox txt_kitap_aciklama;
        private System.Windows.Forms.TextBox txt_kitap_turu;
        private System.Windows.Forms.TextBox txt_kitap_basim_yili;
        private System.Windows.Forms.TextBox txt_kitap_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kitap_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Kitap_Listesi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}