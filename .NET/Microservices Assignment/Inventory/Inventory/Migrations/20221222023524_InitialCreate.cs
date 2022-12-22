using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TInventory",
                columns: table => new
                {
                    airline = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    from = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    instrument = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TInventory", x => x.airline);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TInventory");
        }
    }
}
