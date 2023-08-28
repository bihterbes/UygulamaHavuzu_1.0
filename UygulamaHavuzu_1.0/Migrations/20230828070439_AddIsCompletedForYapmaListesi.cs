using Microsoft.EntityFrameworkCore.Migrations;

namespace UygulamaHavuzu_1._0.Migrations
{
    public partial class AddIsCompletedForYapmaListesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Todo_tablo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Todo_tablo");
        }
    }
}
