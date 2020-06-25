namespace EducationalSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
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
            resources.ApplyResources(this.loginUserBox, "loginUserBox");
            this.loginUserBox.Name = "loginUserBox";
            // 
            // LoginGroup
            // 
            resources.ApplyResources(this.LoginGroup, "LoginGroup");
            this.LoginGroup.Controls.Add(this.GoRegister);
            this.LoginGroup.Controls.Add(this.LoginButton);
            this.LoginGroup.Controls.Add(this.loginLabel);
            this.LoginGroup.Controls.Add(this.loginPassLabel);
            this.LoginGroup.Controls.Add(this.loginUserLabel);
            this.LoginGroup.Controls.Add(this.loginPassBox);
            this.LoginGroup.Controls.Add(this.loginUserBox);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.TabStop = false;
            // 
            // GoRegister
            // 
            resources.ApplyResources(this.GoRegister, "GoRegister");
            this.GoRegister.Name = "GoRegister";
            this.GoRegister.UseVisualStyleBackColor = true;
            this.GoRegister.Click += new System.EventHandler(this.GoRegister_Click);
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginLabel.Name = "loginLabel";
            // 
            // loginPassLabel
            // 
            resources.ApplyResources(this.loginPassLabel, "loginPassLabel");
            this.loginPassLabel.Name = "loginPassLabel";
            // 
            // loginUserLabel
            // 
            resources.ApplyResources(this.loginUserLabel, "loginUserLabel");
            this.loginUserLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginUserLabel.Name = "loginUserLabel";
            // 
            // loginPassBox
            // 
            resources.ApplyResources(this.loginPassBox, "loginPassBox");
            this.loginPassBox.Name = "loginPassBox";
            // 
            // RegisterGroup
            // 
            resources.ApplyResources(this.RegisterGroup, "RegisterGroup");
            this.RegisterGroup.Controls.Add(this.GoLogin);
            this.RegisterGroup.Controls.Add(this.RegisterButton);
            this.RegisterGroup.Controls.Add(this.registerLabel);
            this.RegisterGroup.Controls.Add(this.registerPassLabel);
            this.RegisterGroup.Controls.Add(this.registerUserLabel);
            this.RegisterGroup.Controls.Add(this.registerPassBox);
            this.RegisterGroup.Controls.Add(this.registerUserBox);
            this.RegisterGroup.Name = "RegisterGroup";
            this.RegisterGroup.TabStop = false;
            // 
            // GoLogin
            // 
            resources.ApplyResources(this.GoLogin, "GoLogin");
            this.GoLogin.Name = "GoLogin";
            this.GoLogin.UseVisualStyleBackColor = true;
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // RegisterButton
            // 
            resources.ApplyResources(this.RegisterButton, "RegisterButton");
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // registerLabel
            // 
            resources.ApplyResources(this.registerLabel, "registerLabel");
            this.registerLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registerLabel.Name = "registerLabel";
            // 
            // registerPassLabel
            // 
            resources.ApplyResources(this.registerPassLabel, "registerPassLabel");
            this.registerPassLabel.Name = "registerPassLabel";
            // 
            // registerUserLabel
            // 
            resources.ApplyResources(this.registerUserLabel, "registerUserLabel");
            this.registerUserLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.registerUserLabel.Name = "registerUserLabel";
            // 
            // registerPassBox
            // 
            resources.ApplyResources(this.registerPassBox, "registerPassBox");
            this.registerPassBox.Name = "registerPassBox";
            // 
            // registerUserBox
            // 
            resources.ApplyResources(this.registerUserBox, "registerUserBox");
            this.registerUserBox.Name = "registerUserBox";
            // 
            // StartingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.Login_Background;
            this.Controls.Add(this.RegisterGroup);
            this.Controls.Add(this.LoginGroup);
            this.Name = "StartingForm";
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