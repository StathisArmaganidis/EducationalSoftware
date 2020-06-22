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
             new LearningForm().ShowDialog();

        }

        private void GotoTestForm_Click(object sender, EventArgs e)
        {
             new TestForm().ShowDialog();
        }

        private void GotoLearningTest_Click_1(object sender, EventArgs e)
        {
            new LearningTest().ShowDialog();
        }

        private void GotoProfile(object sender, EventArgs e)
        {
            new Profile_Form().ShowDialog();
        }
    }
}
