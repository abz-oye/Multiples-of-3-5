using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            List<int> mult = new List<int>();
            int total = 0;

            for (int i = 1; i < n; i++)
            {
                nums[i] = i;
            }

            foreach (int s in nums)
            {
                if (s % 3 == 0 || s % 5 == 0)
                {
                    mult.Add(s);
                    total = total + s;
                }
            }
            Console.WriteLine(total);
        }
    }
}
