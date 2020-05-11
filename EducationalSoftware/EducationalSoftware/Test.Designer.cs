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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ThisQuestionsText = new System.Windows.Forms.Label();
            this.QuestionSlash = new System.Windows.Forms.Label();
            this.TotalQuestionsText = new System.Windows.Forms.Label();
            this.QuestionGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResultNum = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RightNumText = new System.Windows.Forms.NumericUpDown();
            this.LeftNumText = new System.Windows.Forms.NumericUpDown();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.ChooseText = new System.Windows.Forms.Label();
            this.DifficultyGroup = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.QuestionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumText)).BeginInit();
            this.DifficultyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            // QuestionGroup
            // 
            this.QuestionGroup.Controls.Add(this.pictureBox6);
            this.QuestionGroup.Controls.Add(this.pictureBox5);
            this.QuestionGroup.Controls.Add(this.pictureBox4);
            this.QuestionGroup.Controls.Add(this.pictureBox3);
            this.QuestionGroup.Controls.Add(this.pictureBox2);
            this.QuestionGroup.Controls.Add(this.pictureBox1);
            this.QuestionGroup.Controls.Add(this.ResultNum);
            this.QuestionGroup.Controls.Add(this.ConfirmButton);
            this.QuestionGroup.Controls.Add(this.RightNumText);
            this.QuestionGroup.Controls.Add(this.LeftNumText);
            this.QuestionGroup.Location = new System.Drawing.Point(287, 42);
            this.QuestionGroup.Name = "QuestionGroup";
            this.QuestionGroup.Size = new System.Drawing.Size(427, 211);
            this.QuestionGroup.TabIndex = 9;
            this.QuestionGroup.TabStop = false;
            this.QuestionGroup.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(299, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(163, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ResultNum
            // 
            this.ResultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultNum.Location = new System.Drawing.Point(339, 94);
            this.ResultNum.Name = "ResultNum";
            this.ResultNum.Size = new System.Drawing.Size(62, 29);
            this.ResultNum.TabIndex = 15;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(313, 161);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(101, 43);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RightNumText
            // 
            this.RightNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightNumText.Location = new System.Drawing.Point(163, 94);
            this.RightNumText.Name = "RightNumText";
            this.RightNumText.Size = new System.Drawing.Size(62, 29);
            this.RightNumText.TabIndex = 14;
            // 
            // LeftNumText
            // 
            this.LeftNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNumText.Location = new System.Drawing.Point(27, 94);
            this.LeftNumText.Name = "LeftNumText";
            this.LeftNumText.Size = new System.Drawing.Size(62, 29);
            this.LeftNumText.TabIndex = 13;
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
            this.DifficultyGroup.Location = new System.Drawing.Point(12, 194);
            this.DifficultyGroup.Name = "DifficultyGroup";
            this.DifficultyGroup.Size = new System.Drawing.Size(221, 244);
            this.DifficultyGroup.TabIndex = 12;
            this.DifficultyGroup.TabStop = false;
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
            // pictureBox4
            // 
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(365, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(95, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(231, 94);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(62, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumText)).EndInit();
            this.DifficultyGroup.ResumeLayout(false);
            this.DifficultyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label ThisQuestionsText;
        private System.Windows.Forms.Label QuestionSlash;
        private System.Windows.Forms.Label TotalQuestionsText;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

