using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Providers.DataAccess.Migrations
{
    public partial class seedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatalogueItemCategory",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 10, 23, 14, 53, 589, DateTimeKind.Local).AddTicks(9085), "Dessert" },
                    { 2, new DateTime(2021, 2, 10, 23, 14, 53, 589, DateTimeKind.Local).AddTicks(9918), "Main Course" },
                    { 3, new DateTime(2021, 2, 10, 23, 14, 53, 589, DateTimeKind.Local).AddTicks(9928), "Soups" },
                    { 4, new DateTime(2021, 2, 10, 23, 14, 53, 589, DateTimeKind.Local).AddTicks(9932), "Apperitives" }
                });

            migrationBuilder.InsertData(
                table: "ProviderCategory",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 10, 23, 14, 53, 583, DateTimeKind.Local).AddTicks(3028), "Mediteranean Cousine" },
                    { 2, new DateTime(2021, 2, 10, 23, 14, 53, 587, DateTimeKind.Local).AddTicks(7102), "Tradinional Romanian Cousine" },
                    { 3, new DateTime(2021, 2, 10, 23, 14, 53, 587, DateTimeKind.Local).AddTicks(7183), "Japonese Cousine" },
                    { 4, new DateTime(2021, 2, 10, 23, 14, 53, 587, DateTimeKind.Local).AddTicks(7190), "Thai Cousine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
