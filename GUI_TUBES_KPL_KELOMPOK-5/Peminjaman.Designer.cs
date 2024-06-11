namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class Peminjaman
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
            dataGridView1 = new DataGridView();
            KodeBuku = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            TahunTerbit = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Pinjam = new Button();
            Keluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, Judul, Penulis, TahunTerbit, Stok });
            dataGridView1.Location = new Point(110, 171);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1100, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "Kode Buku";
            KodeBuku.MinimumWidth = 6;
            KodeBuku.Name = "KodeBuku";
            KodeBuku.Width = 125;
            // 
            // Judul
            // 
            Judul.HeaderText = "Judul";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
            Judul.Width = 125;
            // 
            // Penulis
            // 
            Penulis.HeaderText = "Penulis";
            Penulis.MinimumWidth = 6;
            Penulis.Name = "Penulis";
            Penulis.Width = 125;
            // 
            // TahunTerbit
            // 
            TahunTerbit.HeaderText = "Tahun Terbit";
            TahunTerbit.MinimumWidth = 6;
            TahunTerbit.Name = "TahunTerbit";
            TahunTerbit.Width = 125;
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            Stok.Width = 125;
            // 
            // Pinjam
            // 
            Pinjam.Location = new Point(814, 600);
            Pinjam.Margin = new Padding(5);
            Pinjam.Name = "Pinjam";
            Pinjam.Size = new Size(153, 46);
            Pinjam.TabIndex = 1;
            Pinjam.Text = "Pinjam";
            Pinjam.UseVisualStyleBackColor = true;
            // 
            // Keluar
            // 
            Keluar.Location = new Point(1086, 597);
            Keluar.Margin = new Padding(5);
            Keluar.Name = "Keluar";
            Keluar.Size = new Size(153, 46);
            Keluar.TabIndex = 2;
            Keluar.Text = "Keluar";
            Keluar.UseVisualStyleBackColor = true;
            // 
            // Peminjaman
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(Keluar);
            Controls.Add(Pinjam);
            Controls.Add(dataGridView1);
            Margin = new Padding(5);
            Name = "Peminjaman";
            Text = "Form2";
            Load += Peminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn TahunTerbit;
        private DataGridViewTextBoxColumn Stok;
        private Button Pinjam;
        private Button Keluar;
    }
}