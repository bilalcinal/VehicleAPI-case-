using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wheels",
                table: "Boats");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wheels",
                table: "Boats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
