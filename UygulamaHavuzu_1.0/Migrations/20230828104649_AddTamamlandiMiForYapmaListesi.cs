using Microsoft.EntityFrameworkCore.Migrations;

namespace UygulamaHavuzu_1._0.Migrations
{
    public partial class AddTamamlandiMiForYapmaListesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TamamlandiMi",
                table: "Todo_tablo",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamamlandiMi",
                table: "Todo_tablo");
        }
    }
}
