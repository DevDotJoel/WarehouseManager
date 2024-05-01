using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Stores.ValueObjects;

namespace WarehouseManager.Domain.WarehouseSlots.ValueObjects
{
    public class WarehouseSlotId : EntityId<Guid>
    {
        private WarehouseSlotId(Guid id) : base(id)
        {

        }

        public static WarehouseSlotId Create(Guid value)
        {
            return new WarehouseSlotId(value);

        }
        public static WarehouseSlotId CreateUnique()
        {
            return new WarehouseSlotId(Guid.NewGuid());
        }

        private WarehouseSlotId()
        {

        }
    }
}
