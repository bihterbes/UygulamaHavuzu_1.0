using Microsoft.EntityFrameworkCore.Migrations;

namespace UygulamaHavuzu_1._0.Migrations
{
    public partial class RemoveNameForYapmaListesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Todo_tablo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Todo_tablo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
