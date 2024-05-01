using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Enums;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.Enums;
using WarehouseManager.Domain.Items.Events;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Domain.Items
{
    public sealed class Item:Entity<ItemId>
    {
        public ProductId ProductId { get; private set; }
        public ItemStatus Status { get; private set; }
        public LocationStatus Location { get; private set; }

        private Item(ItemId id,ProductId productId):base(id) 
        {
            ProductId = productId;
            Status = ItemStatus.Movement;
            Location = LocationStatus.Warehouse;
        }

        public static Item Create(ProductId productId)
        {
            var item = new Item(ItemId.CreateUnique(), productId);
            item.AddDomainEvent(new ItemCreated(item));
            return item;
        }
        private Item()
        {
            
        }
    }
}
