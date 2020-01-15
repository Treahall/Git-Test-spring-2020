using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {      
        static void Main(string[] args)
        {
            Random rand = new Random();
            int MyNumber;
            int Guess;
            int Counter = 0;

            Console.WriteLine("I am thinking of a number between 0 and 100.");
            Console.Write("Try to guess what I am thinking: ");

            MyNumber = rand.Next(0, 100);
            do
            {
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess == MyNumber)
                {
                    Console.WriteLine("You guessed correctly!!");
                }
                else
                {
                    if (Guess > MyNumber)
                    {
                        Console.WriteLine("Your guess was too high.");
                    }
                    else if (Guess < MyNumber)
                    {
                        Console.WriteLine("Your guess was too low.");
                    }
                }
                Counter += 1;
            } while (Guess != MyNumber);

            Console.WriteLine($"It took you {Counter} tries.");
            Console.ReadKey();

        }
    }
}
