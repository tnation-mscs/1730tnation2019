using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnation1730ex3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int i = index;

            if (index >= 1 && index <= days.Length)

            return days[i - 1];

            else
            {
                return "Invalid index";
            }
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            string search1 = search.Trim().ToUpper();
            int index = Array.IndexOf(days, search1);

            if (index >= 0 && index <= days.Length)

                return hours[index];

            else
            {
                return "Invalid input";
            }
        }

        public static int Calc2(int[] numbers2)
        {
            int sum = 0;

            foreach (int total in numbers2)
                sum += total;

            return sum;
        }

        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;

            if (count > numbers.GetLength(0))
                sum = 0.0;

            else
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
            }

            return sum;
        }

        public static double Calc5(double[] numbers)
        {

            int count = numbers.Length;

            if (numbers.Length > 0)
            {
            double number = Calc3(numbers, count);
            double average = number / count;
                
            return average;
            }

            return -1;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();

            if (length > 0)
            {
                double avg = Calc5(numbers);

                foreach (double number in numbers)
                {
                    if (number >= avg)
                        aboveAvgList.Add(number);
                }
            }

            return aboveAvgList.ToArray();
        }
    }
}
