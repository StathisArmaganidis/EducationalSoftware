﻿namespace EducationalSoftware
{
    partial class StartingForm
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
            this.loginUserBox = new System.Windows.Forms.TextBox();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.GoRegister = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginPassLabel = new System.Windows.Forms.Label();
            this.loginUserLabel = new System.Windows.Forms.Label();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.RegisterGroup = new System.Windows.Forms.GroupBox();
            this.GoLogin = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.registerPassLabel = new System.Windows.Forms.Label();
            this.registerUserLabel = new System.Windows.Forms.Label();
            this.registerPassBox = new System.Windows.Forms.TextBox();
            this.registerUserBox = new System.Windows.Forms.TextBox();
            this.LoginGroup.SuspendLayout();
            this.RegisterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginUserBox
            // 
            this.loginUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserBox.Location = new System.Drawing.Point(184, 63);
            this.loginUserBox.Name = "loginUserBox";
            this.loginUserBox.Size = new System.Drawing.Size(100, 29);
            this.loginUserBox.TabIndex = 0;
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.GoRegister);
            this.LoginGroup.Controls.Add(this.LoginButton);
            this.LoginGroup.Controls.Add(this.loginLabel);
            this.LoginGroup.Controls.Add(this.loginPassLabel);
            this.LoginGroup.Controls.Add(this.loginUserLabel);
            this.LoginGroup.Controls.Add(this.loginPassBox);
            this.LoginGroup.Controls.Add(this.loginUserBox);
            this.LoginGroup.Location = new System.Drawing.Point(12, 107);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Size = new System.Drawing.Size(300, 206);
            this.LoginGroup.TabIndex = 1;
            this.LoginGroup.TabStop = false;
            // 
            // GoRegister
            // 
            this.GoRegister.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoRegister.Location = new System.Drawing.Point(6, 167);
            this.GoRegister.Name = "GoRegister";
            this.GoRegister.Size = new System.Drawing.Size(93, 33);
            this.GoRegister.TabIndex = 8;
            this.GoRegister.Text = "Register";
            this.GoRegister.UseVisualStyleBackColor = true;
            this.GoRegister.Click += new System.EventHandler(this.GoRegister_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(201, 167);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(93, 33);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginLabel.Location = new System.Drawing.Point(99, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(78, 26);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // loginPassLabel
            // 
            this.loginPassLabel.AutoSize = true;
            this.loginPassLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassLabel.Location = new System.Drawing.Point(19, 117);
            this.loginPassLabel.Name = "loginPassLabel";
            this.loginPassLabel.Size = new System.Drawing.Size(137, 26);
            this.loginPassLabel.TabIndex = 3;
            this.loginPassLabel.Text = "Password";
            // 
            // loginUserLabel
            // 
            this.loginUserLabel.AutoSize = true;
            this.loginUserLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginUserLabel.Location = new System.Drawing.Point(19, 64);
            this.loginUserLabel.Name = "loginUserLabel";
            this.loginUserLabel.Size = new System.Drawing.Size(139, 26);
            this.loginUserLabel.TabIndex = 2;
            this.loginUserLabel.Text = "Username";
            // 
            // loginPassBox
            // 
            this.loginPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassBox.Location = new System.Drawing.Point(184, 116);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.PasswordChar = '*';
            this.loginPassBox.Size = new System.Drawing.Size(100, 29);
            this.loginPassBox.TabIndex = 1;
            // 
            // RegisterGroup
            // 
            this.RegisterGroup.Controls.Add(this.GoLogin);
            this.RegisterGroup.Controls.Add(this.RegisterButton);
            this.RegisterGroup.Controls.Add(this.registerLabel);
            this.RegisterGroup.Controls.Add(this.registerPassLabel);
            this.RegisterGroup.Controls.Add(this.registerUserLabel);
            this.RegisterGroup.Controls.Add(this.registerPassBox);
            this.RegisterGroup.Controls.Add(this.registerUserBox);
            this.RegisterGroup.Location = new System.Drawing.Point(448, 107);
            this.RegisterGroup.Name = "RegisterGroup";
            this.RegisterGroup.Size = new System.Drawing.Size(300, 206);
            this.RegisterGroup.TabIndex = 5;
            this.RegisterGroup.TabStop = false;
            // 
            // GoLogin
            // 
            this.GoLogin.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLogin.Location = new System.Drawing.Point(6, 167);
            this.GoLogin.Name = "GoLogin";
            this.GoLogin.Size = new System.Drawing.Size(93, 33);
            this.GoLogin.TabIndex = 6;
            this.GoLogin.Text = "Login";
            this.GoLogin.UseVisualStyleBackColor = true;
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(201, 167);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(93, 33);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registerLabel.Location = new System.Drawing.Point(99, 16);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(127, 26);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.Text = "Register";
            // 
            // registerPassLabel
            // 
            this.registerPassLabel.AutoSize = true;
            this.registerPassLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassLabel.Location = new System.Drawing.Point(19, 117);
            this.registerPassLabel.Name = "registerPassLabel";
            this.registerPassLabel.Size = new System.Drawing.Size(137, 26);
            this.registerPassLabel.TabIndex = 3;
            this.registerPassLabel.Text = "Password";
            // 
            // registerUserLabel
            // 
            this.registerUserLabel.AutoSize = true;
            this.registerUserLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registerUserLabel.Location = new System.Drawing.Point(19, 64);
            this.registerUserLabel.Name = "registerUserLabel";
            this.registerUserLabel.Size = new System.Drawing.Size(139, 26);
            this.registerUserLabel.TabIndex = 2;
            this.registerUserLabel.Text = "Username";
            // 
            // registerPassBox
            // 
            this.registerPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassBox.Location = new System.Drawing.Point(184, 116);
            this.registerPassBox.Name = "registerPassBox";
            this.registerPassBox.PasswordChar = '*';
            this.registerPassBox.Size = new System.Drawing.Size(100, 29);
            this.registerPassBox.TabIndex = 1;
            // 
            // registerUserBox
            // 
            this.registerUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserBox.Location = new System.Drawing.Point(184, 63);
            this.registerUserBox.Name = "registerUserBox";
            this.registerUserBox.Size = new System.Drawing.Size(100, 29);
            this.registerUserBox.TabIndex = 0;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterGroup);
            this.Controls.Add(this.LoginGroup);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingForm";
            this.Load += new System.EventHandler(this.StartingForm_Load);
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.RegisterGroup.ResumeLayout(false);
            this.RegisterGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginUserBox;
        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Label loginPassLabel;
        private System.Windows.Forms.Label loginUserLabel;
        private System.Windows.Forms.TextBox loginPassBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.GroupBox RegisterGroup;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label registerPassLabel;
        private System.Windows.Forms.Label registerUserLabel;
        private System.Windows.Forms.TextBox registerPassBox;
        private System.Windows.Forms.TextBox registerUserBox;
        private System.Windows.Forms.Button GoRegister;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button GoLogin;
        private System.Windows.Forms.Button RegisterButton;
    }
}