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
            namaUserDisplay = new Label();
            pinjamBukuBTN = new Button();
            logoutBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(184, 31);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // namaUserDisplay
            // 
            namaUserDisplay.AutoSize = true;
            namaUserDisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaUserDisplay.Location = new Point(220, 25);
            namaUserDisplay.Name = "namaUserDisplay";
            namaUserDisplay.Size = new Size(117, 31);
            namaUserDisplay.TabIndex = 1;
            namaUserDisplay.Text = "namaUser";
            // 
            // pinjamBukuBTN
            // 
            pinjamBukuBTN.Location = new Point(30, 86);
            pinjamBukuBTN.Name = "pinjamBukuBTN";
            pinjamBukuBTN.Size = new Size(126, 29);
            pinjamBukuBTN.TabIndex = 2;
            pinjamBukuBTN.Text = "Pinjam Buku";
            pinjamBukuBTN.UseVisualStyleBackColor = true;
            pinjamBukuBTN.Click += pinjamBukuBTN_Click;
            // 
            // logoutBTN
            // 
            logoutBTN.Location = new Point(30, 134);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(126, 29);
            logoutBTN.TabIndex = 3;
            logoutBTN.Text = "Log Out";
            logoutBTN.UseVisualStyleBackColor = true;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // MenuPengguna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutBTN);
            Controls.Add(pinjamBukuBTN);
            Controls.Add(namaUserDisplay);
            Controls.Add(label1);
            Name = "MenuPengguna";
            Text = "MenuPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label namaUserDisplay;
        private Button pinjamBukuBTN;
        private Button logoutBTN;
    }
}