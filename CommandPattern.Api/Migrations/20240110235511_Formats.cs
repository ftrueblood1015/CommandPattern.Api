using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandPattern.Api.Migrations
{
    /// <inheritdoc />
    public partial class Formats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[] { 1L, "Commander", true, "Commander" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formats");
        }
    }
}
