namespace SQLYonet
{
    partial class f03_MySQLYonet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f03_MySQLYonet));
            this.Sunucu_TreeView = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Islemler_TabCtrl = new System.Windows.Forms.TabControl();
            this.TabloDuzenle_TPg = new System.Windows.Forms.TabPage();
            this.TabloKaydetIptal_Btn = new System.Windows.Forms.Button();
            this.TabloyuKaydet_Btn = new System.Windows.Forms.Button();
            this.TabloKayitSayisiAciklama_Lbl = new System.Windows.Forms.Label();
            this.TabloKayitSayisi_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabloToplamSayfa_TBox = new System.Windows.Forms.TextBox();
            this.TabloGecerliSayfa_TBox = new System.Windows.Forms.TextBox();
            this.TabloListeIleri_Btn = new System.Windows.Forms.Button();
            this.TabloListeGeri_Btn = new System.Windows.Forms.Button();
            this.Sirala_Btn = new System.Windows.Forms.Button();
            this.Kacarli_Lbl = new System.Windows.Forms.Label();
            this.Kacarli_CBox = new System.Windows.Forms.ComboBox();
            this.Artan_Chck = new System.Windows.Forms.CheckBox();
            this.Artan_Lbl = new System.Windows.Forms.Label();
            this.KolonaGore_Lbl = new System.Windows.Forms.Label();
            this.TabloKolonlar_CBox = new System.Windows.Forms.ComboBox();
            this.TabloKayitlar_DGV = new System.Windows.Forms.DataGridView();
            this.TabloDBName_Lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabloYapisi_DGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IstekYaz_RTBox = new System.Windows.Forms.RichTextBox();
            this.IstekCalistir_Btn = new System.Windows.Forms.Button();
            this.Istek_DGV = new System.Windows.Forms.DataGridView();
            this.SunucuAdi_Lbl = new System.Windows.Forms.Label();
            this.TekrarBaglan_Btn = new System.Windows.Forms.Button();
            this.Sunucular_Btn = new System.Windows.Forms.Button();
            this.SunucuAdi_PBox = new System.Windows.Forms.PictureBox();
            this.YeniVeriTabani_Btn = new System.Windows.Forms.Button();
            this.VeriTabaniSil_Btn = new System.Windows.Forms.Button();
            this.TabloTV_CxMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabloTVKopyala_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TabloTVYokEt_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TabloTVBosalt_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_IstekTabloKaydet = new System.Windows.Forms.Button();
            this.dilSeciciKontrol1 = new SQLYonet.DilSeciciKontrol();
            this.Islemler_TabCtrl.SuspendLayout();
            this.TabloDuzenle_TPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabloKayitlar_DGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabloYapisi_DGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Istek_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).BeginInit();
            this.TabloTV_CxMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sunucu_TreeView
            // 
            this.Sunucu_TreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sunucu_TreeView.Location = new System.Drawing.Point(12, 34);
            this.Sunucu_TreeView.Name = "Sunucu_TreeView";
            this.Sunucu_TreeView.Size = new System.Drawing.Size(206, 432);
            this.Sunucu_TreeView.TabIndex = 1;
            this.Sunucu_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Sunucu_TreeView_AfterSelect);
            this.Sunucu_TreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sunucu_TreeView_MouseDown);
            this.Sunucu_TreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sunucu_TreeView_MouseMove);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(939, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 2;
            // 
            // Islemler_TabCtrl
            // 
            this.Islemler_TabCtrl.Controls.Add(this.TabloDuzenle_TPg);
            this.Islemler_TabCtrl.Controls.Add(this.tabPage2);
            this.Islemler_TabCtrl.Controls.Add(this.tabPage3);
            this.Islemler_TabCtrl.Location = new System.Drawing.Point(240, 12);
            this.Islemler_TabCtrl.Name = "Islemler_TabCtrl";
            this.Islemler_TabCtrl.SelectedIndex = 0;
            this.Islemler_TabCtrl.Size = new System.Drawing.Size(693, 454);
            this.Islemler_TabCtrl.TabIndex = 3;
            this.Islemler_TabCtrl.SelectedIndexChanged += new System.EventHandler(this.Islemler_TabCtrl_SelectedIndexChanged);
            // 
            // TabloDuzenle_TPg
            // 
            this.TabloDuzenle_TPg.Controls.Add(this.TabloKaydetIptal_Btn);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloyuKaydet_Btn);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloKayitSayisiAciklama_Lbl);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloKayitSayisi_Lbl);
            this.TabloDuzenle_TPg.Controls.Add(this.label1);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloToplamSayfa_TBox);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloGecerliSayfa_TBox);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloListeIleri_Btn);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloListeGeri_Btn);
            this.TabloDuzenle_TPg.Controls.Add(this.Sirala_Btn);
            this.TabloDuzenle_TPg.Controls.Add(this.Kacarli_Lbl);
            this.TabloDuzenle_TPg.Controls.Add(this.Kacarli_CBox);
            this.TabloDuzenle_TPg.Controls.Add(this.Artan_Chck);
            this.TabloDuzenle_TPg.Controls.Add(this.Artan_Lbl);
            this.TabloDuzenle_TPg.Controls.Add(this.KolonaGore_Lbl);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloKolonlar_CBox);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloKayitlar_DGV);
            this.TabloDuzenle_TPg.Controls.Add(this.TabloDBName_Lbl);
            this.TabloDuzenle_TPg.Location = new System.Drawing.Point(4, 22);
            this.TabloDuzenle_TPg.Name = "TabloDuzenle_TPg";
            this.TabloDuzenle_TPg.Padding = new System.Windows.Forms.Padding(3);
            this.TabloDuzenle_TPg.Size = new System.Drawing.Size(685, 428);
            this.TabloDuzenle_TPg.TabIndex = 0;
            this.TabloDuzenle_TPg.Text = "tabPage1";
            this.TabloDuzenle_TPg.UseVisualStyleBackColor = true;
            // 
            // TabloKaydetIptal_Btn
            // 
            this.TabloKaydetIptal_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabloKaydetIptal_Btn.Location = new System.Drawing.Point(87, 396);
            this.TabloKaydetIptal_Btn.Name = "TabloKaydetIptal_Btn";
            this.TabloKaydetIptal_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloKaydetIptal_Btn.TabIndex = 18;
            this.TabloKaydetIptal_Btn.Text = "İptal";
            this.TabloKaydetIptal_Btn.UseVisualStyleBackColor = true;
            this.TabloKaydetIptal_Btn.Click += new System.EventHandler(this.TabloKaydetIptal_Btn_Click);
            // 
            // TabloyuKaydet_Btn
            // 
            this.TabloyuKaydet_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabloyuKaydet_Btn.Location = new System.Drawing.Point(6, 396);
            this.TabloyuKaydet_Btn.Name = "TabloyuKaydet_Btn";
            this.TabloyuKaydet_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloyuKaydet_Btn.TabIndex = 17;
            this.TabloyuKaydet_Btn.Text = "Kaydet";
            this.TabloyuKaydet_Btn.UseVisualStyleBackColor = true;
            this.TabloyuKaydet_Btn.Click += new System.EventHandler(this.TabloyuKaydet_Btn_Click);
            // 
            // TabloKayitSayisiAciklama_Lbl
            // 
            this.TabloKayitSayisiAciklama_Lbl.AutoSize = true;
            this.TabloKayitSayisiAciklama_Lbl.Location = new System.Drawing.Point(631, 400);
            this.TabloKayitSayisiAciklama_Lbl.Name = "TabloKayitSayisiAciklama_Lbl";
            this.TabloKayitSayisiAciklama_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.TabloKayitSayisiAciklama_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabloKayitSayisiAciklama_Lbl.Size = new System.Drawing.Size(34, 19);
            this.TabloKayitSayisiAciklama_Lbl.TabIndex = 16;
            this.TabloKayitSayisiAciklama_Lbl.Text = "Satır";
            this.TabloKayitSayisiAciklama_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TabloKayitSayisi_Lbl
            // 
            this.TabloKayitSayisi_Lbl.AutoSize = true;
            this.TabloKayitSayisi_Lbl.Location = new System.Drawing.Point(588, 399);
            this.TabloKayitSayisi_Lbl.Name = "TabloKayitSayisi_Lbl";
            this.TabloKayitSayisi_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.TabloKayitSayisi_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabloKayitSayisi_Lbl.Size = new System.Drawing.Size(19, 19);
            this.TabloKayitSayisi_Lbl.TabIndex = 15;
            this.TabloKayitSayisi_Lbl.Text = "0";
            this.TabloKayitSayisi_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 400);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TabloToplamSayfa_TBox
            // 
            this.TabloToplamSayfa_TBox.Location = new System.Drawing.Point(411, 400);
            this.TabloToplamSayfa_TBox.Name = "TabloToplamSayfa_TBox";
            this.TabloToplamSayfa_TBox.ReadOnly = true;
            this.TabloToplamSayfa_TBox.Size = new System.Drawing.Size(73, 20);
            this.TabloToplamSayfa_TBox.TabIndex = 13;
            // 
            // TabloGecerliSayfa_TBox
            // 
            this.TabloGecerliSayfa_TBox.Location = new System.Drawing.Point(315, 400);
            this.TabloGecerliSayfa_TBox.Name = "TabloGecerliSayfa_TBox";
            this.TabloGecerliSayfa_TBox.ReadOnly = true;
            this.TabloGecerliSayfa_TBox.Size = new System.Drawing.Size(73, 20);
            this.TabloGecerliSayfa_TBox.TabIndex = 12;
            this.TabloGecerliSayfa_TBox.Text = "1";
            // 
            // TabloListeIleri_Btn
            // 
            this.TabloListeIleri_Btn.Location = new System.Drawing.Point(492, 399);
            this.TabloListeIleri_Btn.Name = "TabloListeIleri_Btn";
            this.TabloListeIleri_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloListeIleri_Btn.TabIndex = 11;
            this.TabloListeIleri_Btn.Text = "İleri";
            this.TabloListeIleri_Btn.UseVisualStyleBackColor = true;
            this.TabloListeIleri_Btn.Click += new System.EventHandler(this.TabloListeIleri_Btn_Click);
            // 
            // TabloListeGeri_Btn
            // 
            this.TabloListeGeri_Btn.Location = new System.Drawing.Point(234, 399);
            this.TabloListeGeri_Btn.Name = "TabloListeGeri_Btn";
            this.TabloListeGeri_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloListeGeri_Btn.TabIndex = 10;
            this.TabloListeGeri_Btn.Text = "Geri";
            this.TabloListeGeri_Btn.UseVisualStyleBackColor = true;
            this.TabloListeGeri_Btn.Click += new System.EventHandler(this.TabloListeGeri_Btn_Click);
            // 
            // Sirala_Btn
            // 
            this.Sirala_Btn.Location = new System.Drawing.Point(187, 2);
            this.Sirala_Btn.Name = "Sirala_Btn";
            this.Sirala_Btn.Size = new System.Drawing.Size(75, 23);
            this.Sirala_Btn.TabIndex = 9;
            this.Sirala_Btn.Text = "Sırala";
            this.Sirala_Btn.UseVisualStyleBackColor = true;
            this.Sirala_Btn.Click += new System.EventHandler(this.Sirala_Btn_Click);
            // 
            // Kacarli_Lbl
            // 
            this.Kacarli_Lbl.AutoSize = true;
            this.Kacarli_Lbl.Location = new System.Drawing.Point(616, 3);
            this.Kacarli_Lbl.Name = "Kacarli_Lbl";
            this.Kacarli_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.Kacarli_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Kacarli_Lbl.Size = new System.Drawing.Size(55, 19);
            this.Kacarli_Lbl.TabIndex = 8;
            this.Kacarli_Lbl.Text = "per page";
            // 
            // Kacarli_CBox
            // 
            this.Kacarli_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kacarli_CBox.FormattingEnabled = true;
            this.Kacarli_CBox.Items.AddRange(new object[] {
            "50",
            "250",
            "500",
            "1000"});
            this.Kacarli_CBox.Location = new System.Drawing.Point(564, 2);
            this.Kacarli_CBox.MaximumSize = new System.Drawing.Size(100, 0);
            this.Kacarli_CBox.Name = "Kacarli_CBox";
            this.Kacarli_CBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Kacarli_CBox.Size = new System.Drawing.Size(50, 21);
            this.Kacarli_CBox.TabIndex = 7;
            this.Kacarli_CBox.SelectedIndexChanged += new System.EventHandler(this.Kacarli_CBox_SelectedIndexChanged);
            // 
            // Artan_Chck
            // 
            this.Artan_Chck.AutoSize = true;
            this.Artan_Chck.Location = new System.Drawing.Point(526, 5);
            this.Artan_Chck.Name = "Artan_Chck";
            this.Artan_Chck.Size = new System.Drawing.Size(15, 14);
            this.Artan_Chck.TabIndex = 6;
            this.Artan_Chck.UseVisualStyleBackColor = true;
            this.Artan_Chck.CheckStateChanged += new System.EventHandler(this.Artan_Chck_CheckStateChanged);
            // 
            // Artan_Lbl
            // 
            this.Artan_Lbl.AutoSize = true;
            this.Artan_Lbl.Location = new System.Drawing.Point(456, 3);
            this.Artan_Lbl.Name = "Artan_Lbl";
            this.Artan_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.Artan_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Artan_Lbl.Size = new System.Drawing.Size(66, 19);
            this.Artan_Lbl.TabIndex = 5;
            this.Artan_Lbl.Text = "Ascending:";
            this.Artan_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KolonaGore_Lbl
            // 
            this.KolonaGore_Lbl.AutoSize = true;
            this.KolonaGore_Lbl.Location = new System.Drawing.Point(262, 4);
            this.KolonaGore_Lbl.Name = "KolonaGore_Lbl";
            this.KolonaGore_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.KolonaGore_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KolonaGore_Lbl.Size = new System.Drawing.Size(65, 19);
            this.KolonaGore_Lbl.TabIndex = 4;
            this.KolonaGore_Lbl.Text = "Şuna göre:";
            this.KolonaGore_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TabloKolonlar_CBox
            // 
            this.TabloKolonlar_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabloKolonlar_CBox.FormattingEnabled = true;
            this.TabloKolonlar_CBox.Location = new System.Drawing.Point(332, 3);
            this.TabloKolonlar_CBox.Name = "TabloKolonlar_CBox";
            this.TabloKolonlar_CBox.Size = new System.Drawing.Size(121, 21);
            this.TabloKolonlar_CBox.TabIndex = 3;
            this.TabloKolonlar_CBox.SelectedIndexChanged += new System.EventHandler(this.TabloKolonlar_CBox_SelectedIndexChanged);
            // 
            // TabloKayitlar_DGV
            // 
            this.TabloKayitlar_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabloKayitlar_DGV.Location = new System.Drawing.Point(6, 26);
            this.TabloKayitlar_DGV.Name = "TabloKayitlar_DGV";
            this.TabloKayitlar_DGV.Size = new System.Drawing.Size(663, 365);
            this.TabloKayitlar_DGV.TabIndex = 1;
            this.TabloKayitlar_DGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TabloKayitlar_DGV_CellBeginEdit);
            this.TabloKayitlar_DGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabloKayitlar_DGV_CellEndEdit);
            this.TabloKayitlar_DGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TabloKayitlar_DGV_DataError);
            this.TabloKayitlar_DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TabloKayitlar_DGV_RowsRemoved);
            this.TabloKayitlar_DGV.Sorted += new System.EventHandler(this.TabloKayitlar_DGV_Sorted);
            // 
            // TabloDBName_Lbl
            // 
            this.TabloDBName_Lbl.AutoSize = true;
            this.TabloDBName_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabloDBName_Lbl.Location = new System.Drawing.Point(19, 4);
            this.TabloDBName_Lbl.Name = "TabloDBName_Lbl";
            this.TabloDBName_Lbl.Padding = new System.Windows.Forms.Padding(3);
            this.TabloDBName_Lbl.Size = new System.Drawing.Size(87, 21);
            this.TabloDBName_Lbl.TabIndex = 0;
            this.TabloDBName_Lbl.Text = "Veri Tabanı Adı";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TabloYapisi_DGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabloYapisi_DGV
            // 
            this.TabloYapisi_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabloYapisi_DGV.Location = new System.Drawing.Point(6, 55);
            this.TabloYapisi_DGV.Name = "TabloYapisi_DGV";
            this.TabloYapisi_DGV.Size = new System.Drawing.Size(662, 327);
            this.TabloYapisi_DGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_IstekTabloKaydet);
            this.tabPage3.Controls.Add(this.IstekYaz_RTBox);
            this.tabPage3.Controls.Add(this.IstekCalistir_Btn);
            this.tabPage3.Controls.Add(this.Istek_DGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(685, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IstekYaz_RTBox
            // 
            this.IstekYaz_RTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IstekYaz_RTBox.Location = new System.Drawing.Point(6, 6);
            this.IstekYaz_RTBox.Name = "IstekYaz_RTBox";
            this.IstekYaz_RTBox.Size = new System.Drawing.Size(668, 111);
            this.IstekYaz_RTBox.TabIndex = 4;
            this.IstekYaz_RTBox.Text = "";
            // 
            // IstekCalistir_Btn
            // 
            this.IstekCalistir_Btn.Location = new System.Drawing.Point(6, 123);
            this.IstekCalistir_Btn.Name = "IstekCalistir_Btn";
            this.IstekCalistir_Btn.Size = new System.Drawing.Size(75, 23);
            this.IstekCalistir_Btn.TabIndex = 3;
            this.IstekCalistir_Btn.Text = "IstekCalistir";
            this.IstekCalistir_Btn.UseVisualStyleBackColor = true;
            this.IstekCalistir_Btn.Click += new System.EventHandler(this.IstekCalistir_Btn_Click);
            // 
            // Istek_DGV
            // 
            this.Istek_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Istek_DGV.Location = new System.Drawing.Point(6, 152);
            this.Istek_DGV.Name = "Istek_DGV";
            this.Istek_DGV.Size = new System.Drawing.Size(668, 183);
            this.Istek_DGV.TabIndex = 2;
            // 
            // SunucuAdi_Lbl
            // 
            this.SunucuAdi_Lbl.AutoSize = true;
            this.SunucuAdi_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SunucuAdi_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SunucuAdi_Lbl.Location = new System.Drawing.Point(46, 8);
            this.SunucuAdi_Lbl.Name = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.Size = new System.Drawing.Size(130, 20);
            this.SunucuAdi_Lbl.TabIndex = 4;
            this.SunucuAdi_Lbl.Text = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TekrarBaglan_Btn
            // 
            this.TekrarBaglan_Btn.Enabled = false;
            this.TekrarBaglan_Btn.Location = new System.Drawing.Point(1020, 31);
            this.TekrarBaglan_Btn.Name = "TekrarBaglan_Btn";
            this.TekrarBaglan_Btn.Size = new System.Drawing.Size(115, 23);
            this.TekrarBaglan_Btn.TabIndex = 8;
            this.TekrarBaglan_Btn.Text = "Tekrar Bağlan";
            this.TekrarBaglan_Btn.UseVisualStyleBackColor = true;
            this.TekrarBaglan_Btn.Click += new System.EventHandler(this.TekrarBaglan_Btn_Click);
            // 
            // Sunucular_Btn
            // 
            this.Sunucular_Btn.Location = new System.Drawing.Point(1020, 60);
            this.Sunucular_Btn.Name = "Sunucular_Btn";
            this.Sunucular_Btn.Size = new System.Drawing.Size(115, 23);
            this.Sunucular_Btn.TabIndex = 9;
            this.Sunucular_Btn.Text = "Sunucular";
            this.Sunucular_Btn.UseVisualStyleBackColor = true;
            this.Sunucular_Btn.Click += new System.EventHandler(this.Sunucular_Btn_Click);
            // 
            // SunucuAdi_PBox
            // 
            this.SunucuAdi_PBox.Image = global::SQLYonet.Properties.Resources.db_root24px;
            this.SunucuAdi_PBox.Location = new System.Drawing.Point(14, 5);
            this.SunucuAdi_PBox.Name = "SunucuAdi_PBox";
            this.SunucuAdi_PBox.Size = new System.Drawing.Size(27, 26);
            this.SunucuAdi_PBox.TabIndex = 5;
            this.SunucuAdi_PBox.TabStop = false;
            // 
            // YeniVeriTabani_Btn
            // 
            this.YeniVeriTabani_Btn.BackgroundImage = global::SQLYonet.Properties.Resources.db_ekle24px;
            this.YeniVeriTabani_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.YeniVeriTabani_Btn.Location = new System.Drawing.Point(12, 471);
            this.YeniVeriTabani_Btn.Name = "YeniVeriTabani_Btn";
            this.YeniVeriTabani_Btn.Size = new System.Drawing.Size(29, 33);
            this.YeniVeriTabani_Btn.TabIndex = 11;
            this.YeniVeriTabani_Btn.UseVisualStyleBackColor = true;
            this.YeniVeriTabani_Btn.Click += new System.EventHandler(this.YeniVeriTabani_Btn_Click);
            // 
            // VeriTabaniSil_Btn
            // 
            this.VeriTabaniSil_Btn.BackgroundImage = global::SQLYonet.Properties.Resources.dbsil_2_24px;
            this.VeriTabaniSil_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VeriTabaniSil_Btn.Location = new System.Drawing.Point(47, 471);
            this.VeriTabaniSil_Btn.Name = "VeriTabaniSil_Btn";
            this.VeriTabaniSil_Btn.Size = new System.Drawing.Size(29, 33);
            this.VeriTabaniSil_Btn.TabIndex = 12;
            this.VeriTabaniSil_Btn.UseVisualStyleBackColor = true;
            this.VeriTabaniSil_Btn.Click += new System.EventHandler(this.VeriTabaniSil_Btn_Click);
            // 
            // TabloTV_CxMS
            // 
            this.TabloTV_CxMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabloTVKopyala_TSMI,
            this.TabloTVYokEt_TSMI,
            this.TabloTVBosalt_TSMI});
            this.TabloTV_CxMS.Name = "TabloTV_CxMS";
            this.TabloTV_CxMS.Size = new System.Drawing.Size(162, 70);
            // 
            // TabloTVKopyala_TSMI
            // 
            this.TabloTVKopyala_TSMI.Name = "TabloTVKopyala_TSMI";
            this.TabloTVKopyala_TSMI.Size = new System.Drawing.Size(161, 22);
            this.TabloTVKopyala_TSMI.Text = "Tabloyu Kopyala";
            // 
            // TabloTVYokEt_TSMI
            // 
            this.TabloTVYokEt_TSMI.Name = "TabloTVYokEt_TSMI";
            this.TabloTVYokEt_TSMI.Size = new System.Drawing.Size(161, 22);
            this.TabloTVYokEt_TSMI.Text = "Tabloyu Yok Et";
            this.TabloTVYokEt_TSMI.Click += new System.EventHandler(this.TabloTVYokEt_TSMI_Click);
            // 
            // TabloTVBosalt_TSMI
            // 
            this.TabloTVBosalt_TSMI.Name = "TabloTVBosalt_TSMI";
            this.TabloTVBosalt_TSMI.Size = new System.Drawing.Size(161, 22);
            this.TabloTVBosalt_TSMI.Text = "Tabloyu Boşalt";
            // 
            // Btn_IstekTabloKaydet
            // 
            this.Btn_IstekTabloKaydet.Location = new System.Drawing.Point(599, 123);
            this.Btn_IstekTabloKaydet.Name = "Btn_IstekTabloKaydet";
            this.Btn_IstekTabloKaydet.Size = new System.Drawing.Size(75, 23);
            this.Btn_IstekTabloKaydet.TabIndex = 5;
            this.Btn_IstekTabloKaydet.Text = "IstekTabloKaydet";
            this.Btn_IstekTabloKaydet.UseVisualStyleBackColor = true;
            this.Btn_IstekTabloKaydet.Click += new System.EventHandler(this.Btn_IstekTabloKaydet_Click);
            // 
            // dilSeciciKontrol1
            // 
            this.dilSeciciKontrol1.Location = new System.Drawing.Point(1041, 2);
            this.dilSeciciKontrol1.Name = "dilSeciciKontrol1";
            this.dilSeciciKontrol1.Size = new System.Drawing.Size(96, 26);
            this.dilSeciciKontrol1.TabIndex = 6;
            // 
            // f03_MySQLYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1139, 506);
            this.Controls.Add(this.VeriTabaniSil_Btn);
            this.Controls.Add(this.YeniVeriTabani_Btn);
            this.Controls.Add(this.Sunucular_Btn);
            this.Controls.Add(this.TekrarBaglan_Btn);
            this.Controls.Add(this.dilSeciciKontrol1);
            this.Controls.Add(this.SunucuAdi_PBox);
            this.Controls.Add(this.SunucuAdi_Lbl);
            this.Controls.Add(this.Islemler_TabCtrl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sunucu_TreeView);
            this.Name = "f03_MySQLYonet";
            this.Text = "Veri Tabanı Yönetimi";
            this.Activated += new System.EventHandler(this.f03_MySQLYonet_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f03_MySQLYonet_FormClosing);
            this.Load += new System.EventHandler(this.f03_MySQLYonet_Load);
            this.Islemler_TabCtrl.ResumeLayout(false);
            this.TabloDuzenle_TPg.ResumeLayout(false);
            this.TabloDuzenle_TPg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabloKayitlar_DGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabloYapisi_DGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Istek_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).EndInit();
            this.TabloTV_CxMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView Sunucu_TreeView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl Islemler_TabCtrl;
        private System.Windows.Forms.TabPage TabloDuzenle_TPg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SunucuAdi_Lbl;
        private System.Windows.Forms.PictureBox SunucuAdi_PBox;
        private DilSeciciKontrol dilSeciciKontrol1;
        private System.Windows.Forms.Button TekrarBaglan_Btn;
        private System.Windows.Forms.Button Sunucular_Btn;
        private System.Windows.Forms.Label TabloDBName_Lbl;
        private System.Windows.Forms.DataGridView TabloKayitlar_DGV;
        private System.Windows.Forms.ComboBox TabloKolonlar_CBox;
        private System.Windows.Forms.Label Kacarli_Lbl;
        private System.Windows.Forms.ComboBox Kacarli_CBox;
        private System.Windows.Forms.CheckBox Artan_Chck;
        private System.Windows.Forms.Label Artan_Lbl;
        private System.Windows.Forms.Label KolonaGore_Lbl;
        private System.Windows.Forms.Button Sirala_Btn;
        private System.Windows.Forms.TextBox TabloGecerliSayfa_TBox;
        private System.Windows.Forms.Button TabloListeIleri_Btn;
        private System.Windows.Forms.Button TabloListeGeri_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TabloToplamSayfa_TBox;
        private System.Windows.Forms.Label TabloKayitSayisi_Lbl;
        private System.Windows.Forms.Label TabloKayitSayisiAciklama_Lbl;
        private System.Windows.Forms.Button TabloKaydetIptal_Btn;
        private System.Windows.Forms.Button TabloyuKaydet_Btn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button YeniVeriTabani_Btn;
        private System.Windows.Forms.Button VeriTabaniSil_Btn;
        private System.Windows.Forms.DataGridView TabloYapisi_DGV;
        private System.Windows.Forms.ContextMenuStrip TabloTV_CxMS;
        private System.Windows.Forms.ToolStripMenuItem TabloTVKopyala_TSMI;
        private System.Windows.Forms.ToolStripMenuItem TabloTVYokEt_TSMI;
        private System.Windows.Forms.ToolStripMenuItem TabloTVBosalt_TSMI;
        private System.Windows.Forms.Button IstekCalistir_Btn;
        private System.Windows.Forms.DataGridView Istek_DGV;
        private System.Windows.Forms.RichTextBox IstekYaz_RTBox;
        private System.Windows.Forms.Button Btn_IstekTabloKaydet;
    }
}