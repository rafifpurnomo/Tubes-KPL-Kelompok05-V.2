﻿namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class TambahBuku
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
            PerpusGO = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnTambah = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // PerpusGO
            // 
            PerpusGO.AutoSize = true;
            PerpusGO.Font = new Font("Segoe UI Semibold", 40.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PerpusGO.ForeColor = SystemColors.ActiveCaption;
            PerpusGO.Location = new Point(568, 52);
            PerpusGO.Name = "PerpusGO";
            PerpusGO.Size = new Size(544, 142);
            PerpusGO.TabIndex = 0;
            PerpusGO.Text = "PerpusGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(380, 280);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 1;
            label2.Text = "Kode";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(380, 380);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 2;
            label3.Text = "Judul";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(380, 480);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 3;
            label4.Text = "Sinopsis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(380, 580);
            label5.Name = "label5";
            label5.Size = new Size(90, 32);
            label5.TabIndex = 4;
            label5.Text = "Penulis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(380, 680);
            label6.Name = "label6";
            label6.Size = new Size(149, 32);
            label6.TabIndex = 5;
            label6.Text = "Tahun Terbit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(380, 780);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 6;
            label7.Text = "Stok";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(568, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 39);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 377);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(544, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(568, 477);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(544, 39);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(568, 577);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(544, 39);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(568, 677);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(544, 39);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(568, 777);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(544, 39);
            textBox6.TabIndex = 12;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(962, 880);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(150, 46);
            btnTambah.TabIndex = 13;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(568, 880);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Kembali";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TambahBuku
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 1079);
            Controls.Add(btnCancel);
            Controls.Add(btnTambah);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PerpusGO);
            Name = "TambahBuku";
            Text = "TambahBuku";
            Load += TambahBuku_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PerpusGO;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnTambah;
        private Button btnCancel;
    }
}