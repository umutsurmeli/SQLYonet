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
        bool TabloDuzenleAcKapaDurum = false;
        MySQLYonet mySQLYonet = new MySQLYonet();
        //DataSet ds = new DataSet();
        //BindingSource AktifTabloBS;
        BindingSource IstekTabloBS;
        DataTable IstekTabloDT;
        string SonIstek;
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
            //TabloDuzenleAcKapa();
            
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
                //TabloDuzenleAcKapaDurum = !TabloDuzenleAcKapaDurum;



            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f03_... TabloDuzenleAcKapa()", HataYeri, Istisna);
            }

            //TabloDuzenleAcKapaDurum = !TabloDuzenleAcKapaDurum;
        }
        private void TabloyuGuncelle(Object sender, EventArgs e)
        {

            HataYeri = 0;
            try
            {
                HataYeri = 1;
                mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                HataYeri = 2;

                IstekTabloBS.EndEdit();
                HataYeri = 3;
                DataTable dtdegisim = new DataTable();
                HataYeri = 4;
                dtdegisim = IstekTabloDT.GetChanges();


                //[ Date, DateTime, TimeStamp veri uyuşmazlıklarını giderelim "0001-01-01" > "0000-00-00"

                // Date, DateTime, TimeStamp veri uyuşmazlıklarını giderelim "0001-01-01" > "0000-00-00" ]
                mySQLYonet.TabloGuncelle(dtdegisim);// dtdegisim);
                //Sirala_Btn_Click(sender, e);
                //TabloyuGoster(Islemler_TabCtrl.TabPages[0].Text);
                //TabloListeKriteriDegistir(sender, e);
                TabloyuYenile();


                mySQLYonet.BaglantiKapat();
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 4:
                        //Hiçbirşey yapma çünkü değişiklik yapılmadı.
                        OrtakSinif.HataBildir(DilSec.HenuzDegistirilmedi, Istisna);
                        //TabloDuzenleAcKapaDurum = false;
                        TabloDuzenleAcKapa();
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet.TabloyuGuncelle()", HataYeri, Istisna);
                        TabloyuYenile();
                        break;
                }
            }
        }
        private void TabloyuYenile()
        {
            HataYeri = 0;
            try
            {
                if (mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName))
                {
                    IstekTabloDT = new DataTable();
                    IstekTabloDT = mySQLYonet.IstekCalistir(SonIstek);

                    //[ Güncellemede kullanmak üzere Table ve BindingSource saklayalım
                    IstekTabloBS = new BindingSource();
                    IstekTabloBS.DataSource = IstekTabloDT;
                    // Güncellemede kullanmak üzere Table ve BindingSource saklayalım ]
                    DGV_SQLSonuc.DataSource = IstekTabloBS;
                    TabloDuzenleAcKapaDurum = false;
                    TabloDuzenleAcKapa();
                    mySQLYonet.BaglantiKapat();
                }

            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f06_ Tabloyu yenile", HataYeri, Istisna);
            }
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

        private void Btn_SQLCalistir_Click(object sender, EventArgs e)
        {
            
            string Istek = RTBox_SQLYaz.Text;
            RTBox_SQLYaz.Clear();
            RTBox_SQLYaz.Text = Istek;
            SonIstek = Istek;
            HataYeri = 0;
            try
            {
                if(mySQLYonet.BaglantiAc(DBHost,DBUser,DBPass,DBName))
                {
                    IstekTabloDT = new DataTable();
                    IstekTabloDT = mySQLYonet.IstekCalistir(Istek);

                    //[ Güncellemede kullanmak üzere Table ve BindingSource saklayalım
                    IstekTabloBS = new BindingSource();
                    IstekTabloBS.DataSource = IstekTabloDT;
                    // Güncellemede kullanmak üzere Table ve BindingSource saklayalım ]
                    DGV_SQLSonuc.DataSource = IstekTabloBS;
                    mySQLYonet.BaglantiKapat();
                }
               OrtakSinif.RTBox_Renklendir(RenklenecekKomutlar, RTBox_SQLYaz);
                TabloDuzenleAcKapaDurum = false;
                TabloDuzenleAcKapa();
            }
            catch(Exception Istisna)
            {
                OrtakSinif.HataBildir(Istisna.ToString(), Istisna);
            }
            
        }

        private void TabloyuKaydet_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                HataYeri = 1;
                mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                HataYeri = 2;

                IstekTabloBS.EndEdit();
                HataYeri = 3;
                DataTable dtdegisim = new DataTable();
                HataYeri = 4;
                dtdegisim = IstekTabloDT.GetChanges();
                mySQLYonet.IstekTablosunuGuncelle(dtdegisim);// dtdegisim);
                mySQLYonet.BaglantiKapat();
                TabloDuzenleAcKapaDurum = false;
                TabloDuzenleAcKapa();
                TabloyuYenile();
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 4:
                        //Hiçbirşey yapma çünkü değişiklik yapılmadı.
                        OrtakSinif.HataBildir(DilSec.HenuzDegistirilmedi, Istisna);
                        //TabloDuzenleAcKapaDurum = false;
                        //TabloDuzenleAcKapa();
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet.Btn_IstekTabloKaydet_Click()", HataYeri, Istisna);
                        TabloyuYenile();
                        break;
                }
            }
        }

        private void TabloKaydetIptal_Btn_Click(object sender, EventArgs e)
        {
            TabloDuzenleAcKapaDurum = false;
            TabloDuzenleAcKapa();
            TabloyuYenile();
        }

        private void DGV_SQLSonuc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TabloDuzenleAcKapaDurum = true;
            TabloDuzenleAcKapa();
        }

        private void DGV_SQLSonuc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DGV_SQLSonuc.CurrentCell = DGV_SQLSonuc[e.ColumnIndex, e.RowIndex];
        }

        private void DGV_SQLSonuc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Don't throw an exception when we're done.
            e.ThrowException = false;

            // Display an error message.
            string Mesaj = "Error with " +
                DGV_SQLSonuc.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message.ToString();
            OrtakSinif.HataBildir(Mesaj, new Exception());

            // If this is true, then the user is trapped in this cell.
            //e.Cancel = true kalırsa kullanıcı o hücreye kilitlenir uygulamadan çıkamaz.
            e.Cancel = false;
        }

        private void DGV_SQLSonuc_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TabloDuzenleAcKapaDurum = true;
            TabloDuzenleAcKapa();
        }
    }
}
