using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Employees;
using WarehouseManager.Domain.ItemMovements;
using WarehouseManager.Domain.Items;
using WarehouseManager.Domain.Products;
using WarehouseManager.Domain.Stores;
using WarehouseManager.Domain.WarehouseSlots;

namespace WarehouseManager.Infrastructure.Common.Persistence
{
    public class WarehouseManagerContext:DbContext
    {
        public WarehouseManagerContext(DbContextOptions<WarehouseManagerContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ItemMovement> ItemMovements { get; set; }
        public DbSet<WarehouseSlot> WarehouseSlots { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WarehouseManagerContext).Assembly);
        }
    }
}
