using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class Event
    {
        //define fields for event class
        public string EventName {  get; set; }
        public double RecordValue { get; set; }
        public string RecordHolderAthlete { get; set; }
        public string RecordHolderCountry { get; set; }
        public DateTime RecordDate { get; set; }


        //constructor to initialize the event with world record details
        public Event(string name, double value, string athlete, string country, DateTime date)
        {
            EventName = name;
            RecordValue = value;
            RecordHolderAthlete = athlete;
            RecordHolderCountry = country;
            RecordDate = date;
        }
    }
}
