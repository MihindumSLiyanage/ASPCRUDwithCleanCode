using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPCRUDwithReactJS.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "IsActive", "Name" },
                values: new object[] { 1, 50, true, "Sunil" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "IsActive", "Name" },
                values: new object[] { 2, 55, false, "Amal" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "IsActive", "Name" },
                values: new object[] { 3, 65, true, "Kamal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
