using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandPattern.Api.Migrations
{
    /// <inheritdoc />
    public partial class Cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConvertedManaCost = table.Column<int>(type: "int", nullable: false),
                    SetId = table.Column<long>(type: "bigint", nullable: false),
                    CardTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ColorIdentityId = table.Column<long>(type: "bigint", nullable: false),
                    RarityId = table.Column<long>(type: "bigint", nullable: false),
                    CardPurposeId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_CardPurposes_CardPurposeId",
                        column: x => x.CardPurposeId,
                        principalTable: "CardPurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_CardTypes_CardTypeId",
                        column: x => x.CardTypeId,
                        principalTable: "CardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_ColorIdentities_ColorIdentityId",
                        column: x => x.ColorIdentityId,
                        principalTable: "ColorIdentities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardPurposeId", "CardTypeId", "ColorIdentityId", "ConvertedManaCost", "Description", "IsActive", "Name", "RarityId", "SetId" },
                values: new object[] { 1L, 1L, 4L, 6L, 0, "Black Lotus", true, "Black Lotus", 3L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardPurposeId",
                table: "Cards",
                column: "CardPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardTypeId",
                table: "Cards",
                column: "CardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ColorIdentityId",
                table: "Cards",
                column: "ColorIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_RarityId",
                table: "Cards",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_SetId",
                table: "Cards",
                column: "SetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
