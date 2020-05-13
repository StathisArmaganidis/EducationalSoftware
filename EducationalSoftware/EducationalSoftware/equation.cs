using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalSoftware
{
    public class Equation
    {
       
        int left_side_number { get; set; }
        int right_side_number { get; set; }
        int equal_number { get; set; }
       public List<int> left_mult_digits = new List<int>();
       public List<int> right_mult_digits = new List<int>();
       public List<int> equal_digits = new List<int>();

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
        public int multiply() { return left_side_number * right_side_number;}
        public int divide() { return right_side_number / left_side_number; }
        public List<int> find_digits(int number)
        {
            List<int> digits = new List<int>();
            while (number > 0)
            {
                int digit = number % 10;
                digits.Add(digit);
                number /= 10;
            }
            return digits;
        }

    }
}
