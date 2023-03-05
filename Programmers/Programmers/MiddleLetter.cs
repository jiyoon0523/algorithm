using System;

namespace Programmers
{
    internal class MiddleLetter
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("abcde"));
            Console.WriteLine(Solution("qwer"));
        }

        public static string Solution(string s)
        {
            string answer = "";
            var chars = s.ToCharArray();
            var count = chars.Length;
            var isOdd = count % 2 == 1;
            if (isOdd) answer = s.Substring(count / 2, 1); //faster(0.05ms)
            //if (isOdd) answer = chars[count / 2].ToString();
            else answer = s.Substring(count / 2 - 1, 2);
            return answer;
        }

        public static string SolutionRevised(string s)
        {
            string answer = "";
            var count = s.Length;
            var isOdd = count % 2 == 1;
            if (isOdd) answer = s.Substring(count / 2, 1);
            else answer = s.Substring(count / 2 - 1, 2);
            return answer;
        }

        public static string Solution2(string s)
        {
            int n = (s.Length + 1) % 2;
            int l = s.Length / 2 - n;
            return s.Substring(l, n + 1);
        }

        //how to add chars to string
        //s += 'c';
        //s = s + 'c';
        //s = s.Insert(s.Length, "c");

        //check if variables are unnecessarily allocated before submitting
    }
}
