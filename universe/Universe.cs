using System;
using System.Linq;
using System.Collections.Generic;

namespace dnc100_makeYourOwnUniverse.universe
{
    public class Universe
    {
        string name;
        public List<Galaxy> Galaxies = new List<Galaxy>(); 
        public Universe()
        {
            Console.WriteLine("Your Universe: nothing yet...");
        }
        public void AddGalaxy(string name)
        {
            Galaxies.Add(new Galaxy(name));
        }
        public void GetGalaxyList()
        {
            foreach(var g in Galaxies)
            {
                Console.WriteLine($" Galaxy: {g.name} ");
            }
        }
        public void UniverseCensus()
        {
            int numberOfGalaxies = Galaxies.Count;
            int numberOfSolarsystems = Galaxies.First().Solarsystems.Count;
            int stars = Galaxies.First().Solarsystems.First().Stars.Count;
            int planets = Galaxies.First().Solarsystems.First().Planets.Count;
            double lifeForms = Galaxies.First().Solarsystems.First().Planets.First().lifeCount;
            Console.WriteLine($"YOUR UNIVERSE");
            Console.WriteLine($"Galaxies: {numberOfGalaxies}");
            Console.WriteLine($"    Solar Systems in each Galaxy: {numberOfSolarsystems}");
            Console.WriteLine($"        Stars in each Solar System: {stars}");
            Console.WriteLine($"            Planets in each Solar System: {planets}");
            Console.WriteLine($"                Life forms on each planet: {lifeForms}");
        }
    }
}
