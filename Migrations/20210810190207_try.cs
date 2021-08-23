using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test1.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Move",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Move",
                table: "MovementRecords",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
