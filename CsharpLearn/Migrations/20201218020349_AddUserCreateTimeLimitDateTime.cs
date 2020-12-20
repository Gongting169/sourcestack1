using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharplearn.Migrations
{
    public partial class AddUserCreateTimeLimitDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Register",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddCheckConstraint(
                name: "CK_CreateTime",
                table: "Register",
                sql: "CreateTime >= '2020/1/1'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_CreateTime",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Register");
        }
    }
}
