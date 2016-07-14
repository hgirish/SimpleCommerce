using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Domain.Models
{
    public class Country : Entity
    {
        public string Name { get; set; }
    }
    public class District : Entity
    {
        public long StateOrProvinceId { get; set; }

        public virtual StateOrProvince StateOrProvince { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

    }
}