using System;

namespace Globals
{
    public static class Format
    {
        public static string RemoveDecimalPoint(this int caseData)
        {
            return Convert.ToDecimal(caseData).ToString("#,##0");
        }
    }
}
