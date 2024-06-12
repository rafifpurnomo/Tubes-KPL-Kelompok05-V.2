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
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(353, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(532, 145);
            label1.TabIndex = 0;
            label1.Text = "PerpusGo";
            // 
            // pinjamBuku
            // 
            pinjamBuku.Location = new Point(250, 315);
            pinjamBuku.Margin = new Padding(5);
            pinjamBuku.Name = "pinjamBuku";
            pinjamBuku.Size = new Size(333, 136);
            pinjamBuku.TabIndex = 1;
            pinjamBuku.Text = "Pinjam Buku";
            pinjamBuku.UseVisualStyleBackColor = true;
            pinjamBuku.Click += button1_Click;
            // 
            // daftarPinjaman
            // 
            daftarPinjaman.Location = new Point(674, 315);
            daftarPinjaman.Margin = new Padding(5);
            daftarPinjaman.Name = "daftarPinjaman";
            daftarPinjaman.Size = new Size(333, 136);
            daftarPinjaman.TabIndex = 3;
            daftarPinjaman.Text = "Daftar Pinjaman";
            daftarPinjaman.UseVisualStyleBackColor = true;
            daftarPinjaman.Click += daftarPinjaman_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 14);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(468, 509);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(333, 136);
            button1.TabIndex = 5;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // MenuPengguna
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(daftarPinjaman);
            Controls.Add(pinjamBuku);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "MenuPengguna";
            Text = "MenuPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button pinjamBuku;
        private Button daftarPinjaman;
        private Label label2;
        private Button button1;
    }
}