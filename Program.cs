using System;
using System.Numerics;
using dnc100_makeYourOwnUniverse.universe;

namespace dnc100_makeYourOwnUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string galaxyNumber, solarNumber;

            Universe myUniverse = new Universe();
            Console.WriteLine($"How many galaxies should exist in your universe?");
            galaxyNumber = Console.ReadLine();
            Console.WriteLine($"How many solar systems should exist in your galaxies?");
            solarNumber = Console.ReadLine();
            for(int i = 1; i <= int.Parse(galaxyNumber); i++) 
            {
                myUniverse.AddGalaxy($"{i} ");

            }
            foreach(var g in myUniverse.Galaxies)
            {
                Console.WriteLine($"Galaxy:{g.name}");

                for(int j = 1; j <= int.Parse(solarNumber); j++) 
                {
                g.AddSolarSystem($"{j}");
                }
                
                foreach(var s in g.Solarsystems)
                {
                    Random random = new Random();
                    s.AddStar($"{s}");
                    s.GetStarList();

                    int numPlanets = random.Next(10,15);

                    for(int k = 1; k <= numPlanets; k++) 
                    {
                        s.AddPlanet($"{k}");
                    }
                    s.GetPlanetList();

                    foreach(var p in s.Planets)
                    {
                        double billions = 100;
                        double lifeForms = random.Next(100, 1000000000);
                        p.AddLife(billions * lifeForms);
                    }
                }
                // g.GetSolarSystemsList();
            }
            // loop galaxy count
            // create 1000 galaxy
            // create galaxys systems each 200
            // create system star
            Console.ReadLine();
            return;
        }
    }
}
