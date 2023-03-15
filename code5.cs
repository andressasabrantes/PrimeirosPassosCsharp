using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 8);//13
            Console.WriteLine(15 - 5);//10
            Console.WriteLine(5 % 2);//1
            Console.WriteLine(4 + 2 * 3);//10
            Console.WriteLine((4 + 2) * 3);//18
            Console.WriteLine(5.8 + 2.6);//8.4
            Console.WriteLine(5 / 2);//2
            Console.WriteLine(5 / 2.0);//2.5

            //working with increment
            int num = 6;
            num++;
            Console.WriteLine(num);

            //working with decrement
            int numSubtraction = 6;
            numSubtraction--;
            Console.WriteLine(numSubtraction);

            //working with methods
            Console.WriteLine(Math.Abs(-40));//Absolute value -> 40
            Console.WriteLine(Math.Pow(3, 2));//Three raised to the second power -> 9
            Console.WriteLine(Math.Sqrt(36));//Square Root -> 6
            Console.WriteLine(Math.Max(5, 89));//Returns the biggest of two numbers
            Console.WriteLine(Math.Min(89, 5));//Returns the smaller of two numbers
            Console.WriteLine(Math.Round(4.3));//Rounds the number to the closest 
            Console.WriteLine(Math.Round(4.6));//Rounds the number to the closest 
        }
    }
}
