using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;//Başvuruları tanımlıyoruz
using EntityLayer;//Başvuruları tanımlıyoruz

namespace KutuphaneOtomasyonu
{
    public partial class frm_KitapVermeİslemi : Form
    {
        public frm_KitapVermeİslemi()
        {
            InitializeComponent();
        }

        private void EmanetleriListele()
        {
            double gecikme;
            DG_Emanet_Tablosu.DataSource = BussinessKitapEmanet.BLKEmanetKitapListele();//datagrid e kitaplar eklenir

            //kitap teslimi geciken kayıtların renklendirilmesi
            for (int i = 0; i < DG_Emanet_Tablosu.Rows.Count; i++)
            {
                DateTime bugun = DateTime.Today;
                DateTime iadeTarih = Convert.ToDateTime(DG_Emanet_Tablosu.Rows[i].Cells[4].Value);
                TimeSpan Sonuc = iadeTarih - bugun;
                gecikme = Sonuc.TotalDays;//gecikme iade tarihinden bugünün tarihinin farkı alınarak hesaplanır
                Application.DoEvents();
                // Math.DivRem(i, 2, out sayi);
                DataGridViewCellStyle renk = new DataGridViewCellStyle();// DataGridViewCellStyle'den stil nesnesi tanımlanır
                if (gecikme > 2)
                {
                    renk.BackColor = Color.White;//gecikme 2 günden büyükse kitanbın iade gününe yaklaşılmamıştır
                }
                else if (gecikme < 0)
                {
                    renk.BackColor = Color.Red; // gecikme 0 günden küçükse iade tarihi geçimiştir ve rengi kırmızı yapılır
                }
                else if (gecikme <= 2)
                {
                    renk.BackColor = Color.Yellow;// gecikme süresi 2 güne eşit veya küçükse iade tarihine yaklaşılıyor demektir ve sarı renge boyanır
                }
                DG_Emanet_Tablosu.Rows[i].DefaultCellStyle = renk;// her satırın rengi değiştirilir
            }

        }

        private void UyeleriListele()
        {
            // uyeleri database'den datagrid'e aktarma
            DG_Ogr_Tablosu.DataSource = BussinessUyeler.BLUyeleriListele();
        }
        private void KitaplariListele()
        {
            // kitaplari database'den datagrid'e aktarma
            DG_Kitap_Tablosu.DataSource = BussinessUyeler.BLKitaplariListele();
        }
        private void frm_KitapVermeİslemi_Load(object sender, EventArgs e)
        {
            DT_iade_tarihi.Value = DT_iade_tarihi.Value.AddDays(7);//default olarak iade tarihi teslim tarihinden 7 gün sonrasıdır
            EmanetleriListele();
            KitaplariListele();// form açıldığında Emanet, Kitap ve Uye Bilgileri databseden çekilir
            UyeleriListele();
        }

        private void DG_Ogr_Tablosu_SelectionChanged(object sender, EventArgs e)
        {
            //datagritten seçilen satırları click eventi ile textboxlara çekme
            txt_ogrID.Text = DG_Ogr_Tablosu.CurrentRow.Cells[0].Value.ToString();
            txt_eogrenci_id.Text = DG_Ogr_Tablosu.CurrentRow.Cells[0].Value.ToString();
            txt_OgrAdi.Text = DG_Ogr_Tablosu.CurrentRow.Cells[1].Value.ToString();
            txt_OgrSoyadi.Text = DG_Ogr_Tablosu.CurrentRow.Cells[2].Value.ToString();
            txt_OgrTel.Text = DG_Ogr_Tablosu.CurrentRow.Cells[3].Value.ToString();
            txt_OgrMail.Text = DG_Ogr_Tablosu.CurrentRow.Cells[4].Value.ToString();
            txt_OgrAdres.Text = DG_Ogr_Tablosu.CurrentRow.Cells[5].Value.ToString();
            txt_OgrBorcu.Text = DG_Ogr_Tablosu.CurrentRow.Cells[6].Value.ToString();
        }

        private void DG_Kitap_Tablosu_SelectionChanged(object sender, EventArgs e)
        {
            //datagritten seçilen satırları click eventi ile textboxlara çekme
            txt_kitap_id.Text = DG_Kitap_Tablosu.CurrentRow.Cells[0].Value.ToString();
            txt_ekitapID.Text = DG_Kitap_Tablosu.CurrentRow.Cells[0].Value.ToString();
            txt_kitap_adi.Text = DG_Kitap_Tablosu.CurrentRow.Cells[1].Value.ToString();
            txt_kitap_basim_yili.Text = DG_Kitap_Tablosu.CurrentRow.Cells[2].Value.ToString();
            txt_kitap_turu.Text = DG_Kitap_Tablosu.CurrentRow.Cells[3].Value.ToString();
            txt_kitap_aciklama.Text = DG_Kitap_Tablosu.CurrentRow.Cells[4].Value.ToString();
            txt_kitap_sayfa_sayisi.Text = DG_Kitap_Tablosu.CurrentRow.Cells[5].Value.ToString();
            txt_kitap_adedi.Text = DG_Kitap_Tablosu.CurrentRow.Cells[6].Value.ToString();
        }

        private void DG_Emanet_Tablosu_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void DG_Emanet_Tablosu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //datagritten seçilen satırları click eventi ile textboxlara doldurma
            txt_emanet_id.Text = DG_Emanet_Tablosu.CurrentRow.Cells[0].Value.ToString();
            txt_eogrenci_id.Text = DG_Emanet_Tablosu.CurrentRow.Cells[1].Value.ToString();
            txt_ekitapID.Text = DG_Emanet_Tablosu.CurrentRow.Cells[2].Value.ToString();
            DT_teslim_alma_tarihi.Value = Convert.ToDateTime(DG_Emanet_Tablosu.Rows[e.RowIndex].Cells[3].Value.ToString());
            DT_iade_tarihi.Value = Convert.ToDateTime(DG_Emanet_Tablosu.Rows[e.RowIndex].Cells[4].Value.ToString());
        }
        private void Kitapadetguncelle(int yeniadet)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_kitap_id.Text != "" && txt_kitap_adi.Text != "" && txt_kitap_basim_yili.Text != "" && txt_kitap_turu.Text != "" && txt_kitap_aciklama.Text != "" && txt_kitap_sayfa_sayisi.Text != "" && txt_kitap_adedi.Text != "")
            {
                // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                EntityKitaplar yKitaplar = new EntityKitaplar()
                {
                    kitap_id = int.Parse(txt_kitap_id.Text),
                    kitap_adi = txt_kitap_adi.Text,
                    kitap_Basim_yili = txt_kitap_basim_yili.Text,
                    kitap_turu = txt_kitap_turu.Text,
                    kitap_aciklama = txt_kitap_aciklama.Text,
                    kitap_sayfa_sayisi = int.Parse(txt_kitap_sayfa_sayisi.Text),
                    kitap_adedi = yeniadet
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BussinessKitaplar.BLKitaplariGuncelle(yKitaplar);

                //Olumlu mesaj veriyoruz
                MessageBox.Show("kitap Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası datagrid güncelleme
                KitaplariListele();
            }
        }
        private void uyeborcGuncelle(int uye_Borcu)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_ogrID.Text != "" && txt_OgrAdi.Text != "" && txt_OgrSoyadi.Text != "" && txt_OgrTel.Text != "" && txt_OgrMail.Text != "" && txt_OgrAdres.Text != "" && txt_OgrBorcu.Text != "")
            {
                // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                EntityUyeler yUyeler = new EntityUyeler()
                {
                    uye_id = int.Parse(txt_ogrID.Text),
                    uye_adi = txt_OgrAdi.Text,
                    uye_soyadi = txt_OgrSoyadi.Text,
                    uye_tel = txt_OgrTel.Text,
                    uye_mail = txt_OgrMail.Text,
                    uye_adres = txt_OgrAdres.Text,
                    uye_borcu = uye_Borcu
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BussinessUyeler.BLUyeleriGuncelle(yUyeler);

                //Olumlu mesaj veriyoruz
                MessageBox.Show("Öğrenci Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası datagrid güncelleme
                UyeleriListele();
            }
        }

        private void btn_KitapVer_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_ogrID.Text != "" && txt_kitap_id.Text != "" && DT_teslim_alma_tarihi.Value != null && DT_iade_tarihi.Value != null)
            {
                //kontrolden sonra emanet nesnesi oluşturma
                EntityKitapEmanet yEmanet = new EntityKitapEmanet()
                {
                    uye_id = int.Parse(txt_ogrID.Text),
                    kitap_id = int.Parse(txt_kitap_id.Text),
                    emanet_verme_tarihi = DT_teslim_alma_tarihi.Text,
                    emanet_alma_tarihi = DT_iade_tarihi.Text
                };
                //  Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                BussinessKitapEmanet.BLEmanetleriEkle(yEmanet);

                int kitap_adedi = int.Parse(txt_kitap_adedi.Text) - 1;// stoktan kitap adedi düşme
                Kitapadetguncelle(kitap_adedi);// güncellenen veriyi database'de güncelleme

                EmanetleriListele();//emanet tablonun güncellenmesi
                MessageBox.Show("Kitap Teslim Kaydı Başarılı...", "Kayıt İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //Olumsuz mesaj
                MessageBox.Show("Kitap Teslim Kaydı Başarısız...", "Kayıt İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kitap_iadeAl_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_emanet_id.Text != "" && txt_eogrenci_id.Text != "" && txt_ekitapID.Text != "" && DT_teslim_alma_tarihi.Value != null && DT_iade_tarihi.Value != null)
            {

                double uyeborcu, toplamborc, gecikme;//borc hesabı için değişken tanımlama
                int kitap_iade = int.Parse(txt_kitap_adedi.Text) + 1;// stoktaki kitap adedini güncelleme

                // gecikme nin gün olarak hesaplanmaası
                DateTime bugun = DateTime.Today;
                DateTime iadeTarih = Convert.ToDateTime(DG_Emanet_Tablosu.CurrentRow.Cells[4].Value);
                TimeSpan Sonuc = bugun - iadeTarih;

                gecikme = Sonuc.TotalDays;

                uyeborcu = int.Parse(txt_OgrBorcu.Text);
                toplamborc = uyeborcu + gecikme;

                // Güncelleme olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
                if (txt_kitap_id.Text != "" && txt_kitap_adi.Text != "" && txt_kitap_basim_yili.Text != "" && txt_kitap_turu.Text != "" && txt_kitap_aciklama.Text != "" && txt_kitap_sayfa_sayisi.Text != "" && txt_kitap_adedi.Text != "")
                {
                    Kitapadetguncelle(kitap_iade);// kitap güncelleme fonkisyonuna yeni değer ile birlikte database e verilr gönderilir
                }

                if (toplamborc != -1)// borc hesaba negatif olarak yanısmayacağı için kontrolden geçmesi gerekir konrolden geçerse
                {
                    uyeborcGuncelle(Convert.ToInt32(toplamborc));// database e değer gönderilerek güncellenir
                }
                //emanet nesnesi oluşturma
                EntityKitapEmanet yEmanet = new EntityKitapEmanet()
                {
                    emanet_id = int.Parse(txt_emanet_id.Text)
                };
                BussinessKitapEmanet.BLEmanetIadeAl(yEmanet);// nesne database e gönderilerek işlem yapılır tablodan veri silinir

                EmanetleriListele();//emanet tablosunu güncelleme
                MessageBox.Show("Kitap İade İşlemi Başarılı...", "İade İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Olumsuz mesaj
                MessageBox.Show("Kitap İade İşlemi Başarısız... Tablodan Bir kayıt Seçiniz", "İade İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();// form ekranını kapatma
        }

        private void txt_ogrID_TextChanged(object sender, EventArgs e)
        {
            //txtbox ın boşluk kontolü
            if (txt_ogrID.Text != "")
            {

                try//hatalı girişi önlemek için try catch kullandım
                {
                    int uye_id = int.Parse(txt_ogrID.Text);

                    //çağırılacak olan üye nesnesini oluşturma ve içine aran üyeyi ekleme
                    List<EntityUyeler> Cekilenuyeler = BussinessUyeler.BLUyeleriCek(uye_id);

                    //çağırılan üye bilgilerini texboxlara doldurma
                    txt_OgrAdi.Text = Cekilenuyeler[0].uye_adi;
                    txt_OgrSoyadi.Text = Cekilenuyeler[0].uye_soyadi;
                    txt_OgrTel.Text = Cekilenuyeler[0].uye_tel;
                    txt_OgrMail.Text = Cekilenuyeler[0].uye_mail;
                    txt_OgrAdres.Text = Cekilenuyeler[0].uye_adres;
                    txt_OgrBorcu.Text = Cekilenuyeler[0].uye_borcu.ToString();
                }
                //aranan üye databse de yoksa boş döndürme
                catch (Exception)
                {
                    txt_OgrAdi.Text = "";
                    txt_OgrSoyadi.Text = "";
                    txt_OgrTel.Text = "";
                    txt_OgrMail.Text = "";
                    txt_OgrAdres.Text = "";
                    txt_OgrBorcu.Text = "";
                }
            }
            else
            {
                //id bilgisi girilmemişse boş döndürme
                txt_OgrAdi.Text = "";
                txt_OgrSoyadi.Text = "";
                txt_OgrTel.Text = "";
                txt_OgrMail.Text = "";
                txt_OgrAdres.Text = "";
                txt_OgrBorcu.Text = "";
            }
            txt_eogrenci_id.Text = txt_ogrID.Text;// öğrenci kimlik bilgisini otomatik olarak emanet txtbox' a ekleme
        }

        private void DT_teslim_alma_tarihi_ValueChanged(object sender, EventArgs e)
        {
            /*teslim verilme tarihindeki datetimepicker'ın değeri değiştirildiğinde iade tarihinin 
            otomatik olarak gelecek haftanın tarihi seçilmesi*/
            DT_iade_tarihi.Value = DT_teslim_alma_tarihi.Value.AddDays(7);
        }

        private void txt_kitap_id_TextChanged(object sender, EventArgs e)
        {
            //txtbox boşluk kontrolü
            if (txt_kitap_id.Text != "")
            {
                try//hatalı girişi önlemek için try catch kullandım
                {
                    int kitap_id = int.Parse(txt_kitap_id.Text);

                    //aranan kitap için nesne oluşturma ve içine aranan kitabı ekleme
                    List<EntityKitaplar> CekilenKitaplar = BussinessKitaplar.BLKitaplariCek(kitap_id);

                    //aranan kitabın bilgilerini txtboxlara getirme
                    txt_kitap_adi.Text = CekilenKitaplar[0].kitap_adi;
                    txt_kitap_basim_yili.Text = CekilenKitaplar[0].kitap_Basim_yili;
                    txt_kitap_turu.Text = CekilenKitaplar[0].kitap_turu;
                    txt_kitap_aciklama.Text = CekilenKitaplar[0].kitap_aciklama;
                    txt_kitap_sayfa_sayisi.Text = CekilenKitaplar[0].kitap_sayfa_sayisi.ToString();
                    txt_kitap_adedi.Text = CekilenKitaplar[0].kitap_adedi.ToString();
                }
                catch (Exception)
                { 
                    //aranan kitap yoksa boş döndürme
                    txt_kitap_adi.Text = "";
                    txt_kitap_basim_yili.Text = "";
                    txt_kitap_turu.Text = "";
                    txt_kitap_aciklama.Text = "";
                    txt_kitap_sayfa_sayisi.Text = "";
                    txt_kitap_adedi.Text = "";
                }
            }
            else
            {
                //id bilgisi girilmemişse boş döndürme
                txt_kitap_adi.Text = "";
                txt_kitap_basim_yili.Text = "";
                txt_kitap_turu.Text = "";
                txt_kitap_aciklama.Text = "";
                txt_kitap_sayfa_sayisi.Text = "";
                txt_kitap_adedi.Text = "";
            }
            txt_ekitapID.Text = txt_kitap_id.Text;// kitap id bilgisi emanet tablosuna gönderilme
        }

        private void txt_emanet_id_TextChanged(object sender, EventArgs e)
        {
            //txtbox boşluk kontrolü
            if (txt_emanet_id.Text != "")
            {
                try//hatalı girişi önlemek için try catch kullandım
                {
                    int emanetID = int.Parse(txt_emanet_id.Text);

                    //aranan emanet için nense oluşturma ve içine aranan veriyi ekleme
                    List<EntityKitapEmanet> Cekilenemanetler = BussinessKitapEmanet.BLKEmanetKitapCek(emanetID);

                    //aranan emanet bilgilerini txtboxlara doldurma
                    txt_eogrenci_id.Text = Cekilenemanetler[0].uye_id.ToString();
                    txt_ekitapID.Text = Cekilenemanetler[0].kitap_id.ToString();
                    DT_teslim_alma_tarihi.Value = Convert.ToDateTime(Cekilenemanetler[0].emanet_verme_tarihi);
                    DT_iade_tarihi.Value = Convert.ToDateTime(Cekilenemanetler[0].emanet_alma_tarihi);
                }
                catch (Exception)
                {
                    //aranan emanet bilgisi yoksa boş döndürme
                    txt_eogrenci_id.Text = "";
                    txt_ekitapID.Text = "";
                    DT_teslim_alma_tarihi.Value = DateTime.Today;
                    DT_iade_tarihi.Value = DateTime.Today;
                }
            }
            else
            {
                //emanet kimlik bilgisi girilmemişse boş döndürme
                txt_eogrenci_id.Text = "";
                txt_ekitapID.Text = "";
                DT_teslim_alma_tarihi.Value = DateTime.Today;// datetimepicker'ın değeri bugünün değeri olarak değiştirilmesi
                DT_iade_tarihi.Value = DateTime.Today;//
            }
        }
    }
}
