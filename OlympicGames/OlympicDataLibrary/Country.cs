using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class Country
    {
        //define fields for country class
        public string CountryName { get; set; }
        public string CountryAbbreviation { get; set; }


        //constructor to initialize country details
        public Country(string name, string abbreviation)
        {
            CountryName = name;
            CountryAbbreviation = abbreviation;
        }
    }
}
