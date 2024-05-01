using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Domain.Items.Enums
{
    public class ItemStatus : SmartEnum<ItemStatus>
    {
        public ItemStatus(string name, int value) : base(name, value)
        {

        }
        public static readonly ItemStatus NotInMovement = new(nameof(NotInMovement), 0);
        public static readonly ItemStatus Movement = new(nameof(Movement), 1);
    }
}
