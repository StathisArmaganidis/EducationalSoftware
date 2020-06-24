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
   
    public partial class TimesLearning : Form
    {
        NumKeyboard keyboard;
        int current_index;
        List<(Equation,int)> equations = new List<(Equation,int)>();
        PictureBox[] left_pict;
        PictureBox[] right_pict ;
        PictureBox[] eq_pict;
        bool first = true;
        public TimesLearning(string snumber,int innumber)
        {
            
            InitializeComponent();
            this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(snumber+"_chalk");
            for (int i = 0; i <= 10; i++)
            {
                equations.Add((new Equation(innumber, i, "right"),0));
            }
            this.left_pict =new PictureBox[2]{Left_mult_1,Left_mult_2};
            this.right_pict = new PictureBox[2] {Right_mult_1, Right_mult_2 };
            this.eq_pict = new PictureBox[3] { Equal_1, Equal_2,Equal_3 };
            this.leftnum.Value = innumber;
            current_index = 0;
            keyboard = new NumKeyboard(Right_mult_2, Right_mult_1, Equal_3, Equal_2, Equal_1, rightnum, eqnum);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.eqnum.Value = 0;
            this.ConfirmButton.Enabled = true;
            this.keyboardpanel.Enabled = true;
            this.panel1.BackColor = SystemColors.Control;
            
            for(int i = 0; i < eq_pict.Length; i++)
            {
                eq_pict[i].Image = null;
                eq_pict[i].Tag = "empty";
            }
            left_pict[0].Visible = false;
            left_pict[1].Visible = false;
            right_pict[0].Visible = false;
            right_pict[1].Visible = false;
            if (first)
            {
                
                this.pictureBox1.Visible = false;
                this.keyboardpanel.Visible = true;
                questionpanel.Visible = true;
                first = !first;
            }
            if (equations.Any())
            {
                for (int i = 0; i < equations[current_index].Item1.left_mult_digits.Count; i++)
                {
                    left_pict[i].Visible = true;
                    left_pict[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + equations[current_index].Item1.left_mult_digits[i].ToString());
                }
                for (int i = 0; i < equations[current_index].Item1.right_mult_digits.Count; i++)
                {
                    right_pict[i].Visible = true;
                    right_pict[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + equations[current_index].Item1.right_mult_digits[i].ToString());
                    
                }


                this.Next.Enabled = false;
            }
            else
            {
                questionpanel.Visible = false;
                keyboardpanel.Visible = false;
                endlabel.Visible = true;
                backtomenu.Visible = true;
                Next.Visible = false;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.ConfirmButton.Enabled = false;
            this.keyboardpanel.Enabled = false;
            this.Next.Enabled = true;
            keyboard.FixResult();
            if (this.eqnum.Value == equations[current_index].Item1.equal_number)
            {
                this.panel1.BackColor = Color.FromArgb(128, 255, 128);
                equations.RemoveAt(current_index);
            }
            else
            {

                this.panel1.BackColor = Color.FromArgb(255, 128, 128);
                this.panel1.Location = new Point(this.panel1.Location.X + 5, this.panel1.Location.Y);
                System.Threading.Thread.Sleep(100);
                this.panel1.Location = new Point(this.panel1.Location.X - 5, this.panel1.Location.Y);
                if (equations[current_index].Item2 >= 2)
                {
                    DialogResult wrong = MessageBox.Show("Would you like to see the solution?", "Wrong", MessageBoxButtons.YesNo);
                    if (wrong == DialogResult.Yes)
                    {
                        for (int i = 0; i < eq_pict.Length; i++)
                        {
                            eq_pict[i].Image = null;
                            eq_pict[i].Tag = "empty";
                        }
                        for (int i = 0; i < equations[current_index].Item1.equal_digits.Count; i++)
                        {
                            eq_pict[i].Visible = true;
                            eq_pict[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + equations[current_index].Item1.equal_digits[i].ToString());
                            this.panel1.BackColor = Color.Yellow;
                        }
                    }
                    else if (wrong == DialogResult.No)
                    {
                    }

                }
                equations.Add((equations[current_index].Item1, equations[current_index].Item2 + 1));
                equations.RemoveAt(current_index);
            }
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboard_click(object sender, EventArgs e)
        {
            keyboard.CheckEmpty(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            keyboard.DelNumber();
        }


    }
}
