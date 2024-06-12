namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class PembayaranDenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranDenda));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 43);
            label1.Name = "label1";
            label1.Size = new Size(290, 41);
            label1.TabIndex = 1;
            label1.Text = "Pembayaran Denda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 430);
            label2.Name = "label2";
            label2.Size = new Size(183, 41);
            label2.TabIndex = 2;
            label2.Text = "Total Denda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 430);
            label3.Name = "label3";
            label3.Size = new Size(101, 41);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(253, 559);
            button1.Name = "button1";
            button1.Size = new Size(219, 70);
            button1.TabIndex = 4;
            button1.Text = "Selesaikan Pembayaran";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PembayaranDenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 715);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PembayaranDenda";
            Text = "PembayaranDenda";
            Load += PembayaranDenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}