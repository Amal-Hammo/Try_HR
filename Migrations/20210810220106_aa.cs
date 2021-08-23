using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test1.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leave",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "LeaveDate",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "LogIn",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "LogInDate",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "LogOut",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "LogOutDate",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "Return",
                table: "MovementRecords");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "MovementRecords",
                newName: "MoveDate");

            migrationBuilder.AddColumn<int>(
                name: "MoveID",
                table: "MovementRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MoveTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveTypes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovementRecords_MoveID",
                table: "MovementRecords",
                column: "MoveID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovementRecords_MoveTypes_MoveID",
                table: "MovementRecords",
                column: "MoveID",
                principalTable: "MoveTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovementRecords_MoveTypes_MoveID",
                table: "MovementRecords");

            migrationBuilder.DropTable(
                name: "MoveTypes");

            migrationBuilder.DropIndex(
                name: "IX_MovementRecords_MoveID",
                table: "MovementRecords");

            migrationBuilder.DropColumn(
                name: "MoveID",
                table: "MovementRecords");

            migrationBuilder.RenameColumn(
                name: "MoveDate",
                table: "MovementRecords",
                newName: "ReturnDate");

            migrationBuilder.AddColumn<bool>(
                name: "Leave",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeaveDate",
                table: "MovementRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "LogIn",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LogInDate",
                table: "MovementRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "LogOut",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LogOutDate",
                table: "MovementRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Return",
                table: "MovementRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
