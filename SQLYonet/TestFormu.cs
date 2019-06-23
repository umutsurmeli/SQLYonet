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
    public partial class TestFormu : Form
    {
        public TestFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sifrelendi = OrtakSinif.Sifrele(textBox1.Text);
            textBox2.Text = Sifrelendi;
            OrtakSinif.ButtonAktif(this, button1,true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifresiz = OrtakSinif.SifreCoz(textBox2.Text);
            textBox3.Text = sifresiz;
            OrtakSinif.ButtonAktif(this, button2,true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = OrtakSinif.Base64Decode(textBox2.Text);
                OrtakSinif.ButtonAktif(this, button3,true);
            }
            catch(Exception Hata)
            {
                MessageBox.Show("Base64Decode çalışmadı çünkü base64encoding sonucunu bilinçli olarak değiştirdik.\r\n" + Hata.Message);
            }
        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            RegistryKey Kullanicilar = Registry.CurrentUser.OpenSubKey(KayitDefteri.KlasorAna).OpenSubKey(KayitDefteri.KlasorKullanicilar);
            KayitDefteri.GetSubKeyNamesToListBox(Kullanicilar, listBox1);
            /*
            using (Kullanicilar)
            {
                foreach (var SubKeyAdi in Kullanicilar.GetSubKeyNames())
                {
                    listBox1.Items.Add(SubKeyAdi.ToString());
                }
                
            }
            */
        }

        private void TestFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(OrtakSinif.GizliFormuAc("f01_GirisEkrani")==0)
            {
                Form YeniForm = new f01_GirisEkrani();
                YeniForm.Show();
            }
        }

        private void Btn_RenkliKomutlar_Click(object sender, EventArgs e)
        {
            MySQLYonet mySQLYonet = new MySQLYonet();
            string[] komutlar = mySQLYonet.IstekKomutlar();
            Array.Sort(komutlar);
            int i = 0;
            RTBox_Komutlar.Text = "";
            foreach (string komut in komutlar)
            {
                RTBox_Komutlar.Text += "dizi[" + i.ToString() + "] = \"" + komut + "\";\r\n";
                i++;

            }
            foreach (string komut in komutlar)
            {
                //[ renklendir
                if (RTBox_Komutlar.Text.Contains(komut))
                {
                    int index = -1;
                    int selectStart = RTBox_Komutlar.SelectionStart;

                    while ((index = RTBox_Komutlar.Text.IndexOf(komut, (index + 1))) != -1
                        || (index = RTBox_Komutlar.Text.IndexOf(komut.ToUpper(), (index + 1))) != -1
                        )
                    {
                        this.RTBox_Komutlar.Select((index + 0), komut.Length);
                        this.RTBox_Komutlar.SelectionColor = Color.Aqua;
                        //this.RTBox_Komutlar.Select(selectStart, 0);
                        this.RTBox_Komutlar.SelectionColor = Color.Blue;
                    }
                }
                // renklendir ]
            }
            OrtakSinif.RTBox_Renklendir(komutlar, richTextBox1);
        }


    }
}
