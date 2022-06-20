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
    public class DALUyeler
    {
        public static int DALUyeleriEkle(EntityUyeler gUyeler)
        {
            // Üye işlemleri Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into tbl_uyeler(uye_adi,uye_soyadi,uye_tel,uye_mail,uye_adres,uye_borcu) Values(@uye_adi,@uye_soyadi,@uye_tel,@uye_mail,@uye_adres,@uye_borcu)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@uye_adi", gUyeler.uye_adi);
            cmd.Parameters.AddWithValue("@uye_soyadi", gUyeler.uye_soyadi);
            cmd.Parameters.AddWithValue("@uye_tel", gUyeler.uye_tel);
            cmd.Parameters.AddWithValue("@uye_mail", gUyeler.uye_mail);
            cmd.Parameters.AddWithValue("@uye_adres", gUyeler.uye_adres);
            cmd.Parameters.AddWithValue("@uye_borcu", gUyeler.uye_borcu);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static List<EntityUyeler> UyeleriListele()
        {
            // Uyeler tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_uyeler", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityUyeler> Uyeler = new List<EntityUyeler>();

            while (dr.Read())
            {
                // Her uyeyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Uyeler.Add(new EntityUyeler
                {
                    uye_id = int.Parse(dr["uye_id"].ToString()),
                    uye_adi = dr["uye_adi"].ToString(),
                    uye_soyadi = dr["uye_soyadi"].ToString(),
                    uye_tel = dr["uye_tel"].ToString(),
                    uye_mail = dr["uye_mail"].ToString(),
                    uye_adres = dr["uye_adres"].ToString(),
                    uye_borcu = int.Parse(dr["uye_borcu"].ToString())
                });
            }

            return Uyeler; // Nesneleri içinde tutan listeyi geri döndürme
        }
        public static List<EntityUyeler> DALUyeleriCek(int id)
        {
            // Uyeler tablosundan id bilgisi girilen veriyi çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_uyeler where uye_id=" + id + "", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityUyeler> Uyeler = new List<EntityUyeler>();

            while (dr.Read())
            {
                // Her uyeyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Uyeler.Add(new EntityUyeler
                {
                    uye_id = int.Parse(dr["uye_id"].ToString()),
                    uye_adi = dr["uye_adi"].ToString(),
                    uye_soyadi = dr["uye_soyadi"].ToString(),
                    uye_tel = dr["uye_tel"].ToString(),
                    uye_mail = dr["uye_mail"].ToString(),
                    uye_adres = dr["uye_adres"].ToString(),
                    uye_borcu = int.Parse(dr["uye_borcu"].ToString())
                });
            }

            return Uyeler; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static int UyeleriSil(EntityUyeler gUyeler)
        {
            // Üye işlemleri Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From tbl_uyeler Where uye_id = @uye_id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@uye_id", gUyeler.uye_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static int DALUyeleriGuncelle(EntityUyeler gUyeler)
        {
            // üye işlemleri Form ekranından gelen bilgilerli güncelleme
            OleDbCommand cmd = new OleDbCommand("Update tbl_uyeler set uye_adi= @uye_adi, uye_soyadi= @uye_soyadi, uye_tel= @uye_tel, uye_mail= @uye_mail, uye_adres= @uye_adres,uye_borcu=@uye_borcu where uye_id=@uye_id", Baglanti.conn);
            //Gelen bilgiler ile update komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@uye_adi", gUyeler.uye_adi);
            cmd.Parameters.AddWithValue("@uye_soyadi", gUyeler.uye_soyadi);
            cmd.Parameters.AddWithValue("@uye_tel", gUyeler.uye_tel);
            cmd.Parameters.AddWithValue("@uye_mail", gUyeler.uye_mail);
            cmd.Parameters.AddWithValue("@uye_adres", gUyeler.uye_adres);
            cmd.Parameters.AddWithValue("@uye_borcu", gUyeler.uye_borcu);
            cmd.Parameters.AddWithValue("@uye_id", gUyeler.uye_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static int DALUyelerinBorcunuGuncelle(EntityUyeler gUyeler)
        {
            // emanet Form ekranından gelen bilgilerli güncelleme
            OleDbCommand cmd = new OleDbCommand("Update tbl_uyeler set uye_borcu=@uye_borcu where uye_id=@uye_id", Baglanti.conn);
            //Gelen bilgiler ile update komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@uye_borcu", gUyeler.uye_borcu);
            cmd.Parameters.AddWithValue("@uye_id", gUyeler.uye_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
    }
}
