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
    public partial class frm_kullanici_girisi : Form
    {
        public frm_kullanici_girisi()
        {
            InitializeComponent();
        }

        private void btn_kullanici_giris_Click(object sender, EventArgs e)
        {
            // Kullanıcı Adı ve şifre boşluk kontrolü
            if (txt_KullaniciAdi.Text != "" && txt_Sifre.Text != "")
            {
                // Kontrolden sonra yeni bir admin nesnesi oluşturma
                EntityPersonel yAdmin = new EntityPersonel()
                {
                    Personel_KullaniciAdi = txt_KullaniciAdi.Text,
                    Personel_Sifre = txt_Sifre.Text
                };

                //Oluşturulan nesneyi gönderip girişin doğruluğunu kontrol etme
                if (BussinessPersonel.BLAdminKontrolEt(yAdmin) == true)
                {
                    // Yeni Form Ekranına geçiş
                    frm_Menu menu = new frm_Menu();

                    menu.ShowDialog();//formu geçişsiz olarak gösterme
                }
                else
                {
                    //Olumlu mesaj veriliyor
                    MessageBox.Show("Giriş İşlemi Başarısız Oldu. Admin Kullanıcı Adı Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Olumsuz messaj veriliyor
                MessageBox.Show("Giriş İşlemi Başarısız Oldu. Admin Kullanıcı Adı Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz...", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Sifre_KeyDown(object sender, KeyEventArgs e)
        {
            //textbox'a şifreyi girdikten sonra enter tuşu ile butonun click eventini aktifleştirme
            if (e.KeyCode == Keys.Enter)
            {
                btn_kullanici_giris_Click(sender, e);
            }
        }
    }
}
