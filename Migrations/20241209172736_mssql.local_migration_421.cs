using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_DG_CH_BF.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_421 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GoodWithCats",
                table: "Dog",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithDogs",
                table: "Dog",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithKids",
                table: "Dog",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HealthStatus",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodWithCats",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "GoodWithDogs",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "GoodWithKids",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "HealthStatus",
                table: "Dog");
        }
    }
}
