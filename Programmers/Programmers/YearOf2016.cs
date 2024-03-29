﻿using System;

namespace Programmers
{
    public class YearOf2016
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(1, 1));
            Console.WriteLine(Solution(5, 24));
        }

        static string[] dayArray = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        static int[] dateArray = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public static string Solution(int a, int b)
        {
            int days = 0; //could init as b-1
            for (int i = 0; i < a - 1; i++)
            {
                days += dateArray[i];
            }
            days += b;
            days -= 1;

            var fromFri = days % 7;
            string answer = dayArray[fromFri];

            return answer;
        }

        public static string Solution2(int a, int b)
        {
            string answer = "";
            DateTime date = new DateTime(2016, a, b);
            answer = date.DayOfWeek.ToString().Substring(0, 3).ToUpper();
            //answer = date.ToString("ddd").ToUpper();
            
            return answer;
        }
    }
}
