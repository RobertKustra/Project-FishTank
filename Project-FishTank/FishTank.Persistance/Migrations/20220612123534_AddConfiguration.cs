using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishTank.Persistance.Migrations
{
    public partial class AddConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EatingsHabitFish");

            migrationBuilder.RenameColumn(
                name: "FishName_Name",
                table: "Fish",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FishName_LatinName",
                table: "Fish",
                newName: "LatinName");

            migrationBuilder.AlterColumn<string>(
                name: "WaterType",
                table: "LivingEnvironments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LivingEnvironments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fish",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LatinName",
                table: "Fish",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EatingsHabits",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "EatingsHabitsFish",
                columns: table => new
                {
                    EatingsHabitsId = table.Column<int>(type: "int", nullable: false),
                    FishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingsHabitsFish", x => new { x.EatingsHabitsId, x.FishId });
                    table.ForeignKey(
                        name: "FK_EatingsHabitsFish_EatingsHabits_EatingsHabitsId",
                        column: x => x.EatingsHabitsId,
                        principalTable: "EatingsHabits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EatingsHabitsFish_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 12, 14, 35, 34, 515, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.CreateIndex(
                name: "IX_EatingsHabitsFish_FishId",
                table: "EatingsHabitsFish",
                column: "FishId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EatingsHabitsFish");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fish",
                newName: "FishName_Name");

            migrationBuilder.RenameColumn(
                name: "LatinName",
                table: "Fish",
                newName: "FishName_LatinName");

            migrationBuilder.AlterColumn<string>(
                name: "WaterType",
                table: "LivingEnvironments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LivingEnvironments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FishName_Name",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FishName_LatinName",
                table: "Fish",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EatingsHabits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "EatingsHabitFish",
                columns: table => new
                {
                    EatingsHabitsId = table.Column<int>(type: "int", nullable: false),
                    FishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingsHabitFish", x => new { x.EatingsHabitsId, x.FishId });
                    table.ForeignKey(
                        name: "FK_EatingsHabitFish_EatingsHabits_EatingsHabitsId",
                        column: x => x.EatingsHabitsId,
                        principalTable: "EatingsHabits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EatingsHabitFish_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 12, 13, 10, 59, 598, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.CreateIndex(
                name: "IX_EatingsHabitFish_FishId",
                table: "EatingsHabitFish",
                column: "FishId");
        }
    }
}
