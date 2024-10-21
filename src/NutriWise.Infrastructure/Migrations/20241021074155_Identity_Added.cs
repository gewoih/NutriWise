using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Identity_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_User_UserId",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("08fc2e24-ada6-4627-a7c9-54c6710b89bf"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("29d0f11c-1441-480e-88e3-bd168f491bf7"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("29e54674-0d1d-494e-ba86-5cfe7619c2c1"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("2d2bd723-7181-427e-b685-54c798455b88"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("3b3220e7-0e56-4966-87c2-10166f4f13eb"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("416046a2-0c68-4cfa-936b-81cb3e50172f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("4e6ff995-5be4-4fbf-aab7-5f81e8459dca"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("604d731e-840e-48c2-a4e6-d29eb9b1cc46"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c2eab0a0-98f7-40c7-8968-9e040cb67f1d"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("f76ebb60-8b54-42e1-a284-4a4a04f18e50"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("03c6acb5-e654-4497-b9b7-7ac9c973543c"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cb713f1-7d24-4c5b-9936-78f34c19142d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1cc6ffeb-b5bb-43a7-8c24-9b59451c6b97"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2382c00d-8751-4e88-abc4-f85f37c5b499"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2383e528-a293-4515-903f-82623e2e095d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("314e9055-4782-4ea3-ac36-17786810b7d6"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("38c4fc47-d01a-42c5-bb82-aff9e102dfe9"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("41838eb2-8aec-4738-89d1-6b66cbc6f2c5"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("48e2ae8b-ecd7-499c-b8e6-01aab7b14c5b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("53ef3c99-32d4-44ab-9c0d-864d28ce9c37"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e172221-57ba-4ae8-b2a2-f045f2b25092"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("67d023bb-4c41-47c5-9331-389c0fbea7ce"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ae81459-579d-4a92-888f-d3f1f3e56491"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b503ebf-7280-41a0-afe4-c09737d8e751"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e32f70b-a61b-4d6c-8584-9ce2faf65fa8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("751e597e-d74c-4327-8508-571edb1e94ec"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("838f7c7e-c03b-48c0-a023-1e7e20d6596a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("928b5b5b-a149-44f8-b243-3a724d1eba6c"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9de41ce9-7ecf-4bae-8dc3-3c07da6561f2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ea992a1-b818-4b63-ac23-c9f9b188d583"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a158d6ca-3e82-444a-b305-c96e45ec3a80"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a71d8fba-913f-4fed-b91f-c1ce0f8ccb2d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a754df1c-db94-41ef-828b-856b8d9600d1"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6a98d97-e15d-492a-846b-17ea179b7092"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb2d4bba-299a-4492-8c18-bb5b9abe413a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfffed6b-ad4a-4234-94ab-a2e74f113853"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c16d80ba-6b7a-4ef7-a879-05f3f88c27a2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4534728-bbf8-40aa-ba51-d2b86b0b114a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c61871d2-0801-4144-8ebe-66042de8a923"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d25f7edb-0709-4a75-85c4-e508c5df0f48"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7afa165-abab-4cd8-880c-3d5c0d5eef7e"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb65bf4f-958f-4d70-a62d-cb5c9cf163a7"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("28df446c-190f-4a0b-9176-4bf58ee9db08"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("50ec680b-c656-4796-a3ce-239496d37c9e"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("60209fe5-8c58-4870-b8d9-de72f1e74739"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("6053e43a-e3d4-450a-951a-f83c2d0c67c1"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("7c49854b-ecdf-467f-9f75-aecdcaf74eac"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("c2d8da1f-b39d-4e87-abea-ec302da66149"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("c7e90907-fbd8-493b-b680-aaf52a4bfc4c"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("cf55ec6e-d045-482b-8111-d5320fff5f47"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("d7a93261-1a31-463f-88a9-c122b54c2008"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("db54a856-91f1-4295-b0c3-b4bd60e56403"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("f194e8da-668f-4e0d-ae92-6d6404a6742c"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("faf16d73-52ce-4991-9945-010dcce84762"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("291bdc89-fd59-416f-b444-52bbfdf99a73"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("75de2bb8-11cc-4f8f-8613-121ca18a8c9c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("776abb02-0fcc-4ad3-b5e7-9b50e34617ff"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("80735ea8-6301-48eb-8249-4578981b97c6"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("816a7cca-ebea-4e5f-9eb0-498894e28395"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("aed2d5d0-1baf-4b65-9cd7-8b938398b44a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("baad7895-49e2-4cc8-8b40-4f53dd02dc30"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1accd7d-995f-449d-b598-a85360d6cb99"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd9d8ae5-cd0a-4ecd-ab69-bfe974d541ce"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "Caption",
                table: "AspNetUsers",
                newName: "SecurityStamp");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_AspNetUsers_UserId",
                table: "UserProfiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_AspNetUsers_UserId",
                table: "UserProfiles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "User",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "User",
                newName: "Caption");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_User_UserId",
                table: "UserProfiles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
