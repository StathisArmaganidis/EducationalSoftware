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
            this.userBox = new System.Windows.Forms.TextBox();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.GotoTestForm = new System.Windows.Forms.Button();
            this.GotoLearningForm = new System.Windows.Forms.Button();
            this.GotoLearningTest = new System.Windows.Forms.Button();
            this.LoginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(174, 65);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 29);
            this.userBox.TabIndex = 0;
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.passLabel);
            this.LoginGroup.Controls.Add(this.userLabel);
            this.LoginGroup.Controls.Add(this.passBox);
            this.LoginGroup.Controls.Add(this.userBox);
            this.LoginGroup.Location = new System.Drawing.Point(244, 82);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Size = new System.Drawing.Size(300, 233);
            this.LoginGroup.TabIndex = 1;
            this.LoginGroup.TabStop = false;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(174, 118);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 29);
            this.passBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userLabel.Location = new System.Drawing.Point(9, 66);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(139, 26);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(9, 119);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(137, 26);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // GotoTestForm
            // 
            this.GotoTestForm.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoTestForm.Location = new System.Drawing.Point(602, 341);
            this.GotoTestForm.Name = "GotoTestForm";
            this.GotoTestForm.Size = new System.Drawing.Size(146, 75);
            this.GotoTestForm.TabIndex = 2;
            this.GotoTestForm.Text = "Final Test!";
            this.GotoTestForm.UseVisualStyleBackColor = true;
            this.GotoTestForm.Click += new System.EventHandler(this.GotoTestForm_Click);
            // 
            // GotoLearningForm
            // 
            this.GotoLearningForm.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoLearningForm.Location = new System.Drawing.Point(43, 341);
            this.GotoLearningForm.Name = "GotoLearningForm";
            this.GotoLearningForm.Size = new System.Drawing.Size(146, 75);
            this.GotoLearningForm.TabIndex = 3;
            this.GotoLearningForm.Text = "Let\'s Practice";
            this.GotoLearningForm.UseVisualStyleBackColor = true;
            this.GotoLearningForm.Click += new System.EventHandler(this.GotoLearningForm_Click);
            // 
            // GotoLearningTest
            // 
            this.GotoLearningTest.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoLearningTest.Location = new System.Drawing.Point(323, 341);
            this.GotoLearningTest.Name = "GotoLearningTest";
            this.GotoLearningTest.Size = new System.Drawing.Size(146, 75);
            this.GotoLearningTest.TabIndex = 4;
            this.GotoLearningTest.Text = "Practice Test!";
            this.GotoLearningTest.UseVisualStyleBackColor = true;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GotoLearningTest);
            this.Controls.Add(this.GotoLearningForm);
            this.Controls.Add(this.GotoTestForm);
            this.Controls.Add(this.LoginGroup);
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingForm";
            this.Load += new System.EventHandler(this.StartingForm_Load);
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button GotoTestForm;
        private System.Windows.Forms.Button GotoLearningForm;
        private System.Windows.Forms.Button GotoLearningTest;
    }
}