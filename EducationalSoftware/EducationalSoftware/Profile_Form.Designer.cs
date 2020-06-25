namespace EducationalSoftware
{
    partial class Profile_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.practise_label = new System.Windows.Forms.Label();
            this.need_practise_photo = new System.Windows.Forms.PictureBox();
            this.corr_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datecombo = new System.Windows.Forms.ComboBox();
            this.testcombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.need_practise_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // practise_label
            // 
            this.practise_label.AutoSize = true;
            this.practise_label.BackColor = System.Drawing.Color.Transparent;
            this.practise_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.practise_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.practise_label.Location = new System.Drawing.Point(12, 94);
            this.practise_label.Name = "practise_label";
            this.practise_label.Size = new System.Drawing.Size(243, 24);
            this.practise_label.TabIndex = 1;
            this.practise_label.Text = "You will need more practise";
            // 
            // need_practise_photo
            // 
            this.need_practise_photo.BackColor = System.Drawing.Color.Transparent;
            this.need_practise_photo.Location = new System.Drawing.Point(261, 62);
            this.need_practise_photo.Name = "need_practise_photo";
            this.need_practise_photo.Size = new System.Drawing.Size(91, 90);
            this.need_practise_photo.TabIndex = 0;
            this.need_practise_photo.TabStop = false;
            // 
            // corr_chart
            // 
            this.corr_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.corr_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.corr_chart.Legends.Add(legend1);
            this.corr_chart.Location = new System.Drawing.Point(372, 39);
            this.corr_chart.Name = "corr_chart";
            this.corr_chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Correct";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series2.Legend = "Legend1";
            series2.Name = "Wrong";
            this.corr_chart.Series.Add(series1);
            this.corr_chart.Series.Add(series2);
            this.corr_chart.Size = new System.Drawing.Size(431, 304);
            this.corr_chart.TabIndex = 2;
            this.corr_chart.Text = "chart1";
            // 
            // datecombo
            // 
            this.datecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datecombo.FormattingEnabled = true;
            this.datecombo.Items.AddRange(new object[] {
            "This Month",
            "Last Month",
            "Last Three Months",
            "This Year",
            "Last Year"});
            this.datecombo.Location = new System.Drawing.Point(611, 12);
            this.datecombo.Name = "datecombo";
            this.datecombo.Size = new System.Drawing.Size(121, 21);
            this.datecombo.TabIndex = 3;
            this.datecombo.SelectedIndexChanged += new System.EventHandler(this.datecombo_SelectedIndexChanged);
            // 
            // testcombo
            // 
            this.testcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testcombo.FormattingEnabled = true;
            this.testcombo.Items.AddRange(new object[] {
            "Practice Test",
            "Final Test"});
            this.testcombo.Location = new System.Drawing.Point(446, 12);
            this.testcombo.Name = "testcombo";
            this.testcombo.Size = new System.Drawing.Size(121, 21);
            this.testcombo.TabIndex = 4;
            this.testcombo.SelectedIndexChanged += new System.EventHandler(this.testcombo_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.profile_backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testcombo);
            this.Controls.Add(this.datecombo);
            this.Controls.Add(this.corr_chart);
            this.Controls.Add(this.practise_label);
            this.Controls.Add(this.need_practise_photo);
            this.DoubleBuffered = true;
            this.Name = "Profile_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile_Form";
            ((System.ComponentModel.ISupportInitialize)(this.need_practise_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox need_practise_photo;
        private System.Windows.Forms.Label practise_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart corr_chart;
        private System.Windows.Forms.ComboBox datecombo;
        private System.Windows.Forms.ComboBox testcombo;
        private System.Windows.Forms.Button button2;
    }
}