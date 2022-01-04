using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoggingSQLDemo2022.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Realeased = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeveloperId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Company_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "Name" },
                values: new object[] { 1, "CD Project" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "Name" },
                values: new object[] { 2, "Id Software" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "DeveloperId", "Name", "Realeased" },
                values: new object[] { 1, 1, "Witcher: Wild Hunt", new DateTime(2015, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "DeveloperId", "Name", "Realeased" },
                values: new object[] { 2, 1, "Cyberpunk 2077", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "DeveloperId", "Name", "Realeased" },
                values: new object[] { 3, 2, "Doom", new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 1, 1, "RPG" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 2, 1, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 3, 1, "Action" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 4, 2, "RPG" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 5, 2, "Cyberpunk" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 6, 2, "Action" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 7, 3, "Shooter" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 8, 3, "Action" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "GameId", "Text" },
                values: new object[] { 9, 3, "Sci-fi" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_GameId",
                table: "Tags",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
