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
            tableDaftarBuku = new DataGridView();
            KodeBuku = new DataGridViewTextBoxColumn();
            Judul = new DataGridViewTextBoxColumn();
            Penulis = new DataGridViewTextBoxColumn();
            TahunTerbit = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Pinjam = new Button();
            kembaliBTN = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableDaftarBuku).BeginInit();
            SuspendLayout();
            // 
            // tableDaftarBuku
            // 
            tableDaftarBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDaftarBuku.Columns.AddRange(new DataGridViewColumn[] { KodeBuku, Judul, Penulis, TahunTerbit, Stok });
            tableDaftarBuku.Location = new Point(44, 107);
            tableDaftarBuku.Name = "tableDaftarBuku";
            tableDaftarBuku.RowHeadersWidth = 51;
            tableDaftarBuku.Size = new Size(681, 188);
            tableDaftarBuku.TabIndex = 0;
            tableDaftarBuku.CellContentClick += dataGridView1_CellContentClick;
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
            Pinjam.Location = new Point(501, 375);
            Pinjam.Name = "Pinjam";
            Pinjam.Size = new Size(94, 29);
            Pinjam.TabIndex = 1;
            Pinjam.Text = "Pinjam";
            Pinjam.UseVisualStyleBackColor = true;
            // 
            // kembaliBTN
            // 
            kembaliBTN.Location = new Point(668, 373);
            kembaliBTN.Name = "kembaliBTN";
            kembaliBTN.Size = new Size(94, 29);
            kembaliBTN.TabIndex = 2;
            kembaliBTN.Text = "kembali";
            kembaliBTN.UseVisualStyleBackColor = true;
            kembaliBTN.Click += kembaliBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(20, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 46);
            label1.TabIndex = 3;
            label1.Text = "PerpusGO";
            // 
            // Peminjaman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(kembaliBTN);
            Controls.Add(Pinjam);
            Controls.Add(tableDaftarBuku);
            Name = "Peminjaman";
            Text = "Form2";
            Load += Peminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)tableDaftarBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableDaftarBuku;
        private DataGridViewTextBoxColumn KodeBuku;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Penulis;
        private DataGridViewTextBoxColumn TahunTerbit;
        private DataGridViewTextBoxColumn Stok;
        private Button Pinjam;
        private Button kembaliBTN;
        private Label label1;
    }
}