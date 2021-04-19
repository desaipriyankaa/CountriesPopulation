using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountriesPopulation
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while((csvLine = sr.ReadLine()) != null)
                { 
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }
                return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split( ',' );

            string name;
            string code;
            string popText;

            switch (parts.Length)
            {
                case 3:
                    name = parts[0];
                    code = parts[1];
                    popText = parts[2];
                    break;

                case 4:
                    name = parts[0] + ", " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    popText = parts[3];
                    break;

                default:
                    throw new Exception($"Can't parse country from csvLine : {csvLine}");

            }
            int.TryParse(popText,out int population);
            return new Country(name, code, population);
        }
    }
}
