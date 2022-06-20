using System;
using DataAccessLayer;//Başvuru tanımlama
using EntityLayer;//Başvuru tanımlama
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessKitaplar
    {
        public static List<EntityKitaplar> BLKitaplariListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitaplar.KitaplariListele();
        }

        public static List<EntityKitaplar> BLKitaplariCek(int id)
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitaplar.DALKitaplariCek(id);
        }
        public static int BLKitaplariGuncelle(EntityKitaplar d)
        {
            // Form ekranından gelen kitap nesnesinin Validation kontrolleri
            if (d.kitap_id != 0 && d.kitap_adi != null && d.kitap_Basim_yili != null && d.kitap_turu != null && d.kitap_aciklama != null && d.kitap_sayfa_sayisi != 0 && d.kitap_adedi != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKitaplar.DALKitaplariGuncelle(d);
            }
            else
            {
                return -1;
            }
        }
        public static int BLKitaplariEkle(EntityKitaplar d)
        {
            // Form ekranından gelen Kitap nesnesinin Validation kontrolleri
            if (d.kitap_id != 0 && d.kitap_adi != null && d.kitap_Basim_yili != null && d.kitap_turu != null && d.kitap_aciklama != null && d.kitap_sayfa_sayisi != 0 && d.kitap_adedi != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKitaplar.DALKitaplariEkle(d);
            }
            else
            {
                return -1;
            }
        }
        public static int BLKitaplariSil(EntityKitaplar d)
        {
            // Form ekranından gelen Kitap nesnesinin Validation kontrolleris
            if (d.kitap_id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKitaplar.DALKitaplariSil(d);
            }
            else
            {
                return -1;
            }
        }
    }
}
