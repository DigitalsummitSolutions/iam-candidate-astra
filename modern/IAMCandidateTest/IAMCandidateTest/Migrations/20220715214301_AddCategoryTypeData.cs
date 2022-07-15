using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IAMCandidateTest.Migrations
{
    public partial class AddCategoryTypeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Animal" });

            migrationBuilder.InsertData(
                table: "CategoryType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Minderal" });

            migrationBuilder.InsertData(
                table: "CategoryType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Vegetable" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
