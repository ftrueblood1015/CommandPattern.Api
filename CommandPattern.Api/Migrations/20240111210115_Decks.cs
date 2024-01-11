using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandPattern.Api.Migrations
{
    /// <inheritdoc />
    public partial class Decks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThemeId = table.Column<long>(type: "bigint", nullable: false),
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    FormatId = table.Column<long>(type: "bigint", nullable: false),
                    WinRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Formats_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Formats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decks_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decks_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "Id", "Description", "FormatId", "GuildId", "IsActive", "Name", "ThemeId", "WinRate" },
                values: new object[] { 1L, "Sliver Tribal", 1L, 1L, true, "Slivers!", 1L, 0m });

            migrationBuilder.CreateIndex(
                name: "IX_Decks_FormatId",
                table: "Decks",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_GuildId",
                table: "Decks",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_ThemeId",
                table: "Decks",
                column: "ThemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decks");
        }
    }
}
