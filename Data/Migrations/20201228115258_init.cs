using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Documents.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EvrakTipis",
                columns: table => new
                {
                    TipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvrakTipis", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "Evraks",
                columns: table => new
                {
                    EvrakID = table.Column<Guid>(nullable: false),
                    Adi = table.Column<string>(nullable: true),
                    Konu = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    TipID = table.Column<int>(nullable: false),
                    EvrakTipiTipID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evraks", x => x.EvrakID);
                    table.ForeignKey(
                        name: "FK_Evraks_EvrakTipis_EvrakTipiTipID",
                        column: x => x.EvrakTipiTipID,
                        principalTable: "EvrakTipis",
                        principalColumn: "TipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evraks_EvrakTipiTipID",
                table: "Evraks",
                column: "EvrakTipiTipID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evraks");

            migrationBuilder.DropTable(
                name: "EvrakTipis");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
