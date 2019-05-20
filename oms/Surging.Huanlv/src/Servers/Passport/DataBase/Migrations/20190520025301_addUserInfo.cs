using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class addUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OemId = table.Column<int>(nullable: false),
                    Cellphone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ModifiedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserWxInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: false),
                    OpenId = table.Column<string>(maxLength: 100, nullable: true),
                    NickName = table.Column<string>(maxLength: 100, nullable: true),
                    HeadImage = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWxInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserWxInfo_UserId",
                table: "UserWxInfo",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserWxInfo");
        }
    }
}
