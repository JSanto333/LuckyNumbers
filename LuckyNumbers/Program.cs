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
            Random ranNum = new Random();
            string playAgain; 
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to my numbers game!");

                Console.WriteLine("\nPlease pick a low, starting number for your number range");
                int startingNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("\nAwesome! Now choose a high, ending number that's at least 50 more than starting number ");
                int endingNumber = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("\nNow choose 6 lucky numbers ");
                int userNumber;
                int i;
                int[] pickNumbers = new int[6];
                for (i = 0; i < 6; i++)
                {
                    Console.Write("Number : ", i);
                    userNumber = int.Parse(Console.ReadLine());
                    while (userNumber < startingNumber || userNumber > endingNumber)
                    {
                        Console.Write("Enter a number inside the range\nNumber : ", i);
                        userNumber = int.Parse(Console.ReadLine());
                    }
                    pickNumbers[i] = userNumber;
                }
                int[] arrayOfRandomNumbers = new int[6];
                int j;
                int randomNumber;
                for (j = 0; j < 6; j++)
                {
                    randomNumber = ranNum.Next(startingNumber, endingNumber);
                    arrayOfRandomNumbers[j] = randomNumber;
                }
                foreach (int n in arrayOfRandomNumbers)
                {
                    Console.WriteLine("Lucky number: " + n);
                }
                double amountOfJackpot = 378954.00;
                Console.WriteLine("This is the winning total for the jackpot! : " + amountOfJackpot.ToString("C2"));
                int totalCorrectPicks = 0;
                int k;
                for (k = 0; k < 6; k++)
                {

                    if (pickNumbers[0] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                    if (pickNumbers[1] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                    if (pickNumbers[2] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                    if (pickNumbers[3] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                    if (pickNumbers[4] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                    if (pickNumbers[5] == arrayOfRandomNumbers[k])
                    {
                        totalCorrectPicks += 1;
                    }
                }
                Console.WriteLine("\nYou guessed " + totalCorrectPicks + " numbers correctly!");
                double userWinnings = 0;
                switch (totalCorrectPicks)
                {
                    case 0:
                        userWinnings = 0;
                        break;
                    case 1:
                        userWinnings = (amountOfJackpot * .10);
                        break;
                    case 2:
                        userWinnings = (amountOfJackpot * .25);
                        break;
                    case 3:
                        userWinnings = (amountOfJackpot * .40);
                        break;
                    case 4:
                        userWinnings = (amountOfJackpot * .55);
                        break;
                    case 5:
                        userWinnings = (amountOfJackpot * .70);
                        break;
                    case 6:
                        userWinnings = (amountOfJackpot);
                        break;
                }
                Console.WriteLine("\nYou won " + userWinnings.ToString("C2") + "!");
                Console.WriteLine("\nWould you like to play the game again?");
                playAgain = Console.ReadLine().ToUpper();
            }while (playAgain == "YES");
            while (playAgain == "NO")
            {
                Console.WriteLine("\n\"Thanks for playing!\"\n");
                return;
            }           
        }
    }
}
