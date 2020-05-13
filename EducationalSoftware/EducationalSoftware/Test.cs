using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        PictureBox[] boxes;
        private void TestForm_Load(object sender, EventArgs e)
        {
            DifficultyGroup.Location = new Point(this.Size.Width / 2 - DifficultyGroup.Size.Width / 2, this.Size.Height / 2 - DifficultyGroup.Size.Height / 2);
            boxes = new PictureBox[5] { picture_r1, picture_r2, picture_res1, picture_res3, picture_res3 };
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

            picture_l2.Visible = true;

            picture_l2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + leftnum);

            LeftNumText.Value = leftnum;
            if (blank == 0)//the right number box is blank.
            {


                ///Result
                int div100 = ans / 100;
                int div10 = ans / 10;
                int remains = ans - div100 * 100 - div10 * 10;
                if (div100 > 0)
                {
                    picture_res1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + div100);
                }
                else
                {
                    picture_res1.Image = null;
                }
                if (div10 > 0)
                {
                    picture_res2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + div10);
                }
                else
                {
                    picture_res2.Image = null;
                }
                picture_res3.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + remains);


                picture_res2.Visible = true;
                picture_res3.Visible = true;

                ResultNum.Value = ans;

                //Right number
                picture_r1.Visible = false;
                picture_r2.Image = Properties.Resources.questionmark;
                RightNumText.Value = 0;

                picture_r1.Tag = "empty";
                picture_r2.Tag = "empty";

                picture_res1.Tag = "filled";
                picture_res2.Tag = "filled";
                picture_res3.Tag = "filled";
            }
            else//the result box is blank.
            {
                picture_r1.Visible = true;
                int div10 = rightnum / 10;
                int remains = rightnum - div10 * 10;
                picture_r1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + div10);
                picture_r2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + remains);

                RightNumText.Value = rightnum;

                picture_res1.Image = Properties.Resources.questionmark;
                picture_res2.Visible = false;
                picture_res3.Visible = false;
                ResultNum.Value = 0;

                picture_res1.Tag = "empty";
                picture_res2.Tag = "empty";
                picture_res3.Tag = "empty";

                picture_r1.Tag = "filled";
                picture_r2.Tag = "filled";
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

        private void AddNumber(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            for(int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].Tag.ToString() == "empty")
                {
                    InsertNumber(clickedbutton, boxes[i]);
                }
            }
        }

        private void InsertNumber(Button source, PictureBox target)
        {
            target.Image = source.BackgroundImage;
        }
    }
}
