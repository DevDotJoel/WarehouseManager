using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Domain.WarehouseSlots
{
    public sealed class WarehouseSlot:Entity<WarehouseSlotId>
    {
        public Guid Isle { get; private set; }
        public Guid SlotNumber { get; private set; }

        private WarehouseSlot(WarehouseSlotId id):base(id)
        {
            Isle = Guid.NewGuid();
            SlotNumber = Guid.NewGuid();
            
        }
        public static WarehouseSlot Create()
        {
            return new WarehouseSlot(WarehouseSlotId.CreateUnique());

        }
        private WarehouseSlot()
        {

        }
    }
}
