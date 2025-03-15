using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modelDB.Migrations
{
    /// <inheritdoc />
    public partial class LatLon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Lat",
                table: "city",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Lon",
                table: "city",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "city");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "city");
        }
    }
}
