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
            SayHi("Rachel", 27);
            SayHi("Aria", 22);
            SayHi("Emily", 29);
            Console.WriteLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "! " + "You're "+ age + " years old!");
        }

    }

}
