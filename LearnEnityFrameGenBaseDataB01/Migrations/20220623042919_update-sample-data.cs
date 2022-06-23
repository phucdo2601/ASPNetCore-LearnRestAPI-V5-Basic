using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnEnityFrameGenBaseDataB01.Migrations
{
    public partial class updatesampledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Uncle", "Bob" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Jan", "Kirsten" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
