namespace SimpleCommerce.Infrastructure.Domain.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}