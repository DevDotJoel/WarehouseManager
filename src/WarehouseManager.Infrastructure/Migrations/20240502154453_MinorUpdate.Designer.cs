﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseManager.Infrastructure.Common.Persistence;

#nullable disable

namespace WarehouseManager.Infrastructure.Migrations
{
    [DbContext(typeof(WarehouseManagerContext))]
    [Migration("20240502154453_MinorUpdate")]
    partial class MinorUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WarehouseManager.Domain.Employees.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("WarehouseManager.Domain.ItemMovements.ItemMovement", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ItemMovementId");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReceivingEndEmployee")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShippingEndEmployee")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ItemMovements", (string)null);
                });

            modelBuilder.Entity("WarehouseManager.Domain.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProductId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("WarehouseManager.Domain.Stores.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StoreId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores", (string)null);
                });

            modelBuilder.Entity("WarehouseManager.Domain.WarehouseSlots.WarehouseSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("WarehouseSlotId");

                    b.Property<Guid>("Isle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotNumber")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Isle")
                        .IsUnique();

                    b.HasIndex("SlotNumber")
                        .IsUnique();

                    b.ToTable("WarehouseSlots", (string)null);
                });

            modelBuilder.Entity("WarehouseManager.Domain.Stores.Store", b =>
                {
                    b.OwnsMany("WarehouseManager.Domain.Items.Item", "Items", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("StoreItemId");

                            b1.Property<Guid>("StoreId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Location")
                                .HasColumnType("int");

                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("ProductId");

                            b1.Property<int>("Status")
                                .HasColumnType("int");

                            b1.HasKey("Id", "StoreId");

                            b1.HasIndex("StoreId");

                            b1.ToTable("StoreItems", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("StoreId");
                        });

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
