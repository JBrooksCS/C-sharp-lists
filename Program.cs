using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){"Neptune", "Uranus"};

            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            




        foreach (string item in planetList)
        {
            Console.WriteLine(item);
        }
        }
    }
}
