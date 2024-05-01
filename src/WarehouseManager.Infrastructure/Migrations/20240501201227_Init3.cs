using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "ItemMovements",
                columns: table => new
                {
                    ItemMovementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingEndEmployee = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceivingEndEmployee = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    From = table.Column<int>(type: "int", nullable: false),
                    To = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMovements", x => x.ItemMovementId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseSlots",
                columns: table => new
                {
                    WarehouseSlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Isle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseSlots", x => x.WarehouseSlotId);
                });

            migrationBuilder.CreateTable(
                name: "StoreItemIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItemIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreItemIds_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreItemIds_StoreId",
                table: "StoreItemIds",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseSlots_Isle",
                table: "WarehouseSlots",
                column: "Isle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseSlots_SlotNumber",
                table: "WarehouseSlots",
                column: "SlotNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ItemMovements");

            migrationBuilder.DropTable(
                name: "StoreItemIds");

            migrationBuilder.DropTable(
                name: "WarehouseSlots");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
