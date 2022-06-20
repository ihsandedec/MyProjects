using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /*database'deki personellerin verileri çekmek için değişkenleri tanımladığım ve bu değişkenleri set ve get komutlarıyla programa aktardığım 
    fonksiyonlar Entity katmanındaki kodlar*/
    public class EntityPersonel
    {
        int personel_Id;
        string personel_KullaniciAdi;
        string personel_Sifre;

        public int Personel_Id { get => personel_Id; set => personel_Id = value; }
        public string Personel_KullaniciAdi { get => personel_KullaniciAdi; set => personel_KullaniciAdi = value; }
        public string Personel_Sifre { get => personel_Sifre; set => personel_Sifre = value; }
    }
}
