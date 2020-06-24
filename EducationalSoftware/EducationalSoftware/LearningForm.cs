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
    public partial class LearningForm : Form
    {
        public LearningForm()
        {
            InitializeComponent();
        }

        private void number_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new TimesLearning(((Button)sender).Name, int.Parse(((Button)sender).Tag.ToString())).ShowDialog();
            this.Visible = true;
        }
    }
}
