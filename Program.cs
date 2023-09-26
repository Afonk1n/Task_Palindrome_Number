using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(x.ToString().ToCharArray(), n => (int)Char.GetNumericValue(n));
            int l = 0;
            int r = arr.Length - 1;
            bool result = true;
            while (l < r)
            {
                if (arr[l] != arr[r])
                    result = false;
                l++;
                r--;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
