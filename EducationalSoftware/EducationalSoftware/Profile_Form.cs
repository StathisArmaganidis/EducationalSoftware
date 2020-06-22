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
        public void refresh_chart(string year, string month)
        {
            corr_chart.Series["Correct"].Points.Clear();
            corr_chart.Series["Wrong"].Points.Clear();
            Datamapper dm = new Datamapper();
            dm.GetConnection();
            int[] statistics = dm.GetStatistics("kostas", year, month);
            int label = 1;
            for (int i = 0; i < 20; i += 2)
            {
                corr_chart.Series["Correct"].Points.AddXY(label, statistics[i]);
                corr_chart.Series["Wrong"].Points.AddXY(label, statistics[i + 1]);
                label++;
            }
        }

        private void datecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string year;
            string month;
            string selected_el = datecombo.SelectedItem.ToString();
            switch (selected_el)
            {
                case "This Month":
                   
                    year = date.ToString("yyyy");
                    month = date.ToString("MM");
                    break;
                case "Last Month":;
                    year =  date.ToString("yyyy");
                    month = date.AddMonths(-1).ToString("MM");
                    break;
                case "Last Three Months":

                    year = date.ToString("yyyy");
                    month = date.AddMonths(-3).ToString("MM");
                    break;
                case "This Year":
                    year = date.ToString("yyyy");
                    month = "01";
                    break;
                    break;
                case "Last Year":
                    year = date.AddYears(-1).ToString("yyyy");
                    month = "01";
                    break;
                default:
                    year = date.ToString("yyyy");
                    month = date.ToString("MM");
                    break;
            }
            refresh_chart(year, month);
        }
    }
}
