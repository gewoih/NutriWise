using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MealPlan_Removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyMeals_MealPlans_MealPlanId",
                table: "DailyMeals");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropIndex(
                name: "IX_DailyMeals_MealPlanId",
                table: "DailyMeals");

            migrationBuilder.DropColumn(
                name: "MealPlanId",
                table: "DailyMeals");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "DailyMeals",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DailyMeals");

            migrationBuilder.AddColumn<Guid>(
                name: "MealPlanId",
                table: "DailyMeals",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DaysCount = table.Column<int>(type: "integer", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_MealPlanId",
                table: "DailyMeals",
                column: "MealPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyMeals_MealPlans_MealPlanId",
                table: "DailyMeals",
                column: "MealPlanId",
                principalTable: "MealPlans",
                principalColumn: "Id");
        }
    }
}
