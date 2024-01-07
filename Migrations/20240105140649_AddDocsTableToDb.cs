using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hospital.Migrations
{
    /// <inheritdoc />
    public partial class AddDocsTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FEES = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Docs",
                columns: new[] { "id", "FEES", "description", "name" },
                values: new object[,]
                {
                    { 1, 2000, "cardiologist", " Arun Kumar" },
                    { 2, 1500, "dentist", " Venugopal Iyer" },
                    { 3, 800, "General Physician", "steve rogers" },
                    { 4, 2500, "Emergency OPD", "Dr.Krishna Vasudev " },
                    { 5, 3000, "Dean", "Dr.Tony Stark " },
                    { 6, 500, "Urologist", "Dr.Natasha Ramonoff " },
                    { 7, 800, "Neurologist", "Dr.Thor Odinson " },
                    { 8, 600, "physic", "Dr.Bruce Banner " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docs");
        }
    }
}
