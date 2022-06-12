using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishTank.Persistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "LivingEnvironments",
                columns: new[] { "Id", "Name", "WaterType" },
                values: new object[] { 1, "Malawi Lake", "Fresh Water" });

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "LivingEnvironmentId", "Modified", "ModifiedBy", "StatusId", "FishName_LatinName", "FishName_Name" },
                values: new object[] { 1, new DateTime(2022, 6, 12, 13, 10, 59, 598, DateTimeKind.Local).AddTicks(3103), "Auto Generate", null, null, 1, null, null, 1, "Pseudotorpheus", "Yellow" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LivingEnvironments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
