using Microsoft.EntityFrameworkCore.Migrations;

namespace test1.Migrations
{
    public partial class obl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Leave",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Log",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leave",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "Log",
                table: "MovementRecords");
        }
    }
}
