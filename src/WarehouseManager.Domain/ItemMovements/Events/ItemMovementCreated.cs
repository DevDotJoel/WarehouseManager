using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.ItemMovements.Events
{
    public record ItemMovementCreated(ItemMovement ItemMovement):IDomainEvent;
}
