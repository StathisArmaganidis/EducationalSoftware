using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            LoginGroup.Location = new Point(this.Size.Width / 2 - LoginGroup.Size.Width / 2, this.Size.Height / 2 - LoginGroup.Size.Height);
            RegisterGroup.Location = new Point(this.Size.Width / 2 - RegisterGroup.Size.Width / 2, this.Size.Height / 2 - RegisterGroup.Size.Height);
            RegisterGroup.Visible = false;
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

        private void GoRegister_Click(object sender, EventArgs e)
        {
            LoginGroup.Visible = false;
            RegisterGroup.Visible = true;
        }

        private void GoLogin_Click(object sender, EventArgs e)
        {
            RegisterGroup.Visible = false;
            LoginGroup.Visible = true;
        }
        }

        private void GotoLearningTest_Click(object sender, EventArgs e)
        {
            try
            {
                Datamapper.getConnection();
                Datamapper.openConnection();
                string cmd = "SELECT username FROM students";
                OleDbCommand command = new OleDbCommand(cmd, Datamapper.connection);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader["Username"].ToString());
                    }
                }
            }
            catch (Exception se)
            {
                throw new Exception(se.ToString());
            }

        }
    }
}
