using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----Results from Exercise 1----");


            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");


            foreach (string item in planetList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----Results from Exercise 2----");
            //list of random numbers. Each number will be between 0 and 5.
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers[i] == i){
                    Console.WriteLine("numbers list contains " + i);
                }
                else {
                    Console.WriteLine("numbers list does not contain " + i);
                }
            }





        }
    }
}