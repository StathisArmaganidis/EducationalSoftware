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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.LoginGroup.SuspendLayout();
            this.RegisterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginUserBox
            // 
            resources.ApplyResources(this.loginUserBox, "loginUserBox");
            this.helpProvider1.SetHelpString(this.loginUserBox, resources.GetString("loginUserBox.HelpString"));
            this.loginUserBox.Name = "loginUserBox";
            this.helpProvider1.SetShowHelp(this.loginUserBox, ((bool)(resources.GetObject("loginUserBox.ShowHelp"))));
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
            resources.ApplyResources(this.LoginGroup, "LoginGroup");
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.TabStop = false;
            // 
            // GoRegister
            // 
            resources.ApplyResources(this.GoRegister, "GoRegister");
            this.helpProvider1.SetHelpString(this.GoRegister, resources.GetString("GoRegister.HelpString"));
            this.GoRegister.Name = "GoRegister";
            this.helpProvider1.SetShowHelp(this.GoRegister, ((bool)(resources.GetObject("GoRegister.ShowHelp"))));
            this.GoRegister.UseVisualStyleBackColor = true;
            this.GoRegister.Click += new System.EventHandler(this.GoRegister_Click);
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.helpProvider1.SetHelpKeyword(this.LoginButton, resources.GetString("LoginButton.HelpKeyword"));
            this.LoginButton.Name = "LoginButton";
            this.helpProvider1.SetShowHelp(this.LoginButton, ((bool)(resources.GetObject("LoginButton.ShowHelp"))));
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
            this.helpProvider1.SetHelpString(this.loginPassBox, resources.GetString("loginPassBox.HelpString"));
            this.loginPassBox.Name = "loginPassBox";
            this.helpProvider1.SetShowHelp(this.loginPassBox, ((bool)(resources.GetObject("loginPassBox.ShowHelp"))));
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
            resources.ApplyResources(this.RegisterGroup, "RegisterGroup");
            this.RegisterGroup.Name = "RegisterGroup";
            this.RegisterGroup.TabStop = false;
            // 
            // GoLogin
            // 
            resources.ApplyResources(this.GoLogin, "GoLogin");
            this.helpProvider1.SetHelpKeyword(this.GoLogin, resources.GetString("GoLogin.HelpKeyword"));
            this.GoLogin.Name = "GoLogin";
            this.helpProvider1.SetShowHelp(this.GoLogin, ((bool)(resources.GetObject("GoLogin.ShowHelp"))));
            this.GoLogin.UseVisualStyleBackColor = true;
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // RegisterButton
            // 
            resources.ApplyResources(this.RegisterButton, "RegisterButton");
            this.helpProvider1.SetHelpKeyword(this.RegisterButton, resources.GetString("RegisterButton.HelpKeyword"));
            this.RegisterButton.Name = "RegisterButton";
            this.helpProvider1.SetShowHelp(this.RegisterButton, ((bool)(resources.GetObject("RegisterButton.ShowHelp"))));
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
            this.helpProvider1.SetHelpString(this.registerPassBox, resources.GetString("registerPassBox.HelpString"));
            this.registerPassBox.Name = "registerPassBox";
            this.helpProvider1.SetShowHelp(this.registerPassBox, ((bool)(resources.GetObject("registerPassBox.ShowHelp"))));
            // 
            // registerUserBox
            // 
            resources.ApplyResources(this.registerUserBox, "registerUserBox");
            this.helpProvider1.SetHelpString(this.registerUserBox, resources.GetString("registerUserBox.HelpString"));
            this.registerUserBox.Name = "registerUserBox";
            this.helpProvider1.SetShowHelp(this.registerUserBox, ((bool)(resources.GetObject("registerUserBox.ShowHelp"))));
            // 
            // StartingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.Login_Background;
            this.Controls.Add(this.RegisterGroup);
            this.Controls.Add(this.LoginGroup);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}