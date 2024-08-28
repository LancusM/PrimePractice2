using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int givenNum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= givenNum; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {

                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
