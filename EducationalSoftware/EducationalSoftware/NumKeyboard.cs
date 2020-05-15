using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSoftware
{
    class NumKeyboard
    {
        public PictureBox[] boxes;
        private NumericUpDown right_num;
        private NumericUpDown result_num;
        public NumKeyboard(PictureBox picture_r1, PictureBox picture_r2, PictureBox picture_res1, PictureBox picture_res2, PictureBox picture_res3, NumericUpDown right, NumericUpDown result)
        {
            boxes = new PictureBox[5] { picture_r1, picture_r2, picture_res1, picture_res2, picture_res3 };
            right_num = right;
            result_num = result;
        }

        /// <summary>
        /// Checks for the rightmost empty box in the equation
        /// </summary>
        /// <param name="sender"></param>
        public void CheckEmpty(object sender)
        {
            Button clickedbutton = (Button)sender;
            for (int i = 0; i < this.boxes.Length; i++)
            {
                if (this.boxes[i].Tag.ToString() == "empty")
                {
                    InsertNumber(clickedbutton, this.boxes[i]);
                    AddValue(clickedbutton, i);
                    break;
                }
            }
        }

        /// <summary>
        /// Inserts the clicked number's image to the equation.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        private void InsertNumber(Button source, PictureBox target)
        {
            target.Tag = source.Tag.ToString();
            target.Image = source.BackgroundImage;
        }

        /// <summary>
        /// Adds the value of the number typed to the correct number holder, checking for units / tens / hundreds.
        /// </summary>
        /// <param name="clicked"></param>
        /// <param name="i"></param>
        private void AddValue(Button clicked, int i)
        {
            if (i < 2)
            {
                if (i == 0)
                {
                    right_num.Value += Int32.Parse(clicked.Tag.ToString()) * 10;
                }
                else
                {
                    right_num.Value += Int32.Parse(clicked.Tag.ToString());
                }
                right_num.Value.ToString();
            }
            else
            {
                if (i == 2)
                {
                    result_num.Value += Int32.Parse(clicked.Tag.ToString()) * 100;
                }
                else if (i == 3)
                {
                    result_num.Value += Int32.Parse(clicked.Tag.ToString()) * 10;
                }
                else
                {
                    result_num.Value += Int32.Parse(clicked.Tag.ToString());
                }
            }
        }

        /// <summary>
        /// Checks for the leftmost filled number in the equation and removes it.
        /// </summary>
        public void DelNumber()
        {
            for (int i = this.boxes.Length - 1; i >= 0; i--)
            {
                if (this.boxes[i].Tag.ToString() != "empty" && this.boxes[i].Tag.ToString() != "given")
                {
                    SubtractValue(i);
                    this.boxes[i].Tag = "empty";
                    this.boxes[i].Image = null;
                    break;
                }
            }
        }

        /// <summary>
        /// After removing the number's image from the equation, removes the value from the holder.
        /// </summary>
        /// <param name="i"></param>
        private void SubtractValue(int i)
        {
            if (i < 2)
            {
                if (i == 0)
                {
                    right_num.Value -= Int32.Parse(boxes[i].Tag.ToString()) * 10;
                }
                else
                {
                    right_num.Value -= Int32.Parse(boxes[i].Tag.ToString());
                }
                right_num.Value.ToString();
            }
            else
            {
                if (i == 2)
                {
                    result_num.Value -= Int32.Parse(boxes[i].Tag.ToString()) * 100;
                }
                else if (i == 3)
                {
                    result_num.Value -= Int32.Parse(boxes[i].Tag.ToString()) * 10;
                }
                else
                {
                    result_num.Value -= Int32.Parse(boxes[i].Tag.ToString());
                }
            }
        }

        /// <summary>
        /// Divides the right / result values by 10 for every empty box in the equation.
        /// </summary>
        public void FixResult()
        {
            if (boxes[4].Image == null && boxes[4].Tag.ToString() == "empty")
            {
                result_num.Value = result_num.Value / 10;
            }
            if (boxes[3].Image == null && boxes[3].Tag.ToString() == "empty")
            {
                result_num.Value = result_num.Value / 10;
            }
            if (boxes[1].Image == null && boxes[1].Tag.ToString() == "empty")
            {
                right_num.Value = right_num.Value / 10;
            }
        }
    }
}

