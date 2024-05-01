using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.Stores.ValueObjects
{
    public class StoreId : EntityId<Guid>
    {
        private StoreId(Guid id) : base(id)
        {

        }

        public static StoreId Create(Guid value)
        {
            return new StoreId(value);

        }
        public static StoreId CreateUnique()
        {
            return new StoreId(Guid.NewGuid());
        }

        private StoreId()
        {

        }
    }
}
