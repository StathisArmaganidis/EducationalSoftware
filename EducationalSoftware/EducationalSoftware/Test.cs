﻿using System;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private int TotalQuestionsNum;
        private int ThisQuestionNum = 0;
        private int points = 0;
        Random rnd = new Random();

        private int[] done = new int[10];
        private void TestForm_Load(object sender, EventArgs e)
        {
            DifficultyGroup.Location = new Point(this.Size.Width / 2 - DifficultyGroup.Size.Width / 2, this.Size.Height / 2 - DifficultyGroup.Size.Height / 2);
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            TotalQuestionsNum = 10;
            CreateQuestionaire();
        }        

        private void MediumButton_Click(object sender, EventArgs e)
        {
            TotalQuestionsNum = 15;
            CreateQuestionaire();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            TotalQuestionsNum = 20;
            CreateQuestionaire();
        }

        /// <summary>
        /// Is called when difficulty is chosen. Makes Questionaire visible.
        /// </summary>
        private void CreateQuestionaire()
        {
            DifficultyGroup.Visible = false;
            QuestionGroup.Location = new Point(this.Size.Width / 2 - QuestionGroup.Size.Width / 2, this.Size.Height / 2 - QuestionGroup.Size.Height / 2);
            QuestionGroup.Visible = true;
            QuestionLabel.Visible = true;
            ThisQuestionsText.Visible = true;
            QuestionSlash.Visible = true;
            TotalQuestionsText.Visible = true;
            TotalQuestionsText.Text = TotalQuestionsNum.ToString();
            CreateQuestion();
        }
        /// <summary>
        /// chooses randomly where the blank number will be and creates the equation.
        /// </summary>
        private void CreateQuestion()
        {
            ThisQuestionNum++;
            ThisQuestionsText.Text = ThisQuestionNum.ToString();
            int blank = rnd.Next(0, 2);//chooses randomly which number box of the multiplication will be blank.
            int rightnum = rnd.Next(0, 11);
            int leftnum;
            do
            {
                leftnum = rnd.Next(1, 11);
            } while (done[leftnum-1]==1);
            done[leftnum - 1] = 1;
            if (!done.Contains(0))
            {
                Array.Clear(done, 0, done.Length);
            }
            int ans = leftnum * rightnum;

            pictureBox1.Visible = true;

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + leftnum);

            LeftNumText.Value = leftnum;
            if (blank == 0)//the right number box is blank.
            {


                ///Result
                int div = ans / 10;
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + div);

                pictureBox4.Location = new Point(pictureBox3.Location.X + pictureBox3.Width+5, pictureBox3.Location.Y);
                int remains = ans - div*10;
                pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + remains);
                pictureBox4.Visible = true;

                ResultNum.Value = ans;

                //Right number
                pictureBox2.Image = Properties.Resources.questionmark;
                RightNumText.Value = 0;
            }
            else//the result box is blank.
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + rightnum);

                RightNumText.Value = rightnum;

                pictureBox3.Image = Properties.Resources.questionmark;
                pictureBox4.Visible = false;
                ResultNum.Value = 0;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (LeftNumText.Value * RightNumText.Value == ResultNum.Value)
            {
                points++;
                MessageBox.Show("Correct Answer! Well Done");
            }
            else
            {
                MessageBox.Show("Oh, no! Wrong answer. \nBetter luck next time!");
            }
            if (ThisQuestionNum < TotalQuestionsNum)
            {
                ConfirmButton.Enabled = true;
                BackButton.Enabled = false;
                CreateQuestion();
            }
            else
            {
                MessageBox.Show("yay! "+points.ToString()+" out of "+TotalQuestionsNum.ToString()+" correct answets!");//test
                BackButton.Enabled = true;
                ConfirmButton.Enabled = false;
            }            
        }
    }
}
