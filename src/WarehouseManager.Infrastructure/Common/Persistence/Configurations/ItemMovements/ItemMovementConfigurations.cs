using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Common.Enums;
using WarehouseManager.Domain.Employees.ValueObjects;
using WarehouseManager.Domain.ItemMovements;
using WarehouseManager.Domain.ItemMovements.ValueObjects;
using WarehouseManager.Domain.Items.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.ItemMovements
{
    public class ItemMovementConfigurations : IEntityTypeConfiguration<ItemMovement>
    {
        public void Configure(EntityTypeBuilder<ItemMovement> builder)
        {
            builder.ToTable("ItemMovements");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).
                HasColumnName("ItemMovementId")
                .ValueGeneratedNever()
                .HasConversion(id => id.Value, value => ItemMovementId.Create(value));
            builder.Property(x => x.ShippingEndEmployee).ValueGeneratedNever().HasConversion(id => id.Value, value => EmployeeId.Create(value));
            builder.Property(x => x.ReceivingEndEmployee).ValueGeneratedNever().HasConversion(id => id.Value, value => EmployeeId.Create(value));
            builder.Property(d => d.From).HasConversion(status => status.Value,value => LocationStatus.FromValue(value));
            builder.Property(d => d.To).HasConversion(status => status.Value, value => LocationStatus.FromValue(value));
            builder.Property(x => x.ItemId).ValueGeneratedNever().HasConversion(id => id.Value, value => ItemId.Create(value));
        }
    }
}
