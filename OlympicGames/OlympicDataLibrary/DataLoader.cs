using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;


namespace OlympicDataLibrary
{
    public static class DataLoader
    {
        //create data lists
        public static List<Olympics> olympicsList = new List<Olympics>();
        public static List<EventMedals> eventMedalsList = new List<EventMedals>();
        public static List<Record> recordList = new List<Record>();
        public static List<Country> countryList = new List<Country>();


        //method for loading Olympics data from CSV
        public static List<Olympics> LoadOlympicsFromCSV(string Olympic_Games_Summary)
        {
            //determines the full file path of Olympic_Games_Summary CSV
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Olympic_Games_Summary.csv");

            //check if file was found
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Olympic Games Summary file not found.");
            }

            //try to populate Olympics list
            try
            {
                using (var reader  = new StreamReader(filePath))
                {
                    //removes header
                    reader.ReadLine();
                    //loops until reader comes to the end of the CSV
                    while (!reader.EndOfStream)
                    {
                        //breaks CSV down by line and then by field
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        //returns needed data
                        int year = int.Parse(values[3]);
                        string seasonString = values[0].Split(' ')[1]; //extracts season from column data
                        Season season = (Season)Enum.Parse(typeof(Season), seasonString, true); //converts string into corresponding Season enum
                        string hostCity = values[4];
                        string hostCountry = values[6];

                        var olympics = new Olympics(year, season, hostCity, hostCountry);
                        olympicsList.Add(olympics);
                    }
                }
            }
            //throw ex if an error occurs
            catch (Exception ex)
            {
                throw new FileLoadException("Error loading Olympic Games Summary.\n\n" + ex);
            }
            return olympicsList;
        }


        //method for loading Event Medal data from CSV
        public static List<EventMedals> LoadEventMedalsFromCSV(string Olympic_Medals)
        {
            //determines the full file path of Olympic_Medals CSV
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Olympic_Medals.csv");

            //check if file was found
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Olympic Medals file not found.");
            }

            //try to populate EventMedals list
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    //loops until reader comes to the end of the CSV
                    while (csv.Read())
                    {
                        //returns needed data
                        //get the full field containing city and year
                        string cityYearField = csv.GetField<string>(1);
                        //extract the year
                        string eventYear = cityYearField.Split('-').Last();
                        int year = int.Parse(eventYear);
                        //extract the city
                        string city = cityYearField.Substring(0, cityYearField.LastIndexOf('-'));            
                        string discipline = csv.GetField<string>(0);
                        string name = csv.GetField<string>(2);
                        Place medal = (Place)Enum.Parse(typeof(Place), csv.GetField<string>(4), true); //converts value into corresponding Place enum
                        string country = csv.GetField<string>(9);
                        string code = csv.GetField<string>(11);

                        var eventMedals = new EventMedals(year, city, discipline, name, medal, country, code);

                        //checks to see if event already exists
                        if (!eventMedalsList.Any(em => em.EventYear == eventMedals.EventYear && em.EventDiscipline == eventMedals.EventDiscipline && em.EventName == eventMedals.EventName && em.MedalType == eventMedals.MedalType))
                        {
                            eventMedalsList.Add(eventMedals);
                        }
                    }
                }
            }
            //throw ex if an error occurs
            catch (Exception ex)
            {
                throw new FileLoadException("Error loading Event Medals.\n\n" + ex);
            }
            return eventMedalsList;
        }


        //method for loading World Record data from CSV
        public static List<Record> LoadRecordFromCSV(string World_Records)
        {
            //determines the full file path of Olympic_Medals CSV
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "World_Records.csv");

            //check if file was found
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("World Records file not found.");
            }

            //try to populate Record list
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    //loops until reader comes to the end of the CSV
                    while (csv.Read())
                    {
                        //returns needed data
                        string name = csv.GetField<string>(2);
                        string category = csv.GetField<string>(3);
                        string rank = csv.GetField<string>(4);
                        string value = csv.GetField<string>(5);
                        string athlete = csv.GetField<string>(6);
                        string country = csv.GetField<string>(7);
                        DateTime date = csv.GetField<DateTime>(10);

                        //checks to make sure record is a #1 world record, only adds the #1
                        if (rank.Trim() == "1" || rank.Trim() == "2" || rank.Trim() == "3")
                        {
                            var record = new Record(name, category, value, rank, athlete, country, date);
                            recordList.Add(record);
                        }
                    }
                }
            }
            //throw ex if an error occurs
            catch (Exception ex)
            {
                throw new FileLoadException("Error loading World Records.\n\n" + ex);
            }
            return recordList;
        }


        //method for loading Country Abbreviation data from CSV
        public static List<Country> LoadCountryFromCSV(string Olympic_Country_Profiles)
        {
            //determines the full file path of Olympic_Country_Profiles CSV
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Olympic_Country_Profiles.csv");

            //check if file was found
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Olympic Country Profiles file not found.");
            }

            //try to populate Country list
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    //loops until reader comes to the end of the CSV
                    while (csv.Read())
                    {
                        //returns needed data
                        string name = csv.GetField<string>(1);
                        string abbreviation = csv.GetField<string>(0);

                        var country = new Country(name, abbreviation);
                        countryList.Add(country);
                    }
                }
            }
            //throw ex if an error occurs
            catch (Exception ex)
            {
                throw new FileLoadException("Error loading Country.\n\n" + ex);
            }
            return countryList;
        }
    }
}
