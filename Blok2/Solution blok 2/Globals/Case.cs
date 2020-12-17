using System;

namespace Globals
{
    public class Case : ICase
    {
        /*
         {
      "Country": "Marshall Islands",
      "CountryCode": "MH",
      "Slug": "marshall-islands",
      "NewConfirmed": 0,
      "TotalConfirmed": 0,
      "NewDeaths": 0,
      "TotalDeaths": 0,
      "NewRecovered": 0,
      "TotalRecovered": 0,
      "Date": "2020-04-05T06:37:00Z"
    },
        */

        public string Country { get; set; }
        public string CountryCode { get; set; }
        public int NewConfirmed { get; set; }
        public int TitalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }

    }
}
