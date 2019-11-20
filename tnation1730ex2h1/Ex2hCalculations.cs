using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace tnation1730ex2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strdateA, string strdateB)
        {
            string result = "Invalid input";
            try
            {
                TimeSpan date = DateTime.Parse(strdateA) - (DateTime.Parse(strdateB));

                result = date.ToString() + " days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strdateA, string strdateB)
        {
            string result = "Invalid input";
            try
            {
                if (DateTime.Parse(strdateA) <= DateTime.Parse(strdateB))
                {
                    return "On time";
                }
                else if (DateTime.Parse(strdateA) > DateTime.Parse(strdateB))
                {
                    TimeSpan date = DateTime.Parse(strdateA) - (DateTime.Parse(strdateB));
                    result = date.ToString() + " days past due";
                }
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string chars)
        {
            string result = "Invalid input";
            try
            {
                chars = chars.Trim();
                chars = chars.Remove(0, 1);
                chars = chars.Insert(0, "cr");
                return chars;
            }
            catch { }

            return result;
        }
        public static string StringCalc02(string chars)
        {
            string result = "Invalid input";
            try
            {
                chars = chars.Trim();
                chars = chars.Remove(1, 1);
                chars = chars.Insert(1, "rit");
                return chars;
            }
            catch { }

            return result;
        }
        public static string StringCalc03(string chars)
        {
            chars = chars.Trim();
            string result = "Invalid input";

            if (chars.Length >= 6)
            {
                chars = chars.Substring(2, 4).ToUpper();
                return chars;
            }

            return result;
        }
        public static string StringCalc04(string chars)
        {
            chars = chars.Trim();
            string result = "Invalid input";

            if (chars.Length < 10)
            {
                chars = chars.PadLeft(10);
                chars = chars.Replace(" ", "*");
                return chars;
            }

            return result;
        }
        public static string StringCalc05(string chars)
        {
            chars = chars.Replace(" ", "");
            chars = chars.Replace("-", "");
            chars = chars.Replace("(", "");
            chars = chars.Replace(")", "");
            return chars;
        }
        public static string StringCalc06(string chars)
        {
            chars = chars.Replace(" ", "");
            chars = chars.Replace("-", "");
            chars = chars.Replace("(", "");
            chars = chars.Replace(")", "");
            if (chars.Length < 7)
            {
                return "Invalid input";
            }

            else if (chars.Length >= 7 && chars.Length < 10)
            {
                chars = chars.Insert(3, ".");
                return chars;
            }

            else if (chars.Length == 10)
            {
                chars = chars.Insert(3, ".");
                chars = chars.Insert(7, ".");
                return chars;
            }
            return chars;
        }
        public static string StringCalc07(string s1)
        {
            s1 = s1.Substring(0).ToLower();
            s1 = s1.IndexOf("pioneer").ToString();

            if (s1 == "-1")
            {
                return "Not found";
            }
            return "Found";
        }
        public static string StringCalc08(string s2)
        {
            string result = "Invalid input";
            if (s2.Contains(","))
            {
                string chars1 = s2.Substring(s2.IndexOf(",") + 2);
                s2 = chars1.Trim();
                return s2;
            }
            return result;
        }
        public static string StringCalc09(string s3)
        {
            s3 = s3.Trim();
            string result = "Invalid input";
            if (s3.Contains(" "))
            {
                string chars1 = s3.Substring(s3.LastIndexOf(" "));
                s3 = chars1.Trim();
                return s3;
            }
            return result;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1);
            sb.Append(", ");
            sb.Append(s2);
            sb.Append(", ");
            sb.Append(s3);
            return sb.ToString();
        }
    }
}