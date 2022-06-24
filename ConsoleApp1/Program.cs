using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };
            int[] nums3 = (int[])nums1.Concat(nums2);
            Console.WriteLine(nums3);
        }

    }
}
