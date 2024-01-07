using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hospital.Migrations
{
    /// <inheritdoc />
    public partial class SeedDtabaseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "hospitals",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "cardiologist", " Arun Kumar" },
                    { 2, "dentist", " Venugopal Iyer" },
                    { 3, "General Physician", "steve rogers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
