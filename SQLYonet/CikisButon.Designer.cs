namespace SQLYonet
{
    partial class CikisButon
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.BackgroundImage = global::SQLYonet.Properties.Resources.formexit;
            this.Btn_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cikis.Location = new System.Drawing.Point(3, 3);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(24, 24);
            this.Btn_Cikis.TabIndex = 0;
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // CikisButon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Cikis);
            this.Name = "CikisButon";
            this.Size = new System.Drawing.Size(31, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cikis;
    }
}
