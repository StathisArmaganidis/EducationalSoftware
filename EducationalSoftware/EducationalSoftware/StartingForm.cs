using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    public partial class StartingForm : Form
    {
        Datamapper dm;
        public static string username ="";
        public StartingForm()
        {
            
            InitializeComponent();
            dm = new Datamapper();
            dm.GetConnection();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            LoginGroup.Location = new Point(10, 10);
            RegisterGroup.Location = new Point(10, 10);
            RegisterGroup.Visible = false;
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







        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(registerUserBox.Text) && !string.IsNullOrWhiteSpace(registerPassBox.Text))
            {
                bool success = dm.Register(registerUserBox.Text, registerPassBox.Text);
                if (success)
                {
                    registerUserBox.Text = "";
                    registerPassBox.Text = "";
                    RegisterGroup.Visible = false;
                    LoginGroup.Visible = true;
                }
                else
                {
                    if (CultureInfo.CurrentCulture.Name.Equals("en-EN"))
                    {
                        MessageBox.Show("There was a problem with the database, please try again...");
                    }
                    else
                    {
                        MessageBox.Show("Προέκυψε πρόβλημα με την βάση δεδομένων. Παρακαλώ δοκιμάστε ξανά...");
                    }
                }
            }
            else
            {
                if (CultureInfo.CurrentCulture.Name.Equals("en-EN"))
                {
                    MessageBox.Show("Please fill both username and password");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, συμπληρώστε όνομα και κωδικό");
                }
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginUserBox.Text) && !string.IsNullOrWhiteSpace(loginPassBox.Text))
            {
                bool success = dm.LoginUser(loginUserBox.Text, loginPassBox.Text);
                if (success)
                {
                    username = loginUserBox.Text;
                    loginUserBox.Text = "";
                    loginPassBox.Text = "";
                    this.Visible = false;
                    new User_Form().ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    if (CultureInfo.CurrentCulture.Name.Equals("en-EN"))
                    {
                        MessageBox.Show("Wrong credentials. Please make sure that the user exists and the password is correct.");
                    }
                    else
                    {
                        MessageBox.Show("Λάθος στοιχεία. Παρακαλώ, επιβεβαιώστε πως υπάρχει ο χρήστης και ο κωδικός του είναι σωστός.");
                    }

                }
            }
            else
            {
                if (CultureInfo.CurrentCulture.Name.Equals("en-EN"))
                {
                    MessageBox.Show("Please fill both username and password");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, συμπληρώστε όνομα και κωδικό");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
