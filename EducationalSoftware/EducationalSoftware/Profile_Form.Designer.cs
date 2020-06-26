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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.need_practise_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // practise_label
            // 
            resources.ApplyResources(this.practise_label, "practise_label");
            this.practise_label.BackColor = System.Drawing.Color.Transparent;
            this.practise_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.helpProvider1.SetHelpKeyword(this.practise_label, resources.GetString("practise_label.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.practise_label, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("practise_label.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.practise_label, resources.GetString("practise_label.HelpString"));
            this.practise_label.Name = "practise_label";
            this.helpProvider1.SetShowHelp(this.practise_label, ((bool)(resources.GetObject("practise_label.ShowHelp"))));
            // 
            // need_practise_photo
            // 
            resources.ApplyResources(this.need_practise_photo, "need_practise_photo");
            this.need_practise_photo.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpKeyword(this.need_practise_photo, resources.GetString("need_practise_photo.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.need_practise_photo, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("need_practise_photo.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.need_practise_photo, resources.GetString("need_practise_photo.HelpString"));
            this.need_practise_photo.Name = "need_practise_photo";
            this.helpProvider1.SetShowHelp(this.need_practise_photo, ((bool)(resources.GetObject("need_practise_photo.ShowHelp"))));
            this.need_practise_photo.TabStop = false;
            // 
            // corr_chart
            // 
            resources.ApplyResources(this.corr_chart, "corr_chart");
            this.corr_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            chartArea2.Name = "ChartArea1";
            this.corr_chart.ChartAreas.Add(chartArea2);
            this.helpProvider1.SetHelpKeyword(this.corr_chart, resources.GetString("corr_chart.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.corr_chart, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("corr_chart.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.corr_chart, resources.GetString("corr_chart.HelpString"));
            legend2.Name = "Legend1";
            this.corr_chart.Legends.Add(legend2);
            this.corr_chart.Name = "corr_chart";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series3.Legend = "Legend1";
            series3.Name = "Correct";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series4.Legend = "Legend1";
            series4.Name = "Wrong";
            this.corr_chart.Series.Add(series3);
            this.corr_chart.Series.Add(series4);
            this.helpProvider1.SetShowHelp(this.corr_chart, ((bool)(resources.GetObject("corr_chart.ShowHelp"))));
            // 
            // datecombo
            // 
            resources.ApplyResources(this.datecombo, "datecombo");
            this.datecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datecombo.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.datecombo, resources.GetString("datecombo.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.datecombo, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("datecombo.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.datecombo, resources.GetString("datecombo.HelpString"));
            this.datecombo.Items.AddRange(new object[] {
            resources.GetString("datecombo.Items"),
            resources.GetString("datecombo.Items1"),
            resources.GetString("datecombo.Items2"),
            resources.GetString("datecombo.Items3"),
            resources.GetString("datecombo.Items4")});
            this.datecombo.Name = "datecombo";
            this.helpProvider1.SetShowHelp(this.datecombo, ((bool)(resources.GetObject("datecombo.ShowHelp"))));
            this.datecombo.SelectedIndexChanged += new System.EventHandler(this.datecombo_SelectedIndexChanged);
            // 
            // testcombo
            // 
            resources.ApplyResources(this.testcombo, "testcombo");
            this.testcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testcombo.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.testcombo, resources.GetString("testcombo.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.testcombo, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("testcombo.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.testcombo, resources.GetString("testcombo.HelpString"));
            this.testcombo.Items.AddRange(new object[] {
            resources.GetString("testcombo.Items"),
            resources.GetString("testcombo.Items1")});
            this.testcombo.Name = "testcombo";
            this.helpProvider1.SetShowHelp(this.testcombo, ((bool)(resources.GetObject("testcombo.ShowHelp"))));
            this.testcombo.SelectedIndexChanged += new System.EventHandler(this.testcombo_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.helpProvider1.SetHelpKeyword(this.button2, resources.GetString("button2.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.button2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button2.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.button2, resources.GetString("button2.HelpString"));
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, ((bool)(resources.GetObject("button2.ShowHelp"))));
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
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
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile_Form";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}