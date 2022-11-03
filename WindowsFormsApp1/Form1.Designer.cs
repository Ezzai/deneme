namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbx_Ad = new System.Windows.Forms.TextBox();
            this.tbx_Fiyat = new System.Windows.Forms.TextBox();
            this.tbx_yemekKategoriId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_KategoriAd = new System.Windows.Forms.TextBox();
            this.tbx_KategoriId = new System.Windows.Forms.TextBox();
            this.btn_YemekEkle = new System.Windows.Forms.Button();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_yazdir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Id
            // 
            this.tbx_Id.Location = new System.Drawing.Point(110, 62);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(100, 22);
            this.tbx_Id.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbx_Ad
            // 
            this.tbx_Ad.Location = new System.Drawing.Point(110, 119);
            this.tbx_Ad.Name = "tbx_Ad";
            this.tbx_Ad.Size = new System.Drawing.Size(100, 22);
            this.tbx_Ad.TabIndex = 2;
            // 
            // tbx_Fiyat
            // 
            this.tbx_Fiyat.Location = new System.Drawing.Point(110, 198);
            this.tbx_Fiyat.Name = "tbx_Fiyat";
            this.tbx_Fiyat.Size = new System.Drawing.Size(100, 22);
            this.tbx_Fiyat.TabIndex = 3;
            // 
            // tbx_yemekKategoriId
            // 
            this.tbx_yemekKategoriId.Location = new System.Drawing.Point(110, 257);
            this.tbx_yemekKategoriId.Name = "tbx_yemekKategoriId";
            this.tbx_yemekKategoriId.Size = new System.Drawing.Size(100, 22);
            this.tbx_yemekKategoriId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "kategoriId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kategori Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategori Id";
            // 
            // tbx_KategoriAd
            // 
            this.tbx_KategoriAd.Location = new System.Drawing.Point(792, 190);
            this.tbx_KategoriAd.Name = "tbx_KategoriAd";
            this.tbx_KategoriAd.Size = new System.Drawing.Size(100, 22);
            this.tbx_KategoriAd.TabIndex = 10;
            // 
            // tbx_KategoriId
            // 
            this.tbx_KategoriId.Location = new System.Drawing.Point(792, 133);
            this.tbx_KategoriId.Name = "tbx_KategoriId";
            this.tbx_KategoriId.Size = new System.Drawing.Size(100, 22);
            this.tbx_KategoriId.TabIndex = 9;
            // 
            // btn_YemekEkle
            // 
            this.btn_YemekEkle.Location = new System.Drawing.Point(110, 330);
            this.btn_YemekEkle.Name = "btn_YemekEkle";
            this.btn_YemekEkle.Size = new System.Drawing.Size(110, 22);
            this.btn_YemekEkle.TabIndex = 13;
            this.btn_YemekEkle.Text = "yemek ekle";
            this.btn_YemekEkle.UseVisualStyleBackColor = true;
            this.btn_YemekEkle.Click += new System.EventHandler(this.btn_YemekEkle_Click);
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.Location = new System.Drawing.Point(792, 236);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(104, 22);
            this.btn_kategoriEkle.TabIndex = 14;
            this.btn_kategoriEkle.Text = "kategori ekle";
            this.btn_kategoriEkle.UseVisualStyleBackColor = true;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_kategoriEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(-2, 358);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(577, 180);
            this.listBox1.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(610, 358);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(495, 180);
            this.listBox2.TabIndex = 16;
            // 
            // lbl_yazdir
            // 
            this.lbl_yazdir.AutoSize = true;
            this.lbl_yazdir.Location = new System.Drawing.Point(37, 583);
            this.lbl_yazdir.Name = "lbl_yazdir";
            this.lbl_yazdir.Size = new System.Drawing.Size(64, 16);
            this.lbl_yazdir.TabIndex = 17;
            this.lbl_yazdir.Text = "lbl_yazdir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 779);
            this.Controls.Add(this.lbl_yazdir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_kategoriEkle);
            this.Controls.Add(this.btn_YemekEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_KategoriAd);
            this.Controls.Add(this.tbx_KategoriId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_yemekKategoriId);
            this.Controls.Add(this.tbx_Fiyat);
            this.Controls.Add(this.tbx_Ad);
            this.Controls.Add(this.tbx_Id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbx_Ad;
        private System.Windows.Forms.TextBox tbx_Fiyat;
        private System.Windows.Forms.TextBox tbx_yemekKategoriId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_KategoriAd;
        private System.Windows.Forms.TextBox tbx_KategoriId;
        private System.Windows.Forms.Button btn_YemekEkle;
        private System.Windows.Forms.Button btn_kategoriEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_yazdir;
    }
}

