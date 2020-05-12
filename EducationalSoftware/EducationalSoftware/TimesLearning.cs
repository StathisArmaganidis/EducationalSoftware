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
        int chosen_number;
        int current_number;
        public TimesLearning(string snumber,int innumber)
        {
            
            InitializeComponent();
            this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(snumber);
            chosen_number = innumber;
            current_number = 1;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Equation eq = Equation_Factory.BuildEquation("known", chosen_number, current_number);
            if (current_number == 1)
            {
                this.pictureBox1.Visible = false;
            }
            if (eq.left_mult_digits.Count == 1)
            {
                this.Left_mult_1.Visible = true;
                this.Left_mult_1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_"+eq.left_mult_digits[0].ToString());
            }
            else if (eq.left_mult_digits.Count == 2)
            {
                this.Left_mult_1.Visible = true;
                this.Left_mult_2.Visible = true;
                this.Left_mult_1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.left_mult_digits[0].ToString());
                this.Left_mult_2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.left_mult_digits[1].ToString());
            }
            if (eq.right_mult_digits.Count == 1)
            {
                this.Right_mult_2.Visible = true;
                this.Right_mult_2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[0].ToString());
            }
            else if (eq.right_mult_digits.Count == 2)
            {
                this.Right_mult_1.Visible = true;
                this.Right_mult_2.Visible = true;
                this.Right_mult_1.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[0].ToString());
                this.Right_mult_2.Image = (Image)Properties.Resources.ResourceManager.GetObject("num_" + eq.right_mult_digits[1].ToString());
            }
                this.times.Visible = true;
                this.equal.Visible = true;
                this.Equal_3.Visible = true;
                this.Equal_2.Visible = true;
                this.Equal_1.Visible = true;
            current_number++;

        }
    }
}
