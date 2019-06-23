namespace SQLYonet
{
    partial class f01_GirisEkrani
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DemoGiris_Btn = new System.Windows.Forms.Button();
            this.dilSeciciKontrol1 = new SQLYonet.DilSeciciKontrol();
            this.Yapilacaklar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hesap Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(22, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 58);
            this.panel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tekrar Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // DemoGiris_Btn
            // 
            this.DemoGiris_Btn.Location = new System.Drawing.Point(132, 211);
            this.DemoGiris_Btn.Name = "DemoGiris_Btn";
            this.DemoGiris_Btn.Size = new System.Drawing.Size(126, 23);
            this.DemoGiris_Btn.TabIndex = 9;
            this.DemoGiris_Btn.Text = "Demo Giriş";
            this.DemoGiris_Btn.UseVisualStyleBackColor = true;
            this.DemoGiris_Btn.Click += new System.EventHandler(this.DemoGiris_Btn_Click);
            // 
            // dilSeciciKontrol1
            // 
            this.dilSeciciKontrol1.Location = new System.Drawing.Point(276, 0);
            this.dilSeciciKontrol1.Name = "dilSeciciKontrol1";
            this.dilSeciciKontrol1.Size = new System.Drawing.Size(85, 23);
            this.dilSeciciKontrol1.TabIndex = 8;
            // 
            // Yapilacaklar
            // 
            this.Yapilacaklar.Location = new System.Drawing.Point(277, 239);
            this.Yapilacaklar.Name = "Yapilacaklar";
            this.Yapilacaklar.Size = new System.Drawing.Size(75, 23);
            this.Yapilacaklar.TabIndex = 10;
            this.Yapilacaklar.Text = "Yapılacaklar";
            this.Yapilacaklar.UseVisualStyleBackColor = true;
            this.Yapilacaklar.Click += new System.EventHandler(this.Yapilacaklar_Click);
            // 
            // f01_GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLYonet.Properties.Resources.formbg;
            this.ClientSize = new System.Drawing.Size(364, 274);
            this.Controls.Add(this.Yapilacaklar);
            this.Controls.Add(this.DemoGiris_Btn);
            this.Controls.Add(this.dilSeciciKontrol1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "f01_GirisEkrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.f01_GirisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private DilSeciciKontrol dilSeciciKontrol1;
        private System.Windows.Forms.Button DemoGiris_Btn;
        private System.Windows.Forms.Button Yapilacaklar;
    }
}

