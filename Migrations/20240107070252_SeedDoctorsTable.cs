using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hospital.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "docts",
                columns: new[] { "id", "FEES", "description", "name" },
                values: new object[,]
                {
                    { 1, 2000, "cardiologist", " Arun Kumar" },
                    { 2, 1500, "dentist", " Venugopal Iyer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "docts",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "docts",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
