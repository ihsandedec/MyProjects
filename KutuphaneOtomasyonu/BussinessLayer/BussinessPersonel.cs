using DataAccessLayer;//Başvuru tanımlama
using EntityLayer;//Başvuru tanımlama
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessPersonel
    {
        public static bool BLAdminKontrolEt(EntityPersonel a)
        {
            // Form ekranından gelen Admin nesnesinin Validation kontrolleri
            if (a.Personel_KullaniciAdi != null && a.Personel_Sifre != null)
            {
                // Kontrolden sonra nesne DAL Katmanındaki Fonksiyona yollanıyor.
                return DALPersonel.AdminKontrolEt(a);
            }
            else
            {
                return false;
            }
        }
    }
}
