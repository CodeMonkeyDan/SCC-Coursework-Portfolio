using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicDataLibrary
{
    public class Record
    {
        //define fields for medal class
        public string EventName { get; set; }
        public string EventCategory { get; set; }
        public string RecordValue { get; set; }
        public string RecordRank { get; set; }
        public string RecordHolderAthlete { get; set; }
        public string RecordHolderCountry { get; set; }
        public DateTime RecordDate { get; set; }


        //constructor to initialize medal details
        public Record(string name, string category, string value, string rank, string athlete, string country, DateTime date)
        {
            EventName = name;
            EventCategory = category;
            RecordValue = value;
            RecordRank = rank;
            RecordHolderAthlete = athlete;
            RecordHolderCountry = country;
            RecordDate = date;
        }
    }
}
