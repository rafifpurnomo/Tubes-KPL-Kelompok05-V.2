namespace GUI_TUBES_KPL_KELOMPOK_5
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox5 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "kode buku";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 105);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "judul buku";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Sinopsis";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 255);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Penulis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 320);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "jumlah buku";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(384, 195);
            button2.Name = "button2";
            button2.Size = new Size(150, 65);
            button2.TabIndex = 13;
            button2.Text = "tambah buku";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 353);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(164, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 255);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 15;
            label5.Text = "tahun terbit";
            // 
            // TambahBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 462);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "TambahBuku";
            Text = "TambahBuku";
            Load += TambahBuku_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox5;
        private Label label5;
    }
}