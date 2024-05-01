using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Products;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.Products
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ProductId").ValueGeneratedNever().HasConversion(id => id.Value, value => ProductId.Create(value));
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
