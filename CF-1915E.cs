using System;
using System.Collections.Generic;
namespace Codeforces
{
    class CF_1915E
    {
        static void solve()
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            string[] arr = input.Split(' ');

            long[,] PreSum = new long[2, n];

            long SumOdd = 0, SumEven = 0, x = 0;
            for (int i = 0; i < n; i++)
            {
                x = long.Parse(arr[i]);
                if (i % 2 == 1) SumEven += x;
                else SumOdd += x;
                PreSum[0, i] = SumOdd;
                PreSum[1, i] = SumEven;
            }

            SortedSet<long> st = new SortedSet<long>();

            long diff = 0;
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                diff = PreSum[0, i] - PreSum[1, i];
                if (st.Contains(diff) || diff == 0)
                {
                    ok = true;
                    break;
                }
                st.Add(diff);
            }

            Console.WriteLine((ok) ? "Yes\n" : "No\n");
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
                solve();
        }
    }
}

