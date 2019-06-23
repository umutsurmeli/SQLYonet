namespace SQLYonet
{
    partial class f02_Sunucular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f02_Sunucular));
            this.Sunucular_ListBox = new System.Windows.Forms.ListBox();
            this.Yeni_Btn = new System.Windows.Forms.Button();
            this.BaglantiAdi_TBox = new System.Windows.Forms.TextBox();
            this.BaglantiAdi_Lbl = new System.Windows.Forms.Label();
            this.DBHost_Lbl = new System.Windows.Forms.Label();
            this.DBHost_TBox = new System.Windows.Forms.TextBox();
            this.DBUser_Lbl = new System.Windows.Forms.Label();
            this.DBUser_TBox = new System.Windows.Forms.TextBox();
            this.DBPass_Lbl = new System.Windows.Forms.Label();
            this.DBPass_TBox = new System.Windows.Forms.TextBox();
            this.Duzenle_Btn = new System.Windows.Forms.Button();
            this.Sil_Btn = new System.Windows.Forms.Button();
            this.Iptal_Btn = new System.Windows.Forms.Button();
            this.Kaydet_Btn = new System.Windows.Forms.Button();
            this.Hosgeldin_Lbl = new System.Windows.Forms.Label();
            this.Kullanici_Lbl = new System.Windows.Forms.Label();
            this.dilSeciciKontrol1 = new SQLYonet.DilSeciciKontrol();
            this.Baglan_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sunucular_ListBox
            // 
            this.Sunucular_ListBox.FormattingEnabled = true;
            this.Sunucular_ListBox.Location = new System.Drawing.Point(12, 32);
            this.Sunucular_ListBox.Name = "Sunucular_ListBox";
            this.Sunucular_ListBox.Size = new System.Drawing.Size(118, 147);
            this.Sunucular_ListBox.TabIndex = 0;
            this.Sunucular_ListBox.SelectedIndexChanged += new System.EventHandler(this.Sunucular_ListBox_SelectedIndexChanged);
            // 
            // Yeni_Btn
            // 
            this.Yeni_Btn.Location = new System.Drawing.Point(12, 239);
            this.Yeni_Btn.Name = "Yeni_Btn";
            this.Yeni_Btn.Size = new System.Drawing.Size(148, 23);
            this.Yeni_Btn.TabIndex = 1;
            this.Yeni_Btn.Text = "Yeni";
            this.Yeni_Btn.UseVisualStyleBackColor = true;
            this.Yeni_Btn.Click += new System.EventHandler(this.Yeni_Btn_Click);
            // 
            // BaglantiAdi_TBox
            // 
            this.BaglantiAdi_TBox.Location = new System.Drawing.Point(12, 213);
            this.BaglantiAdi_TBox.Name = "BaglantiAdi_TBox";
            this.BaglantiAdi_TBox.Size = new System.Drawing.Size(100, 20);
            this.BaglantiAdi_TBox.TabIndex = 3;
            // 
            // BaglantiAdi_Lbl
            // 
            this.BaglantiAdi_Lbl.AutoSize = true;
            this.BaglantiAdi_Lbl.Location = new System.Drawing.Point(12, 197);
            this.BaglantiAdi_Lbl.Name = "BaglantiAdi_Lbl";
            this.BaglantiAdi_Lbl.Size = new System.Drawing.Size(63, 13);
            this.BaglantiAdi_Lbl.TabIndex = 4;
            this.BaglantiAdi_Lbl.Text = "Bağlantı Adı";
            // 
            // DBHost_Lbl
            // 
            this.DBHost_Lbl.AutoSize = true;
            this.DBHost_Lbl.Location = new System.Drawing.Point(127, 197);
            this.DBHost_Lbl.Name = "DBHost_Lbl";
            this.DBHost_Lbl.Size = new System.Drawing.Size(137, 13);
            this.DBHost_Lbl.TabIndex = 6;
            this.DBHost_Lbl.Text = "V.T. Sunucu (IP / Host Adı)";
            // 
            // DBHost_TBox
            // 
            this.DBHost_TBox.Location = new System.Drawing.Point(127, 213);
            this.DBHost_TBox.Name = "DBHost_TBox";
            this.DBHost_TBox.Size = new System.Drawing.Size(135, 20);
            this.DBHost_TBox.TabIndex = 5;
            // 
            // DBUser_Lbl
            // 
            this.DBUser_Lbl.AutoSize = true;
            this.DBUser_Lbl.Location = new System.Drawing.Point(279, 197);
            this.DBUser_Lbl.Name = "DBUser_Lbl";
            this.DBUser_Lbl.Size = new System.Drawing.Size(69, 13);
            this.DBUser_Lbl.TabIndex = 8;
            this.DBUser_Lbl.Text = "V.T. Kullanıcı";
            // 
            // DBUser_TBox
            // 
            this.DBUser_TBox.Location = new System.Drawing.Point(279, 213);
            this.DBUser_TBox.Name = "DBUser_TBox";
            this.DBUser_TBox.Size = new System.Drawing.Size(100, 20);
            this.DBUser_TBox.TabIndex = 7;
            // 
            // DBPass_Lbl
            // 
            this.DBPass_Lbl.AutoSize = true;
            this.DBPass_Lbl.Location = new System.Drawing.Point(385, 197);
            this.DBPass_Lbl.Name = "DBPass_Lbl";
            this.DBPass_Lbl.Size = new System.Drawing.Size(60, 13);
            this.DBPass_Lbl.TabIndex = 10;
            this.DBPass_Lbl.Text = "V.T. Parola";
            // 
            // DBPass_TBox
            // 
            this.DBPass_TBox.Location = new System.Drawing.Point(388, 213);
            this.DBPass_TBox.Name = "DBPass_TBox";
            this.DBPass_TBox.PasswordChar = '*';
            this.DBPass_TBox.Size = new System.Drawing.Size(100, 20);
            this.DBPass_TBox.TabIndex = 9;
            // 
            // Duzenle_Btn
            // 
            this.Duzenle_Btn.Location = new System.Drawing.Point(175, 239);
            this.Duzenle_Btn.Name = "Duzenle_Btn";
            this.Duzenle_Btn.Size = new System.Drawing.Size(145, 23);
            this.Duzenle_Btn.TabIndex = 11;
            this.Duzenle_Btn.Text = "Düzenle";
            this.Duzenle_Btn.UseVisualStyleBackColor = true;
            this.Duzenle_Btn.Click += new System.EventHandler(this.Duzenle_Btn_Click);
            // 
            // Sil_Btn
            // 
            this.Sil_Btn.Location = new System.Drawing.Point(341, 239);
            this.Sil_Btn.Name = "Sil_Btn";
            this.Sil_Btn.Size = new System.Drawing.Size(144, 23);
            this.Sil_Btn.TabIndex = 12;
            this.Sil_Btn.Text = "Sil";
            this.Sil_Btn.UseVisualStyleBackColor = true;
            this.Sil_Btn.Click += new System.EventHandler(this.Sil_Btn_Click);
            // 
            // Iptal_Btn
            // 
            this.Iptal_Btn.Location = new System.Drawing.Point(259, 268);
            this.Iptal_Btn.Name = "Iptal_Btn";
            this.Iptal_Btn.Size = new System.Drawing.Size(145, 23);
            this.Iptal_Btn.TabIndex = 15;
            this.Iptal_Btn.Text = "İptal";
            this.Iptal_Btn.UseVisualStyleBackColor = true;
            this.Iptal_Btn.Click += new System.EventHandler(this.Iptal_Btn_Click);
            // 
            // Kaydet_Btn
            // 
            this.Kaydet_Btn.Location = new System.Drawing.Point(82, 268);
            this.Kaydet_Btn.Name = "Kaydet_Btn";
            this.Kaydet_Btn.Size = new System.Drawing.Size(145, 23);
            this.Kaydet_Btn.TabIndex = 16;
            this.Kaydet_Btn.Text = "Kaydet";
            this.Kaydet_Btn.UseVisualStyleBackColor = true;
            this.Kaydet_Btn.Click += new System.EventHandler(this.Kaydet_Btn_Click);
            // 
            // Hosgeldin_Lbl
            // 
            this.Hosgeldin_Lbl.AutoSize = true;
            this.Hosgeldin_Lbl.Location = new System.Drawing.Point(256, 9);
            this.Hosgeldin_Lbl.Name = "Hosgeldin_Lbl";
            this.Hosgeldin_Lbl.Size = new System.Drawing.Size(54, 13);
            this.Hosgeldin_Lbl.TabIndex = 17;
            this.Hosgeldin_Lbl.Text = "Hoşgeldin";
            // 
            // Kullanici_Lbl
            // 
            this.Kullanici_Lbl.AutoSize = true;
            this.Kullanici_Lbl.Location = new System.Drawing.Point(316, 9);
            this.Kullanici_Lbl.Name = "Kullanici_Lbl";
            this.Kullanici_Lbl.Size = new System.Drawing.Size(46, 13);
            this.Kullanici_Lbl.TabIndex = 18;
            this.Kullanici_Lbl.Text = "Kullanıcı";
            // 
            // dilSeciciKontrol1
            // 
            this.dilSeciciKontrol1.Location = new System.Drawing.Point(431, 3);
            this.dilSeciciKontrol1.Name = "dilSeciciKontrol1";
            this.dilSeciciKontrol1.Size = new System.Drawing.Size(91, 26);
            this.dilSeciciKontrol1.TabIndex = 14;
            // 
            // Baglan_Btn
            // 
            this.Baglan_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Baglan_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Baglan_Btn.Location = new System.Drawing.Point(152, 32);
            this.Baglan_Btn.MinimumSize = new System.Drawing.Size(12, 12);
            this.Baglan_Btn.Name = "Baglan_Btn";
            this.Baglan_Btn.Size = new System.Drawing.Size(96, 24);
            this.Baglan_Btn.TabIndex = 13;
            this.Baglan_Btn.Text = "Bağlan";
            this.Baglan_Btn.UseVisualStyleBackColor = true;
            this.Baglan_Btn.Click += new System.EventHandler(this.Baglan_Btn_Click);
            // 
            // f02_Sunucular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 297);
            this.Controls.Add(this.Kullanici_Lbl);
            this.Controls.Add(this.Hosgeldin_Lbl);
            this.Controls.Add(this.Kaydet_Btn);
            this.Controls.Add(this.Iptal_Btn);
            this.Controls.Add(this.dilSeciciKontrol1);
            this.Controls.Add(this.Baglan_Btn);
            this.Controls.Add(this.Sil_Btn);
            this.Controls.Add(this.Duzenle_Btn);
            this.Controls.Add(this.DBPass_Lbl);
            this.Controls.Add(this.DBPass_TBox);
            this.Controls.Add(this.DBUser_Lbl);
            this.Controls.Add(this.DBUser_TBox);
            this.Controls.Add(this.DBHost_Lbl);
            this.Controls.Add(this.DBHost_TBox);
            this.Controls.Add(this.BaglantiAdi_Lbl);
            this.Controls.Add(this.BaglantiAdi_TBox);
            this.Controls.Add(this.Yeni_Btn);
            this.Controls.Add(this.Sunucular_ListBox);
            this.Name = "f02_Sunucular";
            this.Text = "Sunucular";
            this.Activated += new System.EventHandler(this.f02_Sunucular_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f02_Sunucular_FormClosed);
            this.Load += new System.EventHandler(this.f02_Sunucular_Load);
            this.VisibleChanged += new System.EventHandler(this.f02_Sunucular_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Sunucular_ListBox;
        private System.Windows.Forms.Button Yeni_Btn;
        private System.Windows.Forms.TextBox BaglantiAdi_TBox;
        private System.Windows.Forms.Label BaglantiAdi_Lbl;
        private System.Windows.Forms.Label DBHost_Lbl;
        private System.Windows.Forms.TextBox DBHost_TBox;
        private System.Windows.Forms.Label DBUser_Lbl;
        private System.Windows.Forms.TextBox DBUser_TBox;
        private System.Windows.Forms.Label DBPass_Lbl;
        private System.Windows.Forms.TextBox DBPass_TBox;
        private System.Windows.Forms.Button Duzenle_Btn;
        private System.Windows.Forms.Button Sil_Btn;
        private System.Windows.Forms.Button Baglan_Btn;
        private DilSeciciKontrol dilSeciciKontrol1;
        private System.Windows.Forms.Button Iptal_Btn;
        private System.Windows.Forms.Button Kaydet_Btn;
        private System.Windows.Forms.Label Hosgeldin_Lbl;
        private System.Windows.Forms.Label Kullanici_Lbl;
    }
}