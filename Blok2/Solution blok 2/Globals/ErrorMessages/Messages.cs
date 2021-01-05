﻿namespace Globals.ErrorMessages
{
    public static class Messages
    {
        public const string CanNotFindStatsError = "Please select an item!";
        public const string CanNotLoadDataForCountryError = "Can not load the data for the selected country.";
        public static string ErrorMessage(string message)
        {
            return "Error:" + message;
        }
    }
}
