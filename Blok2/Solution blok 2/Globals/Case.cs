namespace Globals
{
    public class Case
    {
        public string Location { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }

        public Case(string location, int confirmed, int deaths, int recovered, int active)
        {
            Location = location;
            Confirmed = confirmed;
            Deaths = deaths;
            Recovered = recovered;
            Active = active;
        }
    }
}
