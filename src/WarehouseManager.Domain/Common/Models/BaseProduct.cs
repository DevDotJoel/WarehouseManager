using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Domain.Common.Models
{
    public abstract class BaseProduct : Entity<ProductId>
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        protected BaseProduct(ProductId id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        protected BaseProduct()
        {

        }
    }
}
