using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address)" +
                $"VALUES ('Tran', '7AM-7PM Mon-Fri', 'Phu Da')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address)" +
                $"VALUES ('Cao', '8AM-8PM Mon-Sun', 'Phu Vang')");
            migrationBuilder.Sql($"INSERT INTO CoffeeShops (Name, OpeningHours, Address)" +
                $"VALUES ('Hoang', '9AM-9PM Tue-Fri', 'Hue')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
