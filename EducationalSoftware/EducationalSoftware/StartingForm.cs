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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            //LoginGroup.Location = new Point(this.Size.Width / 2 - LoginGroup.Size.Width / 2, this.Size.Height / 2 - LoginGroup.Size.Height / 2);

        }

        private void GotoTestForm_Click(object sender, EventArgs e)
        {
            TestForm tf = new TestForm();
            this.Visible = false;
            tf.ShowDialog();
            this.Visible = true;
        }

        private void GotoLearningForm_Click(object sender, EventArgs e)
        {
            LearningForm lf = new LearningForm();
            this.Visible = false;
            lf.ShowDialog();
            this.Visible = true;
        }
    }
}
