namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class DetailPengembalianBuku
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
            button1 = new Button();
            label_statusPengembalian = new Label();
            label_tenggatWaktu = new Label();
            label_tglPeminjaman = new Label();
            label_buku = new Label();
            label_nama = new Label();
            label_id = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(307, 408);
            button1.Name = "button1";
            button1.Size = new Size(149, 59);
            button1.TabIndex = 28;
            button1.Text = "Konfirmasi Pengembalian";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_statusPengembalian
            // 
            label_statusPengembalian.AutoSize = true;
            label_statusPengembalian.Location = new Point(432, 336);
            label_statusPengembalian.Name = "label_statusPengembalian";
            label_statusPengembalian.Size = new Size(50, 20);
            label_statusPengembalian.TabIndex = 27;
            label_statusPengembalian.Text = "label8";
            // 
            // label_tenggatWaktu
            // 
            label_tenggatWaktu.AutoSize = true;
            label_tenggatWaktu.Location = new Point(433, 288);
            label_tenggatWaktu.Name = "label_tenggatWaktu";
            label_tenggatWaktu.Size = new Size(50, 20);
            label_tenggatWaktu.TabIndex = 26;
            label_tenggatWaktu.Text = "label9";
            // 
            // label_tglPeminjaman
            // 
            label_tglPeminjaman.AutoSize = true;
            label_tglPeminjaman.Location = new Point(432, 243);
            label_tglPeminjaman.Name = "label_tglPeminjaman";
            label_tglPeminjaman.Size = new Size(58, 20);
            label_tglPeminjaman.TabIndex = 25;
            label_tglPeminjaman.Text = "label10";
            // 
            // label_buku
            // 
            label_buku.AutoSize = true;
            label_buku.Location = new Point(433, 197);
            label_buku.Name = "label_buku";
            label_buku.Size = new Size(58, 20);
            label_buku.TabIndex = 24;
            label_buku.Text = "label11";
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Location = new Point(432, 151);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(58, 20);
            label_nama.TabIndex = 23;
            label_nama.Text = "label12";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(432, 103);
            label_id.Name = "label_id";
            label_id.Size = new Size(58, 20);
            label_id.TabIndex = 22;
            label_id.Text = "label13";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 336);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 21;
            label7.Text = "Status ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 288);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 20;
            label6.Text = "Tenggat Waktu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 243);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 19;
            label5.Text = "Tgl Peminjaman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 197);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 18;
            label4.Text = "Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 17;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 103);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 16;
            label2.Text = "ID ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 10);
            label1.Name = "label1";
            label1.Size = new Size(342, 38);
            label1.TabIndex = 15;
            label1.Text = "Detail Peminjaman Buku";
            // 
            // DetailPengembalianBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(button1);
            Controls.Add(label_statusPengembalian);
            Controls.Add(label_tenggatWaktu);
            Controls.Add(label_tglPeminjaman);
            Controls.Add(label_buku);
            Controls.Add(label_nama);
            Controls.Add(label_id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailPengembalianBuku";
            Text = "DetailPengembalianBuku";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_statusPengembalian;
        private Label label_tenggatWaktu;
        private Label label_tglPeminjaman;
        private Label label_buku;
        private Label label_nama;
        private Label label_id;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}