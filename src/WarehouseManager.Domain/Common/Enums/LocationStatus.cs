using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Domain.Common.Enums
{
    public class LocationStatus : SmartEnum<LocationStatus>
    {
        public LocationStatus(string name, int value) : base(name, value)
        {

        }
        public static readonly LocationStatus Warehouse = new(nameof(Warehouse), 0);
        public static readonly LocationStatus Store = new(nameof(Store), 1);
    }
}
