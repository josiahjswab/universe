using System;
using System.Collections.Generic;

namespace dnc100_makeYourOwnUniverse.universe
{
    public class Galaxy
    {
        public string name;    
        public List<Solarsystem> Solarsystems = new List<Solarsystem>(); 

        public  Galaxy(string _name) {
            name = _name;
        }
        public void AddSolarSystem(string name)
        {
            Solarsystems.Add(new Solarsystem(name));
        }        
        public void GetSolarSystemsList()
        {
            foreach(var s in Solarsystems)
            {
                Console.WriteLine($" Solar system: {s.name} ");
            }
        }
    }
}
