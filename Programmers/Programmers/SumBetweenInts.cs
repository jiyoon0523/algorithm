using System;

namespace Programmers
{
    internal class SumBetweenInts
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(3, 5));
            Console.WriteLine(Solution(3, 3));
            Console.WriteLine(Solution(5, 3));
        }

        public static long Solution(int a, int b)
        {
            long answer = 0;

            var diff = b - a;

            if (diff == 0) return a;
            if (diff < 0)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
                answer += i;
            
            return answer;
        }

        public static long Solution2(int a, int b)
        {
            long answer = 0;

            while (a != b)
            {
                answer += a;
                a = (a > b) ? a - 1 : a + 1;
            }

            return answer + b;
        }

        public static long Solution3(int a, int b)
        {
            return (a + b) / 2 * (Math.Abs(b - a) + 1);
        }

        public static long Solution4(int a, int b)
        {
            var answer = 0;

            (var min, var max) = a > b ? (b, a) : (a, b);

            for(int i=min; i<=max; i++)
            {
                answer += i;
            }

            return answer;
        }

    }
}
