using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    public partial class Profile_Form : Form
    {
        private string username = StartingForm.username;
        public Profile_Form()
        {
            InitializeComponent();
            testcombo.SelectedIndex = 0;
            datecombo.SelectedIndex = 0;
        }
        /// <summary>
        /// Refreshes the chart from database data depending on user selection.
        /// </summary>
        /// <param name="date"></param>
        public void refresh_chart(DateTime date)
        {
            if (datecombo.SelectedIndex == -1)
            {
                datecombo.SelectedIndex = 0;
            }
            int selected_el = datecombo.SelectedIndex;
            switch (selected_el)
            {
                case 1:
                    date = date.AddMonths(-1);
                    date = new DateTime(date.Year, date.Month, 1);
                    break;
                case 2:
                    date = date.AddMonths(-3);
                    date = new DateTime(date.Year, date.Month, 1);
                    break;
                case 3:
                    date = new DateTime(date.Year, 1, 1);
                    break;
                case 4:
                    date = date.AddYears(-1);
                    date = new DateTime(date.Year, 1, 1);
                    break;
                default:
                    date = new DateTime(date.Year, date.Month, 1);
                    break;
            }
            string correct;
            string wrong;
            if (CultureInfo.CurrentCulture.Equals("en-EN"))
            {
                correct = "Correct";
                wrong = "Wrong";
            }
            else
            {
                correct = "Σωστά";
                wrong = "Λανθασμένα";
            }
            corr_chart.Series[correct].Points.Clear();
            corr_chart.Series[wrong].Points.Clear();
            Datamapper dm = new Datamapper();
            dm.GetConnection();
            List<(int, int)> differences = new List<(int, int)>();
            int[] statistics;
            if (testcombo.SelectedIndex == 0)
            {
                statistics = dm.GetStatistics("Practice_Statistics", username, date);
            }
            else
            {
                statistics = dm.GetStatistics("Final_Statistics", username, date);
            }
            int label = 1;
            for (int i = 0; i < 20; i += 2)
            {
                corr_chart.Series[correct].Points.AddXY(label, statistics[i]);
                corr_chart.Series[wrong].Points.AddXY(label, statistics[i + 1]);
                if (statistics[i] < statistics[i + 1])
                {
                    differences.Add((label, statistics[i + 1] - statistics[i]));
                }
                label++;

            }
            string lbl;
            string lbl2;
            if (CultureInfo.CurrentCulture.Equals("en-EN"))
            {
                lbl = "You are doing Great!";
                lbl2 = "You need to practise more";
            }
            else
            {
                lbl = "Τα πηγαίνεις Εξαιρετικά!";
                lbl2 = "Χρειάζεσαι περισσότερη εξάσκηση";
            }
            if (differences.Any())
            {
                practise_label.Text = lbl2;
                differences.Sort((p, q) => p.Item2.CompareTo(q.Item2));
                this.need_practise_photo.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + differences.Last().Item1);
            }
            else
            {
                practise_label.Text = lbl;
                this.need_practise_photo.Image = null;
            }            
        }

        private void datecombo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            refresh_chart(DateTime.Now);
        }

        private void testcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_chart(DateTime.Now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
