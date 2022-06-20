using System;
using BussinessLayer;//Başvuruları tanımlıyoruz
using EntityLayer;//Başvuruları tanımlıyoruz
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;//ZegGraph özelliğini kullanmak için tanımlıyoruz

namespace KutuphaneOtomasyonu
{
    public partial class frm_KitapTakibi : Form
    {
        public frm_KitapTakibi()
        {
            InitializeComponent();
            KitaplariListele();//datagrid e kitap listesini çekme fonksiyonu
            KiradakiKitapSayisi();//Kiradaki kitapların sayısını hesaplayan fonksiyon
            CreateGraph(zedGraphControl1);//zedgraph fonks. nu çağırma
        }
        double ToplamKitap = 0, KiradakiKitaplar = 0, BostakiKitaplar = 0;// kiradaki kitapların değişkenleri
        private void KitaplariListele()
        {
            double adet;
            string kitap_adi;

            foreach (var series in chart1.Series)// chart tablosunun varsayılan değerleri temizlenir
            {
                series.Points.Clear();
            }

            // kitaplari database'den datagrid'e aktarma
            DG_Kitap_Listesi.DataSource = BussinessUyeler.BLKitaplariListele();
            for (int i = 0; i < DG_Kitap_Listesi.Rows.Count; i++)
            {
                kitap_adi = DG_Kitap_Listesi.Rows[i].Cells[1].Value.ToString();
                adet = double.Parse(DG_Kitap_Listesi.Rows[i].Cells[6].Value.ToString());
                ToplamKitap += adet;// toplam kitap adedi için
                chart1.Series["Kitap Stoğu"].Points.Add(adet);//adet değerlerini ekleme
                chart1.Series["Kitap Stoğu"].Points[i].AxisLabel = kitap_adi;//kitap isimlerini ekleme
                chart1.Series["Kitap Stoğu"].Points[i].Color = Color.Aqua;//sütunlara renk verme
            }

        }
        private void KiradakiKitapSayisi()// Tablodaki Her satır kadar kitap kirada olduğu için her satır 1 kiralık kitap demektir.
        {
            DG_Emanet_Tablosu.DataSource = BussinessKitapEmanet.BLKEmanetKitapListele();// datagrid e kiralanmış kitaplar çekilir
            KiradakiKitaplar = DG_Emanet_Tablosu.Rows.Count;//count komutuyla tüm kiralık kitaplar sayılır.
        }

        private void DG_Kitap_Listesi_SelectionChanged(object sender, EventArgs e)
        {
            //datagrid' ten veriler textbox lara çekilir
            txt_kitap_id.Text = DG_Kitap_Listesi.CurrentRow.Cells[0].Value.ToString();
            txt_kitap_adi.Text = DG_Kitap_Listesi.CurrentRow.Cells[1].Value.ToString();
            txt_kitap_basim_yili.Text = DG_Kitap_Listesi.CurrentRow.Cells[2].Value.ToString();
            txt_kitap_turu.Text = DG_Kitap_Listesi.CurrentRow.Cells[3].Value.ToString();
            txt_kitap_aciklama.Text = DG_Kitap_Listesi.CurrentRow.Cells[4].Value.ToString();
            txt_kitap_sayfa_sayisi.Text = DG_Kitap_Listesi.CurrentRow.Cells[5].Value.ToString();
            txt_kitap_adedi.Text = DG_Kitap_Listesi.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_kitap_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void CreateGraph(ZedGraphControl zg1)
        {
            BostakiKitaplar = ToplamKitap - KiradakiKitaplar;//kiralanmayan kitaplar, toplam kitap adedinden kiradaki kitaplar çıkartılarak bulunur
            GraphPane myPane = zg1.GraphPane;// mypane nesnesine zedgraph tablosu gönderilir

            myPane.Title.Text = "Kütüphane Kitap Durum Grafiği";// tablo başlığı, satır ve sütun başlığı tanımlanır
            myPane.XAxis.Title.Text = "Kitap Durumu";
            myPane.YAxis.Title.Text = "Kitap Sayısı";

            string[] labels = { "Toplam Kitap", "Kirada", "Hazırdaki Kitaplar" }; // tablonun labellerine değerler gönderilir

            double[] y = { ToplamKitap, KiradakiKitaplar, BostakiKitaplar, 0 };// tablodaki sütun verileri
            double[] y4 = { ToplamKitap, KiradakiKitaplar, BostakiKitaplar, 0 };//tablodaki çizgi verileri

            BarItem myBar = myPane.AddBar("Sütun", null, y, Color.Red);//tabloya sütun eklenir

            myBar.Bar.Fill = new Fill(Color.Blue, Color.White, Color.Blue); // sütunun içi doldurulur ve renk verilir

            LineItem myCurve = myPane.AddCurve("Çizgi", null, y4, Color.Black, SymbolType.Circle);//tabloya çizgi eklenir
            myCurve.Line.Fill = new Fill(Color.Red, Color.LightSkyBlue, -45F);// çizginin kalınlık ve altında kalan alan renklendirilir

            myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.White);
            myCurve.Line.Width = 2.0F;

            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zg1.AxisChange();
        }
        private void frm_KitapTakibi_Load(object sender, EventArgs e)
        {

        }
    }
}
