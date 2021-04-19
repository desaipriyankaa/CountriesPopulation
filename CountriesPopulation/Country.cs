using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesPopulation
{
    // this is only reader class... contains read-only properties... 
    class Country
    {
        public string Name { get; }
        public string Code { get; }
        public int Population { get; }

        public Country(String name, string code, int population)
        {
            this.Name = name;
            this.Code = code;
            this.Population = population;
        }
    }
}
