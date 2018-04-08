namespace Ciftciler
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ListeGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.mtb_DosyaNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_TCNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Soyisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Mahalle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RichTxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 619);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_ListeGetir
            // 
            this.btn_ListeGetir.Location = new System.Drawing.Point(226, 23);
            this.btn_ListeGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ListeGetir.Name = "btn_ListeGetir";
            this.btn_ListeGetir.Size = new System.Drawing.Size(155, 26);
            this.btn_ListeGetir.TabIndex = 1;
            this.btn_ListeGetir.Text = "Liste Getir";
            this.btn_ListeGetir.UseVisualStyleBackColor = true;
            this.btn_ListeGetir.Click += new System.EventHandler(this.btn_ListeGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya Numarası";
            // 
            // txt_Isim
            // 
            this.txt_Isim.Location = new System.Drawing.Point(153, 146);
            this.txt_Isim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Isim.Name = "txt_Isim";
            this.txt_Isim.Size = new System.Drawing.Size(112, 24);
            this.txt_Isim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(149, 32);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(23, 18);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "---";
            // 
            // mtb_DosyaNumarasi
            // 
            this.mtb_DosyaNumarasi.Location = new System.Drawing.Point(153, 65);
            this.mtb_DosyaNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_DosyaNumarasi.Mask = "0000";
            this.mtb_DosyaNumarasi.Name = "mtb_DosyaNumarasi";
            this.mtb_DosyaNumarasi.Size = new System.Drawing.Size(112, 24);
            this.mtb_DosyaNumarasi.TabIndex = 0;
            this.mtb_DosyaNumarasi.ValidatingType = typeof(int);
            this.mtb_DosyaNumarasi.Click += new System.EventHandler(this.mtb_DosyaNumarasi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC Numarası";
            // 
            // mtb_TCNumarasi
            // 
            this.mtb_TCNumarasi.Location = new System.Drawing.Point(153, 104);
            this.mtb_TCNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_TCNumarasi.Mask = "00000000000";
            this.mtb_TCNumarasi.Name = "mtb_TCNumarasi";
            this.mtb_TCNumarasi.Size = new System.Drawing.Size(112, 24);
            this.mtb_TCNumarasi.TabIndex = 1;
            this.mtb_TCNumarasi.ValidatingType = typeof(int);
            this.mtb_TCNumarasi.Click += new System.EventHandler(this.mtb_TCNumarasi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "İsim";
            // 
            // txt_Soyisim
            // 
            this.txt_Soyisim.Location = new System.Drawing.Point(153, 184);
            this.txt_Soyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Soyisim.Name = "txt_Soyisim";
            this.txt_Soyisim.Size = new System.Drawing.Size(112, 24);
            this.txt_Soyisim.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soyisim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mahalle";
            // 
            // cmb_Mahalle
            // 
            this.cmb_Mahalle.FormattingEnabled = true;
            this.cmb_Mahalle.Items.AddRange(new object[] {
            "ALACALAR",
            "ARMUTLU ",
            "BESTAM ",
            "ÇAKIRLI",
            "ÇUKUR ",
            "ESENLI",
            "FATIH ",
            "HISARCIK",
            "KARAMANLI",
            "KAYABASI ",
            "KOYUNCULU",
            "KUTLULAR ",
            "KÜÇÜKYAKA",
            "ORTAKÖY ",
            "PELITÖZÜ",
            "SAGLIK ",
            "SARIYAR",
            "SEFALIK",
            "TOYGAR ",
            "UZUNDERE",
            "ZAFERIMILLI"});
            this.cmb_Mahalle.Location = new System.Drawing.Point(153, 223);
            this.cmb_Mahalle.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Mahalle.Name = "cmb_Mahalle";
            this.cmb_Mahalle.Size = new System.Drawing.Size(135, 26);
            this.cmb_Mahalle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tarih";
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(149, 259);
            this.lbl_Tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(23, 18);
            this.lbl_Tarih.TabIndex = 5;
            this.lbl_Tarih.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Açıklama";
            // 
            // RichTxt_Aciklama
            // 
            this.RichTxt_Aciklama.Location = new System.Drawing.Point(153, 293);
            this.RichTxt_Aciklama.Margin = new System.Windows.Forms.Padding(4);
            this.RichTxt_Aciklama.Name = "RichTxt_Aciklama";
            this.RichTxt_Aciklama.Size = new System.Drawing.Size(222, 76);
            this.RichTxt_Aciklama.TabIndex = 5;
            this.RichTxt_Aciklama.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RichTxt_Aciklama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Mahalle);
            this.groupBox1.Controls.Add(this.txt_Isim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Soyisim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.mtb_TCNumarasi);
            this.groupBox1.Controls.Add(this.lbl_Tarih);
            this.groupBox1.Controls.Add(this.mtb_DosyaNumarasi);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(388, 378);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(409, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1069, 644);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btn_guncelle);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.btn_Temizle);
            this.groupBox3.Controls.Add(this.btn_ListeGetir);
            this.groupBox3.Location = new System.Drawing.Point(13, 400);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(388, 248);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(4, 160);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(4, 112);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(135, 28);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(4, 66);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 28);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(4, 21);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(135, 28);
            this.btn_Temizle.TabIndex = 2;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ListeGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.MaskedTextBox mtb_DosyaNumarasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_TCNumarasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Soyisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Mahalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox RichTxt_Aciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btnSil;
    }
}

