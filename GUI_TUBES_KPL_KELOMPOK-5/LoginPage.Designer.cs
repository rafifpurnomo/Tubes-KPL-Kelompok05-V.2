﻿namespace GUI_TUBES_KPL_KELOMPOK_5
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
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(243, 41);
            label1.Name = "label1";
            label1.Size = new Size(249, 35);
            label1.TabIndex = 0;
            label1.Text = "APLIKASI PerpusGO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 169);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "No Anggota";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 242);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // LoginBTN
            // 
            LoginBTN.Location = new Point(409, 233);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(94, 29);
            LoginBTN.TabIndex = 3;
            LoginBTN.Text = "Login";
            LoginBTN.UseVisualStyleBackColor = true;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(124, 192);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(189, 27);
            usernameInput.TabIndex = 5;
            usernameInput.TextChanged += textBox2_TextChanged;
            // 
            // passInput
            // 
            passInput.Location = new Point(124, 265);
            passInput.Name = "passInput";
            passInput.Size = new Size(189, 27);
            passInput.TabIndex = 6;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passInput);
            Controls.Add(usernameInput);
            Controls.Add(LoginBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "loginPage";
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