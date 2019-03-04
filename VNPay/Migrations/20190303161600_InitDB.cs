using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNPay.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderInfo",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    OrderDescription = table.Column<string>(nullable: true),
                    BankCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    vnp_TransactionNo = table.Column<decimal>(nullable: false),
                    vpn_Message = table.Column<string>(nullable: true),
                    vpn_TxnResponseCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfo", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderInfo");
        }
    }
}
