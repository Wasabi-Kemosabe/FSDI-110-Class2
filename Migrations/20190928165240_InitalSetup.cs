using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Migrations
{
    public partial class InitalSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    DailyPrice = table.Column<decimal>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    Doors = table.Column<int>(nullable: false),
                    Cylinders = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
