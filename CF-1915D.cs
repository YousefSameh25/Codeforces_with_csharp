using System.Text;

namespace SolvingHere
{
    internal class CF_1915D
    {
        static Dictionary<char, char> dic = new Dictionary<char, char> {
                { 'a', 'v' },
                { 'e', 'v' },
                { 'b', 'c' },
                { 'c', 'c' },
                { 'd', 'c' }
        };
        static void solve()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (dic[s[i]] == 'v')
                    sb.Append(s[i]);
                else
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(s[i]);
                        continue;
                    }

                    if (i + 1 < n)
                    {
                        if (dic[s[i + 1]] == 'c')
                        {
                            sb.Append(s[i]);
                            ans.Append(sb);
                            ans.Append(".");
                            sb.Clear();
                        }
                        else
                        {
                            ans.Append(sb);
                            ans.Append(".");
                            sb.Clear();
                            sb.Append(s[i]);
                        }
                    }
                    else
                    {
                        sb.Append(s[i]);
                        ans.Append(sb);
                        sb.Clear();
                    }
                }
            }
            if (sb.Length > 0)
                ans.Append(sb);

            Console.WriteLine(ans);

        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
                solve();
        }
    }
}
