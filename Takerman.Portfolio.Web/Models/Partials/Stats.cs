namespace Takerman.Portfolio.Web.Models.Partials
{
    public class Stats
    {
        public Stats(AreaType areaType)
        {
            switch (areaType)
            {
                case AreaType.Profile:
                    this.HappyCustomers = 6;
                    this.SolvedTickets = 100;
                    this.AverageRating = 9;
                    break;

                case AreaType.Company:
                default:
                    this.HappyCustomers = 2;
                    this.SolvedTickets = 20;
                    this.AverageRating = 8;
                    break;
            }
        }

        public int SolvedTickets { get; set; }
        public int AverageRating { get; set; }
        public int HappyCustomers { get; set; }
    }
}