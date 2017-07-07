using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my numbers game!");

            Console.WriteLine("/n" + "Please pick a low, starting number for your number range");
            int startingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("/n" + "Awesome! Now choose a high, ending number that's at least 50 more than starting numnber ");
            int endingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("/n" + "Now choose 6 lucky numbers ")
        }
    }
}
