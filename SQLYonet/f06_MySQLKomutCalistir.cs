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
        public string TabloListelenen;
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
            Btn_Genislet.BackColor = Color.Silver;
            dilSeciciKontrol1.button1.Click += FormTextleriDegistir;
            dilSeciciKontrol1.button2.Click += FormTextleriDegistir;
            RenklenecekKomutlar = mySQLYonet.IstekKomutlar();
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

        }
        private void Btn_Genislet_Click(object sender, EventArgs e)
        {
            if(Btn_Genislet.BackColor != Color.Silver)
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

        private void f06_MySQLKomutCalistir_Load(object sender, EventArgs e)
        {
            FormTextleriDegistir(sender, e);
        }
    }
}
