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
    public partial class User_Form: Form
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void GotoLearningForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new LearningForm().ShowDialog();
            this.Visible = true;
        }

        private void GotoTestForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new TestForm().ShowDialog();
            this.Visible = true;
        }

        private void GotoLearningTest_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new LearningTest().ShowDialog();
            this.Visible = true;
        }

        private void GotoProfile(object sender, EventArgs e)
        {
            this.Visible = false;
            new Profile_Form().ShowDialog();
            this.Visible = true;
        }
    }
}
