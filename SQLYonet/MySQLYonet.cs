using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gereksinimler
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SQLYonet
{
    public class MySQLYonet
    {
        public string DBHost;
        public string DBUser;
        public string DBPass;
        public string DBName;
        public string Provider;
        public int AktifTabloToplamKayitSayisi;
        public string AktifTabloAdi;
        public string SonSorgu; // TabloGoster'de girilen sorgu
        public string SonIstek; //Manuel girilen sorgu
        byte HataYeri;
        
        MySqlConnection baglan;
        MySqlDataAdapter da;
        MySqlCommandBuilder cb;
        MySqlCommand command;
        MySqlDataReader dr;





        public bool BaglantiAc(string DBHostI, string DBUserI, string DBPassI, string DBNameI)
        {
            HataYeri = 0;
            try
            {
                DBHost = DBHostI;
                DBUser = DBUserI;
                DBPass = DBPassI;
                DBName = DBNameI;

                HataYeri = 1;

                Provider = "Server=" + DBHost + ";";
                //Provider += "Port=3306;";
                Provider += (DBName.Length == 0 ? "Database=;" : "Database=" + DBName + ";");
                Provider += "Uid=" + DBUser + ";Pwd='" + DBPass + "';CharSet=utf8;convert zero datetime=true;";

                //Provider = "Server=localhost;Database=test;Uid=umut;Pwd=123456";
                HataYeri = 2;
                baglan = new MySqlConnection(Provider);

                HataYeri = 3;

                baglan.Open();

                return true;

            }
            catch (MySqlException Istisna)
            {

                switch (HataYeri)
                {
                    case 2:
                        OrtakSinif.ProgramHatasi("MySQLYonet.BaglantiAc() provider değişecek" + Istisna.ToString(), HataYeri, Istisna);
                        break;
                    case 3:
                        OrtakSinif.ProgramHatasi("MySQLYonet.BaglantiAc() (" + Istisna.Number.ToString() + ") ", HataYeri, Istisna);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.BaglantiAc()", HataYeri, Istisna);
                        break;
                }
                /*
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                string s = "MySqlException: " + Istisna.ToString();
                // MessageBox.Show(s, "Error", buttons);
                OrtakSinif.ProgramHatasi(s, HataYeri, Istisna);
                */
                return false;
            }
        }
        public void BaglantiKapat()
        {
            HataYeri = 0;
            try
            {
                baglan.Close();
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.BaglantiKapat()", HataYeri, Istisna);
            }
        }
        public List<string> VeriTabanlari()
        {
            HataYeri = 0;
            List<string> VTListe = new List<string>();
            try
            {

                HataYeri = 1;
                string sorgu = "SHOW DATABASES;";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    //int i = 0;
                    while (dr.Read())
                    {
                        VTListe.Add(dr.GetString(0));

                    }
                }
                dr.Close();
                return VTListe;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.VeriTabanlari()", HataYeri, Istisna);
                return VTListe;
            }
        }
        public void VeriTabaniSec(string VeriTabaniAdi)
        {
            HataYeri = 0;
            try
            {
                DBName = VeriTabaniAdi;
                string sorgu = "USE " + DBName + ";";
                command = new MySqlCommand(sorgu, baglan);
                command.ExecuteNonQuery();
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.VeriTabaniSec()", HataYeri, Istisna);
            }
        }
        public List<string> Tablolar()
        {
            HataYeri = 0;
            List<string> TablolarListe = new List<string>();
            try
            {

                HataYeri = 1;
                //string sorgu = "SHOW TABLES;";
                string sorgu = "SHOW FULL TABLES WHERE Table_Type != 'VIEW';";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    //int i = 0;
                    while (dr.Read())
                    {
                        TablolarListe.Add(dr.GetString(0));

                    }
                }
                dr.Close();
                return TablolarListe;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.Tablolar()", HataYeri, Istisna);
                return TablolarListe;
            }
        }
        public List<string> Viewler()
        {
            HataYeri = 0;
            List<string> ViewlerListe = new List<string>();
            try
            {

                HataYeri = 1;
                //string sorgu = "SHOW TABLES;";
                string sorgu = "SHOW FULL TABLES WHERE Table_Type = 'VIEW';";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    //int i = 0;
                    while (dr.Read())
                    {
                        ViewlerListe.Add(dr.GetString(0));

                    }
                }
                dr.Close();
                return ViewlerListe;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.Viewler()", HataYeri, Istisna);
                return ViewlerListe;
            }
        }
        public List<string> Fonksiyonlar()
        {
            HataYeri = 0;
            List<string> FonksiyonlarListe = new List<string>();
            try
            {

                HataYeri = 1;
                string sorgu = "SHOW FUNCTION STATUS WHERE `DB`='" + DBName + "';";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    //int i = 0;
                    while (dr.Read())
                    {
                        //1 Burda Name alanını verir. 
                        //Daha sonra tüm Fieldleri almak için gerekli işlemleri yapacağız.
                        FonksiyonlarListe.Add(dr.GetString(1));

                    }
                }
                dr.Close();
                return FonksiyonlarListe;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.Fonksiyonlar()", HataYeri, Istisna);
                return FonksiyonlarListe;
            }
        }
        //TabloOku (bütün tabloyu gösterdiği için yerine TabloListele kullanılarak iptal edilecek.)
        public DataTable TabloOku(string TabloAdi)
        {
            HataYeri = 0;
            DataTable Tablo = new DataTable();
            try
            {
                //datetime hatası yüzünden kolonları tek tek isteyelim
                //string[] AlanIsimleri = TabloKolonlar(TabloAdi, 0);
                string sorgu = "SELECT * FROM " + TabloAdi + ";";

                HataYeri = 1;

                da = new MySqlDataAdapter(sorgu, baglan);
                Tablo.Clear();
                da.Fill(Tablo);

                return Tablo;
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloOku()", HataYeri, Istisna);

                        break;
                }
                return Tablo;
            }
        }
        public bool TabloYokEt(string TabloAdi)
        {
            HataYeri = 0;
            try
            {
                HataYeri = 1;
                string sorgu = "DROP TABLE "+TabloAdi+ ";";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.VeriTabaniSec()", HataYeri, Istisna);
                return false;
            }
        }

        //2019-02-27 şimdilik kullanılmıyor. Bkz. f03_MySQLYonet.cs TabloKolonlarComboBox()
        //2019-03-17 artık kullanıyoruz.
        public string[] TabloKolonlar(string TabloAdi, int ColIndex)
        {
            //ColIndex = 0 Alan isimlerini verir
            HataYeri = 0;

            try
            {
                string sorgu = "DESCRIBE " + TabloAdi + ";";
                da = new MySqlDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                da.Fill(ds);
                HataYeri = 1;
                int KolonSayisi = ds.Tables[0].Rows.Count;
                string[] Kolonlar = new string[KolonSayisi];
                //return Kolonlar;
                for (int i = 0; i < KolonSayisi; i++)
                {
                    Kolonlar[i] = ds.Tables[0].Rows[i][ColIndex].ToString();

                }
                return Kolonlar;


            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloKolonlar()", HataYeri, Istisna);
                        break;
                }
                string[] Kolonlar = new string[0];
                return Kolonlar;
            }
        }
        public DataTable TabloYapisi(string TabloAdi)
        {
            HataYeri = 0;
            DataTable TabloYapisiDT = new DataTable();
            try
            {
                string sorgu = "DESCRIBE " + TabloAdi + ";";
                MySqlDataAdapter TabloYapisiDA = new MySqlDataAdapter(sorgu, baglan);

                TabloYapisiDA.Fill(TabloYapisiDT);
                HataYeri = 1;

                return TabloYapisiDT;


            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloYapisi()", HataYeri, Istisna);
                        break;
                }

                return TabloYapisiDT;
            }
        }
        public List<string[]> TabloInfoList(string TabloAdi)
        {
            //ColIndex = 0 Alan isimlerini verir
            HataYeri = 0;

            try
            {
                string sorgu = "DESCRIBE " + TabloAdi + ";";
                da = new MySqlDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                da.Fill(ds);
                HataYeri = 1;
                int KolonSayisi = ds.Tables[0].Rows.Count;
                List<string[]> TabloBilgisi = new List < string[] > ();
                HataYeri = 2;
                //string[] Kolonlar = new string[KolonSayisi];
                //return Kolonlar;
                //List<String> Kolonlar = new List<string>();
                //List<string> listemsatir = new List<string>();
                //List<List<string>> matrix = new List<List<string>>();
                HataYeri = 3;
                //OrtakSinif.HataBildir(KolonSayisi.ToString(), new Exception());
                for (int i = 0; i < KolonSayisi; i++)
                {
                    HataYeri++;
                    //string[] KolonInfo = new string[6];
                    string[] kolonbilgisi = new string[6];
                    for (int j = 0; j < 6; j++)
                    {
                        
                        kolonbilgisi[j]=ds.Tables[0].Rows[i][j].ToString();
                        //OrtakSinif.HataBildir(kolonbilgisi[j].ToString(), new Exception());

                    }
                    TabloBilgisi.Add(kolonbilgisi);

                }
                return TabloBilgisi;


            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloInfo()", HataYeri, Istisna);
                        break;
                }
                List<string[]> TabloBilgisi = new List<string[]>();
                return TabloBilgisi;
            }
        }
        public int TabloKayitSayisi(string TabloAdi)
        {
            HataYeri = 33;
            try
            {
                string sorgu = "SELECT COUNT(*) AS KayitSayisi FROM " + TabloAdi;
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 34;
                //dr = command.ExecuteReader();

                HataYeri = 35;
                //dr.Read();
                int KayitSayisi = Convert.ToInt32(command.ExecuteScalar());
                //AktifTabloToplamKayitSayisi = Convert.ToInt32(KayitSayisi);
                AktifTabloToplamKayitSayisi = KayitSayisi;
                //dr.Close();
                return KayitSayisi;

            }
            catch (Exception Istisna)
            {
                hicbirsey(Istisna);
                switch (HataYeri)
                {

                    default:
                        int KayitSayisi = -1;

                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloKayitSayisi()", HataYeri, Istisna);
                        return KayitSayisi;
                        //break;
                }
                
                
                
            }
        }
        public int VeriTabaniOlustur(string VeriTabaniAdi,string CharSet,string Collation)
        {
            int sonuc = 0;
            HataYeri = 0;
            try
            {
                string sorgu = "CREATE DATABASE " + VeriTabaniAdi;
                sorgu += " CHARACTER SET " + CharSet;
                sorgu += " COLLATE " + Collation;
                HataYeri = 1;
                command = new MySqlCommand(sorgu,baglan);
                HataYeri = 2;
                sonuc=command.ExecuteNonQuery();
                return sonuc; // 1 olumlu
                //OrtakSinif.HataBildir(sonuc.ToString(),new Exception());

            }
            catch(MySqlException MySqlIstisna)
            {
                string mesaj = "MySQLYonet.VeriTabaniOlustur() HataYeri:" + HataYeri.ToString();
                mesaj += "\r\n MySQLNum:" + MySqlIstisna.Number.ToString();
                //mesaj += "\r\n"+MySqlIstisna.Message;//  Zaten ekleniyor.
                OrtakSinif.HataBildir(mesaj, MySqlIstisna);
                return sonuc;
            }
            catch(Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.VeriTabaniOlustur()", HataYeri, Istisna);
                return sonuc;
            }
        }

        public bool VeriTabaniSil(string VeriTabaniAdi)
        {
            bool sonuc = false;
            HataYeri = 0;
            try
            {
                string sorgu = "DROP DATABASE `" + VeriTabaniAdi+"`;";
                HataYeri = 1;
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                command.ExecuteNonQuery();
                sonuc = true;
                return sonuc; 

            }
            catch (MySqlException MySqlIstisna)
            {
                string mesaj = "MySQLYonet.VeriTabaniSil() HataYeri:" + HataYeri.ToString();
                mesaj += "\r\n MySQLNum:" + MySqlIstisna.Number.ToString();
                //mesaj += "\r\n"+MySqlIstisna.Message;//  Zaten ekleniyor.
                OrtakSinif.HataBildir(mesaj, MySqlIstisna);
                return sonuc;
            }
            catch (Exception Istisna)
            {
                OrtakSinif.ProgramHatasi("MySQLYonet.VeriTabaniSil()", HataYeri, Istisna);
                return sonuc;
            }
        }
        public DataTable TabloListele(string TabloAdi,string SayfaNo,string Kacarli, string Egore, bool Artan)
        {

            HataYeri = 0;
            string sorgu="";
            DataTable Tablo = new DataTable();
            try
            {

                HataYeri = 1;
                // Sorgumuzu sayfa sayfa çağıracak şekilde ayarlayalım
                int ToplamKayitSayisi = TabloKayitSayisi(TabloAdi);
                int SayfaIndex = Convert.ToInt32(SayfaNo) - 1;
                int LimitBaslangic = SayfaIndex * Convert.ToInt32(Kacarli);
                List<string[]> TabloInfos =  TabloInfoList(TabloAdi);
                string sorguparcasi = "";
                int alanadino = 0;
                string asType;
                
                //var enumerator = TabloInfos.GetEnumerator();
                //TabloInfos.ForEach()
                foreach(string[] satir in TabloInfos)//(int i = 0; i < TabloInfos.Length; i++) ;
                {
                    //OrtakSinif.HataBildir(satir[0], new Exception());
                    //tring[] satir = TabloInfos[i,];
                    switch (satir[1])
                    {
                        case "date":
                            asType = " as char(10)";
                            if (alanadino == 0) { sorguparcasi += "cast(`" + satir[0]+"`" + asType + ") as `" + satir[0] + "`"; }
                            else { sorguparcasi += ",cast(`" + satir[0] + "`" + asType + ") as `" + satir[0] + "`"; }
                            break;
                        case "datetime":
                            asType = " as char(19)";
                            if (alanadino == 0) { sorguparcasi += "cast(`" + satir[0] + "`" + asType + ") as `" + satir[0] + "`"; }
                            else { sorguparcasi += ",cast(`" + satir[0] + "`" + asType + ") as `" + satir[0] + "`"; }
                            break;
                        case "timestamp":
                            asType = " as char(19)";
                            if (alanadino == 0) { sorguparcasi += "cast(`" + satir[0] + "`" + asType + ") as `" + satir[0] + "`"; }
                            else { sorguparcasi += ",cast(`" + satir[0] + "`" + asType + ") as `" + satir[0] + "`"; }
                            break;
                        default:
                            if (alanadino == 0) { sorguparcasi += "`" + satir[0]+"`"; }
                            else { sorguparcasi += ",`" + satir[0]+"`"; }
                            break;
                    }
                    alanadino++;
                }

                sorgu = "SELECT "+sorguparcasi+"  FROM " + TabloAdi;
                string HamSorgu = "SELECT *  FROM " + TabloAdi;
                if (Egore.Length > 0)
                {
                    sorgu += " ORDER BY " + Egore;
                    HamSorgu += " ORDER BY " + Egore;
                    sorgu += (Artan == true) ? " ASC" : " DESC";
                    HamSorgu += (Artan == true) ? " ASC" : " DESC";

                }
                sorgu += " LIMIT " + LimitBaslangic.ToString() + "," + Kacarli;
                HamSorgu += " LIMIT " + LimitBaslangic.ToString() + "," + Kacarli;
                da = new MySqlDataAdapter(sorgu,baglan);
                command = new MySqlCommand(sorgu);
                Tablo.Clear();
                SonSorgu = HamSorgu;

                da.Fill(Tablo);

                return Tablo;
            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloListele() "+sorgu, HataYeri, Istisna);

                        break;
                }
                return Tablo;
            }
        }
        public DataTable IstekCalistir(string Istek)
        {
            HataYeri = 0;
            DataTable Tablo = new DataTable();
            try
            {

                string sorgu = Istek;
                SonIstek = sorgu;
                da = new MySqlDataAdapter(sorgu, baglan);
                command = new MySqlCommand(sorgu);
                Tablo.Clear();
                da.Fill(Tablo);
                return Tablo;
            }
            catch (MySqlException Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.IstekCalistir() (" + Istisna.Number.ToString() + ")", HataYeri, Istisna);
                        break;
                }
                return Tablo;
            }
        }
        public void TabloGuncelle(DataTable dtdegisim)
        {
            HataYeri = 0;
            try
            {

                HataYeri = 1;
                da = new MySqlDataAdapter();
                
                HataYeri = 2;
                // [[ Select Command ve tabloda Key yok ise update çalışmıyor
                command = new MySqlCommand(SonSorgu,baglan);
                HataYeri = 24;
                da.SelectCommand = command;

                
                // Select Command ve tabloda Key yok ise update çalışmıyor ]]
                HataYeri = 26;
                cb = new MySqlCommandBuilder(da);
                HataYeri = 29;
                
                da.UpdateCommand = cb.GetUpdateCommand();
                
                //OrtakSinif.HataBildir(da.UpdateCommand.CommandText, new Exception());
                HataYeri = 3;
                da.InsertCommand = cb.GetInsertCommand();
                HataYeri = 4;
                da.DeleteCommand = cb.GetDeleteCommand();
                HataYeri = 5;
                

                //Tıklayıp içini değiştirmediklerinde hata oluşmasını engelleyelim
                if (dtdegisim.Rows.Count > 0)
                {
                    
                    da.Update(dtdegisim);
                }




            }
            catch (MySqlException Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloGuncelle() ("+Istisna.Number.ToString()+")", HataYeri, Istisna);
                        break;
                }
            }
        }

        public void IstekTablosunuGuncelle(DataTable dtdegisim)
        {
            HataYeri = 0;
            try
            {

                HataYeri = 1;
                da = new MySqlDataAdapter();

                HataYeri = 2;
                // [[ Select Command ve tabloda Key yok ise update çalışmıyor
                command = new MySqlCommand(SonIstek, baglan);
                HataYeri = 24;
                da.SelectCommand = command;


                // Select Command ve tabloda Key yok ise update çalışmıyor ]]
                HataYeri = 26;
                cb = new MySqlCommandBuilder(da);
                HataYeri = 29;

                da.UpdateCommand = cb.GetUpdateCommand();

                //OrtakSinif.HataBildir(da.UpdateCommand.CommandText, new Exception());
                HataYeri = 3;
                da.InsertCommand = cb.GetInsertCommand();
                HataYeri = 4;
                da.DeleteCommand = cb.GetDeleteCommand();
                HataYeri = 5;


                //Tıklayıp içini değiştirmediklerinde hata oluşmasını engelleyelim
                if (dtdegisim.Rows.Count > 0)
                {

                    da.Update(dtdegisim);
                }




            }
            catch (MySqlException Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.IstekTablosunuGuncelle() (" + Istisna.Number.ToString() + ")", HataYeri, Istisna);
                        break;
                }
            }
        }
        public List<string[]> KarakterSetleriInfo()
        {

            HataYeri = 0;
            List<string[]> CollationCharset = new List<string[]>();
            try
            {
                HataYeri = 1;
                string sorgu = "SELECT `COLLATION_NAME`,`CHARACTER_SET_NAME` FROM information_schema.COLLATIONS;";
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    HataYeri = 3;
                    //int i = 0;
                    while (dr.Read())
                    {
                        string[] satir = new string[2];
                        satir[0] = dr.GetString(0);
                        satir[1] = dr.GetString(1);
                        CollationCharset.Add(satir);

                    }
                    HataYeri = 4;
                }
                dr.Close();
               
                return CollationCharset;
            }
            catch (Exception Istisna)
            {

                switch (HataYeri)
                {
                    case 3:
                        OrtakSinif.ProgramHatasi("MySQLYonet.KarakterSetleriInfo()", HataYeri, Istisna);
                        dr.Close();
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.KarakterSetleriInfo()", HataYeri, Istisna);
                        break;
                }
                return CollationCharset;
            }
        }
        public bool TabloYapisiniKopyala(string TabloKopyalanacakAdi, string TabloYeniKopyaAdi)
        {
            bool Sonuc = false;
            string sorgu = "";
            string mesaj = "";
            HataYeri = 0;
            try
            {
                sorgu = "CREATE TABLE `" + TabloYeniKopyaAdi + "` LIKE `" + TabloKopyalanacakAdi + "`;";
                HataYeri = 10;
                command = new MySqlCommand(sorgu, baglan);
                command.ExecuteNonQuery();
                Sonuc = true;
                return Sonuc;
            }
            catch(MySqlException MySqlIstisna)
            {
                switch (HataYeri)
                {
                    case 10:
                        //Hiçbir işlem yapılmadı
                        mesaj = "MySQLYonet.TabloKopyala() \r\n MySQLNum(" + MySqlIstisna.Number.ToString() + ")";
                        OrtakSinif.ProgramHatasi(mesaj, HataYeri, MySqlIstisna);
                        break;
                    default:
                        mesaj = "MySQLYonet.TabloKopyala() \r\n MySQLNum(" + MySqlIstisna.Number.ToString() + ")";
                        OrtakSinif.ProgramHatasi(mesaj, HataYeri, MySqlIstisna);
                        break;
                }
                return Sonuc;
            }
            catch(Exception Istisna)
            {
                switch (HataYeri)
                {
                    case 10:
                        //Hiçbir işlem yapılmadı
                        mesaj = "MySQLYonet.TabloKopyala()";
                        OrtakSinif.ProgramHatasi(mesaj, HataYeri, Istisna);
                        break;
                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.TabloKopyala()", HataYeri, Istisna);
                        break;
                }
                return Sonuc;
            }
        }
        public int TabloVerisiniKopyala(string TabloKopyalanacakAdi, string TabloYeniKopyaAdi)
        {
            //Bu fonksiyonu kullanabilmek için TabloYeniKopyaAdi birebir aynı şekilde oluşturulmuş olmalı.
            // Yani önce TabloYapisiniKopyala metodunu kullanmalıyız.
            int KayitAdedi = 0;
            string sorgu = "";
            string mesaj = "";
            HataYeri = 0;
            try
            {
                sorgu = "INSERT INTO " + TabloYeniKopyaAdi;
                sorgu += Environment.NewLine+"SELECT * FROM "+ TabloKopyalanacakAdi + " WHERE 1=1;";
                HataYeri = 1;
                
                command = new MySqlCommand(sorgu, baglan);
                HataYeri = 2;
                KayitAdedi = command.ExecuteNonQuery();
               
                HataYeri = 3;

                return KayitAdedi;
            }
            catch(MySqlException Istisna)
            {
                mesaj = "MySQLYonet.TabloVerisiniKopyala() (" + Istisna.Number.ToString() + ")";
                OrtakSinif.ProgramHatasi(mesaj, HataYeri, Istisna);
                return KayitAdedi;
            }
            catch(Exception Istisna)
            {
                mesaj = "MySQLYonet.TabloVerisiniKopyala() ";
                OrtakSinif.ProgramHatasi(mesaj, HataYeri, Istisna);
                return KayitAdedi;
            }

        }
        public String[] IstekKomutlar()
        {
            string[] dizi = new string[39];
            dizi[0] = " and ";
            dizi[1] = " by ";
            dizi[2] = " in ";
            dizi[3] = " or ";
            dizi[4] = " set ";
            dizi[5] = "add";
            dizi[6] = "after ";
            dizi[7] = "alter";
            dizi[8] = "before ";
            dizi[9] = "change";
            dizi[10] = "column";
            dizi[11] = "create";
            dizi[12] = "database";
            dizi[13] = "date ";
            dizi[14] = "datetime ";
            dizi[15] = "delete";
            dizi[16] = "drop";
            dizi[17] = "foreign";
            dizi[18] = "from";
            dizi[19] = "function";
            dizi[20] = "insert";
            dizi[21] = "into";
            dizi[22] = "key";
            dizi[23] = "limit";
            dizi[24] = "modifiy";
            dizi[25] = "not ";
            dizi[26] = "null ";
            dizi[27] = "order";
            dizi[28] = "primary";
            dizi[29] = "procedure";
            dizi[30] = "select";
            dizi[31] = "table";
            dizi[32] = "timestamp ";
            dizi[33] = "unique";
            dizi[34] = "update";
            dizi[35] = "values";
            dizi[36] = "version";
            dizi[37] = "view";
            dizi[38] = "where";


            return dizi;
        }
        
        
        public void deneme()
        {
            HataYeri = 0;
            try
            {




            }
            catch (Exception Istisna)
            {
                switch (HataYeri)
                {

                    default:
                        OrtakSinif.ProgramHatasi("MySQLYonet.deneme()", HataYeri, Istisna);
                        break;
                }
            }
        }
        public void hicbirsey(object hicbirsey)
        {
            //Bu metod kullanılmayan değişkenlerin hata listesinde görünmesini engellemek için kullanılacak

        }

    }
}
