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
            ((System.ComponentModel.ISupportInitialize)(this.need_practise_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // practise_label
            // 
            this.practise_label.AutoSize = true;
            this.practise_label.Location = new System.Drawing.Point(12, 241);
            this.practise_label.Name = "practise_label";
            this.practise_label.Size = new System.Drawing.Size(153, 13);
            this.practise_label.TabIndex = 1;
            this.practise_label.Text = "You will need more practise in: ";
            // 
            // need_practise_photo
            // 
            this.need_practise_photo.Location = new System.Drawing.Point(171, 201);
            this.need_practise_photo.Name = "need_practise_photo";
            this.need_practise_photo.Size = new System.Drawing.Size(91, 90);
            this.need_practise_photo.TabIndex = 0;
            this.need_practise_photo.TabStop = false;
            // 
            // corr_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.corr_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.corr_chart.Legends.Add(legend1);
            this.corr_chart.Location = new System.Drawing.Point(334, 106);
            this.corr_chart.Name = "corr_chart";
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
            this.corr_chart.Size = new System.Drawing.Size(469, 304);
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
            this.datecombo.Location = new System.Drawing.Point(473, 90);
            this.datecombo.Name = "datecombo";
            this.datecombo.Size = new System.Drawing.Size(121, 21);
            this.datecombo.TabIndex = 3;
            this.datecombo.SelectedIndexChanged += new System.EventHandler(this.datecombo_SelectedIndexChanged);
            // 
            // Profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.datecombo);
            this.Controls.Add(this.corr_chart);
            this.Controls.Add(this.practise_label);
            this.Controls.Add(this.need_practise_photo);
            this.Name = "Profile_Form";
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
    }
}