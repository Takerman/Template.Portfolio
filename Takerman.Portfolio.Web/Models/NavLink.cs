namespace Takerman.Portfolio.Web.Models
{
    public class NavLink
    {
        public object Data;

        public string Url { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public string Area { get; set; }

        public string Label { get; set; }

        public string Icon { get; set; }
    }
}