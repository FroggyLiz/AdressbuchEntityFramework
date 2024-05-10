using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdressbuchEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Geburtstag",
                table: "AdressEinträge",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TelefonNummer",
                table: "AdressEinträge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Adressen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Straße = table.Column<string>(type: "TEXT", nullable: false),
                    Hausnummer = table.Column<string>(type: "TEXT", nullable: false),
                    Postleitzahl = table.Column<string>(type: "TEXT", nullable: false),
                    Stadt = table.Column<string>(type: "TEXT", nullable: false),
                    AdressEintragId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adressen_AdressEinträge_AdressEintragId",
                        column: x => x.AdressEintragId,
                        principalTable: "AdressEinträge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adressen_AdressEintragId",
                table: "Adressen",
                column: "AdressEintragId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adressen");

            migrationBuilder.DropColumn(
                name: "Geburtstag",
                table: "AdressEinträge");

            migrationBuilder.DropColumn(
                name: "TelefonNummer",
                table: "AdressEinträge");
        }
    }
}
