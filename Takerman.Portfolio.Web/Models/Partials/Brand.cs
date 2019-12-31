namespace Takerman.Portfolio.Web.Models
{
    public class Brand
    {
        public Brand()
        {
            this.Url = string.Empty;
            this.ImageName = string.Empty;
        }
        public string Url { get; set; }
        public string ImageName { get; set; }
    }
}