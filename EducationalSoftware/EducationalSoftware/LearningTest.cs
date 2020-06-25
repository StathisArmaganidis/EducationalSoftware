using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    public partial class LearningTest : Form
    {
        Datamapper dm;
        float[] probabilities;
        float[] multipliers;
        int[] statistics;
        string[] numbers;
        string username = StartingForm.username;
        float starting_Prob;
        public LearningTest()
        {
            InitializeComponent();
            msglabel.Location = new Point(300, 200);
            dm = new Datamapper();
            probabilities = dm.GetStats(username);
            multipliers = dm.GetMultipliers(username);
            statistics = dm.GetStatistics("Practice_Statistics",username, DateTime.Now);
            numbers = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            starting_Prob = probabilities[0] / multipliers[0];
        }
        Random rnd = new Random();

        NumKeyboard keys;
        private void LearningTest_Load(object sender, EventArgs e)
        {
            keys = new NumKeyboard(picture_r1, picture_r2, picture_res1, picture_res2, picture_res3, RightNum, ResultNum);
            CreateQuestionaire();
        }

        /// <summary>
        /// Is called when difficulty is chosen. Makes Questionaire visible.
        /// </summary>
        private void CreateQuestionaire()
        {
            QuestionGroup.Location = new Point(this.Size.Width / 2 - QuestionGroup.Size.Width / 2, this.Size.Height / 2 - QuestionGroup.Size.Height / 2);
            QuestionGroup.Visible = true;
            CreateQuestion();
        }
        /// <summary>
        /// chooses randomly where the blank number will be and creates the equation.
        /// </summary>
        private void CreateQuestion()
        {
            picture_l1.Image = null;
            picture_l2.Image = null;
            picture_r1.Image = null;
            picture_r2.Image = null;
            picture_res1.Image = null;
            picture_res2.Image = null;
            picture_res3.Image = null;


            int rightnum = rnd.Next(0, 11);
            string chosen_number = RandomProbability.Choose(probabilities,numbers);
            int leftnum = Int32.Parse(chosen_number);
            Equation eq = new Equation(leftnum, rightnum, "right");

            int blank = rnd.Next(0, 2);//chooses randomly which number box of the multiplication will be blank.


            if (eq.left_mult_digits.Count == 2)
            {
                picture_l1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.left_mult_digits[1]);
                picture_l2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.left_mult_digits[0]);
            }
            else
            {
                picture_l1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.left_mult_digits[0]);
            }


            LeftNum.Value = leftnum;
            if (blank == 0)//the right number box is blank.
            {
                ResultNum.Value = leftnum * rightnum;
                RightNum.Value = 0;

                if (eq.equal_digits.Count >= 2)
                {
                    if (eq.equal_digits.Count == 3)
                    {
                        picture_res1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[2]);
                        picture_res2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[1]);
                        picture_res3.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[0]);
                    }
                    else
                    {
                        picture_res1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[1]);
                        picture_res2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[0]);
                    }
                }
                else
                {
                    picture_res1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.equal_digits[0]);
                }



                picture_r1.Image = Properties.Resources.questionmark;


                picture_r1.Tag = "empty";
                picture_r2.Tag = "empty";

                picture_res1.Tag = "given";
                picture_res2.Tag = "given";
                picture_res3.Tag = "given";
            }
            else//the result box is blank.
            {
                ResultNum.Value = 0;
                RightNum.Value = rightnum;

                if (eq.right_mult_digits.Count == 2)
                {
                    picture_r1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[1]);
                    picture_r2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[0]);
                }
                else
                {
                    picture_r1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[0]);
                }

                picture_res1.Image = Properties.Resources.questionmark;

                picture_res1.Tag = "empty";
                picture_res2.Tag = "empty";
                picture_res3.Tag = "empty";

                picture_r1.Tag = "given";
                picture_r2.Tag = "given";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            keys.FixResult();
            int index = (int)LeftNum.Value - 1;
            if (LeftNum.Value * RightNum.Value == ResultNum.Value)
            {
                msglabel.Text = "Correct!";
                statistics[2 * index]++;
                msglabel.ForeColor = Color.Green;
                QuestionGroup.Visible = false;
                msglabel.Visible = true;
                Wait();


                if (multipliers[index] > 0.9f)
                {
                    fix_probabilities(index, "-", 0.9f);
                }
            }
            else
            {
                msglabel.Text = "Wrong!";
                statistics[(2 * index)+1]++;
                msglabel.ForeColor = Color.Maroon;
                QuestionGroup.Visible = false;
                msglabel.Visible = true;
                Wait();
                if (multipliers[index] <= 7.2)
                {
                    fix_probabilities(index, "+", 1.8f);
                }
                CreateQuestion();

            }
            for (int i = 0; i < probabilities.Length; i++)
            {
                Console.WriteLine(probabilities[i] + " , " + multipliers[i]);
            }

            Datamapper dm = new Datamapper();
            dm.GetConnection();
            dm.SaveMultipliers(multipliers, StartingForm.username);
            dm.SaveStats(probabilities, StartingForm.username);
            dm.SaveStatistics("Practice_Statistics",StartingForm.username, statistics,DateTime.Now);
            CreateQuestion();
        }

        private void AddNumber(object sender, EventArgs e)
        {
            keys.CheckEmpty(sender);
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            keys.DelNumber();
        }

        /// <summary>
        /// Balances mutlipliers and calculates new probabilities.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="operation"></param>
        /// <param name="dif"></param>
        private void fix_probabilities(int index, string operation,float dif)
        {
            if (operation == "+")
            {
                multipliers[index] += dif;
                for (int i = 0; i < index; i++)
                {
                    multipliers[i] -= dif / 9;
                }
                for(int j = multipliers.Length-1; j > index; j--)
                {
                    multipliers[j] -= dif / 9;
                }
                for(int v = 0; v < probabilities.Length; v++)
                {
                    probabilities[v] =starting_Prob*multipliers[v];
                }
            }
            else
            {
                multipliers[index] = multipliers[index]-dif;
                for (int i = 0; i < index; i++)
                {
                    multipliers[i] += dif / 9;
                }
                for (int j = multipliers.Length-1; j > index; j--)
                {
                    multipliers[j] += dif / 9;
                }
                for (int v = 0; v < probabilities.Length; v++)
                {
                    probabilities[v] = starting_Prob* multipliers[v];
                }
            }
            
        }
        public async void Wait()
        {
            await Task.Delay(1000);
            msglabel.Visible = false;
            QuestionGroup.Visible = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

