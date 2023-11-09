using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[] { 15,20,13,7};

            foreach (int x in nums)
            {
                sum += x;
                Console.WriteLine(sum);
            }
        }
    }
}
