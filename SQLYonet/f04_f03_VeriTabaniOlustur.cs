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

namespace SQLYonet
{
    public partial class f04_f03_VeriTabaniOlustur : Form
    {
        //[Buradaki veriler f03_MySQLYonet.cs tarafından bu form açılırken dolduruluyor
        public string BaglantiAdi;
        public string DBHost;
        public string DBUser;
        public string DBPass;
        MySQLYonet mySQLYonet;
        //public string DBName; // yeni oluşturulacak
        //public string TabloListelenen; //gereksiz
        // ]
        byte HataYeri;
        string FormAdi;
        public f04_f03_VeriTabaniOlustur()
        {
            InitializeComponent();
        }

        private void f04_f03_VeriTabaniOlustur_Load(object sender, EventArgs e)
        {
            HataYeri = 0;
            //string ComboBoxText;
            try
            {
                HataYeri = 1;
                FormTextleriDegistir(sender, e);
                SunucuAdi_Lbl.Text = BaglantiAdi;
                HataYeri = 2;
                mySQLYonet = new MySQLYonet();
                bool BaglantiDurumu = mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                KarakterSetleri_LV.FullRowSelect = true;
                KarakterSetleri_LV.MultiSelect = false;
                KarakterSetleri_LV.View = View.Details;
                KarakterSetleri_LV.Columns.Add("COLLATION", 140, HorizontalAlignment.Left);
                KarakterSetleri_LV.Columns.Add("CHARSET", 80, HorizontalAlignment.Left);

                if (BaglantiDurumu == true)
                {
                    HataYeri = 3;
                    List<string[]> KarakterSetleriListesi = mySQLYonet.KarakterSetleriInfo();
                    foreach(string[] alan in KarakterSetleriListesi)
                    {
                        ListViewItem listViewItem = new ListViewItem(alan);
                        listViewItem.SubItems.Add(alan[0]);
                        listViewItem.SubItems.Add(alan[1]);
                        KarakterSetleri_LV.Items.Add(listViewItem);
                    }
             
                    
                    
                    

                }
                else
                {
                    //TekrarBaglan_Btn.Enabled = true;
                    SunucuAdi_PBox.Image = Properties.Resources.db_sil24px;
                }
                mySQLYonet.BaglantiKapat();
            }
            catch(Exception Istisna)
            {

                OrtakSinif.ProgramHatasi("f04_f03_VeriTabaniOlustur_Load", HataYeri, Istisna);
                
            }
            
        }
        public void FormTextleriDegistir(object sender, EventArgs e)
        {
            if (DilSec.aktifdil == null)
            {
                DilSec.tr();
            }

            if (DilSec.aktifdil == "tr")
            {
                FormAdi = DilSec.VeriTabani + " " + DilSec.Olustur + " -" + DilSec.ProgramBaslik;
            }
            else if (DilSec.aktifdil == "en")
            {
                FormAdi = DilSec.Olustur + " " + DilSec.VeriTabani+ " -" + DilSec.ProgramBaslik;
            }

            this.Text = FormAdi;
            VeriTabaniniOlustur_Btn.Text = DilSec.Olustur;
            VeriTabaniAdi_Lbl.Text = DilSec.VeriTabani + " " + DilSec.Adi.ToLower();
            KarakterKarsilastirma_Lbl.Text = DilSec.KarakterKarsilastirma;
            Iptal_Btn.Text = DilSec.iptal;

        }
        private void KarakterSetleriniComboboxaDoldur()
        {
            /* 2019-03-21 
             * Bu kod çalışıyor ancak listview içinde hem charset'i hem collation'u göstermek daha mantıklı
                    List<string[]> KarakterSetleriListesi = mySQLYonet.KarakterSetleriInfo();

                    //TekrarBaglan_Btn.Enabled = false;
                    //VeriTabanlariniListele();
                    
                    KarakterSetleri_CBox.DisplayMember = "COLLATION_NAME_UMUT"; 
                    KarakterSetleri_CBox.ValueMember = "CHARACTER_SET_NAME_SURMELI";
                    foreach (string[] BirKarakterSeti in KarakterSetleriListesi)
                    {
                        ComboBoxText = BirKarakterSeti[0] + " " + BirKarakterSeti[1];
                        KarakterSetleri_CBox.Items.Add(new { COLLATION_NAME_UMUT = ComboBoxText, CHARACTER_SET_NAME_SURMELI = BirKarakterSeti[1]});
                    }



            */
        }


        private void KarakterSetleri_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KarakterSetleri_LV.SelectedItems.Count > 0)
            {
                //MessageBox.Show(KarakterSetleri_LV.SelectedItems[0].SubItems[0].ToString());
            }
        }

        private void VeriTabaniniOlustur_Btn_Click(object sender, EventArgs e)
        {
            HataYeri = 0;
            string KontrolMesaji="";
            try
            {
                HataYeri = 1;
                if (KarakterSetleri_LV.SelectedItems.Count > 0)
                {
                    if(YeniVeriTabaniAdi_TBox.Text.Length > 0)
                    {
                        HataYeri = 2;
                        mySQLYonet.BaglantiAc(DBHost, DBUser, DBPass, "");
                        HataYeri = 3;
                        string Charset = KarakterSetleri_LV.SelectedItems[0].SubItems[1].Text;
                        string Collation = KarakterSetleri_LV.SelectedItems[0].SubItems[0].Text;
                        HataYeri = 4;
                        int sonuc=mySQLYonet.VeriTabaniOlustur(YeniVeriTabaniAdi_TBox.Text, Charset, Collation);
                        if(sonuc > 0)
                        {
                            mySQLYonet.BaglantiKapat();
                            // dialog kapanınca bunu açan diğer formda FormActivate eventı bir seferliğine mahsus tetiklenecek.
                            OrtakSinif.FormActivateKilitli = false; 
                            this.Close();
                            
                            
                        }
                        HataYeri = 5;
                        mySQLYonet.BaglantiKapat();
                    }
                    else
                    {
                        if (DilSec.aktifdil == "tr")
                        {
                            KontrolMesaji = DilSec.Lutfen + " " + DilSec.VeriTabani.ToLower() + " " + DilSec.Adi.ToLower();
                            KontrolMesaji += " "+ DilSec.YaziYaz.ToLower();
                        }
                        else if(DilSec.aktifdil == "en")
                        {
                            KontrolMesaji = DilSec.Lutfen + " " + DilSec.YaziYaz.ToLower() + " " + DilSec.VeriTabani.ToLower();
                            KontrolMesaji += " " + DilSec.Adi.ToLower();
                        }
                        MessageBox.Show(KontrolMesaji);
                        YeniVeriTabaniAdi_TBox.Focus();
                        return;
                    }
                }
                else
                {
                    if(DilSec.aktifdil == "en")
                    {
                        KontrolMesaji = DilSec.Lutfen + " " + DilSec.Secin.ToLower();
                        KontrolMesaji += " " + DilSec.Bir.ToLower() + " " + DilSec.DilKarsilastirmasi.ToLower();
                    }
                    else if(DilSec.aktifdil == "tr")
                    {
                        KontrolMesaji = DilSec.Lutfen + " " + DilSec.Bir.ToLower();
                        KontrolMesaji += " " + DilSec.DilKarsilastirmasi.ToLower() + " " + DilSec.Secin.ToLower();
                    }
                    MessageBox.Show(KontrolMesaji);
                    return;
                }

            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("VeriTabaniniOlustur_Btn_Click()", HataYeri, Istisna);
            }

        }

        private void Iptal_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
