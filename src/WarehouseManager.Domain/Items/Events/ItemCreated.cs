using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.Items.Events
{
    public record ItemCreated(Item item):IDomainEvent;
}
