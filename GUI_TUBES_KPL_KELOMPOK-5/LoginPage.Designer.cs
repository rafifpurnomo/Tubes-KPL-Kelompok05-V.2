namespace GUI_TUBES_KPL_KELOMPOK_5
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginBTN = new Button();
            usernameInput = new TextBox();
            passInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(115, 62);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1393, 170);
            label1.TabIndex = 0;
            label1.Text = "PerpusGO Application";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(575, 350);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "No Anggota";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 500);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = SystemColors.ActiveCaption;
            LoginBTN.ForeColor = SystemColors.ButtonHighlight;
            LoginBTN.Location = new Point(750, 630);
            LoginBTN.Margin = new Padding(5, 5, 5, 5);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(153, 46);
            LoginBTN.TabIndex = 3;
            LoginBTN.Text = "Login";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(575, 390);
            usernameInput.Margin = new Padding(5, 5, 5, 5);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(500, 39);
            usernameInput.TabIndex = 5;
            usernameInput.TextChanged += textBox2_TextChanged;
            // 
            // passInput
            // 
            passInput.Location = new Point(575, 540);
            passInput.Margin = new Padding(5, 5, 5, 5);
            passInput.Name = "passInput";
            passInput.Size = new Size(500, 39);
            passInput.TabIndex = 6;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 1079);
            Controls.Add(passInput);
            Controls.Add(usernameInput);
            Controls.Add(LoginBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "LoginPage";
            Text = "loginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button LoginBTN;
        private TextBox usernameInput;
        private TextBox passInput;
    }
}
