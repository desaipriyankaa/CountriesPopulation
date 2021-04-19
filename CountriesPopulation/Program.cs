using System;
using System.Collections.Generic;

namespace CountriesPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\PProject\Array\CountriesDemo\CountryData.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
                                                      
            foreach(Country country in countries)
            {

                Console.WriteLine($"{country.Population} : {country.Name}");
            }
            Console.WriteLine($"\n{countries.Count} countries");

        }
    }
}
