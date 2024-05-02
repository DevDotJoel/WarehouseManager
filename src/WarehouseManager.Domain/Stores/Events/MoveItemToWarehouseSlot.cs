using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Domain.Stores.Events
{
    public record MoveItemToWarehouseSlot(List<ItemId> ItemIds,WarehouseSlotId WarehouseSlotId):IDomainEvent;
}
