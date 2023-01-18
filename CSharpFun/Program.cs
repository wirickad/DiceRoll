using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create an array with all of the possible outcomes from each roll
            int[] possibilities = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //Create array called results that tracks the amount of times each number is rolled
            int[] results = new int[possibilities.Length];

            //Prompt user for the amount of times they would like to roll the dice
            Console.Write("How many times would you like to roll the dice? ");
            int numRolls = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int total = roll1 + roll2;
                results[total]++;
            }


            Console.WriteLine("Dice Rolling Simulation Results?\nEach '*' represents 1% of the total number of rolls\nTotal number of rolls = " + numRolls);

            for (int i = 0; i < possibilities.Length;i++)
            {
                double percentage = (double)results[i] / numRolls * 100;
                Console.Write((i+2) + ": ");
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }

    }
}
