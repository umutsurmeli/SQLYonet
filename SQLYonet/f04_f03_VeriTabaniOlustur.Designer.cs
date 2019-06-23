namespace SQLYonet
{
    partial class f04_f03_VeriTabaniOlustur
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
            this.YeniVeriTabaniAdi_TBox = new System.Windows.Forms.TextBox();
            this.VeriTabaniAdi_Lbl = new System.Windows.Forms.Label();
            this.KarakterKarsilastirma_Lbl = new System.Windows.Forms.Label();
            this.VeriTabaniniOlustur_Btn = new System.Windows.Forms.Button();
            this.SunucuAdi_PBox = new System.Windows.Forms.PictureBox();
            this.SunucuAdi_Lbl = new System.Windows.Forms.Label();
            this.KarakterSetleri_LV = new System.Windows.Forms.ListView();
            this.Iptal_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YeniVeriTabaniAdi_TBox
            // 
            this.YeniVeriTabaniAdi_TBox.Location = new System.Drawing.Point(130, 60);
            this.YeniVeriTabaniAdi_TBox.Name = "YeniVeriTabaniAdi_TBox";
            this.YeniVeriTabaniAdi_TBox.Size = new System.Drawing.Size(211, 20);
            this.YeniVeriTabaniAdi_TBox.TabIndex = 0;
            // 
            // VeriTabaniAdi_Lbl
            // 
            this.VeriTabaniAdi_Lbl.AutoSize = true;
            this.VeriTabaniAdi_Lbl.Location = new System.Drawing.Point(11, 60);
            this.VeriTabaniAdi_Lbl.Name = "VeriTabaniAdi_Lbl";
            this.VeriTabaniAdi_Lbl.Size = new System.Drawing.Size(79, 13);
            this.VeriTabaniAdi_Lbl.TabIndex = 2;
            this.VeriTabaniAdi_Lbl.Text = "Veri Tabanı Adı";
            // 
            // KarakterKarsilastirma_Lbl
            // 
            this.KarakterKarsilastirma_Lbl.AutoSize = true;
            this.KarakterKarsilastirma_Lbl.Location = new System.Drawing.Point(9, 99);
            this.KarakterKarsilastirma_Lbl.Name = "KarakterKarsilastirma_Lbl";
            this.KarakterKarsilastirma_Lbl.Size = new System.Drawing.Size(115, 13);
            this.KarakterKarsilastirma_Lbl.TabIndex = 3;
            this.KarakterKarsilastirma_Lbl.Text = "Karakter Karşılaştırması";
            // 
            // VeriTabaniniOlustur_Btn
            // 
            this.VeriTabaniniOlustur_Btn.Location = new System.Drawing.Point(130, 189);
            this.VeriTabaniniOlustur_Btn.Name = "VeriTabaniniOlustur_Btn";
            this.VeriTabaniniOlustur_Btn.Size = new System.Drawing.Size(123, 23);
            this.VeriTabaniniOlustur_Btn.TabIndex = 4;
            this.VeriTabaniniOlustur_Btn.Text = "Veri Tabanı Oluştur";
            this.VeriTabaniniOlustur_Btn.UseVisualStyleBackColor = true;
            this.VeriTabaniniOlustur_Btn.Click += new System.EventHandler(this.VeriTabaniniOlustur_Btn_Click);
            // 
            // SunucuAdi_PBox
            // 
            this.SunucuAdi_PBox.Image = global::SQLYonet.Properties.Resources.db_root24px;
            this.SunucuAdi_PBox.Location = new System.Drawing.Point(11, 6);
            this.SunucuAdi_PBox.Name = "SunucuAdi_PBox";
            this.SunucuAdi_PBox.Size = new System.Drawing.Size(27, 26);
            this.SunucuAdi_PBox.TabIndex = 7;
            this.SunucuAdi_PBox.TabStop = false;
            // 
            // SunucuAdi_Lbl
            // 
            this.SunucuAdi_Lbl.AutoSize = true;
            this.SunucuAdi_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SunucuAdi_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SunucuAdi_Lbl.Location = new System.Drawing.Point(43, 9);
            this.SunucuAdi_Lbl.Name = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.Size = new System.Drawing.Size(130, 20);
            this.SunucuAdi_Lbl.TabIndex = 6;
            this.SunucuAdi_Lbl.Text = "SunucuAdi_Lbl";
            this.SunucuAdi_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KarakterSetleri_LV
            // 
            this.KarakterSetleri_LV.Location = new System.Drawing.Point(131, 86);
            this.KarakterSetleri_LV.Name = "KarakterSetleri_LV";
            this.KarakterSetleri_LV.Size = new System.Drawing.Size(245, 97);
            this.KarakterSetleri_LV.TabIndex = 8;
            this.KarakterSetleri_LV.UseCompatibleStateImageBehavior = false;
            this.KarakterSetleri_LV.SelectedIndexChanged += new System.EventHandler(this.KarakterSetleri_LV_SelectedIndexChanged);
            // 
            // Iptal_Btn
            // 
            this.Iptal_Btn.Location = new System.Drawing.Point(259, 189);
            this.Iptal_Btn.Name = "Iptal_Btn";
            this.Iptal_Btn.Size = new System.Drawing.Size(123, 23);
            this.Iptal_Btn.TabIndex = 9;
            this.Iptal_Btn.Text = "İptal";
            this.Iptal_Btn.UseVisualStyleBackColor = true;
            this.Iptal_Btn.Click += new System.EventHandler(this.Iptal_Btn_Click);
            // 
            // f04_f03_VeriTabaniOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLYonet.Properties.Resources.formbg;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.Iptal_Btn);
            this.Controls.Add(this.KarakterSetleri_LV);
            this.Controls.Add(this.SunucuAdi_PBox);
            this.Controls.Add(this.SunucuAdi_Lbl);
            this.Controls.Add(this.VeriTabaniniOlustur_Btn);
            this.Controls.Add(this.KarakterKarsilastirma_Lbl);
            this.Controls.Add(this.VeriTabaniAdi_Lbl);
            this.Controls.Add(this.YeniVeriTabaniAdi_TBox);
            this.Name = "f04_f03_VeriTabaniOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f04_f03_VeriTabaniOlustur";
            this.Load += new System.EventHandler(this.f04_f03_VeriTabaniOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SunucuAdi_PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YeniVeriTabaniAdi_TBox;
        private System.Windows.Forms.Label VeriTabaniAdi_Lbl;
        private System.Windows.Forms.Label KarakterKarsilastirma_Lbl;
        private System.Windows.Forms.Button VeriTabaniniOlustur_Btn;
        private System.Windows.Forms.PictureBox SunucuAdi_PBox;
        private System.Windows.Forms.Label SunucuAdi_Lbl;
        private System.Windows.Forms.ListView KarakterSetleri_LV;
        private System.Windows.Forms.Button Iptal_Btn;
    }
}