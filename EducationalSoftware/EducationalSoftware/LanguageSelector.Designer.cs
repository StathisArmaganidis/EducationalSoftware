namespace EducationalSoftware
{
    partial class LanguageSelector
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
            this.ENButton = new System.Windows.Forms.Button();
            this.GRButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // ENButton
            // 
            this.ENButton.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.ENButton, "Change language to English.");
            this.ENButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ENButton.Location = new System.Drawing.Point(190, 154);
            this.ENButton.Name = "ENButton";
            this.helpProvider1.SetShowHelp(this.ENButton, true);
            this.ENButton.Size = new System.Drawing.Size(123, 92);
            this.ENButton.TabIndex = 6;
            this.ENButton.Text = "English";
            this.ENButton.UseVisualStyleBackColor = true;
            this.ENButton.Click += new System.EventHandler(this.ENButton_Click);
            // 
            // GRButton
            // 
            this.GRButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.GRButton, "Change language to Greek.");
            this.GRButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GRButton.Location = new System.Drawing.Point(467, 154);
            this.GRButton.Name = "GRButton";
            this.helpProvider1.SetShowHelp(this.GRButton, true);
            this.GRButton.Size = new System.Drawing.Size(123, 92);
            this.GRButton.TabIndex = 7;
            this.GRButton.Text = "Ελληνικά";
            this.GRButton.UseVisualStyleBackColor = true;
            this.GRButton.Click += new System.EventHandler(this.GRButton_Click);
            // 
            // LanguageSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GRButton);
            this.Controls.Add(this.ENButton);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ENButton;
        private System.Windows.Forms.Button GRButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}