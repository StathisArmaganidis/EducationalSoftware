namespace EducationalSoftware
{
    partial class TestForm
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ThisQuestionsText = new System.Windows.Forms.Label();
            this.QuestionSlash = new System.Windows.Forms.Label();
            this.TotalQuestionsText = new System.Windows.Forms.Label();
            this.MultSymbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionGroup = new System.Windows.Forms.GroupBox();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.ChooseText = new System.Windows.Forms.Label();
            this.DifficultyGroup = new System.Windows.Forms.GroupBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LeftNumText = new System.Windows.Forms.NumericUpDown();
            this.RightNumText = new System.Windows.Forms.NumericUpDown();
            this.ResultNum = new System.Windows.Forms.NumericUpDown();
            this.QuestionGroup.SuspendLayout();
            this.DifficultyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultNum)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(86, 24);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.Visible = false;
            // 
            // ThisQuestionsText
            // 
            this.ThisQuestionsText.AutoSize = true;
            this.ThisQuestionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisQuestionsText.Location = new System.Drawing.Point(104, 12);
            this.ThisQuestionsText.Name = "ThisQuestionsText";
            this.ThisQuestionsText.Size = new System.Drawing.Size(18, 20);
            this.ThisQuestionsText.TabIndex = 1;
            this.ThisQuestionsText.Text = "1";
            this.ThisQuestionsText.Visible = false;
            // 
            // QuestionSlash
            // 
            this.QuestionSlash.AutoSize = true;
            this.QuestionSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionSlash.Location = new System.Drawing.Point(128, 12);
            this.QuestionSlash.Name = "QuestionSlash";
            this.QuestionSlash.Size = new System.Drawing.Size(13, 20);
            this.QuestionSlash.TabIndex = 2;
            this.QuestionSlash.Text = "/";
            this.QuestionSlash.Visible = false;
            // 
            // TotalQuestionsText
            // 
            this.TotalQuestionsText.AutoSize = true;
            this.TotalQuestionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuestionsText.Location = new System.Drawing.Point(147, 12);
            this.TotalQuestionsText.Name = "TotalQuestionsText";
            this.TotalQuestionsText.Size = new System.Drawing.Size(18, 20);
            this.TotalQuestionsText.TabIndex = 3;
            this.TotalQuestionsText.Text = "0";
            this.TotalQuestionsText.Visible = false;
            // 
            // MultSymbol
            // 
            this.MultSymbol.AutoSize = true;
            this.MultSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultSymbol.Location = new System.Drawing.Point(131, 94);
            this.MultSymbol.Name = "MultSymbol";
            this.MultSymbol.Size = new System.Drawing.Size(25, 31);
            this.MultSymbol.TabIndex = 6;
            this.MultSymbol.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // QuestionGroup
            // 
            this.QuestionGroup.Controls.Add(this.ResultNum);
            this.QuestionGroup.Controls.Add(this.ConfirmButton);
            this.QuestionGroup.Controls.Add(this.RightNumText);
            this.QuestionGroup.Controls.Add(this.LeftNumText);
            this.QuestionGroup.Controls.Add(this.label1);
            this.QuestionGroup.Controls.Add(this.MultSymbol);
            this.QuestionGroup.Location = new System.Drawing.Point(413, 37);
            this.QuestionGroup.Name = "QuestionGroup";
            this.QuestionGroup.Size = new System.Drawing.Size(375, 211);
            this.QuestionGroup.TabIndex = 9;
            this.QuestionGroup.TabStop = false;
            this.QuestionGroup.Visible = false;
            // 
            // EasyButton
            // 
            this.EasyButton.Location = new System.Drawing.Point(59, 77);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(101, 43);
            this.EasyButton.TabIndex = 9;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MediumButton
            // 
            this.MediumButton.Location = new System.Drawing.Point(59, 126);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(101, 43);
            this.MediumButton.TabIndex = 10;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.Location = new System.Drawing.Point(59, 175);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(101, 43);
            this.HardButton.TabIndex = 11;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // ChooseText
            // 
            this.ChooseText.AutoSize = true;
            this.ChooseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseText.Location = new System.Drawing.Point(37, 16);
            this.ChooseText.Name = "ChooseText";
            this.ChooseText.Size = new System.Drawing.Size(148, 24);
            this.ChooseText.TabIndex = 12;
            this.ChooseText.Text = "Choose Difficulty";
            // 
            // DifficultyGroup
            // 
            this.DifficultyGroup.Controls.Add(this.ChooseText);
            this.DifficultyGroup.Controls.Add(this.HardButton);
            this.DifficultyGroup.Controls.Add(this.MediumButton);
            this.DifficultyGroup.Controls.Add(this.EasyButton);
            this.DifficultyGroup.Location = new System.Drawing.Point(164, 79);
            this.DifficultyGroup.Name = "DifficultyGroup";
            this.DifficultyGroup.Size = new System.Drawing.Size(221, 244);
            this.DifficultyGroup.TabIndex = 12;
            this.DifficultyGroup.TabStop = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(267, 162);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(101, 43);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(687, 395);
            this.BackButton.Name = "BackButton";
            this.BackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackButton.Size = new System.Drawing.Size(101, 43);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // LeftNumText
            // 
            this.LeftNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNumText.Location = new System.Drawing.Point(63, 94);
            this.LeftNumText.Name = "LeftNumText";
            this.LeftNumText.Size = new System.Drawing.Size(62, 29);
            this.LeftNumText.TabIndex = 13;
            // 
            // RightNumText
            // 
            this.RightNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightNumText.Location = new System.Drawing.Point(163, 94);
            this.RightNumText.Name = "RightNumText";
            this.RightNumText.Size = new System.Drawing.Size(62, 29);
            this.RightNumText.TabIndex = 14;
            // 
            // ResultNum
            // 
            this.ResultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultNum.Location = new System.Drawing.Point(267, 94);
            this.ResultNum.Name = "ResultNum";
            this.ResultNum.Size = new System.Drawing.Size(62, 29);
            this.ResultNum.TabIndex = 15;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DifficultyGroup);
            this.Controls.Add(this.QuestionGroup);
            this.Controls.Add(this.TotalQuestionsText);
            this.Controls.Add(this.QuestionSlash);
            this.Controls.Add(this.ThisQuestionsText);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evaluation Test";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.QuestionGroup.ResumeLayout(false);
            this.QuestionGroup.PerformLayout();
            this.DifficultyGroup.ResumeLayout(false);
            this.DifficultyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label ThisQuestionsText;
        private System.Windows.Forms.Label QuestionSlash;
        private System.Windows.Forms.Label TotalQuestionsText;
        private System.Windows.Forms.Label MultSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox QuestionGroup;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Label ChooseText;
        private System.Windows.Forms.GroupBox DifficultyGroup;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown ResultNum;
        private System.Windows.Forms.NumericUpDown RightNumText;
        private System.Windows.Forms.NumericUpDown LeftNumText;
    }
}

