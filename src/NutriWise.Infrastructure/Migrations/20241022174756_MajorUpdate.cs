using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MajorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Recipes");

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

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DaysCount = table.Column<int>(type: "integer", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyMeals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MealPlanId = table.Column<Guid>(type: "uuid", nullable: true),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyMeals_MealPlans_MealPlanId",
                        column: x => x.MealPlanId,
                        principalTable: "MealPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CookingInstructions = table.Column<string>(type: "text", nullable: false),
                    DailyMealsId = table.Column<Guid>(type: "uuid", nullable: true),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_DailyMeals_DailyMealsId",
                        column: x => x.DailyMealsId,
                        principalTable: "DailyMeals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    MeasurmentType = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    MealId = table.Column<Guid>(type: "uuid", nullable: true),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4af58e1b-fbee-412e-a80f-3f6a41c1edf5"), "Gluten" },
                    { new Guid("621df475-35ac-4c46-b89a-a17a2bc7632d"), "Soy" },
                    { new Guid("6fdb3e1d-f7a6-495a-a8b8-959bd7a50643"), "Dairy" },
                    { new Guid("76af8563-5e2f-4153-8afd-65868ae658c3"), "Eggs" },
                    { new Guid("8b1fc317-a0ba-426c-9c10-f59fcd51c80b"), "Wheat" },
                    { new Guid("9b01ac9e-57f3-4f71-a2aa-716c5af15b45"), "Sesame" },
                    { new Guid("abda2732-a133-4c11-8022-6d69d2c1f92e"), "Fish" },
                    { new Guid("c677beed-6b44-4d69-94c0-bcb49b8b8d90"), "Tree Nuts" },
                    { new Guid("e863aab7-53f5-4b00-80b8-7ebf64c01837"), "Shellfish" },
                    { new Guid("e9abe9ca-1d14-491d-a347-4f2306238b0b"), "Peanuts" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("152c0439-f23b-46fa-ac9c-316cc2128cfb"), "Herbs and Spices" },
                    { new Guid("2a66f59e-6642-4fcf-9bdf-0e65f32479e5"), "Oils and Fats" },
                    { new Guid("407b83da-9c2f-48d0-aef4-6c9261e399c2"), "Nuts and Seeds" },
                    { new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Fruits" },
                    { new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Vegetables" },
                    { new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"), "Grains and Legumes" },
                    { new Guid("cd71e4bc-edee-4c69-b07c-af61f01857aa"), "Baking Ingredients" },
                    { new Guid("f5f004f2-b397-426c-a6b1-656b3f86028c"), "Dairy" },
                    { new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Meats" }
                });

            migrationBuilder.InsertData(
                table: "KitchenEquipments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08ec717d-c1b9-443c-a856-3df040903ea4"), "Pressure Cooker" },
                    { new Guid("0b427dc0-5e2a-4efb-8627-9a5577d669b7"), "Slow Cooker" },
                    { new Guid("0e506411-c8ef-48ef-a9da-2d92ca1ccd54"), "Food Processor" },
                    { new Guid("147e57e6-1ca4-4948-8019-cbdf2df5e63c"), "Oven" },
                    { new Guid("5ae4800e-83f2-4e61-be75-2d9403ba39ed"), "Mixer" },
                    { new Guid("7186f2ef-fda1-44ae-acc1-c41f7f3ae4a5"), "Grill" },
                    { new Guid("7e1bcf1e-1617-4158-b6af-7c278f7e20e0"), "Toaster" },
                    { new Guid("c47f43fa-1a7e-4baf-84ef-80c228d25063"), "Air Fryer" },
                    { new Guid("e0b43d96-ef89-4487-8f30-aadafb4c4a4f"), "Stove" },
                    { new Guid("eb0f331e-c059-450f-a171-3e726f418b3e"), "Microwave" },
                    { new Guid("f0d53cd9-8b91-4c69-b0ea-fb56feec4b58"), "Rice Cooker" },
                    { new Guid("fb4f8642-3f9f-47d1-a77c-9b0aa92db190"), "Blender" }
                });

            migrationBuilder.InsertData(
                table: "FoodSubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("064d6d24-4756-42ec-95f4-1876aee96960"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Dried Fruits" },
                    { new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2"), new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"), "Rice" },
                    { new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa"), new Guid("152c0439-f23b-46fa-ac9c-316cc2128cfb"), "Spices" },
                    { new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d"), new Guid("f5f004f2-b397-426c-a6b1-656b3f86028c"), "Other Dairy" },
                    { new Guid("2319c3e5-1513-4bd4-b742-d997af53c0c1"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Melons" },
                    { new Guid("266b6421-569f-482d-a89b-37a0e0a09a22"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Nightshades" },
                    { new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Allium Vegetables" },
                    { new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Leafy Greens" },
                    { new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0"), new Guid("407b83da-9c2f-48d0-aef4-6c9261e399c2"), "Nuts" },
                    { new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0"), new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"), "Other Grains" },
                    { new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28"), new Guid("cd71e4bc-edee-4c69-b07c-af61f01857aa"), "Sugars" },
                    { new Guid("52e56aaa-0a32-467e-9848-61869027a81c"), new Guid("152c0439-f23b-46fa-ac9c-316cc2128cfb"), "Herbs" },
                    { new Guid("66c2848b-8c33-4214-a8f9-3e18aec268be"), new Guid("cd71e4bc-edee-4c69-b07c-af61f01857aa"), "Baking Ingredients" },
                    { new Guid("7866c57f-6fe6-463a-b527-db597b292d77"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Tropical Fruits" },
                    { new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Berries" },
                    { new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2"), new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"), "Pasta" },
                    { new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce"), new Guid("2a66f59e-6642-4fcf-9bdf-0e65f32479e5"), "Oils" },
                    { new Guid("9e1b3304-424b-43c2-a5d2-5c04536e02fc"), new Guid("f5f004f2-b397-426c-a6b1-656b3f86028c"), "Milk" },
                    { new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Root Vegetables" },
                    { new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d"), new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"), "Legumes" },
                    { new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Stone Fruits" },
                    { new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Cruciferous Vegetables" },
                    { new Guid("ca387376-76c1-4bc9-a614-a94813a8fabe"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Pome Fruits" },
                    { new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68"), new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Fish" },
                    { new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3"), new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Poultry" },
                    { new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca"), new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"), "Squash Vegetables" },
                    { new Guid("ed293930-c956-4410-aed7-e6a14077ea05"), new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Beef" },
                    { new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f"), new Guid("f5f004f2-b397-426c-a6b1-656b3f86028c"), "Cheese" },
                    { new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4"), new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Pork" },
                    { new Guid("f612edc2-c205-4199-9e80-efe2df479133"), new Guid("407b83da-9c2f-48d0-aef4-6c9261e399c2"), "Seeds" },
                    { new Guid("f64a061c-56e4-4c90-8a59-624536e16f22"), new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"), "Citrus Fruits" },
                    { new Guid("f794b537-f497-49af-9b5c-86adf62e3346"), new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"), "Shellfish" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "Caption", "Carbohydrates", "CreatedDate", "DeletedDate", "Fats", "IsDeleted", "ModifiedDate", "Proteins", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("03624fbe-28d3-4c92-8f86-cd916d22f4b7"), null, "Cauliflower", null, null, null, null, false, null, null, new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3") },
                    { new Guid("03e9dbd6-572f-443d-bc4d-0c4a927de86e"), null, "Tomatoes", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("05ec82c5-3c01-43b5-83e5-db020bde7ab1"), null, "Leeks", null, null, null, null, false, null, null, new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874") },
                    { new Guid("068655e7-3498-4fc7-a62a-5a23f1cf7e73"), null, "Quinces", null, null, null, null, false, null, null, new Guid("ca387376-76c1-4bc9-a614-a94813a8fabe") },
                    { new Guid("098bab42-aa17-4a22-aea5-b34f9587ada1"), null, "Pistachios", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("0ac09a19-2abb-4d4e-b8c1-04536921767c"), null, "Eggplants", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("0c916de7-5c83-4b9f-a5d4-b023d799f1be"), null, "Habaneros", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("0faa160c-015b-4c9f-8ddd-30a9f71d1d9a"), null, "Spinach", null, null, null, null, false, null, null, new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb") },
                    { new Guid("0fbc4f08-20ea-49b7-b3a1-86e7fcadeb28"), null, "Nectarines", null, null, null, null, false, null, null, new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84") },
                    { new Guid("11703429-c37a-4289-89bc-f5fb7ec1be7e"), null, "Steaks", null, null, null, null, false, null, null, new Guid("ed293930-c956-4410-aed7-e6a14077ea05") },
                    { new Guid("11a4fec3-3182-4151-b773-2e744d07c246"), null, "Swiss", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("12bddf12-4138-401d-86ca-e358b4092ac5"), null, "Basmati Rice", null, null, null, null, false, null, null, new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2") },
                    { new Guid("13707ae6-7afc-48eb-924d-9806857d6959"), null, "Cherries", null, null, null, null, false, null, null, new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84") },
                    { new Guid("15333872-b685-4a55-a3f7-c3c6e4d9fd3a"), null, "Sunflower Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("1620b618-1284-41d4-8457-f7f177fa0c1b"), null, "Low-Fat Milk", null, null, null, null, false, null, null, new Guid("9e1b3304-424b-43c2-a5d2-5c04536e02fc") },
                    { new Guid("16598214-92ee-492f-9896-fcdc38b6372f"), null, "Butternut Squash", null, null, null, null, false, null, null, new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca") },
                    { new Guid("17ba6c04-17ec-4a7b-86a4-1194c21734ad"), null, "Chicken Thighs", null, null, null, null, false, null, null, new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3") },
                    { new Guid("1831691f-ead2-49db-9e7e-4ae9f7689021"), null, "Garlic", null, null, null, null, false, null, null, new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874") },
                    { new Guid("1943a882-a806-4c57-b7b3-9bc041d6dc46"), null, "Quinoa", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("1b75e4d7-4044-44b3-b052-9c913ef63717"), null, "Parsley", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("20ee83a6-d333-4612-88ba-0ba6f79ef269"), null, "Watermelons", null, null, null, null, false, null, null, new Guid("2319c3e5-1513-4bd4-b742-d997af53c0c1") },
                    { new Guid("23dcc76e-1580-4453-83d3-d68eba91f4f9"), null, "Mint", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("2514b3c3-5659-4560-b959-18ca9fe3f9b1"), null, "Brown Sugar", null, null, null, null, false, null, null, new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28") },
                    { new Guid("25e1377b-b322-482a-80ec-b678a895fef1"), null, "Cabbage", null, null, null, null, false, null, null, new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3") },
                    { new Guid("261684a7-8194-4d5f-8214-6e844a8a0ebb"), null, "Chia Seeds", null, null, null, null, false, null, null, new Guid("f612edc2-c205-4199-9e80-efe2df479133") },
                    { new Guid("26cb68ca-73d4-4075-a6f0-9c4b2674e94a"), null, "Granulated Sugar", null, null, null, null, false, null, null, new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28") },
                    { new Guid("2779cefa-c969-480c-b3e0-bc716bbab991"), null, "Millet", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("2def3cc3-c903-4f67-be31-7c9a9b10481b"), null, "Turmeric", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("2e779678-fbe2-4451-a329-b6d23f7741de"), null, "Pork Loins", null, null, null, null, false, null, null, new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4") },
                    { new Guid("32729e73-2154-445c-b02e-0179ee532a96"), null, "Papayas", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("32a23df1-cace-4be9-bb5b-859fb06dc13c"), null, "Vegetable Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("356e77fb-d8a4-47cc-8c91-7fd0ac837381"), null, "Plums", null, null, null, null, false, null, null, new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84") },
                    { new Guid("35e2b68b-743b-4358-b53d-09e00dc9f0c2"), null, "Feta", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("389fb025-8382-4099-81f9-45a03a27c068"), null, "Grapefruits", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("38ff4b9b-3dcc-4990-8c7a-0fb4241371e4"), null, "Salt", null, null, null, null, false, null, null, new Guid("66c2848b-8c33-4214-a8f9-3e18aec268be") },
                    { new Guid("3a6c0fda-110c-4964-9f1a-c0381981a1c6"), null, "Black Pepper", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("3ac29a1d-4379-4d5e-a1d0-0e94b3d4a021"), null, "Parsnips", null, null, null, null, false, null, null, new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273") },
                    { new Guid("3af9ace0-a404-4584-999a-5c79277a1d85"), null, "Goat Cheese", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("3b16168e-ecf3-4aaa-a195-529f3e9a01f6"), null, "Maple Syrup", null, null, null, null, false, null, null, new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28") },
                    { new Guid("3b8f4b1a-4674-4b6a-ac50-ffc42fd1ae36"), null, "Pumpkin", null, null, null, null, false, null, null, new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca") },
                    { new Guid("3b94407d-259b-4520-9d82-e0140e749251"), null, "Ground Chicken", null, null, null, null, false, null, null, new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3") },
                    { new Guid("3be8ed78-b214-4c03-9f28-bce590df0847"), null, "Carrots", null, null, null, null, false, null, null, new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273") },
                    { new Guid("404dd8d9-baad-4b55-8bf0-9e7e28ba6c15"), null, "Thyme", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("4096eba5-15b0-4165-a32b-58fa53e5b4f9"), null, "Swiss Chard", null, null, null, null, false, null, null, new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb") },
                    { new Guid("40ac2a45-70da-423d-b7f6-e86176330bff"), null, "Avocado Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("41130a6e-691a-48a6-8ad6-6109c8cd1812"), null, "Egg Noodles", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("41b1c772-a3a4-4a44-860b-3d161f5a7a69"), null, "Cilantro", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("437976bf-7357-410b-82aa-9e99f110c0c7"), null, "Tangerines", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("451d9e40-c7d4-47ed-9f15-3d5e978c8786"), null, "Honeydews", null, null, null, null, false, null, null, new Guid("2319c3e5-1513-4bd4-b742-d997af53c0c1") },
                    { new Guid("484761be-28dc-4994-8804-175ff106cb7b"), null, "Coriander", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("485f5327-1685-4404-85f0-70662411513d"), null, "Cantaloupes", null, null, null, null, false, null, null, new Guid("2319c3e5-1513-4bd4-b742-d997af53c0c1") },
                    { new Guid("49715232-edda-4f89-8f67-a16e1a48ca2d"), null, "Ground Pork", null, null, null, null, false, null, null, new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4") },
                    { new Guid("4c8903a7-4087-463a-8acc-b23c0af0fe21"), null, "Apricots", null, null, null, null, false, null, null, new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84") },
                    { new Guid("4d660cb1-4f3b-4d42-aa95-b51705dc8551"), null, "Macadamia Nuts", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("4ec3d68a-7375-43a2-9372-5c69f4e2ded0"), null, "Peanuts", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("507e5c5c-5bae-4774-96d3-e95d26331be4"), null, "Dill", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("54f5f6ad-a674-4b60-99b9-6e5389b80e09"), null, "Serrano Peppers", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("56d4b8e9-3893-4f30-8e36-261a3682e4c4"), null, "Bananas", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("594ffecc-31b3-4bfd-af7a-915f91514730"), null, "Lettuce", null, null, null, null, false, null, null, new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb") },
                    { new Guid("5c81cd2a-7f95-4b4a-b3f6-4c59268844d1"), null, "Lobster", null, null, null, null, false, null, null, new Guid("f794b537-f497-49af-9b5c-86adf62e3346") },
                    { new Guid("5dea68fe-f8d2-4f2a-bb10-01d42251128f"), null, "Cinnamon", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("5e1ad11f-5234-42e2-87e2-dd60ea1bc019"), null, "Macaroni", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("5ede5194-a12c-4524-a841-0bb05e2527b5"), null, "Pumpkin Seeds", null, null, null, null, false, null, null, new Guid("f612edc2-c205-4199-9e80-efe2df479133") },
                    { new Guid("5f0e4611-342f-4382-b4f3-354c3410bab8"), null, "Peaches", null, null, null, null, false, null, null, new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84") },
                    { new Guid("634e43e1-3942-4cbf-b346-c0897e1ff53a"), null, "Raspberries", null, null, null, null, false, null, null, new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e") },
                    { new Guid("6437a9ae-68c1-4396-986e-e35a7df1826c"), null, "Mozzarella", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("65631f27-7f80-42e9-81ac-53db4c22fd25"), null, "Buckwheat", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("6641308a-e5d0-449b-af4e-e0bc7fe0b175"), null, "Polenta", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("674cc146-fdd1-44b6-ae53-a23e82d020d9"), null, "Kidney Beans", null, null, null, null, false, null, null, new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d") },
                    { new Guid("6e07aeea-f52c-4eeb-a1c9-0d7b9c4deec6"), null, "Paprika", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("6f13d463-106b-4ddf-a38a-92d1a596c6df"), null, "Shallots", null, null, null, null, false, null, null, new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874") },
                    { new Guid("7110aa5b-f7ce-4258-bab1-e0ce8b4abd7d"), null, "Crab", null, null, null, null, false, null, null, new Guid("f794b537-f497-49af-9b5c-86adf62e3346") },
                    { new Guid("72f2f7e7-b4d4-48e7-b646-44812ca0a19c"), null, "Chickpeas", null, null, null, null, false, null, null, new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d") },
                    { new Guid("754ce6c9-7382-4242-b3ef-5a343542ef17"), null, "Green Onions", null, null, null, null, false, null, null, new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874") },
                    { new Guid("7637fb38-a2bf-4370-a2ef-89306422aecb"), null, "Roasts", null, null, null, null, false, null, null, new Guid("ed293930-c956-4410-aed7-e6a14077ea05") },
                    { new Guid("76ac7a2a-e376-49e2-b691-74474becf147"), null, "Heavy Cream", null, null, null, null, false, null, null, new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d") },
                    { new Guid("78af7fea-67f0-4f5d-8b96-1ce60c695558"), null, "Penne", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("7981fec8-5014-469c-bb79-bd91e9ff6106"), null, "White Rice", null, null, null, null, false, null, null, new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2") },
                    { new Guid("799d1618-0e42-4481-9729-d7dca9a51df2"), null, "Haddock", null, null, null, null, false, null, null, new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68") },
                    { new Guid("7cf2ac41-51c3-4f2c-a9b4-847ad4e21e19"), null, "Passion Fruit", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("7dfe3501-100e-45f1-b1f9-b454a21d2f83"), null, "Jasmine Rice", null, null, null, null, false, null, null, new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2") },
                    { new Guid("805e5101-7927-4f00-8117-cd75356fc268"), null, "Baking Powder", null, null, null, null, false, null, null, new Guid("66c2848b-8c33-4214-a8f9-3e18aec268be") },
                    { new Guid("8064746f-a073-4e53-b1a9-f287a3afc2bb"), null, "Cranberries", null, null, null, null, false, null, null, new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e") },
                    { new Guid("83851591-e34f-41be-8c49-aac308a4f1bd"), null, "Pears", null, null, null, null, false, null, null, new Guid("ca387376-76c1-4bc9-a614-a94813a8fabe") },
                    { new Guid("84c5199f-07f5-4bce-a440-d13d0befab06"), null, "Cheddar", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("85be50e5-271f-470d-9f67-c42741fedcba"), null, "Shrimp", null, null, null, null, false, null, null, new Guid("f794b537-f497-49af-9b5c-86adf62e3346") },
                    { new Guid("8730f1fb-87b2-4be0-922e-2ddd4e3c6089"), null, "Ground Beef", null, null, null, null, false, null, null, new Guid("ed293930-c956-4410-aed7-e6a14077ea05") },
                    { new Guid("88df1eba-9faa-4deb-b95c-24ee2598b802"), null, "Mangoes", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("8a97676a-fd90-4b63-b411-1aac6515ce50"), null, "Cod", null, null, null, null, false, null, null, new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68") },
                    { new Guid("8ac4ca6c-761a-4040-9701-de0b6fd4ec32"), null, "Zucchini", null, null, null, null, false, null, null, new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca") },
                    { new Guid("8b1179ad-4c4a-4af5-9534-95ce53c31885"), null, "Dried Apricots", null, null, null, null, false, null, null, new Guid("064d6d24-4756-42ec-95f4-1876aee96960") },
                    { new Guid("8e90e196-9662-4755-972d-492a9490536c"), null, "Salmon", null, null, null, null, false, null, null, new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68") },
                    { new Guid("93b6d22c-23f2-47df-877e-de95fa51c00d"), null, "Baking Soda", null, null, null, null, false, null, null, new Guid("66c2848b-8c33-4214-a8f9-3e18aec268be") },
                    { new Guid("945342f9-105a-4d3f-abb0-185646fa4aa4"), null, "Clementines", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("95effc8d-6d56-4e65-86f7-749a887ca0a9"), null, "Spaghetti", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("976b275e-177d-48d9-9fbe-34397bed9208"), null, "Cashews", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("98422ecd-6460-48eb-b14e-498226e060b8"), null, "Coconut Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("98793890-c690-4471-bec0-98a8893394d4"), null, "Limes", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("989416a9-9f1c-4a4d-a91b-07723fccda26"), null, "Ginger", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("996d2c07-414c-4a73-a75d-50c0e39e606c"), null, "Rice Noodles", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("999eccde-1e8f-4215-8f17-dbef93a2778b"), null, "Whole Milk", null, null, null, null, false, null, null, new Guid("9e1b3304-424b-43c2-a5d2-5c04536e02fc") },
                    { new Guid("9c9b2e42-a245-42b9-a5a1-66ba3317fe20"), null, "Oranges", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("9ed08006-8085-4993-8d0a-d524ed5c86cc"), null, "Pecans", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("a11bb48b-7a87-49c9-8bbf-53a66a3a9e74"), null, "Brown Rice", null, null, null, null, false, null, null, new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2") },
                    { new Guid("a1b9f08e-02ea-41ce-91ce-bec69e296bc3"), null, "Pineapples", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("a234e820-02b3-4161-b43f-ebb0ed206509"), null, "Onions", null, null, null, null, false, null, null, new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874") },
                    { new Guid("a31be609-8f4f-40f1-97d3-c8f7ac025ca1"), null, "Ricotta", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("a3e9072d-4788-4359-b6b7-932e01606e99"), null, "Chili Peppers", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("a409da49-7ab0-4dd0-a0ba-2220cd49b757"), null, "Flaxseeds", null, null, null, null, false, null, null, new Guid("f612edc2-c205-4199-9e80-efe2df479133") },
                    { new Guid("a48a2e58-c1fd-4edb-ad61-4cbe9f749c0e"), null, "Sesame Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("a5f38bf2-98d2-4334-ab4f-306f06ec5fbf"), null, "Jalapenos", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("a66b8550-ac27-4e68-aef6-6af221c8a278"), null, "Bell Peppers", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("a6eecebc-1e7f-4395-837c-c587db7f2ebf"), null, "Rosemary", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("a81eb272-e8a7-4aed-b887-38ccdebee565"), null, "Walnuts", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("a905a872-980c-4cc3-b19b-371774fac6b0"), null, "Strawberries", null, null, null, null, false, null, null, new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e") },
                    { new Guid("aa087248-3dbf-4f52-832e-5e4dc83c3e58"), null, "Parmesan", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("aecf4946-e60a-4307-b8f2-8680238f9312"), null, "Pinto Beans", null, null, null, null, false, null, null, new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d") },
                    { new Guid("af265133-d7ed-4541-ac1c-c04322adf025"), null, "Honey", null, null, null, null, false, null, null, new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28") },
                    { new Guid("b006772e-f881-4ae2-92e2-6a5bca0381e8"), null, "Rye", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("b0542fac-e936-41d3-bf13-bf6b6654d422"), null, "Chicken Breasts", null, null, null, null, false, null, null, new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3") },
                    { new Guid("b1f17cd0-704a-46dd-b240-2eed6aa8107b"), null, "Arborio Rice", null, null, null, null, false, null, null, new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2") },
                    { new Guid("b3f10d3c-86b4-4268-a2ac-58bfa2754a04"), null, "Basil", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("b432fb6a-f64a-4f1b-964b-c8d827a2da29"), null, "Grape Tomatoes", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("b62b5e11-7a53-4a63-9ba6-db44c3745292"), null, "Greek Yogurt", null, null, null, null, false, null, null, new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d") },
                    { new Guid("b65b7374-0682-4c6f-872a-3c4a3f6fb8e5"), null, "Cherry Tomatoes", null, null, null, null, false, null, null, new Guid("266b6421-569f-482d-a89b-37a0e0a09a22") },
                    { new Guid("b7d395ae-80d9-4edb-8c6b-d112092b8451"), null, "Brie", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("b8adf6b7-119e-4355-be36-5290c75aa670"), null, "Broccoli", null, null, null, null, false, null, null, new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3") },
                    { new Guid("bbcc7619-429e-4301-a471-6a1aee3d6b43"), null, "Blackberries", null, null, null, null, false, null, null, new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e") },
                    { new Guid("bc84d881-1e57-493f-a58c-63d9f5b92ab0"), null, "Black Beans", null, null, null, null, false, null, null, new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d") },
                    { new Guid("bce02461-2fbe-4f9d-acf3-4a9326febb05"), null, "Salted Butter", null, null, null, null, false, null, null, new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d") },
                    { new Guid("be316df3-4f67-40db-89c9-4289c435ba61"), null, "Oregano", null, null, null, null, false, null, null, new Guid("52e56aaa-0a32-467e-9848-61869027a81c") },
                    { new Guid("c13bbc52-af0a-47e2-8ba2-3e9e7e974621"), null, "Scallops", null, null, null, null, false, null, null, new Guid("f794b537-f497-49af-9b5c-86adf62e3346") },
                    { new Guid("c60dee4c-49c2-45c4-a588-aac185a9e9e1"), null, "Soba Noodles", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("c8bf34a5-ff0d-4018-a31c-0c2c36abda23"), null, "Apples", null, null, null, null, false, null, null, new Guid("ca387376-76c1-4bc9-a614-a94813a8fabe") },
                    { new Guid("cb77114b-3276-4fef-b2fa-4fbe1c02376c"), null, "Dates", null, null, null, null, false, null, null, new Guid("064d6d24-4756-42ec-95f4-1876aee96960") },
                    { new Guid("cbe311a3-ace0-4b20-90a2-6c12afe6cd79"), null, "Tuna", null, null, null, null, false, null, null, new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68") },
                    { new Guid("cc691bab-d807-40a6-a294-f11ded4b29b6"), null, "Sunflower Seeds", null, null, null, null, false, null, null, new Guid("f612edc2-c205-4199-9e80-efe2df479133") },
                    { new Guid("cdaa46d4-e876-4683-a89f-070eeb75fce7"), null, "Olive Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("ce168bbf-e21e-412e-98ad-91efbf32c745"), null, "Bacon", null, null, null, null, false, null, null, new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4") },
                    { new Guid("ceccf846-46ce-4077-a99c-564be5d811db"), null, "Sour Cream", null, null, null, null, false, null, null, new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d") },
                    { new Guid("d184d6ba-fddf-4284-865d-780b2e291573"), null, "Barley", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("d2657c3b-debc-47cb-99ab-48914ff2dd48"), null, "Acorn Squash", null, null, null, null, false, null, null, new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca") },
                    { new Guid("d3ab2f68-0890-4335-951e-e7be8925049d"), null, "Chili Powder", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("d4b336d6-e995-45b4-b0ee-917a58df7ebe"), null, "Kale", null, null, null, null, false, null, null, new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb") },
                    { new Guid("d4eea46d-2aa2-449a-92a6-961ae7259e01"), null, "Lentils", null, null, null, null, false, null, null, new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d") },
                    { new Guid("d7d2de64-c5e8-478f-93e7-a16a6285e799"), null, "Brussels Sprouts", null, null, null, null, false, null, null, new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3") },
                    { new Guid("dafc55ff-71d7-4d7a-b109-9f989a7a878c"), null, "Cumin", null, null, null, null, false, null, null, new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa") },
                    { new Guid("dc17cecc-0e51-44e0-8132-f2ccd3882ed9"), null, "Cornmeal", null, null, null, null, false, null, null, new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0") },
                    { new Guid("e06e6982-2b7e-45f1-8204-ffe2a3f756fc"), null, "Ham", null, null, null, null, false, null, null, new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4") },
                    { new Guid("e1403cee-8736-4548-b91a-47ecd078751a"), null, "Canola Oil", null, null, null, null, false, null, null, new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce") },
                    { new Guid("e155c68e-3b5b-4c9b-875e-48c4d4e7da05"), null, "Chicken Wings", null, null, null, null, false, null, null, new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3") },
                    { new Guid("e22f604c-55fe-4764-a8f2-21d75860cc87"), null, "Guavas", null, null, null, null, false, null, null, new Guid("7866c57f-6fe6-463a-b527-db597b292d77") },
                    { new Guid("e41c4dfe-8332-49ae-8ba9-426f0557d0a8"), null, "Turnips", null, null, null, null, false, null, null, new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273") },
                    { new Guid("e5167ee1-de85-48a6-9d0e-af209f24e99a"), null, "Cottage Cheese", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("e55d80dc-6d2a-4800-a6e6-0d1809665f31"), null, "Arugula", null, null, null, null, false, null, null, new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb") },
                    { new Guid("e66595d8-4b8c-42a2-9f15-5f1dc7651c7e"), null, "Fusilli", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("e6eb5d42-fbfd-4f3e-bff1-9a823a383c09"), null, "Almonds", null, null, null, null, false, null, null, new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0") },
                    { new Guid("e78dcd2c-9c0b-43bd-a774-1a6cd17023f4"), null, "Yellow Squash", null, null, null, null, false, null, null, new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca") },
                    { new Guid("edc5b150-ad47-46c5-90d0-92338730a7f5"), null, "Lemons", null, null, null, null, false, null, null, new Guid("f64a061c-56e4-4c90-8a59-624536e16f22") },
                    { new Guid("f2d75ddb-6f0a-4a28-b8af-70a65ebfd311"), null, "Cream Cheese", null, null, null, null, false, null, null, new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f") },
                    { new Guid("f344c5fd-9f62-4811-b8df-1ff2c4809807"), null, "Blueberries", null, null, null, null, false, null, null, new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e") },
                    { new Guid("f45a7adc-4720-4a66-aacf-1c4b08157655"), null, "Radishes", null, null, null, null, false, null, null, new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273") },
                    { new Guid("f53017e2-0a0e-4175-9222-c93bf10dfa71"), null, "Bok Choy", null, null, null, null, false, null, null, new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3") },
                    { new Guid("f59456e5-30db-4f5b-9dc6-535551352efe"), null, "Pork Chops", null, null, null, null, false, null, null, new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4") },
                    { new Guid("f5ea5eb2-0bc0-46b3-917b-87e3d069a403"), null, "Raisins", null, null, null, null, false, null, null, new Guid("064d6d24-4756-42ec-95f4-1876aee96960") },
                    { new Guid("f748398e-da5f-4e91-9f7c-a9c25fb24d59"), null, "Skim Milk", null, null, null, null, false, null, null, new Guid("9e1b3304-424b-43c2-a5d2-5c04536e02fc") },
                    { new Guid("f906738b-a8da-4927-8e03-8f3353eafb13"), null, "Lasagna Sheets", null, null, null, null, false, null, null, new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2") },
                    { new Guid("fae7fe21-a2ba-4dd9-812f-f33212b11abb"), null, "Unsalted Butter", null, null, null, null, false, null, null, new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d") },
                    { new Guid("fb34dac2-68c8-494b-ba1b-cee141687dfb"), null, "Beets", null, null, null, null, false, null, null, new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyMeals_MealPlanId",
                table: "DailyMeals",
                column: "MealPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MealId",
                table: "Ingredients",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DailyMealsId",
                table: "Meals",
                column: "DailyMealsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "DailyMeals");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("4af58e1b-fbee-412e-a80f-3f6a41c1edf5"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("621df475-35ac-4c46-b89a-a17a2bc7632d"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("6fdb3e1d-f7a6-495a-a8b8-959bd7a50643"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("76af8563-5e2f-4153-8afd-65868ae658c3"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("8b1fc317-a0ba-426c-9c10-f59fcd51c80b"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("9b01ac9e-57f3-4f71-a2aa-716c5af15b45"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("abda2732-a133-4c11-8022-6d69d2c1f92e"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("c677beed-6b44-4d69-94c0-bcb49b8b8d90"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e863aab7-53f5-4b00-80b8-7ebf64c01837"));

            migrationBuilder.DeleteData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: new Guid("e9abe9ca-1d14-491d-a347-4f2306238b0b"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("08ec717d-c1b9-443c-a856-3df040903ea4"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("0b427dc0-5e2a-4efb-8627-9a5577d669b7"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("0e506411-c8ef-48ef-a9da-2d92ca1ccd54"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("147e57e6-1ca4-4948-8019-cbdf2df5e63c"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("5ae4800e-83f2-4e61-be75-2d9403ba39ed"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("7186f2ef-fda1-44ae-acc1-c41f7f3ae4a5"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("7e1bcf1e-1617-4158-b6af-7c278f7e20e0"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("c47f43fa-1a7e-4baf-84ef-80c228d25063"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("e0b43d96-ef89-4487-8f30-aadafb4c4a4f"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("eb0f331e-c059-450f-a171-3e726f418b3e"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("f0d53cd9-8b91-4c69-b0ea-fb56feec4b58"));

            migrationBuilder.DeleteData(
                table: "KitchenEquipments",
                keyColumn: "Id",
                keyValue: new Guid("fb4f8642-3f9f-47d1-a77c-9b0aa92db190"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03624fbe-28d3-4c92-8f86-cd916d22f4b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03e9dbd6-572f-443d-bc4d-0c4a927de86e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05ec82c5-3c01-43b5-83e5-db020bde7ab1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("068655e7-3498-4fc7-a62a-5a23f1cf7e73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098bab42-aa17-4a22-aea5-b34f9587ada1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ac09a19-2abb-4d4e-b8c1-04536921767c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c916de7-5c83-4b9f-a5d4-b023d799f1be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0faa160c-015b-4c9f-8ddd-30a9f71d1d9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fbc4f08-20ea-49b7-b3a1-86e7fcadeb28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11703429-c37a-4289-89bc-f5fb7ec1be7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11a4fec3-3182-4151-b773-2e744d07c246"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12bddf12-4138-401d-86ca-e358b4092ac5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13707ae6-7afc-48eb-924d-9806857d6959"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15333872-b685-4a55-a3f7-c3c6e4d9fd3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1620b618-1284-41d4-8457-f7f177fa0c1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16598214-92ee-492f-9896-fcdc38b6372f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17ba6c04-17ec-4a7b-86a4-1194c21734ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1831691f-ead2-49db-9e7e-4ae9f7689021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1943a882-a806-4c57-b7b3-9bc041d6dc46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b75e4d7-4044-44b3-b052-9c913ef63717"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20ee83a6-d333-4612-88ba-0ba6f79ef269"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23dcc76e-1580-4453-83d3-d68eba91f4f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2514b3c3-5659-4560-b959-18ca9fe3f9b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25e1377b-b322-482a-80ec-b678a895fef1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("261684a7-8194-4d5f-8214-6e844a8a0ebb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26cb68ca-73d4-4075-a6f0-9c4b2674e94a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2779cefa-c969-480c-b3e0-bc716bbab991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2def3cc3-c903-4f67-be31-7c9a9b10481b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e779678-fbe2-4451-a329-b6d23f7741de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32729e73-2154-445c-b02e-0179ee532a96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32a23df1-cace-4be9-bb5b-859fb06dc13c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("356e77fb-d8a4-47cc-8c91-7fd0ac837381"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e2b68b-743b-4358-b53d-09e00dc9f0c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("389fb025-8382-4099-81f9-45a03a27c068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38ff4b9b-3dcc-4990-8c7a-0fb4241371e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a6c0fda-110c-4964-9f1a-c0381981a1c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ac29a1d-4379-4d5e-a1d0-0e94b3d4a021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3af9ace0-a404-4584-999a-5c79277a1d85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b16168e-ecf3-4aaa-a195-529f3e9a01f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b8f4b1a-4674-4b6a-ac50-ffc42fd1ae36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b94407d-259b-4520-9d82-e0140e749251"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3be8ed78-b214-4c03-9f28-bce590df0847"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("404dd8d9-baad-4b55-8bf0-9e7e28ba6c15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4096eba5-15b0-4165-a32b-58fa53e5b4f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40ac2a45-70da-423d-b7f6-e86176330bff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41130a6e-691a-48a6-8ad6-6109c8cd1812"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41b1c772-a3a4-4a44-860b-3d161f5a7a69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("437976bf-7357-410b-82aa-9e99f110c0c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("451d9e40-c7d4-47ed-9f15-3d5e978c8786"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("484761be-28dc-4994-8804-175ff106cb7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485f5327-1685-4404-85f0-70662411513d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49715232-edda-4f89-8f67-a16e1a48ca2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c8903a7-4087-463a-8acc-b23c0af0fe21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d660cb1-4f3b-4d42-aa95-b51705dc8551"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ec3d68a-7375-43a2-9372-5c69f4e2ded0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("507e5c5c-5bae-4774-96d3-e95d26331be4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54f5f6ad-a674-4b60-99b9-6e5389b80e09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56d4b8e9-3893-4f30-8e36-261a3682e4c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("594ffecc-31b3-4bfd-af7a-915f91514730"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c81cd2a-7f95-4b4a-b3f6-4c59268844d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dea68fe-f8d2-4f2a-bb10-01d42251128f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e1ad11f-5234-42e2-87e2-dd60ea1bc019"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ede5194-a12c-4524-a841-0bb05e2527b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f0e4611-342f-4382-b4f3-354c3410bab8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("634e43e1-3942-4cbf-b346-c0897e1ff53a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6437a9ae-68c1-4396-986e-e35a7df1826c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65631f27-7f80-42e9-81ac-53db4c22fd25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6641308a-e5d0-449b-af4e-e0bc7fe0b175"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("674cc146-fdd1-44b6-ae53-a23e82d020d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e07aeea-f52c-4eeb-a1c9-0d7b9c4deec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f13d463-106b-4ddf-a38a-92d1a596c6df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7110aa5b-f7ce-4258-bab1-e0ce8b4abd7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72f2f7e7-b4d4-48e7-b646-44812ca0a19c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("754ce6c9-7382-4242-b3ef-5a343542ef17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7637fb38-a2bf-4370-a2ef-89306422aecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76ac7a2a-e376-49e2-b691-74474becf147"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78af7fea-67f0-4f5d-8b96-1ce60c695558"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7981fec8-5014-469c-bb79-bd91e9ff6106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("799d1618-0e42-4481-9729-d7dca9a51df2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cf2ac41-51c3-4f2c-a9b4-847ad4e21e19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dfe3501-100e-45f1-b1f9-b454a21d2f83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("805e5101-7927-4f00-8117-cd75356fc268"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8064746f-a073-4e53-b1a9-f287a3afc2bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83851591-e34f-41be-8c49-aac308a4f1bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84c5199f-07f5-4bce-a440-d13d0befab06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85be50e5-271f-470d-9f67-c42741fedcba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8730f1fb-87b2-4be0-922e-2ddd4e3c6089"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88df1eba-9faa-4deb-b95c-24ee2598b802"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a97676a-fd90-4b63-b411-1aac6515ce50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ac4ca6c-761a-4040-9701-de0b6fd4ec32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b1179ad-4c4a-4af5-9534-95ce53c31885"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e90e196-9662-4755-972d-492a9490536c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93b6d22c-23f2-47df-877e-de95fa51c00d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("945342f9-105a-4d3f-abb0-185646fa4aa4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95effc8d-6d56-4e65-86f7-749a887ca0a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("976b275e-177d-48d9-9fbe-34397bed9208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98422ecd-6460-48eb-b14e-498226e060b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98793890-c690-4471-bec0-98a8893394d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("989416a9-9f1c-4a4d-a91b-07723fccda26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("996d2c07-414c-4a73-a75d-50c0e39e606c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("999eccde-1e8f-4215-8f17-dbef93a2778b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c9b2e42-a245-42b9-a5a1-66ba3317fe20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ed08006-8085-4993-8d0a-d524ed5c86cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11bb48b-7a87-49c9-8bbf-53a66a3a9e74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1b9f08e-02ea-41ce-91ce-bec69e296bc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a234e820-02b3-4161-b43f-ebb0ed206509"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a31be609-8f4f-40f1-97d3-c8f7ac025ca1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3e9072d-4788-4359-b6b7-932e01606e99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a409da49-7ab0-4dd0-a0ba-2220cd49b757"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a48a2e58-c1fd-4edb-ad61-4cbe9f749c0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5f38bf2-98d2-4334-ab4f-306f06ec5fbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a66b8550-ac27-4e68-aef6-6af221c8a278"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6eecebc-1e7f-4395-837c-c587db7f2ebf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a81eb272-e8a7-4aed-b887-38ccdebee565"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a905a872-980c-4cc3-b19b-371774fac6b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa087248-3dbf-4f52-832e-5e4dc83c3e58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aecf4946-e60a-4307-b8f2-8680238f9312"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af265133-d7ed-4541-ac1c-c04322adf025"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b006772e-f881-4ae2-92e2-6a5bca0381e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0542fac-e936-41d3-bf13-bf6b6654d422"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1f17cd0-704a-46dd-b240-2eed6aa8107b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3f10d3c-86b4-4268-a2ac-58bfa2754a04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b432fb6a-f64a-4f1b-964b-c8d827a2da29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b62b5e11-7a53-4a63-9ba6-db44c3745292"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b65b7374-0682-4c6f-872a-3c4a3f6fb8e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7d395ae-80d9-4edb-8c6b-d112092b8451"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8adf6b7-119e-4355-be36-5290c75aa670"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbcc7619-429e-4301-a471-6a1aee3d6b43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc84d881-1e57-493f-a58c-63d9f5b92ab0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bce02461-2fbe-4f9d-acf3-4a9326febb05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be316df3-4f67-40db-89c9-4289c435ba61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c13bbc52-af0a-47e2-8ba2-3e9e7e974621"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c60dee4c-49c2-45c4-a588-aac185a9e9e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8bf34a5-ff0d-4018-a31c-0c2c36abda23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb77114b-3276-4fef-b2fa-4fbe1c02376c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbe311a3-ace0-4b20-90a2-6c12afe6cd79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc691bab-d807-40a6-a294-f11ded4b29b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdaa46d4-e876-4683-a89f-070eeb75fce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce168bbf-e21e-412e-98ad-91efbf32c745"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ceccf846-46ce-4077-a99c-564be5d811db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d184d6ba-fddf-4284-865d-780b2e291573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2657c3b-debc-47cb-99ab-48914ff2dd48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ab2f68-0890-4335-951e-e7be8925049d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4b336d6-e995-45b4-b0ee-917a58df7ebe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4eea46d-2aa2-449a-92a6-961ae7259e01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7d2de64-c5e8-478f-93e7-a16a6285e799"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dafc55ff-71d7-4d7a-b109-9f989a7a878c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc17cecc-0e51-44e0-8132-f2ccd3882ed9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e06e6982-2b7e-45f1-8204-ffe2a3f756fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1403cee-8736-4548-b91a-47ecd078751a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e155c68e-3b5b-4c9b-875e-48c4d4e7da05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e22f604c-55fe-4764-a8f2-21d75860cc87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e41c4dfe-8332-49ae-8ba9-426f0557d0a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5167ee1-de85-48a6-9d0e-af209f24e99a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e55d80dc-6d2a-4800-a6e6-0d1809665f31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e66595d8-4b8c-42a2-9f15-5f1dc7651c7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6eb5d42-fbfd-4f3e-bff1-9a823a383c09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e78dcd2c-9c0b-43bd-a774-1a6cd17023f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edc5b150-ad47-46c5-90d0-92338730a7f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2d75ddb-6f0a-4a28-b8af-70a65ebfd311"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f344c5fd-9f62-4811-b8df-1ff2c4809807"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f45a7adc-4720-4a66-aacf-1c4b08157655"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f53017e2-0a0e-4175-9222-c93bf10dfa71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f59456e5-30db-4f5b-9dc6-535551352efe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ea5eb2-0bc0-46b3-917b-87e3d069a403"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f748398e-da5f-4e91-9f7c-a9c25fb24d59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f906738b-a8da-4927-8e03-8f3353eafb13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fae7fe21-a2ba-4dd9-812f-f33212b11abb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb34dac2-68c8-494b-ba1b-cee141687dfb"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("064d6d24-4756-42ec-95f4-1876aee96960"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("11fc9de4-3343-4b72-934e-43f3f92e1da2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d314eb0-5712-4b63-aa40-2d47e4cf06aa"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f9d0708-6034-49f6-b26b-a725db4f9b5d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2319c3e5-1513-4bd4-b742-d997af53c0c1"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("266b6421-569f-482d-a89b-37a0e0a09a22"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("35438aa0-f6d7-45df-b079-6dd0c69ac874"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("40322d1e-89c1-4011-8d85-5b0d2d652acb"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("45591010-fe3f-4b05-8562-9eb39b62d9c0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4761341e-ae1d-48ed-a00a-69c638aac2c0"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cda1dd9-14f4-4db5-8c89-cff0e104ac28"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("52e56aaa-0a32-467e-9848-61869027a81c"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("66c2848b-8c33-4214-a8f9-3e18aec268be"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7866c57f-6fe6-463a-b527-db597b292d77"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b7712ee-fc3e-4730-9ff9-256d32ca237e"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8720a6b7-6b39-457e-9255-32928dfc00d2"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d0b4824-dddb-42c1-a2cc-5f28a246e0ce"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e1b3304-424b-43c2-a5d2-5c04536e02fc"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b5d85954-7aa0-4e9d-ae9b-0a0dbbe0f273"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9be8e13-c7f1-425f-84bb-abaf23a41c7d"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc5775ea-5234-4a9e-a0a4-5970a79cbf84"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5a74bf4-4e91-49d4-a48e-0bf7bfb60af3"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca387376-76c1-4bc9-a614-a94813a8fabe"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd96c7c4-c6f7-4196-8b70-ce5d26bb6d68"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cfc3ef3b-9732-40c6-96d9-1a8627cb19d3"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d457c48b-cdb5-415b-bc01-56ec2be4caca"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed293930-c956-4410-aed7-e6a14077ea05"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f48032a1-937a-40f8-a62c-d3f5bdeffb5f"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4e52391-0aa8-41d0-baef-1a8a07ad25d4"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f612edc2-c205-4199-9e80-efe2df479133"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f64a061c-56e4-4c90-8a59-624536e16f22"));

            migrationBuilder.DeleteData(
                table: "FoodSubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f794b537-f497-49af-9b5c-86adf62e3346"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("152c0439-f23b-46fa-ac9c-316cc2128cfb"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a66f59e-6642-4fcf-9bdf-0e65f32479e5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("407b83da-9c2f-48d0-aef4-6c9261e399c2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("44753428-5d6f-4065-85a6-23cd5e196c3f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("460eb3f3-4271-44d6-acf9-34d7cb950e5e"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfcb539c-0c8f-4ad8-999c-8d5686c15ab9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd71e4bc-edee-4c69-b07c-af61f01857aa"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5f004f2-b397-426c-a6b1-656b3f86028c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("fbaaed55-3202-49e8-931d-2b03626c246a"));

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    CookingInstructions = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FoodRecipeId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    MeasurmentType = table.Column<int>(type: "integer", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_FoodRecipeId",
                table: "RecipeIngredients",
                column: "FoodRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_ProductId",
                table: "RecipeIngredients",
                column: "ProductId");
        }
    }
}
