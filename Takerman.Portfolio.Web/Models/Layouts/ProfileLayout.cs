using System.Collections.Generic;
using Takerman.Portfolio.Web.Models.Contracts;

namespace Takerman.Portfolio.Web.Models
{
    public class ProfileLayout : ILayout
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public Head Head { get; set; }
        public Banner Banner { get; set; }

        public ProfileLayout()
        {
            this.Head = new Head()
            {
                Title = "Tanyo Ivanov"
            };

            this.Header = new Header()
            {
                NavigationLinks = new List<NavLink>()
                {
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Home", Label = "Home" },
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "CV", Label = "CV" },
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Specs", Label = "Specs" },
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Blog", Label = "Blog" },
                     new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Contact", Label = "Contact" }
                },
                ImageUrl = "/img/profile/logo.png"
            };

            this.Banner = new Banner();

            this.Footer = new Footer()
            {
                Area = "Tanyo",
                NavigationLinks = new List<NavLink>()
                {
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Home", Label = "Home" },
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "CV", Label = "CV" },
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Specs", Label = "Specs" },
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Portfolio", Label = "Portfolio" },
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Blog", Label = "Blog" },
                    new NavLink(){ Area="Tanyo", Action = "Index", Controller = "Contact", Label = "Contact" }
                },
                SocialLinks = new List<NavLink>()
                {
                    new NavLink(){ Url="https://www.facebook.com/Tanyo-Ivanov-100694504729828", Icon = "facebook-f" },
                    new NavLink(){ Url="https://www.linkedin.com/company/takerman-ltd/", Icon = "linkedin" },
                    new NavLink(){ Url="skype:live:contact_44094?chat", Icon = "skype" },
                    new NavLink(){ Url="https://www.instagram.com/ivanov.tanyo/", Icon = "instagram" },
                    new NavLink(){ Url="https://www.github.com/takermanltd", Icon = "github" }
                },
                CopyLink = new NavLink()
                {
                    Label = "Tanyo Ivanov",
                    Url = "https://tanyo.takerman.net"
                },
                ImageUrl = "/img/profile/logo2.png"
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