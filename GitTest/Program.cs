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
            int MyNumber; int Min;int Max;
            int Guess;
            int Counter = 0;
            Console.Write("Give me your first (lower) number: ");
            Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give me your Second (higher) number: ");
            Max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I am thinking of a number between {Min} and {Max}.");
            Console.Write("Try to guess what I am thinking: ");

            MyNumber = rand.Next(Min, Max);
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
