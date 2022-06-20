using BussinessLayer;//Başvuruları ekliyoruz
using EntityLayer;//Başvuruları ekliyoruz
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
    public partial class frm_OgrenciIslemleri : Form
    {
        public frm_OgrenciIslemleri()
        {
            InitializeComponent();
        }

        private void UyeleriListele()
        {
            // uyeleri database'den datagrid'e aktarma
            DG_ogr_Listesi.DataSource = BussinessUyeler.BLUyeleriListele();
        }
        private void frm_OgrenciIslemleri_Load(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void btn_ogrenci_ekle_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol ediyoruz
            if (txt_OgrAdi.Text != "" && txt_OgrSoyadi.Text != "" && txt_OgrTel.Text != "" && txt_OgrMail.Text != "" && txt_OgrAdres.Text != "" && txt_OgrBorcu.Text != "")
            {
                // Kontrolden sonra yeni bir üye  nesnesi oluşturma
                EntityUyeler yUyeler = new EntityUyeler()
                {
                    uye_adi = txt_OgrAdi.Text,
                    uye_soyadi = txt_OgrSoyadi.Text,
                    uye_tel = txt_OgrTel.Text,
                    uye_mail = txt_OgrMail.Text,
                    uye_adres = txt_OgrAdres.Text,
                    uye_borcu = int.Parse(txt_OgrBorcu.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                BussinessUyeler.BLUyeleriEkle(yUyeler);

                UyeleriListele();// üye tablosunu listeleme
                MessageBox.Show("Yeni Öğrenci Kaydı Başarılı...", "Kayıt İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //Kullanıcıya başarız olduğunu söylüyoruz.
                MessageBox.Show("Yeni Öğrenci Kaydı Başarısız...", "Kayıt İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_ogr_Listesi_SelectionChanged(object sender, EventArgs e)
        {
            //üye tablosundaki seçili satırdaki veriyi txtboxlara doldurma
            txt_ogrID.Text = DG_ogr_Listesi.CurrentRow.Cells[0].Value.ToString();
            txt_OgrAdi.Text = DG_ogr_Listesi.CurrentRow.Cells[1].Value.ToString();
            txt_OgrSoyadi.Text = DG_ogr_Listesi.CurrentRow.Cells[2].Value.ToString();
            txt_OgrTel.Text = DG_ogr_Listesi.CurrentRow.Cells[3].Value.ToString();
            txt_OgrMail.Text = DG_ogr_Listesi.CurrentRow.Cells[4].Value.ToString();
            txt_OgrAdres.Text = DG_ogr_Listesi.CurrentRow.Cells[5].Value.ToString();
            txt_OgrBorcu.Text = DG_ogr_Listesi.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_ogrenci_sil_Click(object sender, EventArgs e)
        {
            if (txt_OgrAdi.Text != "" && txt_OgrSoyadi.Text != "" && txt_OgrTel.Text != "" && txt_OgrMail.Text != "" && txt_OgrAdres.Text != "" && txt_OgrBorcu.Text != "")
            {
                // Kontrolden sonra yeni bir üye  nesnesi oluşturma
                EntityUyeler yUyeler = new EntityUyeler()
                {
                    uye_id = int.Parse(txt_ogrID.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'e ekleme
                BussinessUyeler.BLUyeleriSil(yUyeler);

                UyeleriListele();//üye tablosunu listeleme
                MessageBox.Show("Öğrenci Kaydı Silme Başarılı...", "Silme İşlemi Başarılı ve Liste Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Öğrenci Kaydı Silme Başarısız...", "Silme İşlemi Başarılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ogrenci_guncelle_Click(object sender, EventArgs e)
        {
            // Kayıt olurken ilk olarak bütün textbox'ların dolu olduğunu kontrol etme
            if (txt_ogrID.Text != "" && txt_OgrAdi.Text != "" && txt_OgrSoyadi.Text != "" && txt_OgrTel.Text != "" && txt_OgrMail.Text != "" && txt_OgrAdres.Text != "" && txt_OgrBorcu.Text != "")
            {
                // Kontrolden sonra yeni bir üye  nesnesi oluşturma
                EntityUyeler yUyeler = new EntityUyeler()
                {
                    uye_id = int.Parse(txt_ogrID.Text),
                    uye_adi = txt_OgrAdi.Text,
                    uye_soyadi = txt_OgrSoyadi.Text,
                    uye_tel = txt_OgrTel.Text,
                    uye_mail = txt_OgrMail.Text,
                    uye_adres = txt_OgrAdres.Text,
                    uye_borcu = int.Parse(txt_OgrBorcu.Text)
                };

                // Oluşturulan ve içi doldurulan nesneyi database'de güncelleme
                BussinessUyeler.BLUyeleriGuncelle(yUyeler);

                MessageBox.Show("Öğrenci Güncelleme İşlemi Başarılı...", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Güncelleme sonrası datagrid güncelleme
                UyeleriListele();
            }
        }
        //değişkenleri global olarak tanımlıyoruz
        int yer_at_isareti, yer_nokta_isareti;

        private void txt_OgrMail_Validating(object sender, CancelEventArgs e)
        {
            //mail adresi için filtre oluşturma
            yer_at_isareti = txt_OgrMail.Text.IndexOf("@", 1);

            if (yer_at_isareti > 0)
            {
                yer_nokta_isareti = txt_OgrMail.Text.IndexOf(".", yer_at_isareti + 1);
            }
            if (yer_at_isareti < 0 || yer_nokta_isareti < 0)
            {
                MessageBox.Show("mail adresi yanlış girilmiştir. birisi@examlple.com şeklinde olmalıdır");
                e.Cancel = true;
            }
        }

        private void txt_ogrID_TextChanged(object sender, EventArgs e)
        {
            //textbox boluk kontrolü
            if (txt_ogrID.Text != "")
            {
                try//hatalı girişi önlemek için try catch kullandım
                {
                    int uye_id = int.Parse(txt_ogrID.Text);
                    //aranan üyenin nesnesini oluşturma ve içini doldurma
                    List<EntityUyeler> Cekilenuyeler = BussinessUyeler.BLUyeleriCek(uye_id);

                    //aranan üye bilgilerini textboxlara doldurma
                    txt_OgrAdi.Text = Cekilenuyeler[0].uye_adi;
                    txt_OgrSoyadi.Text = Cekilenuyeler[0].uye_soyadi;
                    txt_OgrTel.Text = Cekilenuyeler[0].uye_tel;
                    txt_OgrMail.Text = Cekilenuyeler[0].uye_mail;
                    txt_OgrAdres.Text = Cekilenuyeler[0].uye_adres;
                    txt_OgrBorcu.Text = Cekilenuyeler[0].uye_borcu.ToString();
                }
                catch (Exception)
                {//aranan üye database'de yoksa boş döndürme
                    txt_OgrAdi.Text = "";
                    txt_OgrSoyadi.Text = "";
                    txt_OgrTel.Text = "";
                    txt_OgrMail.Text = "";
                    txt_OgrAdres.Text = "";
                    txt_OgrBorcu.Text = "";
                }
            }
            else
            {//üye kimlik bilgisi girilmemişse boş döndürme
                txt_OgrAdi.Text = "";
                txt_OgrSoyadi.Text = "";
                txt_OgrTel.Text = "";
                txt_OgrMail.Text = "";
                txt_OgrAdres.Text = "";
                txt_OgrBorcu.Text = "";
            }
        }

        private void txt_OgrTel_Validating(object sender, CancelEventArgs e)
        {
            //telefon girişi için filre oluşturma
            if (txt_OgrTel.Text.Length != 10)
            {
                MessageBox.Show("Telefon numaranız 5452262486 şeklinde olmalıdır");
                e.Cancel = true;
            }
        }

    }
}
