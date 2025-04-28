using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class Medal
    {
        //define fields for medal class
        public Olympics Olympics { get; set; }
        public Event EventName { get; set; }
        public Place Place { get; set; }
        public string WinningCountry { get; set; }


        //constructor to initialize medal details
        public Medal(Olympics olympics, Event eventName, Place place, string country)
        {
            Olympics = olympics;
            EventName = eventName;
            Place = place;
            WinningCountry = country;
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
