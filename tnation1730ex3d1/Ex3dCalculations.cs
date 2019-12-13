using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnation1730ex3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            string sbResult = "";

            foreach (int number in values)
            {
                sbResult += number + ", ";

            }

            string result = sbResult.TrimEnd(',', ' ').ToString();

            return result;
            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;

            foreach (int number in values)
            {
                if (number == searchValue)
                {
                    count++;
                }
            }
            return count;

            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter

        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            int count = 0;

            foreach (int number in values)
            {
                if (number >= searchMin && number <= searchMax)
                {
                    count++;
                }
            }

            return count;
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
        }
    }
}
