using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Models;
using WarehouseManager.Domain.Items.Enums;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Domain.Products
{
    public sealed class Product:BaseProduct
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        private Product(ProductId id, string name, string description) : base(id, name, description)
        {

        }
        public static  Product Create(string name, string description)
        {
            return new Product(ProductId.CreateUnique(), name, description);
            
        }
        private Product()
        {
            
        }
    }
}
