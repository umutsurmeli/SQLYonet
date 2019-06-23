using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Microsoft.Win32;
namespace SQLYonet
{
    public partial class f02_Sunucular : Form
    {
        private string FormAdi;
        private RegistryKey Sunucular;
        private bool SunucuDuzenleAcKapaDurum = true;
        private string AktifIslem = null;
        private string SunucuSonIslenen = null;
        List<TextBox> TextBoxBosKalabilir = new List<TextBox>();
        public f02_Sunucular()
        {
            InitializeComponent();
            dilSeciciKontrol1.button1.Click += FormTextleriDegistir;
            dilSeciciKontrol1.button2.Click += FormTextleriDegistir;

        }

        private void f02_Sunucular_Load(object sender, EventArgs e)
        {
            if (DilSec.aktifdil == null) { DilSec.tr(); }
            FormTextleriDegistir(sender, e);
            SunuculariListele();
            SunucuDuzenleAcKapa();

            //KayitDefteri.GetSubKeyNamesToListBox()

        }
        private void FormTextleriDegistir(object sender, EventArgs e)
        {
            FormAdi = DilSec.Sunucular;
            this.Text = FormAdi + " -" + DilSec.ProgramBaslik;
            Baglan_Btn.Text = DilSec.Baglan;
            BaglantiAdi_Lbl.Text = DilSec.BaglantiAdi_Lbl;
            DBHost_Lbl.Text = DilSec.DBHost_Lbl;
            DBUser_Lbl.Text = DilSec.DBUser_Lbl;
            DBPass_Lbl.Text = DilSec.DBPass_Lbl;
            Yeni_Btn.Text = DilSec.Yeni;
            Duzenle_Btn.Text = DilSec.Duzenle;//var
            Sil_Btn.Text = DilSec.LISTE_BUTONLAR_SIL;
            Kaydet_Btn.Text = DilSec.kaydet;
            Iptal_Btn.Text = DilSec.iptal;
            Hosgeldin_Lbl.Text = DilSec.Hosgeldin;
            Kullanici_Lbl.Text = KayitDefteri.TextAktifKullanici;

        }
        private void SunuculariListele()
        {
            Sunucular = KayitDefteri.KlasorKeyAktifKullanici.OpenSubKey(KayitDefteri.KlasorSunucular, true);
            Sunucular_ListBox.Items.Clear();
            KayitDefteri.GetSubKeyNamesToListBox(Sunucular, Sunucular_ListBox);
            Sunucular.Close();

        }
        private void SunucuDuzenleAcKapa()
        {
            BaglantiAdi_TBox.ReadOnly = SunucuDuzenleAcKapaDurum;
            DBHost_TBox.ReadOnly = SunucuDuzenleAcKapaDurum;
            DBUser_TBox.ReadOnly = SunucuDuzenleAcKapaDurum;
            DBPass_TBox.ReadOnly = SunucuDuzenleAcKapaDurum;

            Yeni_Btn.Enabled = SunucuDuzenleAcKapaDurum;
            Duzenle_Btn.Enabled = SunucuDuzenleAcKapaDurum;
            Sil_Btn.Enabled = SunucuDuzenleAcKapaDurum;

            Baglan_Btn.Enabled = SunucuDuzenleAcKapaDurum;
            Kaydet_Btn.Enabled = !SunucuDuzenleAcKapaDurum;
            Iptal_Btn.Enabled = !SunucuDuzenleAcKapaDurum;


            SunucuDuzenleAcKapaDurum = !SunucuDuzenleAcKapaDurum;
        }
        private void Kaydet_Btn_Click(object sender, EventArgs e)
        {
            byte HataYeri = 0;

            try
            {

                TextBoxBosKalabilir.Clear();
                bool BosVarmi = false;
                if (AktifIslem == "Yeni")
                {
                    HataYeri = 1;
                    TextBoxBosKalabilir.Add(DBPass_TBox);
                    HataYeri = 2;
                    BosVarmi = OrtakSinif.TextBoxBosKontrol(this, TextBoxBosKalabilir);
                }
                else if(AktifIslem == "Duzenle")
                {
                    HataYeri = 11;
                    TextBoxBosKalabilir.Add(DBPass_TBox);
                    HataYeri = 22;
                    BosVarmi = OrtakSinif.TextBoxBosKontrol(this, TextBoxBosKalabilir);
                }



                if (BosVarmi == true)
                {
                    HataYeri = 3;
                    MessageBox.Show(DilSec.BosOlmaz);
                }
                else
                {
                    HataYeri = 4;
                    //İstenilen alanlar doldurulmuşsa kayıt işlemine başlıyoruz.
                    if (AktifIslem == "Yeni")
                    {
                        //Önceden varsa düzenleme kısmından girmeli
                        int sayac = 0, SunucuSayisi = Sunucular_ListBox.Items.Count;

                        while (sayac < SunucuSayisi)
                        {
                            if (BaglantiAdi_TBox.Text == Sunucular_ListBox.Items[sayac].ToString())
                            {

                                HataYeri = 101;
                                throw new Exception(DilSec.BaglantiAdi_Lbl + " " + DilSec.zaten_var);

                            }
                            sayac++;
                        }

                        SunucuEkleDegistir();



                    }//if Yeni Kaydetme sonu
                    else if (AktifIslem == "Duzenle")
                    {
                        HataYeri = 12;
                        SunucuEkleDegistir();
                    }
                    HataYeri = 13;
                    //Kayıt Bitti
                    //Son işleneni seçmek için kaydedelim
                    if(BaglantiAdi_TBox.Text != string.Empty)
                    {
                        SunucuSonIslenen = BaglantiAdi_TBox.Text;
                    }
                    List<TextBox> TextBoxHaricTut = new List<TextBox>();
                    OrtakSinif.TextBoxBosalt(this, TextBoxHaricTut);
                    SunucuDuzenleAcKapa();
                    HataYeri = 14;
                    OrtakSinif.ButtonAktif(this, Kaydet_Btn, false);
                    SunuculariListele();
                    SunucuSonIsleneniSec();



                }//Else (BosVarMi == false) ise
            }
            catch (Exception Hata)
            {
                switch (HataYeri)
                {
                    case 101:
                        MessageBox.Show(Hata.Message);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("f02_Sunucular.Kaydet_Btn", HataYeri, Hata);
                        break;
                }
            }

        }

        private void Iptal_Btn_Click(object sender, EventArgs e)
        {
            AktifIslem = null;
            SunucuDuzenleAcKapa();
            OrtakSinif.ButtonAktif(this, Iptal_Btn, false);
            Sunucular_ListBox_SelectedIndexChanged(sender, e);
        }

        private void f02_Sunucular_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void Yeni_Btn_Click(object sender, EventArgs e)
        {
            AktifIslem = "Yeni";
            SunucuDuzenleAcKapa();
            OrtakSinif.ButtonAktif(this, Yeni_Btn, true);

            List<TextBox> TextBoxHaricTut = new List<TextBox>();
            OrtakSinif.TextBoxBosalt(this, TextBoxHaricTut);
            /*
            BaglantiAdi_TBox.Clear();
            DBHost_TBox.Clear();
            DBUser_TBox.Clear();
            DBPass_TBox.Clear();
            */
        }

        private void Sunucular_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte HataYeri = 0;

            try
            {
                HataYeri = 1;
                string SecilenBaglantiAdi = Sunucular_ListBox.SelectedItem.ToString();
                HataYeri = 2;
                RegistryKey KullaniciSunucular = KayitDefteri.KlasorKeyAktifKullanici.OpenSubKey(KayitDefteri.KlasorSunucular);
                RegistryKey Sunucu = KullaniciSunucular.OpenSubKey(SecilenBaglantiAdi);
                using (Sunucu)
                {
                    BaglantiAdi_TBox.Text = SecilenBaglantiAdi;
                    DBHost_TBox.Text = Sunucu.GetValue(KayitDefteri.KayitSunucuDBHost).ToString();
                    DBUser_TBox.Text = Sunucu.GetValue(KayitDefteri.KayitSunucuDBUser).ToString();
                    string KayitliSifre = OrtakSinif.SifreCoz(Sunucu.GetValue(KayitDefteri.KayitSunucuDBPass).ToString());
                    DBPass_TBox.Text = KayitliSifre;
                }
            }
            catch (Exception Istisna)
            {
                switch(HataYeri)
                {
                    case 1:
                        //ListBox üzerinde Yanlış tıklama olduğu için hiçbir işlem gerçekleştirilmeyecek
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("Sunucular_ListBox_SelectedIndexChanged()", HataYeri, Istisna);
                        break;
                }
                
            }
        }

        private void Duzenle_Btn_Click(object sender, EventArgs e)
        {
            byte HataYeri = 0;
            string Mesaj;
            AktifIslem = "Duzenle";
            
            try
            {
                HataYeri = 1;
                string SecilenSunucu = Sunucular_ListBox.SelectedItem.ToString();
                Sunucular_ListBox_SelectedIndexChanged(sender, e);
                HataYeri = 2;
                SunucuDuzenleAcKapa();
                BaglantiAdi_TBox.ReadOnly = true;
                HataYeri = 3;
                OrtakSinif.ButtonAktif(this, Duzenle_Btn, true);
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 1:
                        Mesaj = DilSec.Lutfen + " " + DilSec.SunucuSec.ToLower();
                        MessageBox.Show(Mesaj);
                        OrtakSinif.ButtonAktif(this, Duzenle_Btn, false);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("Duzenle_Btn_Click", HataYeri, Istisna);
                        break;

                }

            }
        }
        private void SunucuEkleDegistir()
        {

            byte HataYeri = 5;
            try
            {

                RegistryKey AnaKlasor = Registry.CurrentUser.CreateSubKey(KayitDefteri.KlasorAna);
                HataYeri = 6;
                RegistryKey Kullanicilar = AnaKlasor.CreateSubKey(KayitDefteri.KlasorKullanicilar);
                HataYeri = 61;
                RegistryKey Kullanici = Kullanicilar.CreateSubKey(KayitDefteri.TextAktifKullanici);
                HataYeri = 62;
                RegistryKey RSunucular = Kullanici.CreateSubKey(KayitDefteri.KlasorSunucular);
                HataYeri = 63;
                RegistryKey IslenecekSunucu = RSunucular.CreateSubKey(BaglantiAdi_TBox.Text, true);
                HataYeri = 64;
                using (IslenecekSunucu)
                {
                    HataYeri = 7;
                    IslenecekSunucu.SetValue(KayitDefteri.KayitSunucuDBHost, DBHost_TBox.Text);
                    HataYeri = 8;
                    IslenecekSunucu.SetValue(KayitDefteri.KayitSunucuDBUser, DBUser_TBox.Text);
                    HataYeri = 9;
                    string SifreliParola = OrtakSinif.Sifrele(DBPass_TBox.Text);
                    HataYeri = 10;
                    IslenecekSunucu.SetValue(KayitDefteri.KayitSunucuDBPass, SifreliParola);
                    HataYeri = 11;
                }
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("SunucuEkleDegistir", HataYeri, Istisna);
            }
        }
        private void SunucuSonIsleneniSec()
        {
            byte HataYeri = 0;
            try
            {
                if(SunucuSonIslenen!=null)
                {
                    int SunucuSayisi = Sunucular_ListBox.Items.Count;

                    for(int i=0;i<SunucuSayisi;i++)
                    {
                        if (Sunucular_ListBox.Items[i].ToString() == SunucuSonIslenen)
                        {
                            Sunucular_ListBox.SetSelected(i, true);
                        }
                    }

                }
            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("SunucuIsleneniSec()", HataYeri, Istisna);
            }
        }

        private void Sil_Btn_Click(object sender, EventArgs e)
        {
             byte HataYeri = 0;
            string Mesaj;
            try
            {
                HataYeri = 10;
                OrtakSinif.ButtonAktif(this, Sil_Btn, true);
                HataYeri = 11;
                string SecilenSunucu = Sunucular_ListBox.SelectedItem.ToString();
                HataYeri = 12;
                Sunucular_ListBox_SelectedIndexChanged(sender, e);
                HataYeri = 13;
                
                HataYeri = 2;
                string SilmeSorusu;
                switch(DilSec.aktifdil)
                {
                    case "tr":
                        SilmeSorusu = DilSec.Bu+" "+ DilSec.Baglanti.ToLower() + " " + DilSec.silinsinmi.ToLower();
                        break;
                    case "en":
                        SilmeSorusu = DilSec.silinsinmi + " " + DilSec.Bu.ToLower() + " " + DilSec.Baglanti.ToLower();
                        break;
                    default:
                        SilmeSorusu = "This connection will be DELETE!";
                        break;
                }
                
                DialogResult SilinsinMi = MessageBox.Show(SilmeSorusu, DilSec.silmeonay_caption,
    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button1);
                
                if(SilinsinMi == DialogResult.OK)
                {
                    //MessageBox.Show("silindi");
                    RegistryKey KlasorKullanici = KayitDefteri.KlasorKeyAktifKullanici;
                    RegistryKey KlasorSunucular = KlasorKullanici.OpenSubKey(KayitDefteri.KlasorSunucular, true);
                    using (KlasorSunucular)
                    {
                        KlasorSunucular.DeleteSubKeyTree(SecilenSunucu);
                    }
                    SunuculariListele();
                    List<TextBox> Haric = new List<TextBox>();
                    OrtakSinif.TextBoxBosalt(this, Haric);

                }
                else
                {

                }
                OrtakSinif.ButtonAktif(this, Sil_Btn, false);

            }
            catch(Exception Istisna)
            {
                switch(HataYeri)
                {
                    case 11:
                        Mesaj = DilSec.Lutfen + " " + DilSec.SunucuSec.ToLower();
                        MessageBox.Show(Mesaj);

                        break;
                    default:
                        OrtakSinif.ProgramHatasi("Sil_Btn_Click()", HataYeri, Istisna);
                        break;
                }
                OrtakSinif.ButtonAktif(this, Sil_Btn, false);

            }
        }

        private void Baglan_Btn_Click(object sender, EventArgs e)
        {
            byte HataYeri = 0;
            try
            {
                OrtakSinif.IslemiBekleButon(Baglan_Btn, true);
                HataYeri = 1;
                string SecilenSunucu = Sunucular_ListBox.SelectedItem.ToString();
                HataYeri = 2;

                //Baglan_Btn.BackgroundImage = Properties.Resources.saat24px;


                
                //Bağlantı bilgilerini MySQL yönetim formuna aktaralım
                    f03_MySQLYonet YeniForm = new f03_MySQLYonet();
                    YeniForm.BaglantiAdi = BaglantiAdi_TBox.Text;
                    YeniForm.DBHost = DBHost_TBox.Text;
                    YeniForm.DBUser = DBUser_TBox.Text;
                    YeniForm.DBPass = DBPass_TBox.Text;
                    YeniForm.Show();
                    this.Visible = false;

                OrtakSinif.IslemiBekleButon(Baglan_Btn, false);

            }
            catch (Exception Istisna)
            {
                switch(HataYeri)
                {
                    case 1:
                        MessageBox.Show(DilSec.Lutfen + " " + DilSec.SunucuSec.ToLower());
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("Baglan_Btn_Click()", HataYeri, Istisna);
                        break;
                }
            }
        }

        private void f02_Sunucular_VisibleChanged(object sender, EventArgs e)
        {
            FormTextleriDegistir(sender,e);
        }

        private void f02_Sunucular_Activated(object sender, EventArgs e)
        {
            if(OrtakSinif.FormActivateKilitli==false)
            {
                this.Baglan_Btn_Click(sender, e);
                OrtakSinif.FormActivateKilitli = true;
            }
        }
    }
}
