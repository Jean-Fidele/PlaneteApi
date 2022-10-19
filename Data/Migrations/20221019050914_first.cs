using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Societe",
                columns: new[] { "SocieteId", "AdressCompl", "Adresse", "Capital", "CategHotelId", "ChampLibre", "ChampLibre2", "ChampLibre3", "Email", "Fax", "FormeJuridiqueId", "Latitude", "Logo", "Longitude", "NIF", "Nom", "PaysId", "Region", "RegionCode", "Stat", "Tel", "Website" },
                values: new object[] { 1, "Ambohibao", "Analamahitsy", 10000m, 1, null, null, null, "fidele999@gmail.com", null, 101, null, null, null, null, "O3 Consulting", 1, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Societe",
                keyColumn: "SocieteId",
                keyValue: 1);
        }
    }
}
