using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_DG_CH_BF.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetID = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateOnly>(type: "date", nullable: false),
                    NameOfVet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasChildren = table.Column<bool>(type: "bit", nullable: false),
                    HasDogs = table.Column<bool>(type: "bit", nullable: false),
                    HasCats = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
