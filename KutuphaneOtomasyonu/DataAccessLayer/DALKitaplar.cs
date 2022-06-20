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
    public class DALKitaplar
    {
        public static List<EntityKitaplar> KitaplariListele()
        {
            // tbl_kitaplar tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_kitaplar", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKitaplar> Kitaplar = new List<EntityKitaplar>();

            while (dr.Read())
            {
                // Her kitabın birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Kitaplar.Add(new EntityKitaplar
                {
                    kitap_id = int.Parse(dr["kitap_id"].ToString()),
                    kitap_adi = dr["kitap_adi"].ToString(),
                    kitap_Basim_yili = dr["kitap_basim_yili"].ToString(),
                    kitap_turu = dr["kitap_turu"].ToString(),
                    kitap_aciklama = dr["kitap_aciklama"].ToString(),
                    kitap_sayfa_sayisi = int.Parse(dr["kitap_sayfa_sayisi"].ToString()),
                    kitap_adedi = int.Parse(dr["kitap_adedi"].ToString()),
                });
            }

            return Kitaplar; // Nesneleri içinde tutan listeyi geri döndürme

        }

        public static List<EntityKitaplar> DALKitaplariCek(int id)
        {
            // tbl_kitaplar tablosundan id bilgisi girilen veriyi çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_kitaplar where kitap_id= " + id + "", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKitaplar> Kitaplar = new List<EntityKitaplar>();

            while (dr.Read())
            {
                // Her kitabı birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Kitaplar.Add(new EntityKitaplar
                {
                    kitap_id = int.Parse(dr["kitap_id"].ToString()),
                    kitap_adi = dr["kitap_adi"].ToString(),
                    kitap_Basim_yili = dr["kitap_basim_yili"].ToString(),
                    kitap_turu = dr["kitap_turu"].ToString(),
                    kitap_aciklama = dr["kitap_aciklama"].ToString(),
                    kitap_sayfa_sayisi = int.Parse(dr["kitap_sayfa_sayisi"].ToString()),
                    kitap_adedi = int.Parse(dr["kitap_adedi"].ToString()),
                });
            }

            return Kitaplar; // Nesneleri içinde tutan listeyi geri döndürme

        }

        public static int DALKitaplariGuncelle(EntityKitaplar gKitaplar)
        {
            // Kitap işlemleri Form ekranından gelen bilgilerli güncelleme
            OleDbCommand cmd = new OleDbCommand("Update tbl_kitaplar set kitap_adi= @kitap_adi, kitap_basim_yili= @kitap_basim_yili, kitap_turu= @kitap_turu, kitap_aciklama= @kitap_aciklama, kitap_sayfa_sayisi=@kitap_sayfa_sayisi, kitap_adedi=@kitap_adedi where kitap_id=@kitap_id", Baglanti.conn);
            //Gelen bilgiler ile update komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@kitap_adi", gKitaplar.kitap_adi);
            cmd.Parameters.AddWithValue("@kitap_basim_yili", gKitaplar.kitap_Basim_yili);
            cmd.Parameters.AddWithValue("@kitap_turu", gKitaplar.kitap_turu);
            cmd.Parameters.AddWithValue("@kitap_aciklama", gKitaplar.kitap_aciklama);
            cmd.Parameters.AddWithValue("@kitap_sayfa_sayisi", gKitaplar.kitap_sayfa_sayisi);
            cmd.Parameters.AddWithValue("@kitap_adedi", gKitaplar.kitap_adedi);
            cmd.Parameters.AddWithValue("@kitap_id", gKitaplar.kitap_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static int DALKitaplariEkle(EntityKitaplar gKitaplar)
        {
            // Kitap işlemleri Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into tbl_kitaplar(kitap_adi,kitap_basim_yili,kitap_turu,kitap_aciklama,kitap_sayfa_sayisi,kitap_adedi) Values(@kitap_adi,@kitap_basim_yili,@kitap_turu,@kitap_aciklama,@kitap_sayfa_sayisi,@kitap_adedi)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@kitap_adi", gKitaplar.kitap_adi);
            cmd.Parameters.AddWithValue("@kitap_basim_yili", gKitaplar.kitap_Basim_yili);
            cmd.Parameters.AddWithValue("@kitap_turu", gKitaplar.kitap_turu);
            cmd.Parameters.AddWithValue("@kitap_aciklama", gKitaplar.kitap_aciklama);
            cmd.Parameters.AddWithValue("@kitap_sayfa_sayisi", gKitaplar.kitap_sayfa_sayisi);
            cmd.Parameters.AddWithValue("@kitap_adedi", gKitaplar.kitap_adedi);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static int DALKitaplariSil(EntityKitaplar gKitaplar)
        {
            // Kitap işlemleri Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From tbl_kitaplar Where kitap_id = @kitap_id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@kitap_id", gKitaplar.kitap_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
    }
}
