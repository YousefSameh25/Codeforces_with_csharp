using System;
using System.Collections.Generic;
namespace Codeforces
{
    internal class CF_1915B
    {
        static void solve()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string s = Console.ReadLine();
                list.Add(s);
            }

            char[] L = { 'A', 'B', 'C' };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (list[i][j] != '?')
                        continue;

                    SortedSet<char> st = new SortedSet<char>();

                    // Loop on this row
                    for (int c = 0; c < 3; c++)
                        st.Add(list[i][c]);

                    // Loop on this column
                    for (int r = 0; r < 3; r++)
                        st.Add(list[r][j]);

                    for (int c = 0; c < 3; c++)
                    {
                        if (!st.Contains(L[c]))
                        {
                            Console.WriteLine(L[c]);
                            return;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
                solve();
        }
    }
}
