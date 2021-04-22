using System;
using System.Collections.Generic;

namespace dnc100_makeYourOwnUniverse.universe
{
    public class Solarsystem
    {
        public string name;
        public List<Planet> Planets = new List<Planet>(); 
        public List<Star> Stars = new List<Star>(); 
        public Solarsystem(string _name)
        {
            name = _name;
        }
        public void AddStar(string name)
        {
            Stars.Add(new Star(name));
        }        
        public void AddPlanet(string name)
        {
            Planets.Add(new Planet(name));
        }     
        public void GetPlanetList()
        {
            foreach(var p in Planets)
            {
                Console.WriteLine($" Planet: {p.name} ");
            }
        }
        public void GetStarList()
        {
            foreach(var s in Stars)
            {
                Console.WriteLine($" Sun of Solar System: {name} ");
            }
        }   
    }
}
