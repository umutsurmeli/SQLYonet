using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Registry için gerekli
using Microsoft.Win32;

namespace SQLYonet
{
    public partial class f01_GirisEkrani : Form
    {
        private string FormAdi;
        public f01_GirisEkrani()
        {
            InitializeComponent();
            dilSeciciKontrol1.button1.Click += FormTextleriDegistir;
            dilSeciciKontrol1.button2.Click += FormTextleriDegistir;

        }

        private void f01_GirisEkrani_Load(object sender, EventArgs e)
        {

            KayitDefteri.KullaniciOlustur(KayitDefteri.KlasorDemo,KayitDefteri.DemoSifre);
            DemoGiris_Btn.Visible = true; 
            panel1.Visible = false;//Yeni hesap nesneleri
            DilSec.tr();
            FormTextleriDegistir(sender,e);
            


        }
        public void FormTextleriDegistir(object sender, EventArgs e)
        {
            FormAdi = DilSec.giris;
            this.Text = FormAdi + " -" + DilSec.ProgramBaslik;
            button1.Text = DilSec.giris;
            button2.Text = DilSec.KayitOl;
            button4.Text = DilSec.kaydet;
            label1.Text = DilSec.Kullanici;
            label2.Text = DilSec.Sifre;
            label3.Text = DilSec.SifreTekrar;
            DemoGiris_Btn.Text = DilSec.Demo + " " + DilSec.giris;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Hesap Oluştur Aç/Kapa
            panel1.Visible = !panel1.Visible;
            // Daha önce oluşturmuş olduğum OrtakSinif.PanelAcKapa(Panel panel) metoduna baktığımda  gereksiz olduğunu görüyorum.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş Yap
            byte HataYeri = 0;
            string KullaniciAdi;
            string KayitliKullaniciSifresi;
            string GirilenKullaniciSifresi;
            
            try
            {
                if (textBox1.Text != string.Empty && textBox2.Text!=string.Empty)
                {//Kullanıcı adı ve Şifre Boş değilse
                    KullaniciAdi = textBox1.Text;
                    GirilenKullaniciSifresi = textBox2.Text;
                    RegistryKey Kullanici = KayitDefteri.KullaniciKontrol(textBox1.Text);
                    HataYeri = 1;//Kullanici Yoksa catch case 1 e atlar. /asdf ile dene / demo oluşturulacak.
                    //MessageBox.Show(Kullanici.ToString());
                    
                    RegistryKey Giris = Kullanici.OpenSubKey(KayitDefteri.KlasorGiris,true);
                    using (Giris)
                    {
                        HataYeri = 2;//using kullanmadıkça catch kısmına gitmiyor. // Giriş Klasörü yoksa // catch case 2

                        KayitliKullaniciSifresi = Giris.GetValue(KayitDefteri.KayitSifre).ToString();
                        KayitliKullaniciSifresi = OrtakSinif.SifreCoz(KayitliKullaniciSifresi);

                        HataYeri = 3;
                    }

                    if(GirilenKullaniciSifresi == KayitliKullaniciSifresi)
                    {
                        //Burda sunucu listesi düzenleme ekranı gelecek.
                        // 
                        if (OrtakSinif.GizliFormuAc("f02_Sunucular") == 0)
                        {
                            f02_Sunucular YeniForm = new f02_Sunucular();
                            YeniForm.Show();
                        }
                        this.Visible = false;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show(DilSec.LutfenGirisKontrolEdin);
                        textBox1.Focus();
                        textBox1.SelectAll();
                        DemoGiris_Btn.Visible = true;
                    }
                    //MessageBox.Show(KayitliKullaniciSifresi);
                    //MessageBox.Show(Kullanici.ToString());
                }
                else
                {
                    MessageBox.Show(DilSec.Kullanici + DilSec.VE + DilSec.Sifre.ToLower()+" "+ DilSec.BosOlmaz.ToLower());
                }
            }
            catch (Exception Hata)
            {
                switch (HataYeri)
                {
                    case 1:
                        MessageBox.Show(DilSec.LutfenGirisKontrolEdin);
                        DemoGiris_Btn.Visible = true;
                        break;
                    case 2:
                        //Burası hiç çalışmamalı. Kullanıcı oluşturulunca KlasorGiris tanımlanmalı ve altına diğer gerekli alanlar tanımlanmalı
                        OrtakSinif.ProgramHatasi("button1_Click " 
                            + DilSec.giris+ "KayitDefteri.KlasorGiris oluşturulmamış"
                            +"Ya da Sifre tanımlanmamış", HataYeri, Hata);
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("button1_Click", HataYeri, Hata);
                        break;
                }
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Kullanıcı Kaydet Butonu
            byte HataYeri = 0;
            string GirilenKullaniciAdi = textBox1.Text;
            string GirilenSifre = textBox2.Text;
            string GirilenSifreTekrari = textBox3.Text;
            bool EksikVarMi = false;
            try
            {
                //[ girilen bilgilerin doğru ve eksiksiz bir şekilde girilmesi sağlandı.

                if (GirilenSifreTekrari == "") { textBox3.Focus(); EksikVarMi = true; }
                if (GirilenSifre == "") { textBox2.Focus(); EksikVarMi = true; }
                if (GirilenKullaniciAdi == "") { textBox1.Focus(); EksikVarMi = true; }

                if (EksikVarMi == true) { MessageBox.Show(DilSec.LutfenGirisKontrolEdin); return; }

                if(GirilenSifre != GirilenSifreTekrari) { MessageBox.Show(DilSec.SifreTekrariUyusmuyor);textBox2.Focus(); textBox2.SelectAll(); return; }
                // girilen bilgilerin doğru ve eksiksiz bir şekilde girilmesi sağlandı. ]

                // Kullanıcı adının daha önce başkası tarafından alınıp alınmadığını kontrol edelim.
                HataYeri = 1;
                RegistryKey Kullanici = KayitDefteri.KullaniciKontrol(GirilenKullaniciAdi);
                HataYeri = 2;
                RegistryKey Giris = Kullanici.OpenSubKey(KayitDefteri.KlasorGiris, true);
                HataYeri = 3;
                //Kod buraya kadar çalışarak geldiyse KullaniciAdi/Giris zaten mevcuttur dolayısıyla 
                //burada kullanıcıya bir uyarı vermeliyiz.
                MessageBox.Show(DilSec.KullaniciAdiKullaniliyor);
                return;

                //HataYeri = 3;




                


            }
            catch (Exception Hata)
            {
                switch(HataYeri)
                {
                    case 2:
                        //Böyle bir kullanıcı yok burada oluşturulabilir
                        if(KayitDefteri.KullaniciOlustur(GirilenKullaniciAdi, GirilenSifre) == true)
                        {
                            MessageBox.Show(DilSec.UyelikOlusturuldu);
                            panel1.Visible = !panel1.Visible;
                        }
                        else
                        {
                            OrtakSinif.ProgramHatasi("f01_Giris Button4_click () Kullanıcı oluşturulamadı Exception kısmı", HataYeri, Hata);
                        }
                        
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("f01_Giris; button4_click; "+"Herhangi bir hata", HataYeri, Hata);
                        break;
                }
            }
        }

        private void DemoGirisiGoster()
        {
            //Bu metod demo hesabı hazır olduğunda  ve kullanıcı yanlış giriş yaptığında gösterilir.
            DemoGiris_Btn.Visible = true;

        }

        private void DemoGiris_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = KayitDefteri.KlasorDemo;
            textBox2.Text = KayitDefteri.DemoSifre;
            button1_Click(sender, e);
        }

        private void Yapilacaklar_Click(object sender, EventArgs e)
        {

            if (OrtakSinif.GizliFormuAc("TestFormu") == 0)
            {
                TestFormu YeniForm = new TestFormu();
                YeniForm.Show();
                this.Visible = false;
            }

        }
    }
}
