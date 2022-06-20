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
    public class DALKitapEmanet
    {
        public static int DALEmanetKitapKaydet(EntityKitapEmanet gEmanet)
        {
            // Emanet Kayıt Form ekranından gelen bilgilerle yeni kayıt ekleme
            OleDbCommand cmd = new OleDbCommand("Insert Into tbl_emanet(uye_id,kitap_id,emanet_verme_tarihi,emanet_alma_tarihi) Values(@uye_id,@kitap_id,@emanet_verme_tarihi,@emanet_alma_tarihi)", Baglanti.conn);
            //Gelen bilgiler ile insert into komutuna yollamak

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@uye_id", gEmanet.uye_id);
            cmd.Parameters.AddWithValue("@kitap_id", gEmanet.kitap_id);
            cmd.Parameters.AddWithValue("@emanet_verme_tarihi", gEmanet.emanet_verme_tarihi);
            cmd.Parameters.AddWithValue("@emanet_alma_tarihi", gEmanet.emanet_alma_tarihi);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
        public static List<EntityKitapEmanet> DALEmanetKitapListele()
        {
            // Uyeler tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_emanet", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKitapEmanet> Emanetler = new List<EntityKitapEmanet>();

            while (dr.Read())
            {
                // Her uyeyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Emanetler.Add(new EntityKitapEmanet
                {
                    emanet_id = int.Parse(dr["emanet_id"].ToString()),
                    uye_id = int.Parse(dr["uye_id"].ToString()),
                    kitap_id = int.Parse(dr["kitap_id"].ToString()),
                    emanet_verme_tarihi = dr["emanet_verme_tarihi"].ToString(),
                    emanet_alma_tarihi = dr["emanet_alma_tarihi"].ToString()
                });
            }

            return Emanetler; // Nesneleri içinde tutan listeyi geri döndürme
        }
        public static List<EntityKitapEmanet> DALEmanetKitapCek(int emanetID)
        {
            // Emanet tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_emanet where emanet_id=" + emanetID + "", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKitapEmanet> Emanetler = new List<EntityKitapEmanet>();

            while (dr.Read())
            {
                // Her uyeyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Emanetler.Add(new EntityKitapEmanet
                {
                    emanet_id = int.Parse(dr["emanet_id"].ToString()),
                    uye_id = int.Parse(dr["uye_id"].ToString()),
                    kitap_id = int.Parse(dr["kitap_id"].ToString()),
                    emanet_verme_tarihi = dr["emanet_verme_tarihi"].ToString(),
                    emanet_alma_tarihi = dr["emanet_alma_tarihi"].ToString()
                });
            }


            return Emanetler; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static List<EntityKitapEmanet> DALEmanetKitapFiltreli(int kitapid)
        {
            // Emanet tablosundan tüm verileri çekmek
            OleDbCommand cmd = new OleDbCommand("Select * From tbl_emanet where kitap_id=" + kitapid + "", Baglanti.conn);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<EntityKitapEmanet> Emanetler = new List<EntityKitapEmanet>();

            while (dr.Read())
            {
                // Her uyeyi birer birer değerlerini çekip yeni nesne şekillerinde listeye ekleme
                Emanetler.Add(new EntityKitapEmanet
                {
                    emanet_id = int.Parse(dr["emanet_id"].ToString()),
                    uye_id = int.Parse(dr["uye_id"].ToString()),
                    kitap_id = int.Parse(dr["kitap_id"].ToString()),
                    emanet_verme_tarihi = dr["emanet_verme_tarihi"].ToString(),
                    emanet_alma_tarihi = dr["emanet_alma_tarihi"].ToString()
                });
            }


            return Emanetler; // Nesneleri içinde tutan listeyi geri döndürme
        }

        public static int DALEmanetIadeAl(EntityKitapEmanet gEmanet)
        {
            // Emanet Kontrol Paneli Form ekranından gelen bilgilerle silme işlemi
            OleDbCommand cmd = new OleDbCommand("Delete From tbl_emanet Where emanet_id = @emanet_id", Baglanti.conn);
            // Gelen Id bilgisi bulunan veriyi silme
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            // Gelen bilgileri addwithvalue ile sql kodunun içine entegre ediyoruz. 
            cmd.Parameters.AddWithValue("@emanet_id", gEmanet.emanet_id);

            return cmd.ExecuteNonQuery(); // Komutları işle.
        }
    }
}
