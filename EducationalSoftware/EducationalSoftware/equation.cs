using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalSoftware
{
    class Equation
    {
        int left_side_number { get; set; }
        int right_side_number { get; set; }
        int equal_number { get; set; }

        Equation(int left_side,int right_side)
        {
            equal_number = left_side * right_side;
        }
    }
}
