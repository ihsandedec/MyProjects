using EntityLayer;//Başvuru tanımlama
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static bool AdminKontrolEt(EntityPersonel gPersonel)
        {
            // Admin giriş yap butonunda çalışan kod satırı ile Form ekranından Kullanici adı ve şifre geliyor.
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_personel Where personel_kullanici_adi = @personel_kullanici_adi And personel_sifre = @personel_sifre", Baglanti.conn);
            // Kullanici adi ve şifre gelen kişinin admin bilgilerini geri döndür.
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@personel_kullanici_adi", gPersonel.Personel_KullaniciAdi);
            cmd.Parameters.AddWithValue("@personel_sifre", gPersonel.Personel_Sifre);

            OleDbDataReader dr = cmd.ExecuteReader();
            bool Sonuc = false;
            int sayac = 0;

            while (dr.Read())
            {
                sayac++; //Eğer okunacak bir veri var ise sayacı arttır.
            }

            if (sayac > 0)
            {
                // eğer sayac 0'dan büyükse sonucu true yap
                Sonuc = true;
            }
            //Eğer true sonuc dönüyorsa. Gelen bilgilerle eşleşen admin var. Giriş yapabilir demektir.
            return Sonuc;
        }
    }
}
