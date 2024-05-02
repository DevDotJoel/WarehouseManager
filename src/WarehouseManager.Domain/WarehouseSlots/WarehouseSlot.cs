using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Products.ValueObjects;
using WarehouseManager.Domain.Stores.ValueObjects;
using WarehouseManager.Domain.WarehouseSlots.Events;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Domain.WarehouseSlots
{
    public sealed class WarehouseSlot:Entity<WarehouseSlotId>
    {
        private readonly List<ItemId> _itemIds = new();
        public string Name { get; private set; }
        public Guid Isle { get; private set; }
        public Guid SlotNumber { get; private set; }
        public IReadOnlyList<ItemId> ItemIds => _itemIds.AsReadOnly();

        private WarehouseSlot(WarehouseSlotId id, string name) : base(id)
        {
            Isle = Guid.NewGuid();
            SlotNumber = Guid.NewGuid();
            Name = name;

        }
        public static WarehouseSlot Create(string name,List<ProductId> productIds)
        {
            var warehouseSlot= new WarehouseSlot(WarehouseSlotId.CreateUnique(),name);
            warehouseSlot.AddDomainEvent(new WarehouseSlotCreated(warehouseSlot,productIds));
            return warehouseSlot;

        }
        public ErrorOr<Success> AddItems(List<ItemId> itemIds)
        {
            foreach (var itemId in itemIds)
            {
                _itemIds.Add(itemId);

            }
            return Result.Success;
        }
        public ErrorOr<Success> MoveItemsToStore(List<ItemId> itemIds,StoreId storeId)
        {
            foreach (var itemId in itemIds)
            {
                var itemExists = _itemIds.Where(i=>i==itemId).FirstOrDefault();
                if(itemExists is null)
                {
                    return Error.NotFound(description: "Item doesn't exist in the warehouse");
                }
                else
                {
                    _itemIds.Remove(itemExists);
                }
            }
            AddDomainEvent(new MoveItemToStore(itemIds,storeId));
            return Result.Success;

        }
        private WarehouseSlot()
        {

        }
    }
}
