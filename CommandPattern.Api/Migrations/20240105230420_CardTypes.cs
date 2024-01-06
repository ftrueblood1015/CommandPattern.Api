using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommandPattern.Api.Migrations
{
    /// <inheritdoc />
    public partial class CardTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardTypes",
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
                    table.PrimaryKey("PK_CardTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1L, "Creature", true, "Creature" },
                    { 2L, "Basic Land", true, "Basic Land" },
                    { 3L, "Land", true, "Land" },
                    { 4L, "Artifact", true, "Artifact" },
                    { 5L, "Instant", true, "Instant" },
                    { 6L, "Sorcery", true, "Sorcery" },
                    { 7L, "Enchantment", true, "Enchantment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTypes");
        }
    }
}
