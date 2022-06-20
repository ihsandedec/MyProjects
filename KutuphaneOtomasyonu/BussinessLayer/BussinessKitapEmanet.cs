using System;
using DataAccessLayer;//Başvuru tanımlama
using EntityLayer;//Başvuru tanımlama
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessKitapEmanet
    {
        public static List<EntityKitapEmanet> BLKEmanetKitapListele()
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitapEmanet.DALEmanetKitapListele();
        }

        public static List<EntityKitapEmanet> BLKEmanetKitapCek(int emanetID)
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitapEmanet.DALEmanetKitapCek(emanetID);
        }

        public static List<EntityKitapEmanet> BLKEmanetKitapFiltreli(int kitapid)
        {
            // DAL Katmanından veri çekiliyor. Değer gönderilmiyor.
            return DALKitapEmanet.DALEmanetKitapFiltreli(kitapid);
        }

        public static int BLEmanetleriEkle(EntityKitapEmanet d)
        {
            // Form ekranından gelen emanet nesnesinin Validation kontrolleri
            if (d.uye_id != 0 && d.kitap_id != 0 && d.emanet_verme_tarihi != null && d.emanet_alma_tarihi != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKitapEmanet.DALEmanetKitapKaydet(d);
            }
            else
            {
                return -1;
            }

        }
        public static int BLEmanetIadeAl(EntityKitapEmanet d)
        {
            // Form ekranından gelen emanet nesnesinin Validation kontrolleris
            if (d.emanet_id != 0)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALKitapEmanet.DALEmanetIadeAl(d);
            }
            else
            {
                return -1;
            }
        }
    }
}
