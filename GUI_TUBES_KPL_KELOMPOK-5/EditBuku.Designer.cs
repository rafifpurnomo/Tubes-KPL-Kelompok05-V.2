namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class EditBuku
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
            btnSave = new Button();
            btnCancel = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 40.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(568, 52);
            label1.Name = "label1";
            label1.Size = new Size(544, 142);
            label1.TabIndex = 0;
            label1.Text = "PerpusGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 280);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Kode Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 380);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "Judul Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 480);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 3;
            label4.Text = "Sinopsis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 580);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 4;
            label5.Text = "Penulis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 680);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 5;
            label6.Text = "Tahun Terbit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 780);
            label7.Name = "label7";
            label7.Size = new Size(151, 32);
            label7.TabIndex = 6;
            label7.Text = "Jumlah Buku";
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
            // btnSave
            // 
            btnSave.Location = new Point(962, 878);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 13;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Kembali";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(568, 778);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(544, 39);
            numericUpDown1.TabIndex = 15;
            // 
            // EditBuku
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 1079);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Controls.Add(label1);
            Name = "EditBuku";
            Text = "EditBuku";
            Load += EditBuku_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown numericUpDown1;
    }
}