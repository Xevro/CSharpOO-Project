using System;

namespace Globals
{
    public class CountryData : Case
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public DateTime Date { get; set; }

        public CountryData(string country, string countryCode, string province, string city, string cityCode, string lat, string lon, int confirmed, int deaths, int recovered, int active, DateTime date)
             : base(country, confirmed, deaths, recovered, active)
        {
            Country = country;
            CountryCode = countryCode;
            Province = province;
            City = city;
            CityCode = cityCode;
            Lat = lat;
            Lon = lon;
            Date = date;
        }
    }
}
