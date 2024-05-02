using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.WarehouseSlots;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Application.Common.Persistence
{
    public interface IWarehouseSlotRepository:IBaseRepository<WarehouseSlotId,WarehouseSlot>
    {

    }
}
