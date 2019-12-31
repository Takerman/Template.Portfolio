using System;
using System.Collections.Generic;

namespace Takerman.Portfolio.Web.Models.Partials
{
    public class Blog
    {
        public Blog(AreaType areaType)
        {
            this.BlogItemsMini = new List<BlogItemMini>();

            switch (areaType)
            {
                case AreaType.Profile:
                    this.Area = "Tanyo";
                    this.BlogItemsMini = new List<BlogItemMini>()
                    {
                        new BlogItemMini(){
                            Author = "Tanyo Ivanov",
                            Title = "Personal branding and portfolio completed",
                            Content = "How and why I choose to change my employment style and to have personal branding. Teams that I joined.",
                            Date = new DateTime(2020, 1, 1),
                            Image = "/img/profile/b1.jpg",
                            Name = "portfiolio-has-been-released" },

                        new BlogItemMini(){
                            Author = "Tanyo Ivanov",
                            Title = "Prices defined and listed",
                            Content = "How I defined and listed my optimized for the client prices.",
                            Date = new DateTime(2020, 1, 17),
                            Image = "/img/blog/home-blog/home-blog-4.jpg",
                            Name = "prices-listed" },

                        new BlogItemMini(){
                            Author = "Tanyo Ivanov",
                            Title = "Raspberry Pi Home Automation",
                            Content = @"In this blog post I will show you how I'm using some Raspberry PIs
                                        for web server, media center, smar home, database server, to save pictures
                                        from a camera and more.",
                            Date = new DateTime(2020, 3, 7),
                            Image = "/img/blog/raspberry-pi-home-automation/raspberry-pi-cover.png",
                            Name = "raspberrypi-home-automation" },

                        new BlogItemMini(){
                            Author = "Tanyo Ivanov",
                            Title = "Design Patterns Package",
                            Content = @"Here you can find a package with Design Patterns which I made while watching a YouTube channel. There is explanation and a video about all of them.",
                            Date = new DateTime(2020, 3, 22),
                            Image = "/img/blog/designpatterns.png",
                            Name = "designpatterns-package" }
                    };
                    break;

                case AreaType.Company:
                default:
                    this.Area = "";
                    this.BlogItemsMini = new List<BlogItemMini>()
                    {
                        new BlogItemMini(){
                            Author = "Tanyo Ivanov",
                            Title = "Branding renewed",
                            Content = "Our branding, website and logo now is renewed and we are available to take new projects. Please use the contact section to learn more, send us an email or call us.",
                            Date = new DateTime(2020, 1, 12),
                            Image = "/img/png_logomark.png",
                            Name = "company-renewed" }
                    };
                    break;
            }
        }

        public string Area { get; }
        public IEnumerable<BlogItemMini> BlogItemsMini { get; set; }
    }
}