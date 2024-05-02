using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Enums;
using WarehouseManager.Domain.Items;
using WarehouseManager.Domain.Items.Enums;
using WarehouseManager.Domain.Items.ValueObjects;
using WarehouseManager.Domain.Products.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.Items
{
    internal class ItemConfigurations : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).
                HasColumnName("ItemId")
                .ValueGeneratedNever()
                .HasConversion(id => id.Value, value => ItemId.Create(value));
            builder.Property(x => x.ProductId).
             HasColumnName("ProductId")
             .ValueGeneratedNever()
             .HasConversion(id => id.Value, value => ProductId.Create(value));
        }
    }
}
