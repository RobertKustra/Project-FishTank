using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishTank.Persistance.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EatingsHabits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingsHabits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivingEnvironments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingEnvironments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FishName_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FishName_LatinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivingEnvironmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fish_LivingEnvironments_LivingEnvironmentId",
                        column: x => x.LivingEnvironmentId,
                        principalTable: "LivingEnvironments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EatingsHabitFish_FishId",
                table: "EatingsHabitFish",
                column: "FishId");

            migrationBuilder.CreateIndex(
                name: "IX_Fish_LivingEnvironmentId",
                table: "Fish",
                column: "LivingEnvironmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EatingsHabitFish");

            migrationBuilder.DropTable(
                name: "EatingsHabits");

            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "LivingEnvironments");
        }
    }
}
