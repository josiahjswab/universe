using System;
using System.Collections.Generic;

namespace dnc100_makeYourOwnUniverse.universe
{
    public class Planet
    {
        public string name;
        public double lifeCount;
        public Planet(string _name)
        {
            name = _name;
        }
        public void AddLife(double number)
        {
            lifeCount = number;
        }
    }
}
