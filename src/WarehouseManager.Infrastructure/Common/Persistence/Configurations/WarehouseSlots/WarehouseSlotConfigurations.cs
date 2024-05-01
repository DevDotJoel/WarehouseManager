using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Stores.ValueObjects;
using WarehouseManager.Domain.WarehouseSlots;
using WarehouseManager.Domain.WarehouseSlots.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.WarehouseSlots
{
    public class WarehouseSlotConfigurations : IEntityTypeConfiguration<WarehouseSlot>
    {
        public void Configure(EntityTypeBuilder<WarehouseSlot> builder)
        {
            builder.ToTable("WarehouseSlots");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).
                HasColumnName("WarehouseSlotId")
                .ValueGeneratedNever()
                .HasConversion(id => id.Value, value => WarehouseSlotId.Create(value));

            builder.HasIndex(x => x.SlotNumber).IsUnique();

            builder.HasIndex(x => x.Isle).IsUnique();
        }
    }
}
