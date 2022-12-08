using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GarageUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CarRecieved = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CarNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Catagory = table.Column<string>(type: "TEXT", nullable: true),
                    ClientInsurance = table.Column<string>(type: "TEXT", nullable: true),
                    ClientAgent = table.Column<string>(type: "TEXT", nullable: true),
                    Admin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GarageUsers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GarageUsers");
        }
    }
}
