using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    public partial class Profile_Form : Form
    {
        public Profile_Form()
        {
            InitializeComponent();
            datecombo.SelectedItem = "This Month";

           
        }
        public void refresh_chart(DateTime date)
        {
            corr_chart.Series["Correct"].Points.Clear();
            corr_chart.Series["Wrong"].Points.Clear();
            Datamapper dm = new Datamapper();
            dm.GetConnection();
            List<(int, int)> differences = new List<(int, int)>();
            int[] statistics = dm.GetStatistics("kostas",date);
            int label = 1;
            for (int i = 0; i < 20; i += 2)
            {
                corr_chart.Series["Correct"].Points.AddXY(label, statistics[i]);
                corr_chart.Series["Wrong"].Points.AddXY(label, statistics[i + 1]);
                if (statistics[i] < statistics[i + 1])
                {
                    differences.Add((label, statistics[i + 1] - statistics[i]));
                }
                    label++;
                
            }
            if (differences.Any())
            {
                differences.Sort((p, q) => p.Item2.CompareTo(q.Item2));
                this.need_practise_photo.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + differences.Last().Item1);
            }
        }

        private void datecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string selected_el = datecombo.SelectedItem.ToString();
            switch (selected_el)
            {
                case "Last Month":
                    date = date.AddMonths(-1);
                    break;
                case "Last Three Months":
                    date = date.AddMonths(-3);
                    break;
                case "This Year":
                    date = date.AddMonths(-(date.Month));
                    break;
                case "Last Year":
                    date = date.AddYears(-1);
                    date = date.AddMonths(-(date.Month));
                    break;
                default:
                    break;
            }
            refresh_chart(date);
        }
    }
}
