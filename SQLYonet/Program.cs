using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hata Satır Numarası
using System.Diagnostics;
//KayitDefteri
using Microsoft.Win32;
namespace SQLYonet
{
    static class Program
    {

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f01_GirisEkrani());//TestFormu());//f02_Sunucular());//
        }
        

    }

    //Form Yönetim Sınıfı
    static class OrtakSinif
    {

        static public int KorunacakGizliFormlarAdedi = 4;
        static public string KorunacakAnaForm = "f01_GirisEkrani";
        //2019-03-22 02:05
        //FormActivateKilitli: ShowDialog metodu kullanıldığında form kapanınca bir önceki formun
        // FormActivate'nin çalıştırılıp çalıştırılmaması için bir kilittir. nasıl kullanıldığını görmek için
        // f03_MySQLYonet.f03_MySQLYonet_Activated ile f04_f03VeriTabaniOlustur.VeriTabaniniOlustur_Btn_Click e bakınız.
        static public bool FormActivateKilitli = true;
        static public void Nedir(object Nesne)
        {
            MessageBox.Show(Nesne.ToString());
            //OrtakSinif.NesneNedir = Nesne.ToString();
            // Void "RETURN" içeremez işlem gerçekleştirir//return Nesne.ToString();
        }

        static public bool PanelAcKapa(object panelNesnesi)
        {
            //gereksiz 2019-02-17 02:00 // pane1.Visible = !panel1.Visible; aşağıdaki kodun işini görüyor.
            // Proje bitiminde bu metod OrtakSinif altından kaldırılacak.
            Panel panel = panelNesnesi as Panel;
            if (panel.Visible == false) { panel.Visible = true; panel.Focus(); return true; }
            else { panel.Visible = false; return false; }
        }
        static public void EskiGizliFormuKapat(int AcikGizliFormlarAdedi, string KorunacakForm)
        {
            int KapanacakFormlarAdedi = AcikGizliFormlarAdedi - KorunacakGizliFormlarAdedi;
            if (AcikGizliFormlarAdedi > KorunacakGizliFormlarAdedi)
            {
                for (int i = 0; i < KapanacakFormlarAdedi; i++)
                {
                    if (Application.OpenForms[i].Name != KorunacakAnaForm && Application.OpenForms[i].Name != KorunacakForm)
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }
        static public void RTBox_Renklendir(string[] RenklenecekKelimeler,RichTextBox RTBox)
        {

            foreach (string kelime in RenklenecekKelimeler)
            {
                //[ renklendir
                bool KucukBulundu = false;
                bool BuyukBulundu = false;
                if (RTBox.Text.Contains(kelime) || RTBox.Text.Contains(kelime.ToUpper()))
                {

                    if(RTBox.Text.Contains(kelime)) { KucukBulundu = true; }
                    if (RTBox.Text.Contains(kelime.ToUpper())) { BuyukBulundu = true; }
                }

                    int index = -1;
                    int bindex = -1;
                    int selectStart = RTBox.SelectionStart;

                    

                    while (KucukBulundu == true && (index = RTBox.Text.IndexOf(kelime, (index + 1))) != -1)
                    {
                        RTBox.Select((index + 0), kelime.Length);
                        RTBox.SelectionColor = System.Drawing.Color.Blue;
                    }

                    while (BuyukBulundu == true && (bindex = RTBox.Text.IndexOf(kelime.ToUpper(), (bindex + 1))) != -1)
                    {
                        RTBox.Select((bindex + 0), kelime.Length);
                        RTBox.SelectionColor = System.Drawing.Color.Blue;
                    }


                    //seçimi bitir
                    RTBox.SelectionStart = RTBox.TextLength;
                    RTBox.SelectionColor = System.Drawing.Color.Black;
                


                // renklendir ]
            }
        }
        static public void TumFormlariKapat()
        {
            //Bu metod testlerde hata verdi kullanılmıyor.
            List<Form> AcikFormlar = new List<Form>();
            int AcikFormlarSayisi = Application.OpenForms.Count;
            for (int i = 0; i < AcikFormlarSayisi; i++)
            {
                AcikFormlar.Add(Application.OpenForms[i]);


            }

            foreach (Form kapanacak in AcikFormlar)
            {
                kapanacak.Close();
            }
        }
        static public void ButtonAktif(Form form,Button Tiklanan,bool isaretle)
        {
            byte HataYeri = 0;
            try
            {
                //isaretle true olursa tıklananı işaretler, false olursa tüm işaretlenmiş olanı kaldırır.
                foreach (Control b in form.Controls)
                {
                    //b.BackgroundImage = null;
                    HataYeri = 1;
                    if (b is Button && b == Tiklanan && isaretle == true)
                    {
                        HataYeri = 2;
                        b.BackgroundImage = Properties.Resources.aktifButonBG;
                        b.Font = new System.Drawing.Font(b.Font, System.Drawing.FontStyle.Bold);

                    }
                    else if (b is Button && b == Tiklanan && isaretle == false)
                    {
                        HataYeri = 21;
                        b.BackgroundImage = null;
                        b.Font = new System.Drawing.Font(b.Font, System.Drawing.FontStyle.Regular);
                    }
                    else if (b is Button && b != Tiklanan)
                    {
                        HataYeri = 3;
                        b.BackgroundImage = null;
                        b.Font = new System.Drawing.Font(b.Font, System.Drawing.FontStyle.Regular);

                    }
                }
            }
            catch(Exception Hata)
            {
                ProgramHatasi("OrtakSinif.ButonAktif() Muhtemelen zemin resim dosyası eksik", HataYeri, Hata);
            }
        }
        
        static public void KontrolleriAcKapat_TabPage(TabPage pencere,List<Control> HariCAdi,bool AcKapat)
        {
            byte HataYeri = 0;
            try
            {
                foreach (Control tumctrl in pencere.Controls)
                {
                    //b.BackgroundImage = null;
                    HataYeri++;

                    //Control HaricTut = Haric.Find(item => item.Name == form.Controls.name);
                    bool HaricBulundu = false;
                    foreach(Control HaricTut in HariCAdi)
                    {
                        if(tumctrl.Name == HaricTut.Name)
                        {
                            HaricBulundu = true;
                        }
                    }
                    if(HaricBulundu == false)
                    {
                        tumctrl.Enabled = AcKapat;
                        //MessageBox.Show(tumctrl.Name);
                    }





                }
                HataYeri = 200;
            }
            catch (Exception Istisna)
            {
                ProgramHatasi("OrtakSinif.KontrolleriKapat()", HataYeri, Istisna);
            }
        }
        static public void KontrolleriAcKapat_Form(string FormAdi, List<Control> HariCAdi, bool AcKapat)
        {
            byte HataYeri = 0;
            try
            {

                // [ FormuBulalim
                int AcikFormlarSayisi = Application.OpenForms.Count;
                int FormIndexi = -1;
                for (int i = 0; i < AcikFormlarSayisi; i++)
                {
                    if (Application.OpenForms[i].Name == FormAdi)
                    {
                        Application.OpenForms[i].Visible = true;
                        FormIndexi = i;
                    }
                }
                //  FormuBulalim ]

                foreach (Control tumctrl in Application.OpenForms[FormIndexi].Controls)
                {
                    //b.BackgroundImage = null;
                    HataYeri++;

                    //Control HaricTut = Haric.Find(item => item.Name == form.Controls.name);
                    bool HaricBulundu = false;
                    foreach (Control HaricTut in HariCAdi)
                    {
                        if (tumctrl.Name == HaricTut.Name)
                        {
                            HaricBulundu = true;
                        }
                    }
                    if (HaricBulundu == false)
                    {
                        tumctrl.Enabled = AcKapat;
                        //MessageBox.Show(tumctrl.Name);
                    }





                }
                HataYeri = 200;
            }
            catch (Exception Istisna)
            {
                ProgramHatasi("OrtakSinif.KontrolleriAcKapat_Form()", HataYeri, Istisna);
            }
        }
        static public bool TextBoxBosKontrol(Form form,List<TextBox> BosOlabilir)
        {
            byte HataYeri = 0;
            bool BosVar = false;

            try
            {
                //isaretle true olursa tıklananı işaretler, false olursa tüm işaretlenmiş olanı kaldırır.
                foreach (Control c in form.Controls)
                {
                    //b.BackgroundImage = null;

                    if (c is TextBox && c.Text==string.Empty)
                    {
                        TextBox Istisna = BosOlabilir.Find(item => item.Name == c.Name);
                        if(Istisna ==null)
                        {
                            c.Focus();
                            BosVar = true;

                        }

                    }

                }
                return BosVar;
            }
            catch (Exception Hata)
            {
                ProgramHatasi("OrtakSinif.TextBoxBosKontrol()", HataYeri, Hata);
                return BosVar;
            }
        }
        static public void TextBoxBosalt(Form form,List<TextBox> Haric)
        {
            byte HataYeri = 0;
            try
            {
                //isaretle true olursa tıklananı işaretler, false olursa tüm işaretlenmiş olanı kaldırır.
                foreach (Control c in form.Controls)
                {
                    //b.BackgroundImage = null;

                    if (c is TextBox )
                    {
                        TextBox Istisna = Haric.Find(item => item.Name == c.Name);
                        if (Istisna == null)
                        {
                            c.Text = string.Empty;
                        }

                    }

                }

            }
            catch (Exception Hata)
            {
                ProgramHatasi("OrtakSinif.TextBoxBosalt()", HataYeri, Hata);

            }
        }
        public static void IslemiBekleButon(Button button, bool ekle)
        {
            byte HataYeri = 0;
            try
            {
                if (ekle == true)
                {
                    button.Image = Properties.Resources.loading16px;
                    button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                }
                else
                {
                    button.Image = null;
                }
            }
            catch (Exception Istisna)
            {
                ProgramHatasi("IslemiBekleButon() loading16px.gif eksik olabilir.", HataYeri, Istisna);
            }
        }
        static public int GizliFormuAc(string FormAdi)
        {
            //Kullanım: if(GizliFormuAc(formadi)==0) ise yeni form aç değilse zaten GizliFormuAc aşağıda açacak.
            int AcikFormlarSayisi = Application.OpenForms.Count;
            int FormAdiBulundu = 0;
            for (int i = 0; i < AcikFormlarSayisi; i++)
            {
                if (Application.OpenForms[i].Name == FormAdi)
                {
                    Application.OpenForms[i].Visible = true;
                    FormAdiBulundu++;
                }
            }

            OrtakSinif.EskiGizliFormuKapat(AcikFormlarSayisi, FormAdi);
            return FormAdiBulundu;


        }
        static public void AcikFormlar()
        {
            string FormAdlari = "";
            int AcikFormlarSayisi = Application.OpenForms.Count;
            for (int i = 0; i < AcikFormlarSayisi; i++)
            {
                FormAdlari = FormAdlari + " " + i.ToString() + "." + Application.OpenForms[i].Name;
            }
            MessageBox.Show(FormAdlari);

        }
        // [Matematik fonksiyonları bunun altına kopyala
        static public double kotanjant(double radyan)
        {
            if (radyan == 0)
            {
                MessageBox.Show("0 radyanın kotanjantı tanımsızdır");
                return 0;
            }
            double Tanjant = Math.Tan(radyan);
            double Kotanjant = 1 / Tanjant;
            return Kotanjant;
        }
        //TextBoxu Sayisal işleme hazırla
        static public string NoktayiVirgule(string deger)
        {
            deger = deger.Replace(".", ",");
            return deger;
        }
        static public void merhaba()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static bool IsNumeric(this string value)
        {
            //Kaynaktan anladığım kadarıyla TryParse kullanmak için MS Visual Basic başvurusu eklenmiş olmalı.
            double Sonuc = 0;
            return double.TryParse(value, out Sonuc);
        }



        public static void KodGoster(RichTextBox rtb)
        {
            Form form = rtb.Parent.FindForm();
            rtb.Left = 10;
            rtb.Top = 10;
            int YeniGenislik = form.Width - 20;
            int YeniYukseklik = form.Height - 100;
            rtb.Size = new System.Drawing.Size(YeniGenislik, YeniYukseklik);
            rtb.Visible = !rtb.Visible;



        }

            
        public static void ProgramHatasi(string FonksiyonAdi, byte HataYeri, Exception Istisna)
        {
            MessageBox.Show(FonksiyonAdi + "\r\n HataYeri " + HataYeri.ToString() + "\r\n" + Istisna.Message.ToString());
        }
        public static void HataBildir(string Mesaj, Exception Istisna)
        {
            MessageBox.Show(Mesaj+"\r\n"+Istisna.Message.ToString(), DilSec.HATA, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static DialogResult DialogOkCancel(string Soru, string Baslik)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(Soru, Baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return dialogResult;

        }
        static public void Cikis(string Mesaj, string Baslik)
        {
            DialogResult Cevap;
            Cevap = MessageBox.Show(Mesaj, Baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Cevap == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string RasgeleMetin(int MetinBoyu)
        {
            Random rasgele = new Random();
            string chars = "umtabcdefghijklnopqrsvwxyzUMT2019ABCDEFGHIJKLNOPQRSVWXYZ345678";
            return new string(Enumerable.Repeat(chars, MetinBoyu)
              .Select(s => s[rasgele.Next(s.Length)]).ToArray());
        }
        public static string Sifrele(string SifrelenecekDizge)
        {
            //Bu proje tamamlanır ve kullanıma sunulursa, kullanılmaya başlandıktan sonra bu metod ve 
            // geri dönüştüren SifreCoz metodundaki algoritma değiştirilmeden önce gerekli tedbirler alınmalı.
            // Bu metodla şifrelenen parolalar yeni versiyonda değişen metodla çözülmek istenirse yeni program versiyonu
            // şifreleri hatalı kabul edecektir.
            string rand3 = RasgeleMetin(3);
            SifrelenecekDizge = Base64Encode(SifrelenecekDizge);
            string SifreliDizge = rand3 + "" + SifrelenecekDizge;
            return SifreliDizge;
        }
        public static string SifreCoz(string SifreliDizge)
        {
            string b64encoded = SifreliDizge.Substring(3);
            string SifresizDizge = Base64Decode(b64encoded);
            return SifresizDizge;
        }


    }//OrtakSinif

    static class KayitDefteri
    {
        public static string KlasorAna = "SQLYonet";
        public static string KlasorKullanicilar = "Kullanicilar";
        public static string KlasorDemo = "demo"; // demo kullanıcısı
        public static string KlasorSunucular = "Sunucular";
        public static string DemoSifre = "1234";// demo şifresi
        public static string KlasorGiris = "Giris";
        public static string KayitSifre = "Sifre";
        public static string KayitSonGiris = "SonGiris";
        public static string KayitHataliGirisSayisi = "HataliGirisSayisi";
        public static string KayitSunucuDBHost = "DBHost";
        public static string KayitSunucuDBUser = "DBUser";
        public static string KayitSunucuDBPass = "DBPass";
        public static RegistryKey KlasorKeyAktifKullanici;
        public static string TextAktifKullanici;
        
        //public static string RegistryVeriTabanlari = "VeriTabanlari";
        /*                Klasör        Klasör       Klasör         Klasör                          Kayit
         * CurrentUser -> SQLYonet -> Kullanicilar -> KullaniciAdi -> Giris ->                      SIFRE    -> değer
         *                                                                                          SonGiris -> değer
         *                                                                                          HataliGirisSayisi -> değer
         *                                                         VeriTabanlari  -> Veri Tabani adi(degisken) -> VTIP ->değer
         *                                                                                                       VTKADI -> değer
         *                                                                                                       VTSIFRE->deger
         *                                                                                                       VTDBADI->deger
         *                                                                              
         * 
         */
        public static RegistryKey KullaniciKontrol(string ParametreKullaniciAdi)
        {
        //Özellikler: 20190214 01:45 catch case2: ile artık ilk  kullanımda KlasorAna / KlasorKullanicilar yok ise oluşturulacak.

        //RegistryKey KaydaGir = Registry.CurrentUser.OpenSubKey(KlasorAna).OpenSubKey("IMYO", true);
        bastan:
            byte HataYeri = 0;
            TextAktifKullanici = ParametreKullaniciAdi;
            try
            {
                
                HataYeri = 1;
                RegistryKey AnaKlasor = Registry.CurrentUser.OpenSubKey(KlasorAna);
                //Yaptığım testlerde HataYeri işareti bir önceki satıra işaret ettiği  için catch kısmını güncelliyorum.
                HataYeri = 2;
                RegistryKey Kullanicilar = AnaKlasor.OpenSubKey(KlasorKullanicilar);

                HataYeri = 3;
                KlasorKeyAktifKullanici = Kullanicilar.OpenSubKey(ParametreKullaniciAdi);
                
                HataYeri = 4;
                
                return KlasorKeyAktifKullanici;
            }
            catch (Exception Hata)
            {
                switch (HataYeri)
                {
                    case 2:
                        //OrtakSinif.ProgramHatasi("KullaniciKontrol() Registry '"+ KlasorAna+"' oluşturulmamış.", HataYeri, Hata);

                        //Burda Ana Klasör oluşturulmalı 20190213.
                        //Hatta şablondaki SQLYonet/Kullanicilar klasörleri oluşturulmalı. Sonraki yerlerde sadece Kullanıcı Var/Yok, Varsa Şifre kontrol edilecek.
                        RegistryKey KurulumDemo = Registry.CurrentUser.CreateSubKey(KlasorAna).CreateSubKey(KlasorKullanicilar).CreateSubKey(KlasorDemo);
                        RegistryKey KurulumDemoGiris = KurulumDemo.CreateSubKey(KlasorGiris, true);
                        using (KurulumDemoGiris)
                        {
                            string SifreliDemoSifre = OrtakSinif.Sifrele(DemoSifre);
                            KurulumDemoGiris.SetValue(KayitSifre, SifreliDemoSifre);
                        }
                        //Sunucular klasörünüde oluşturalım
                        KurulumDemo.CreateSubKey(KlasorSunucular);

                        goto bastan;
                        //break;

                    case 3:
                        OrtakSinif.ProgramHatasi("KullaniciKontrol() Registry '" + KlasorKullanicilar + "' oluşturulmamış.", HataYeri, Hata);
                        //Case 2 de 3 teki sorunuda çözeceğim böylece burası hiç çalışmayacak. Ancak projenin ilerleyişini görmek adına bu
                        // kısmı silmiyoruz.
                        break;

                    case 4:
                        //OrtakSinif.ProgramHatasi("KullaniciKontrol() Registry '" + KullaniciAdi + "' oluşturulmamış.", HataYeri, Hata);
                        //using(Key) kullanılmadığı için bu alana doğru bir istisna atlaması yok. Aynı mesaj f01 altında veriliyor.
                        MessageBox.Show(DilSec.LutfenGirisKontrolEdin);
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("KullaniciKontrol", HataYeri, Hata);
                        break;

                }
                return null;

            }

        }
        public static bool KullaniciOlustur(string KullaniciAdi, string Sifre)
        {
            byte HataYeri = 0;
            try
            {


                HataYeri = 1;
                RegistryKey Kullanici = Registry.CurrentUser.CreateSubKey(KlasorAna).CreateSubKey(KlasorKullanicilar).CreateSubKey(KullaniciAdi);
                RegistryKey KullaniciGiris = Kullanici.CreateSubKey(KlasorGiris, true);
                using (KullaniciGiris)
                {
                    HataYeri = 2;
                    Sifre = OrtakSinif.Sifrele(Sifre);
                    HataYeri = 3;
                    KullaniciGiris.SetValue(KayitSifre, Sifre);
                }
                Kullanici.CreateSubKey(KlasorSunucular);
                //Kod bu satıra kadar catch kısmına atlamadan çalıştıysa işlemler tamamlanmıştır
                return true;
            }
            catch(Exception Hata)
            {
                switch(HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("KayitDefteri.KullaniciOlustur()", HataYeri, Hata);
                        return false;
                        //break;
                }
            }
        }

        public static void GetSubKeyNamesToListBox(RegistryKey KlasorAdi, ListBox listBoxAdi)
        {
            byte HataYeri = 0;
            try
            {
                HataYeri = 1;
                using (KlasorAdi)
                {
                    HataYeri = 2;
                    foreach (var SubKeyAdi in KlasorAdi.GetSubKeyNames())
                    {
                        listBoxAdi.Items.Add(SubKeyAdi.ToString());
                    }

                }
            }
            catch (Exception Hata)
            {
                OrtakSinif.ProgramHatasi("GetSubKeyNames()", HataYeri, Hata);
            }
        }
    }

   
}//NameSpace sonu

