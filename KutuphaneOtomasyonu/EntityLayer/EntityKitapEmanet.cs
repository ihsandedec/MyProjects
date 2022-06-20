using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /*database'deki emanet kitapların verileri çekmek için değişkenleri tanımladığım ve bu değişkenleri set ve get komutlarıyla programa aktardığım 
    fonksiyonlar Entity katmanındaki kodlar*/
    public class EntityKitapEmanet
    {
        int Emanet_id;
        int Uye_id;
        int Kitap_id;
        string Emanet_Verme_Tarihi;
        string Emanet_Alma_Tarihi;

        public int emanet_id { get => Emanet_id; set => Emanet_id = value; }
        public int uye_id { get => Uye_id; set => Uye_id = value; }
        public int kitap_id { get => Kitap_id; set => Kitap_id = value; }
        public string emanet_verme_tarihi { get => Emanet_Verme_Tarihi; set => Emanet_Verme_Tarihi = value; }
        public string emanet_alma_tarihi { get => Emanet_Alma_Tarihi; set => Emanet_Alma_Tarihi = value; }
    }
}
