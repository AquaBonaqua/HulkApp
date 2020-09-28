using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number from 1 to 100");
            int n = Convert.ToInt32(Console.ReadLine());
           
            string result;

            result = string.Join(" that ", Enumerable.Range(1, n).Select(i => $"i {(i % 2 == 1 ? "hate" : "love")}")) + " it";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
