using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Stores.Events;
using WarehouseManager.Domain.Stores.ValueObjects;
using WarehouseManager.Domain.WarehouseSlots.Events;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Domain.Stores
{
    public sealed class Store:Entity<StoreId>
    {
        private readonly List<ItemId> _itemIds = new();
        public string Name { get; private set; }
        public IReadOnlyList<ItemId> ItemIds => _itemIds.AsReadOnly();
        private Store(StoreId id,string name):base(id)
        {
            Name = name;
            
        }
        public static Store Create(string name)
        {
            return new Store(StoreId.CreateUnique(),name);
            
        }
        public ErrorOr<Success> AddItems(List<ItemId> items)
        {
            return Result.Success;
        }
        public ErrorOr<Success> MoveItemsToWarehouseSlot(List<ItemId> itemIds, WarehouseSlotId warehouseSlotId)
        {
            foreach (var itemId in itemIds)
            {
                var itemExists = _itemIds.Where(i => i == itemId).FirstOrDefault();
                if (itemExists is null)
                {
                    return Error.NotFound(description: "Item doesn't exist in the Store");
                }
                else
                {
                    _itemIds.Remove(itemExists);
                }
            }
            AddDomainEvent(new MoveItemToWarehouseSlot(itemIds, warehouseSlotId));
            return Result.Success;

        }
        private Store()
        {

        }
    }
}
