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
    public partial class f06_MySQLKomutCalistir : Form
    {
        //[Buradaki veriler f02_Sunucular.cs tarafından bu form açılırken dolduruluyor
        public string BaglantiAdi;
        public string DBHost;
        public string DBUser;
        public string DBPass;
        public string DBName; // Sonradan tıklamayla seçilecek.
        //public string TabloListelenen;
        // ]
        bool TabloDuzenleAcKapaDurum = true;
        MySQLYonet mySQLYonet = new MySQLYonet();
        //DataSet ds = new DataSet();
        BindingSource AktifTabloBS;
        DataTable AktifTabloDT;
        byte HataYeri;
        string[] RenklenecekKomutlar;
        string FormAdi;
        //bool TabloKriteriniKullaniciTetikledi = false;

        public f06_MySQLKomutCalistir()
        {
            InitializeComponent();

        }
        public void FormTextleriDegistir(object sender, EventArgs e)
        {
            if (DilSec.aktifdil == null)
            {
                DilSec.tr();
            }

            FormAdi = "MySQL "+DilSec.Komut + " -" + DilSec.ProgramBaslik;
            this.Text = FormAdi;
            Lbl_DBNAME.Text = DilSec.VeriTabani;
            TabloKaydetIptal_Btn.Text = DilSec.iptal;
            TabloyuKaydet_Btn.Text = DilSec.kaydet;

        }


        public void f06_MySQLKomutCalistir_Load(object sender, EventArgs e)
        {
            SunucuAdi_Lbl.Text = BaglantiAdi;
            FormTextleriDegistir(sender, e);
            Btn_Genislet.BackColor = Color.Silver;
            dilSeciciKontrol1.button1.Click += FormTextleriDegistir;
            dilSeciciKontrol1.button2.Click += FormTextleriDegistir;
            cikisButon1.CikiButonButtonClicked += Cikis;
            RenklenecekKomutlar = mySQLYonet.IstekKomutlar();
            CBox_VeriTabanlariniDoldur();
            
        }
        public void Cikis(object sender, EventArgs e)
        {
            OrtakSinif.Cikis(DilSec.CikmakMi, DilSec.cikis);
        }
        private void CBox_VeriTabanlariniDoldur()
        {
            mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
            List<string> VeriTabanlari = mySQLYonet.VeriTabanlari();
            CBox_DBNAME.Items.Clear();
            int i = 0;
            int CBoxVTIndex = -1;
            foreach(string VTAdi in VeriTabanlari)
            {
                
                CBox_DBNAME.Items.Add(VTAdi);
                if(VTAdi == DBName) { CBoxVTIndex = i; }
                i++;
            }
            CBox_DBNAME.SelectedIndex = CBoxVTIndex;
            
            mySQLYonet.BaglantiKapat();
        }


        private void TabloDuzenleAcKapa()
        {
            HataYeri = 0;
            try
            {
                TabloyuKaydet_Btn.Enabled = TabloDuzenleAcKapaDurum;
                TabloKaydetIptal_Btn.Enabled = TabloDuzenleAcKapaDurum;
                if (TabloDuzenleAcKapaDurum == true)
                {
                    TabloyuKaydet_Btn.BackgroundImage = Properties.Resources.aktifButonBG;
                    TabloKaydetIptal_Btn.BackgroundImage = Properties.Resources.aktifButonBG;
                }
                else
                {
                    TabloyuKaydet_Btn.BackgroundImage = null;
                    TabloKaydetIptal_Btn.BackgroundImage = null;
                }
                //TabloKayitlar_DGV.Enabled = TabloDuzenleAcKapaDurum;

                List<Control> Haric = new List<Control>();
                Haric.Add(TabloyuKaydet_Btn);
                Haric.Add(TabloKaydetIptal_Btn);
                Haric.Add(DGV_SQLSonuc);

                //MessageBox.Show(Haric.Count.ToString());
                OrtakSinif.KontrolleriAcKapat_Form("f06_MySQLKomutCalistir", Haric, !TabloDuzenleAcKapaDurum);



            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f03_... TabloDuzenleAcKapa()", HataYeri, Istisna);
            }

            //TabloDuzenleAcKapaDurum = !TabloDuzenleAcKapaDurum;
        }
        private void Btn_Genislet_Click(object sender, EventArgs e)
        {
            if (Btn_Genislet.BackColor != Color.Silver)
            {
                RTBox_SQLYaz.Width = this.Width - 50;
                DGV_SQLSonuc.Width = this.Width - 50;
                LVw_SQLLog.Width = this.Width - 50;
                Btn_Genislet.BackColor = Color.Silver;
            }
            else
            {
                RTBox_SQLYaz.Width = 50;
                DGV_SQLSonuc.Width = 50;
                LVw_SQLLog.Width = 50;
                Btn_Genislet.BackColor = Color.Yellow;
            }

        }
        private void CBox_DBNAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBName = CBox_DBNAME.SelectedItem.ToString();
            //MessageBox.Show(DBName);
        }

    }
}
