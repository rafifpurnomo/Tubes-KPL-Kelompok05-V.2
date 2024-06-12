namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class TambahAnggotaPerpus
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            tbNoAnggota = new TextBox();
            tbNama = new TextBox();
            tbNoTelpon = new TextBox();
            buttonSimpan = new Button();
            label3 = new Label();
            label7 = new Label();
            tbPassword = new TextBox();
            tbConfirmPass = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 131);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "No Anggota";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 178);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 315);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "No Telpon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 82);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 7;
            // 
            // tbNoAnggota
            // 
            tbNoAnggota.Location = new Point(255, 124);
            tbNoAnggota.Name = "tbNoAnggota";
            tbNoAnggota.Size = new Size(318, 27);
            tbNoAnggota.TabIndex = 8;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(255, 171);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(318, 27);
            tbNama.TabIndex = 10;
            // 
            // tbNoTelpon
            // 
            tbNoTelpon.Location = new Point(255, 308);
            tbNoTelpon.Name = "tbNoTelpon";
            tbNoTelpon.Size = new Size(318, 27);
            tbNoTelpon.TabIndex = 11;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(615, 388);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(94, 29);
            buttonSimpan.TabIndex = 13;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 225);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 270);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 15;
            label7.Text = "Konfirmasi Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(255, 218);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(318, 27);
            tbPassword.TabIndex = 16;
            // 
            // tbConfirmPass
            // 
            tbConfirmPass.Location = new Point(255, 263);
            tbConfirmPass.Name = "tbConfirmPass";
            tbConfirmPass.Size = new Size(318, 27);
            tbConfirmPass.TabIndex = 17;
            // 
            // TambahAnggotaPerpus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbConfirmPass);
            Controls.Add(tbPassword);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(buttonSimpan);
            Controls.Add(tbNoTelpon);
            Controls.Add(tbNama);
            Controls.Add(tbNoAnggota);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "TambahAnggotaPerpus";
            Text = "TambahAnggotaPerpus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private TextBox tbNoAnggota;
        private TextBox tbNama;
        private TextBox tbNoTelpon;
        private Button buttonSimpan;
        private Label label3;
        private Label label7;
        private TextBox tbPassword;
        private TextBox tbConfirmPass;
    }
}