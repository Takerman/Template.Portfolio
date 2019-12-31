using System.Collections.Generic;

namespace Takerman.Portfolio.Web.Models.Contracts
{
    public interface ILayout
    {
        public Header Header { get; set; }

        public Footer Footer { get; set; }

        public IEnumerable<Brand> Brands { get; set; }

        public Head Head { get; set; }

        public Banner Banner { get; set; }
    }
}