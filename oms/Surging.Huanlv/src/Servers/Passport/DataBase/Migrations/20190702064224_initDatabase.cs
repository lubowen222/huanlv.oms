using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserWxInfo");

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OemId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    IsDisable = table.Column<bool>(nullable: false),
                    FirstLogonTime = table.Column<DateTime>(nullable: false),
                    LastLogonTime = table.Column<DateTime>(nullable: false),
                    LogonErrorNum = table.Column<int>(nullable: false),
                    LogonError = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userinfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OemId = table.Column<int>(nullable: false),
                    AccountId = table.Column<long>(nullable: false),
                    NickName = table.Column<string>(maxLength: 20, nullable: true),
                    RealName = table.Column<string>(maxLength: 20, nullable: true),
                    HeadImg = table.Column<string>(maxLength: 255, nullable: true),
                    Mail = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    QQ = table.Column<string>(maxLength: 50, nullable: true),
                    Weixin = table.Column<string>(maxLength: 50, nullable: true),
                    Wid = table.Column<string>(maxLength: 100, nullable: true),
                    Province = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    Region = table.Column<string>(maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsFakePhone = table.Column<bool>(nullable: false),
                    Source = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userinfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_account_OemId",
                table: "account",
                column: "OemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "userinfo");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cellphone = table.Column<string>(nullable: true),
                    ModifiedTime = table.Column<DateTime>(nullable: false),
                    OemId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RegisterTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
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
                    HeadImage = table.Column<string>(maxLength: 500, nullable: true),
                    NickName = table.Column<string>(maxLength: 100, nullable: true),
                    OpenId = table.Column<string>(maxLength: 100, nullable: true),
                    UserId = table.Column<long>(nullable: false)
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
    }
}
