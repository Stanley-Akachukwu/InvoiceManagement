using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeHome.WebAPI.Migrations
{
    public partial class Seeding_Guid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceNumber",
                table: "Invoices",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceNumber", "Amount", "Client", "Currency", "DeliveryDate", "Description", "ExchangeRate", "InvoiceDate", "InvoiceVat", "OrderNumber", "SalesAgent", "SettleDate" },
                values: new object[] { new Guid("4fa4a36a-d5b3-4aee-b9e7-ae6df318b31d"), 45000m, "Zubby Inc.", "$", new DateTime(2020, 11, 28, 21, 37, 28, 705, DateTimeKind.Local).AddTicks(1389), "Tax Invoice", "4.30", new DateTime(2020, 11, 28, 21, 37, 28, 703, DateTimeKind.Local).AddTicks(6310), "7.5", "ORD3092", "Agent0982", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceNumber",
                keyValue: new Guid("4fa4a36a-d5b3-4aee-b9e7-ae6df318b31d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");
        }
    }
}
