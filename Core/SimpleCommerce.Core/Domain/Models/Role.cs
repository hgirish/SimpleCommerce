using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Domain.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public Role()
        {
            
        }

        public Role(string name)
        {
            Name = name;
        }
    }
}