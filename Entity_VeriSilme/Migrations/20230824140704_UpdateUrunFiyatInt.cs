using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Veri_Silme.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunFiyatInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UrunFiyat",
                table: "Urunler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunFiyat",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
