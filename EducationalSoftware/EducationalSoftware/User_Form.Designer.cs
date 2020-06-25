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
            this.GotoLearningTest = new System.Windows.Forms.Button();
            this.GotoLearningForm = new System.Windows.Forms.Button();
            this.GotoTestForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GotoLearningTest
            // 
            this.GotoLearningTest.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoLearningTest.Location = new System.Drawing.Point(509, 193);
            this.GotoLearningTest.Name = "GotoLearningTest";
            this.GotoLearningTest.Size = new System.Drawing.Size(146, 75);
            this.GotoLearningTest.TabIndex = 7;
            this.GotoLearningTest.Text = "Practice Test!";
            this.GotoLearningTest.UseVisualStyleBackColor = true;
            this.GotoLearningTest.Click += new System.EventHandler(this.GotoLearningTest_Click_1);
            // 
            // GotoLearningForm
            // 
            this.GotoLearningForm.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoLearningForm.Location = new System.Drawing.Point(509, 95);
            this.GotoLearningForm.Name = "GotoLearningForm";
            this.GotoLearningForm.Size = new System.Drawing.Size(146, 75);
            this.GotoLearningForm.TabIndex = 6;
            this.GotoLearningForm.Text = "Let\'s Practice";
            this.GotoLearningForm.UseVisualStyleBackColor = true;
            this.GotoLearningForm.Click += new System.EventHandler(this.GotoLearningForm_Click);
            // 
            // GotoTestForm
            // 
            this.GotoTestForm.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoTestForm.Location = new System.Drawing.Point(509, 350);
            this.GotoTestForm.Name = "GotoTestForm";
            this.GotoTestForm.Size = new System.Drawing.Size(146, 75);
            this.GotoTestForm.TabIndex = 5;
            this.GotoTestForm.Text = "Final Test!";
            this.GotoTestForm.UseVisualStyleBackColor = true;
            this.GotoTestForm.Click += new System.EventHandler(this.GotoTestForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GotoProfile);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.Main_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GotoLearningTest);
            this.Controls.Add(this.GotoLearningForm);
            this.Controls.Add(this.GotoTestForm);
            this.Name = "User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GotoLearningTest;
        private System.Windows.Forms.Button GotoLearningForm;
        private System.Windows.Forms.Button GotoTestForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}