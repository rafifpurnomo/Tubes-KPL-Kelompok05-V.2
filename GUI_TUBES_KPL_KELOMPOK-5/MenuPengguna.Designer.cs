namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class MenuPengguna
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
            pinjamBuku = new Button();
            daftarPinjaman = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(217, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 89);
            label1.TabIndex = 0;
            label1.Text = "PerpusGo";
            // 
            // pinjamBuku
            // 
            pinjamBuku.Location = new Point(154, 197);
            pinjamBuku.Name = "pinjamBuku";
            pinjamBuku.Size = new Size(205, 85);
            pinjamBuku.TabIndex = 1;
            pinjamBuku.Text = "Pinjam Buku";
            pinjamBuku.UseVisualStyleBackColor = true;
            pinjamBuku.Click += button1_Click;
            // 
            // daftarPinjaman
            // 
            daftarPinjaman.Location = new Point(415, 197);
            daftarPinjaman.Name = "daftarPinjaman";
            daftarPinjaman.Size = new Size(205, 85);
            daftarPinjaman.TabIndex = 3;
            daftarPinjaman.Text = "Daftar Pinjaman";
            daftarPinjaman.UseVisualStyleBackColor = true;
            daftarPinjaman.Click += daftarPinjaman_Click;
            // 
            // MenuPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(daftarPinjaman);
            Controls.Add(pinjamBuku);
            Controls.Add(label1);
            Name = "MenuPengguna";
            Text = "MenuPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button pinjamBuku;
        private Button daftarPinjaman;
    }
}