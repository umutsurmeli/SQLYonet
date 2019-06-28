namespace SQLYonet
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
            this.Btn_SonucTabloKaydet = new System.Windows.Forms.Button();
            this.LVw_SQLLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Genislet = new System.Windows.Forms.Button();
            this.dilSeciciKontrol1 = new SQLYonet.DilSeciciKontrol();
            this.CBox_DBNAME = new System.Windows.Forms.ComboBox();
            this.Lbl_DBNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SQLSonuc)).BeginInit();
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
            // Btn_SonucTabloKaydet
            // 
            this.Btn_SonucTabloKaydet.Location = new System.Drawing.Point(8, 393);
            this.Btn_SonucTabloKaydet.Name = "Btn_SonucTabloKaydet";
            this.Btn_SonucTabloKaydet.Size = new System.Drawing.Size(75, 23);
            this.Btn_SonucTabloKaydet.TabIndex = 8;
            this.Btn_SonucTabloKaydet.Text = "IstekTabloKaydet";
            this.Btn_SonucTabloKaydet.UseVisualStyleBackColor = true;
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
            this.Btn_Genislet.Location = new System.Drawing.Point(488, 11);
            this.Btn_Genislet.Name = "Btn_Genislet";
            this.Btn_Genislet.Size = new System.Drawing.Size(33, 23);
            this.Btn_Genislet.TabIndex = 10;
            this.Btn_Genislet.Text = "<->";
            this.Btn_Genislet.UseVisualStyleBackColor = true;
            this.Btn_Genislet.Click += new System.EventHandler(this.Btn_Genislet_Click);
            // 
            // dilSeciciKontrol1
            // 
            this.dilSeciciKontrol1.Location = new System.Drawing.Point(391, 10);
            this.dilSeciciKontrol1.Name = "dilSeciciKontrol1";
            this.dilSeciciKontrol1.Size = new System.Drawing.Size(92, 26);
            this.dilSeciciKontrol1.TabIndex = 11;
            // 
            // CBox_DBNAME
            // 
            this.CBox_DBNAME.FormattingEnabled = true;
            this.CBox_DBNAME.Location = new System.Drawing.Point(8, 31);
            this.CBox_DBNAME.Name = "CBox_DBNAME";
            this.CBox_DBNAME.Size = new System.Drawing.Size(161, 21);
            this.CBox_DBNAME.TabIndex = 12;
            // 
            // Lbl_DBNAME
            // 
            this.Lbl_DBNAME.AutoSize = true;
            this.Lbl_DBNAME.Location = new System.Drawing.Point(13, 12);
            this.Lbl_DBNAME.Name = "Lbl_DBNAME";
            this.Lbl_DBNAME.Size = new System.Drawing.Size(84, 13);
            this.Lbl_DBNAME.TabIndex = 13;
            this.Lbl_DBNAME.Text = "Database Name";
            // 
            // f06_MySQLKomutCalistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(534, 509);
            this.Controls.Add(this.Lbl_DBNAME);
            this.Controls.Add(this.CBox_DBNAME);
            this.Controls.Add(this.dilSeciciKontrol1);
            this.Controls.Add(this.Btn_Genislet);
            this.Controls.Add(this.LVw_SQLLog);
            this.Controls.Add(this.Btn_SonucTabloKaydet);
            this.Controls.Add(this.DGV_SQLSonuc);
            this.Controls.Add(this.Btn_SQLCalistir);
            this.Controls.Add(this.RTBox_SQLYaz);
            this.MinimumSize = new System.Drawing.Size(550, 536);
            this.Name = "f06_MySQLKomutCalistir";
            this.Text = "f06_MySQLKomutCalistir";
            this.Load += new System.EventHandler(this.f06_MySQLKomutCalistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SQLSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBox_SQLYaz;
        private System.Windows.Forms.Button Btn_SQLCalistir;
        private System.Windows.Forms.DataGridView DGV_SQLSonuc;
        private System.Windows.Forms.Button Btn_SonucTabloKaydet;
        private System.Windows.Forms.ListView LVw_SQLLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Btn_Genislet;
        private DilSeciciKontrol dilSeciciKontrol1;
        private System.Windows.Forms.ComboBox CBox_DBNAME;
        private System.Windows.Forms.Label Lbl_DBNAME;
    }
}