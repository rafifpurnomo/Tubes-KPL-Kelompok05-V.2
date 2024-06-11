namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class DaftarBuku
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
            JUDUL = new Label();
            dataGridView1 = new DataGridView();
            KodeBuku = new DataGridViewTextBoxColumn();
            JudulBuku = new DataGridViewTextBoxColumn();
            SinopsisBuku = new DataGridViewTextBoxColumn();
            PenulisBuku = new DataGridViewTextBoxColumn();
            TahunTerbitBuku = new DataGridViewTextBoxColumn();
            StokBuku = new DataGridViewTextBoxColumn();
            BTNhapus = new Button();
            BTNtambah = new Button();
            BTNedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // JUDUL
            // 
            JUDUL.AutoSize = true;
            JUDUL.Font = new Font("Segoe UI Semibold", 40.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JUDUL.ForeColor = SystemColors.ActiveCaption;
            JUDUL.Location = new Point(568, 52);
            JUDUL.Name = "JUDUL";
            JUDUL.Size = new Size(544, 142);
            JUDUL.TabIndex = 0;
            JUDUL.Text = "PerpusGO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, JudulBuku, SinopsisBuku, PenulisBuku, TahunTerbitBuku, StokBuku });
            dataGridView1.Location = new Point(167, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1284, 413);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // KodeBuku
            // 
            KodeBuku.HeaderText = "Kode";
            KodeBuku.MinimumWidth = 10;
            KodeBuku.Name = "KodeBuku";
            KodeBuku.Width = 200;
            // 
            // JudulBuku
            // 
            JudulBuku.HeaderText = "Judul";
            JudulBuku.MinimumWidth = 10;
            JudulBuku.Name = "JudulBuku";
            JudulBuku.Width = 200;
            // 
            // SinopsisBuku
            // 
            SinopsisBuku.HeaderText = "Sinopsis";
            SinopsisBuku.MinimumWidth = 10;
            SinopsisBuku.Name = "SinopsisBuku";
            SinopsisBuku.Width = 200;
            // 
            // PenulisBuku
            // 
            PenulisBuku.HeaderText = "Penulis";
            PenulisBuku.MinimumWidth = 10;
            PenulisBuku.Name = "PenulisBuku";
            PenulisBuku.Width = 200;
            // 
            // TahunTerbitBuku
            // 
            TahunTerbitBuku.HeaderText = "Tahun Terbit";
            TahunTerbitBuku.MinimumWidth = 10;
            TahunTerbitBuku.Name = "TahunTerbitBuku";
            TahunTerbitBuku.Width = 200;
            // 
            // StokBuku
            // 
            StokBuku.HeaderText = "Stok";
            StokBuku.MinimumWidth = 10;
            StokBuku.Name = "StokBuku";
            StokBuku.Width = 200;
            // 
            // BTNhapus
            // 
            BTNhapus.Location = new Point(1301, 838);
            BTNhapus.Name = "BTNhapus";
            BTNhapus.Size = new Size(150, 46);
            BTNhapus.TabIndex = 2;
            BTNhapus.Text = "Hapus";
            BTNhapus.UseVisualStyleBackColor = true;
            BTNhapus.Click += BTNhapus_Click;
            // 
            // BTNtambah
            // 
            BTNtambah.Location = new Point(1145, 838);
            BTNtambah.Name = "BTNtambah";
            BTNtambah.Size = new Size(150, 46);
            BTNtambah.TabIndex = 3;
            BTNtambah.Text = "Tambah";
            BTNtambah.UseVisualStyleBackColor = true;
            BTNtambah.Click += BTNtambah_Click;
            // 
            // BTNedit
            // 
            BTNedit.Location = new Point(989, 838);
            BTNedit.Name = "BTNedit";
            BTNedit.Size = new Size(150, 46);
            BTNedit.TabIndex = 5;
            BTNedit.Text = "Edit";
            BTNedit.UseVisualStyleBackColor = true;
            BTNedit.Click += BTNedit_Click;
            // 
            // DaftarBuku
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 1079);
            Controls.Add(BTNedit);
            Controls.Add(BTNtambah);
            Controls.Add(BTNhapus);
            Controls.Add(dataGridView1);
            Controls.Add(JUDUL);
            Name = "DaftarBuku";
            Text = "DaftarBuku";
            Load += DaftarBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JUDUL;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn JudulBuku;
        private DataGridViewTextBoxColumn SinopsisBuku;
        private DataGridViewTextBoxColumn PenulisBuku;
        private DataGridViewTextBoxColumn TahunTerbitBuku;
        private DataGridViewTextBoxColumn StokBuku;
        private Button BTNhapus;
        private Button BTNtambah;
        private Button BTNedit;
    }
}