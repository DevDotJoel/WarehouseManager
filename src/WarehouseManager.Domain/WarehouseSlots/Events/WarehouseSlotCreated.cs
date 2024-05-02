using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Domain.WarehouseSlots.Events
{
    public record WarehouseSlotCreated(WarehouseSlot WarehouseSlot,List<ProductId> ProductIds):IDomainEvent;
}
