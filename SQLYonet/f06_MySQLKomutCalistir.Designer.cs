﻿namespace SQLYonet
{
    partial class f06_MySQLKomutCalistir
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
            this.RTBox_SQLYaz = new System.Windows.Forms.RichTextBox();
            this.Btn_SQLCalistir = new System.Windows.Forms.Button();
            this.DGV_SQLSonuc = new System.Windows.Forms.DataGridView();
            this.LVw_SQLLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Genislet = new System.Windows.Forms.Button();
            this.CBox_DBNAME = new System.Windows.Forms.ComboBox();
            this.Lbl_DBNAME = new System.Windows.Forms.Label();
            this.SunucuAdi_PBox = new System.Windows.Forms.PictureBox();
            this.SunucuAdi_Lbl = new System.Windows.Forms.Label();
            this.TabloKaydetIptal_Btn = new System.Windows.Forms.Button();
            this.TabloyuKaydet_Btn = new System.Windows.Forms.Button();
            this.dilSeciciKontrol1 = new SQLYonet.DilSeciciKontrol();
            this.cikisButon1 = new SQLYonet.CikisButon();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SQLSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBox_SQLYaz
            // 
            this.RTBox_SQLYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RTBox_SQLYaz.Location = new System.Drawing.Point(8, 58);
            this.RTBox_SQLYaz.Name = "RTBox_SQLYaz";
            this.RTBox_SQLYaz.Size = new System.Drawing.Size(520, 111);
            this.RTBox_SQLYaz.TabIndex = 5;
            this.RTBox_SQLYaz.Text = "";
            // 
            // Btn_SQLCalistir
            // 
            this.Btn_SQLCalistir.Location = new System.Drawing.Point(8, 175);
            this.Btn_SQLCalistir.Name = "Btn_SQLCalistir";
            this.Btn_SQLCalistir.Size = new System.Drawing.Size(75, 23);
            this.Btn_SQLCalistir.TabIndex = 6;
            this.Btn_SQLCalistir.Text = "IstekCalistir";
            this.Btn_SQLCalistir.UseVisualStyleBackColor = true;
            // 
            // DGV_SQLSonuc
            // 
            this.DGV_SQLSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SQLSonuc.Location = new System.Drawing.Point(8, 204);
            this.DGV_SQLSonuc.Name = "DGV_SQLSonuc";
            this.DGV_SQLSonuc.Size = new System.Drawing.Size(520, 183);
            this.DGV_SQLSonuc.TabIndex = 7;
            // 
            // LVw_SQLLog
            // 
            this.LVw_SQLLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LVw_SQLLog.Location = new System.Drawing.Point(8, 421);
            this.LVw_SQLLog.Name = "LVw_SQLLog";
            this.LVw_SQLLog.Size = new System.Drawing.Size(520, 80);
            this.LVw_SQLLog.TabIndex = 9;
            this.LVw_SQLLog.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Saat";
            this.columnHeader1.Text = "Saat";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Aciklama";
            this.columnHeader2.Text = "Açıklama";
            // 
            // Btn_Genislet
            // 
            this.Btn_Genislet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Genislet.Location = new System.Drawing.Point(489, 33);
            this.Btn_Genislet.Name = "Btn_Genislet";
            this.Btn_Genislet.Size = new System.Drawing.Size(33, 23);
            this.Btn_Genislet.TabIndex = 10;
            this.Btn_Genislet.Text = "<->";
            this.Btn_Genislet.UseVisualStyleBackColor = true;
            this.Btn_Genislet.Click += new System.EventHandler(this.Btn_Genislet_Click);
            // 
            // CBox_DBNAME
            // 
            this.CBox_DBNAME.FormattingEnabled = true;
            this.CBox_DBNAME.Location = new System.Drawing.Point(188, 35);
            this.CBox_DBNAME.Name = "CBox_DBNAME";
            this.CBox_DBNAME.Size = new System.Drawing.Size(161, 21);
            this.CBox_DBNAME.TabIndex = 12;
            this.CBox_DBNAME.SelectedIndexChanged += new System.EventHandler(this.CBox_DBNAME_SelectedIndexChanged);
            // 
            // Lbl_DBNAME
            // 
            this.Lbl_DBNAME.AutoSize = true;
            this.Lbl_DBNAME.Location = new System.Drawing.Point(193, 16);
            this.Lbl_DBNAME.Name = "Lbl_DBNAME";
            this.Lbl_DBNAME.Size = new System.Drawing.Size(84, 13);
            this.Lbl_DBNAME.TabIndex = 13;
            this.Lbl_DBNAME.Text = "Database Name";
            // 
            // SunucuAdi_PBox
            // 
            this.SunucuAdi_PBox.Image = global::SQLYonet.Properties.Resources.db_root24px;
            this.SunucuAdi_PBox.Location = new System.Drawing.Point(4, 3);
            this.SunucuAdi_PBox.Name = "SunucuAdi_PBox";
            this.SunucuAdi_PBox.Size = new System.Drawing.Size(27, 26);
            this.SunucuAdi_PBox.TabIndex = 15;
            this.SunucuAdi_PBox.TabStop = false;
            // 
            // SunucuAdi_Lbl
            // 
            this.SunucuAdi_Lbl.AutoSize = true;
            this.SunucuAdi_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SunucuAdi_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SunucuAdi_Lbl.Location = new System.Drawing.Point(36, 6);
            this.SunucuAdi_Lbl.Name = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.Size = new System.Drawing.Size(130, 20);
            this.SunucuAdi_Lbl.TabIndex = 14;
            this.SunucuAdi_Lbl.Text = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabloKaydetIptal_Btn
            // 
            this.TabloKaydetIptal_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabloKaydetIptal_Btn.Location = new System.Drawing.Point(93, 392);
            this.TabloKaydetIptal_Btn.Name = "TabloKaydetIptal_Btn";
            this.TabloKaydetIptal_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloKaydetIptal_Btn.TabIndex = 20;
            this.TabloKaydetIptal_Btn.Text = "İptal";
            this.TabloKaydetIptal_Btn.UseVisualStyleBackColor = true;
            // 
            // TabloyuKaydet_Btn
            // 
            this.TabloyuKaydet_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabloyuKaydet_Btn.Location = new System.Drawing.Point(12, 392);
            this.TabloyuKaydet_Btn.Name = "TabloyuKaydet_Btn";
            this.TabloyuKaydet_Btn.Size = new System.Drawing.Size(75, 23);
            this.TabloyuKaydet_Btn.TabIndex = 19;
            this.TabloyuKaydet_Btn.Text = "Kaydet";
            this.TabloyuKaydet_Btn.UseVisualStyleBackColor = true;
            // 
            // dilSeciciKontrol1
            // 
            this.dilSeciciKontrol1.Location = new System.Drawing.Point(396, 3);
            this.dilSeciciKontrol1.Name = "dilSeciciKontrol1";
            this.dilSeciciKontrol1.Size = new System.Drawing.Size(92, 26);
            this.dilSeciciKontrol1.TabIndex = 11;
            // 
            // cikisButon1
            // 
            this.cikisButon1.Location = new System.Drawing.Point(490, 0);
            this.cikisButon1.Name = "cikisButon1";
            this.cikisButon1.Size = new System.Drawing.Size(31, 30);
            this.cikisButon1.TabIndex = 21;
            // 
            // f06_MySQLKomutCalistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 509);
            this.Controls.Add(this.cikisButon1);
            this.Controls.Add(this.TabloKaydetIptal_Btn);
            this.Controls.Add(this.TabloyuKaydet_Btn);
            this.Controls.Add(this.SunucuAdi_PBox);
            this.Controls.Add(this.SunucuAdi_Lbl);
            this.Controls.Add(this.Lbl_DBNAME);
            this.Controls.Add(this.CBox_DBNAME);
            this.Controls.Add(this.dilSeciciKontrol1);
            this.Controls.Add(this.Btn_Genislet);
            this.Controls.Add(this.LVw_SQLLog);
            this.Controls.Add(this.DGV_SQLSonuc);
            this.Controls.Add(this.Btn_SQLCalistir);
            this.Controls.Add(this.RTBox_SQLYaz);
            this.MinimumSize = new System.Drawing.Size(550, 536);
            this.Name = "f06_MySQLKomutCalistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f06_MySQLKomutCalistir";
            this.Load += new System.EventHandler(this.f06_MySQLKomutCalistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SQLSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBox_SQLYaz;
        private System.Windows.Forms.Button Btn_SQLCalistir;
        private System.Windows.Forms.DataGridView DGV_SQLSonuc;
        private System.Windows.Forms.ListView LVw_SQLLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Btn_Genislet;
        private DilSeciciKontrol dilSeciciKontrol1;
        private System.Windows.Forms.ComboBox CBox_DBNAME;
        private System.Windows.Forms.Label Lbl_DBNAME;
        private System.Windows.Forms.PictureBox SunucuAdi_PBox;
        private System.Windows.Forms.Label SunucuAdi_Lbl;
        private System.Windows.Forms.Button TabloKaydetIptal_Btn;
        private System.Windows.Forms.Button TabloyuKaydet_Btn;
        private CikisButon cikisButon1;
    }
}