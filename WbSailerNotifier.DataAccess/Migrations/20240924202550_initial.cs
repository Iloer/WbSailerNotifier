using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WbSailerNotifier.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "wb-sailer-notifier");

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "wb-sailer-notifier",
                columns: table => new
                {
                    Srid = table.Column<string>(type: "text", nullable: false),
                    IsNotified = table.Column<bool>(type: "boolean", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastChangeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WarehouseName = table.Column<string>(type: "text", nullable: false),
                    CountryName = table.Column<string>(type: "text", nullable: false),
                    OblastOkrugName = table.Column<string>(type: "text", nullable: false),
                    RegionName = table.Column<string>(type: "text", nullable: false),
                    SupplierArticle = table.Column<string>(type: "text", nullable: false),
                    NmId = table.Column<int>(type: "integer", nullable: true),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    TechSize = table.Column<string>(type: "text", nullable: false),
                    IncomeID = table.Column<int>(type: "integer", nullable: true),
                    IsSupply = table.Column<bool>(type: "boolean", nullable: true),
                    IsRealization = table.Column<bool>(type: "boolean", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    DiscountPercent = table.Column<int>(type: "integer", nullable: true),
                    Spp = table.Column<decimal>(type: "numeric", nullable: true),
                    FinishedPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    PriceWithDisc = table.Column<decimal>(type: "numeric", nullable: true),
                    IsCancel = table.Column<bool>(type: "boolean", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OrderType = table.Column<string>(type: "text", nullable: false),
                    Sticker = table.Column<string>(type: "text", nullable: false),
                    GNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Srid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders",
                schema: "wb-sailer-notifier");
        }
    }
}
