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

        private void CreateQuestion()
        {
            ThisQuestionNum++;
            ThisQuestionsText.Text = ThisQuestionNum.ToString();
            int blank = rnd.Next(0, 3);//chooses randomly which number box of the multiplication will be blank.
            int leftnum = rnd.Next(0, 10);
            int rightnum = rnd.Next(0, 10);
            int ans = leftnum * rightnum;
            if (blank == 0)//the left number box is blank.
            {
                RightNumText.Value = rightnum;
                RightNumText.Enabled = false;

                ResultNum.Value = ans;
                ResultNum.Enabled = false;

                LeftNumText.Value = 0;
                LeftNumText.Enabled = true;
            }
            else if(blank==1)//the right number box is blank.
            {
                LeftNumText.Value = leftnum;
                LeftNumText.Enabled = false;

                ResultNum.Value = ans;
                ResultNum.Enabled = false;

                RightNumText.Value = 0;
                RightNumText.Enabled = true;
            }
            else
            {
                RightNumText.Value = rightnum;
                RightNumText.Enabled = false;

                LeftNumText.Value = leftnum;
                LeftNumText.Enabled = false;

                ResultNum.Value = 0;
                ResultNum.Enabled = true;
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
                CreateQuestion();
            }
            else
            {
                MessageBox.Show("yay! "+points.ToString()+" points!");//test
            }
            
        }
    }
}
