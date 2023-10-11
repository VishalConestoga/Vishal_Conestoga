using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180) 
            {
                result = "THE TRIANGLE IS VALID.";
            }
            else
            {
                result = "THE TRIANGLE CREATED BY (VISHAL THAKOR) IS NOT VALID.";
            }
            return result;
        }
    }
}

