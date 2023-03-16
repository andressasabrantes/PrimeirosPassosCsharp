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
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            string[] friends = new string[5];
            friends[0] = "Michael";
            friends[1] = "Ross";
            friends[2] = "Monica";
            friends[3] = "Chandler";
            friends[4] = "Joey";
            
            Console.WriteLine(friends[4]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine();
            Console.WriteLine(friends[3]);
        }

    }

}