using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2Angular.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Adress", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "MobileNumber", "Salary" },
                values: new object[,]
                {
                    { 1, "Gata1231235", 1, "kalle@anka.se", "Kalle", "Anka", "Anka", "01231244", 77777 },
                    { 2, "Gata1231415", 2, "knatte@anka.se", "Knatte", "Anka", "Anka", "401243124", 54233 },
                    { 3, "Gata3132", 3, "tjatte@anka.se", "Tjatte", "Anka", "Anka", "1337411", 27777 },
                    { 4, "Gata51231", 4, "Fnatte@Hotmail.com", "Fnatte", "Anka", "Anka", "12312313", 25555 },
                    { 5, "Gata5123123121", 1, "Latte@Hotmail.com", "Latte", "Anka", "Anka", "123124667", 25552 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: 5);
        }
    }
}
