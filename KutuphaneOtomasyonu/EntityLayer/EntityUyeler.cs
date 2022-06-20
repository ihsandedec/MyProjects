using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /*database'deki üyelerin verileri çekmek için değişkenleri tanımladığım ve bu değişkenleri set ve get komutlarıyla programa aktardığım 
    fonksiyonlar Entity katmanındaki kodlar*/
    public class EntityUyeler
    {

        int Uye_id;

        string Uye_adi;

        string Uye_soyadi;

        string Uye_tel;

        string Uye_mail;

        string Uye_adres;

        int Uye_borcu;

        public int uye_id { get => Uye_id; set => Uye_id = value; }
        public string uye_adi { get => Uye_adi; set => Uye_adi = value; }
        public string uye_soyadi { get => Uye_soyadi; set => Uye_soyadi = value; }
        public string uye_tel { get => Uye_tel; set => Uye_tel = value; }
        public string uye_mail { get => Uye_mail; set => Uye_mail = value; }
        public string uye_adres { get => Uye_adres; set => Uye_adres = value; }
        public int uye_borcu { get => Uye_borcu; set => Uye_borcu = value; }
    }
}
