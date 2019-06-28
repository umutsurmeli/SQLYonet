using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Gereksinimler


namespace SQLYonet
{
    public partial class f03_MySQLYonet : Form
    {
        //[Buradaki veriler f02_Sunucular.cs tarafından bu form açılırken dolduruluyor
        public string BaglantiAdi;
        public string DBHost;
        public string DBUser;
        public string DBPass;
        public string DBName; // Sonradan tıklamayla seçilecek.
        public string TabloListelenen;
        // ]
        bool TabloDuzenleAcKapaDurum = true;
        MySQLYonet mySQLYonet = new MySQLYonet();
        //DataSet ds = new DataSet();
        BindingSource AktifTabloBS;
        BindingSource IstekTabloBS;
        DataTable AktifTabloDT;
        DataTable IstekTabloDT;


        
        byte HataYeri;
        string[] RenklenecekKomutlar;
        string FormAdi;
        bool TabloKriteriniKullaniciTetikledi = false;
        // TabloKriteriniKullaniciTetikledi değişkeni Olayın kendi içinde tekrar etmesini engellemek için kullanılıyor.
        // İlk kullanımda "TabloyuGoster()" biz tablodan aldığımız verilerle sıralama kriterlerinin kontrollerini 
        // oluşturup değiştiriyoruz. "TabloyuGoster()" işlemi biterken TabloKriteriniKullaniciTetikledi = true 
        // yapıyoruz;bağlı event'ın kendi  kendini tetiklemesini engelliyoruz.
        // Bknz. TabloKolonlar_CBox_SelectedIndexChanged , Artan_Chck_CheckStateChanged, Kacarli_CBox_SelectedIndexChanged
        // TabloyuGoster() > TabloKolonlar_CBox.SelectedIndex = 0;
        public f03_MySQLYonet()
        {
            InitializeComponent();
            dilSeciciKontrol1.button1.Click += FormTextleriDegistir;
            dilSeciciKontrol1.button2.Click += FormTextleriDegistir;
            RenklenecekKomutlar = mySQLYonet.IstekKomutlar();

        }

        private void TekrarBaglan_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(BaglantiAdi+" "+DBHost+" "+DBUser+" "+DBPass);
            //OrtakSinif.AcikFormlar();
            this.Close();
        }


        public void f03_MySQLYonet_Load(object sender, EventArgs e)
        {
            FormAcilinca(sender,e);
        }
        public void FormAcilinca(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {

                SunucuAdi_Lbl.Text = BaglantiAdi;
                HataYeri = 1;
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                if (BaglantiDurumu == true)
                {

                    TekrarBaglan_Btn.Enabled = false;
                    VeriTabanlariniListele();

                    HataYeri = 11;

                }
                else
                {
                    TekrarBaglan_Btn.Enabled = true;
                    SunucuAdi_PBox.Image = Properties.Resources.db_sil24px;
                }
                HataYeri = 2;
                FormTextleriDegistir(sender, e);
                HataYeri = 3;
                Kacarli_CBox.SelectedIndex = 0;
                HataYeri = 4;
                //[ Event varsa silelim aksi halde kaç defa tekrar edilmişse o kadar açıyor
                TabloTVKopyala_TSMI.Click -= TabloKopyalamaFormuAc;
                TabloTVKopyala_TSMI.Click += TabloKopyalamaFormuAc;
                // Event varsa silelim aksi halde kaç defa tekrar edilmişse o kadar açıyor ]

            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 1:
                        //MessageBox.Show("Bağlantı kurulamadı");
                        //MySQLYonet ten OrtakSinif.HataBildir() çalışıyor.
                        //dolayısıyla burası hiç çalışmıyor.

                        break;
                    case 2:
                        //MessageBox.Show("Veri Tabanları okunamıyor");
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet_Load() Veri Tabanları okunamıyor", HataYeri, Istisna);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet_Load()", HataYeri, Istisna);
                        break;
                }

            }
        }
        public void VeriTabanlariniListele()
        {
            List<string> VeriTabanlari = new List<string>();

            HataYeri = 11;
            //TreeView ImageList
            ImageList myImageList = new ImageList();
            myImageList.Images.Add(Properties.Resources.db_root24px);
            myImageList.Images.Add(Properties.Resources.db_24px);
            myImageList.Images.Add(Properties.Resources.db_ekle24px);
            myImageList.Images.Add(Properties.Resources.db_sil24px);
            myImageList.Images.Add(Properties.Resources.db_table24px);
            myImageList.Images.Add(Properties.Resources.db_function24px);
            myImageList.Images.Add(Properties.Resources.db_view24px);
            Sunucu_TreeView.ImageList = myImageList;

            HataYeri = 2;
            VeriTabanlari = mySQLYonet.VeriTabanlari();
            Sunucu_TreeView.Nodes.Clear();

            TreeNode SunucuVT;
            for (int i = 0; i < VeriTabanlari.Count; i++)
            {

                SunucuVT = new TreeNode(VeriTabanlari[i], 1, 1);
                SunucuVT.Tag = "DataBase";
                Sunucu_TreeView.Nodes.Add(SunucuVT);

                /*
                RadioButton VTradios = new RadioButton();
                VTradios.Name = "VTRadio_" + i.ToString();
                VTradios.Text = VeriTabanlari[i];
                VTradios.Top = VTGrup.Top + (i * 15);
                VTGrup.Controls.Add(VTradios);
                */


            }
        }



        private void f03_MySQLYonet_FormClosing(object sender, FormClosingEventArgs e)
        {
            HataYeri = 0;
            //Form Kapanınca tekrar sunucu seçimini gösterelim.
            try
            {
                mySQLYonet.BaglantiKapat();
                HataYeri = 1;
                if(OrtakSinif.GizliFormuAc("f02_Sunucular") == 0)
                {
                    Form YeniForm = new f02_Sunucular();
                    YeniForm.Show();
                }


            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 0:
                        OrtakSinif.GizliFormuAc("f02_Sunucular");
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet_FormClosing", HataYeri, Istisna);
                        break;
                }
            }
        }

        private void TekrarBaglan_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                OrtakSinif.IslemiBekleButon(TekrarBaglan_Btn, true);
                HataYeri = 1;
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                if (BaglantiDurumu == true)
                {
                    VeriTabanlariniListele();
                    SunucuAdi_PBox.Image = Properties.Resources.db_root24px;

                }
                else
                {
                    //MessageBox.Show(BaglantiDurumu.ToString());
                    //OrtakSinif.GizliFormuAc("f02_Sunucular");
                    //f02_Sunucular.ActiveForm.Visible = true;
                    //this.Visible = false;
                }
                OrtakSinif.IslemiBekleButon(TekrarBaglan_Btn, false);
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("TekrarBaglan_Btn_Click", HataYeri, Istisna);
            }
        }

        private void Sunucular_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormTextleriDegistir(object sender, EventArgs e)
        {
            if (DilSec.aktifdil == null)
            {
                DilSec.tr();
            }

            if (DilSec.aktifdil == "tr")
            {
                FormAdi = "MySQL " + DilSec.Yonet + " -" + DilSec.ProgramBaslik;
            }
            else if (DilSec.aktifdil == "en")
            {
                FormAdi = DilSec.Yonet + " MySQL" + " -" + DilSec.ProgramBaslik;
            }

            this.Text = FormAdi;
            TekrarBaglan_Btn.Text = DilSec.TekrarBaglan;
            Sunucular_Btn.Text = DilSec.Sunucular;
            KolonaGore_Lbl.Text = DilSec.SunaGore;
            Artan_Lbl.Text = DilSec.Artan;
            Kacarli_Lbl.Text = DilSec.KacarliCvp;
            TabloListeGeri_Btn.Text = DilSec.Geri;
            TabloListeIleri_Btn.Text = DilSec.Ileri;
            TabloKayitSayisiAciklama_Lbl.Text = DilSec.Satir;

            Sirala_Btn.Text = DilSec.Sirala;
            TabloKaydetIptal_Btn.Text = DilSec.iptal;
            TabloyuKaydet_Btn.Text = DilSec.kaydet;
            TabloTVKopyala_TSMI.Text = DilSec.Tablo + " " + DilSec.Kopyala;
            TabloTVYokEt_TSMI.Text = DilSec.Tablo + " " + DilSec.YokEt;
            TabloTVBosalt_TSMI.Text = DilSec.Tablo + " " + DilSec.Bosalt;



            




        }
        void TabloDGVTemizle()
        {
            //Tablo DataGridView temizle
            DataTable dt = new DataTable();
            AktifTabloDT = new DataTable();
            TabloKayitlar_DGV.DataSource = dt;
            Islemler_TabCtrl.TabPages[0].Text = "";
            TabloKayitSayisi_Lbl.Text = "0";
            TabloGecerliSayfa_TBox.Text = "1";
            TabloToplamSayfa_TBox.Text = "";

            TabloDuzenleAcKapaDurum = false;
            TabloDuzenleAcKapa();
        }
        private void Sunucu_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HataYeri = 0;
            try
            {
                HataYeri = 1;
                string SecilenTuru = Sunucu_TreeView.SelectedNode.Tag.ToString();
                string SecilenAdi = Sunucu_TreeView.SelectedNode.Text;
                switch (SecilenTuru)
                {
                    case "DataBase":
                        VTAltNesneleriGetir();
                        TabloDGVTemizle();
                        TabloKolonlar_CBox.Items.Clear();
                        Sunucu_TreeView.SelectedNode.Expand();

                        break;
                    case "Table":
                        HataYeri = 19;
                        TreeViewSecilenAltNesneden_VTBul();
                        
                        HataYeri = 20;
                        //TabloKolonlarComboBox(SecilenAdi, TabloKolonlar_CBox);
                        HataYeri = 21;
                        //TabloKolonlar_CBox.SelectedIndex = 0;
                        HataYeri = 22;
                        TabloyuGoster(SecilenAdi);
                        break;
                    case "View":
                        TreeViewSecilenAltNesneden_VTBul();
                        HataYeri = 221;
                        TabloyuGoster(SecilenAdi); // View için TabloyuGoster sorgusu aynıdır.
                        break;
                    case "Function":
                        TreeViewSecilenAltNesneden_VTBul();
                        TabloDGVTemizle();
                        TabloKolonlar_CBox.Items.Clear();
                        break;


                    default:
                        
                        TabloDGVTemizle();
                        TabloKolonlar_CBox.Items.Clear();
                        break;
                }
                HataYeri = 11;
                TabloDBName_Lbl.Text = DBName;
                //MessageBox.Show(SecilenTuru);

            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 1:
                        OrtakSinif.ProgramHatasi("Sunucu_TreeView_Click() SelectedNode.Tag boş olabilir.", HataYeri, Istisna);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("Sunucu_TreeView_Click()", HataYeri, Istisna);
                        break;
                }
            }
        }
        void VTAltNesneleriGetir()
        {
            HataYeri = 0;
            try
            {
                HataYeri = 10;
                //MessageBox.Show(Sunucu_TreeView.SelectedNode.Text +" "+ Sunucu_TreeView.SelectedNode.Index.ToString());
                DBName = Sunucu_TreeView.SelectedNode.Text;

                //VTGrup.Controls[Sunucu_TreeView.SelectedNode.Index].Select();
                HataYeri = 11;
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                if (BaglantiDurumu == true)
                {
                    mySQLYonet.VeriTabaniSec(DBName);
                    List<string> Tablolar = new List<string>();
                    Tablolar = mySQLYonet.Tablolar();

                    HataYeri = 111;
                    List<string> Viewler = new List<string>();
                    Viewler = mySQLYonet.Viewler();

                    HataYeri = 12;
                    List<string> Fonksiyonlar = new List<string>();
                    Fonksiyonlar = mySQLYonet.Fonksiyonlar();

                    /*
                    listBox1.Items.Clear();
                    foreach (string TAdi in Tablolar)
                    {

                        listBox1.Items.Add(TAdi);
                    }
                    */
                    HataYeri = 13;
                    TreeNode SecilenVT = Sunucu_TreeView.SelectedNode;
                    SecilenVT.Nodes.Clear();

                    TreeNode SecilenVT_BirTablosu;
                    foreach (string TabloAdi in Tablolar)
                    {
                        SecilenVT_BirTablosu = new TreeNode(TabloAdi, 4, 4);
                        SecilenVT_BirTablosu.Tag = "Table";
                        SecilenVT.Nodes.Add(SecilenVT_BirTablosu);
                    }

                    HataYeri = 130;
                    TreeNode SecilenVT_BirViewi;
                    foreach (string ViewAdi in Viewler)
                    {
                        SecilenVT_BirViewi = new TreeNode(ViewAdi, 6, 6);
                        SecilenVT_BirViewi.Tag = "View";
                        SecilenVT.Nodes.Add(SecilenVT_BirViewi);
                    }

                    TreeNode SecilenVT_BirFonksiyonu;
                    foreach (string FonksiyonAdi in Fonksiyonlar)
                    {
                        SecilenVT_BirFonksiyonu = new TreeNode(FonksiyonAdi, 5, 5);
                        SecilenVT_BirFonksiyonu.Tag = "Function";
                        SecilenVT.Nodes.Add(SecilenVT_BirFonksiyonu);
                    }
                    mySQLYonet.BaglantiKapat();
                    //Sunucu_TreeView.CollapseAll();

                    //SecilenVT.Expand();

                }
                else
                {

                }
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("Sunucu_TreeView_Click()", HataYeri, Istisna);
                        break;
                }

            }


            //MessageBox.Show(Sunucu_TreeView.SelectedNode.Text);
        }
        void TreeViewSecilenAltNesneden_VTBul()
        {
            HataYeri = 0;
            try
            {
                TreeNode SecilenAltNesne = Sunucu_TreeView.SelectedNode;
                HataYeri = 10;
                string VTAdi = SecilenAltNesne.Parent.Text;
                DBName = VTAdi;
                //MessageBox.Show(DBName);
                /*
                foreach (Control radio in VTGrup.Controls)
                {
                    if (radio.Text == VTAdi)
                    {
                        radio.Select();
                    }
                }
                */
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("VTRadioIsaretle()", HataYeri, Istisna);
                        break;
                }

            }
        }
        private void TabloyuYenile()
        {
            HataYeri = 0;
            try
            {
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                string TabloAdi = Islemler_TabCtrl.TabPages[0].Text;
                if (BaglantiDurumu == true)
                {
                    DataTable dt = new DataTable();
                    BindingSource bs = new BindingSource();
                    string SayfaNo = TabloGecerliSayfa_TBox.Text;
                    string Kacarli = Kacarli_CBox.SelectedItem.ToString();
                    string Egore = TabloKolonlar_CBox.SelectedItem.ToString();
                    bool Artan = Artan_Chck.Checked;
                    dt = mySQLYonet.TabloListele(TabloAdi, SayfaNo, Kacarli, Egore, Artan);
                    bs.Clear();
                    bs.DataSource = dt;
                    //[ Güncellemede kullanmak üzere Table ve BindingSource saklayalım
                    AktifTabloBS = new BindingSource();
                    AktifTabloBS = bs;
                    AktifTabloDT = new DataTable();
                    AktifTabloDT = dt;
                    // Güncellemede kullanmak üzere Table ve BindingSource saklayalım ]
                    TabloKayitlar_DGV.DataSource = bs;
                    //DGVVeriTipiDuzenle(TabloAdi);
                    TabloDuzenleAcKapaDurum = false;
                    TabloDuzenleAcKapa();
                }
                mySQLYonet.BaglantiKapat();
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("TabloyuGoster()", HataYeri, Istisna);
                        break;
                }
            }
        }
        void IstekCalistir(string Istek)
        {
            mySQLYonet.SonIstek = Istek;

        }
        void TabloyuGoster(string TabloAdi)
        {
            HataYeri = 0;
            TabloKriteriniKullaniciTetikledi = false;
            try
            {
                TabloKolonlar_CBox.Items.Clear();
                HataYeri = 1;
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                HataYeri = 11;
                Islemler_TabCtrl.TabPages[0].Text = TabloAdi;

                HataYeri = 2;
                if (BaglantiDurumu == true)
                {
                    DataTable dt = new DataTable();
                    BindingSource bs = new BindingSource();
                    
                    HataYeri = 21;
                    //mySQLYonet.VeriTabaniSec(DBName);
                    //dt.Clear();
                    HataYeri = 22;
                    //dt =mySQLYonet.TabloOku(TabloAdi);
                    HataYeri = 23;
                    string SayfaNo = TabloGecerliSayfa_TBox.Text;
                    HataYeri = 24;
                    string Kacarli = Kacarli_CBox.SelectedItem.ToString();
                    //MessageBox.Show(Kacarli);
                    HataYeri = 25;
                    string Egore = "";
                    if (TabloKolonlar_CBox.Items.Count > 0)
                    {
                        Egore = TabloKolonlar_CBox.SelectedItem.ToString();
                    }
                    HataYeri = 26;
                    Artan_Chck.Checked = true;
                    bool Artan = Artan_Chck.Checked;
                    

                    HataYeri = 27;
                    dt = mySQLYonet.TabloListele(TabloAdi, SayfaNo, Kacarli, Egore, Artan);
                    
                    //Tablo Kolonlar Combobox ı dolduralım
                    TabloKolonlar_CBox.Items.Clear();
                    HataYeri = 28;
                    
                    foreach (DataColumn column in dt.Columns)
                    {
                        TabloKolonlar_CBox.Items.Add(column.ColumnName);

                    }

                   TabloKolonlar_CBox.SelectedIndex = 0;

                    // ]

                    HataYeri = 23;
                    bs.Clear();
                    bs.DataSource = dt;
                    //[ Güncellemede kullanmak üzere Table ve BindingSource saklayalım
                    AktifTabloBS = new BindingSource();
                    AktifTabloBS = bs;
                    AktifTabloDT = new DataTable();
                    AktifTabloDT = dt;//dt;
                    // Güncellemede kullanmak üzere Table ve BindingSource saklayalım ]
                    TabloKayitlar_DGV.DataSource = bs;

                    //DGVVeriTipiDuzenle(TabloAdi);
                    //dataGrid1.DataSource = bs;
                    //MessageBox.Show(dt.Columns.Count.ToString());
                    TabloKayitlar_DGV.Sort(TabloKayitlar_DGV.Columns[0], ListSortDirection.Ascending);


                    int TabloKayitSayisi = mySQLYonet.AktifTabloToplamKayitSayisi;
                    TabloKayitSayisi_Lbl.Text = TabloKayitSayisi.ToString();
                    if (Convert.ToInt32(Kacarli) >= TabloKayitSayisi)
                    {
                        TabloToplamSayfa_TBox.Text = "1";

                    }
                    else
                    {
                        int KacarliInt = Convert.ToInt32(Kacarli);
                        int Kalan = TabloKayitSayisi % KacarliInt;
                        int TabloToplamSayfaSayisi;
                        if (Kalan==0)
                        {
                            TabloToplamSayfaSayisi = TabloKayitSayisi / KacarliInt;
                        }
                        else
                        {
                            TabloToplamSayfaSayisi = ((TabloKayitSayisi - Kalan) / KacarliInt) + 1;
                        }
                        TabloToplamSayfa_TBox.Text = TabloToplamSayfaSayisi.ToString();
                    }



                    



                }//Baglanti sağlandı ise

                HataYeri = 200;
                mySQLYonet.BaglantiKapat();
                TabloKriteriniKullaniciTetikledi = true;
                
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("TabloyuGoster()", HataYeri, Istisna);
                        break;
                }
                TabloKriteriniKullaniciTetikledi = true;
                

            }
        }
        /* Gerek kalmadı sorguda MySQL formatında string olarak alıyoruz.
        private void DGVVeriTipiDuzenle(string TabloAdi)
        {
            
            string[] TabloKolonTipleri = mySQLYonet.TabloKolonlar(TabloAdi, 1);
            for (int i = 0; i < TabloKolonTipleri.Count(); i++)
            {
                if (TabloKolonTipleri[i].Contains("datetime"))
                {
                    TabloKayitlar_DGV.Columns[i].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

                }
                else if (TabloKolonTipleri[i].Contains("timestamp"))
                {
                    TabloKayitlar_DGV.Columns[i].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                }
                else if (TabloKolonTipleri[i].Contains("date"))
                {
                    TabloKayitlar_DGV.Columns[i].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
            }
            
            
        }*/
        private DataGridView DGVKopyala(DataGridView Kopyalanacak)
        {
            //2019-02-26 Bu prosedür datagridviewle ilgili bir sorun sebebiple boş kopyalar oluşturmak amacıyla oluşturuldu.
            // Sorun çözülmedi ama bu prosedür çalıştığı ve başka bir yerde kullanılabileceği için saklı tutulacak.
            foreach(Control x in this.Controls)
            {
                if(x.Name != Kopyalanacak.Name && x is DataGridView)
                {
                    x.Dispose();
                    this.Controls.Remove(x);
                }
            }



            DataGridView yeni = new DataGridView();
            yeni.Width = Kopyalanacak.Width;
            yeni.Height = Kopyalanacak.Height;
            yeni.Top = Kopyalanacak.Top;
            yeni.Left = Kopyalanacak.Left;
            Kopyalanacak.Visible = false;
            TabloDuzenle_TPg.Controls.Add(yeni);
            return yeni;
        }
        public void TabloKolonlarComboBox(string TabloAdi,ComboBox comboBox)
        {
            //2019-02-27 Artık kullanılmıyor bunun yerine dataTable dan aldığım verileri ikinci
            // bir sorguya ihtiyaç duymaksızın comboBox'a aktarıyorum.
            HataYeri = 0;
            try
            {
                mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                //mySQLYonet.VeriTabaniSec(DBName);
                comboBox.Items.Clear();
                string[] Kolonlar = new string[] { };
                Kolonlar = mySQLYonet.TabloKolonlar(TabloAdi,0);
                foreach(string Kolon in Kolonlar)
                {
                    comboBox.Items.Add(Kolon);
                }

                mySQLYonet.BaglantiKapat();

            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloKolonlarComboBox()", HataYeri, Istisna);
                        break;
                }
            }
        }

        private void Sunucu_TreeView_MouseMove(object sender, MouseEventArgs e)
        {
            Sunucu_TreeView.Focus();
        }

        private void Sirala_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                HataYeri = 1;
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                HataYeri = 11;

                if(Islemler_TabCtrl.TabPages[0].Text.Length == 0) { return; }

                HataYeri = 2;
                if (BaglantiDurumu == true)
                {
                    DataTable dt = new DataTable();
                    BindingSource bs = new BindingSource();

                    string SayfaNo = TabloGecerliSayfa_TBox.Text;
                    HataYeri = 24;
                    string Kacarli = Kacarli_CBox.SelectedItem.ToString();
                    HataYeri = 25;
                    string Egore = "";
                    if (TabloKolonlar_CBox.Items.Count > 0)
                    {
                        Egore = TabloKolonlar_CBox.SelectedItem.ToString();
                    }
                    HataYeri = 26;
                    bool Artan = Artan_Chck.Checked;
                    HataYeri = 27;
                    dt = mySQLYonet.TabloListele(Islemler_TabCtrl.TabPages[0].Text, SayfaNo, Kacarli, Egore, Artan);

                    HataYeri = 23;
                    bs.Clear();
                    bs.DataSource = dt;
                    AktifTabloDT.Clear();
                    AktifTabloDT = new DataTable();
                    AktifTabloDT = dt;
                    TabloKayitlar_DGV.DataSource = bs;
                    //DGVVeriTipiDuzenle(Islemler_TabCtrl.TabPages[0].Text);
                    
                    TabloDuzenleAcKapaDurum = false;
                    TabloDuzenleAcKapa();

                    int TabloKayitSayisi = mySQLYonet.AktifTabloToplamKayitSayisi;
                    TabloKayitSayisi_Lbl.Text = TabloKayitSayisi.ToString();
                    if (Convert.ToInt32(Kacarli) >= TabloKayitSayisi)
                    {
                        TabloToplamSayfa_TBox.Text = "1";

                    }
                    else
                    {
                        int KacarliInt = Convert.ToInt32(Kacarli);
                        int Kalan = TabloKayitSayisi % KacarliInt;
                        int TabloToplamSayfaSayisi;
                        if (Kalan == 0)
                        {
                            TabloToplamSayfaSayisi = TabloKayitSayisi / KacarliInt;
                        }
                        else
                        {
                            TabloToplamSayfaSayisi = ((TabloKayitSayisi - Kalan) / KacarliInt) + 1;
                        }
                        TabloToplamSayfa_TBox.Text = TabloToplamSayfaSayisi.ToString();
                    }







                }//Baglanti sağlandı ise

                HataYeri = 200;
                mySQLYonet.BaglantiKapat();
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("Sirala_Btn_Click()", HataYeri, Istisna);
                        break;
                }

            }
        }

        private void TabloListeGeri_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                if (Islemler_TabCtrl.TabPages[0].Text.Length > 0) //Tablo seçili ise zaten Toplam kayıt sayısı hesaplanmıştır.
                {
                    HataYeri = 1;
                    //mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                    int TabloKayitSayisi = mySQLYonet.AktifTabloToplamKayitSayisi;
                    int TabloGecerliSayfa = Convert.ToInt32(TabloGecerliSayfa_TBox.Text);
                    int TabloToplamSayfa = Convert.ToInt32(TabloToplamSayfa_TBox.Text);
                    if(TabloGecerliSayfa >1)
                    {
                        TabloGecerliSayfa--;
                        TabloGecerliSayfa_TBox.Text = TabloGecerliSayfa.ToString();
                        Sirala_Btn_Click(sender,e);
                    }

                    //MessageBox.Show(TabloKayitSayisi.ToString());
                    //mySQLYonet.BaglantiKapat();
                }
            }
            catch(Exception Istisna)
            {
                switch(HataYeri)
                {
                    default:
                        OrtakSinif.ProgramHatasi("TabloListeGeri_Btn_Click()", HataYeri, Istisna);
                        break;
                }
            }
            
           
        }
 
        private void TabloListeIleri_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                if (Islemler_TabCtrl.TabPages[0].Text.Length > 0) //Tablo seçili ise zaten Toplam kayıt sayısı hesaplanmıştır.
                {
                    HataYeri = 1;
                    int TabloKayitSayisi = mySQLYonet.AktifTabloToplamKayitSayisi;
                    int TabloGecerliSayfa = Convert.ToInt32(TabloGecerliSayfa_TBox.Text);
                    int TabloToplamSayfa = Convert.ToInt32(TabloToplamSayfa_TBox.Text);
                    if (TabloGecerliSayfa < TabloToplamSayfa)
                    {
                        TabloGecerliSayfa++;
                        TabloGecerliSayfa_TBox.Text = TabloGecerliSayfa.ToString();
                        Sirala_Btn_Click(sender, e);
                    }

                }
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    default:
                        OrtakSinif.ProgramHatasi("TabloListeIleri_Btn_Click()", HataYeri, Istisna);
                        break;
                }
            }


        }
        private void TabloListeKriteriDegistir(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                HataYeri = 1;
                if (Islemler_TabCtrl.TabPages[0].Text != String.Empty)
                {
                    string TabloAdi = Islemler_TabCtrl.TabPages[0].Text;
                    TabloDGVTemizle();
                    Islemler_TabCtrl.TabPages[0].Text = TabloAdi;
                    
                    Sirala_Btn_Click(sender, e);
                }
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    default:
                        OrtakSinif.ProgramHatasi("SiralamaKriteriDegistir()", HataYeri, Istisna);
                        break;
                }
            }
        }
        private void TabloKolonlar_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabloKriteriniKullaniciTetikledi  == true)
            {
                TabloListeKriteriDegistir(sender, e);
            }
        }

        private void Artan_Chck_CheckStateChanged(object sender, EventArgs e)
        {
            if (TabloKriteriniKullaniciTetikledi == true)
            {
                TabloListeKriteriDegistir(sender, e);
            }
        }

        private void Kacarli_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabloKriteriniKullaniciTetikledi == true)
            {
                TabloListeKriteriDegistir(sender, e);
            }
        }


        private void TabloyuGuncelle(Object sender, EventArgs e)
        {

            HataYeri = 0;
            try
            {
                HataYeri = 1;
                mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                HataYeri = 2;
                
                    AktifTabloBS.EndEdit();
                HataYeri = 3;
                DataTable dtdegisim = new DataTable();
                HataYeri = 4;
                dtdegisim = AktifTabloDT.GetChanges();
                

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
                        TabloDuzenleAcKapaDurum = false;
                        TabloDuzenleAcKapa();
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet.TabloyuGuncelle()", HataYeri, Istisna);
                        TabloyuYenile();
                        break;
                }
            }
        }

        private void TabloyuKaydet_Btn_Click(object sender, EventArgs e)
        {
            TabloyuGuncelle(sender, e);
        }

        private void TabloKayitlar_DGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("burası çalıştı");
            TabloDuzenleAcKapaDurum = true;
            TabloDuzenleAcKapa();
        }


        private void TabloKayitlar_DGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Don't throw an exception when we're done.
            e.ThrowException = false;

            // Display an error message.
            string Mesaj = "Error with " +
                TabloKayitlar_DGV.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            OrtakSinif.HataBildir(Mesaj, new Exception());

            // If this is true, then the user is trapped in this cell.
            //e.Cancel = true kalırsa kullanıcı o hücreye kilitlenir uygulamadan çıkamaz.
            e.Cancel = false;
        }

        private void TabloKayitlar_DGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("burası çalıştı");
            this.TabloKayitlar_DGV.CurrentCell = this.TabloKayitlar_DGV[e.ColumnIndex, e.RowIndex];
            //Hücre düzenlenince mouse hareketiyle içinden çıkılmasını engelleyelim
        }
        private void TabloDuzenleAcKapa()
        {
            HataYeri = 0;
            try
            {
                TabloyuKaydet_Btn.Enabled = TabloDuzenleAcKapaDurum;
                TabloKaydetIptal_Btn.Enabled = TabloDuzenleAcKapaDurum;
                if(TabloDuzenleAcKapaDurum == true)
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
                    Haric.Add(TabloKayitlar_DGV);
                    Haric.Add(TabloGecerliSayfa_TBox);
                    Haric.Add(TabloToplamSayfa_TBox);


                    //MessageBox.Show(Haric.Count.ToString());
                    OrtakSinif.KontrolleriAcKapat_TabPage(TabloDuzenle_TPg, Haric, !TabloDuzenleAcKapaDurum);



            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f03_... TabloDuzenleAcKapa()",HataYeri, Istisna);
            }

            //TabloDuzenleAcKapaDurum = !TabloDuzenleAcKapaDurum;
        }


        private void TabloKayitlar_DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (TabloKriteriniKullaniciTetikledi == true)
            {
                TabloDuzenleAcKapaDurum = true;
                TabloDuzenleAcKapa();
            }
        }

        private void TabloKaydetIptal_Btn_Click(object sender, EventArgs e)
        {
            //TabloKriteriniKullaniciTetikledi = false;
            TabloyuYenile();
        }

        private void TabloKayitlar_DGV_Sorted(object sender, EventArgs e)
        {
            //TabloDuzenleAcKapaDurum = false;
            //TabloDuzenleAcKapa();
        }

        private void YeniVeriTabani_Btn_Click(object sender, EventArgs e)
        {
            f04_f03_VeriTabaniOlustur YeniForm = new f04_f03_VeriTabaniOlustur();
            YeniForm.BaglantiAdi = BaglantiAdi;
            YeniForm.DBHost = DBHost;
            YeniForm.DBUser = DBUser;
            YeniForm.DBPass = DBPass;
            YeniForm.ShowDialog();
            //this.Visible = false;
        }

        private void f03_MySQLYonet_Activated(object sender, EventArgs e)
        {
            if (OrtakSinif.FormActivateKilitli == false)
            {
                FormAcilinca(sender, e);
                OrtakSinif.FormActivateKilitli = true;
            }
        }
        
        private void VeriTabaniSil_Btn_Click(object sender, EventArgs e)
        {
            string VeriTabaniAdi = TabloDBName_Lbl.Text;
            string Soru="";
            try
            {
                if (VeriTabaniAdi != String.Empty)
                {
                    if (DilSec.aktifdil == "tr")
                    {
                        Soru = VeriTabaniAdi + " " + DilSec.VeriTabani.ToLower() + " " + DilSec.silinsinmi + "?";
                    }
                    else if (DilSec.aktifdil == "en")
                    {
                        Soru = DilSec.silinsinmi + " " + VeriTabaniAdi + " " + DilSec.VeriTabani.ToLower() + "?";
                    }
                    DialogResult Cevap = MessageBox.Show(Soru, "DROP DATABASE `" + VeriTabaniAdi + "`;", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Cevap.Equals(DialogResult.OK))
                    {
                        mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                        bool sonuc = mySQLYonet.VeriTabaniSil(VeriTabaniAdi);
                        
                        //Listeyi yenileyelim
                        if (sonuc == true)
                        {
                            // Bu formu tekrar yükleyelim
                            mySQLYonet.BaglantiKapat();
                            TabloDBName_Lbl.Text = "";
                            FormAcilinca(sender, e);
                            return;
                        }
                        mySQLYonet.BaglantiKapat();



                    }
                    else
                    {
                        //MessageBox.Show("İşlem iptal edildi");
                    }
                }

            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("VeriTabaniSil_Btn_Click()",HataYeri, Istisna);
            }
        }

        private void Islemler_TabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            HataYeri = 0;
            try
            {
                // ==1 tablo yapısı sekmesi
                if (Islemler_TabCtrl.SelectedIndex == 1 && Islemler_TabCtrl.TabPages[0].Text != "")
                {
                    string TabloAdi = Islemler_TabCtrl.TabPages[0].Text;
                    //MessageBox.Show("2. tab tıklandı");
                    BindingSource bs = new BindingSource();
                    DataTable dtyapi = new DataTable();
                    dtyapi = mySQLYonet.TabloYapisi(TabloAdi);
                    bs.DataSource = dtyapi;
                    TabloYapisi_DGV.DataSource = bs;

                }
            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("f03_*.Islemler_TabCtrl_SelectedIndexChanged()", HataYeri, Istisna);
            }

        }

        //Sağ tıklanan treeview node bulalım
        private void Sunucu_TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }

            TreeNode nodubul = Sunucu_TreeView.GetNodeAt(e.X, e.Y);
            if(nodubul == null) { return; }
            else
            {
                //sağ tıklananı seçelim
                Sunucu_TreeView.SelectedNode = nodubul;

                //Önceden Tag olarak tanımladıklarımıza göre sağ menü göstereceğiz
                string SagTiklananNode = nodubul.Tag.ToString();
                switch(SagTiklananNode)
                {
                    case "DataBase":
                        break;
                    case "Table":
                        mySQLYonet.AktifTabloAdi = nodubul.Text;
                        TabloTV_CxMS.Show(Sunucu_TreeView, new Point(e.X, e.Y));
                        
                        break;
                    case "Function":
                        break;
                    case "View":
                        break;
                    default:
                        mySQLYonet.AktifTabloAdi = null;
                        break;
                }
                //MessageBox.Show(nodubul.Tag.ToString());
            }

        }
        private void TabloKopyalamaFormuAc(object sender, EventArgs e)
        {
            f05_TabloKopyala YeniForm = new f05_TabloKopyala();
            YeniForm.BaglantiAdi = BaglantiAdi;
            YeniForm.DBHost = DBHost;
            YeniForm.DBUser = DBUser;
            YeniForm.DBPass = DBPass;
            YeniForm.DBName = DBName;
            YeniForm.KopyalanacakTabloAdi = mySQLYonet.AktifTabloAdi;
            YeniForm.ShowDialog();
        }

        private void TabloTVYokEt_TSMI_Click(object sender, EventArgs e)
        {
            string TabloAdi = mySQLYonet.AktifTabloAdi;
            bool Sonuc = false;
            if (TabloAdi.Length > 0)
            {
                string Soru = DilSec.Tablo + " " + TabloAdi + " " + DilSec.YokEdilecek.ToLower() + "?";
                string Baslik = TabloAdi + " " + DilSec.YokEdilecek;
                DialogResult dialogResult = OrtakSinif.DialogOkCancel(Soru, Baslik);
                if(dialogResult == DialogResult.OK)
                {
                    bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, DBName);
                    if (BaglantiDurumu == true)
                    {
                        Sonuc = mySQLYonet.TabloYokEt(TabloAdi);
                        mySQLYonet.BaglantiKapat();
                        if (Sonuc == true)
                        {
                            OrtakSinif.FormActivateKilitli = false;
                            FormAcilinca(sender, e);
                            OrtakSinif.FormActivateKilitli = true;
                            TabloDGVTemizle();
                        }
                        else
                        {
                            MessageBox.Show(DilSec.BASARISIZ,DilSec.BASARISIZ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show(DilSec.BaglantiSaglanamadi);
                    }
                        
                }
                //MessageBox.Show(dialogResult.ToString());
            }
            else
            {
                MessageBox.Show(DilSec.Tablo + " " + DilSec.Secin);
            }
        }

        private void IstekCalistir_Btn_Click(object sender, EventArgs e)
        {
            /*
            // string Istek = IstekYaz_RTBox.Text;

            HataYeri = 0;
            try
            {
                if(mySQLYonet.BaglantiAc(DBHost,DBUser,DBPass,DBName))
                {
                    // DataTable dt = mySQLYonet.IstekCalistir(Istek);
                    IstekTabloDT = new DataTable();
                    IstekTabloDT = dt;
                    //[ Güncellemede kullanmak üzere Table ve BindingSource saklayalım
                    IstekTabloBS = new BindingSource();
                    IstekTabloBS.DataSource = dt;
                    // Güncellemede kullanmak üzere Table ve BindingSource saklayalım ]
                 //   Istek_DGV.DataSource = IstekTabloBS;
                    mySQLYonet.BaglantiKapat();
                }
               // OrtakSinif.RTBox_Renklendir(RenklenecekKomutlar, IstekYaz_RTBox);
            }
            catch(Exception Istisna)
            {
                OrtakSinif.HataBildir(Istisna.ToString(), Istisna);
            }
            */
        }

        private void Btn_IstekTabloKaydet_Click(object sender, EventArgs e)
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
                mySQLYonet.IstekTablosunuGuncelle(dtdegisim);// dtdegisim);
                


                mySQLYonet.BaglantiKapat();
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 4:
                        //Hiçbirşey yapma çünkü değişiklik yapılmadı.
                        OrtakSinif.HataBildir(DilSec.HenuzDegistirilmedi, Istisna);
                        TabloDuzenleAcKapaDurum = false;
                        TabloDuzenleAcKapa();
                        break;

                    default:
                        OrtakSinif.ProgramHatasi("f03_MySQLYonet.Btn_IstekTabloKaydet_Click()", HataYeri, Istisna);
                        TabloyuYenile();
                        break;
                }
            }
        }

        private void f06_FormAc_Click(object sender, EventArgs e)
        {
            Form Yeniform = new f06_MySQLKomutCalistir();
            Yeniform.Show();
        }
    }//Form Sonu

    
    
}//namespace sonu
