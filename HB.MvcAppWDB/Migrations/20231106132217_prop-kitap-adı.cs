using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HB.MvcAppWDB.Migrations
{
    /// <inheritdoc />
    public partial class propkitapadı : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KitapAdı",
                table: "Kitaplar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitapAdı",
                table: "Kitaplar");
        }
    }
}
