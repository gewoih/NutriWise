using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodSubCategories_FoodCategories_CategoryId",
                table: "FoodSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_FoodSubCategories_CategoryId",
                table: "FoodSubCategories");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("12cefa87-eab8-4796-a2e5-4d3356b5e3a9"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("2fc32da0-8179-4928-837a-96b6c602294b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("55c9330b-f35b-4deb-b766-ddc4cc397351"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("56c711ab-1c0f-4aff-abee-878803a4b67f"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("5a2a4b99-46e9-4033-8af1-d2a121dfdf11"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("7525dfc0-98c8-44fd-a280-ddb64424d574"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("8f77e549-9ca6-4000-9d7b-09699321a96b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("9b4c8901-a65f-47ca-829b-7492c648284b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("9d284174-4e54-4fe6-ade2-e19ddd28cec0"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("ee40fdd9-67c7-47b0-b924-a1ecaf1f0350"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("07da96e6-9d28-475a-8f0a-abc6ae9da19a"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("0caf128a-29fd-4326-a84a-47929e1c6b5a"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("29d515ad-9a98-410c-acf9-37e3f35c37fb"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("4fc284e4-c458-4d55-8c24-5ebaa86c2171"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("6e87d858-24f7-457f-8095-f1e2e9baed8c"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("771e72ce-d23d-43ee-9f27-142c2df6c089"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("904bcb27-5e9f-4b2b-aba7-7f1db0343545"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("b159f248-ab55-409b-a4c0-c4060e94c7ac"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("bca501f8-d398-4ab2-a1f3-c34c92c080d3"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("e80dc3f7-e4af-4e97-894b-c202a2b2ba9e"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("efc770ef-ceb6-4c15-877a-9283e4438198"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("fa6620fa-f596-4699-90d5-618b95f6348c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00e518f5-62aa-439b-a2d4-fd2915b4e7f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("024d0b8a-2682-4682-95e3-76c03104de1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04caf886-89d6-48da-af52-9f687a2dda3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0549066a-6896-4c8e-9499-2b2b672720ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05835763-cdf8-4d83-9233-7d7c82a81df0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0588c53d-e051-4d8b-a132-5235c501562e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("078fd2df-599b-422d-924c-e90c6c0884e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ac421c8-4bd7-4277-995c-3ab95379a71a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dd8b0b4-62ab-4cd4-87e4-3199cfd8aae1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1200f4d0-415e-49f5-9199-501fbe211241"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("122b8169-9a23-4e47-bf19-8707a736cc01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14773346-93c0-43ec-9bb1-55e176448065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14fcdd29-94af-4b19-8a53-1dccb58a6a5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1844f708-1f68-4111-863f-3735c65d3e7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19a876ba-147c-4d55-a397-028eeee8c250"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a1b499a-dc8c-438d-8b25-b46e259d4e58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bbc1f8b-2aa6-4f55-a946-3fe3ad081f9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d207653-9317-4d11-9e0c-20d3fc6df6fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e6249a2-799f-42ff-ac86-2babd2ed1dc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eb98c9f-a70d-496c-8ede-31cd665cf60f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f0e8bac-e084-4741-8002-2c34905e92e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f714ae5-95b3-45cb-b819-fb8cab1ba66f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("201e55c1-1d55-42e7-a04d-b856903ed39c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c034ee-6b48-4f70-9c95-b3945ba57a1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ced3af-cb81-4823-b29e-6d45b4172275"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c32462-1a0e-4313-baca-e03dcae499db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("271b0816-535e-40cf-8583-445c678eeb50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28cd8cf4-1cb1-41d8-b44a-b65a221435fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a4ad7a9-690e-45ff-82e1-61ed5c57db4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c854f84-8083-4fa1-a7e0-3d179d6e8152"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e8f59c7-128a-42db-8341-8021f2f6c932"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30ebde56-bfa0-49e4-80b8-65083fd61317"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31ac3591-d39b-4cc5-92ee-273d7045c4ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31cfc04f-ba31-44c4-ad25-76bfa6458908"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("321983e6-4572-4040-a4a5-9a008aadfc82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32479f27-e332-464c-bc7a-803515bcd876"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33aca046-5ccf-4d59-9153-84604271fa98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34ed3daa-8918-4136-b321-a851c825511b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("383af3a1-7ed4-40eb-b338-93713e5a52ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3907ed95-22af-4755-b703-8205e31ce9f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("395b3c9f-3550-4f31-883e-14c6dee2bb1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b31c2cc-e475-477d-af52-934f8abf972e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bf10805-00bf-44c8-bb4e-0d2e19e260b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c2cfa6d-cc18-4440-978e-efead5eb3e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d9f5e38-4760-42de-9b2a-1613b0f66caf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40812df1-e288-482f-b490-78b0260beedb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44377492-aed6-4639-9dec-62c0b1396d87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4aa90319-d3ec-4968-92eb-d5e3e0cb2a5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b876f88-fdd6-4be1-8fd7-6eb6eb37c329"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4de9f8de-330c-42f1-9a25-bb3af45a44cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e1c670a-1b73-49b5-8dcf-6d00998572ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ffa15e1-621f-4f3b-b92b-05b3685c7a0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("516968bc-5c56-46ea-ae7b-7c300f83af9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("517b4d97-00ca-46b0-a512-7c04a0048b24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51e5f0d3-c200-4af7-87c5-51fa2d1ff4f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5223ea8b-7481-467c-9694-dcb3fb7f779c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56094ea7-4ba6-45e6-8a37-d55c70fbe347"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56e92a98-7320-4737-985b-95637122f7af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57594da3-9022-4a50-986d-a11c1e12e20b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5afd5b64-33ec-4700-be07-d8e5766893fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ccafd9f-8efd-4c31-9317-f4e60d3d9408"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d158e91-18a9-4e8c-aa43-21de243a2a76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d27bc66-5816-48d1-b510-5cb1ea2ebad0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e6c112e-564b-400f-9fd2-f6ce1a25cbbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f82625e-76b3-4627-9de1-79e918ceba76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60dcaed5-caa8-4b38-961e-fcfc25005dec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67e003cc-5f06-407b-a8d1-70789d5cde60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bb45b42-5b62-4610-8e79-2a5fab5b3e12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c9ba509-f7a7-44a9-a30b-b88c1363b0a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cffdfb5-0558-404b-9fed-908a33083307"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d92edd7-18de-42f2-b780-4fdb6ae5bb3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("708398e7-309b-44b6-88b0-f65fe28912cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7166cf9b-a41b-481d-be16-35c61ff319e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("729ff0d1-de11-458c-958b-b12f11e57cac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73bb6c92-12da-434a-bc31-363787d1bae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73e835e6-79f5-4714-b272-853add211415"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74bcf38d-7927-40e7-9b75-98662c43e326"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75633aa8-b849-434d-b63a-f0e892c3ff0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76057c33-acff-4607-80e5-4bd8e77cf3fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76500f6a-87b8-4944-a7d6-758e86a81d96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7752d074-6a5c-461e-a0e0-d8fc58f360c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("791dc057-6954-460e-a26a-1bbb4289cd95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a21d2cc-6ba2-426d-b834-d41f0adc308f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a9543ba-d151-4a60-8084-bc64c0c154ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e2bcebc-2c00-414f-9f19-ec7526407d7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80692797-a866-4265-a6c9-262bc15b8b07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81d9e9f7-dc6e-446b-b191-80af0766d8c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82da03c9-d2ae-420e-9fb6-8bda3870769f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("849da813-99ba-4485-be45-62d00ec5f34f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84bb1fd3-ef8b-44c1-85b0-ee7e47a9c3ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8667cea8-fde3-44ad-8be9-4d863d329200"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86cc1411-7110-4f2f-a2b7-6a09d3cdbc43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86dd3181-ff7e-4071-82e6-a6900f64fc58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89ee70f0-2397-462c-aaa8-b33388346a8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b8c4100-445c-481d-b6f4-3f021968a0cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cc34180-2e04-4d99-bf03-05b3efacf516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fd366c0-541d-4f30-9764-3f1ba49f1d5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92b78ff5-6281-4cc0-9d72-ccf441bb928f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("957604ad-eb9a-4479-bce0-de8f2fa77817"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("983d389c-4d47-4153-a4d6-1551a11379f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9914def4-474f-422e-96d7-2a813e02bb00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99f4f6b1-0d4f-4744-8144-b1d7777a98fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a55fd53-7123-4491-915a-3b43d41fe0ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af8481b-d5c3-4683-bba5-16137b03f02f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c2d61a0-6ba8-45c6-9376-12d9ef854770"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ecb4f95-487c-4905-ab43-5b8ea7b6b976"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e6596d-4941-496e-847a-d1a05d481c2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2f165b4-e1ba-41bc-a18f-6d62cd638e19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2f91220-8861-4880-8a11-91a1a49941e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a441691f-f059-4f58-9624-945c304365f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a64d679b-b762-4d15-8931-10ada5db9486"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8cbf969-efad-4361-b9f8-9eb264fc3792"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a916dfea-8c83-4a0f-a972-02c85ad8032a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa0d8272-019b-4a3b-974d-504eff25fdef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab6c3e20-0071-4170-806a-2a981f8f821b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac027667-9965-4963-a6c2-31939efc5d28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad78f4ff-870b-439e-a158-45efa28201ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad95a414-c275-4dc2-80d7-12654ab2b0cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae78e3a3-e7a1-4eb5-bd6c-f05d7dae1285"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afcc76ae-06ac-47a8-ad2d-6af58d2cbd16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1010632-0342-44ea-8e39-c1ec59d178b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2dfb854-7ddf-4a7c-a012-d9c6c073500f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b316c287-ce8c-44e9-a406-c3d335834d95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b606bd43-3b71-4b09-9761-c57e8ed42861"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b670d9a4-b2d9-46ac-9f92-cf6d07481bdf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b851a0c1-97b3-447a-8ab9-e3e2bd7c9d86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b85aa3ca-b857-4a42-9548-934c1a967ea0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8bcf148-7f49-4c8f-b20a-a9c138d983c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8ea98a6-5e7e-42a2-8e9a-ea4c80b0291c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9352617-702f-47f6-bc75-6fac43ae076c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb8aa4d0-123a-4b80-9d44-517d7def02a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc646842-3b4a-4fe8-a8de-03fe7f5d5d7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bec688b7-b626-4ec0-8fee-1d6a664ed664"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0592194-208d-4341-891f-435df8a57eea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1c8bb0b-059d-409b-bfbb-db7473082ba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3cc3c9f-169d-457e-bdb6-90e6f703e428"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c53443a7-06c0-4140-bdeb-5fdb94fb1ce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c77dcf7a-04a7-44dc-b515-217aae6db34a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7ec7272-b9d5-44be-88ad-b635d0df5293"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb7904c7-8fe6-404d-9b53-bede41b4ae95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb848193-d0e2-44a9-a349-c65c2189551f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdd4470e-96b9-4e88-a42c-c354a6e3fa0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cea84979-1ac3-4191-ae4c-bac315376da9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf2c40c7-0f93-4dec-8c97-c2404d137ae4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2a08df2-a456-4652-82ec-dd323f1784db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d57a4ce4-dce5-43fa-8ef4-fabf5e0aa92c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d71044b7-e273-4305-80ee-582516a8434b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d71da456-98fb-47c6-a9d1-adc90162266c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9409785-421f-4c77-a8ff-c66bbe259021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d99e2844-3a19-4a56-a1c7-da88c0f919cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9aa972f-1889-46f3-8512-079270372e11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddd74eda-5e62-483e-b476-c395d650b1ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e054f451-def0-4002-90a0-82ad58162328"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2deca58-cecb-4218-acfc-6f28096ba991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e548d498-0245-4bf2-b6e5-4192e2cdc0cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9259058-800f-4dfe-9d65-aa857a422e4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9812489-b4a0-4521-bc75-1ed9fc39d500"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec32832b-1b06-4fd6-8d77-c8027600bbd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec758021-bc2f-47bc-b4ff-f9d7beeb78af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef4a0c15-e66f-45e2-830b-ac0f1adfb2ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efcf24af-54f4-4b57-8b07-88687c0652d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4663f29-abdc-469b-afce-e928f7ac9c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f503800f-708e-4674-99b1-b005c4529625"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7488a06-d343-4134-96dd-5f7d47488cbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc4fac3d-4890-4a62-8f3d-277b3cf6436c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe6438b3-6e58-43d1-aba5-fd1135d3fd3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe6d661b-6b6f-46bd-a2b8-0d5ca92bd4ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("feacba88-cc8e-4935-b5bd-0ac3654e8437"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fff0d7a4-a46e-44dc-a24d-d57605aeac67"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("41d491a9-d817-4683-885f-02dee3121c15"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cfa63ef-457d-4932-b77a-b6295af3278a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d723e01-39e6-461e-a685-e954f74576a0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("84fdd379-810b-4ff7-8ab7-32f970fcd1c0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("85050f35-b856-4436-b81b-416457baeef0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa7a78a2-9a61-43fe-abc3-041af22be3b0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae08aa07-e259-4763-a6fe-e3bd4f94fade"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b46658fd-606b-4288-9d58-c6decc3ce9b8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce094fdf-c267-484f-b024-21b5819f2c23"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d68078fa-9fe6-45dd-bd9d-dc0185f99074"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("fab798e1-fd52-43c0-bf64-69400266487f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1facc03c-d98d-41c7-b4bc-a00d73d0fb22"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fded450-95cf-4c28-b43f-5ef3e27c95cb"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("83fe4edb-1bd0-478b-a8a1-f061ad3415b1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("95d0967f-4e70-4763-a288-85f994b3057f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7193554-2d86-4996-a2d8-c0527db7042a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ddbcf736-7980-473e-b281-351563e64a13"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2268a12-220f-4789-b78a-7acea5395170"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Allergies");

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "KitchenEquipments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KitchenEquipments",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "KitchenEquipments",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "KitchenEquipments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KitchenEquipments",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "FoodSubCategories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodSubCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "FoodSubCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FoodCategoryId",
                table: "FoodSubCategories",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FoodSubCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "FoodSubCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "FoodCategories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "FoodCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "FoodCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FoodCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "FoodCategories",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "Allergies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Allergies",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Allergies",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Allergies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Allergies",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodSubCategories_FoodCategoryId",
                table: "FoodSubCategories",
                column: "FoodCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodSubCategories_FoodCategories_FoodCategoryId",
                table: "FoodSubCategories",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodSubCategories_FoodCategories_FoodCategoryId",
                table: "FoodSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_FoodSubCategories_FoodCategoryId",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KitchenEquipments");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "FoodSubCategories");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "FoodCategories");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Allergies");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "KitchenEquipments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FoodSubCategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FoodCategories",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Allergies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12cefa87-eab8-4796-a2e5-4d3356b5e3a9"), "Shellfish" },
                    { new Guid("2fc32da0-8179-4928-837a-96b6c602294b"), "Gluten" },
                    { new Guid("55c9330b-f35b-4deb-b766-ddc4cc397351"), "Sesame" },
                    { new Guid("56c711ab-1c0f-4aff-abee-878803a4b67f"), "Wheat" },
                    { new Guid("5a2a4b99-46e9-4033-8af1-d2a121dfdf11"), "Eggs" },
                    { new Guid("7525dfc0-98c8-44fd-a280-ddb64424d574"), "Soy" },
                    { new Guid("8f77e549-9ca6-4000-9d7b-09699321a96b"), "Peanuts" },
                    { new Guid("9b4c8901-a65f-47ca-829b-7492c648284b"), "Tree Nuts" },
                    { new Guid("9d284174-4e54-4fe6-ade2-e19ddd28cec0"), "Fish" },
                    { new Guid("ee40fdd9-67c7-47b0-b924-a1ecaf1f0350"), "Dairy" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1facc03c-d98d-41c7-b4bc-a00d73d0fb22"), "Dairy" },
                    { new Guid("1fded450-95cf-4c28-b43f-5ef3e27c95cb"), "Herbs and Spices" },
                    { new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Fruits" },
                    { new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Meats" },
                    { new Guid("83fe4edb-1bd0-478b-a8a1-f061ad3415b1"), "Baking Ingredients" },
                    { new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Vegetables" },
                    { new Guid("a7193554-2d86-4996-a2d8-c0527db7042a"), "Nuts and Seeds" },
                    { new Guid("ddbcf736-7980-473e-b281-351563e64a13"), "Grains and Legumes" },
                    { new Guid("e2268a12-220f-4789-b78a-7acea5395170"), "Oils and Fats" }
                });

            migrationBuilder.InsertData(
                table: "KitchenEquipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("07da96e6-9d28-475a-8f0a-abc6ae9da19a"), "Food Processor" },
                    { new Guid("0caf128a-29fd-4326-a84a-47929e1c6b5a"), "Air Fryer" },
                    { new Guid("29d515ad-9a98-410c-acf9-37e3f35c37fb"), "Rice Cooker" },
                    { new Guid("4fc284e4-c458-4d55-8c24-5ebaa86c2171"), "Mixer" },
                    { new Guid("6e87d858-24f7-457f-8095-f1e2e9baed8c"), "Oven" },
                    { new Guid("771e72ce-d23d-43ee-9f27-142c2df6c089"), "Stove" },
                    { new Guid("904bcb27-5e9f-4b2b-aba7-7f1db0343545"), "Pressure Cooker" },
                    { new Guid("b159f248-ab55-409b-a4c0-c4060e94c7ac"), "Microwave" },
                    { new Guid("bca501f8-d398-4ab2-a1f3-c34c92c080d3"), "Slow Cooker" },
                    { new Guid("e80dc3f7-e4af-4e97-894b-c202a2b2ba9e"), "Blender" },
                    { new Guid("efc770ef-ceb6-4c15-877a-9283e4438198"), "Toaster" },
                    { new Guid("fa6620fa-f596-4699-90d5-618b95f6348c"), "Grill" }
                });

            migrationBuilder.InsertData(
                table: "FoodSubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Squash Vegetables" },
                    { new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310"), new Guid("a7193554-2d86-4996-a2d8-c0527db7042a"), "Seeds" },
                    { new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146"), new Guid("ddbcf736-7980-473e-b281-351563e64a13"), "Pasta" },
                    { new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Cruciferous Vegetables" },
                    { new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158"), new Guid("ddbcf736-7980-473e-b281-351563e64a13"), "Other Grains" },
                    { new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd"), new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Poultry" },
                    { new Guid("41d491a9-d817-4683-885f-02dee3121c15"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Stone Fruits" },
                    { new Guid("4cfa63ef-457d-4932-b77a-b6295af3278a"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Pome Fruits" },
                    { new Guid("4d723e01-39e6-461e-a685-e954f74576a0"), new Guid("83fe4edb-1bd0-478b-a8a1-f061ad3415b1"), "Sugars" },
                    { new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf"), new Guid("ddbcf736-7980-473e-b281-351563e64a13"), "Rice" },
                    { new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b"), new Guid("ddbcf736-7980-473e-b281-351563e64a13"), "Legumes" },
                    { new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1"), new Guid("1facc03c-d98d-41c7-b4bc-a00d73d0fb22"), "Other Dairy" },
                    { new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Leafy Greens" },
                    { new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa"), new Guid("1facc03c-d98d-41c7-b4bc-a00d73d0fb22"), "Cheese" },
                    { new Guid("84fdd379-810b-4ff7-8ab7-32f970fcd1c0"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Melons" },
                    { new Guid("85050f35-b856-4436-b81b-416457baeef0"), new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Shellfish" },
                    { new Guid("aa7a78a2-9a61-43fe-abc3-041af22be3b0"), new Guid("83fe4edb-1bd0-478b-a8a1-f061ad3415b1"), "Baking Ingredients" },
                    { new Guid("ae08aa07-e259-4763-a6fe-e3bd4f94fade"), new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Beef" },
                    { new Guid("b46658fd-606b-4288-9d58-c6decc3ce9b8"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Dried Fruits" },
                    { new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61"), new Guid("1fded450-95cf-4c28-b43f-5ef3e27c95cb"), "Herbs" },
                    { new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d"), new Guid("a7193554-2d86-4996-a2d8-c0527db7042a"), "Nuts" },
                    { new Guid("ce094fdf-c267-484f-b024-21b5819f2c23"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Root Vegetables" },
                    { new Guid("d68078fa-9fe6-45dd-bd9d-dc0185f99074"), new Guid("1facc03c-d98d-41c7-b4bc-a00d73d0fb22"), "Milk" },
                    { new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Berries" },
                    { new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Citrus Fruits" },
                    { new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd"), new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Fish" },
                    { new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2"), new Guid("1fded450-95cf-4c28-b43f-5ef3e27c95cb"), "Spices" },
                    { new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Nightshades" },
                    { new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8"), new Guid("2df47e0c-08c2-4f37-90da-14c4a7bfd19c"), "Tropical Fruits" },
                    { new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8"), new Guid("56255fd7-3acb-4495-9ebb-58d11951fc7c"), "Pork" },
                    { new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef"), new Guid("e2268a12-220f-4789-b78a-7acea5395170"), "Oils" },
                    { new Guid("fab798e1-fd52-43c0-bf64-69400266487f"), new Guid("95d0967f-4e70-4763-a288-85f994b3057f"), "Allium Vegetables" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "Caption", "Carbohydrates", "CreatedDate", "DeletedDate", "Fats", "IsDeleted", "ModifiedDate", "Proteins", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("00e518f5-62aa-439b-a2d4-fd2915b4e7f6"), null, "Limes", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("024d0b8a-2682-4682-95e3-76c03104de1e"), null, "Chicken Wings", null, null, null, null, false, null, null, new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd") },
                    { new Guid("04caf886-89d6-48da-af52-9f687a2dda3e"), null, "Soba Noodles", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("0549066a-6896-4c8e-9499-2b2b672720ef"), null, "Lentils", null, null, null, null, false, null, null, new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b") },
                    { new Guid("05835763-cdf8-4d83-9233-7d7c82a81df0"), null, "Flaxseeds", null, null, null, null, false, null, null, new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310") },
                    { new Guid("0588c53d-e051-4d8b-a132-5235c501562e"), null, "Swiss", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("078fd2df-599b-422d-924c-e90c6c0884e9"), null, "Bananas", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("0ac421c8-4bd7-4277-995c-3ab95379a71a"), null, "Watermelons", null, null, null, null, false, null, null, new Guid("84fdd379-810b-4ff7-8ab7-32f970fcd1c0") },
                    { new Guid("0dd8b0b4-62ab-4cd4-87e4-3199cfd8aae1"), null, "Pork Loins", null, null, null, null, false, null, null, new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8") },
                    { new Guid("1200f4d0-415e-49f5-9199-501fbe211241"), null, "Cherries", null, null, null, null, false, null, null, new Guid("41d491a9-d817-4683-885f-02dee3121c15") },
                    { new Guid("122b8169-9a23-4e47-bf19-8707a736cc01"), null, "Feta", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("14773346-93c0-43ec-9bb1-55e176448065"), null, "Rice Noodles", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("14fcdd29-94af-4b19-8a53-1dccb58a6a5d"), null, "Arugula", null, null, null, null, false, null, null, new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180") },
                    { new Guid("1844f708-1f68-4111-863f-3735c65d3e7d"), null, "Cumin", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("19a876ba-147c-4d55-a397-028eeee8c250"), null, "Dried Apricots", null, null, null, null, false, null, null, new Guid("b46658fd-606b-4288-9d58-c6decc3ce9b8") },
                    { new Guid("1a1b499a-dc8c-438d-8b25-b46e259d4e58"), null, "Tomatoes", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("1bbc1f8b-2aa6-4f55-a946-3fe3ad081f9a"), null, "Thyme", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("1d207653-9317-4d11-9e0c-20d3fc6df6fb"), null, "Apricots", null, null, null, null, false, null, null, new Guid("41d491a9-d817-4683-885f-02dee3121c15") },
                    { new Guid("1e6249a2-799f-42ff-ac86-2babd2ed1dc0"), null, "Greek Yogurt", null, null, null, null, false, null, null, new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1") },
                    { new Guid("1eb98c9f-a70d-496c-8ede-31cd665cf60f"), null, "Arborio Rice", null, null, null, null, false, null, null, new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf") },
                    { new Guid("1f0e8bac-e084-4741-8002-2c34905e92e3"), null, "Chicken Breasts", null, null, null, null, false, null, null, new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd") },
                    { new Guid("1f714ae5-95b3-45cb-b819-fb8cab1ba66f"), null, "Heavy Cream", null, null, null, null, false, null, null, new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1") },
                    { new Guid("201e55c1-1d55-42e7-a04d-b856903ed39c"), null, "Broccoli", null, null, null, null, false, null, null, new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547") },
                    { new Guid("24c034ee-6b48-4f70-9c95-b3945ba57a1f"), null, "Penne", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("25ced3af-cb81-4823-b29e-6d45b4172275"), null, "Cod", null, null, null, null, false, null, null, new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd") },
                    { new Guid("26c32462-1a0e-4313-baca-e03dcae499db"), null, "Quinoa", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("271b0816-535e-40cf-8583-445c678eeb50"), null, "Carrots", null, null, null, null, false, null, null, new Guid("ce094fdf-c267-484f-b024-21b5819f2c23") },
                    { new Guid("28cd8cf4-1cb1-41d8-b44a-b65a221435fa"), null, "Beets", null, null, null, null, false, null, null, new Guid("ce094fdf-c267-484f-b024-21b5819f2c23") },
                    { new Guid("2a4ad7a9-690e-45ff-82e1-61ed5c57db4f"), null, "Yellow Squash", null, null, null, null, false, null, null, new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee") },
                    { new Guid("2c854f84-8083-4fa1-a7e0-3d179d6e8152"), null, "Pears", null, null, null, null, false, null, null, new Guid("4cfa63ef-457d-4932-b77a-b6295af3278a") },
                    { new Guid("2e8f59c7-128a-42db-8341-8021f2f6c932"), null, "Cherry Tomatoes", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("30ebde56-bfa0-49e4-80b8-65083fd61317"), null, "Turnips", null, null, null, null, false, null, null, new Guid("ce094fdf-c267-484f-b024-21b5819f2c23") },
                    { new Guid("31ac3591-d39b-4cc5-92ee-273d7045c4ed"), null, "Guavas", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("31cfc04f-ba31-44c4-ad25-76bfa6458908"), null, "Jasmine Rice", null, null, null, null, false, null, null, new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf") },
                    { new Guid("321983e6-4572-4040-a4a5-9a008aadfc82"), null, "Baking Soda", null, null, null, null, false, null, null, new Guid("aa7a78a2-9a61-43fe-abc3-041af22be3b0") },
                    { new Guid("32479f27-e332-464c-bc7a-803515bcd876"), null, "Pork Chops", null, null, null, null, false, null, null, new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8") },
                    { new Guid("33aca046-5ccf-4d59-9153-84604271fa98"), null, "Avocado Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("34ed3daa-8918-4136-b321-a851c825511b"), null, "Habaneros", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("383af3a1-7ed4-40eb-b338-93713e5a52ac"), null, "Chicken Thighs", null, null, null, null, false, null, null, new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd") },
                    { new Guid("3907ed95-22af-4755-b703-8205e31ce9f5"), null, "Oranges", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("395b3c9f-3550-4f31-883e-14c6dee2bb1d"), null, "Unsalted Butter", null, null, null, null, false, null, null, new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1") },
                    { new Guid("3b31c2cc-e475-477d-af52-934f8abf972e"), null, "Zucchini", null, null, null, null, false, null, null, new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee") },
                    { new Guid("3bf10805-00bf-44c8-bb4e-0d2e19e260b9"), null, "Granulated Sugar", null, null, null, null, false, null, null, new Guid("4d723e01-39e6-461e-a685-e954f74576a0") },
                    { new Guid("3c2cfa6d-cc18-4440-978e-efead5eb3e82"), null, "Brown Sugar", null, null, null, null, false, null, null, new Guid("4d723e01-39e6-461e-a685-e954f74576a0") },
                    { new Guid("3d9f5e38-4760-42de-9b2a-1613b0f66caf"), null, "Parmesan", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("40812df1-e288-482f-b490-78b0260beedb"), null, "Dill", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("44377492-aed6-4639-9dec-62c0b1396d87"), null, "Swiss Chard", null, null, null, null, false, null, null, new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180") },
                    { new Guid("4aa90319-d3ec-4968-92eb-d5e3e0cb2a5b"), null, "Shrimp", null, null, null, null, false, null, null, new Guid("85050f35-b856-4436-b81b-416457baeef0") },
                    { new Guid("4b876f88-fdd6-4be1-8fd7-6eb6eb37c329"), null, "Whole Milk", null, null, null, null, false, null, null, new Guid("d68078fa-9fe6-45dd-bd9d-dc0185f99074") },
                    { new Guid("4de9f8de-330c-42f1-9a25-bb3af45a44cb"), null, "Paprika", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("4e1c670a-1b73-49b5-8dcf-6d00998572ef"), null, "Crab", null, null, null, null, false, null, null, new Guid("85050f35-b856-4436-b81b-416457baeef0") },
                    { new Guid("4ffa15e1-621f-4f3b-b92b-05b3685c7a0c"), null, "Salt", null, null, null, null, false, null, null, new Guid("aa7a78a2-9a61-43fe-abc3-041af22be3b0") },
                    { new Guid("516968bc-5c56-46ea-ae7b-7c300f83af9f"), null, "Black Beans", null, null, null, null, false, null, null, new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b") },
                    { new Guid("517b4d97-00ca-46b0-a512-7c04a0048b24"), null, "Brie", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("51e5f0d3-c200-4af7-87c5-51fa2d1ff4f2"), null, "Kale", null, null, null, null, false, null, null, new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180") },
                    { new Guid("5223ea8b-7481-467c-9694-dcb3fb7f779c"), null, "Pumpkin Seeds", null, null, null, null, false, null, null, new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310") },
                    { new Guid("56094ea7-4ba6-45e6-8a37-d55c70fbe347"), null, "Cashews", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("56e92a98-7320-4737-985b-95637122f7af"), null, "Low-Fat Milk", null, null, null, null, false, null, null, new Guid("d68078fa-9fe6-45dd-bd9d-dc0185f99074") },
                    { new Guid("57594da3-9022-4a50-986d-a11c1e12e20b"), null, "Apples", null, null, null, null, false, null, null, new Guid("4cfa63ef-457d-4932-b77a-b6295af3278a") },
                    { new Guid("5afd5b64-33ec-4700-be07-d8e5766893fb"), null, "Basmati Rice", null, null, null, null, false, null, null, new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf") },
                    { new Guid("5ccafd9f-8efd-4c31-9317-f4e60d3d9408"), null, "Egg Noodles", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("5d158e91-18a9-4e8c-aa43-21de243a2a76"), null, "Sesame Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("5d27bc66-5816-48d1-b510-5cb1ea2ebad0"), null, "Honey", null, null, null, null, false, null, null, new Guid("4d723e01-39e6-461e-a685-e954f74576a0") },
                    { new Guid("5e6c112e-564b-400f-9fd2-f6ce1a25cbbc"), null, "Radishes", null, null, null, null, false, null, null, new Guid("ce094fdf-c267-484f-b024-21b5819f2c23") },
                    { new Guid("5f82625e-76b3-4627-9de1-79e918ceba76"), null, "Polenta", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("60dcaed5-caa8-4b38-961e-fcfc25005dec"), null, "Raspberries", null, null, null, null, false, null, null, new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130") },
                    { new Guid("67e003cc-5f06-407b-a8d1-70789d5cde60"), null, "Strawberries", null, null, null, null, false, null, null, new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130") },
                    { new Guid("6bb45b42-5b62-4610-8e79-2a5fab5b3e12"), null, "Olive Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("6c9ba509-f7a7-44a9-a30b-b88c1363b0a5"), null, "Cantaloupes", null, null, null, null, false, null, null, new Guid("84fdd379-810b-4ff7-8ab7-32f970fcd1c0") },
                    { new Guid("6cffdfb5-0558-404b-9fed-908a33083307"), null, "Cornmeal", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("6d92edd7-18de-42f2-b780-4fdb6ae5bb3b"), null, "Lobster", null, null, null, null, false, null, null, new Guid("85050f35-b856-4436-b81b-416457baeef0") },
                    { new Guid("708398e7-309b-44b6-88b0-f65fe28912cc"), null, "Papayas", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("7166cf9b-a41b-481d-be16-35c61ff319e6"), null, "Chili Peppers", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("729ff0d1-de11-458c-958b-b12f11e57cac"), null, "Peaches", null, null, null, null, false, null, null, new Guid("41d491a9-d817-4683-885f-02dee3121c15") },
                    { new Guid("73bb6c92-12da-434a-bc31-363787d1bae9"), null, "Brussels Sprouts", null, null, null, null, false, null, null, new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547") },
                    { new Guid("73e835e6-79f5-4714-b272-853add211415"), null, "Millet", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("74bcf38d-7927-40e7-9b75-98662c43e326"), null, "Skim Milk", null, null, null, null, false, null, null, new Guid("d68078fa-9fe6-45dd-bd9d-dc0185f99074") },
                    { new Guid("75633aa8-b849-434d-b63a-f0e892c3ff0e"), null, "Chili Powder", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("76057c33-acff-4607-80e5-4bd8e77cf3fd"), null, "Pineapples", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("76500f6a-87b8-4944-a7d6-758e86a81d96"), null, "Ground Chicken", null, null, null, null, false, null, null, new Guid("3603e219-5983-43fa-949f-dcafb2bcdddd") },
                    { new Guid("7752d074-6a5c-461e-a0e0-d8fc58f360c4"), null, "Parsley", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("791dc057-6954-460e-a26a-1bbb4289cd95"), null, "Chickpeas", null, null, null, null, false, null, null, new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b") },
                    { new Guid("7a21d2cc-6ba2-426d-b834-d41f0adc308f"), null, "Garlic", null, null, null, null, false, null, null, new Guid("fab798e1-fd52-43c0-bf64-69400266487f") },
                    { new Guid("7a9543ba-d151-4a60-8084-bc64c0c154ed"), null, "Macadamia Nuts", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("7e2bcebc-2c00-414f-9f19-ec7526407d7a"), null, "Nectarines", null, null, null, null, false, null, null, new Guid("41d491a9-d817-4683-885f-02dee3121c15") },
                    { new Guid("80692797-a866-4265-a6c9-262bc15b8b07"), null, "Chia Seeds", null, null, null, null, false, null, null, new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310") },
                    { new Guid("81d9e9f7-dc6e-446b-b191-80af0766d8c0"), null, "Grape Tomatoes", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("82da03c9-d2ae-420e-9fb6-8bda3870769f"), null, "Dates", null, null, null, null, false, null, null, new Guid("b46658fd-606b-4288-9d58-c6decc3ce9b8") },
                    { new Guid("849da813-99ba-4485-be45-62d00ec5f34f"), null, "Baking Powder", null, null, null, null, false, null, null, new Guid("aa7a78a2-9a61-43fe-abc3-041af22be3b0") },
                    { new Guid("84bb1fd3-ef8b-44c1-85b0-ee7e47a9c3ee"), null, "Pecans", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("8667cea8-fde3-44ad-8be9-4d863d329200"), null, "Green Onions", null, null, null, null, false, null, null, new Guid("fab798e1-fd52-43c0-bf64-69400266487f") },
                    { new Guid("86cc1411-7110-4f2f-a2b7-6a09d3cdbc43"), null, "Serrano Peppers", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("86dd3181-ff7e-4071-82e6-a6900f64fc58"), null, "Bell Peppers", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("89ee70f0-2397-462c-aaa8-b33388346a8e"), null, "Pumpkin", null, null, null, null, false, null, null, new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee") },
                    { new Guid("8b8c4100-445c-481d-b6f4-3f021968a0cb"), null, "Bok Choy", null, null, null, null, false, null, null, new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547") },
                    { new Guid("8cc34180-2e04-4d99-bf03-05b3efacf516"), null, "Buckwheat", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("8fd366c0-541d-4f30-9764-3f1ba49f1d5a"), null, "Walnuts", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("92b78ff5-6281-4cc0-9d72-ccf441bb928f"), null, "Black Pepper", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("957604ad-eb9a-4479-bce0-de8f2fa77817"), null, "Maple Syrup", null, null, null, null, false, null, null, new Guid("4d723e01-39e6-461e-a685-e954f74576a0") },
                    { new Guid("983d389c-4d47-4153-a4d6-1551a11379f6"), null, "Lettuce", null, null, null, null, false, null, null, new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180") },
                    { new Guid("9914def4-474f-422e-96d7-2a813e02bb00"), null, "Bacon", null, null, null, null, false, null, null, new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8") },
                    { new Guid("99f4f6b1-0d4f-4744-8144-b1d7777a98fa"), null, "Sunflower Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("9a55fd53-7123-4491-915a-3b43d41fe0ba"), null, "Ground Beef", null, null, null, null, false, null, null, new Guid("ae08aa07-e259-4763-a6fe-e3bd4f94fade") },
                    { new Guid("9af8481b-d5c3-4683-bba5-16137b03f02f"), null, "Almonds", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("9c2d61a0-6ba8-45c6-9376-12d9ef854770"), null, "Butternut Squash", null, null, null, null, false, null, null, new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee") },
                    { new Guid("9ecb4f95-487c-4905-ab43-5b8ea7b6b976"), null, "Sour Cream", null, null, null, null, false, null, null, new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1") },
                    { new Guid("a0e6596d-4941-496e-847a-d1a05d481c2a"), null, "Tangerines", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("a2f165b4-e1ba-41bc-a18f-6d62cd638e19"), null, "Cilantro", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("a2f91220-8861-4880-8a11-91a1a49941e0"), null, "Tuna", null, null, null, null, false, null, null, new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd") },
                    { new Guid("a441691f-f059-4f58-9624-945c304365f3"), null, "White Rice", null, null, null, null, false, null, null, new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf") },
                    { new Guid("a64d679b-b762-4d15-8931-10ada5db9486"), null, "Oregano", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("a8cbf969-efad-4361-b9f8-9eb264fc3792"), null, "Cauliflower", null, null, null, null, false, null, null, new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547") },
                    { new Guid("a916dfea-8c83-4a0f-a972-02c85ad8032a"), null, "Honeydews", null, null, null, null, false, null, null, new Guid("84fdd379-810b-4ff7-8ab7-32f970fcd1c0") },
                    { new Guid("aa0d8272-019b-4a3b-974d-504eff25fdef"), null, "Blueberries", null, null, null, null, false, null, null, new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130") },
                    { new Guid("ab6c3e20-0071-4170-806a-2a981f8f821b"), null, "Basil", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("ac027667-9965-4963-a6c2-31939efc5d28"), null, "Spaghetti", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("ad78f4ff-870b-439e-a158-45efa28201ec"), null, "Ham", null, null, null, null, false, null, null, new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8") },
                    { new Guid("ad95a414-c275-4dc2-80d7-12654ab2b0cc"), null, "Cream Cheese", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("ae78e3a3-e7a1-4eb5-bd6c-f05d7dae1285"), null, "Mozzarella", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("afcc76ae-06ac-47a8-ad2d-6af58d2cbd16"), null, "Coconut Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("b1010632-0342-44ea-8e39-c1ec59d178b0"), null, "Lemons", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("b2dfb854-7ddf-4a7c-a012-d9c6c073500f"), null, "Cabbage", null, null, null, null, false, null, null, new Guid("23c13914-bebc-45ae-9d44-cbe075d6a547") },
                    { new Guid("b316c287-ce8c-44e9-a406-c3d335834d95"), null, "Turmeric", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("b606bd43-3b71-4b09-9761-c57e8ed42861"), null, "Ground Pork", null, null, null, null, false, null, null, new Guid("f6f038ec-3a4f-4dfe-b8f6-a052a5a017b8") },
                    { new Guid("b670d9a4-b2d9-46ac-9f92-cf6d07481bdf"), null, "Quinces", null, null, null, null, false, null, null, new Guid("4cfa63ef-457d-4932-b77a-b6295af3278a") },
                    { new Guid("b851a0c1-97b3-447a-8ab9-e3e2bd7c9d86"), null, "Grapefruits", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("b85aa3ca-b857-4a42-9548-934c1a967ea0"), null, "Acorn Squash", null, null, null, null, false, null, null, new Guid("18e605e5-5e1e-4968-a73b-7f622c9aefee") },
                    { new Guid("b8bcf148-7f49-4c8f-b20a-a9c138d983c6"), null, "Ginger", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("b8ea98a6-5e7e-42a2-8e9a-ea4c80b0291c"), null, "Cranberries", null, null, null, null, false, null, null, new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130") },
                    { new Guid("b9352617-702f-47f6-bc75-6fac43ae076c"), null, "Jalapenos", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("bb8aa4d0-123a-4b80-9d44-517d7def02a1"), null, "Parsnips", null, null, null, null, false, null, null, new Guid("ce094fdf-c267-484f-b024-21b5819f2c23") },
                    { new Guid("bc646842-3b4a-4fe8-a8de-03fe7f5d5d7b"), null, "Raisins", null, null, null, null, false, null, null, new Guid("b46658fd-606b-4288-9d58-c6decc3ce9b8") },
                    { new Guid("bec688b7-b626-4ec0-8fee-1d6a664ed664"), null, "Vegetable Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") },
                    { new Guid("c0592194-208d-4341-891f-435df8a57eea"), null, "Pistachios", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("c1c8bb0b-059d-409b-bfbb-db7473082ba4"), null, "Cheddar", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("c3cc3c9f-169d-457e-bdb6-90e6f703e428"), null, "Cinnamon", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("c53443a7-06c0-4140-bdeb-5fdb94fb1ce6"), null, "Mint", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("c77dcf7a-04a7-44dc-b515-217aae6db34a"), null, "Rosemary", null, null, null, null, false, null, null, new Guid("b81b1c1c-4495-4e1c-a255-b38d23831b61") },
                    { new Guid("c7ec7272-b9d5-44be-88ad-b635d0df5293"), null, "Kidney Beans", null, null, null, null, false, null, null, new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b") },
                    { new Guid("cb7904c7-8fe6-404d-9b53-bede41b4ae95"), null, "Onions", null, null, null, null, false, null, null, new Guid("fab798e1-fd52-43c0-bf64-69400266487f") },
                    { new Guid("cb848193-d0e2-44a9-a349-c65c2189551f"), null, "Scallops", null, null, null, null, false, null, null, new Guid("85050f35-b856-4436-b81b-416457baeef0") },
                    { new Guid("cdd4470e-96b9-4e88-a42c-c354a6e3fa0e"), null, "Spinach", null, null, null, null, false, null, null, new Guid("69283062-59c3-4f3d-afd7-a9e8fca71180") },
                    { new Guid("cea84979-1ac3-4191-ae4c-bac315376da9"), null, "Sunflower Seeds", null, null, null, null, false, null, null, new Guid("1cb447a5-11a2-43b4-8cf2-8a23d2405310") },
                    { new Guid("cf2c40c7-0f93-4dec-8c97-c2404d137ae4"), null, "Barley", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("d2a08df2-a456-4652-82ec-dd323f1784db"), null, "Pinto Beans", null, null, null, null, false, null, null, new Guid("58e450d7-4eaf-4e3d-ae46-05f38775878b") },
                    { new Guid("d57a4ce4-dce5-43fa-8ef4-fabf5e0aa92c"), null, "Salted Butter", null, null, null, null, false, null, null, new Guid("64d3a745-abbe-4573-9dd3-e6a9cbb8c0d1") },
                    { new Guid("d71044b7-e273-4305-80ee-582516a8434b"), null, "Cottage Cheese", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("d71da456-98fb-47c6-a9d1-adc90162266c"), null, "Coriander", null, null, null, null, false, null, null, new Guid("ea2182d3-6cb7-4463-b8f2-dcb012f4adc2") },
                    { new Guid("d9409785-421f-4c77-a8ff-c66bbe259021"), null, "Leeks", null, null, null, null, false, null, null, new Guid("fab798e1-fd52-43c0-bf64-69400266487f") },
                    { new Guid("d99e2844-3a19-4a56-a1c7-da88c0f919cd"), null, "Clementines", null, null, null, null, false, null, null, new Guid("e0d6795c-7d54-4fd1-8532-00a4124ec84a") },
                    { new Guid("d9aa972f-1889-46f3-8512-079270372e11"), null, "Passion Fruit", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("ddd74eda-5e62-483e-b476-c395d650b1ac"), null, "Mangoes", null, null, null, null, false, null, null, new Guid("f2b2109a-1676-45df-9a6d-1ecc945f07e8") },
                    { new Guid("e054f451-def0-4002-90a0-82ad58162328"), null, "Goat Cheese", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("e2deca58-cecb-4218-acfc-6f28096ba991"), null, "Salmon", null, null, null, null, false, null, null, new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd") },
                    { new Guid("e548d498-0245-4bf2-b6e5-4192e2cdc0cd"), null, "Shallots", null, null, null, null, false, null, null, new Guid("fab798e1-fd52-43c0-bf64-69400266487f") },
                    { new Guid("e9259058-800f-4dfe-9d65-aa857a422e4d"), null, "Plums", null, null, null, null, false, null, null, new Guid("41d491a9-d817-4683-885f-02dee3121c15") },
                    { new Guid("e9812489-b4a0-4521-bc75-1ed9fc39d500"), null, "Ricotta", null, null, null, null, false, null, null, new Guid("7a808fd5-8fe3-4a1f-a5d4-455a9d190faa") },
                    { new Guid("ec32832b-1b06-4fd6-8d77-c8027600bbd6"), null, "Rye", null, null, null, null, false, null, null, new Guid("2964cad5-9533-4bb0-a935-924ae1cd3158") },
                    { new Guid("ec758021-bc2f-47bc-b4ff-f9d7beeb78af"), null, "Eggplants", null, null, null, null, false, null, null, new Guid("ed7cc6f7-bcbd-4bbc-9972-d1a41b3ba12b") },
                    { new Guid("ef4a0c15-e66f-45e2-830b-ac0f1adfb2ae"), null, "Brown Rice", null, null, null, null, false, null, null, new Guid("5487abeb-a8f1-4329-9591-57c493cf45bf") },
                    { new Guid("efcf24af-54f4-4b57-8b07-88687c0652d7"), null, "Peanuts", null, null, null, null, false, null, null, new Guid("cd6556a3-ed82-47a7-85b2-09e10103857d") },
                    { new Guid("f4663f29-abdc-469b-afce-e928f7ac9c22"), null, "Blackberries", null, null, null, null, false, null, null, new Guid("d9d3865e-6f6a-4b97-885e-e7274f371130") },
                    { new Guid("f503800f-708e-4674-99b1-b005c4529625"), null, "Fusilli", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("f7488a06-d343-4134-96dd-5f7d47488cbc"), null, "Lasagna Sheets", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("fc4fac3d-4890-4a62-8f3d-277b3cf6436c"), null, "Roasts", null, null, null, null, false, null, null, new Guid("ae08aa07-e259-4763-a6fe-e3bd4f94fade") },
                    { new Guid("fe6438b3-6e58-43d1-aba5-fd1135d3fd3a"), null, "Haddock", null, null, null, null, false, null, null, new Guid("e47ee126-d146-497b-a6eb-45d983b54fbd") },
                    { new Guid("fe6d661b-6b6f-46bd-a2b8-0d5ca92bd4ca"), null, "Steaks", null, null, null, null, false, null, null, new Guid("ae08aa07-e259-4763-a6fe-e3bd4f94fade") },
                    { new Guid("feacba88-cc8e-4935-b5bd-0ac3654e8437"), null, "Macaroni", null, null, null, null, false, null, null, new Guid("23b7ae58-d9fb-4966-9f1d-e876864c8146") },
                    { new Guid("fff0d7a4-a46e-44dc-a24d-d57605aeac67"), null, "Canola Oil", null, null, null, null, false, null, null, new Guid("f7dd43d5-cf8f-4057-b5f0-8e0c843476ef") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodSubCategories_CategoryId",
                table: "FoodSubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodSubCategories_FoodCategories_CategoryId",
                table: "FoodSubCategories",
                column: "CategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
