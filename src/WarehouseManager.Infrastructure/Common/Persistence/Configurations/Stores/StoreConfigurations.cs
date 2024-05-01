using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.ItemMovements.ValueObjects;
using WarehouseManager.Domain.Stores;
using WarehouseManager.Domain.Stores.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.Stores
{
    public class StoreConfigurations : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Stores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).
                HasColumnName("StoreId")
                .ValueGeneratedNever()
                .HasConversion(id => id.Value, value => StoreId.Create(value));

            builder.OwnsMany(m => m.ItemIds, dib =>
            {
                dib.ToTable("StoreItemIds");

                dib.WithOwner().HasForeignKey("StoreId");

                dib.HasKey("Id");

                dib.Property(d => d.Value)
                    .HasColumnName("ItemId")
                    .ValueGeneratedNever();
            });

            builder.Metadata.FindNavigation(nameof(Store.ItemIds))!
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
