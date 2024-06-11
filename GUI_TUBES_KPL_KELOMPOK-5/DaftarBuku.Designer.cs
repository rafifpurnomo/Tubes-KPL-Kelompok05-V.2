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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            KodeBuku = new DataGridViewTextBoxColumn();
            JudulBuku = new DataGridViewTextBoxColumn();
            SinopsisBuku = new DataGridViewTextBoxColumn();
            PenulisBuku = new DataGridViewTextBoxColumn();
            TahunTerbitBuku = new DataGridViewTextBoxColumn();
            StokBuku = new DataGridViewTextBoxColumn();
            BTNhapus = new Button();
            BTNtambah = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 40.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(367, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 89);
            label1.TabIndex = 0;
            label1.Text = "PerpusGo";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, JudulBuku, SinopsisBuku, PenulisBuku, TahunTerbitBuku, StokBuku });
            dataGridView1.Location = new Point(103, 201);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(790, 312);
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
            BTNhapus.Location = new Point(801, 524);
            BTNhapus.Margin = new Padding(2, 2, 2, 2);
            BTNhapus.Name = "BTNhapus";
            BTNhapus.Size = new Size(92, 29);
            BTNhapus.TabIndex = 2;
            BTNhapus.Text = "Hapus";
            BTNhapus.UseVisualStyleBackColor = true;
            // 
            // BTNtambah
            // 
            BTNtambah.Location = new Point(705, 524);
            BTNtambah.Margin = new Padding(2, 2, 2, 2);
            BTNtambah.Name = "BTNtambah";
            BTNtambah.Size = new Size(92, 29);
            BTNtambah.TabIndex = 3;
            BTNtambah.Text = "Tambah";
            BTNtambah.UseVisualStyleBackColor = true;
            BTNtambah.Click += BTNtambah_Click;
            // 
            // button1
            // 
            button1.Location = new Point(609, 524);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 29);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // DaftarBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 659);
            Controls.Add(button1);
            Controls.Add(BTNtambah);
            Controls.Add(BTNhapus);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DaftarBuku";
            Text = "DaftarBuku";
            Load += DaftarBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn JudulBuku;
        private DataGridViewTextBoxColumn SinopsisBuku;
        private DataGridViewTextBoxColumn PenulisBuku;
        private DataGridViewTextBoxColumn TahunTerbitBuku;
        private DataGridViewTextBoxColumn StokBuku;
        private Button BTNhapus;
        private Button BTNtambah;
        private Button button1;
    }
}