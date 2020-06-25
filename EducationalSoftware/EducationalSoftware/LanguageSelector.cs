using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    public partial class LanguageSelector : Form
    {
        public LanguageSelector()
        {
            InitializeComponent();
        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            this.Visible = false;
            new StartingForm().ShowDialog();
            this.Visible = true;
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("el-GR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("el-GR");
            this.Visible = false;
            new StartingForm().ShowDialog();
            this.Visible = true;
        }
    }
}
