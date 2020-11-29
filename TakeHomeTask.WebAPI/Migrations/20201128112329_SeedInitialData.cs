using Microsoft.EntityFrameworkCore.Migrations;

namespace TakeHome.WebAPI.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Invoices (Description,Amount,InvoiceDate,DeliveryDate,SettleDate,InvoiceVat,Currency,ExchangeRate,OrderNumber,SalesAgent) VALUES ('Tax Invoice','45000','11/28/2020','11/28/2020','11/28/2020','7.5','$','4.30','ORD3092','Agent0982')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Invoices");
        }
    }
}
