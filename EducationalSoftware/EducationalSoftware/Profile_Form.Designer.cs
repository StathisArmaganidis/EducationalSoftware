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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            resources.ApplyResources(this.practise_label, "practise_label");
            this.practise_label.BackColor = System.Drawing.Color.Transparent;
            this.practise_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.practise_label.Name = "practise_label";
            // 
            // need_practise_photo
            // 
            resources.ApplyResources(this.need_practise_photo, "need_practise_photo");
            this.need_practise_photo.BackColor = System.Drawing.Color.Transparent;
            this.need_practise_photo.Name = "need_practise_photo";
            this.need_practise_photo.TabStop = false;
            // 
            // corr_chart
            // 
            resources.ApplyResources(this.corr_chart, "corr_chart");
            this.corr_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            chartArea2.Name = "ChartArea1";
            this.corr_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.corr_chart.Legends.Add(legend2);
            this.corr_chart.Name = "corr_chart";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series3.Legend = "Legend1";
            series3.Name = "Σωστά";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series4.Legend = "Legend1";
            series4.Name = "Λανθασμένα";
            this.corr_chart.Series.Add(series3);
            this.corr_chart.Series.Add(series4);
            // 
            // datecombo
            // 
            resources.ApplyResources(this.datecombo, "datecombo");
            this.datecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datecombo.FormattingEnabled = true;
            this.datecombo.Items.AddRange(new object[] {
            resources.GetString("datecombo.Items"),
            resources.GetString("datecombo.Items1"),
            resources.GetString("datecombo.Items2"),
            resources.GetString("datecombo.Items3"),
            resources.GetString("datecombo.Items4")});
            this.datecombo.Name = "datecombo";
            this.datecombo.SelectedIndexChanged += new System.EventHandler(this.datecombo_SelectedIndexChanged);
            // 
            // testcombo
            // 
            resources.ApplyResources(this.testcombo, "testcombo");
            this.testcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testcombo.FormattingEnabled = true;
            this.testcombo.Items.AddRange(new object[] {
            resources.GetString("testcombo.Items"),
            resources.GetString("testcombo.Items1")});
            this.testcombo.Name = "testcombo";
            this.testcombo.SelectedIndexChanged += new System.EventHandler(this.testcombo_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Profile_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalSoftware.Properties.Resources.profile_backround;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testcombo);
            this.Controls.Add(this.datecombo);
            this.Controls.Add(this.corr_chart);
            this.Controls.Add(this.practise_label);
            this.Controls.Add(this.need_practise_photo);
            this.DoubleBuffered = true;
            this.Name = "Profile_Form";
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