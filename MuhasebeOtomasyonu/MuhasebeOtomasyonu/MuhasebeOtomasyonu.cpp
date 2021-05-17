#include <iostream>//cin,cout komutlarını kullanmak için kütüpane kullanfım
#include <fstream> // dosyalama islemleri icin
#include <windows.h> //komut ekranına renk vermek icin
#include<cstdlib>
#include<string>//string için kütüphane ekledim
#include <iomanip>////setw() icin eklenen kutuphane
using namespace std;//isim uzayı tanimladim.

int  gelirAdedi, gelirMiktari, id;
int  giderAdedi, giderMiktari;
char personelAdi[50], personelSoyadi[30];
int personelYasi;
//yukarıda kullanacagim globallerimi tanimladim 
class insan //insan adında class tanımladım . çunku programın kimin kullandıgını gormek icin.
{
protected:
    string  isim, soyadi; //kulancı erisimine kapalı degerleri tanımladım.
public:

    insan(string isim = "", string soyadi = "") : isim(isim), soyadi(soyadi) {}//yapıcı fonksiyon tanımladım
    ~insan() {}//yıkıcı fonksiyon tanımladım
    string getIsim() { return isim; }//yukarıda kullanıcıya kapalı degerleri kullanırken get kullandım.
    string getSoyadi() { return soyadi; }//yukarıda kullanıcıya kapalı degerleri kullanırken get kullandım.
    void setIsim(string isim) { this->isim = isim; }//yukarıda kullanıcıya kapalı degerlere ulasmak icin set kullandım.
    void setSoyadi(string soyadi) { this->soyadi = soyadi; }//yukarıda kullanıcıya kapalı degerlere ulasmak icin set kullandım.


};
class hazirlayan :public insan //hazırlayan classı actım
{
private:
    string tc; //kulancı erisimine kapalı degerleri tanımladım.
public:
    hazirlayan(string tc = "", string isim = "", string soyadi = "") : tc(tc), insan(isim, soyadi) {}//yapıcı fonksiyon tanımladım
    ~hazirlayan() {}//yıkıcı fonksiyon tanımladım
    void setTc(string tc) { this->tc = tc; }//yukarıda kullanıcıya kapalı degerlere ulasmak icin set kullandım.
    string getTc() { return tc; }//yukarıda kullanıcıya kapalı degerleri kullanırken get kullandım.
};
class k_Bilgiler
{
private:
    string okul, bolum;//kulancı erisimine kapalı degerleri tanımladım.
public:
    k_Bilgiler(string okul, string bolum)//yapıcı fonksiyon tanımladım
    {
        this->okul = okul;
        this->bolum = bolum;
    }
    ~k_Bilgiler() {};//yıkıcı fonksiyon tanımladım
    friend void showInfos(k_Bilgiler k_bilgiler); //kucuk bilgiler için arkadas fonksiyon kullandım.
};
void showInfos(k_Bilgiler k_bilgiler) { //arkadas fonksiyon tanımlamasını yaptım
    cout << "=======" << k_bilgiler.okul << k_bilgiler.bolum << "=======" << endl;
}
class gelir//gelir class ı tanımladım.
{
public:


    void gelirEkle()//gelir ekle fonksiyonu actım
    {

        ofstream DosyaYaz;//dosyaya yazma icin
        DosyaYaz.open("Gelir.txt", ios::app);//dosya yazma islemi ivin dosyayı actım.
        cout << "Id Giriniz :";              cin >> id; cin.ignore();//kullaıcıdan ıd degeri istedim 
        cout << "Gelir Adeti :";             cin >> gelirAdedi; cin.ignore();//kullaıcıdan Gelir Adeti degeri istedim
        cout << "Gelir Miktari (TL) :";      cin >> gelirMiktari; cin.ignore();//kullaıcıdan Gelir Miktari degeri istedim
        DosyaYaz << setw(15) << left << id << setw(15) << left << gelirAdedi << setw(15) << left << gelirMiktari << endl;// tek yaptığım 99.satırdaki dosyaya yazma komutunu kopyalamak. 
        cout << "Islem Dosyaya Yazildi ...." << endl;
        DosyaYaz.close();//dosyayı kapattım.
    }
    void gelirSil()//gelir sil fonksiyonu actım
    {
        int silinecekbelgeid;
        cout << "Gelirin ID Numarasini Giriniz :";
        cin >> silinecekbelgeid;////belge ıd istedim.
        ifstream DosyaOku("Gelir.txt", ios::out | ios::in | ios::app);
        ofstream DosyaYaz("gecicigelir.txt", ios::out | ios::in | ios::app);//Gecici bir dosya acılır
        DosyaYaz.setf(ios::left);
        while (!(DosyaOku.eof())) //dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            DosyaOku >> id >> gelirAdedi >> gelirMiktari; // dosya okuma

            if (silinecekbelgeid == id)//Girilen ıd nosu kayıtlarda var ise if icine girer .
            {

                cout << "========== Gelir Kayit Bilgileri ==========" << endl << endl;

                cout << "Id Giriniz :" << id << endl;// onceki ıd ekrana basılır
                cout << "Gelir Adeti :" << gelirAdedi << endl;// onceki Gelir Adeti ekrana basılır
                cout << "Gelir Miktari (TL) :" << gelirMiktari << endl;// onceki Gelir Miktari ekrana basılır
                cout << "Silme Isleminiz Gerceklesmistir..." << endl;
            }
            else
                DosyaYaz << setw(15) << left << id << setw(15) << left << gelirAdedi << setw(15) << left << gelirMiktari << endl;//dosya yazma 
        }

        DosyaYaz.close();//dosya kapattım
        DosyaOku.close();//dosya kapattım

        remove("Gelir.txt");//dosyayi sildim.
        rename("gecicigelir.txt", "Gelir.txt");//Gecici dosyalar kayıt silindiktentxt dosyasina aktardım
    }
    void gelirListele()//Gelir listeleme icin fonksiyon
    {
        ifstream DosyaOku("Gelir.txt", ios::in);//dosyami actim.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basilir.
        }
        DosyaOku.close();//Dosyayi kapattim
    }
    void gelirAra()
    {
        string tamamlanan, sorgulanan;
        int uzunluk1, uzunluk2;
        ifstream DosyaOku("Gelir.txt", ios::in); // dosya okuma
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> sorgulanan;//sorgulanacak veri alınır
        while (!DosyaOku.eof())//dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            getline(DosyaOku, tamamlanan);
            uzunluk1 = tamamlanan.length();
            uzunluk2 = sorgulanan.length();
            for (int i = 0; i < (uzunluk1 - uzunluk2); i++)
            {
                if (sorgulanan.compare(tamamlanan.substr(i, uzunluk2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << tamamlanan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//dosya kapatıldı
    }
    void gelirGuncelle()
    {
        int g_gelir;
        cout << "Guncellenecek Gelir Bilgisi Icin ID No Giriniz :"; cin >> g_gelir;
        int gecicigelir = 0;
        ifstream DosyaOku("Gelir.txt");//dosya okuma islemi
        while (!(DosyaOku.eof())) //dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            DosyaOku >> id >> gelirAdedi >> gelirMiktari; // dosyaya yazılır
            if (id == g_gelir)//id ve kullancıdan girilen id esitse if dongusune girer.
            {
                cout << "========== Mevcut Gelir Bilgileri ===========" << endl;

                cout << "Id Giriniz :" << id << endl;//eski id ekrana basılır
                cout << "Gelir Adeti :" << gelirAdedi << endl;//eski Gelir Adeti  ekrana basılır
                cout << "Gelir Miktari (TL) :" << gelirMiktari << endl;//eski Gelir Miktari ekrana basılır
                DosyaOku.close();//dosya kapattım
                break;
            }
        }

        ifstream GelirDosyaOku("gelir.txt"); //dosyadan okuma amaclı actık.
        ofstream GeciciDosyaYaz("Gelir.tmp");//gecici dosya actım

        while (GelirDosyaOku >> id >> gelirAdedi >> gelirMiktari)
        {
            if (g_gelir != id) //girilen gecici gelir id numarasıyla eşit degilse if dongusune girer.
                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << gelirAdedi << setw(15) << left << gelirMiktari << endl;//gecici dosyaya yazılır

            if (g_gelir == id)//girilen ıd onceden grilmis ıd ile esit ise yeni bilgiler istenir.
            {
                cout << "\n Yeni Gelir Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";              cin >> id; cin.ignore();//yeni ıd istenir.
                cout << "Gelir Adeti :";             cin >> gelirAdedi; cin.ignore();//yeni Gelir Adeti istenir.
                cout << "Gelir Miktari (TL) :";      cin >> gelirMiktari; cin.ignore();//yeni Gelir Miktari istenir.

                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << gelirAdedi << setw(15) << left << gelirMiktari << endl; //girilen bilgilerin dosya yazımı gerceklesir.
                gecicigelir = 1;//gecici gelir 1 e esitlenir islem kontrol edilir.
            }
        }
        GeciciDosyaYaz.close();//dosya kapattım
        GelirDosyaOku.close();//dosya kapattım

        remove("Gelir.txt"); //Gelir.txt dosyadan sildim.
        rename("Gelir.tmp", "Gelir.txt"); //Gelir.tmp dosyasini Gelir.txt dosyasina kopyaladim.

        if (gecicigelir == 0)//gecici geliri yukarıda tanımladıgım 1 degeri olmazsa if dongusene girer
            cout << "Boyle Bir Gelir Bilgisi Bulunmamaktadir..." << endl;
        if (gecicigelir == 1)//gecici geliri yukarıda tanımladıgım 1 degeri olursa if dongusene girer
            cout << "Gelir Bilgileri Guncellendi..." << endl;

    }

}glr;
class gider
{
public:
    void giderEkle()//gider ekleme fonksiyonu
    {
        ofstream DosyaYaz;//dosya yazma islemi
        DosyaYaz.open("Gider.txt", ios::app);//dosya acma
        cout << "Id Giriniz :";              cin >> id; cin.ignore();//kullanıcıdan id istedim
        cout << "Gider Adeti :";             cin >> giderAdedi; cin.ignore();//kullanıcıdan Gider Adeti istedim
        cout << "Gider Miktari (TL) :";      cin >> giderMiktari; cin.ignore();//kullanıcıdan Gider Miktari  istedim
        DosyaYaz << setw(15) << left << id << setw(15) << left << giderAdedi << setw(15) << left << giderMiktari << endl;//dosyaya yazdırıldı
        cout << "Islem Dosyaya Yazildi ...." << endl;
        DosyaYaz.close();//dosayayı kapattım.
    }
    void giderSil()//gider silme fonksiyonu
    {
        int silinecekbelgeid;
        cout << "Giderin ID Numarasini giriniz :";
        cin >> silinecekbelgeid; //silenmek istenen belge id si girilir
        ifstream DosyaOku("Gider.txt");//dosya okuma
        ofstream DosyaYaz("gecicigider.tmp");//Gecici bir dosya acılır

        while (!(DosyaOku.eof())) //dosya sonuna kadar gelinceye kadar while döngüsüne girer
        {
            DosyaOku >> id >> giderAdedi >> giderMiktari;//dosya yazım

            if (silinecekbelgeid == id)//girilen id ile önceki id aynı ise if dongusune girer.
            {

                cout << "========== Gider Kayit Bilgileri ==========" << endl << endl;

                cout << "Id Giriniz :" << id << endl;//id ekrana basılır
                cout << "Gider Adeti : -" << giderAdedi << endl;//Gider Adeti ekrana basılır
                cout << "Gider Miktari (TL) :" << giderMiktari << endl;//Gider Miktari  ekrana basılır
                cout << "Silme Isleminiz Gerceklesmistir..." << endl;
            }
            else
                DosyaYaz << setw(15) << left << id << setw(15) << left << giderAdedi << setw(15) << left << giderMiktari << endl;//dosya yazımı gerceklesir
        }

        DosyaYaz.close();//dosya kapattım.
        DosyaOku.close();//dosya kapattım.

        remove("Gider.txt");//dosyayi sildim.
        rename("gecicigider.tmp", "Gider.txt");//Gecici dosyalar kayit silindikten sonra tmp dosyasi txt dosyasına kopyalanır
    }
    void giderListele()//Gider listeleme icin fonksiyon
    {
        ifstream DosyaOku("Gider.txt", ios::in);//dosyami actim.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basilir.
        }
        DosyaOku.close();//Dosyayi kapattim
    }
    void giderAra()
    {
        string okunan, aranan;
        int uzunluk1, uzunluk2;
        ifstream DosyaOku("Gider.txt", ios::in);
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> aranan;//aramak istenenveri girisi yapılır
        while (!DosyaOku.eof())//dosya sonuna kadar gelinceye kadar while döngüsüne girer
        {
            getline(DosyaOku, okunan);//satır satır okunur .
            uzunluk1 = okunan.length();//uzunluk ataması yapılır .
            uzunluk2 = aranan.length();//uzunluk ataması yapılır .
            for (int i = 0; i < (uzunluk1 - uzunluk2); i++)
            {
                if (aranan.compare(okunan.substr(i, uzunluk2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << okunan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//dosya kapattım
    }
    void giderGuncelle()
    {
        int g_gider;
        cout << "Guncellenecek Gider Bilgisi Icin ID No Giriniz :"; cin >> g_gider;//güncellenece veri id alınır
        int gecicigider = 0;
        ifstream DosyaOku("Gider.txt");
        while (!(DosyaOku.eof())) //dosya sonuna kadar gelinceye kadar while döngüsüne girer
        {
            DosyaOku >> id >> giderAdedi >> giderMiktari; //
            if (id == g_gider)//önceki id ile girilen id ayni ise if döngüsüne girer.
            {
                cout << "========== Mevcut Gider Bilgileri ===========" << endl;

                cout << "Id Giriniz :" << id << endl;//eski ıd ekrana basılır
                cout << "Gider Adeti :" << giderAdedi << endl;//eski Gider Adeti ekrana basılır
                cout << "Gider Miktari (TL) :" << giderMiktari << endl;//eski Gider Miktari ekrana basılır
                DosyaOku.close();//dosya kapanır.
                break;
            }
        }

        ifstream GelirDosyaOku("gider.txt"); //dosyaya okuma amacli actik
        ofstream GeciciDosyaYaz("Gider.tmp");//gecici dosya acilir.

        while (GelirDosyaOku >> id >> giderAdedi >> giderMiktari)
        {
            if (g_gider != id)//girilen id onceki ile ayı degilse if dongusune girer.
                GeciciDosyaYaz << id << setw(15) << giderAdedi << setw(15) << giderMiktari << setw(15) << endl;//dosyaya yazılır

            if (g_gider == id)//girilen id onceki ile ayı ise if dongusune girer.
            {
                cout << "\n Yeni Gider Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";              cin >> id; cin.ignore();
                cout << "Gider Adeti :";             cin >> giderAdedi; cin.ignore();
                cout << "Gider Miktari (TL) :";      cin >> giderMiktari; cin.ignore();

                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << giderAdedi << setw(15) << left << giderMiktari << endl; //girilen randevu bilgilerini dosyaya yazdirilir
                gecicigider = 1;//islem kontrolu icin
            }
        }
        GeciciDosyaYaz.close();//dosyayı kapattım.
        GelirDosyaOku.close();//dosyayı kapattım.

        remove("Gider.txt"); //Gider.txt dosyasini sildim.
        rename("Gider.tmp", "Gider.txt"); //Gider.tmp dosyasini Gider.txt dosyasina kopyaladim.

        if (gecicigider == 0)//316. satırda kontrol ettgim deger 1 degilse if dongusune girer
            cout << "Boyle Bir Gider Bilgisi Bulunmamaktadir..." << endl;
        if (gecicigider == 1)//316. satırda kontrol ettgim deger 1 ise if dongusune girer
            cout << "Gider Bilgileri Guncellendi..." << endl;

    }


}gdr;
class personel
{
public:
    void personelEkle()
    {
        ofstream DosyaYaz;
        DosyaYaz.open("Personel.txt", ios::app);//doya actım
        cout << "Id Giriniz :";                   cin >> id; cin.ignore();//persone icin ıd istenir
        cout << "Personel Adini Giriniz :";       cin.getline(personelAdi, 50);//persone icin Personel Adi istenir
        cout << "Personel Soyadini Giriniz :";    cin.getline(personelSoyadi, 30);//persone icin Personel Soyadi istenir
        cout << "Personel Yasini Giriniz :";      cin >> personelYasi; cin.ignore();//persone icin Personel Yasi istenir
        DosyaYaz << setw(15) << left << id << setw(15) << left << personelAdi << setw(15) << left << personelSoyadi << setw(23) << left << personelYasi << endl;//dosya yazımı gerceklesir
        cout << "Islem Dosyaya Yazildi ...." << endl;
        DosyaYaz.close();//dosya kapattım.
    }
    void personelSil()
    {

        int silinecekbelgeid;
        cout << "Personel ID Numarasini Giriniz :";
        cin >> silinecekbelgeid; // silinecek ver id si girilir.
        ifstream DosyaOku("Personel.txt");
        ofstream DosyaYaz("gecicipersonel.tmp");//Gecici bir dosya acilir

        while (!(DosyaOku.eof()))//dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            DosyaOku >> id >> personelAdi >> personelSoyadi >> personelYasi;

            if (silinecekbelgeid == id)//silnmek icin girilen id ile onceki id esit ise donguye girer.
            {

                cout << "========== Personel Kayit Bilgileri ==========" << endl << endl;

                cout << "ID No :" << id << endl;
                cout << "Personel Adi : " << personelAdi << endl;
                cout << "Personel Soyadi :" << personelSoyadi << endl;
                cout << "Personel Yasini Giriniz :" << personelYasi << endl;
                cout << "Silme Isleminiz Gerceklesmistir..." << endl;
            }
            else
                DosyaYaz << setw(15) << left << id << setw(15) << left << personelAdi << setw(15) << left << personelSoyadi << setw(23) << left << personelYasi << endl;//dosyaya yazilir
        }

        DosyaYaz.close();//dosyayı kapattım
        DosyaOku.close();//dosyayı kapattım

        remove("Personel.txt");//dosyayi sildim.
        rename("gecicipersonel.tmp", "Personel.txt"); // gecicipersonel.tmp dosyasini Personel.txt dosyasina kopyaladim.
    }
    void personelListele()//personel listeleme ivin fonksiyon
    {
        ifstream DosyaOku("Personel.txt", ios::in);//dosyami actim.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basilir.
        }
        DosyaOku.close();//Dosyayi kapattim
    }
    void personelAra()
    {
        string okunan, aranan;
        int uzunluk1, uzunluk2;
        ifstream DosyaOku("Personel.txt", ios::in);
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> aranan;//aranacak olan veri girisi yapilir.
        while (!DosyaOku.eof())//dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            getline(DosyaOku, okunan);
            uzunluk1 = okunan.length();//uzuluk orculur
            uzunluk2 = aranan.length();//uzuluk orculur
            for (int i = 0; i < (uzunluk1 - uzunluk2); i++)
            {
                if (aranan.compare(okunan.substr(i, uzunluk2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << okunan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//dosyayı kapattım.
    }
    void personelGuncelle()
    {
        int g_personel;
        cout << "Guncellenecek Personel Bilgisi Icin ID No Giriniz :"; cin >> g_personel;//guncellenecek veri istenir
        int gecicipersonel = 0;
        ifstream DosyaOku("Personel.txt");
        while (!(DosyaOku.eof())) //dosya sonuna kadar gelinceye kadar while döngüsüne girer.
        {
            DosyaOku >> id >> personelAdi >> personelSoyadi >> personelYasi;
            if (id == g_personel)//girilen id ile oceki id numarasi ayni ise donguye girer.
            {
                cout << "========== Mevcut Personel Bilgileri ===========" << endl;//mevcut bilgiler ekrana basilir.

                cout << "ID No :" << id << endl;
                cout << "Personel Adi : " << personelAdi << endl;
                cout << "Personel Soyadi :" << personelSoyadi << endl;
                cout << "Personel Yasini Giriniz :" << personelYasi << endl;
                cout << "Silme Isleminiz Gerceklesmistir..." << endl;
                DosyaOku.close();//doyayi kapattim.
                break;
            }
        }

        ifstream PersonelDosyaOku("personel.txt"); //dosyayi okuma amacli actik.
        ofstream GeciciDosyaYaz("Personel.tmp");//gecici dosya actik

        while (PersonelDosyaOku >> id >> personelAdi >> personelSoyadi >> personelYasi)
        {
            if (g_personel != id)//girilen id ile oceki id numarasi ayni degil ise donguye girer
                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << personelAdi << setw(15) << left << personelSoyadi << setw(23) << left << personelYasi << endl;

            if (g_personel == id)//girilen id ile oceki id numarasi ayni ise donguye girer
            {
                cout << "\n Yeni personel Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";                   cin >> id; cin.ignore();
                cout << "Personel Adini Giriniz :";       cin.getline(personelAdi, 50);
                cout << "Personel Soyadini Giriniz :";    cin.getline(personelSoyadi, 30);
                cout << "Personel Yasini Giriniz :";      cin >> personelYasi; cin.ignore();

                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << personelAdi << setw(15) << left << personelSoyadi << setw(23) << left << personelYasi << endl; //dosyaya yazdirildi
                gecicipersonel = 1;//kontrol icin
            }
        }
        GeciciDosyaYaz.close();
        PersonelDosyaOku.close();

        remove("Personel.txt"); //Personel.txt dosyasÄ±nÄ± sildim.
        rename("Personel.tmp", "Personel.txt");

        if (gecicipersonel == 0)//459.satirda kontrol yapilmadiysa donguye girer.
            cout << "Boyle Bir Personel Bilgisi Bulunmamaktadir..." << endl;
        if (gecicipersonel == 1)//459.satirda kontrol yapildiysa donguye girer.
            cout << "Personel Bilgileri Guncellendi..." << endl;
    }
}prsnl;

int main()
{
    system("color 3");//komut ekranina renk verir.
    system("cls");//komut ekraı temizlenir.
    hazirlayan kllnc2("12308038746", "IHSAN", "DEDEC");//hazirlayan bilgilerini girdim.
    cout << "                              " << kllnc2.getTc() << " " << kllnc2.getIsim() << " " << kllnc2.getSoyadi() << endl << endl;//kullanici bilgilerini ekrana basar.
    char Hesapekle[50];
    int GelirMiktar, GelirAdet;
    int secim1, secim2, secim3, secim4;
    string cevap;
    //yukarda kullanacagim degerleri tanimladim.
    do {

        /////////////////////MENU/////////////////////////////
        cout << "     ========== MUHASEBE ISLEMLERI ==========" << endl << endl;

        cout << " 1-ISLEMLER" << endl;
        cout << " 2-HESAPLAR" << endl;
        cout << " 3-SORGULAMA" << endl << endl;

        cout << "Yapmak Istediginiz Islemi Seciniz:  "; cin >> secim1;//secim yapilir
        switch (secim1)
        {
        case 1:
        {
            system("cls");
            cout << " 1-GELIR EKLE" << endl;
            cout << " 2-GELIR SIL" << endl;
            cout << " 3-GELIR GUNCELLE" << endl;
            cout << " 4-GIDER EKLE" << endl;
            cout << " 5-GIDER SIL" << endl;
            cout << " 6-GIDER GUNCELLE" << endl;
            cout << " 7-PERSONEL EKLE" << endl;
            cout << " 8-PERSONEL SIL" << endl;
            cout << " 9-PERSONEL GUNCELLE" << endl << endl;
            cout << "Yapmak istediginiz islemi seciniz:  "; cin >> secim2;

            switch (secim2)
            {
            case 1://gelir ekleme 
            {
                system("cls");
                glr.gelirEkle();
                break;
            }
            case 2://gelir silme 
            {
                system("cls");
                glr.gelirSil();

                break;
            }
            case 3://gelir guncelleme 
            {
                system("cls");
                glr.gelirGuncelle();

                break;
            }
            case 4://gider ekleme 
            {
                system("cls");
                gdr.giderEkle();

                break;
            }
            case 5://gider silme 
            {
                system("cls");
                gdr.giderSil();

                break;
            }
            case 6://gider guncelleme 
            {
                system("cls");
                gdr.giderGuncelle();
                break;
            }
            case 7://personel ekleme 
            {
                system("cls");
                prsnl.personelEkle();

                break;
            }
            case 8://personel silme 
            {
                system("cls");
                prsnl.personelSil();
                break;
            }
            case 9://personel guncelleme 
            {
                system("cls");
                prsnl.personelGuncelle();
                break;
            }
            default://yanlıs tuslama icin
                cout << "!!! Yanlis Tuslama Yaptiniz !!!" << endl;
                break;
            }
            break;
        }
        case 2://secim2
        {
            system("cls");
            cout << " 1-GELIR BILGILERINI LISTELE" << endl;
            cout << " 2-GIDER BILGILERINI LISTELE" << endl;
            cout << " 3-PERSONEL BILGILERINI LISTELE" << endl;
            cout << "Yapmak istediginiz islemi seciniz:  "; cin >> secim3;
            switch (secim3)
            {
            case 1://gelir listele
            {
                system("cls");
                glr.gelirListele();
                break;
            }
            case 2://gider listele
            {
                system("cls");
                gdr.giderListele();
                break;
            }
            case 3://personel listele
            {
                system("cls");
                prsnl.personelListele();
                break;
            }
            default:
                break;
            }
            break;
        }
        case 3:
        {
            system("cls");
            cout << " 1-GELIR ARA" << endl;
            cout << " 2-GIDER ARA" << endl;
            cout << " 3-PERSONEL ARA" << endl;
            cout << "Yapmak istediginiz islemi seciniz:  "; cin >> secim4;
            switch (secim4)
            {
            case 1://gelir arama
            {
                system("cls");
                glr.gelirAra();
                break;
            }
            case 2://gider arama
            {
                system("cls");
                gdr.giderAra();
                break;
            }
            case 3://personel arama
            {
                system("cls");
                prsnl.personelAra();
                break;
            }
            default:
                break;
            }
            break;
        }
        default://yanlıs tuslama icin
            cout << "!!! Yanlis Tuslama Yaptiniz !!!" << endl;
            break;
        }
        cout << "Devam Etmek Ister Misiniz ? (E-e/H-h) :" << endl;//devam sorgulama
        cin >> cevap;
    } while (cevap == "e" || cevap == "E");
    system("cls");//ekran temizledim
    system("color 4");//ekrana renk verdi
    k_Bilgiler k_bilgiler("DUZCE UNIVERSITESI", "  Bilgisayar Muhendisligi");//kucuk bilgiler ekledim

    cout << endl << endl << endl << endl << endl;
    hazirlayan kllnc("12308038746", "IHSAN", "DEDEC");//kulanıcı bilgileri
    showInfos(k_bilgiler);
    cout << "      ========" << kllnc.getTc() << " " << kllnc.getIsim() << " " << kllnc.getSoyadi() << "========" << endl << endl << endl;//kullanici bilgileri ekrana basilir.
    return 0;
}
