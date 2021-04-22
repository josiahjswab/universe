using System;
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
    }
}
