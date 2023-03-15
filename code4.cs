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
            Console.WriteLine("Giraffe\nAcademy"); //Print out on different lines

            string phrase = "Giraffe Academy 2";
            Console.WriteLine(phrase); //printing a variable

            string phrase2 = "Giraffe Academy" + "is cool";
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase2.Length); //Counting how many characters there are in phrase2
            Console.WriteLine(phrase2.ToUpper()); //returns all caps
            Console.WriteLine(phrase2.ToLower()); //returns all characters in lower case
            Console.WriteLine(phrase2.Contains("is")); //returns whether or not the phrase2 contains what you're looking for
            Console.WriteLine(phrase2.Contains("not cool")); //returns whether or not the phrase2 contains what you're looking for
            Console.WriteLine(phrase2[2]); //returns the index position of the character
            Console.WriteLine(phrase2[6]); //returns the index position of the character
            Console.WriteLine(phrase2.IndexOf("cool")); //tell us if a string contains a certain value and tell us what index position the string starts at
            Console.WriteLine(phrase2.IndexOf("Academy")); //tell us if a string contains a certain value and tell us what index position the string starts at
            Console.WriteLine(phrase2.IndexOf("P")); //if the certain value does not contains in the string, it will return -1
            Console.WriteLine(phrase2.Substring(8)); //Grabs the characters starting at eight and goes to the end of the string
            Console.WriteLine(phrase2.Substring(8, 7)); //Grabs the string starting at eight and passes how many characters I want to grab 
        }
    }
}
