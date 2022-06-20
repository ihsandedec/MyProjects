using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    /*database'deki kitapların verileri çekmek için değişkenleri tanımladığım ve bu değişkenleri set ve get komutlarıyla programa aktardığım 
    fonksiyonlar Entity katmanındaki kodlar*/
    public class EntityKitaplar
    {
        int Kitap_id;
        string Kitap_adi;
        string Kitap_Basim_yili;
        string Kitap_turu;
        string Kitap_aciklama;
        int Kitap_sayfa_sayisi;
        int Kitap_adedi;

        public int kitap_id { get => Kitap_id; set => Kitap_id = value; }
        public string kitap_adi { get => Kitap_adi; set => Kitap_adi = value; }
        public string kitap_Basim_yili { get => Kitap_Basim_yili; set => Kitap_Basim_yili = value; }
        public string kitap_turu { get => Kitap_turu; set => Kitap_turu = value; }
        public string kitap_aciklama { get => Kitap_aciklama; set => Kitap_aciklama = value; }
        public int kitap_sayfa_sayisi { get => Kitap_sayfa_sayisi; set => Kitap_sayfa_sayisi = value; }
        public int kitap_adedi { get => Kitap_adedi; set => Kitap_adedi = value; }
    }
}
