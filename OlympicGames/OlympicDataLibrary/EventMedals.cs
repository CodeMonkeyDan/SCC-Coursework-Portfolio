using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class EventMedals
    {
        //define fields for event class
        public int EventYear {  get; set; }
        public string EventCity { get; set; }
        public string EventDiscipline { get; set; }
        public string EventName {  get; set; }
        public Place MedalType { get; set; }
        public string WinningCountry { get; set; }
        public string CountryCode { get; set; }


        //constructor to initialize the event with world record details
        public EventMedals(int year, string city, string discipline, string name, Place medal, string country, string code)
        {
            EventYear = year;
            EventCity = city;
            EventDiscipline = discipline;
            EventName = name;
            MedalType = medal;
            WinningCountry = country;
            CountryCode = code;
        }
    }


    //define place data type
    public enum Place
    {
        Gold,
        Silver,
        Bronze
    }
}
