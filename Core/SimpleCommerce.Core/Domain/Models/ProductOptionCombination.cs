using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Domain.Models
{
    public class ProductOptionCombination : Entity
    {
        public long ProducdtId { get; set; }

        public virtual Product Product { get; set; }

        public long OptionId { get; set; }

        public virtual ProductOption Option { get; set; }

        public string Value { get; set; }
    }
}