using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;

namespace WarehouseManager.Domain.Products.ValueObjects
{
    public class ProductId:EntityId<Guid>
    {
        private ProductId(Guid value):base(value)
        {
            
        }

        public static ProductId Create(Guid value)
        {
            return new ProductId(value);

        }
        public static ProductId CreateUnique()
        {
            return new ProductId(Guid.NewGuid());
        }

        private ProductId()
        {

        }
    }
}
