using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WbSailerNotifier.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAssemblyTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AssemblyTasks",
                schema: "wb-sailer-notifier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    IsNotified = table.Column<bool>(type: "boolean", nullable: true),
                    FullAddress = table.Column<string>(type: "text", nullable: true),
                    LongitudeAddress = table.Column<decimal>(type: "numeric", nullable: true),
                    LatitudeAddress = table.Column<decimal>(type: "numeric", nullable: true),
                    Ddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SalePrice = table.Column<int>(type: "integer", nullable: true),
                    DTimeFrom = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DTimeTo = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RequiredMeta = table.Column<List<string>>(type: "text[]", nullable: false),
                    DeliveryType = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    ScanPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderUid = table.Column<string>(type: "text", nullable: false),
                    Article = table.Column<string>(type: "text", nullable: false),
                    ColorCode = table.Column<string>(type: "text", nullable: false),
                    Rid = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Offices = table.Column<List<string>>(type: "text[]", nullable: false),
                    Skus = table.Column<List<string>>(type: "text[]", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: true),
                    NmId = table.Column<int>(type: "integer", nullable: true),
                    ChrtId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: true),
                    ConvertedPrice = table.Column<int>(type: "integer", nullable: true),
                    CurrencyCode = table.Column<int>(type: "integer", nullable: true),
                    ConvertedCurrencyCode = table.Column<int>(type: "integer", nullable: true),
                    CargoType = table.Column<int>(type: "integer", nullable: true),
                    IsZeroOrder = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssemblyTasks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssemblyTasks",
                schema: "wb-sailer-notifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                schema: "wb-sailer-notifier",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
