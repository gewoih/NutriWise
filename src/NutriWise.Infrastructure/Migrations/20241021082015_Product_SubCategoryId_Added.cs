using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Product_SubCategoryId_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_FoodSubCategories_FoodSubCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("06a506c3-cb8c-41a2-8e84-915703a87747"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("3c9a5706-ba6d-42d0-9e92-c69401842620"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6027a767-b04c-47f6-a79a-bc0ece0eb8a2"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6ae1e191-6b02-4b3d-b94c-749dcf86fd44"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6cabbc47-e9d4-413a-a5d6-4c29c223f996"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("7d999f26-3cc4-4065-bb66-be7594784687"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("a2115d27-52ad-41a8-a4d3-dceb4f57083c"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("afaac70d-8581-49cb-86bb-f6861d8d00c9"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c6a520c8-01d5-43a0-85b6-918fde1c2b82"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e61d54f6-6049-4a18-8bd4-4c190b657052"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0873c235-35a3-486a-9f22-26c218b9835b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0acf5173-c234-4051-80d6-de00e90f42c2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("108d3aa5-9980-4a5d-bcf3-d14dedd1ae8a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("15a8d309-f540-4a55-813d-b71372948a88"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("27daeb22-1ba7-429b-b4f2-8ea8ed22c408"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2dc27ae3-3505-418f-9b2d-4152ac066086"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e15c75f-92c1-4d8e-a3b4-af37bdc0212c"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("30d103a6-9356-424b-a8f6-e862236a8fd0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("38b07a82-b813-4d83-8abe-46642df44867"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3fb20cd4-3b7f-4651-ba5a-5cc15e4b72f7"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("43599cd4-b3ca-49fd-9d49-88ed7af95a46"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("45dc585d-65b0-4839-ae66-4f6fcf87749b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("49aa5cc5-01f2-4f38-b50b-d90e4059bf09"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b8eb8eb-2496-49ce-b125-3ae8410fad34"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("519cf1ff-d892-41f7-b16f-4021a4e083b8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ae538fe-2a67-454d-95f8-ef6158f44b51"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7da73681-82fe-4ca4-b7fb-096563b15bbd"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("802ff61b-d76e-4b2b-9dc4-7e2059e3c530"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("81da61f4-0654-4d95-af14-abbd14d20951"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("85abf512-c7f8-4f75-9307-f8042f642002"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("85ec0e49-d7cb-4a8d-a2f7-0bbd32555aca"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac35aa10-44da-4d0b-9068-68b4a640bfbe"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd4c104b-bb4d-482d-be08-f8962f2a4ab7"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf48413d-15bb-4a8f-98c8-3bded3b3fe3b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb62d76d-e302-471b-83bc-b6f491cb9b8d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d226a4ba-80cb-4584-9f9c-806ec9f32e58"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("da77506c-7544-48c7-9383-09e0fbe67738"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("de0551ee-0d70-4a32-ab80-abdf6acb0990"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e120d296-27d6-4d5d-af04-86de6b04320f"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb947b74-5804-4433-9220-9f8ad2a02104"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1103175-a80b-4ea4-9b2c-136541d0384e"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fada0c45-3f76-4137-a716-47d2564aa6be"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("06f67933-7537-4e2f-a673-19af1a55655b"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("1b2dbf44-07cf-4377-aa56-8e4541841b1e"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("1d069d73-0c1b-42ae-aa49-2cc0860248a3"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("2010bfc4-139a-499b-80ac-9e5bc2c4bf02"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("206bef1e-950e-437b-b02b-ea86a6ae972a"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("730a74b1-67af-413f-b908-9e71e5a71058"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("a1c84707-db4b-46c4-9321-a928ae67ce63"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("c5c5d973-c7ce-4903-ae34-760e5704bffe"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("c726f977-e3c6-42a6-9fe1-55b74221e5cc"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("d00938b5-c95e-41ed-b819-bd748fe96c74"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("dc0b8b15-0f2f-4e42-973e-1edf95c0325f"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("edd3d340-2c94-4224-afd4-a57ea31901ac"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d69098c-0694-4fcc-ae1f-352e6a8ceb47"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("303667df-67ec-4234-aa96-af33c9140f0b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("812a9f16-268a-4087-997a-478dcdaabda6"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c40385c1-4365-4bba-ac67-2125e99aa9d3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb72317a-733f-41ec-9760-9b7e535ea7c9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3621cc3-deb1-478c-b068-116a4fa2f0ac"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"));

            migrationBuilder.RenameColumn(
                name: "FoodSubCategoryId",
                table: "Products",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_FoodSubCategoryId",
                table: "Products",
                newName: "IX_Products_SubCategoryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<double>(
                name: "Proteins",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<double>(
                name: "Fats",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<double>(
                name: "Carbohydrates",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5fb7ffd1-2795-4e37-be01-89ab5173b789"), "Fish" },
                    { new Guid("6080ac5c-29b3-404b-8f21-6ecaa9828ca5"), "Wheat" },
                    { new Guid("65404861-db2c-43cc-8001-4be14a2aa46f"), "Gluten" },
                    { new Guid("73ff93ea-55bd-4c55-8711-f8806686286b"), "Eggs" },
                    { new Guid("a8ff2732-c9e3-4f2d-8c9e-880370538a41"), "Shellfish" },
                    { new Guid("c9259576-0ab7-467f-be68-5436e5301e0b"), "Dairy" },
                    { new Guid("ca1311f2-2e82-417f-9ca2-ef305c3fb529"), "Tree Nuts" },
                    { new Guid("d3dd8f8b-a096-4e2a-b89d-f356e2319500"), "Soy" },
                    { new Guid("e6b9fbf8-195a-41d9-a11d-ced3f1a75f12"), "Sesame" },
                    { new Guid("f40b0b39-f708-4ae2-ace5-bb3be36b0fd8"), "Peanuts" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Meats" },
                    { new Guid("171854e3-6862-4dda-892e-f72bed876606"), "Herbs and Spices" },
                    { new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"), "Grains and Legumes" },
                    { new Guid("513862b9-95a3-4001-a378-b38572a29fde"), "Nuts and Seeds" },
                    { new Guid("6ca09620-d412-44be-ba02-17134db28a98"), "Dairy" },
                    { new Guid("700b0bbd-f843-4d0e-96c8-39edf19e1fa1"), "Baking Ingredients" },
                    { new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Fruits" },
                    { new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Vegetables" },
                    { new Guid("badeac32-9693-444f-9d72-52dc2929dccb"), "Oils and Fats" }
                });

            migrationBuilder.InsertData(
                table: "KitchenEquipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("49bcd407-62f6-4e8f-b00e-84d47cfdc33e"), "Toaster" },
                    { new Guid("4efc2b40-013b-4ac6-aed9-a976a2888b31"), "Mixer" },
                    { new Guid("5f48d79c-08e1-434e-8cfb-160b4954bf4a"), "Oven" },
                    { new Guid("bcd234bb-e846-4935-85cf-f30cc296daa9"), "Rice Cooker" },
                    { new Guid("d4dbb194-6188-4ac3-8098-946fca616af1"), "Air Fryer" },
                    { new Guid("d5e53f81-1d34-4314-bd01-668cb2c9ba32"), "Microwave" },
                    { new Guid("dacfa5ba-1abf-4107-a1b5-531b0fb86a95"), "Food Processor" },
                    { new Guid("e37b52b4-0df7-47ce-8eb8-cf111897cb9b"), "Blender" },
                    { new Guid("ea2f0364-5631-4c59-9f35-dc46a2a91058"), "Grill" },
                    { new Guid("efc8788b-0dde-40a4-a7a2-3c43d56cf3ef"), "Pressure Cooker" },
                    { new Guid("f0f62b17-5a3b-407a-9d1b-812adcb30a1b"), "Stove" },
                    { new Guid("f8eb9aea-e8b5-4737-b1ff-5914738abf1c"), "Slow Cooker" }
                });

            migrationBuilder.InsertData(
                table: "FoodSubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("04b663f0-fe68-46a5-8099-b7d89efbdb98"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Pome Fruits" },
                    { new Guid("0fe90c47-53ab-4893-9832-53382454283d"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Leafy Greens" },
                    { new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3"), new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Shellfish" },
                    { new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5"), new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Poultry" },
                    { new Guid("317cabed-f827-4117-88ab-579730269b54"), new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Fish" },
                    { new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8"), new Guid("171854e3-6862-4dda-892e-f72bed876606"), "Herbs" },
                    { new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc"), new Guid("6ca09620-d412-44be-ba02-17134db28a98"), "Cheese" },
                    { new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Squash Vegetables" },
                    { new Guid("41702ab8-15c4-49b3-9201-387f1e143111"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Allium Vegetables" },
                    { new Guid("489fc833-6d06-4277-a241-0e9a70926123"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Tropical Fruits" },
                    { new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Citrus Fruits" },
                    { new Guid("4f55fb5c-7117-4911-b481-48a75141c85e"), new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"), "Rice" },
                    { new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd"), new Guid("6ca09620-d412-44be-ba02-17134db28a98"), "Other Dairy" },
                    { new Guid("66508192-19fd-47a6-b910-c31fc6d0973f"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Nightshades" },
                    { new Guid("66bb930f-d411-4b60-a024-7d1ccaa1314a"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Melons" },
                    { new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c"), new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"), "Pasta" },
                    { new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f"), new Guid("badeac32-9693-444f-9d72-52dc2929dccb"), "Oils" },
                    { new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Stone Fruits" },
                    { new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28"), new Guid("171854e3-6862-4dda-892e-f72bed876606"), "Spices" },
                    { new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d"), new Guid("513862b9-95a3-4001-a378-b38572a29fde"), "Seeds" },
                    { new Guid("9d7fff01-9e87-436d-9761-bfcc9cc4ad5a"), new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Beef" },
                    { new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7"), new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"), "Pork" },
                    { new Guid("adb0c96f-7779-44ff-8160-556d7c63be61"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Cruciferous Vegetables" },
                    { new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de"), new Guid("700b0bbd-f843-4d0e-96c8-39edf19e1fa1"), "Sugars" },
                    { new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Berries" },
                    { new Guid("dbad3ebe-f187-44ab-b5e9-58bbb9ad2630"), new Guid("88414907-d38c-40e6-96f3-b82fed911250"), "Dried Fruits" },
                    { new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8"), new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"), "Root Vegetables" },
                    { new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b"), new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"), "Legumes" },
                    { new Guid("f8ccc5ab-4e8e-4be9-9978-747aa19968eb"), new Guid("6ca09620-d412-44be-ba02-17134db28a98"), "Milk" },
                    { new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37"), new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"), "Other Grains" },
                    { new Guid("fb7a6e78-1351-4992-a732-1b4f8510dcb9"), new Guid("700b0bbd-f843-4d0e-96c8-39edf19e1fa1"), "Baking Ingredients" },
                    { new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b"), new Guid("513862b9-95a3-4001-a378-b38572a29fde"), "Nuts" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "Caption", "Carbohydrates", "CreatedDate", "DeletedDate", "Fats", "IsDeleted", "ModifiedDate", "Proteins", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("00979c3f-37d0-44d2-bd11-bfa3acd8ed44"), null, "Black Pepper", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("00f02108-ed3c-405c-b40c-81794fa386dc"), null, "Pears", null, null, null, null, false, null, null, new Guid("04b663f0-fe68-46a5-8099-b7d89efbdb98") },
                    { new Guid("04040a01-febf-46d9-b75a-25f865265261"), null, "Buckwheat", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("0642bc98-2980-4046-b8d8-6c9acbe43c74"), null, "Arborio Rice", null, null, null, null, false, null, null, new Guid("4f55fb5c-7117-4911-b481-48a75141c85e") },
                    { new Guid("07625ebb-3473-4e27-9239-a249f1597945"), null, "Pork Loins", null, null, null, null, false, null, null, new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7") },
                    { new Guid("07627bd4-c8b3-4424-b86a-ed9aa3b8b705"), null, "Limes", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("0a63777c-0fce-4b45-bae8-ed78743ac91c"), null, "Unsalted Butter", null, null, null, null, false, null, null, new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd") },
                    { new Guid("0b6966e5-89c8-44a6-82e9-bd5a965a8357"), null, "Paprika", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("0ecade65-8777-43b9-a02e-be5ea9b9b971"), null, "Radishes", null, null, null, null, false, null, null, new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8") },
                    { new Guid("0f62142f-a12c-45fc-af05-0a7b1f8f0e57"), null, "Grape Tomatoes", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("1201790a-adab-4c42-9b36-c0670ed3f380"), null, "Macaroni", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("12ce6a22-aaea-4195-8fc9-fbe191942458"), null, "Tangerines", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("13c9dbf6-82b1-472b-a91b-4f22c9927a19"), null, "Chicken Wings", null, null, null, null, false, null, null, new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5") },
                    { new Guid("1646be14-9192-4d6e-a151-5d11e48a6388"), null, "Brussels Sprouts", null, null, null, null, false, null, null, new Guid("adb0c96f-7779-44ff-8160-556d7c63be61") },
                    { new Guid("180389f0-de08-4cc4-a048-2475b712266e"), null, "Heavy Cream", null, null, null, null, false, null, null, new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd") },
                    { new Guid("196faa87-b84a-4998-b7c7-693534f65f19"), null, "Chickpeas", null, null, null, null, false, null, null, new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b") },
                    { new Guid("198bfd3c-43c9-4727-bbe0-45949844a77c"), null, "Kale", null, null, null, null, false, null, null, new Guid("0fe90c47-53ab-4893-9832-53382454283d") },
                    { new Guid("1b3e0011-16aa-4504-a64e-10e3d3c1572b"), null, "Cabbage", null, null, null, null, false, null, null, new Guid("adb0c96f-7779-44ff-8160-556d7c63be61") },
                    { new Guid("1ce1be95-65d8-485f-adef-059f2aa90f72"), null, "Guavas", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("1d8f452f-1f4b-434a-9053-363b6896df8f"), null, "Vegetable Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("20a4aa50-974f-4cbc-82d0-5e935120e6f4"), null, "Carrots", null, null, null, null, false, null, null, new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8") },
                    { new Guid("262c454d-18f4-4ac0-9bc5-8d1b4a148d12"), null, "Granulated Sugar", null, null, null, null, false, null, null, new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de") },
                    { new Guid("26ae5673-a6aa-4df1-b2c2-b5debb429cf9"), null, "Cumin", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("2869c4bf-8f9d-409d-bb1a-0e957d059674"), null, "Tomatoes", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("28c58156-3cbf-4d3e-b3ee-ef5914351203"), null, "Goat Cheese", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("29719ece-6a43-4979-8815-a5fd9be80126"), null, "Chia Seeds", null, null, null, null, false, null, null, new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d") },
                    { new Guid("2aab4691-567e-4c59-bd19-07c4743db685"), null, "Beets", null, null, null, null, false, null, null, new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8") },
                    { new Guid("2ad061f7-1ca2-4ced-913d-e0fb5c5adf69"), null, "Cottage Cheese", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("2c3775d4-d60c-4532-8f04-1564aeab615c"), null, "Jasmine Rice", null, null, null, null, false, null, null, new Guid("4f55fb5c-7117-4911-b481-48a75141c85e") },
                    { new Guid("2fe1e3b7-315e-4569-9e78-559dd62c208c"), null, "Crab", null, null, null, null, false, null, null, new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3") },
                    { new Guid("300de9fa-d63e-495b-84b0-1c88a99fae4b"), null, "Cauliflower", null, null, null, null, false, null, null, new Guid("adb0c96f-7779-44ff-8160-556d7c63be61") },
                    { new Guid("318c2189-76b7-4e7c-b2da-d8c670c1f78e"), null, "Quinoa", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("347eabf5-3a6c-4d41-8de3-e3d4ee20067e"), null, "Shrimp", null, null, null, null, false, null, null, new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3") },
                    { new Guid("34f3492c-60e3-4539-bc78-3701a58ef47d"), null, "Almonds", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("35077c22-72fe-4f9f-bcda-97b078fad89d"), null, "Turnips", null, null, null, null, false, null, null, new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8") },
                    { new Guid("35b471fd-0a2b-4244-8ad7-ea90b49513d5"), null, "Watermelons", null, null, null, null, false, null, null, new Guid("66bb930f-d411-4b60-a024-7d1ccaa1314a") },
                    { new Guid("3686fa0d-f914-405e-9fe7-103950b0e786"), null, "Blueberries", null, null, null, null, false, null, null, new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0") },
                    { new Guid("3b3af4ce-8cfb-402c-8473-c4249f07fcf9"), null, "Cantaloupes", null, null, null, null, false, null, null, new Guid("66bb930f-d411-4b60-a024-7d1ccaa1314a") },
                    { new Guid("3bce823b-517d-48f8-8859-475ffbe5c187"), null, "Chicken Thighs", null, null, null, null, false, null, null, new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5") },
                    { new Guid("3dfe13b1-dea1-412a-8f67-1f4c4066d2d4"), null, "Ham", null, null, null, null, false, null, null, new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7") },
                    { new Guid("3eb107b3-915a-4302-b07a-b3f264e6d98d"), null, "White Rice", null, null, null, null, false, null, null, new Guid("4f55fb5c-7117-4911-b481-48a75141c85e") },
                    { new Guid("3fb9450c-5941-446b-9609-cf6cb574955a"), null, "Oregano", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("45ca4109-1f41-48fb-ad6e-a7c70ec21060"), null, "Salt", null, null, null, null, false, null, null, new Guid("fb7a6e78-1351-4992-a732-1b4f8510dcb9") },
                    { new Guid("45ff41f3-c81a-4362-98f5-b6f062fda958"), null, "Ricotta", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("46b6dcd7-7e68-4fd5-8c9d-b6c083a319d6"), null, "Peaches", null, null, null, null, false, null, null, new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232") },
                    { new Guid("4787a327-dd76-489c-81ac-c0bdb49c2db7"), null, "Black Beans", null, null, null, null, false, null, null, new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b") },
                    { new Guid("4a3099c9-de6b-4bb4-92f2-9e9da7312875"), null, "Peanuts", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("4a4b0def-d116-4a60-a502-e24153595369"), null, "Coconut Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("4b44eb65-626a-45c3-ba9c-b4d9125cacc3"), null, "Chili Powder", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("4b982f0e-e8d2-45a0-96c8-0c3c6ff32c5b"), null, "Rice Noodles", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("4ef91f6c-9814-4724-a218-2b9b2579e261"), null, "Broccoli", null, null, null, null, false, null, null, new Guid("adb0c96f-7779-44ff-8160-556d7c63be61") },
                    { new Guid("50370d9e-0cf8-47e6-b362-2501abd21ecb"), null, "Penne", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("51bc7ce0-2d13-453f-95f8-c1ab94863e24"), null, "Lemons", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("52d9b842-df1d-4e42-b4b1-aa177d39539e"), null, "Kidney Beans", null, null, null, null, false, null, null, new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b") },
                    { new Guid("536ee163-d07c-400f-80ac-ccc3d21e77da"), null, "Pork Chops", null, null, null, null, false, null, null, new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7") },
                    { new Guid("5747ffdd-5df1-49cc-ad27-b0717891410b"), null, "Cinnamon", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("58517d3e-9dab-4e2d-ac1a-fa308c8830ec"), null, "Polenta", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("589a28df-6cd1-4dae-b4b2-4d6bb9a548a6"), null, "Swiss", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("59336075-7dc7-4a95-937f-2e3bd18090e4"), null, "Parsnips", null, null, null, null, false, null, null, new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8") },
                    { new Guid("5a672907-c342-436e-8502-3e0d97031ae6"), null, "Clementines", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("5a968207-b687-40d7-8102-310d4d8a3cb8"), null, "Millet", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("5c209517-d906-485d-9da9-21d4a2db5bfc"), null, "Coriander", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("5d7ac8fd-919e-415f-91b1-ab35b5f9e755"), null, "Strawberries", null, null, null, null, false, null, null, new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0") },
                    { new Guid("5e024ce1-230f-48df-9b0b-acf5f666e548"), null, "Bell Peppers", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("5f4ea4bb-2cb6-441b-97f1-39e36c7cffa7"), null, "Brie", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("5fc2812e-e856-402a-905a-96a4fb4b81be"), null, "Greek Yogurt", null, null, null, null, false, null, null, new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd") },
                    { new Guid("60b40aa6-fa2a-46dc-ab16-c6db47e6fda8"), null, "Roasts", null, null, null, null, false, null, null, new Guid("9d7fff01-9e87-436d-9761-bfcc9cc4ad5a") },
                    { new Guid("6136f988-679f-42a6-9304-4e4e1a0e9315"), null, "Lasagna Sheets", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("61714b28-2e35-407a-babb-37b7410f8862"), null, "Mozzarella", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("62119bdf-fd55-469b-89db-6d0d57a22836"), null, "Blackberries", null, null, null, null, false, null, null, new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0") },
                    { new Guid("629505a3-e234-4249-8ab7-57d40b973501"), null, "Scallops", null, null, null, null, false, null, null, new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3") },
                    { new Guid("62de3b4c-076b-4ce7-abc1-9cbdb332c04e"), null, "Maple Syrup", null, null, null, null, false, null, null, new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de") },
                    { new Guid("6318144e-27e9-4761-97d5-fa36c5b71e21"), null, "Swiss Chard", null, null, null, null, false, null, null, new Guid("0fe90c47-53ab-4893-9832-53382454283d") },
                    { new Guid("649ff6d8-735a-4284-8572-e2214c4fd233"), null, "Tuna", null, null, null, null, false, null, null, new Guid("317cabed-f827-4117-88ab-579730269b54") },
                    { new Guid("677f02db-e080-47ae-a493-cbb31eef7998"), null, "Bok Choy", null, null, null, null, false, null, null, new Guid("adb0c96f-7779-44ff-8160-556d7c63be61") },
                    { new Guid("6786750d-3d25-4450-a32a-c39f32d85689"), null, "Raisins", null, null, null, null, false, null, null, new Guid("dbad3ebe-f187-44ab-b5e9-58bbb9ad2630") },
                    { new Guid("680a2262-728b-4dfd-8ff6-5371a98b99df"), null, "Dill", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("6862340a-71b7-492f-8a72-dd8059376fc9"), null, "Brown Sugar", null, null, null, null, false, null, null, new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de") },
                    { new Guid("6b335cc4-7efa-4a9f-8dfc-6b5145e085b1"), null, "Serrano Peppers", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("6ca18038-d433-45e3-8047-c6312fbeb8c0"), null, "Flaxseeds", null, null, null, null, false, null, null, new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d") },
                    { new Guid("6ddf6949-e764-4a11-b47c-a5041e60c40b"), null, "Cheddar", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("6ec66918-dcf6-4492-a145-98f785f73be0"), null, "Garlic", null, null, null, null, false, null, null, new Guid("41702ab8-15c4-49b3-9201-387f1e143111") },
                    { new Guid("709ef077-306e-4ad1-8186-2b142db75fa9"), null, "Apricots", null, null, null, null, false, null, null, new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232") },
                    { new Guid("70d8eb5d-3775-41d3-ab43-59e2fd15333a"), null, "Papayas", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("72bcc391-6646-4931-a838-7641513db122"), null, "Cod", null, null, null, null, false, null, null, new Guid("317cabed-f827-4117-88ab-579730269b54") },
                    { new Guid("7357a6db-e153-4e7b-9a8c-ccd8c3356d7a"), null, "Chili Peppers", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("73917240-0786-49e3-be6b-b5c16de4be7e"), null, "Dried Apricots", null, null, null, null, false, null, null, new Guid("dbad3ebe-f187-44ab-b5e9-58bbb9ad2630") },
                    { new Guid("773cfcff-2f46-446d-8f8a-38b2a76aca61"), null, "Egg Noodles", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("7765bca7-cb6e-4588-bcbb-811d7edcecfc"), null, "Thyme", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("778a0e4a-fdd9-4177-bb3d-dc64c22abf4a"), null, "Turmeric", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("78dd3bad-752f-4f27-ae8e-d3b8472a1fd5"), null, "Avocado Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("7b3846da-8afc-41a9-b1c6-6f4869da8401"), null, "Cranberries", null, null, null, null, false, null, null, new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0") },
                    { new Guid("7bfaf7bc-b6eb-42e3-b894-cdca1261d57b"), null, "Whole Milk", null, null, null, null, false, null, null, new Guid("f8ccc5ab-4e8e-4be9-9978-747aa19968eb") },
                    { new Guid("7e60eea9-f4a4-4a2c-972b-3d05a1872906"), null, "Bacon", null, null, null, null, false, null, null, new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7") },
                    { new Guid("7e985f3f-43bc-4ac7-af11-50ecc74a3e7d"), null, "Ginger", null, null, null, null, false, null, null, new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28") },
                    { new Guid("7f7abaf0-f21b-4958-8999-d659d8681d70"), null, "Leeks", null, null, null, null, false, null, null, new Guid("41702ab8-15c4-49b3-9201-387f1e143111") },
                    { new Guid("7fcc9b55-c79c-4bc3-8917-c2a13e1fae9b"), null, "Chicken Breasts", null, null, null, null, false, null, null, new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5") },
                    { new Guid("81ed9326-aa76-4d42-a32a-31e65c63f1fe"), null, "Pistachios", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("84a3bbb1-6583-4226-9ddf-64e7a389ffd5"), null, "Canola Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("8679a1ca-7fc6-4103-9e8b-1a9c66454c5a"), null, "Spaghetti", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("86f6a723-d3f7-4fcf-83d0-18dae9c37b90"), null, "Quinces", null, null, null, null, false, null, null, new Guid("04b663f0-fe68-46a5-8099-b7d89efbdb98") },
                    { new Guid("872d12f4-d8f7-4200-a5f8-be951741dc4d"), null, "Mint", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("89e1cc83-230c-42b2-9227-073b2b66bf91"), null, "Basmati Rice", null, null, null, null, false, null, null, new Guid("4f55fb5c-7117-4911-b481-48a75141c85e") },
                    { new Guid("8b8d9a34-8669-4842-8956-08eb336a7687"), null, "Sunflower Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("8baa1731-add6-4fd0-8c41-04a7dd3dd5fe"), null, "Acorn Squash", null, null, null, null, false, null, null, new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd") },
                    { new Guid("8bcf12ae-8f9a-4306-ba5e-82a59a5aecef"), null, "Shallots", null, null, null, null, false, null, null, new Guid("41702ab8-15c4-49b3-9201-387f1e143111") },
                    { new Guid("8c40056e-45b1-4b56-a62c-1003ba243db5"), null, "Ground Pork", null, null, null, null, false, null, null, new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7") },
                    { new Guid("8d67170b-538b-4442-9848-a68b3113039f"), null, "Cornmeal", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("8e19f6a9-74c5-4aa5-a1c6-3c307215d342"), null, "Steaks", null, null, null, null, false, null, null, new Guid("9d7fff01-9e87-436d-9761-bfcc9cc4ad5a") },
                    { new Guid("8e278c30-c879-43ec-b285-0ccd68fc46d9"), null, "Plums", null, null, null, null, false, null, null, new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232") },
                    { new Guid("8e5d5497-7e5b-4fec-97ee-5f87ace3723d"), null, "Soba Noodles", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("9666d9df-9924-4a6c-8edc-a51a771c54b8"), null, "Salted Butter", null, null, null, null, false, null, null, new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd") },
                    { new Guid("99c4c2d5-27aa-4081-ab23-69bef8660a2b"), null, "Lettuce", null, null, null, null, false, null, null, new Guid("0fe90c47-53ab-4893-9832-53382454283d") },
                    { new Guid("9c158aa8-57f6-4338-ac7f-d2371cc2c41f"), null, "Yellow Squash", null, null, null, null, false, null, null, new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd") },
                    { new Guid("9d760ed4-c37c-4c6c-8a94-f1c9dba21bce"), null, "Pinto Beans", null, null, null, null, false, null, null, new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b") },
                    { new Guid("9e1b127a-dd74-4122-8cad-c116d736669f"), null, "Baking Powder", null, null, null, null, false, null, null, new Guid("fb7a6e78-1351-4992-a732-1b4f8510dcb9") },
                    { new Guid("9ff1df1b-3953-4671-80db-a66883866aa4"), null, "Habaneros", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("a024793f-c793-4e0c-9e82-849bc82c70fe"), null, "Nectarines", null, null, null, null, false, null, null, new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232") },
                    { new Guid("a1e3b7a4-a6b0-41e2-b06f-4883d02cc8bb"), null, "Raspberries", null, null, null, null, false, null, null, new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0") },
                    { new Guid("a31b5a2b-3ba8-490c-8b51-0e114968a2cf"), null, "Sesame Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("a4903769-a86f-4d04-966d-2ca3c7ab0a7d"), null, "Salmon", null, null, null, null, false, null, null, new Guid("317cabed-f827-4117-88ab-579730269b54") },
                    { new Guid("a6466296-90d3-4247-8722-a276ca983a6d"), null, "Low-Fat Milk", null, null, null, null, false, null, null, new Guid("f8ccc5ab-4e8e-4be9-9978-747aa19968eb") },
                    { new Guid("a7008f60-5e24-4b35-b7b3-f18c68c9ecf9"), null, "Jalapenos", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("a97100ab-4039-4ed7-ac79-dc9e7ee26bc0"), null, "Cherries", null, null, null, null, false, null, null, new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232") },
                    { new Guid("ab8af64e-364f-48fb-bd5a-9a5b316b2f3a"), null, "Cashews", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("ab8b1aaf-f5c8-464c-ba94-5be1ebc63556"), null, "Dates", null, null, null, null, false, null, null, new Guid("dbad3ebe-f187-44ab-b5e9-58bbb9ad2630") },
                    { new Guid("b0c46b17-84cf-4c1c-a0a6-deaff255b53d"), null, "Skim Milk", null, null, null, null, false, null, null, new Guid("f8ccc5ab-4e8e-4be9-9978-747aa19968eb") },
                    { new Guid("b4563c76-17d1-43b3-83b3-84d978d9fed0"), null, "Sunflower Seeds", null, null, null, null, false, null, null, new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d") },
                    { new Guid("b59a056a-43a3-4bcb-81d9-a23b2120a077"), null, "Sour Cream", null, null, null, null, false, null, null, new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd") },
                    { new Guid("b724f9f3-a213-4d03-b41f-c29827cc5c91"), null, "Butternut Squash", null, null, null, null, false, null, null, new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd") },
                    { new Guid("ba1ef009-7c17-40d5-8baa-48ab47fcd8c2"), null, "Haddock", null, null, null, null, false, null, null, new Guid("317cabed-f827-4117-88ab-579730269b54") },
                    { new Guid("ba8d6087-4540-4b2f-ba22-ae94f03f04c3"), null, "Lentils", null, null, null, null, false, null, null, new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b") },
                    { new Guid("bad18ba4-2959-4e84-9279-e51eede64f67"), null, "Honey", null, null, null, null, false, null, null, new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de") },
                    { new Guid("bc7b6069-a86c-4602-8c69-8279dda3d449"), null, "Basil", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("bdd7addd-ec15-4589-b19b-c6cf3e460bc3"), null, "Bananas", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("be386ce9-642f-4eae-9216-9929dd40d494"), null, "Oranges", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("bed632cc-9a10-48e7-8e18-aada96787094"), null, "Grapefruits", null, null, null, null, false, null, null, new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2") },
                    { new Guid("c16838cc-8cf0-4669-8b8c-36113a7bb1bb"), null, "Passion Fruit", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("c205f15e-4949-4f40-b52f-76dd91f5030d"), null, "Pumpkin", null, null, null, null, false, null, null, new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd") },
                    { new Guid("c49233f6-8e52-47e6-b6aa-0154e6761197"), null, "Onions", null, null, null, null, false, null, null, new Guid("41702ab8-15c4-49b3-9201-387f1e143111") },
                    { new Guid("cc96ca2e-4eba-4a23-8339-5c3738a757ac"), null, "Cilantro", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("cd863d6a-7145-4f3c-9fcf-2e0f0087c5d5"), null, "Walnuts", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("d222558d-489e-4716-b33d-f5b5b2b9f564"), null, "Ground Beef", null, null, null, null, false, null, null, new Guid("9d7fff01-9e87-436d-9761-bfcc9cc4ad5a") },
                    { new Guid("d33e7046-a6f2-4bb7-83b0-cc9c38effade"), null, "Pumpkin Seeds", null, null, null, null, false, null, null, new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d") },
                    { new Guid("d3aab5f9-4e12-44ea-8abd-1102d0157a6d"), null, "Zucchini", null, null, null, null, false, null, null, new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd") },
                    { new Guid("d3ae0655-5a7d-4d74-b2d1-1a191d8dbd92"), null, "Feta", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("d404afd0-b8e2-48d0-bdcb-92729277ee68"), null, "Green Onions", null, null, null, null, false, null, null, new Guid("41702ab8-15c4-49b3-9201-387f1e143111") },
                    { new Guid("d48adc0d-f709-405e-a907-ddc7ad9ff580"), null, "Apples", null, null, null, null, false, null, null, new Guid("04b663f0-fe68-46a5-8099-b7d89efbdb98") },
                    { new Guid("d922d149-7f7e-4d33-a2d3-c5783e179db8"), null, "Ground Chicken", null, null, null, null, false, null, null, new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5") },
                    { new Guid("db977dad-11e2-4ca6-ae96-7ca393347642"), null, "Rosemary", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("de34a5eb-212a-4400-a2c7-d09b9d7d4529"), null, "Arugula", null, null, null, null, false, null, null, new Guid("0fe90c47-53ab-4893-9832-53382454283d") },
                    { new Guid("de5903e8-58f8-4fd4-9892-ed3e48194c4d"), null, "Pineapples", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("e01978cc-e0aa-4bba-9d3b-cc5f8816fc40"), null, "Olive Oil", null, null, null, null, false, null, null, new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f") },
                    { new Guid("e2faa565-fd81-4c65-b1f2-ec794e05ea3a"), null, "Lobster", null, null, null, null, false, null, null, new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3") },
                    { new Guid("e3183717-5cb5-4497-b009-8184fe01983b"), null, "Fusilli", null, null, null, null, false, null, null, new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c") },
                    { new Guid("e365939a-c217-4201-b29b-b1627aac40c4"), null, "Parsley", null, null, null, null, false, null, null, new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8") },
                    { new Guid("e3e222ed-cbeb-4be0-97f3-1bd667dfb9ac"), null, "Rye", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("e53d27bd-1072-4657-8c17-66fb93ff5a1d"), null, "Honeydews", null, null, null, null, false, null, null, new Guid("66bb930f-d411-4b60-a024-7d1ccaa1314a") },
                    { new Guid("e66b77e6-db6f-4dd6-8e7d-e4b74100859a"), null, "Cherry Tomatoes", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("e983c2f0-5672-4e23-97d8-394bf3882f3e"), null, "Cream Cheese", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("f02dc182-155c-4a65-9468-ed3c707bcb24"), null, "Pecans", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("f1667388-791b-43cf-8a94-22ee61eccba9"), null, "Brown Rice", null, null, null, null, false, null, null, new Guid("4f55fb5c-7117-4911-b481-48a75141c85e") },
                    { new Guid("f1eeaf08-8168-4284-9369-380ab4576233"), null, "Parmesan", null, null, null, null, false, null, null, new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc") },
                    { new Guid("f40c6732-7c7c-4bd1-84e1-9ff41f71ff22"), null, "Macadamia Nuts", null, null, null, null, false, null, null, new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b") },
                    { new Guid("f4f4d318-b6ba-425d-99a9-3b4d456cee33"), null, "Eggplants", null, null, null, null, false, null, null, new Guid("66508192-19fd-47a6-b910-c31fc6d0973f") },
                    { new Guid("f74eb9f5-351e-4126-9d8e-2251d8e4b090"), null, "Spinach", null, null, null, null, false, null, null, new Guid("0fe90c47-53ab-4893-9832-53382454283d") },
                    { new Guid("fa9ceb65-99d7-4f50-897b-495aee237b0f"), null, "Barley", null, null, null, null, false, null, null, new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37") },
                    { new Guid("fad5c8fe-afe8-4793-8393-3b4700675166"), null, "Mangoes", null, null, null, null, false, null, null, new Guid("489fc833-6d06-4277-a241-0e9a70926123") },
                    { new Guid("fec43808-4d01-4693-a15c-122ab4d65de1"), null, "Baking Soda", null, null, null, null, false, null, null, new Guid("fb7a6e78-1351-4992-a732-1b4f8510dcb9") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FoodSubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "FoodSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_FoodSubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("5fb7ffd1-2795-4e37-be01-89ab5173b789"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6080ac5c-29b3-404b-8f21-6ecaa9828ca5"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("65404861-db2c-43cc-8001-4be14a2aa46f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("73ff93ea-55bd-4c55-8711-f8806686286b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("a8ff2732-c9e3-4f2d-8c9e-880370538a41"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c9259576-0ab7-467f-be68-5436e5301e0b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("ca1311f2-2e82-417f-9ca2-ef305c3fb529"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("d3dd8f8b-a096-4e2a-b89d-f356e2319500"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e6b9fbf8-195a-41d9-a11d-ced3f1a75f12"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("f40b0b39-f708-4ae2-ace5-bb3be36b0fd8"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("49bcd407-62f6-4e8f-b00e-84d47cfdc33e"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("4efc2b40-013b-4ac6-aed9-a976a2888b31"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("5f48d79c-08e1-434e-8cfb-160b4954bf4a"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("bcd234bb-e846-4935-85cf-f30cc296daa9"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("d4dbb194-6188-4ac3-8098-946fca616af1"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("d5e53f81-1d34-4314-bd01-668cb2c9ba32"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("dacfa5ba-1abf-4107-a1b5-531b0fb86a95"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("e37b52b4-0df7-47ce-8eb8-cf111897cb9b"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("ea2f0364-5631-4c59-9f35-dc46a2a91058"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("efc8788b-0dde-40a4-a7a2-3c43d56cf3ef"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("f0f62b17-5a3b-407a-9d1b-812adcb30a1b"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("f8eb9aea-e8b5-4737-b1ff-5914738abf1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00979c3f-37d0-44d2-bd11-bfa3acd8ed44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00f02108-ed3c-405c-b40c-81794fa386dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04040a01-febf-46d9-b75a-25f865265261"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0642bc98-2980-4046-b8d8-6c9acbe43c74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07625ebb-3473-4e27-9239-a249f1597945"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07627bd4-c8b3-4424-b86a-ed9aa3b8b705"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a63777c-0fce-4b45-bae8-ed78743ac91c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b6966e5-89c8-44a6-82e9-bd5a965a8357"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ecade65-8777-43b9-a02e-be5ea9b9b971"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f62142f-a12c-45fc-af05-0a7b1f8f0e57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1201790a-adab-4c42-9b36-c0670ed3f380"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12ce6a22-aaea-4195-8fc9-fbe191942458"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13c9dbf6-82b1-472b-a91b-4f22c9927a19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1646be14-9192-4d6e-a151-5d11e48a6388"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("180389f0-de08-4cc4-a048-2475b712266e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("196faa87-b84a-4998-b7c7-693534f65f19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("198bfd3c-43c9-4727-bbe0-45949844a77c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b3e0011-16aa-4504-a64e-10e3d3c1572b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ce1be95-65d8-485f-adef-059f2aa90f72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d8f452f-1f4b-434a-9053-363b6896df8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20a4aa50-974f-4cbc-82d0-5e935120e6f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("262c454d-18f4-4ac0-9bc5-8d1b4a148d12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26ae5673-a6aa-4df1-b2c2-b5debb429cf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2869c4bf-8f9d-409d-bb1a-0e957d059674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28c58156-3cbf-4d3e-b3ee-ef5914351203"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29719ece-6a43-4979-8815-a5fd9be80126"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2aab4691-567e-4c59-bd19-07c4743db685"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ad061f7-1ca2-4ced-913d-e0fb5c5adf69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c3775d4-d60c-4532-8f04-1564aeab615c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fe1e3b7-315e-4569-9e78-559dd62c208c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("300de9fa-d63e-495b-84b0-1c88a99fae4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("318c2189-76b7-4e7c-b2da-d8c670c1f78e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("347eabf5-3a6c-4d41-8de3-e3d4ee20067e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34f3492c-60e3-4539-bc78-3701a58ef47d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35077c22-72fe-4f9f-bcda-97b078fad89d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35b471fd-0a2b-4244-8ad7-ea90b49513d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3686fa0d-f914-405e-9fe7-103950b0e786"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b3af4ce-8cfb-402c-8473-c4249f07fcf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bce823b-517d-48f8-8859-475ffbe5c187"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dfe13b1-dea1-412a-8f67-1f4c4066d2d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3eb107b3-915a-4302-b07a-b3f264e6d98d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fb9450c-5941-446b-9609-cf6cb574955a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45ca4109-1f41-48fb-ad6e-a7c70ec21060"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45ff41f3-c81a-4362-98f5-b6f062fda958"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46b6dcd7-7e68-4fd5-8c9d-b6c083a319d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4787a327-dd76-489c-81ac-c0bdb49c2db7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a3099c9-de6b-4bb4-92f2-9e9da7312875"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a4b0def-d116-4a60-a502-e24153595369"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b44eb65-626a-45c3-ba9c-b4d9125cacc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b982f0e-e8d2-45a0-96c8-0c3c6ff32c5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef91f6c-9814-4724-a218-2b9b2579e261"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50370d9e-0cf8-47e6-b362-2501abd21ecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51bc7ce0-2d13-453f-95f8-c1ab94863e24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52d9b842-df1d-4e42-b4b1-aa177d39539e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("536ee163-d07c-400f-80ac-ccc3d21e77da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5747ffdd-5df1-49cc-ad27-b0717891410b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58517d3e-9dab-4e2d-ac1a-fa308c8830ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("589a28df-6cd1-4dae-b4b2-4d6bb9a548a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59336075-7dc7-4a95-937f-2e3bd18090e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a672907-c342-436e-8502-3e0d97031ae6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a968207-b687-40d7-8102-310d4d8a3cb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c209517-d906-485d-9da9-21d4a2db5bfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d7ac8fd-919e-415f-91b1-ab35b5f9e755"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e024ce1-230f-48df-9b0b-acf5f666e548"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f4ea4bb-2cb6-441b-97f1-39e36c7cffa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fc2812e-e856-402a-905a-96a4fb4b81be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60b40aa6-fa2a-46dc-ab16-c6db47e6fda8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6136f988-679f-42a6-9304-4e4e1a0e9315"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61714b28-2e35-407a-babb-37b7410f8862"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62119bdf-fd55-469b-89db-6d0d57a22836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("629505a3-e234-4249-8ab7-57d40b973501"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62de3b4c-076b-4ce7-abc1-9cbdb332c04e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6318144e-27e9-4761-97d5-fa36c5b71e21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("649ff6d8-735a-4284-8572-e2214c4fd233"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("677f02db-e080-47ae-a493-cbb31eef7998"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6786750d-3d25-4450-a32a-c39f32d85689"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("680a2262-728b-4dfd-8ff6-5371a98b99df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6862340a-71b7-492f-8a72-dd8059376fc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b335cc4-7efa-4a9f-8dfc-6b5145e085b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ca18038-d433-45e3-8047-c6312fbeb8c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ddf6949-e764-4a11-b47c-a5041e60c40b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ec66918-dcf6-4492-a145-98f785f73be0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("709ef077-306e-4ad1-8186-2b142db75fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70d8eb5d-3775-41d3-ab43-59e2fd15333a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72bcc391-6646-4931-a838-7641513db122"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7357a6db-e153-4e7b-9a8c-ccd8c3356d7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73917240-0786-49e3-be6b-b5c16de4be7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("773cfcff-2f46-446d-8f8a-38b2a76aca61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7765bca7-cb6e-4588-bcbb-811d7edcecfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778a0e4a-fdd9-4177-bb3d-dc64c22abf4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78dd3bad-752f-4f27-ae8e-d3b8472a1fd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b3846da-8afc-41a9-b1c6-6f4869da8401"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bfaf7bc-b6eb-42e3-b894-cdca1261d57b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e60eea9-f4a4-4a2c-972b-3d05a1872906"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e985f3f-43bc-4ac7-af11-50ecc74a3e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f7abaf0-f21b-4958-8999-d659d8681d70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fcc9b55-c79c-4bc3-8917-c2a13e1fae9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81ed9326-aa76-4d42-a32a-31e65c63f1fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84a3bbb1-6583-4226-9ddf-64e7a389ffd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8679a1ca-7fc6-4103-9e8b-1a9c66454c5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86f6a723-d3f7-4fcf-83d0-18dae9c37b90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("872d12f4-d8f7-4200-a5f8-be951741dc4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89e1cc83-230c-42b2-9227-073b2b66bf91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b8d9a34-8669-4842-8956-08eb336a7687"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8baa1731-add6-4fd0-8c41-04a7dd3dd5fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bcf12ae-8f9a-4306-ba5e-82a59a5aecef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c40056e-45b1-4b56-a62c-1003ba243db5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d67170b-538b-4442-9848-a68b3113039f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e19f6a9-74c5-4aa5-a1c6-3c307215d342"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e278c30-c879-43ec-b285-0ccd68fc46d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e5d5497-7e5b-4fec-97ee-5f87ace3723d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9666d9df-9924-4a6c-8edc-a51a771c54b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99c4c2d5-27aa-4081-ab23-69bef8660a2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c158aa8-57f6-4338-ac7f-d2371cc2c41f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d760ed4-c37c-4c6c-8a94-f1c9dba21bce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e1b127a-dd74-4122-8cad-c116d736669f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ff1df1b-3953-4671-80db-a66883866aa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a024793f-c793-4e0c-9e82-849bc82c70fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1e3b7a4-a6b0-41e2-b06f-4883d02cc8bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a31b5a2b-3ba8-490c-8b51-0e114968a2cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4903769-a86f-4d04-966d-2ca3c7ab0a7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6466296-90d3-4247-8722-a276ca983a6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7008f60-5e24-4b35-b7b3-f18c68c9ecf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a97100ab-4039-4ed7-ac79-dc9e7ee26bc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab8af64e-364f-48fb-bd5a-9a5b316b2f3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab8b1aaf-f5c8-464c-ba94-5be1ebc63556"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0c46b17-84cf-4c1c-a0a6-deaff255b53d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4563c76-17d1-43b3-83b3-84d978d9fed0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b59a056a-43a3-4bcb-81d9-a23b2120a077"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b724f9f3-a213-4d03-b41f-c29827cc5c91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba1ef009-7c17-40d5-8baa-48ab47fcd8c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba8d6087-4540-4b2f-ba22-ae94f03f04c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bad18ba4-2959-4e84-9279-e51eede64f67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc7b6069-a86c-4602-8c69-8279dda3d449"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdd7addd-ec15-4589-b19b-c6cf3e460bc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be386ce9-642f-4eae-9216-9929dd40d494"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bed632cc-9a10-48e7-8e18-aada96787094"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c16838cc-8cf0-4669-8b8c-36113a7bb1bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c205f15e-4949-4f40-b52f-76dd91f5030d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c49233f6-8e52-47e6-b6aa-0154e6761197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc96ca2e-4eba-4a23-8339-5c3738a757ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd863d6a-7145-4f3c-9fcf-2e0f0087c5d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d222558d-489e-4716-b33d-f5b5b2b9f564"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d33e7046-a6f2-4bb7-83b0-cc9c38effade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3aab5f9-4e12-44ea-8abd-1102d0157a6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ae0655-5a7d-4d74-b2d1-1a191d8dbd92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d404afd0-b8e2-48d0-bdcb-92729277ee68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d48adc0d-f709-405e-a907-ddc7ad9ff580"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d922d149-7f7e-4d33-a2d3-c5783e179db8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db977dad-11e2-4ca6-ae96-7ca393347642"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de34a5eb-212a-4400-a2c7-d09b9d7d4529"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de5903e8-58f8-4fd4-9892-ed3e48194c4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e01978cc-e0aa-4bba-9d3b-cc5f8816fc40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2faa565-fd81-4c65-b1f2-ec794e05ea3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3183717-5cb5-4497-b009-8184fe01983b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e365939a-c217-4201-b29b-b1627aac40c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3e222ed-cbeb-4be0-97f3-1bd667dfb9ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e53d27bd-1072-4657-8c17-66fb93ff5a1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e66b77e6-db6f-4dd6-8e7d-e4b74100859a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e983c2f0-5672-4e23-97d8-394bf3882f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f02dc182-155c-4a65-9468-ed3c707bcb24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1667388-791b-43cf-8a94-22ee61eccba9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1eeaf08-8168-4284-9369-380ab4576233"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f40c6732-7c7c-4bd1-84e1-9ff41f71ff22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f4d318-b6ba-425d-99a9-3b4d456cee33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f74eb9f5-351e-4126-9d8e-2251d8e4b090"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa9ceb65-99d7-4f50-897b-495aee237b0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fad5c8fe-afe8-4793-8393-3b4700675166"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec43808-4d01-4693-a15c-122ab4d65de1"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("04b663f0-fe68-46a5-8099-b7d89efbdb98"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fe90c47-53ab-4893-9832-53382454283d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b26e890-6f81-4e22-9763-301ff482e6f3"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c9f7178-9f48-4383-a7d8-52b3c4a2eba5"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("317cabed-f827-4117-88ab-579730269b54"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("35c5e37f-17f5-4ff1-9ea9-6ae79b4bb2d8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d16103f-43cc-499b-b9eb-ece0a502fecc"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e2eed01-e879-4dee-beb4-e9338400a6fd"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("41702ab8-15c4-49b3-9201-387f1e143111"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("489fc833-6d06-4277-a241-0e9a70926123"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4dede805-7bf7-4055-8a8c-2917b2f859c2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f55fb5c-7117-4911-b481-48a75141c85e"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5bdf8914-ba06-4415-b018-09a41edf26fd"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("66508192-19fd-47a6-b910-c31fc6d0973f"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("66bb930f-d411-4b60-a024-7d1ccaa1314a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("692b49bf-17da-4d08-b8e6-a863d571cc5c"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ca003f3-9a93-4d0f-9e58-808b9426b94f"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("70330ebb-02af-4984-b42b-75a5ce2a4232"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7893cddc-a4f2-4ee2-bc52-84456a5b2f28"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8378c940-b7ee-41a0-b740-fc7dcb62729d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d7fff01-9e87-436d-9761-bfcc9cc4ad5a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac14dc1d-fa3c-4e9f-bdc8-62ad10b687c7"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("adb0c96f-7779-44ff-8160-556d7c63be61"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d133f302-ec57-4acb-845c-eb0daea1b6de"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6d9fe22-f9bc-4617-ba86-a09ac8c97af0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dbad3ebe-f187-44ab-b5e9-58bbb9ad2630"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e775aa73-985c-4198-ac6d-0c19f6e191e8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5d6dae7-80a7-45ec-8995-cbe47452a12b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8ccc5ab-4e8e-4be9-9978-747aa19968eb"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9c1d277-5dc6-46ae-87d6-b1b66e44bc37"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb7a6e78-1351-4992-a732-1b4f8510dcb9"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd2acf2c-7d94-47f6-ad84-db76e2726b0b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("01361a54-ee90-42a2-93cd-818806cdac5f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("171854e3-6862-4dda-892e-f72bed876606"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("36e9c5ce-690f-4587-8b59-cf1e42e027db"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("513862b9-95a3-4001-a378-b38572a29fde"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ca09620-d412-44be-ba02-17134db28a98"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("700b0bbd-f843-4d0e-96c8-39edf19e1fa1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("88414907-d38c-40e6-96f3-b82fed911250"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ed34f48-c691-4f89-948c-ecb2c030e007"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("badeac32-9693-444f-9d72-52dc2929dccb"));

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Products",
                newName: "FoodSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                newName: "IX_Products_FoodSubCategoryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Recipes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RecipeIngredients",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Proteins",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Fats",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Carbohydrates",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06a506c3-cb8c-41a2-8e84-915703a87747"), "Soy" },
                    { new Guid("3c9a5706-ba6d-42d0-9e92-c69401842620"), "Fish" },
                    { new Guid("6027a767-b04c-47f6-a79a-bc0ece0eb8a2"), "Dairy" },
                    { new Guid("6ae1e191-6b02-4b3d-b94c-749dcf86fd44"), "Wheat" },
                    { new Guid("6cabbc47-e9d4-413a-a5d6-4c29c223f996"), "Shellfish" },
                    { new Guid("7d999f26-3cc4-4065-bb66-be7594784687"), "Sesame" },
                    { new Guid("a2115d27-52ad-41a8-a4d3-dceb4f57083c"), "Tree Nuts" },
                    { new Guid("afaac70d-8581-49cb-86bb-f6861d8d00c9"), "Peanuts" },
                    { new Guid("c6a520c8-01d5-43a0-85b6-918fde1c2b82"), "Gluten" },
                    { new Guid("e61d54f6-6049-4a18-8bd4-4c190b657052"), "Eggs" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Meats" },
                    { new Guid("2d69098c-0694-4fcc-ae1f-352e6a8ceb47"), "Herbs and Spices" },
                    { new Guid("303667df-67ec-4234-aa96-af33c9140f0b"), "Grains and Legumes" },
                    { new Guid("812a9f16-268a-4087-997a-478dcdaabda6"), "Dairy" },
                    { new Guid("c40385c1-4365-4bba-ac67-2125e99aa9d3"), "Baking Ingredients" },
                    { new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Vegetables" },
                    { new Guid("cb72317a-733f-41ec-9760-9b7e535ea7c9"), "Nuts and Seeds" },
                    { new Guid("d3621cc3-deb1-478c-b068-116a4fa2f0ac"), "Oils and Fats" },
                    { new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Fruits" }
                });

            migrationBuilder.InsertData(
                table: "KitchenEquipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06f67933-7537-4e2f-a673-19af1a55655b"), "Stove" },
                    { new Guid("1b2dbf44-07cf-4377-aa56-8e4541841b1e"), "Mixer" },
                    { new Guid("1d069d73-0c1b-42ae-aa49-2cc0860248a3"), "Food Processor" },
                    { new Guid("2010bfc4-139a-499b-80ac-9e5bc2c4bf02"), "Pressure Cooker" },
                    { new Guid("206bef1e-950e-437b-b02b-ea86a6ae972a"), "Blender" },
                    { new Guid("730a74b1-67af-413f-b908-9e71e5a71058"), "Grill" },
                    { new Guid("a1c84707-db4b-46c4-9321-a928ae67ce63"), "Air Fryer" },
                    { new Guid("c5c5d973-c7ce-4903-ae34-760e5704bffe"), "Toaster" },
                    { new Guid("c726f977-e3c6-42a6-9fe1-55b74221e5cc"), "Oven" },
                    { new Guid("d00938b5-c95e-41ed-b819-bd748fe96c74"), "Slow Cooker" },
                    { new Guid("dc0b8b15-0f2f-4e42-973e-1edf95c0325f"), "Microwave" },
                    { new Guid("edd3d340-2c94-4224-afd4-a57ea31901ac"), "Rice Cooker" }
                });

            migrationBuilder.InsertData(
                table: "FoodSubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("0873c235-35a3-486a-9f22-26c218b9835b"), new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Fish" },
                    { new Guid("0acf5173-c234-4051-80d6-de00e90f42c2"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Berries" },
                    { new Guid("108d3aa5-9980-4a5d-bcf3-d14dedd1ae8a"), new Guid("303667df-67ec-4234-aa96-af33c9140f0b"), "Legumes" },
                    { new Guid("15a8d309-f540-4a55-813d-b71372948a88"), new Guid("812a9f16-268a-4087-997a-478dcdaabda6"), "Milk" },
                    { new Guid("27daeb22-1ba7-429b-b4f2-8ea8ed22c408"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Stone Fruits" },
                    { new Guid("2dc27ae3-3505-418f-9b2d-4152ac066086"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Squash Vegetables" },
                    { new Guid("2e15c75f-92c1-4d8e-a3b4-af37bdc0212c"), new Guid("c40385c1-4365-4bba-ac67-2125e99aa9d3"), "Baking Ingredients" },
                    { new Guid("30d103a6-9356-424b-a8f6-e862236a8fd0"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Tropical Fruits" },
                    { new Guid("38b07a82-b813-4d83-8abe-46642df44867"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Dried Fruits" },
                    { new Guid("3fb20cd4-3b7f-4651-ba5a-5cc15e4b72f7"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Pome Fruits" },
                    { new Guid("43599cd4-b3ca-49fd-9d49-88ed7af95a46"), new Guid("303667df-67ec-4234-aa96-af33c9140f0b"), "Pasta" },
                    { new Guid("45dc585d-65b0-4839-ae66-4f6fcf87749b"), new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Beef" },
                    { new Guid("49aa5cc5-01f2-4f38-b50b-d90e4059bf09"), new Guid("2d69098c-0694-4fcc-ae1f-352e6a8ceb47"), "Spices" },
                    { new Guid("4b8eb8eb-2496-49ce-b125-3ae8410fad34"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Citrus Fruits" },
                    { new Guid("519cf1ff-d892-41f7-b16f-4021a4e083b8"), new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Shellfish" },
                    { new Guid("5ae538fe-2a67-454d-95f8-ef6158f44b51"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Nightshades" },
                    { new Guid("7da73681-82fe-4ca4-b7fb-096563b15bbd"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Allium Vegetables" },
                    { new Guid("802ff61b-d76e-4b2b-9dc4-7e2059e3c530"), new Guid("812a9f16-268a-4087-997a-478dcdaabda6"), "Other Dairy" },
                    { new Guid("81da61f4-0654-4d95-af14-abbd14d20951"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Cruciferous Vegetables" },
                    { new Guid("85abf512-c7f8-4f75-9307-f8042f642002"), new Guid("cb72317a-733f-41ec-9760-9b7e535ea7c9"), "Nuts" },
                    { new Guid("85ec0e49-d7cb-4a8d-a2f7-0bbd32555aca"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Root Vegetables" },
                    { new Guid("ac35aa10-44da-4d0b-9068-68b4a640bfbe"), new Guid("2d69098c-0694-4fcc-ae1f-352e6a8ceb47"), "Herbs" },
                    { new Guid("bd4c104b-bb4d-482d-be08-f8962f2a4ab7"), new Guid("d3621cc3-deb1-478c-b068-116a4fa2f0ac"), "Oils" },
                    { new Guid("bf48413d-15bb-4a8f-98c8-3bded3b3fe3b"), new Guid("d5c7320c-b3ad-4c67-9e44-1dc57952f9ae"), "Melons" },
                    { new Guid("cb62d76d-e302-471b-83bc-b6f491cb9b8d"), new Guid("303667df-67ec-4234-aa96-af33c9140f0b"), "Other Grains" },
                    { new Guid("d226a4ba-80cb-4584-9f9c-806ec9f32e58"), new Guid("c40385c1-4365-4bba-ac67-2125e99aa9d3"), "Sugars" },
                    { new Guid("da77506c-7544-48c7-9383-09e0fbe67738"), new Guid("cb72317a-733f-41ec-9760-9b7e535ea7c9"), "Seeds" },
                    { new Guid("de0551ee-0d70-4a32-ab80-abdf6acb0990"), new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Pork" },
                    { new Guid("e120d296-27d6-4d5d-af04-86de6b04320f"), new Guid("303667df-67ec-4234-aa96-af33c9140f0b"), "Rice" },
                    { new Guid("eb947b74-5804-4433-9220-9f8ad2a02104"), new Guid("812a9f16-268a-4087-997a-478dcdaabda6"), "Cheese" },
                    { new Guid("f1103175-a80b-4ea4-9b2c-136541d0384e"), new Guid("c9ae85d8-b441-4199-a01f-777c1ae0e16d"), "Leafy Greens" },
                    { new Guid("fada0c45-3f76-4137-a716-47d2564aa6be"), new Guid("2359fde8-9c0b-4b4b-9892-2a4309688b12"), "Poultry" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FoodSubCategories_FoodSubCategoryId",
                table: "Products",
                column: "FoodSubCategoryId",
                principalTable: "FoodSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
