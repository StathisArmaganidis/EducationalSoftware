﻿using System;
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
        Datamapper dm ;
        public StartingForm()
        {
            InitializeComponent();
            dm = new Datamapper();
            dm.GetConnection();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            LoginGroup.Location = new Point(this.Size.Width / 2 - LoginGroup.Size.Width / 2, this.Size.Height / 2 - LoginGroup.Size.Height);
            RegisterGroup.Location = new Point(this.Size.Width / 2 - RegisterGroup.Size.Width / 2, this.Size.Height / 2 - RegisterGroup.Size.Height);
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
                Console.WriteLine("Registration Executed Succesfully? Answer: " + success);
                if (success)
                {
                    registerUserBox.Text = "";
                    registerPassBox.Text = "";
                }
                else
                {
                    MessageBox.Show("There was a problem with the database, please try again...");
                }
            }
            else
            {
                MessageBox.Show("Please fill both username and password");
            }
        }


    }
}
