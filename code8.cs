using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            string adjective1, adjective2, noun1, noun2, pluralNoun1, game, pluralNoun2, ing1, ing2, pluralNoun3, ing3, noun3, plant, partOfTheBody, place, ing4, adjective3, pluralNoun4;
            double number;

            Console.Write("Enter an adjective: ");
            adjective1 = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            adjective2 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            noun1 = Console.ReadLine();

            Console.Write("Enter another noun: ");
            noun2 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun1 = Console.ReadLine();

            Console.Write("Enter a game: ");
            game = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun2 = Console.ReadLine();

            Console.Write("Enter a a verb ending in 'ING': ");
            ing1 = Console.ReadLine();

            Console.Write("Enter another verb ending in 'ING': ");
            ing2 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun3 = Console.ReadLine();

            Console.Write("Enter a verb ending in 'ING': ");
            ing3 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            noun3 = Console.ReadLine();

            Console.Write("Enter the name of a plant: ");
            plant = Console.ReadLine();

            Console.Write("Enter a part of the body: ");
            partOfTheBody = Console.ReadLine();

            Console.Write("Enter a place: ");
            place = Console.ReadLine();


            Console.Write("Enter a a verb ending in 'ING': ");
            ing4 = Console.ReadLine();


            Console.Write("Enter an adjective: ");
            adjective3 = Console.ReadLine();


            Console.Write("Enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter a plural noun: ");
            pluralNoun4 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Here's your Mad Libs: ");
            Console.WriteLine();
            Console.WriteLine("A vacation is when you take a trip to some " + adjective1 + " place");
            Console.WriteLine("with your " + adjective2  + " family. Usually you go to some place");
            Console.WriteLine("that is near a/an " + noun1 + " or up on a/an " + noun2 + ".");
            Console.WriteLine("A good vacation place is one where you can ride " + pluralNoun1);
            Console.WriteLine("or play " + game + " or go haunting for " + pluralNoun2 + ".");
            Console.WriteLine("I like to spend my time " + ing1 + " or " + ing2 + ".");
            Console.WriteLine("When parents go on vacation, they spend their time eating");
            Console.WriteLine("three " + pluralNoun3 + " a day, and fathers play golf, and mothers");
            Console.WriteLine("sit around " + ing3 + ". Last summer, my little brother");
            Console.WriteLine("fell in a/an " + noun3 + " and got poison by a " + plant + " all");
            Console.WriteLine("over his " + partOfTheBody + ". My family is going to go to (the)");
            Console.WriteLine(place + ", and I will practice " + ing4 + ".");
            Console.WriteLine("Parents need vacations more than kids because parents are always very");
            Console.WriteLine(adjective3 + " and beacuse they have to work " + number);
            Console.WriteLine("hours every day all year making enough " + pluralNoun4 + " to pay");
            Console.WriteLine("for the vacation.");
        }
    }
}
