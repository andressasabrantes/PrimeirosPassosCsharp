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
            Console.WriteLine(GetPower(3, 5));
        }

        static int GetPower(int baseNum, int powerNum)
        {
            int result = 1;
            for (int i = 0; i < powerNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }

}
