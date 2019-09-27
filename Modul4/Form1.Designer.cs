namespace Modul4
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_judul = new System.Windows.Forms.Label();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.listBuku = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.button_cari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_pinjam = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.date_pinjam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pinjam = new System.Windows.Forms.Button();
            this.btn_pengembalian = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_kembali = new System.Windows.Forms.DateTimePicker();
            this.comboBox_mhs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(16, 106);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id Buku";
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(16, 132);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(60, 13);
            this.label_judul.TabIndex = 1;
            this.label_judul.Text = "Judul Buku";
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(16, 158);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(59, 13);
            this.label_pengarang.TabIndex = 2;
            this.label_pengarang.Text = "Pengarang";
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(16, 181);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(40, 13);
            this.label_jumlah.TabIndex = 3;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(138, 103);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(137, 20);
            this.text_id.TabIndex = 4;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(138, 129);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(137, 20);
            this.text_judul.TabIndex = 5;
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(138, 155);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(137, 20);
            this.text_pengarang.TabIndex = 6;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(138, 178);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(137, 20);
            this.text_jumlah.TabIndex = 7;
            // 
            // button_tambah
            // 
            this.button_tambah.Location = new System.Drawing.Point(11, 207);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(75, 23);
            this.button_tambah.TabIndex = 10;
            this.button_tambah.Text = "Tambah";
            this.button_tambah.UseVisualStyleBackColor = true;
            this.button_tambah.Click += new System.EventHandler(this.Button_tambah_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(93, 207);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.Location = new System.Drawing.Point(175, 207);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(75, 23);
            this.button_hapus.TabIndex = 12;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.Button_hapus_Click);
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBuku.HideSelection = false;
            this.listBuku.Location = new System.Drawing.Point(326, 90);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(460, 174);
            this.listBuku.TabIndex = 13;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.SelectedIndexChanged += new System.EventHandler(this.ListBuku_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Buku";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul Buku";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pengarang";
            this.columnHeader3.Width = 181;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            this.columnHeader4.Width = 55;
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(12, 60);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(211, 20);
            this.textBox_cari.TabIndex = 14;
            // 
            // button_cari
            // 
            this.button_cari.Location = new System.Drawing.Point(229, 60);
            this.button_cari.Name = "button_cari";
            this.button_cari.Size = new System.Drawing.Size(75, 23);
            this.button_cari.TabIndex = 15;
            this.button_cari.Text = "Search";
            this.button_cari.UseVisualStyleBackColor = true;
            this.button_cari.Click += new System.EventHandler(this.Button_cari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Peminjaman Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Daftar Buku yang di Pinjam";
            // 
            // list_pinjam
            // 
            this.list_pinjam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.list_pinjam.HideSelection = false;
            this.list_pinjam.Location = new System.Drawing.Point(329, 292);
            this.list_pinjam.Name = "list_pinjam";
            this.list_pinjam.Size = new System.Drawing.Size(560, 178);
            this.list_pinjam.TabIndex = 18;
            this.list_pinjam.UseCompatibleStateImageBehavior = false;
            this.list_pinjam.View = System.Windows.Forms.View.Details;
            this.list_pinjam.SelectedIndexChanged += new System.EventHandler(this.List_pinjam_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nama Mahasiswa";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Judul Buku";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pengarang";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Jumlah";
            this.columnHeader8.Width = 51;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            this.columnHeader9.Width = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 20;
            // 
            // date_pinjam
            // 
            this.date_pinjam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pinjam.Location = new System.Drawing.Point(183, 297);
            this.date_pinjam.Name = "date_pinjam";
            this.date_pinjam.Size = new System.Drawing.Size(137, 20);
            this.date_pinjam.TabIndex = 21;
            this.date_pinjam.Value = new System.DateTime(2019, 9, 27, 23, 7, 5, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // btn_pinjam
            // 
            this.btn_pinjam.Enabled = false;
            this.btn_pinjam.Location = new System.Drawing.Point(57, 331);
            this.btn_pinjam.Name = "btn_pinjam";
            this.btn_pinjam.Size = new System.Drawing.Size(88, 23);
            this.btn_pinjam.TabIndex = 23;
            this.btn_pinjam.Text = "Pinjam Buku";
            this.btn_pinjam.UseVisualStyleBackColor = true;
            this.btn_pinjam.Click += new System.EventHandler(this.Btn_pinjam_Click);
            // 
            // btn_pengembalian
            // 
            this.btn_pengembalian.Enabled = false;
            this.btn_pengembalian.Location = new System.Drawing.Point(57, 447);
            this.btn_pengembalian.Name = "btn_pengembalian";
            this.btn_pengembalian.Size = new System.Drawing.Size(88, 23);
            this.btn_pengembalian.TabIndex = 24;
            this.btn_pengembalian.Text = "Pengembalian Buku";
            this.btn_pengembalian.UseVisualStyleBackColor = true;
            this.btn_pengembalian.Click += new System.EventHandler(this.Btn_pengembalian_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Peminjaman Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pengembalian Buku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nama Mahasiswa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tanggal Pengembalian";
            // 
            // date_kembali
            // 
            this.date_kembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_kembali.Location = new System.Drawing.Point(183, 416);
            this.date_kembali.Name = "date_kembali";
            this.date_kembali.Size = new System.Drawing.Size(137, 20);
            this.date_kembali.TabIndex = 28;
            // 
            // comboBox_mhs
            // 
            this.comboBox_mhs.FormattingEnabled = true;
            this.comboBox_mhs.Location = new System.Drawing.Point(183, 271);
            this.comboBox_mhs.Name = "comboBox_mhs";
            this.comboBox_mhs.Size = new System.Drawing.Size(137, 21);
            this.comboBox_mhs.TabIndex = 29;
            this.comboBox_mhs.SelectedIndexChanged += new System.EventHandler(this.ComboBox_mhs_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Daftar Buku";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 30;
            this.label10.Visible = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tgl Pinjam";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tgl Pengembalian";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ID";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 482);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_mhs);
            this.Controls.Add(this.date_kembali);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_pengembalian);
            this.Controls.Add(this.btn_pinjam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_pinjam);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_pinjam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cari);
            this.Controls.Add(this.textBox_cari);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_tambah);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modul 4 - 195150209111013";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button button_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_pinjam;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker date_pinjam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pinjam;
        private System.Windows.Forms.Button btn_pengembalian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_kembali;
        private System.Windows.Forms.ComboBox comboBox_mhs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

