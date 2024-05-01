using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.Items.ValueObjects
{
    public class ItemId : EntityId<Guid>
    {
        private ItemId(Guid id) : base(id)
        {

        }

        public static ItemId Create(Guid value)
        {
            return new ItemId(value);

        }
        public static ItemId CreateUnique()
        {
            return new ItemId(Guid.NewGuid());
        }

        private ItemId()
        {

        }
    }
}
