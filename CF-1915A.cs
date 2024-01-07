namespace Codeforces
{
    internal class CF_1915A
    {
        static void solve()
        {
            string s = Console.ReadLine();
            string[] nums = s.Split(' ');

            if (nums[0] == nums[1])
                Console.WriteLine(nums[2]);
            else if (nums[1] == nums[2])
                Console.WriteLine(nums[0]);
            else
                Console.WriteLine(nums[1]);
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
                solve();
        }
    }
}