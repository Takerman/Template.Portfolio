using System.Collections.Generic;

namespace Takerman.Portfolio.Web.Models.Partials
{
    public class ProgressBars
    {
        public ProgressBars()
        {
            this.Bars = new Dictionary<string, int>();
        }

        public ProgressBars(AreaType areaType) : this()
        {
            switch (areaType)
            {
                case AreaType.Company:
                    this.Bars.Add("Front-End", 7);
                    this.Bars.Add("Back-End", 9);
                    this.Bars.Add("Databases", 7);
                    this.Bars.Add("Web", 8);
                    this.Bars.Add("Desktop", 7);
                    break;

                case AreaType.Profile:
                    this.Bars.Add("Front-End", 7);
                    this.Bars.Add("Back-End", 9);
                    this.Bars.Add("Databases", 7);
                    this.Bars.Add("Web", 8);
                    this.Bars.Add("Desktop", 7);
                    break;
            }
        }

        public Dictionary<string, int> Bars { get; set; }
    }
}