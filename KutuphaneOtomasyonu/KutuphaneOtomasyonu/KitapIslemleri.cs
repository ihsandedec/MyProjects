using BussinessLayer;//Başvuruları tanımlıyoruz
using EntityLayer;//Başvuruları tanımlıyoruz
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frm_KitapIslemleri : Form
    {
        public frm_KitapIslemleri()
        {
            InitializeComponent();
        }

        private void KitaplariListele()
        {
            // kitaplari database'den datagrid'e aktarma
            DG_kitap_Listesi.DataSource = BussinessUyeler.BLKitaplariListele();
        }
        private void frm_KitapIslemleri_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            //textboxların boşluk kontrolü
            if (txt_kitap_id.Text != "" && txt_kitap_adi.Text != "" && txt_kitap_basim_yili.Text != "" && txt_kitap_turu.Text != "" && txt_kitap_aciklama.Text != "" && txt_kitap_sayfa_sayisi.Text != "" && txt_kitap_adedi.Text != "")
            {
                //yeni bir kitap nesnesi oluşturma 
                EntityKitaplar yKitaplar = new EntityKitaplar()
                {
                    kitap_id = int.Parse(txt_kitap_id.Text),
                    kitap_adi = txt_kitap_adi.Text,
                    kitap_Basim_yili = txt_kitap_basim_yili.Text,
                    kitap_turu = txt_kitap_turu.Text,
                    kitap_aciklama = txt_kitap_aciklama.Text,
                    kitap_sayfa_sayisi = int.Parse(txt_kitap_sayfa_sayisi.Text),
                    kitap_adedi = int.Parse(txt_kitap_adedi.Text)
                };
                //oluşturulan ve içi doldurulan nesneyi database'e gönderme
                BussinessKitaplar.BLKitaplariEkle(yKitaplar);
                KitaplariListele();  //kitap listesini güncelleme
                //olumlu mesaj veriyoruz
                MessageBox.Show("Yeni Kitap Kaydı Başarılı...", "Kayıt İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Olumsuz mesaj veriliyor
                MessageBox.Show("Yeni Kitap Kaydı Başarısız...", "Kayıt İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kitap_sil_Click(object sender, EventArgs e)
        {
            //textboxların boşluk kontrolü
            if (txt_kitap_adi.Text != "" && txt_kitap_adi.Text != "" && txt_kitap_basim_yili.Text != "" && txt_kitap_turu.Text != "" && txt_kitap_aciklama.Text != "" && txt_kitap_sayfa_sayisi.Text != "" && txt_kitap_adedi.Text != "")
            {
                // Kontrolden sonra yeni bir doktor  nesnesi oluşturma
                EntityKitaplar yKitaplar = new EntityKitaplar()
                {
                    kitap_id = int.Parse(txt_kitap_id.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                BussinessKitaplar.BLKitaplariSil(yKitaplar);

                KitaplariListele();

                //Olumlu mesaj veriyoruz
                MessageBox.Show("Kitap Kaydı Silme Başarılı...", "Silme İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //olumsuz mesaj veriyoruz
                MessageBox.Show("Kitap Kaydı Silme Başarısız...", "Silme İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kitap_guncelle_Click(object sender, EventArgs e)
        {
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
                    kitap_adedi = int.Parse(txt_kitap_adedi.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BussinessKitaplar.BLKitaplariGuncelle(yKitaplar);

                //olumlu mesaj veriyoruz
                MessageBox.Show("kitap Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // kitap listesini güncelleme
                KitaplariListele();
            }
        }

        private void DG_kitap_Listesi_SelectionChanged(object sender, EventArgs e)
        {
            //datagridte seçilen satırdaki verileri textboxlara çekme
            txt_kitap_id.Text = DG_kitap_Listesi.CurrentRow.Cells[0].Value.ToString();
            txt_kitap_adi.Text = DG_kitap_Listesi.CurrentRow.Cells[1].Value.ToString();
            txt_kitap_basim_yili.Text = DG_kitap_Listesi.CurrentRow.Cells[2].Value.ToString();
            txt_kitap_turu.Text = DG_kitap_Listesi.CurrentRow.Cells[3].Value.ToString();
            txt_kitap_aciklama.Text = DG_kitap_Listesi.CurrentRow.Cells[4].Value.ToString();
            txt_kitap_sayfa_sayisi.Text = DG_kitap_Listesi.CurrentRow.Cells[5].Value.ToString();
            txt_kitap_adedi.Text = DG_kitap_Listesi.CurrentRow.Cells[6].Value.ToString();
        }

        private void txt_kitap_id_TextChanged(object sender, EventArgs e)
        {
            //txtbox boşluk kontrolü
            if (txt_kitap_id.Text != "")
            {
                try//hatalı girişi önlemek için try catch kullandım
                {
                    int kitap_id = int.Parse(txt_kitap_id.Text);

                    //aranan kitabı oluşturulan nesne içerisine alma
                    List<EntityKitaplar> CekilenKitaplar = BussinessKitaplar.BLKitaplariCek(kitap_id);

                    //arnan kitabı dah önce kiralayan kişileri nesne içerisine alma
                    List<EntityKitapEmanet> FiltreliKitap = BussinessKitapEmanet.BLKEmanetKitapFiltreli(kitap_id);

                    //aranan kitabı daha önce kiralayanları ayrı bir tabloya çekme
                    DG_Emanet_Tablosu.DataSource = FiltreliKitap;
                    //aranan kkitap bilgilerini textboxlara çekme
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
                //kitap kimlik bilgisi girilmemişse boş döndürme
                txt_kitap_adi.Text = "";
                txt_kitap_basim_yili.Text = "";
                txt_kitap_turu.Text = "";
                txt_kitap_aciklama.Text = "";
                txt_kitap_sayfa_sayisi.Text = "";
                txt_kitap_adedi.Text = "";
            }
        }
    }
}
