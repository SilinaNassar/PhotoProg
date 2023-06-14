using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoProg.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(30)", nullable: false),
                    PictureName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureID);
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "PictureID", "FileName", "Location", "PictureName", "When" },
                values: new object[] { 1, "pecs1.jpg", "Pécs", "Panorama of Pécs", new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "PictureID", "FileName", "Location", "PictureName", "When" },
                values: new object[] { 2, "pecs2.jpg", "Pécs", "Crypt of the Cathedral", new DateTime(2018, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "PictureID", "FileName", "Location", "PictureName", "When" },
                values: new object[] { 3, "pecs3.jpg", "Pécs", "Havihegy church", new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pictures");
        }
    }
}
