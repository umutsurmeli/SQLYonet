﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLYonet
{
    public partial class DilSeciciKontrol : UserControl
    {
        public DilSeciciKontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DilSec.tr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DilSec.en();
        }
        
        void DilGuncellemeCalistir( MethodInvoker FormTextleriDegistir)
        {
            FormTextleriDegistir();
        }
        
    }

    static class DilSec
    {
        //Bu alanda daha önce PHP projelerinde kullanmış olduğum dil değiştirme mantığını uygulamaya çalışıyorum.
        //Kaynak olarak dil PHP dil dosyalarımı değiştirip kullanacağım bazı kelimeler bu projede herhangi bir anlam
        // ifade etmez ancak ihtiyaç duydukça onları değiştirerek kullanacağım. Ayrıca çeviri konusunda da bazı hatalarım olabilir.
        public static string ProgramBaslik = " MySQL YÖNET - Umut SÜRMELİ 2019 ";
        public static string aktifdil;
        public static string yetkiniz_yok;
        public static string adminn;
        public static string firstpass;
        public static string secondpass;
        public static string baslik;
        public static string AnaSayfa;
        public static string giris;
        public static string kapat;
        public static string Duzenle;
        public static string Incele;
        public static string kopyalandi;
        public static string upload_fail;
        public static string yenikla_succes;
        public static string sayfa_olusturuldu;
        public static string yenikla_fail;
        public static string yenikla_prompt;
        public static string silindi;
        public static string silinemedi;
        public static string silinsinmi;
        public static string kaydet;
        public static string KaydetBitir;
        public static string iptal;
        public static string diz;
        public static string silonay;
        public static string silmeonay_caption;
        public static string klasor_;
        public static string cikis;
        public static string CikmakMi;
        public static string klasorundesin;
        public static string klasoru;
        public static string klasor_sec;
        public static string hedef_klasor;
        public static string Hedef;
        public static string KODLA;
        public static string ZIPCOZ;
        public static string def_dir;
        public static string up_dir;
        public static string temiz;
        public static string YUKLE;
        public static string KesKopyalaYapistirLegend;
        public static string yenikla_sb;
        public static string BOS;
        public static string sekmedeAc;
        public static string sekmeAc;
        public static string yuklemeSecButon;
        public static string yuklemeSec;
        public static string ResimSec;
        public static string oturum_yok;
        public static string oturum_sonlandirildi;
        public static string OturumBolgesiDegisti;
        public static string OturumIdDegisti;
        public static string AcilacakKlasorYolunuSor;
        public static string SonYuklemeler;
        public static string AdDegistirNesneSec;
        public static string AdDegistirSadeceBir;
        public static string ChmodNesneSec;
        public static string SadeceBirTaneSec;
        public static string AdYeniYaz;
        public static string AdZatenVar;
        public static string AdGecersizDosyaKlasor;
        public static string EnAzBirNoktaIcermeli;
        public static string Kullanilamaz;
        public static string AdYeniOlmadi;
        public static string AdDegisti;
        public static string zaten_var;
        public static string YeniDosyaAdiGir;
        public static string YeniDosyaAdiGecersiz;
        public static string YeniDosyaUzantisiGecersiz;

        public static string LISTE_BUTONLAR_ADLANDIR;
        public static string LISTE_BUTONLAR_YENI_KLASOR;
        public static string LISTE_BUTONLAR_SIL;
        public static string LISTE_BUTONLAR_KES;
        public static string LISTE_BUTONLAR_KOPYALA;
        public static string LISTE_BUTONLAR_YAPISTIR;
        public static string LISTE_BUTONLAR_ZIPLE;
        public static string LISTE_BUTONLAR_YENI_DOSYA;

        public static string USTUNE_YAZ;
        public static string DAIMA_USTUNE_YAZ;
        public static string YapistirKaynakEkleSec;
        public static string OlusturulanKlasor;
        public static string SayilanKlasor;
        public static string YapistirilanDosya;
        public static string SayilanDosya;
        public static string Kaynak;
        public static string KAYNAK_BOS;
        public static string HEDEF_BOS;
        public static string Kopyala;
        public static string BASARISIZ;
        public static string BASARILI;
        public static string TumunuSecButon;
        public static string TumunuBirakButon;
        public static string TumunuTemizleButon;

        public static string KOPYALAVESIL;
        public static string KOPYALAVESIL_HATASI;
        public static string TASINDI;
        public static string TASINDI_HATASI;
        public static string BULUNAMADI;
        public static string KENDI_ICINE_KOPYALANMAZ;
        public static string KLASOR_KENDI_ICINE_ARSIVLENMEZ;
        public static string ARSIV_KENDI_ICINE_ARSIVLENMEZ;

        public static string ZIP_DEGIL;
        public static string HATA;
        public static string ZIPLI_DOSYA_SEC;
        public static string ARSIV_UNZIP_LEGEND;
        public static string ARSIV_ZIP_LEGEND;
        public static string ARSIV_UNZIP_BITIR;
        public static string ARSIV_ZIP_BITIR;
        public static string ZIP_HEPSI_BIRDEN;
        public static string ZIP_TEKTEK;
        public static string ZIPLENDI;
        public static string ZipleKaynakEkleSec;
        public static string ZipArsivAdiGir;
        public static string ZipArsivAdiGecersiz;
        public static string VE;
        public static string VEYA;
        public static string EKSIK_VERI;
        public static string UNZIPLENDI;
        public static string EDITOR_DOSYA_SEC;
        public static string KAYDEDILDI;


        public static string UyeOl;
        public static string BosOlmaz;
        public static string EnAz;
        public static string EMailTekrar;
        public static string EMailTekrariAyniDegil;
        public static string EMailGecersiz;
        public static string EMailKullaniliyor;
        public static string EmailDogrulamaBaslik;
        public static string LutfenGirisKontrolEdin;
        public static string UyelikOlusturuldu;
        public static string SpamMailiKontrolEt;
        public static string BirHataOlustuBizeYazin;
        public static string Tiklayin;
        public static string UyelikEMailBilgilendirme;
        public static string Alaniniz;
        public static string KullaniciAdi;
        public static string KullaniciAdiEnAz;
        public static string KullaniciAdiKullaniliyor;
        public static string AlanAdi;
        public static string AlanAdiEnAz;
        public static string AlanAdiOrnek;
        public static string Sifre;
        public static string SifreEnAz;
        public static string SifreTekrar;
        public static string SifreTekrariUyusmuyor;
        public static string SifreIcermeliIsaret;
        public static string SifreIcermeliRakam;
        public static string SifreSadeceRakamOlamaz;
        public static string KayitOl;

        public static string GirisOlumsuzMesaj;

        public static string KlasorunuzeErisilemiyor;
        public static string AnaDizinDegismez;
        public static string HedefleKaynakAyni;

        public static string Yonet;
        public static string DosyaYoneticisi;
        public static string SQLTablolar;
        public static string SablonKurulum;
        public static string Sablonlar;
        public static string Kur;
        public static string Kullanici;
        public static string Sunucular;
        public static string Baglan;
        public static string Baglanti;
        public static string BaglantiSaglanamadi;
        public static string BaglantiAdi_Lbl;
        public static string TekrarBaglan;
        public static string DBHost_Lbl;
        public static string DBUser_Lbl;
        public static string DBPass_Lbl;
        public static string Yeni;
        public static string Demo;
        public static string Hosgeldin;
        public static string Lutfen;
        public static string SunucuSec;
        public static string Bu;
        public static string SunaGore;
        public static string Artan;
        public static string KacarliCvp;
        public static string Sayfa;
        public static string Satir;
        public static string Geri;
        public static string Ileri;
        public static string Sirala;
        public static string HenuzDegistirilmedi;
        public static string VeriTabani;
        public static string Olustur;
        public static string Ekle;
        public static string KarakterKarsilastirma;
        public static string Adi;
        public static string Secin;
        public static string Bir;
        public static string DilKarsilastirmasi;
        public static string YaziYaz;
        public static string Tablo;
        public static string Veri;
        public static string Yapi;
        public static string Sadece;
        public static string Islem;
        public static string YokEdilecek;
        public static string YokEt;
        public static string Bosalt;
        public static string Calistir;
        public static string Komut;
        public static string Sorgu;
        public static string Etkilenenler;

        public static void tr()
        {
            aktifdil = "tr";
            yetkiniz_yok = "Yetkiniz yok";
            adminn = "Yönetici:";
            firstpass = "Birinci Şifre:";
            secondpass = "İkinci Şifre:";
            baslik = "PHP Dosya Yöneticisi";
            AnaSayfa = "Ana Sayfa";
            giris = "Giriş";
            kapat = "Kapat";
            Duzenle = "Düzenle";
            Incele = "İncele";
            kopyalandi = "kopyalandı";
            upload_fail = "Yükleme gerçekleşmedi!";
            yenikla_succes = "oluşturuldu";
            sayfa_olusturuldu = "sayfa oluşturuldu";
            yenikla_fail = "oluşturulamadı!";
            yenikla_prompt = "YeniKlasor";
            silindi = "silindi!";
            silinemedi = "silinemedi!";
            silinsinmi = "silinsin mi";
            kaydet = "Kaydet";
            KaydetBitir = "Kaydet Ve Bitir";
            iptal = "İptal";
            diz = "diz";
            silonay = "seçili dosyaları silmek için TAMAM (OK)\n vazgeçmek için İPTAL (CANCEL) \n tuşuna basın!";
            silmeonay_caption = "Silme Onay!";
            klasor_ = "Klasör:";
            cikis = "Çıkış";
            CikmakMi = "Çıkmak istediğinize emin misiniz?";
            klasorundesin = "klasöründesiniz";
            klasoru = "klasörü";
            klasor_sec = "bir klasör seçiniz";
            hedef_klasor = "Hedef Klasör:";
            Hedef = "Hedef";
            KODLA = "kodla";
            ZIPCOZ = "zip çöz";
            def_dir = "varsayılan dizin";
            up_dir = "üst dizin";
            temiz = "Temizle";
            YUKLE = "Yükle";
            KesKopyalaYapistirLegend = "(Kes | Kopyala) Yapıştır";
            yenikla_sb = "yeni klasör";
            BOS = "Bu klasör boş";
            sekmedeAc = "Yeni sekmede aç";
            sekmeAc = "Yeni sekme aç";
            yuklemeSecButon = "Dosya seç";
            yuklemeSec = "Lütfen dosya seçmek için yükle butonuna basınız!";
            ResimSec = "Lütfen bir resim seçin!";
            oturum_yok = "Lütfen giriş yapın";
            oturum_sonlandirildi = "Oturum sonlandırıldı.";
            OturumBolgesiDegisti = "Oturum yeri değişti, lütfen tekrar giriş yapın.";
            OturumIdDegisti = "Oturum bilgisi değişti! lütfen tekrar giriş yapın.";
            AcilacakKlasorYolunuSor = "Yolunu yazacağım klasörü aç:";
            SonYuklemeler = "Son Yüklemeler";
            AdDegistirNesneSec = "Adını değiştirmek için bir dosya veya klasör seçmelisin!";
            AdDegistirSadeceBir = "Her seferde sadece 1 dosya ya da klasör adı değiştirebilirsin!";
            ChmodNesneSec = "Lütfen chmod kullanmak istediğin dosya ya da klasörü seç!";
            SadeceBirTaneSec = "Her seferde sadece 1 tane dosya ya da klasör seçebilirsin!";
            AdYeniYaz = "Lütfen yeni adını yaz:";
            AdZatenVar = "Bu isimde bir dosya veya bir klasör var! Başka bir isim seç!";
            AdGecersizDosyaKlasor = "Dosya isimlerinde \".\" ve \"_\" , klasör isimlerinde \"_\" kullanılabilir.";
            EnAzBirNoktaIcermeli = " En az bir nokta içermeli. ";
            Kullanilamaz = "Kullanılamaz: ";
            AdYeniOlmadi = "Ad Değiştirilemedi!";
            AdDegisti = "Adı değişti.";
            zaten_var = "zaten var!";
            YeniDosyaAdiGir = "Lütfen yeni dosya adını uzantısıyla birlikte giriniz.";
            YeniDosyaAdiGecersiz = "Dosya adı geçerli değil!";
            YeniDosyaUzantisiGecersiz = "Dosya uzantısı geçersiz!";

            LISTE_BUTONLAR_ADLANDIR = "Adını Değiştir";
            LISTE_BUTONLAR_YENI_KLASOR = "Yeni Klasör";
            LISTE_BUTONLAR_SIL = "Sil";
            LISTE_BUTONLAR_KES = "Kes";
            LISTE_BUTONLAR_KOPYALA = "Kopyala";
            LISTE_BUTONLAR_YAPISTIR = "Yapıştır";
            LISTE_BUTONLAR_ZIPLE = "ZipeEkle";
            LISTE_BUTONLAR_YENI_DOSYA = "Yeni Dosya";

            USTUNE_YAZ = "Üstüne yaz";
            DAIMA_USTUNE_YAZ = "Daima üstüne yaz";
            YapistirKaynakEkleSec = "Lütfen yapıştırmak istediğiniz kaynağı ekleyin ya da seçin";
            OlusturulanKlasor = "Oluşturulan Klasör";
            SayilanKlasor = "Sayılan Klasör";
            YapistirilanDosya = "Yapıştırılan Dosya";
            SayilanDosya = "Sayılan Dosya";
            Kaynak = "Kaynak";
            KAYNAK_BOS = "Kaynak seçilmedi!";
            HEDEF_BOS = "Hedef seçilmedi!";
            Kopyala = "Kopyala";
            BASARISIZ = "BAŞARISIZ";
            BASARILI = "BAŞARILI";
            TumunuSecButon = "Tümünü seç";
            TumunuBirakButon = "Tümünü bırak";
            TumunuTemizleButon = "Temizle";// Satır:30 'temiz'

            KOPYALAVESIL = "TAŞINDI (KopyalaVeSil)";
            KOPYALAVESIL_HATASI = "TAŞIMADA HATA (KopyalaVeSil)";
            TASINDI = "TAŞINDI";
            TASINDI_HATASI = "TAŞIMADA HATA";
            BULUNAMADI = "BULUNAMADI";
            KENDI_ICINE_KOPYALANMAZ = "Klasör kendi içine kopyalanamaz!";
            KLASOR_KENDI_ICINE_ARSIVLENMEZ = "Klasör kendi içine arşivlenmez!";
            ARSIV_KENDI_ICINE_ARSIVLENMEZ = "Zip arşiv dosyası kendi içine eklenemez!";

            ZIP_DEGIL = "zip arşivi değil!";
            HATA = "HATA";
            ZIPLI_DOSYA_SEC = "Lütfen sermek istediğiniz zip  arşivini listeden tıklayınız!";
            ARSIV_UNZIP_LEGEND = "Zipten çıkar";
            ARSIV_ZIP_LEGEND = "Zip Arşivi Oluştur";
            ARSIV_UNZIP_BITIR = "Zipten çıkarmayı tamamla!";
            ARSIV_ZIP_BITIR = "Seçilenleri Ziple";
            ZIP_HEPSI_BIRDEN = "Tek seferde ziple";
            ZIP_TEKTEK = "Tek tek ziple";
            ZIPLENDI = "Ziplendi";
            ZipleKaynakEkleSec = "Lütfen Ziplemek istediğiniz kaynağı ekleyin ya da seçin";
            ZipArsivAdiGir = "Lütfen zip arşiv adı yazınız!";
            ZipArsivAdiGecersiz = "Zip adında geçersiz karakter!";
            VE = " ve ";
            VEYA = " veya ";
            EKSIK_VERI = "Eksik veri!";
            UNZIPLENDI = "Zip yayıldı";
            EDITOR_DOSYA_SEC = "Kaynağını görüntülemek istediğiniz dosyayı seçin!";
            KAYDEDILDI = "kaydedildi";


            UyeOl = "Üye Ol";
            BosOlmaz = "Boş bırakılamaz! ";
            EnAz = "En az: ";
            EMailTekrar = "EMail Tekrar";
            EMailTekrariAyniDegil = "EMail ve tekrari aynı değil!";
            EMailGecersiz = "EMail geçersiz ";
            EMailKullaniliyor = "Bu EMail kullanılıyor. ";
            EmailDogrulamaBaslik = "EMail doğrulama ";
            LutfenGirisKontrolEdin = "Lütfen giriş bilgilerinizi tekrar kontrol ediniz!";
            UyelikOlusturuldu = "Hesabınız oluştruldu. ";
            SpamMailiKontrolEt = "Doğrulama için lütfen e-mailinizin inbox/spam/junk/gereksiz kutusu dahil olmak üzere kontrol ediniz. ";
            BirHataOlustuBizeYazin = "Bir hata oluştu lütfen bizimle iletişime geçin!";
            Tiklayin = "lütfen tıklayın";
            UyelikEMailBilgilendirme = "Aramıza hoşgeldiniz. \r\n EMailinizi doğrulamak için aşağıdaki bağlantıyı tıklayınız \r\n ya da adres satırına yapıştırınız.\r\n";
            Alaniniz = "Alanınız ";
            KullaniciAdi = "Kullanıcı Adı";
            KullaniciAdiEnAz = "Kullanıcı adı en az: ";
            KullaniciAdiKullaniliyor = "Bu kullanıcı adı kullanılıyor. ";
            AlanAdi = "Alan Adı";
            AlanAdiEnAz = "Alan adı en az: ";
            AlanAdiOrnek = "alanadi";
            Sifre = "Şifre";
            SifreEnAz = "Şifre en az: ";
            SifreTekrar = "Şifre Tekrar";
            SifreTekrariUyusmuyor = "Şifre ve tekrarı aynı değil!";
            SifreIcermeliIsaret = "Şifre sembol ya da işaret içermeli";
            SifreIcermeliRakam = "Şifre en az bir rakam içermeli";
            SifreSadeceRakamOlamaz = "Şifre sadece rakamlardan oluşamaz";
            KayitOl = "Kayıt Ol";

            GirisOlumsuzMesaj = "EMail ya da şifre hatalı!";

            KlasorunuzeErisilemiyor = "Klasörünüzün bilgisine erişilemiyor.";
            AnaDizinDegismez = "Ana klasörünüzü değiştiremezsiniz!";
            HedefleKaynakAyni = "Seçilen hedefle kaynak aynı";

            Yonet = "Yönet";
            DosyaYoneticisi = "Dosya Yöneticisi";
            SQLTablolar = "SQL Tablolar";
            SablonKurulum = "Şablon Kurulum";
            Sablonlar = "Şablonlar";
            Kur = "Kur";
            /*2019-02-13  Sonrası */
            Kullanici = "Kullanıcı";
            Sunucular = "Sunucular";
            Baglan = "Bağlan";
            Baglanti = "Bağlantı";
            BaglantiSaglanamadi = "Bağlantı sağlanamadı!";
            BaglantiAdi_Lbl = "Bağlantı Adı";
            TekrarBaglan = "Tekrar Bağlan";
            DBHost_Lbl = "V.T. Sunucu (IP / Host Adı)";
            DBUser_Lbl = "V.T. Kullanıcı";
            DBPass_Lbl = "V.T. Parola";
            Yeni= "Yeni";
            Demo = "Demo";
            Hosgeldin = "Hoşgeldin";
            Lutfen = "Lütfen";
            SunucuSec = "Sunucu seçiniz!";
            Bu = "Bu";
            SunaGore = "Şuna göre";
            Artan = "Artan";
            KacarliCvp ="adet göster";
            Sayfa = "Sayfa";
            Satir = "Satır";
            Geri = "Geri";
            Ileri = "İleri";
            Sirala = "Sırala";
            HenuzDegistirilmedi = "Henüz değiştirilmedi";
            VeriTabani = "Veritabanı";
            Olustur = "Oluştur";
            Ekle ="Ekle";
            KarakterKarsilastirma = "Karakter karşılaştırması";
            Adi = "Adı";
            Secin = "Seçin";
            Bir = "Bir";
            DilKarsilastirmasi = "Dil Kodlaması";
            YaziYaz = "Yazın";
            Tablo = "Tablo";
            Veri = "Veri";
            Yapi = "Yapı";
            Sadece = "Sadece";
            Islem = "İşlem";
            YokEdilecek = "Yok Edilecek";
            YokEt = "Yok Et";
            Bosalt = "Boşalt";
            Calistir = "Çalıştır";
            Komut = "Komut";
            Etkilenenler = "Etkilenenler";
            Sorgu = "Sorgu";

    }
    public static void en()
        {
            aktifdil = "en";
            yetkiniz_yok = "You do not have access";
            adminn = "Administrator:";
            firstpass = "First Password:";
            secondpass = "Second Password:";
            baslik = "PHP File Manager";
            AnaSayfa = "Home Page";
            giris = "Login";
            kapat = "Close";
            Duzenle = "Edit";
            Incele = "View";
            kopyalandi = "saved";
            upload_fail = "Upload FAILED!";
            yenikla_succes = "created";
            sayfa_olusturuldu = "page created";
            yenikla_fail = "FAILED";
            yenikla_prompt = "NewFolder";
            silindi = "deleted";
            silinemedi = "delete FAILED";
            silinsinmi = "Are you want to delete";
            kaydet = "Save";
            KaydetBitir = "Save And Finish";
            iptal = "Cancel";
            diz = "Sort";
            silonay = "For delete press (OK)\n OR  CANCEL!";
            silmeonay_caption = "Delete Confirmation!";
            klasor_ = "Directory:";
            cikis = "Log Out";
            CikmakMi = "Do you want to leave?";
            klasorundesin = "";
            klasoru = "directory";
            klasor_sec = "please choose directory";
            hedef_klasor = "Target Directory:";
            Hedef = "Target";
            KODLA = "source";
            ZIPCOZ = "unzip";
            def_dir = "Default DIR";
            up_dir = "Top DIR";
            temiz = "clear";
            YUKLE = "Upload";
            KesKopyalaYapistirLegend = "(Cut | Copy) Paste";
            yenikla_sb = "new DIR";
            BOS = "This folder is empty";
            sekmedeAc = "Open in new tab";
            sekmeAc = "Open new tab";
            yuklemeSecButon = "Upload file";
            yuklemeSec = "Please press upload button and choose file!";
            ResimSec = "Please choose a image.";
            oturum_yok = "Please login";
            oturum_sonlandirildi = "Session closed!";
            OturumBolgesiDegisti = "Your session location has changed. Please re-login.";
            OturumIdDegisti = "Session info has changed. Please re-login.";
            AcilacakKlasorYolunuSor = "Open directory with path:";
            SonYuklemeler = "Upload Recent";
            AdDegistirNesneSec = "Please choose file or folder for rename!";
            AdDegistirSadeceBir = "You can rename only 1 file or folder per times!";
            ChmodNesneSec = "Please choose object(file/folder) for using chmod!";
            SadeceBirTaneSec = "You can choose only 1 file or folder per action";
            AdYeniYaz = "Please write new name:";
            AdZatenVar = "This name used, write other!";
            AdGecersizDosyaKlasor = "You can use \".\" and \"_\" in file names,  \"_\" in folder names.";
            EnAzBirNoktaIcermeli = " You must use \".\" (dot) ";
            Kullanilamaz = "You can not use: ";
            AdYeniOlmadi = "Rename Failed!";
            AdDegisti = "Renamed.";
            zaten_var = "already exist!";
            YeniDosyaAdiGir = "Please type new file name with extension.";
            YeniDosyaAdiGecersiz = "New file name is not valid!";
            YeniDosyaUzantisiGecersiz = "Invalid file extension!";

            LISTE_BUTONLAR_ADLANDIR = "Rename";
            LISTE_BUTONLAR_YENI_KLASOR = "New Folder";
            LISTE_BUTONLAR_SIL = "Delete";
            LISTE_BUTONLAR_KES = "Cut";
            LISTE_BUTONLAR_KOPYALA = "Copy";
            LISTE_BUTONLAR_YAPISTIR = "Paste";
            LISTE_BUTONLAR_ZIPLE = "AddToZip";
            LISTE_BUTONLAR_YENI_DOSYA = "New File";

            USTUNE_YAZ = "Overwrite";
            DAIMA_USTUNE_YAZ = "Always overwrite";
            YapistirKaynakEkleSec = "Please add or select source for paste!";
            OlusturulanKlasor = "Created Folders";
            SayilanKlasor = "Counted Folders";
            YapistirilanDosya = "Pasted Files";
            SayilanDosya = "Counted Files";
            Kaynak = "Source";
            KAYNAK_BOS = "Source empty!";
            HEDEF_BOS = "Target not seleced!";
            Kopyala = "Copy";
            BASARISIZ = "FAILED";
            BASARILI = "SUCCESSFUL";
            TumunuSecButon = "Select all";
            TumunuBirakButon = "Leave all";
            TumunuTemizleButon = "Clear all";// Satır:30 'temiz'

            KOPYALAVESIL = "MOVED (CopyAndDelete)";
            KOPYALAVESIL_HATASI = "MOVE FAILED (CopyAndDelete)";
            TASINDI = "MOVED";
            TASINDI_HATASI = "MOVE FAILED";
            BULUNAMADI = "NOT FOUND";
            KENDI_ICINE_KOPYALANMAZ = "You can not copy folder into self";
            KLASOR_KENDI_ICINE_ARSIVLENMEZ = "You can not archive folder into self";
            ARSIV_KENDI_ICINE_ARSIVLENMEZ = "You can not add archive file into self";

            ZIP_DEGIL = "not a zip archive!";
            HATA = "ERROR";
            ZIPLI_DOSYA_SEC = "Please click \"extract zip\" button in file list";
            ARSIV_UNZIP_LEGEND = "Zip extract";
            ARSIV_ZIP_LEGEND = "Create Zip Archive";
            ARSIV_UNZIP_BITIR = "Start zip extract!";
            ARSIV_ZIP_BITIR = "Add selected to Zip!";
            ZIP_HEPSI_BIRDEN = "All in one time";
            ZIP_TEKTEK = "One by one";
            ZIPLENDI = "Zipped";
            ZipleKaynakEkleSec = "Please add or select source for creating Zip archive!";
            ZipArsivAdiGir = "Please write zip archive name!";
            ZipArsivAdiGecersiz = "Zip name have wrong characters!";
            VE = " and ";
            VEYA = " or ";
            EKSIK_VERI = "Some form variables are missing!";
            UNZIPLENDI = "Zip extracted";
            EDITOR_DOSYA_SEC = "Choose file for view source!";
            KAYDEDILDI = "saved";


            UyeOl = "Sign Up";
            BosOlmaz = "Should be written ";
            EnAz = "Minimum length: ";
            EMailTekrar = "Re-Type Email";
            EMailTekrariAyniDegil = "EMail and Re-EMail does not match!";
            EMailGecersiz = "EMail is not valid ";
            EMailKullaniliyor = "This EMail in use. ";
            EmailDogrulamaBaslik = "EMail confirmation ";
            LutfenGirisKontrolEdin = "Please check your login information!";
            UyelikOlusturuldu = "Your account created ";
            SpamMailiKontrolEt = "Please check your mail inbox/junk/spam folders for confirmation. ";
            BirHataOlustuBizeYazin = "Unkown error. Please contact us ";
            Tiklayin = "please click";
            UyelikEMailBilgilendirme = "Wellcome \r\n For EMail confirmation please click URL or \r\n copy and paste to your browser.\r\n";
            Alaniniz = "Your space ";
            KullaniciAdi = "Nick Name";
            KullaniciAdiEnAz = "Minimum length: ";
            KullaniciAdiKullaniliyor = "This user name in use. Please choose other. ";
            AlanAdi = "Space Name";
            AlanAdiEnAz = "Minimum length: ";
            AlanAdiOrnek = "yourspace";
            Sifre = "Password";
            SifreEnAz = "Minimum length: ";
            SifreTekrar = "Re-Type Password";
            SifreTekrariUyusmuyor = "Password and re-password does not match";
            SifreIcermeliIsaret = "The Password must have a symbol or sign";
            SifreIcermeliRakam = "The Password must have a digit";
            SifreSadeceRakamOlamaz = "The Password must not be only digits";
            KayitOl = "Sign Up";

            GirisOlumsuzMesaj = "EMail or password is  wrong!";

            KlasorunuzeErisilemiyor = "Your folder information can not accesible.";
            AnaDizinDegismez = "You can not change your main directory!";
            HedefleKaynakAyni = "Same source as target";

            Yonet = "Manage";
            DosyaYoneticisi = "File Manager";
            SQLTablolar = "SQL Tables";
            SablonKurulum = "Template Setup";
            Sablonlar = "Templates";
            Kur = "Setup";
            /*2019-02-13  Sonrası */
            Kullanici = "User";
            Sunucular = "Hosts";
            Baglan = "Connect";
            Baglanti = "Connection";
            BaglantiSaglanamadi = "Connection failed!";
            BaglantiAdi_Lbl = "Connection Name";
            TekrarBaglan = "Retry Connect";
            DBHost_Lbl = "DB IP or HostName";
            DBUser_Lbl = "DB User";
            DBPass_Lbl = "DB Password";
            Yeni = "New";
            Demo = "Demo";
            Hosgeldin = "Wellcome";
            Lutfen = "Please";
            SunucuSec = "Choose a server!";
            Bu = "This";
            SunaGore = "Sort by";
            Artan = "Ascending";
            KacarliCvp = "per view";
            Sayfa = "Page";
            Satir = "Row";
            Geri = "Back";
            Ileri = "Next";
            Sirala = "Sort";
            HenuzDegistirilmedi = "Not changed yet";
            VeriTabani = "Database";
            Olustur = "Create";
            Ekle = "Add";
            KarakterKarsilastirma = "Collation charset";
            Adi = "Name";
            Secin = "Choose";
            Bir = "A";
            DilKarsilastirmasi = "Collation";
            YaziYaz = "Write";
            Tablo = "Table";
            Veri = "Data";
            Yapi = "Structure";
            Sadece = "Only";
            Islem = "Action";
            YokEdilecek = "Will Destroy";
            YokEt = "Destroy";
            Bosalt = "Erase";
            Calistir = "Run";
            Komut = "Command";
            Etkilenenler = "Affected";
            Sorgu = "Query";
       }
    }
}
