using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Employees;
using WarehouseManager.Domain.Employees.ValueObjects;
using WarehouseManager.Domain.Items.ValueObjects;

namespace WarehouseManager.Infrastructure.Common.Persistence.Configurations.Employees
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("EmployeeId").ValueGeneratedNever().HasConversion(id => id.Value, value => EmployeeId.Create(value));
        }
    }
}
