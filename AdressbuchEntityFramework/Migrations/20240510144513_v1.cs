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
            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "AdressEinträge",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdressEinträge_AdressId",
                table: "AdressEinträge",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdressEinträge_Adressen_AdressId",
                table: "AdressEinträge",
                column: "AdressId",
                principalTable: "Adressen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdressEinträge_Adressen_AdressId",
                table: "AdressEinträge");

            migrationBuilder.DropTable(
                name: "Adressen");

            migrationBuilder.DropIndex(
                name: "IX_AdressEinträge_AdressId",
                table: "AdressEinträge");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "AdressEinträge");

            migrationBuilder.DropColumn(
                name: "Geburtstag",
                table: "AdressEinträge");

            migrationBuilder.DropColumn(
                name: "TelefonNummer",
                table: "AdressEinträge");
        }
    }
}
