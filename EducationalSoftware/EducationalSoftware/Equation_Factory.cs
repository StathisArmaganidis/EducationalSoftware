using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalSoftware
{
    public static class Equation_Factory
    {
        public static Equation BuildEquation(string type,int left_side,int right_side)
        {
            switch (type)
            {
                case "known":
                    return new Equation(left_side,right_side);
                case "unknown":
                    return new Equation(left_side);
                default:
                    return new Equation(left_side);
            }
        }
    }
}
