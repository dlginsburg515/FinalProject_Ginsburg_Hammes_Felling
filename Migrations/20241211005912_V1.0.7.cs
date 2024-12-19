using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_DG_CH_BF.Migrations
{
    /// <inheritdoc />
    public partial class V107 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageName",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageName",
                table: "Dog");
        }
    }
}
