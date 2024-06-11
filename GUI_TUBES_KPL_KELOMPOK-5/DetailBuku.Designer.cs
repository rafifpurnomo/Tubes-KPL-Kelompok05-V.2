namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class DetailBuku
    {
        private System.ComponentModel.IContainer components = null;

        // Add declarations for labels
        private System.Windows.Forms.Label labelKodeBuku;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.Label labelTahunTerbit;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Button buttonKeluar;

        // Dispose method

        private void InitializeComponent()
        {
            labelKodeBuku = new Label();
            labelJudul = new Label();
            labelPenulis = new Label();
            labelTahunTerbit = new Label();
            labelStok = new Label();
            buttonKeluar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Pinjam = new Button();
            SuspendLayout();
            // 
            // labelKodeBuku
            // 
            labelKodeBuku.AutoSize = true;
            labelKodeBuku.Location = new Point(235, 83);
            labelKodeBuku.Margin = new Padding(4, 0, 4, 0);
            labelKodeBuku.Name = "labelKodeBuku";
            labelKodeBuku.Size = new Size(80, 20);
            labelKodeBuku.TabIndex = 0;
            labelKodeBuku.Text = "Kode Buku";
            labelKodeBuku.Click += labelKodeBuku_Click;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(198, 123);
            labelJudul.Margin = new Padding(4, 0, 4, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(43, 20);
            labelJudul.TabIndex = 1;
            labelJudul.Text = "Judul";
            labelJudul.Click += labelJudul_Click;
            // 
            // labelPenulis
            // 
            labelPenulis.AutoSize = true;
            labelPenulis.Location = new Point(207, 163);
            labelPenulis.Margin = new Padding(4, 0, 4, 0);
            labelPenulis.Name = "labelPenulis";
            labelPenulis.Size = new Size(54, 20);
            labelPenulis.TabIndex = 2;
            labelPenulis.Text = "Penulis";
            // 
            // labelTahunTerbit
            // 
            labelTahunTerbit.AutoSize = true;
            labelTahunTerbit.Location = new Point(235, 203);
            labelTahunTerbit.Margin = new Padding(4, 0, 4, 0);
            labelTahunTerbit.Name = "labelTahunTerbit";
            labelTahunTerbit.Size = new Size(89, 20);
            labelTahunTerbit.TabIndex = 3;
            labelTahunTerbit.Text = "Tahun Terbit";
            labelTahunTerbit.Click += labelTahunTerbit_Click;
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.Location = new Point(183, 243);
            labelStok.Margin = new Padding(4, 0, 4, 0);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(38, 20);
            labelStok.TabIndex = 4;
            labelStok.Text = "Stok";
            // 
            // buttonKeluar
            // 
            buttonKeluar.Location = new Point(405, 353);
            buttonKeluar.Margin = new Padding(4, 5, 4, 5);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(100, 35);
            buttonKeluar.TabIndex = 5;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = true;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 6;
            label1.Text = "Detail Buku";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 7;
            label2.Text = "Kode Buku  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 123);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "Judul  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 163);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Penulis  :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 203);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Tahun Terbit  :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 243);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Stok  :";
            // 
            // Pinjam
            // 
            Pinjam.Location = new Point(188, 312);
            Pinjam.Name = "Pinjam";
            Pinjam.Size = new Size(94, 29);
            Pinjam.TabIndex = 12;
            Pinjam.Text = "Pinjam ";
            Pinjam.UseVisualStyleBackColor = true;
            Pinjam.Click += Pinjam_Click;
            // 
            // DetailBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 402);
            Controls.Add(Pinjam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonKeluar);
            Controls.Add(labelStok);
            Controls.Add(labelTahunTerbit);
            Controls.Add(labelPenulis);
            Controls.Add(labelJudul);
            Controls.Add(labelKodeBuku);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DetailBuku";
            Text = "DetailBuku";
            Load += DetailBuku_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Pinjam;
    }
}
