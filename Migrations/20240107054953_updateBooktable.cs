using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospital.Migrations
{
    /// <inheritdoc />
    public partial class updateBooktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientAge = table.Column<int>(type: "int", nullable: false),
                    Pemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cno = table.Column<int>(type: "int", nullable: false),
                    ApDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ApDate", "Cno", "Dname", "PatientAge", "PatientName", "Pemail" },
                values: new object[] { 1, "12-12-2003", 2000, "ppp", 10, "john", "cyoh" });

            migrationBuilder.InsertData(
                table: "Docs",
                columns: new[] { "id", "FEES", "description", "name" },
                values: new object[] { 9, 400, "gymasic", "Dr.Bruce Bannen " });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DeleteData(
                table: "Docs",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
