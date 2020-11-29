using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeHome.WebAPI.Migrations
{
    public partial class Initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceNumber = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    SettleDate = table.Column<DateTime>(nullable: false),
                    InvoiceVat = table.Column<string>(maxLength: 20, nullable: false),
                    Currency = table.Column<string>(maxLength: 10, nullable: false),
                    ExchangeRate = table.Column<string>(maxLength: 20, nullable: false),
                    Client = table.Column<string>(maxLength: 50, nullable: false),
                    OrderNumber = table.Column<string>(maxLength: 50, nullable: false),
                    SalesAgent = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
