using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HB.MvcAppWDB.Migrations
{
    /// <inheritdoc />
    public partial class nulllableprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategorler_KategoriID",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriID",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategorler_KategoriID",
                table: "Kitaplar",
                column: "KategoriID",
                principalTable: "Kategorler",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategorler_KategoriID",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriID",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategorler_KategoriID",
                table: "Kitaplar",
                column: "KategoriID",
                principalTable: "Kategorler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
