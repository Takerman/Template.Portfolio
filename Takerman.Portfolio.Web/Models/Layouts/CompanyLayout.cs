using System.Collections.Generic;
using Takerman.Portfolio.Web.Models.Contracts;

namespace Takerman.Portfolio.Web.Models
{
    public class CompanyLayout : ILayout
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public Head Head { get; set; }
        public Banner Banner { get; set; }

        public CompanyLayout()
        {
            this.Head = new Head()
            {
                Title = "Takerman"
            };

            this.Header = new Header()
            {
                NavigationLinks = new List<NavLink>()
                {
                     new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                     new NavLink(){ Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
                     new NavLink(){ Action = "Index", Controller = "Blog", Label = "Blog" },
                     new NavLink(){ Action = "Index", Controller = "Contact", Label = "Contact" }
                },
                ImageUrl = "/img/logo.png"
            };

            this.Banner = new Banner();

            this.Footer = new Footer()
            {
                Area = "",
                NavigationLinks = new List<NavLink>()
                {
                     new NavLink(){ Action = "Index", Controller = "Home", Label = "Home" },
                     new NavLink(){ Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
                     new NavLink(){ Action = "Index", Controller = "Blog", Label = "Blog" },
                     new NavLink(){ Action = "Index", Controller = "Contact", Label = "Contact" }
                },
                SocialLinks = new List<NavLink>()
                {
                    new NavLink(){ Url="https://www.linkedin.com/company/takerman-ltd/", Icon = "linkedin" },
                    new NavLink(){ Url="skype:live:contact_44094?chat", Icon = "skype" },
                    new NavLink(){ Url="https://www.github.com/takermanltd", Icon = "github" }
                },
                CopyLink = new NavLink()
                {
                    Label = "Takerman",
                    Url = "https://takerman.net"
                },
                ImageUrl = "/img/logo2.png"
            };

            this.Brands = new List<Brand>()
            {
                new Brand() { ImageName = "logo1", Url = "https://www.bucons.com" },
                new Brand() { ImageName = "logo2", Url = "https://www.bgosoftware.com" },
                new Brand() { ImageName = "logo3", Url = "http://comstream.se/home" }
            };
        }
    }
}