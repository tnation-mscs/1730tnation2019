using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnation1730ex3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = 0.0;

            celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }

        public static double CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = celsius * 1.8 + 32;
            return fahrenheit;
        }

        public static decimal GrossPay(decimal hours, decimal payRate)
        {
            decimal grossPay = 0.0m;

            if (hours <= 40m)
            {
                grossPay = hours * payRate;
            }
            else
                grossPay = (40 * payRate) + (hours - 40) * (payRate * 1.5m);

            return grossPay;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }


            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal payRate)
        {
            decimal total = 0;
            int startIndex = 0;
            decimal grossPay = 0.0m;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            if (total <= 40m)
            {
                grossPay = total * payRate;
            }
            else
                grossPay = (40 * payRate) + (total - 40) * (payRate * 1.5m);

            return grossPay;
        }
    }
}
