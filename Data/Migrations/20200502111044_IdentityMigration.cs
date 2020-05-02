using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalManager.Migrations
{
    public partial class IdentityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_userId",
                table: "User",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_userId",
                table: "User",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_userId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_userId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "User");
        }
    }
}
