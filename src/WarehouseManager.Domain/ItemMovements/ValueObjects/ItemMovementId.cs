using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.ItemMovements.ValueObjects
{
    public class ItemMovementId : EntityId<Guid>
    {
        public ItemMovementId(Guid value) : base(value)
        {

        }
        public static ItemMovementId CreateUnique()
        {
            return new ItemMovementId(Guid.NewGuid());
        }

        public static ItemMovementId Create(Guid value)
        {
            return new ItemMovementId(value);
        }
    }
}
