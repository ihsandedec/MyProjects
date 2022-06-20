using DataAccessLayer;//Başvuru tanımlama
using EntityLayer;//Başvuru tanımlama
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessUyeler
    {
        public static int BLUyeleriEkle(EntityUyeler d)
        {
            // Form ekranından gelen üye nesnesinin Validation kontrolleri
            if (d.uye_adi != null && d.uye_soyadi != null && d.uye_tel != null && d.uye_mail != null && d.uye_adres != null && d.uye_borcu != -1)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALUyeler.DALUyeleriEkle(d);
            }
            else
            {
                return -2;
            }
        }
        public static List<EntityUyeler> BLUyeleriListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALUyeler.UyeleriListele();
        }
        public static List<EntityKitaplar> BLKitaplariListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitaplar.KitaplariListele();
        }

        public static List<EntityUyeler> BLUyeleriCek(int id)
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALUyeler.DALUyeleriCek(id);
        }
        public static int BLUyeleriSil(EntityUyeler d)
        {
            // Form ekranından gelen üye nesnesinin Validation kontrolleris
            if (d.uye_id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALUyeler.UyeleriSil(d);
            }
            else
            {
                return -1;
            }
        }
        public static int BLUyeleriGuncelle(EntityUyeler d)
        {
            // Form ekranından gelen üye nesnesinin Validation kontrolleri
            if (d.uye_id != 0 && d.uye_adi != null && d.uye_soyadi != null && d.uye_tel != null && d.uye_mail != null && d.uye_adres != null && d.uye_borcu != -1)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALUyeler.DALUyeleriGuncelle(d);
            }
            else
            {
                return -2;
            }
        }
        public static int BLUyelerinBorcunuGuncelle(EntityUyeler d)
        {
            // Form ekranından gelen üye nesnesinin Validation kontrolleri
            if (d.uye_id != 0 && d.uye_borcu != -1)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALUyeler.DALUyelerinBorcunuGuncelle(d);
            }
            else
            {
                return -2;
            }
        }
    }
}
