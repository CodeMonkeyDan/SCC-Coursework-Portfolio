using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class Olympics
    {
        //define fields for olympics class
        public int Year { get; set; }
        public Season Season { get; set; }
        public string HostCity { get; set; }
        public string HostCountry { get; set; }


        //constructor to initialize olympic details
        public Olympics(int year, Season season, string hostCity, string hostCountry)
        {
            Year = year;
            Season = season;
            HostCity = hostCity;
            HostCountry = hostCountry;
        }
    }


    //define season data type
    public enum Season
    {
        Summer,
        Winter,
        Equestrian,
        Intercalated
    }
}
