﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnation1730ex2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4: if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5: Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6: nested if statements
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else discountPercent = 0.1m;
            }
            else        // customerType isn't "R"                
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal price = 0m;
            decimal quant = 0m;
            decimal amount = 0m;
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                price = Decimal.Parse(inputA);
                quant = Decimal.Parse(inputB);
                amount = price * quant;
                if (amount >= 50)
                    total = amount;

                else total = (amount + 5m);
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal prevmonth = 0m;
            decimal nextmonth = 0m;
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                prevmonth = Decimal.Parse(inputA);
                nextmonth = Decimal.Parse(inputB);
                if (prevmonth > nextmonth)
                    return "Invalid input";
                else total = (nextmonth - prevmonth) * .1m;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            double result = 0.0;
            double left = 0.0;
            double right = 0.0;
            if (inputA != "" && inputB != "")
            {
                if (inputA != "0" && inputB != "0")
                {
                    left = Double.Parse(inputA);
                    right = Double.Parse(inputB);
                    if (left > right)
                        result = (left / right);
                    else if (left < right)
                        result = (right / left);

                    return result.ToString("n2");
                }
                return "Invalid input";
            }
            return "Invalid input";
        }
    }
}
