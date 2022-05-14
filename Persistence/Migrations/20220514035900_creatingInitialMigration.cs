using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Layer.Migrations
{
    public partial class creatingInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Modified_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customerid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
