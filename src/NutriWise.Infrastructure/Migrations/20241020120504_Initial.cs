using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KitchenEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CookingInstructions = table.Column<string>(type: "text", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodSubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodSubCategories_FoodCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    BirthdayDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    ActivityLevel = table.Column<int>(type: "integer", nullable: false),
                    DietGoalType = table.Column<int>(type: "integer", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodSubCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Calories = table.Column<double>(type: "double precision", nullable: false),
                    Proteins = table.Column<double>(type: "double precision", nullable: false),
                    Fats = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrates = table.Column<double>(type: "double precision", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_FoodSubCategories_FoodSubCategoryId",
                        column: x => x.FoodSubCategoryId,
                        principalTable: "FoodSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllergyUserProfile",
                columns: table => new
                {
                    AllergiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserProfilesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyUserProfile", x => new { x.AllergiesId, x.UserProfilesId });
                    table.ForeignKey(
                        name: "FK_AllergyUserProfile_Allergies_AllergiesId",
                        column: x => x.AllergiesId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyUserProfile_UserProfiles_UserProfilesId",
                        column: x => x.UserProfilesId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitchenEquipmentUserProfile",
                columns: table => new
                {
                    KitchenEquipmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserProfilesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenEquipmentUserProfile", x => new { x.KitchenEquipmentsId, x.UserProfilesId });
                    table.ForeignKey(
                        name: "FK_KitchenEquipmentUserProfile_KitchenEquipments_KitchenEquipm~",
                        column: x => x.KitchenEquipmentsId,
                        principalTable: "KitchenEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitchenEquipmentUserProfile_UserProfiles_UserProfilesId",
                        column: x => x.UserProfilesId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    MeasurmentType = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    FoodRecipeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_FoodRecipeId",
                        column: x => x.FoodRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08fc2e24-ada6-4627-a7c9-54c6710b89bf"), "Shellfish" },
                    { new Guid("29d0f11c-1441-480e-88e3-bd168f491bf7"), "Wheat" },
                    { new Guid("29e54674-0d1d-494e-ba86-5cfe7619c2c1"), "Dairy" },
                    { new Guid("2d2bd723-7181-427e-b685-54c798455b88"), "Eggs" },
                    { new Guid("3b3220e7-0e56-4966-87c2-10166f4f13eb"), "Tree Nuts" },
                    { new Guid("416046a2-0c68-4cfa-936b-81cb3e50172f"), "Fish" },
                    { new Guid("4e6ff995-5be4-4fbf-aab7-5f81e8459dca"), "Sesame" },
                    { new Guid("604d731e-840e-48c2-a4e6-d29eb9b1cc46"), "Peanuts" },
                    { new Guid("c2eab0a0-98f7-40c7-8968-9e040cb67f1d"), "Soy" },
                    { new Guid("f76ebb60-8b54-42e1-a284-4a4a04f18e50"), "Gluten" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("291bdc89-fd59-416f-b444-52bbfdf99a73"), "Baking Ingredients" },
                    { new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Fruits" },
                    { new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Meats" },
                    { new Guid("80735ea8-6301-48eb-8249-4578981b97c6"), "Oils and Fats" },
                    { new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"), "Grains and Legumes" },
                    { new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Vegetables" },
                    { new Guid("baad7895-49e2-4cc8-8b40-4f53dd02dc30"), "Nuts and Seeds" },
                    { new Guid("c1accd7d-995f-449d-b598-a85360d6cb99"), "Dairy" },
                    { new Guid("dd9d8ae5-cd0a-4ecd-ab69-bfe974d541ce"), "Herbs and Spices" }
                });

            migrationBuilder.InsertData(
                table: "KitchenEquipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28df446c-190f-4a0b-9176-4bf58ee9db08"), "Grill" },
                    { new Guid("50ec680b-c656-4796-a3ce-239496d37c9e"), "Mixer" },
                    { new Guid("60209fe5-8c58-4870-b8d9-de72f1e74739"), "Microwave" },
                    { new Guid("6053e43a-e3d4-450a-951a-f83c2d0c67c1"), "Air Fryer" },
                    { new Guid("7c49854b-ecdf-467f-9f75-aecdcaf74eac"), "Pressure Cooker" },
                    { new Guid("c2d8da1f-b39d-4e87-abea-ec302da66149"), "Food Processor" },
                    { new Guid("c7e90907-fbd8-493b-b680-aaf52a4bfc4c"), "Slow Cooker" },
                    { new Guid("cf55ec6e-d045-482b-8111-d5320fff5f47"), "Toaster" },
                    { new Guid("d7a93261-1a31-463f-88a9-c122b54c2008"), "Oven" },
                    { new Guid("db54a856-91f1-4295-b0c3-b4bd60e56403"), "Blender" },
                    { new Guid("f194e8da-668f-4e0d-ae92-6d6404a6742c"), "Rice Cooker" },
                    { new Guid("faf16d73-52ce-4991-9945-010dcce84762"), "Stove" }
                });

            migrationBuilder.InsertData(
                table: "FoodSubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("03c6acb5-e654-4497-b9b7-7ac9c973543c"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Citrus Fruits" },
                    { new Guid("0cb713f1-7d24-4c5b-9936-78f34c19142d"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Cruciferous Vegetables" },
                    { new Guid("1cc6ffeb-b5bb-43a7-8c24-9b59451c6b97"), new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"), "Legumes" },
                    { new Guid("2382c00d-8751-4e88-abc4-f85f37c5b499"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Nightshades" },
                    { new Guid("2383e528-a293-4515-903f-82623e2e095d"), new Guid("dd9d8ae5-cd0a-4ecd-ab69-bfe974d541ce"), "Spices" },
                    { new Guid("314e9055-4782-4ea3-ac36-17786810b7d6"), new Guid("291bdc89-fd59-416f-b444-52bbfdf99a73"), "Sugars" },
                    { new Guid("38c4fc47-d01a-42c5-bb82-aff9e102dfe9"), new Guid("c1accd7d-995f-449d-b598-a85360d6cb99"), "Other Dairy" },
                    { new Guid("41838eb2-8aec-4738-89d1-6b66cbc6f2c5"), new Guid("291bdc89-fd59-416f-b444-52bbfdf99a73"), "Baking Ingredients" },
                    { new Guid("48e2ae8b-ecd7-499c-b8e6-01aab7b14c5b"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Squash Vegetables" },
                    { new Guid("53ef3c99-32d4-44ab-9c0d-864d28ce9c37"), new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Fish" },
                    { new Guid("5e172221-57ba-4ae8-b2a2-f045f2b25092"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Tropical Fruits" },
                    { new Guid("67d023bb-4c41-47c5-9331-389c0fbea7ce"), new Guid("c1accd7d-995f-449d-b598-a85360d6cb99"), "Milk" },
                    { new Guid("6ae81459-579d-4a92-888f-d3f1f3e56491"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Melons" },
                    { new Guid("6b503ebf-7280-41a0-afe4-c09737d8e751"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Allium Vegetables" },
                    { new Guid("6e32f70b-a61b-4d6c-8584-9ce2faf65fa8"), new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"), "Rice" },
                    { new Guid("751e597e-d74c-4327-8508-571edb1e94ec"), new Guid("dd9d8ae5-cd0a-4ecd-ab69-bfe974d541ce"), "Herbs" },
                    { new Guid("838f7c7e-c03b-48c0-a023-1e7e20d6596a"), new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Poultry" },
                    { new Guid("928b5b5b-a149-44f8-b243-3a724d1eba6c"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Berries" },
                    { new Guid("9de41ce9-7ecf-4bae-8dc3-3c07da6561f2"), new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Shellfish" },
                    { new Guid("9ea992a1-b818-4b63-ac23-c9f9b188d583"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Leafy Greens" },
                    { new Guid("a158d6ca-3e82-444a-b305-c96e45ec3a80"), new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Pork" },
                    { new Guid("a71d8fba-913f-4fed-b91f-c1ce0f8ccb2d"), new Guid("baad7895-49e2-4cc8-8b40-4f53dd02dc30"), "Seeds" },
                    { new Guid("a754df1c-db94-41ef-828b-856b8d9600d1"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Pome Fruits" },
                    { new Guid("b6a98d97-e15d-492a-846b-17ea179b7092"), new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"), "Beef" },
                    { new Guid("bb2d4bba-299a-4492-8c18-bb5b9abe413a"), new Guid("80735ea8-6301-48eb-8249-4578981b97c6"), "Oils" },
                    { new Guid("bfffed6b-ad4a-4234-94ab-a2e74f113853"), new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"), "Other Grains" },
                    { new Guid("c16d80ba-6b7a-4ef7-a879-05f3f88c27a2"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Stone Fruits" },
                    { new Guid("c4534728-bbf8-40aa-ba51-d2b86b0b114a"), new Guid("c1accd7d-995f-449d-b598-a85360d6cb99"), "Cheese" },
                    { new Guid("c61871d2-0801-4144-8ebe-66042de8a923"), new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"), "Dried Fruits" },
                    { new Guid("d25f7edb-0709-4a75-85c4-e508c5df0f48"), new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"), "Root Vegetables" },
                    { new Guid("d7afa165-abab-4cd8-880c-3d5c0d5eef7e"), new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"), "Pasta" },
                    { new Guid("fb65bf4f-958f-4d70-a62d-cb5c9cf163a7"), new Guid("baad7895-49e2-4cc8-8b40-4f53dd02dc30"), "Nuts" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllergyUserProfile_UserProfilesId",
                table: "AllergyUserProfile",
                column: "UserProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodSubCategories_CategoryId",
                table: "FoodSubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_KitchenEquipmentUserProfile_UserProfilesId",
                table: "KitchenEquipmentUserProfile",
                column: "UserProfilesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FoodSubCategoryId",
                table: "Products",
                column: "FoodSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_FoodRecipeId",
                table: "RecipeIngredients",
                column: "FoodRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_ProductId",
                table: "RecipeIngredients",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergyUserProfile");

            migrationBuilder.DropTable(
                name: "KitchenEquipmentUserProfile");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "KitchenEquipments");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "FoodSubCategories");

            migrationBuilder.DropTable(
                name: "FoodCategories");
        }
    }
}
