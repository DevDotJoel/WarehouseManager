using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Stores.ValueObjects;

namespace WarehouseManager.Domain.WarehouseSlots.Events
{
    public record MoveItemToStore(List<ItemId> ItemIds,StoreId StoreId):IDomainEvent;

}
