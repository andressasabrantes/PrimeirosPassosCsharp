using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            int[,] myArray = new int[2, 3];
            myArray[1, 2] = 10;
            myArray[0, 0] = 85;


            Console.WriteLine(numberGrid[1,1]);
            Console.WriteLine(myArray[0, 0]);

        }

    }

}
