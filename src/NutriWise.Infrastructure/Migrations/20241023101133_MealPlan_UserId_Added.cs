using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriWise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MealPlan_UserId_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "MealPlans",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "UserId",
                table: "MealPlans");

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
        }
    }
}
