using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Stores.ValueObjects;

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
        private Store()
        {

        }
    }
}
