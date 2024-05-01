using WarehouseManager.Domain.Common.Enums;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Employees.ValueObjects;
using WarehouseManager.Domain.ItemMovements.Events;
using WarehouseManager.Domain.ItemMovements.ValueObjects;
using WarehouseManager.Domain.Items.ValueObjects;

namespace WarehouseManager.Domain.ItemMovements
{
    public sealed class ItemMovement:Entity<ItemMovementId>
    {
        public EmployeeId ShippingEndEmployee { get; private set; }
        public EmployeeId ReceivingEndEmployee { get; private set; }
        public ItemId ItemId { get; private set; }
        public LocationStatus From { get; private set; }
        public LocationStatus To { get; private set;}
        private ItemMovement(
            ItemMovementId id,
            EmployeeId shippingEndEmployee, 
            EmployeeId receivingEndEmployee,
            ItemId itemId,
            LocationStatus from,
            LocationStatus to
            ):base( id )
        {
            ShippingEndEmployee = shippingEndEmployee;
            ReceivingEndEmployee = receivingEndEmployee;
            ItemId = itemId;
            From = from;
            To = to;

        }
        public static ItemMovement Create(
            EmployeeId shippingEndEmployee,
            EmployeeId receivingEndEmployee,
            ItemId itemId,
            LocationStatus from,
            LocationStatus to)
        {
            var itemMovement= new ItemMovement(ItemMovementId.CreateUnique(), shippingEndEmployee, receivingEndEmployee, itemId, from, to);
            itemMovement.AddDomainEvent(new ItemMovementCreated(itemMovement));
            return itemMovement;
        }
        private ItemMovement()
        {
            
        }
    }
}
