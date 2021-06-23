// Bilimsel Hesap Makinesi.cpp : Bu dosya 'main' işlevi içeriyor. Program yürütme orada başlayıp biter.
//
#include <iostream>//cin ve cout dosyalarının tanımlı olduğu kütüphaneyi ekledim.
#include <fstream>  //dosyalama işlemleri için gerekli kütüphaneyi ekledim.
#include <windows.h> //komut ekranına renk vermek için tanımladım
#include<cstdlib>
#include<string>//string değişkeni için gerekli kütüphaneyi ekledim.
#include <iomanip>//setw() için eklenen kütüphane

using namespace std;//isim uzayı tanımladım.

//global tanımlamalar yaptım.
int id , soruSayisi;
char aciklama[200], formul[100] , ders[50];

class formuller//Formuller adında class tanımladım. Amaç kullanıcıya lazım olacak formulleri kaydetmesi ve kolayca erişebilmesidir.
//Formul Kitabı adı altında formul ekle silme listele güncelle arama gibi imkanlar sundum.
{
public:
    void formulEkle()//Dosaya formül bilgilerini ekliyoruz.
    {
        ofstream DosyaYaz;//Yazma dosyasını tanımladım.
        DosyaYaz.open("Formul.txt", ios::app);//Formül.txt dosyasını dosya ekleme modunda açtım.
        cout << "Id Giriniz :";                 cin >> id; cin.ignore();//Kullanıcıdan id numarasını istedim
        cout << "Formul Basligi :";             gets_s(aciklama);//Kullanıcıdan formul başlığını  istedim
        cout << "Formul :";                     gets_s(formul);//Kullanıcıdan formulü istedim
        DosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << setw(15) << left << formul << endl;//Yazma dosyasına yazdırdım.
        cout << "Islem Dosyaya Basariyla Yazildi ...." << endl;//Pozitif sonuc ekrana bastım.
        DosyaYaz.close();//Dosyayı kapattım.
    }
    void formulSil()//Dosyadan silme işlemlerini yapıyoruz.
    {
        int silineceId;//Tanımlama yaptm.
        cout << "ID Numarasini Giriniz :";
        cin >> silineceId;//Kullanıcıdan silinecek id numarasını istedim.
        ifstream DosyaOku("Formul.txt");//Formul adındaki okuma dosyasını actım.
        ofstream DosyaYaz("geciciformul.tmp");//geciciFormul.tmp adımda dosya oluşturup dosya ekleme modunda açtım

        while (!(DosyaOku.eof())) //DosyaOku da tanımladığım Formul.txt dosyasını sonuna kadar okuttum.
        {
            DosyaOku >> id >> aciklama >> formul;//Dosyadaki kayıtlı bilgileri aldım.

            if (silineceId == id)//Girilen id numarası kayıtlarda varsa görüntüleme yapılır.
            {
                //Silinen bilgileri gösterdim.
                cout << "========== Formul Bilgileri ==========" << endl << endl;

                cout << "Id Giriniz :" << id << endl;
                cout << "Formul Basligi :" << aciklama << endl;
                cout << "Formul :" << formul << endl;
                cout << "Silme Isleminiz Basariyla Gerceklesmistir..." << endl;//Pozitif bir sonuc ekrana bastım.
            }
            else//kayıtlarda yoksa
            {
                DosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << setw(15) << left << formul << endl;
            }
        }
        DosyaYaz.close();//Dosyayı kapattım.
        DosyaOku.close();//Dosyayı kapattım.

        remove("Formul.txt");//Dosyaı remove komutu ile sildim.
        rename("geciciformul.tmp", "Formul.txt"); // Gecici dosyalar kayıt silindikten tmp dosyasi txt dosyasina aktarılır.
  
    }
    void formulListele()//Tüm formul bilgilerini görüntülüyoruz.
    {
        ifstream DosyaOku("Formul.txt", ios::in);//dosyamı açtım.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basılır.
        }
        DosyaOku.close();//Dosyayı kapattım
    }
    void formulGuncelle()//Formuller üzerinde güncellemeler yapıyoruz.
    {
        int g_formul;
        cout << "Guncellenecek Formul Bilgisi Icin ID No Giriniz :"; cin >> g_formul;//Kullanıcıdan güncellemek istediği id numarasını aldım.
        int geciciformul = 0;//Ekrana olumlu yada olumsuz cevap yazmak için ilk degeri 0 atadım.
        ifstream DosyaOku("Formul.txt");//Formul adındaki okuma dosyasını actım.
        while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Formul.txt dosyasını sonuna kadar okuttum.
        {
            DosyaOku >> id >> aciklama >> formul ;//Dosyadaki kayitli bilgileri okudum.

            if (id == g_formul)//Kullanıcın girdiği id numarası varsa mevcut formul bilgilerini ekrana bastım.
            {
                //Mevcut formul bilgileri
                cout << "========== Mevcut Formul Bilgileri ===========" << endl;

                cout << "ID No :" << id << endl;
                cout << "Formul Basligi : " << aciklama << endl;
                cout << "Formul :" << formul << endl;
                DosyaOku.close();//Dosyayı kapattım.
                break;
            }
        }

        ifstream FormulDosyaOku("formul.txt"); //dosyayı okuma amaçlı açtık.
        ofstream GeciciDosyaYaz("Formul.tmp");//Geçici tmp dosyası açtım .

        while (FormulDosyaOku >> id >> aciklama >> formul )//Eğer mevcut bilgiler doğruysa aşağıdaki işlemleri yaptım.
        {

            if (g_formul == id)//Kullanıcın girmiş olduğu id  kayitli ıd ile aynıysa tekrar yeni bilgileri istedim.
            {
                cout << "\n Yeni Formul Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";           cin >> id; cin.ignore();
                cout << "Formul Basligi :";       gets_s(aciklama);
                cout << "Formul :";               gets_s(formul);

                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << setw(15) << left << formul << endl; //girilen formül bilgilerini gecici dosyaya yazdırdım.
                geciciformul = 1;//Pozitif cevabı vermek için 1 atadım.
            }
            else //Girilen id eşit değilse
                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << setw(15) << left << formul << endl;
        }
        GeciciDosyaYaz.close();//dosyayı kapattım.
        FormulDosyaOku.close();//dosyayı kapattım.

        remove("Formul.txt"); //Formul.txt dosyasını sildim.
        rename("Formul.tmp", "Formul.txt"); //Formul.tmp dosyasını Formul.txt dosyasına kopyaladım.

        if (geciciformul == 0)//Eğer geciciformul 0 Negatif sonuc ekrana bastım.
            cout << "Boyle Bir Formul Bilgisi Bulunmamaktadir..." << endl;
        if (geciciformul == 1)//Eğer geciciformul 1 isePozitif sonuc ekrana bastım.
            cout << "Formul Bilgileri Guncellendi..." << endl;
    
    }
    void formulAra()//Dosyada arama işlemlerini yapıyoruz.
    {
        string okunan, arananVeri;
        int length_1, length_2;
        ifstream DosyaOku("Formul.txt", ios::in);
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> arananVeri;
        while (!DosyaOku.eof())//Dosyanın sonunda değilsem aşagıdakiler yapılır.
        {
            getline(DosyaOku, okunan);
            //uzunlukları belirledim.
            length_1 = okunan.length();
            length_2 = arananVeri.length();
            for (int i = 0; i < (length_1 - length_2); i++)
            {
                //okunanın i'ninci karakterinden length_2'nci karakterine kadar okunana atanır.
                //okunan ile arananVeri aynı ise aranan kayıt ekrana basılır.
                if (arananVeri.compare(okunan.substr(i, length_2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << okunan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//Dosyayı kapattım.
    }
}frml;
class notlarım//Notlarım adında class tanımladım.Amaç kullanıcın not defteri gibi kullanacağı bir bölüm hazırlamaktır.
{
public:
    void notEkle()//Dosyaya not ekliyoruz
    {
        ofstream DosyaYaz;//Yazma dosyasını tanımladım.
        DosyaYaz.open("Notlar.txt", ios::app);//Notlar.txt dosyasını dosya ekleme modunda açtım
        cout << "Id Giriniz :";           cin >> id; cin.ignore();//id numarası istedim.
        cout << "Not :";                  gets_s(aciklama);//Not girmesini istedim.
        DosyaYaz << setw(15) << left << id << setw(15) << left << aciklama <<  endl;//Girilen bilgileri  dosyaya yazdım.
        cout << "Islem Dosyaya Basariyla Yazildi ...." << endl;//Pozitif sonuc ekrana bastım
        DosyaYaz.close();//Dosyayı kapattım.
    }
    void notSil()//Dosyada silme işlemleri yapıyoruz.
    {
        int silineceId;
        cout << "ID Numarasini Giriniz :";
        cin >> silineceId;//Silinecek olan ıd numarasını istedim.
        ifstream DosyaOku("Notlar.txt");//Notlar.txt adlı okuma dosyasını açtım.
        ofstream DosyaYaz("gecicinotlar.tmp");//Gecici bir dosya açtım.
        while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Notlar.txt dosyasını sonuna kadar okuttum.
        {
            DosyaOku >> id >> aciklama;//Dosyadan bilgileri aldım

            if (silineceId == id)//Girilen id nosu kayıtlarda var ise mevcut not bilgilerini görüntüledim.
            {
                //Silinen veri bilgileri
                cout << "========== Not Bilgileri ==========" << endl << endl;

                cout << "Id Giriniz :" << id << endl;
                cout << "Not :" << aciklama << endl;
                cout << "Silme Isleminiz Basariyla Gerceklesmistir..." << endl;
            }
            else//id eşit değilse
            {
                DosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << endl;
            }
        }
        DosyaYaz.close();//Dosyayı kapattım.
        DosyaOku.close();//Dosyayı kapattım.
        remove("Notlar.txt");//Notlar.txt yi sildim.
        rename("gecicinotlar.tmp", "Notlar.txt");// Gecici dosyalar kayıt silindikten tmp dosyasi txt dosyasina aktarılır.
    }
    void notListele()//Not kayıtlarını listeliyoruz.
    {
        ifstream DosyaOku("Notlar.txt", ios::in);//dosyamı açtım.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basılır.
        }
        DosyaOku.close();//Dosyayı kapattım
    }
    void notGuncelle()
    {
        int g_not;
        cout << "Guncellenecek Not Bilgisi Icin ID No Giriniz :"; cin >> g_not;//Kullanıcan değiştirmek istediği id numarasını istedim.
        int gecicinot = 0;//Ekrana olumlu yada olumsuz cevap yazmak için ilk degeri 0 atadım.
        ifstream DosyaOku("Notlar.txt");//Notlar.txt adlı okuma dosyasını açtım.
        while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Notlar.txt dosyasını sonuna kadar okuttum.
        {
            DosyaOku >> id >> aciklama;//Mevcut bilgileri aldım.
            if (id == g_not)//Kullanıcın girdiği id numarası varsa mevcut not bilgilerini ekrana bastım.
            {
                //Mevcut not bilgileri
                cout << "========== Mevcut Not Bilgileri ===========" << endl;

                cout << "ID No :" << id << endl;
                cout << "Not : " << aciklama << endl;
                DosyaOku.close();//Dosyayı kapattım.
                break;
            }
        }
        ifstream NotDosyaOku("notlar.txt"); //dosyayı okuma amaçlı açtık.
        ofstream GeciciDosyaYaz("Notlar.tmp");//Geçici tmp dosyası açtım.
        while (NotDosyaOku >> id >> aciklama )//Bilgiler doğru ise aşağıdaki işlemleri yaptım.
        {
            if (g_not == id)//Kullanıcın girmiş olduğu id  kayitli ıd ile aynıysa tekrar yeni bilgileri istedim.
            {
                cout << "\n Yeni Not Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";           cin >> id; cin.ignore();
                cout << "Not :";                  gets_s(aciklama);

                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << endl; //girilen not bilgilerini dosyaya yazdırdım.
                gecicinot = 1;//Pozitif cevap vermek için 1 atadım.
            }
            else//id eşit değilse
            {
                GeciciDosyaYaz << setw(15) << left << id << setw(15) << left << aciklama << endl;
            }
        }
        GeciciDosyaYaz.close();//dosyayı kapattım.
        NotDosyaOku.close();//dosyayı kapattım.
        remove("Notlar.txt"); //Notlar.txt dosyasını sildim.
        rename("Notlar.tmp", "Notlar.txt"); //Notlar.tmp dosyasını Notlar.txt dosyasına kopyaladım.

        if (gecicinot == 0)//Eğer gecicinot 0 ise Ekrana Negatif sonuc bastım.
            cout << "Maalesef Boyle Bir Not Bilgisi Bulunamamaktadir..." << endl;
        if (gecicinot == 1)//Eğer gecicinot 1 ise Ekrana Pozitif sonuc bastım.
            cout << "Not Bilgileri Basariyla Guncellendi..." << endl;
    }
    void notAra()//Dosyada arama yapıyoruz.
    {
        string okunan, arananVeri;
        int length_1, length_2;
        ifstream DosyaOku("Notlar.txt", ios::in);
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> arananVeri;
        while (!DosyaOku.eof())//Dosyanın sonunda değilsem aşagıdakiler yapılır.
        {
            getline(DosyaOku, okunan);
            //uzunlukları belirledim.
            length_1 = okunan.length();
            length_2 = arananVeri.length();
            for (int i = 0; i < (length_1 - length_2); i++)
            {
                //okunanın i'ninci karakterinden length_2'nci karakterine kadar okunana atanır.
                //okunan ile arananVeri aynı ise aranan kayıt ekrana basılır.
                if (arananVeri.compare(okunan.substr(i, length_2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << okunan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//Dosyayı kapattım.
    }
}nt;
class kayit//Kayit adında class tanımladım.Amaç Kullanci cözmüş olduğu soru adedlerini yazıp kontrellerini sağlamasıdır.
{
public:
    void kayitEkle()//Dosyaya test kaydı ekliyoruz.
    {
        ofstream DosyaYaz;//Yazma dosyasını açtım.
        DosyaYaz.open("Kayitlar.txt", ios::app);//Kayitlar.txt dosyasını dosya ekleme modunda açtım
        cout << "Id Giriniz :";                   cin >> id; cin.ignore();//kullanıcıdan id girmesini istedim.
        cout << "Ders Adi Giriniz :";             gets_s(ders);//Kullanıcıdan ders adı girmesini istedim.
        cout << "Toplam Cozulen Soru Sayisi :";   cin >> soruSayisi; cin.ignore();//Kulanıcıdan cözdüğü soru adedini istedim.
        DosyaYaz << setw(30) << left << id << setw(30) << left << ders << setw(30) << left << soruSayisi << endl;//Bilgileri dosyaya yazdım.
        cout << "Islem Dosyaya Basariyla Yazildi ...." << endl;//Pozitif sonuc ekrana yazdım.
        DosyaYaz.close();//Dosyayı kapattım.
    }
    void kayitSil()//Dosyadan test kaydı siliyoruz.
    {
        int silineceId;
        cout << "ID Numarasini Giriniz :";
        cin >> silineceId;//Kullanıcıdan silmek istediği id numarsını istedim.
        ifstream DosyaOku("Kayitlar.txt");//Kayitlar.txt adlı okuma dosyası açtım.
        ofstream DosyaYaz("gecicikayit.tmp");//Gecici bir dosya açtım.
        while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Kayitlar.txt dosyasının sonuna kadar okuttum.
        {
            DosyaOku >> id >> ders >> soruSayisi;//Bigileri dosyadan aldım.
            if (silineceId == id)//Girilen id nosu kayıtlarda var ise mevcut test kayıt bilgilrini ekrana yazdım.
            {
                //Silinen test kayıt bilgileri
                cout << "========== Test Kayit Bilgileri ==========" << endl << endl;

                cout << "Id Giriniz :" << id << endl;
                cout << "Ders Adi Giriniz :" << ders << endl;
                cout << "Toplam Cozulen Soru Sayisi :" << soruSayisi << endl;
                cout << "Silme Isleminiz Basariyla Gerceklesmistir..." << endl;
            }
            else//id eşit değilse
                DosyaYaz << setw(30) << left << id << setw(30) << left << ders << setw(30) << left << soruSayisi << endl;
        }
        DosyaYaz.close();//dosyayı kapattım.
        DosyaOku.close();//dosyayı kapattım.
        remove("Kayitlar.txt");//Kayitlar.txt yi sildim.
        rename("gecicikayit.tmp", "Kayitlar.txt");// Gecici dosyalar kayıt silindikten tmp dosyasi txt dosyasina aktarılır.
    }
    void kayitListele()//test kayitlarını listeliyoruz.
    {
        ifstream DosyaOku("Kayitlar.txt", ios::in);//dosyamı açtım.
        string satir;
        while (getline(DosyaOku, satir))//satir satir okudum.
        {
            cout << satir << endl;//Her okunan satir ekrana basılır.
        }
        DosyaOku.close();//Dosyayı kapattım
    }
    void kayitGuncelle()//Test kayıtlarını güncelliyoruz.
    {
        int g_kayit;
        cout << "Guncellenecek Test Bilgisi Icin ID No Giriniz :"; cin >> g_kayit;//Kullanıcıdan guncellemek istediği id numarasını istiyorum.
        int gecicikayit = 0;//Ekrana olumlu yada olumsuz cevap yazmak için ilk degeri 0 atadım.
        ifstream DosyaOku("Kayitlar.txt");//Kayitlar.txt adlı okuma dosyası açtım.
        while (!(DosyaOku.eof())) //DosyaOku da belirttiğim Kayitlar.txt dosyasını sonuna kadar okuttum.
        {
            DosyaOku >> id >> ders >> soruSayisi;//bilgileri dosyadan okudum.
            if (id == g_kayit)//Kullanıcın girdiği id numarası varsa mevcut not bilgilerini ekrana bastım.
            {
                //Mevcut test kayıt  bilgileri
                cout << "========== Mevcut Test Kayit Bilgileri ===========" << endl;

                cout << "ID No :" << id << endl;
                cout <<"Ders Adi Giriniz :" << ders << endl;
                cout << "Toplam Cozulen Soru Sayisi :" << soruSayisi << endl;
                DosyaOku.close();//Dosyayı kapattım.
                break;
            }
        }

        ifstream KayitDosyaOku("kayitlar.txt"); //dosyayı okuma amaçlı açtık.
        ofstream GeciciDosyaYaz("Kayitlar.tmp");;//Geçici tmp dosyası açtım.

        while (KayitDosyaOku >> id >> ders >> soruSayisi)//Bilgiler doğru ise aşağıdaki işlemleri yaptım.
        {
            
            if (g_kayit == id)//Girmiş olduğu id numarası kayitlarda varsa yeni bilgileri istedim.
            {
                cout << "\n Yeni Test Kayit Bilgilerini Giriniz \n";
                cout << "Id Giriniz :";                   cin >> id; cin.ignore();
                cout << "Ders Adi Giriniz :";             gets_s(ders);
                cout << "Toplam Cozulen Soru Sayisi :";   cin >> soruSayisi; cin.ignore();

                GeciciDosyaYaz << setw(30) << left << id << setw(30) << left << ders << setw(30) << left << soruSayisi << endl; //girilen test kayıt bilgilerini dosyaya yazdırdım.
                gecicikayit = 1;;//Pozitif cevap vermek için 1 atadım.
            }
            else
                GeciciDosyaYaz << setw(30) << left << id << setw(30) << left << ders << setw(30) << left << soruSayisi << endl;

        }
        GeciciDosyaYaz.close();//dosyayı kapattım.
        KayitDosyaOku.close();//dosyayı kapattım

        remove("Kayitlar.txt"); //Kayitlar.txt dosyasını sildim.
        rename("Kayitlar.tmp", "Kayitlar.txt"); //Kayitlar.tmp dosyasını Kayitlar.txt dosyasına kopyaladım.

        if (gecicikayit == 0)//Eger gecicikayit 0 ise Negatif sonuc bastırdım.
            cout << "Boyle Bir Test Kayit Bilgisi Bulunmamaktadir..." << endl;
        if (gecicikayit == 1)//Eger gecicikayit 0 ise pozitif sonuc bastırdım.
            cout << "Test Kayit Bilgileri Guncellendi..." << endl;
    }
    void kayitAra()//Dosyadan arama yapıyoruz.
    {

        string okunan, arananVeri;
        int length_1, length_2;
        ifstream DosyaOku("Kayitlar.txt", ios::in);
        cout << "Aramak Istediginiz Veriyi Giriniz :";
        cin >> arananVeri;
        while (!DosyaOku.eof())//Dosyanın sonunda değilsem aşagıdakiler yapılır.
        {
            getline(DosyaOku, okunan);
            //uzunlukları belirledim.
            length_1 = okunan.length();
            length_2 = arananVeri.length();
            for (int i = 0; i < (length_1 - length_2); i++)
            {
                //okunanın i'ninci karakterinden length_2'nci karakterine kadar okunana atanır.(compare)
                //okunan ile arananVeri aynı ise aranan kayıt ekrana basılır.(substr)
                if (arananVeri.compare(okunan.substr(i, length_2)) == 0)
                {
                    cout << "Aranan Kayit" << endl;
                    cout << okunan << endl;
                    break;
                }
            }
        }
        DosyaOku.close();//Dosyayı kapattım.
    }
}test;
class sekil//şekil adında class tanımladım.
{
private:
    string name;
    int kenarSayisi;
public:
    //private erişimi için set fonksiyonlarını tanımladım.
    void setsekilAdiAtamasi(string ad)
    {
        name = ad;
    }
    void setkenarSayisiAdiAtamasi(int _kenar)
    {
        kenarSayisi = _kenar;
    }
    void setAll(string ad , int _kenar)
    {
        name = ad;
        kenarSayisi = _kenar;
    }
    //main bloğunda private özelliklere erişim için get fonksiyonlarını tanımladım.
    string getsekilAdiAtamasi() { return name; }
    int getkenarSayisiAdiAtamasi() { return kenarSayisi; }
};
class Kare:public sekil//Kaltım kullanarak Kare classında sekil classındakileri kullanabildim. 
{
private:
    int kenar; 
public:
    //Constructor tanımladım.
    Kare()
    {
        kenar = 1;
        setsekilAdiAtamasi("KARE");
    }
    Kare(int knr)
    {
        
        setkenarSayisiAdiAtamasi(4);
        setkenarDegeriAtama(knr);

    }
    ~Kare() {};//Destructor  tanımladım.

    int seklinCevresiniHesapla()//Şeklin cevresini hesapladım.
    {
        int cevre = kenar * 4;
        return cevre;
    }
    int seklinAlaniniHesapla()//Şeklin alanını hesapladım.
    {
        int alan = kenar * kenar;
        return alan;
    }
    void setkenarDegeriAtama(int knr)//kenar uzunluğu için kontroller yaptım ve kullanıcıdan kenar uzunluğunu istedim.
    {
        while (knr <= 0)//Kenar sayısı 0 dan küçükse tekrar sayi istedim.
        {
            cout << "!!HATA!! Kenarlar 0 Veya Negatif Olamaz Tekrar Deneyiniz" << endl;
            cout << "Tekrar Deger Giriniz :";
            cin >> knr;
        }
        kenar = knr;
    }
    int getkenarDegeriAtama() { return kenar; }

      friend void sonucEkranaBas(Kare k1);//sonucEkranaBas fonksiyonunu arkadaş fonksiyon olarak tanımladım.
};
void sonucEkranaBas(Kare k1)//Arkadaş fonksiyon olduğu için Kare classındaki seklin çevre ve alanını ekrana bastım.
{
    cout << "Karenin Cevresi : " << k1.seklinCevresiniHesapla() << endl;
    cout << "Karenin Alani : " << k1.seklinAlaniniHesapla() << endl;
}

int main()
{
    system("color 4");//Komut ekranını kırmızı yaptım.
    //Tanımlamalarımı yaptım.
    int secim1 , secim2 , secim3 , secim4 , secim5 , secim6 , secim7;
    int  kac;
    double sayi ,sayi2 , sayi3;
    char devam;
    do
    {
    cout << "==========Hesap Makinesine Hos Geldiniz==========" << endl<<endl;
    
    cout << " Matematiksel Islemler Icin (1)'i Seciniz  " << endl;
    cout << " Geometriksel Islemler Icin (2)'i Seciniz  " << endl;
    cout << " Formul Kitabi Icin (3)'u Seciniz " << endl;
    cout << " Notlar Icin (4)'u Seciniz " << endl;
    cout << " Test Kayit  Icin (5)'u Seciniz " << endl;
    cout << " Lutfen Bir Islem Seciniz :";
    cin >> secim1;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
    switch (secim1)
    {
      case 1://Kullanıcı 1 i secerse aşağıdaki işlemler çalışır.
      {
        system("cls");//Ekranı temizledim.
        cout << "Matematiksel Islemler    :"<< endl;
        cout << "1)Toplama Islemi         " << endl;
        cout << "2)Cikarma Islemi         " << endl;
        cout << "3)Carpma Islemi          " << endl;
        cout << "4)Bolme Islemi           " << endl;
        cout << "5)Mod Alma Islemi        " << endl;
        cout << "6)Faktoriyel Hesabi      " << endl;
        cout << "7)Karakok Hesabi         " << endl;     
        cout << "8)Uslu  Islemler         " << endl;
        cout << "9)Trigonometrik Islemler " << endl;
        cout << "10)Logaritmik Islemler   " << endl;
        cout << "11)2.Dereceden Denklemin Koklerini Bulma " << endl;
        cout << "(Yapacagiz Islemin Numarasini Giriniz)" << endl;
        cin >> secim2;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.

        switch (secim2)
        {
         case 1: //Kullanıcı 1 i secerse aşağıdaki işlemler çalışır.
         {
             //Toplama işlemi
            system("cls");//Ekranı temizledim.
            double toplam = 0;           
            cout << "Kac Sayi Ile Islem Yapmak Istiyorsunuz ? ";
            cin >> kac;//Kullanıcı birden fazla sayıyla işem yapacagı için ilk önce sayı adedini istedim.
            for (int i = 0; i < kac; i++)
            {
                cout <<i+1<< ".Sayiyi Giriniz :";
                cin >> sayi;
                toplam += sayi;
            }
            
            cout << "Sonuc :" << toplam << endl;
            break;
         }
         case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır.
         {
             //Çıkarma işlemi
            system("cls");//Ekranı temizledim.
            double fark = 0;
            cout << "1.Sayiyi Giriniz :";
            cin >> sayi;
            cout << "2.Sayiyi Giriniz :";
            cin >> sayi2;
            fark = sayi - sayi2;
            cout << "Sonuc :" << fark << endl;
            break;
         }
         case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır.
         {
             //Çarpma işlemi
            system("cls");//Ekranı temizledim.
            double carpma=1;
            cout << "Kac Sayi Ile Islem Yapmak Istiyorsunuz ? ";
            cin >> kac;//Kullanıcı birden fazla sayıyla işem yapacagı için ilk önce sayı adedini istedim.
            for (int i = 0; i < kac; i++)
            {
                cout << i + 1 << ".Sayiyi Giriniz :";
                cin >> sayi;
                carpma *= sayi;
            }
            cout << "Sonuc :" << carpma << endl;
            break;
         }
         case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır.
         {
             //Bölme işlemi
             system("cls");//Ekranı temizledim.
             double sonuc = 0;
             cout << "1.Sayiyi Giriniz :";
             cin >> sayi;
             cout << "2.Sayiyi Giriniz :";
             cin >> sayi2;
             while (sayi < sayi2)//Bölme işleminde sayi2 sayi dan büyük olursa yanlış olacaktır.
             {
                 //Kullanıcıdan yeniden sayiları ıstedim.
                 cout << "!! HATA !! (1.Sayi 2.Sayiden Buyuk Olamaz) " << endl;
                 cout << "Tekrar Deneyiniz " << endl;
                 cout << "Tekrar 1.Sayiyi Giriniz :";
                 cin >> sayi;
                 cout << "Tekrar 2.Sayiyi Giriniz :";
                 cin >> sayi2;
             }
             sonuc = sayi / sayi2;
             cout << "Sonuc :" << sonuc << endl;
             break;
         }
         case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır.
         {
             //Mod alma
             system("cls");//Ekranı temizledim.
             int x, y;
             cout << "1.Sayiyi Giriniz :";
             cin >> x;
             cout << "2.Sayiyi Giriniz :";
             cin >> y;
             if (y < x)
             {
                 cout << "Sonuc :" << x % y << endl;
             }
             else
             {
                 cout << "1.Sayi 2.Sayidan Buyuk Olamaz." << endl;
                 cout << "Lutfen Sayilari Konrtol Ediniz..." << endl;
             }
             break;
         }
         case 6://Kullanıcı 6 i secerse aşağıdaki işlemler çalışır.
         {
             //Faktoriyel hesabı
             system("cls");//Ekranı temizledim.
             int faktoriyel=1;
             cout << "Faktoriyelini Hesaplamak Istediginiz Sayiyi Giriniz :";
             cin >> sayi;
             for (int i = 1; i <= sayi; i++)
             {
                 faktoriyel *= i;
             }
             cout << "Sonuc :" << faktoriyel << endl;
             break;
         }
         case 7://Kullanıcı 7 i secerse aşağıdaki işlemler çalışır.
         {
             //Karakök hesabı
             system("cls");//Ekranı temizledim.
             cout << "Karekokunu Hesaplamak Istediginiz Sayiyi Giriniz :";
             cin >> sayi;
             cout << "Sonuc :" << sqrt(sayi) << endl;
             break;
         }
         case 8://Kullanıcı 8 i secerse aşağıdaki işlemler çalışır.
         {
             //üst hesabı
             system("cls");//Ekranı temizledim.
             cout << "Sayinin Tabanini Giriniz :";
             cin >> sayi;
             cout << "Us Degerini Giriniz :";
             cin >> sayi2;
             cout << "Sonuc :" << pow(sayi, sayi2) << endl;
             break;
         }
         case 9://Kullanıcı 9 i secerse aşağıdaki işlemler çalışır.
         {
             //Trigonometrik işlemler
             system("cls");//Ekranı temizledim.
             double radyan;
             cout << "Trigonometrik Islem Yapacaginiz Sayiyi Griniz :";
             cin >> sayi;
             radyan = (3.141593 / 180) * sayi; //Derece cinsinden işlem yapılmadığı için radyana çevirdim.
             cout << "Trigonometrik Fonksiyonu Seciniz:" << endl;
             cout << "1) Sinus " << endl;
             cout << "2) Cosinus " << endl;
             cout << "3) Tanjant " << endl;
             cout << "4) Cotanjant " << endl;
             cout << "5) Sekant " << endl;
             cout << "6) Kosekant " << endl;
             cout << "(Yapacagiz Islemin Numarasini Giriniz) :";
             cin >> secim3;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
             switch (secim3)
             {
             case 1://Kullanıcı 1 i secerse aşağıdaki işlemler çalışır.
                 cout << "Sin(" << sayi << ") :" << sin(radyan) << endl;
                 break;
             case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır.
                 cout << "Cos(" << sayi << ") :" << cos(radyan) << endl;
                 break;
             case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır.
                 cout << "Tan(" << sayi << ") :" << tan(radyan) << endl;
                 break;
             case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır.
                 cout << "Cot(" << sayi << ") :" <<  pow(tan(radyan) , -1 ) << endl;
                 break;
             case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır.
                 cout << "Sec(" << sayi << ") :" << ( 1 / cos(radyan) ) << endl;
                 break;
             case 6://Kullanıcı 6 i secerse aşağıdaki işlemler çalışır.
                 cout << "Cosec(" << sayi << ") :" << (1 / sin(radyan)) << endl;
                 break;
             default:
                 cout << "Yanlis Tuslama Yaptiniz" << endl;
                 break;
             }
             break;
         }
         case 10://Kullanıcı 10 i secerse aşağıdaki işlemler çalışır.
         {
             //Logaritma hesabı
             system("cls");//Ekranı temizledim.
             cout << "Logaritmasini Hesaplamak Istediginiz Sayiyi Giriniz :";
             cin >> sayi;
             cout << "Log(" << sayi << ") :" << log(sayi) << endl;
             break;
         }
         case 11://Kullanıcı 11 i secerse aşağıdaki işlemler çalışır.
         {
             //2.Dereceden Denklemin Koklerini Bulma
             system("cls");//Ekranı temizledim.
             float x, y, z;
             float a;
             float x1, x2;
             cout << " Denklemin x , y ve z Katsayilarini giriniz:"<<endl;
             cout << "X :";  cin >> x;
             cout << "Y :";   cin >> y;
             cout << "Z :";  cin >> z;
             a = y * y - 4 * x * z;
             if (a < 0)
             {
                 cout << "Gercel Kok Yok"<<endl;
             }
             else
             {
                 if (a == 0)
                 {
                     x1 = -y / (2 * x);
                     cout << x1 << " " << "Noktasinda Cakisan Iki Kok Vardir." << endl;
                 }
                 else
                 {
                     x1 = (-y + sqrt(a)) / (2 * x);
                     x2 = (-y - sqrt(a)) / (2 * x);
                     cout << x1 << " " << "Ve" << " " << x2 << " " << "Noktalarinda Iki Gercel Kok Vardir." << endl;
                 }
             }
             break;
         }

         default:
             cout << "Yanlis Tuslama Yaptiniz" << endl;
             break;
        }
        break;
      }
      case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır.
      {
          system("cls");//Ekranı temizledim.
          cout << "Geometriksel Islemler    :" << endl;
          cout << "1)Karenin Alanini Ve Cevresini Hesaplama :" << endl;
          cout << "2)Dikdortgen Alan Ve Cevre Hesaplama :" << endl;
          cout << "3)Ucgen Cevre Hesaplama :" << endl;
          cout << "4)Dik Ucgende Pisagor Hesaplama :" << endl;
          cout << "5)Eskenar Dortgen Alan Hesaplama :" << endl;
          cout << "6)Paralelkenar Alan Hesaplama :" << endl;
          cout << "7)Yamuk Alan Hesaplama :" << endl;
          cout << "(Yapacagiz Islemin Numarasini Giriniz)" << endl;
          cin >> secim4;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
          switch (secim4)
          {
          case 1://Kullanıcı 1 i secerse aşağıdaki işlemler çalışır.
          {
              //)Karenin Alanini Ve Cevresini Hesaplama
              system("cls");//Ekranı temizledim.
              int x;
              system("cls");
              Kare k1(1);//k1 i sınıf tanımladım 
              cout << "Karenin Kenar Uzunlugunu Giriniz:";
              cin >> x;//Kullanıcıdan bir kenar uzunluğu aldım.
              k1.setkenarDegeriAtama(x);//Kenar degerini atadım
              sonucEkranaBas(k1);//sonuçları ekrana bastım.
              break;
          }

          case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır.
          {
              //Dikdortgen Alan Ve Cevre Hesaplama
              system("cls");//Ekranı temizledim.
              cout << "Dikdortgenin Uzun Kenarini Girniz :";
              cin >> sayi;
              cout << "Dikdortgenin Kisa Kenarini Giriniz :";
              cin >> sayi2;
              if (sayi > 0 && sayi2 >= 0)
              {
                  cout << "Dikdortgenin Cevresi :" << (sayi + sayi2) * 2 << endl;
                  cout << "Dikdortgenin Alani :" << sayi * sayi2 << endl;
              }
              else
                  cout << "Kenar Uzunluklari Negatif Bir Deger Alamaz." << endl;
              break;
          }

          case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır.
          {
              //Ucgen Cevre Hesaplama
              system("cls");//Ekranı temizledim.
              cout << "Ucgenin Kenar Uzunluklarini Giriniz :"<<endl;
              cout << "Kenar 1 :";
              cin >> sayi;
              cout << "Kenar 2 :";
              cin >> sayi2;
              cout << "Kenar 3 :";
              cin >> sayi3;
              if (sayi>0 && sayi2>0 && sayi3>0)
              {
                  cout << "Ucgenin Cevresi :" << sayi + sayi2 + sayi3 << endl;
              }
              else
                  cout << "Kenar Uzunluklari Negatif Bir Deger Alamaz." << endl;
              break;
          }

          case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır.
          {
              //Dik Ucgende Pisagor Hesaplama
              system("cls");//Ekranı temizledim.
              double pisagor;
              cout << "Dik Ucgenin 1.Kenarini Giriniz :";
              cin >> sayi;
              cout<< "Dik Ucgenin 2.Kenarini Giriniz :";
              cin >> sayi2;
              if (sayi > 0 && sayi2 > 0)
              {
                  pisagor = sqrt(pow(sayi, 2) + pow(sayi2, 2));
                  cout << "Sonuc :" << pisagor << endl;
              }
              
              break;
          }

          case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır.
          {
              //Eskenar Dortgen Alan Hesaplama
              system("cls");//Ekranı temizledim.
              cout << "Eskear Dortgenin Kosegenlerini Giriniz :" << endl;
              cout << "Kosegen 1 :";
              cin >> sayi;
              cout << "Kosegen 2 :";
              cin >> sayi2;
              if (sayi>0 && sayi2>0)
              {
                  cout << "Eskenar Dortgenin Alani : " << (sayi + sayi2) / 2 << endl;
              }
              
              break;
          }

          case 6://Kullanıcı 6 i secerse aşağıdaki işlemler çalışır.
          {
              //Paralelkenar Alan Hesaplama
              system("cls");//Ekranı temizledim.
              cout << "Paralelkenarin Yuksekligini Giriniz :";
              cin >> sayi;
              cout << "Paralelkenarin Taban Uzunlugunu Giriniz :";
              cin >> sayi2;
              if (sayi > 0 && sayi2 > 0)
              {
                  cout << "Paralelkenarin Alani :" << sayi * sayi2 << endl;
              }
              
              break;
          }

          case 7://Kullanıcı 7 i secerse aşağıdaki işlemler çalışır.
          {
              //Yamuk Alan Hesaplama 
              system("cls");//Ekranı temizledim.
              cout << "Alt Taban Giriniz:";
              cin >> sayi;
              cout << "Ust Taban Giriniz:";
              cin >> sayi2;
              cout << "Yuksekligi Giriniz:";
              cin >> sayi3;
              if (sayi > 0 && sayi2 > 0 && sayi3>0)
              {
                  cout << "Alan:" << " " << sayi3 * (sayi + sayi2) / 2 << endl;
              }
              break;
          }

          break;

          }//secim4 switch
          break;
      }  
      case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır.
      {
          system("cls");//Ekranı temizledim.
          cout << "======== Formul Kitabi ========" << endl<<endl;
          cout << "1- Formul Ekle " << endl;
          cout << "2- Formul Sil " << endl;
          cout << "3- Formul Listele " << endl;
          cout << "4- Formul Guncelle " << endl;
          cout << "5- Formul Ara " << endl;
          cout << "Yapmak Istediginiz Islemin Numarasini Giriniz :";
          cin >> secim5;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
          switch (secim5)
          {
          case 1://Kullanıcı 1 i secerse aşağıdaki işlemler çalışır
          {
              //Formul Ekle
              system("cls");//Ekranı temizledim.
              cout << "===Formul Ekleme===" << endl <<endl;
              frml.formulEkle();
              break;
          }
          case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır
          {
              //Formul Sil
              system("cls");//Ekranı temizledim.
              cout << "===Formul Silme===" << endl << endl;
              frml.formulSil();
              break;
          }
          case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır
          {
              //Formul Listele
              system("cls");//Ekranı temizledim.
              cout << "===Formul Listesi===" << endl << endl;
              frml.formulListele();
              break;
          }
          case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır
          {
              //Formul Guncelle
              system("cls");//Ekranı temizledim.
              cout << "===Formul Guncelleme===" << endl << endl;
              frml.formulGuncelle();
              break;
          }
          case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır
          {
              //Formul Ara
              system("cls");//Ekranı temizledim.
              cout << "===Formul Arama===" << endl << endl;
              frml.formulAra();
              break;
          }
          default:
              cout << "Yanlis Tuslama Yaptiniz" << endl;
              break;
          }
          break;
      }
      case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır.
      {
          system("cls");//Ekranı temizledim.
          cout << "==========Notlarim==========" << endl<<endl;
          cout << "1- Not Ekle " << endl;
          cout << "2- Not Sil " << endl;
          cout << "3- Not Listele " << endl;
          cout << "4- Not Guncelle " << endl;
          cout << "5- Not Ara " << endl;
          cout << "Yapmak Istediginiz Islemin Numarasini Giriniz :";
          cin >> secim6;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
          switch (secim6)
          {
          case 1:
          {
              //Not Ekle
              system("cls");
              cout << "===Not Ekleme=== " << endl<< endl;
              nt.notEkle();
              break;
          }
          case 2:
          {
              // Not Sil
              system("cls");
              cout << "===Not Silme=== " << endl << endl;
              nt.notSil();
              break;
          }
          case 3:
          {
              //Not Listele
              system("cls");
              cout << "===Not Listesi=== " << endl << endl;
              nt.notListele();
              break;
          }
          case 4:
          {
              //Not Guncelle 
              system("cls");
              cout << "===Not Guncelleme=== " << endl << endl;
              nt.notGuncelle();
              break;
          }
          case 5:
          {
              //Not Ara
              system("cls");
              cout << "===Not Ara=== " << endl << endl;
              nt.notAra();
              break;
          }
          default:
              cout << "!! Yanlis Tuslama Yaptiniz !!" << endl;
              break;
          }
          break;
      }
      case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır.
      {
          system("cls");//Ekranı temizledim.
          cout << "=======Test Kayit Belgem========" << endl << endl;
          cout << "1- Kayit Ekle " << endl;
          cout << "2- Kayit Sil " << endl;
          cout << "3- Kayit Listele " << endl;
          cout << "4- Kayit Guncelle " << endl;
          cout << "5- Kayit Ara " << endl;
          cout << "Yapmak Istediginiz Islemin Numarasini Giriniz :";
          cin >> secim7;//Kullanıcıdan yukarıdakiler arasında seçim yapmasını istedim.
          switch (secim7)
          {
          case 1://Kullanıcı 1 i secerse aşağıdaki işlemler çalışır.
          {
              // Kayit Ekle
              system("cls");
              cout << "===Kayit Ekleme===" << endl << endl;
              test.kayitEkle();
              break;
          }
          case 2://Kullanıcı 2 i secerse aşağıdaki işlemler çalışır.
          {
              // Kayit Sil
              system("cls");
              cout << "===Kayit Silme===" << endl << endl;
              test.kayitSil();
              break;
          }
          case 3://Kullanıcı 3 i secerse aşağıdaki işlemler çalışır.
          {
              //Kayit Listele
              system("cls");
              cout << "===Kayit Listesi===" << endl << endl;
              test.kayitListele();
              break;
          }
          case 4://Kullanıcı 4 i secerse aşağıdaki işlemler çalışır.
          {
              //Kayit Guncelle
              system("cls");
              cout << "===Kayit Guncelleme===" << endl << endl;
              test.kayitGuncelle();
              break;
          }
          case 5://Kullanıcı 5 i secerse aşağıdaki işlemler çalışır.
          {
              //Kayit Ara
              system("cls");
              cout << "===Kayit Arama===" << endl << endl;
              test.kayitAra();
              break;
          }
          default:
              cout << "!!Yanlis Tuslama Yaptiniz!!" << endl;
              break;
          }
          break;

      }
      
    }
    cout << "Devam Etmek Istiyor Musunuz (E-e / H-h) :";
    cin >> devam;//Kullanıcıya devam edip etmeyecegini sordum.

    }while (devam=='e' || devam=='E');//E veya e secerse tekrar başa dönecek.
     return 0;
    }
