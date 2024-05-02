using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarehouseManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MinorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreItemIds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "StoreItems");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StoreItems",
                newName: "StoreItemId");

            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "StoreItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreItems",
                table: "StoreItems",
                columns: new[] { "StoreItemId", "StoreId" });

            migrationBuilder.CreateIndex(
                name: "IX_StoreItems_StoreId",
                table: "StoreItems",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreItems_Stores_StoreId",
                table: "StoreItems",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreItems_Stores_StoreId",
                table: "StoreItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreItems",
                table: "StoreItems");

            migrationBuilder.DropIndex(
                name: "IX_StoreItems_StoreId",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "StoreItems");

            migrationBuilder.RenameTable(
                name: "StoreItems",
                newName: "Items");

            migrationBuilder.RenameColumn(
                name: "StoreItemId",
                table: "Items",
                newName: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemId");

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
        }
    }
}
