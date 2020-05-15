using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalSoftware
{
    public class Equation
    {
       
       public int left_side_number { get; set; }
       public int right_side_number { get; set; }
       public int equal_number { get; set; }
       public List<int> left_mult_digits = new List<int>();
       public List<int> right_mult_digits = new List<int>();
       public List<int> equal_digits = new List<int>();

        /// <summary>
        /// Creates the equation and calculates the missing numbers.
        /// </summary>
        /// <param name="left_side"></param>
        /// <param name="right_side"></param>
        /// <param name="type"></param>
        public Equation(int left_side,int right_side,string type)
        {
            this.left_side_number = left_side;
            left_mult_digits = find_digits(left_side);
            if (type == "right")
            {
              
                this.right_side_number = right_side;
                this.equal_number = multiply();
                right_mult_digits = find_digits(right_side);
                equal_digits = find_digits(equal_number);
            }
            else
            {
                this.left_side_number = left_side;
                this.equal_number= right_side;
                this.right_side_number = divide();
                right_mult_digits = find_digits(right_side);
                equal_digits = find_digits(equal_number);
            }

        }
        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <returns></returns>
        public int multiply() { return left_side_number * right_side_number;}
        /// <summary>
        /// Divides the second number from the first one.
        /// </summary>
        /// <returns></returns>
        public int divide() { return right_side_number / left_side_number; }
        /// <summary>
        ///Finds the digits of a number and returns a list.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<int> find_digits(int number)
        {
            List<int> digits = new List<int>();
            do
            {
                int digit = number % 10;
                digits.Add(digit);
                number /= 10;
            } while (number > 0);
            return digits;
        }

    }
}
