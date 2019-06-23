using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLYonet
{
    public partial class f05_TabloKopyala : Form
    {
        public f05_TabloKopyala()
        {
            InitializeComponent();
        }
        //[Buradaki veriler f02_Sunucular.cs tarafından bu form açılırken dolduruluyor
        public string BaglantiAdi;
        public string DBHost;
        public string DBUser;
        public string DBPass;
        public string DBName; // Sonradan tıklamayla seçilecek.
        public string KopyalanacakTabloAdi;
        // ]
        byte HataYeri;
        string FormAdi;
        string YeniTabloAdiYaz;
        string LutfenIslemSec;

        MySQLYonet mySQLYonet = new MySQLYonet();
        private void f05_TabloKopyala_Load(object sender, EventArgs e)
        {
            SunucuAdi_Lbl.Text = BaglantiAdi;
            VeriTabaniAdi_TBox.Text = DBName;
            TabloAdi_TBox.Text = KopyalanacakTabloAdi;
            FormTextleriDegistir(sender,e);
        }
        public void FormTextleriDegistir(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                if (DilSec.aktifdil == null)
                {
                    DilSec.tr();
                }

                if (DilSec.aktifdil == "tr")
                {
                    FormAdi = DilSec.Tablo + " " + DilSec.Kopyala + " -" + DilSec.ProgramBaslik;
                    KopyalaVeriVeYapi_RBtn.Text = DilSec.Yapi + " " + DilSec.VE + " " + DilSec.Veri.ToLower() + " " + DilSec.Kopyala.ToLower();
                    KopyalaYapi_RBtn.Text = DilSec.Sadece + " " + DilSec.Yapi.ToLower() + " " + DilSec.Kopyala.ToLower();
                    YeniTabloAdiYaz = DilSec.Yeni + " " + DilSec.Tablo.ToLower() + " " + DilSec.Adi.ToLower() + " " + DilSec.BosOlmaz.ToLower();
                    LutfenIslemSec = DilSec.Lutfen + " " + DilSec.Islem.ToLower() + " " + DilSec.Secin.ToLower();
                }
                else if (DilSec.aktifdil == "en")
                {
                    FormAdi = DilSec.Kopyala + " " + DilSec.Tablo + " -" + DilSec.ProgramBaslik;
                    KopyalaVeriVeYapi_RBtn.Text = DilSec.Kopyala + " " + DilSec.Yapi.ToLower() + " " + DilSec.VE + " " + DilSec.Veri.ToLower();
                    KopyalaYapi_RBtn.Text = DilSec.Kopyala + " " + DilSec.Sadece.ToLower() + " " + DilSec.Yapi.ToLower();
                    YeniTabloAdiYaz = DilSec.Yeni + " " + DilSec.Tablo.ToLower() + " " + DilSec.Adi.ToLower() + " " + DilSec.BosOlmaz.ToLower();
                    LutfenIslemSec = DilSec.Lutfen + " " + DilSec.Secin.ToLower() + " " + DilSec.Islem.ToLower();
                }

                this.Text = FormAdi;
                VeriTabaniAdi_Lbl.Text = DilSec.VeriTabani + " " + DilSec.Adi;
                TabloAdi_Lbl.Text = DilSec.Tablo + " " + DilSec.Adi;
                TabloKopyaAdi_Lbl.Text = DilSec.Yeni + " " + DilSec.Tablo + " " + DilSec.Adi;

                Kopyala_Btn.Text = DilSec.Kopyala;
                Iptal_Btn.Text = DilSec.iptal;
            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f05_*.FormTextleriDegistir", HataYeri, Istisna);
            }

        }

        private void Iptal_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kopyala_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            string Islem="";
            string TabloYeniKopyaAdi = "";
            string mesaj = "";
            bool sonuc = false;
            
            try
            {

                TabloYeniKopyaAdi = TabloKopyaAdi_TBox.Text;
                if(TabloYeniKopyaAdi == String.Empty)
                {

                    MessageBox.Show(YeniTabloAdiYaz);
                    return;
                }
                HataYeri = 10;
                foreach (RadioButton secim in TabloIslem_GBox.Controls)
                {
                    if (secim.Checked == true)
                    {
                        Islem = secim.Tag.ToString();
                    }
                    HataYeri++;
                }
                HataYeri = 100;
                mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                //Islem radiobuttonların Tag özelliğinde tanımlı olmalı
                if (Islem == "Yapi")
                {
                    

                    sonuc = mySQLYonet.TabloYapisiniKopyala(KopyalanacakTabloAdi, TabloYeniKopyaAdi);
                    if(sonuc == true)
                    {

                        MessageBox.Show(DilSec.Tablo+" "+DilSec.Yapi.ToLower()+" "+DilSec.kopyalandi);
                    }


                    
                    

                }
                else if(Islem == "VeriVeYapi")
                {
                    HataYeri = 110;
                    sonuc = mySQLYonet.TabloYapisiniKopyala(KopyalanacakTabloAdi, TabloYeniKopyaAdi);
                    if (sonuc == true)
                    {

                        mesaj = DilSec.Tablo + " " + DilSec.Yapi.ToLower() + " " + DilSec.kopyalandi;
                    }
                    HataYeri = 115;
                    int KopyalananKayitSayisi = mySQLYonet.TabloVerisiniKopyala(KopyalanacakTabloAdi, TabloYeniKopyaAdi);
                    mesaj += "\r\n " + KopyalananKayitSayisi.ToString()+" "+ DilSec.Satir + " " + DilSec.kopyalandi.ToLower();
                    MessageBox.Show(mesaj);
                }
                else
                {
                    MessageBox.Show(LutfenIslemSec);
                }
                if(sonuc == true)
                {
                    OrtakSinif.FormActivateKilitli = false;
                    mySQLYonet.BaglantiKapat();
                    this.Close();
                }
                mySQLYonet.BaglantiKapat();
            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f05_TabloKopyala.Kopyala_Btn_Click", HataYeri, Istisna);
                mySQLYonet.BaglantiKapat();
            }
        }
    }
}
