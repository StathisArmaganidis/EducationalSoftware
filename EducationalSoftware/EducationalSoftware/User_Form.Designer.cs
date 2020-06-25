namespace EducationalSoftware
{
    partial class User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            this.GotoLearningTest = new System.Windows.Forms.Button();
            this.GotoLearningForm = new System.Windows.Forms.Button();
            this.GotoTestForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // GotoLearningTest
            // 
            resources.ApplyResources(this.GotoLearningTest, "GotoLearningTest");
            this.helpProvider1.SetHelpString(this.GotoLearningTest, resources.GetString("GotoLearningTest.HelpString"));
            this.GotoLearningTest.Name = "GotoLearningTest";
            this.helpProvider1.SetShowHelp(this.GotoLearningTest, ((bool)(resources.GetObject("GotoLearningTest.ShowHelp"))));
            this.GotoLearningTest.UseVisualStyleBackColor = true;
            this.GotoLearningTest.Click += new System.EventHandler(this.GotoLearningTest_Click_1);
            // 
            // GotoLearningForm
            // 
            resources.ApplyResources(this.GotoLearningForm, "GotoLearningForm");
            this.helpProvider1.SetHelpString(this.GotoLearningForm, resources.GetString("GotoLearningForm.HelpString"));
            this.GotoLearningForm.Name = "GotoLearningForm";
            this.helpProvider1.SetShowHelp(this.GotoLearningForm, ((bool)(resources.GetObject("GotoLearningForm.ShowHelp"))));
            this.GotoLearningForm.UseVisualStyleBackColor = true;
            this.GotoLearningForm.Click += new System.EventHandler(this.GotoLearningForm_Click);
            // 
            // GotoTestForm
            // 
            resources.ApplyResources(this.GotoTestForm, "GotoTestForm");
            this.helpProvider1.SetHelpString(this.GotoTestForm, resources.GetString("GotoTestForm.HelpString"));
            this.GotoTestForm.Name = "GotoTestForm";
            this.helpProvider1.SetShowHelp(this.GotoTestForm, ((bool)(resources.GetObject("GotoTestForm.ShowHelp"))));
            this.GotoTestForm.UseVisualStyleBackColor = true;
            this.GotoTestForm.Click += new System.EventHandler(this.GotoTestForm_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.helpProvider1.SetHelpString(this.button1, resources.GetString("button1.HelpString"));
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GotoProfile);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.helpProvider1.SetHelpString(this.button2, resources.GetString("button2.HelpString"));
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, ((bool)(resources.GetObject("button2.ShowHelp"))));
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.Main_Background;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GotoLearningTest);
            this.Controls.Add(this.GotoLearningForm);
            this.Controls.Add(this.GotoTestForm);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GotoLearningTest;
        private System.Windows.Forms.Button GotoLearningForm;
        private System.Windows.Forms.Button GotoTestForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}