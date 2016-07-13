using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Domain.Models
{
    public class UrlSlug : Entity
    {
        public string Slug { get; set; }

        public long EntityId { get; set; }

        public string EntityName { get; set; }
    }
}