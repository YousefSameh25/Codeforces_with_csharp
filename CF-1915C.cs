using System;
using System.Collections.Generic;
namespace Codeforces
{
    internal class CF_1915C
    {
        static void solve()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            List<string> list = s.Split(' ').ToList();
            long sum = 0;
            for (int i = 0; i < n; i++)
                sum += long.Parse(list[i]);

            long sr = (long) Math.Sqrt(sum);
            Console.WriteLine(sr * sr == sum ? "YES" : "NO");
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
                solve();
        }
    }
}
