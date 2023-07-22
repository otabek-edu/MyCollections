using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDelte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("4d768cc0-a8a7-4874-8ae9-5ef3bdfdc21c"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("50487bef-8ee4-41aa-a328-de30abe456ae"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("53d2757e-1311-435b-ab29-4f1485cd6172"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a46355bd-a064-46ec-8a36-fe8d8c3726a7"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a80aed97-0201-4144-ad4e-9cecdded40b9"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("b1463858-114b-405e-9d03-ad4a8449d435"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("b6700ca2-83d3-4f89-9a79-3a74c4165e74"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("bf25ebc0-266b-42ce-8744-05dd8f3bd5d3"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("c2a4292e-63dd-451f-b96a-d7a87022e4e0"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("d2c7e18a-da79-4af6-ad0a-fb0165491602"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c4a3e7c-5874-4db8-84dc-50c84a16d4e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48b0a037-99ee-4db0-8f6f-06ef49e6f80a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61fef2d6-5335-4e06-a431-aac20fe8638b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9be406d-7d44-43a7-8074-54c1a276073b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4c8bd32-a473-4393-b9cb-e1f60634fa6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d956b6ee-48fe-490c-a26f-75bd9905c5c7"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("0ba63716-1fa8-42aa-a186-bd9a607d2e53"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("11f5828c-1558-48d1-ba67-56bdcd9c811c"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("1b1f9306-4f21-4d90-8021-4fae6e696177"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("626e0e1a-712a-427e-96ec-8e0ea088a97b"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("6d681cb1-7c4e-459e-80f4-e84c06f229ae"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("6e095e7e-6930-402d-b8e3-61924cb2135b"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("718f5815-564b-455f-ac76-af3e55eb3e2b"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("85544e5b-f336-4724-8429-a5707a537e68"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("9016ad5f-9402-4529-a558-4157c17d3fc1"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("99c45d62-9d51-4817-be49-20d877dc1517"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e0331ae-baad-4ba4-8b09-8141907e03ef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5cab4146-3f1f-43e7-95a9-1f82518b4a16"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("62da1db3-8edb-40f2-bfcf-ade0fe4ba783"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6583da49-37b4-4fc2-9b95-9e425bb15093"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6b553a0b-6c6b-40ec-9ee6-ecb0c488132f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77cda0a2-f6f0-497c-933e-629e9f338c1d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a20422f6-29f0-4820-9b9b-351aae427763"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b670afec-3724-404c-8370-49882acc5f7d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bdf2bdda-24fb-4fc2-b121-69209cbb6bde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fae1bf87-85af-4c03-8f59-c65cd922f90c"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("1aad8020-a44d-419b-ad09-dc76599aac43"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("349e82da-20ab-4bc2-b763-18d3161c7ed9"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("3a93d32e-7971-45ec-8b92-ebd38626961f"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("3fa41386-370a-4177-ae6a-7183dfbb230d"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("5548e8fa-9b24-4236-ab7f-799a84e5143a"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("8f3d56e2-e69e-4617-a493-e33d2611878e"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9f678230-11ea-4826-8c55-434445e22539"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("a188a239-5b6c-47e9-8f81-00db40ff5280"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("acb929b1-3c81-48b8-bf3b-6a3256adc2e9"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d60ab275-70e3-4fed-a05e-55c174073e4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46e9b799-2cac-4a2e-b496-e1a8353803c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60efcc8b-5265-4d36-a94f-48ea4f9e3fab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75008141-5aab-423e-8824-fec9dde7bc0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cae3ed0a-691d-4ce6-93c6-b44b0b679886"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f69fb4f6-6c9a-45e6-a099-a3cefd8bd6f3"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("0049aa2d-1986-4ecb-9a01-38f38255143e"), "Thelma48@gmail.com", "Thelma", false, false, "Crooks", "" },
                    { new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f"), "Raquel.Ritchie@hotmail.com", "Raquel", false, false, "Ritchie", "" },
                    { new Guid("32c96d0d-ae06-4f5b-9699-3742559dc878"), "Brett94@hotmail.com", "Brett", false, false, "Windler", "" },
                    { new Guid("7d441a99-aba1-4565-a237-5b6cf66411a1"), "otabek.r743@gmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("7ea14d43-3f78-413a-8e41-8ca7793fe50e"), "Randy_Bradtke3@yahoo.com", "Randy", false, false, "Bradtke", "" },
                    { new Guid("96e4dde2-c912-4855-9dcd-907f92054908"), "Wallace76@yahoo.com", "Wallace", false, false, "Toy", "" },
                    { new Guid("9ce546d6-d68c-471b-aaf9-993f62761d0a"), "Sabrina22@hotmail.com", "Sabrina", false, false, "Nicolas", "" },
                    { new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664"), "Homer91@gmail.com", "Homer", false, false, "Feest", "" },
                    { new Guid("ad6484ff-376f-4143-9b0c-90929afe8734"), "Shannon_Lemke@hotmail.com", "Shannon", false, false, "Lemke", "" },
                    { new Guid("bd9d2221-58e7-4839-9160-26368be7f668"), "Ann.Kerluke72@gmail.com", "Ann", false, false, "Kerluke", "" },
                    { new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b"), "Steven.Casper1@yahoo.com", "Steven", false, false, "Casper", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=160", "Gorgeous Steel Shoes", "Awesome", new Guid("9ce546d6-d68c-471b-aaf9-993f62761d0a") },
                    { new Guid("1019ce56-587c-401c-b27f-46db35f448e9"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=757", "Practical Soft Towels", "Licensed", new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b") },
                    { new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=476", "Sleek Wooden Sausages", "Rustic", new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664") },
                    { new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=317", "Practical Wooden Soap", "Unbranded", new Guid("0049aa2d-1986-4ecb-9a01-38f38255143e") },
                    { new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=1021", "Refined Soft Hat", "Awesome", new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f") },
                    { new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=813", "Handcrafted Steel Hat", "Ergonomic", new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f") },
                    { new Guid("74943104-fa1a-4451-893a-ddce7415937b"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=807", "Licensed Plastic Chair", "Handmade", new Guid("32c96d0d-ae06-4f5b-9699-3742559dc878") },
                    { new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=490", "Fantastic Steel Tuna", "Handcrafted", new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664") },
                    { new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=628", "Sleek Frozen Shoes", "Practical", new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b") },
                    { new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=822", "Incredible Frozen Pants", "Incredible", new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperties",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("10b83954-8f3d-4915-b9f1-f3a8c1c1a91a"), new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"), "Feest - Gottlieb", "string" },
                    { new Guid("2dc520e2-7197-400b-a1c8-65320c86cb2d"), new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"), "D'Amore - Lehner", "dateTime" },
                    { new Guid("4f27c86e-e760-4d7a-8d37-12ff4580c61d"), new Guid("74943104-fa1a-4451-893a-ddce7415937b"), "Zieme, Lemke and Muller", "dateTime" },
                    { new Guid("4fb8042d-d5a4-4d62-8675-abcac6b1df55"), new Guid("1019ce56-587c-401c-b27f-46db35f448e9"), "Kessler, Friesen and Steuber", "string" },
                    { new Guid("53780827-cf44-42ff-98b3-f3ea31bd9237"), new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"), "Lynch LLC", "boolean" },
                    { new Guid("6ef38b8b-0a33-4270-bfb0-66bbd4f277aa"), new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"), "Ward LLC", "string" },
                    { new Guid("ad1f3a87-e310-420b-a6c3-a35a1f43965f"), new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"), "Spencer, Dare and Hilpert", "string" },
                    { new Guid("c15aa460-5e34-4f7a-96eb-f6bf5abf3596"), new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"), "Klocko, Brown and Auer", "boolean" },
                    { new Guid("ef90839c-0d71-4625-960a-f0fd3b656d58"), new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"), "Wiegand and Sons", "string" },
                    { new Guid("f21e8b34-636c-4283-99d7-755125cb89a0"), new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"), "Larson LLC", "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("3c429245-2b27-42db-9fcb-d5546c036305"), new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"), new DateTime(2022, 11, 24, 1, 54, 42, 29, DateTimeKind.Local).AddTicks(6447), "Unbranded Frozen Shoes" },
                    { new Guid("4753e100-9671-413d-b217-1aaefdf0f0c1"), new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"), new DateTime(2023, 3, 30, 23, 27, 44, 172, DateTimeKind.Local).AddTicks(1984), "Ergonomic Fresh Fish" },
                    { new Guid("4cde87f4-ccd9-4591-80b0-1aaa12906591"), new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"), new DateTime(2023, 7, 1, 5, 48, 11, 498, DateTimeKind.Local).AddTicks(4886), "Refined Frozen Towels" },
                    { new Guid("5c5b918d-6058-40bc-ab1b-27f5479087a3"), new Guid("1019ce56-587c-401c-b27f-46db35f448e9"), new DateTime(2023, 1, 28, 10, 26, 49, 809, DateTimeKind.Local).AddTicks(924), "Handmade Concrete Bacon" },
                    { new Guid("69583c50-be41-4beb-a94e-d02b7a827cc3"), new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"), new DateTime(2023, 6, 6, 23, 4, 51, 205, DateTimeKind.Local).AddTicks(1917), "Incredible Rubber Gloves" },
                    { new Guid("71ae6c3e-52db-4b08-8275-d4510601afe3"), new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"), new DateTime(2022, 8, 26, 19, 6, 51, 471, DateTimeKind.Local).AddTicks(3196), "Generic Metal Bacon" },
                    { new Guid("797ceebe-3836-49bf-a5b3-a6b5175552fa"), new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"), new DateTime(2023, 3, 29, 20, 0, 15, 429, DateTimeKind.Local).AddTicks(8128), "Ergonomic Wooden Keyboard" },
                    { new Guid("a68f0392-504c-46af-ae42-f0fc23185839"), new Guid("74943104-fa1a-4451-893a-ddce7415937b"), new DateTime(2023, 5, 30, 5, 55, 54, 380, DateTimeKind.Local).AddTicks(6825), "Unbranded Frozen Chicken" },
                    { new Guid("d958da33-132f-40ff-a3d5-216c6cebdac3"), new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"), new DateTime(2022, 10, 11, 4, 18, 18, 576, DateTimeKind.Local).AddTicks(8727), "Handcrafted Plastic Fish" },
                    { new Guid("ea8cc440-f897-4f34-92ff-e6d059040cfb"), new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"), new DateTime(2022, 12, 22, 0, 44, 13, 654, DateTimeKind.Local).AddTicks(2836), "Ergonomic Concrete Shoes" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValues",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("1d3132c3-eaa0-4214-aeb9-a395e0895955"), new Guid("53780827-cf44-42ff-98b3-f3ea31bd9237"), new Guid("69583c50-be41-4beb-a94e-d02b7a827cc3"), "Refined Metal Pants" },
                    { new Guid("20ae2bfb-30f2-4a3c-b379-3f420232601c"), new Guid("ef90839c-0d71-4625-960a-f0fd3b656d58"), new Guid("4cde87f4-ccd9-4591-80b0-1aaa12906591"), "Refined Concrete Salad" },
                    { new Guid("6b780fd2-acc7-496b-8310-aca4531147af"), new Guid("2dc520e2-7197-400b-a1c8-65320c86cb2d"), new Guid("797ceebe-3836-49bf-a5b3-a6b5175552fa"), "Fantastic Rubber Pizza" },
                    { new Guid("814c7c76-7926-486a-a436-8322735b6020"), new Guid("f21e8b34-636c-4283-99d7-755125cb89a0"), new Guid("ea8cc440-f897-4f34-92ff-e6d059040cfb"), "Intelligent Plastic Towels" },
                    { new Guid("a4bacfc1-5815-4c97-9aac-b2c23e761bd0"), new Guid("c15aa460-5e34-4f7a-96eb-f6bf5abf3596"), new Guid("d958da33-132f-40ff-a3d5-216c6cebdac3"), "Generic Metal Hat" },
                    { new Guid("a4d80817-85e3-4201-affe-df7e6a5a68bd"), new Guid("ad1f3a87-e310-420b-a6c3-a35a1f43965f"), new Guid("3c429245-2b27-42db-9fcb-d5546c036305"), "Gorgeous Granite Chicken" },
                    { new Guid("a76042e3-27f5-4096-8ec8-842a118a782f"), new Guid("6ef38b8b-0a33-4270-bfb0-66bbd4f277aa"), new Guid("71ae6c3e-52db-4b08-8275-d4510601afe3"), "Tasty Frozen Towels" },
                    { new Guid("acafa747-8ac3-4044-87a4-6a6772f335aa"), new Guid("4f27c86e-e760-4d7a-8d37-12ff4580c61d"), new Guid("a68f0392-504c-46af-ae42-f0fc23185839"), "Intelligent Frozen Table" },
                    { new Guid("d4f5ca0a-2241-4056-95fb-087088c2294d"), new Guid("10b83954-8f3d-4915-b9f1-f3a8c1c1a91a"), new Guid("4753e100-9671-413d-b217-1aaefdf0f0c1"), "Ergonomic Metal Chips" },
                    { new Guid("f821dc07-7b16-4346-9910-4d56f2b60272"), new Guid("4fb8042d-d5a4-4d62-8675-abcac6b1df55"), new Guid("5c5b918d-6058-40bc-ab1b-27f5479087a3"), "Tasty Wooden Sausages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("1d3132c3-eaa0-4214-aeb9-a395e0895955"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("20ae2bfb-30f2-4a3c-b379-3f420232601c"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("6b780fd2-acc7-496b-8310-aca4531147af"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("814c7c76-7926-486a-a436-8322735b6020"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a4bacfc1-5815-4c97-9aac-b2c23e761bd0"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a4d80817-85e3-4201-affe-df7e6a5a68bd"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a76042e3-27f5-4096-8ec8-842a118a782f"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("acafa747-8ac3-4044-87a4-6a6772f335aa"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("d4f5ca0a-2241-4056-95fb-087088c2294d"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("f821dc07-7b16-4346-9910-4d56f2b60272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d441a99-aba1-4565-a237-5b6cf66411a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ea14d43-3f78-413a-8e41-8ca7793fe50e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96e4dde2-c912-4855-9dcd-907f92054908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad6484ff-376f-4143-9b0c-90929afe8734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd9d2221-58e7-4839-9160-26368be7f668"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("10b83954-8f3d-4915-b9f1-f3a8c1c1a91a"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("2dc520e2-7197-400b-a1c8-65320c86cb2d"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("4f27c86e-e760-4d7a-8d37-12ff4580c61d"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("4fb8042d-d5a4-4d62-8675-abcac6b1df55"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("53780827-cf44-42ff-98b3-f3ea31bd9237"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("6ef38b8b-0a33-4270-bfb0-66bbd4f277aa"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("ad1f3a87-e310-420b-a6c3-a35a1f43965f"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("c15aa460-5e34-4f7a-96eb-f6bf5abf3596"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("ef90839c-0d71-4625-960a-f0fd3b656d58"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("f21e8b34-636c-4283-99d7-755125cb89a0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c429245-2b27-42db-9fcb-d5546c036305"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4753e100-9671-413d-b217-1aaefdf0f0c1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4cde87f4-ccd9-4591-80b0-1aaa12906591"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5c5b918d-6058-40bc-ab1b-27f5479087a3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("69583c50-be41-4beb-a94e-d02b7a827cc3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("71ae6c3e-52db-4b08-8275-d4510601afe3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("797ceebe-3836-49bf-a5b3-a6b5175552fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a68f0392-504c-46af-ae42-f0fc23185839"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d958da33-132f-40ff-a3d5-216c6cebdac3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ea8cc440-f897-4f34-92ff-e6d059040cfb"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("040bab10-aae1-41dc-8393-0cb7bbc04749"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("1019ce56-587c-401c-b27f-46db35f448e9"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("358f506d-af6f-4eed-b8d5-39cf4b511769"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("49369176-effc-4d68-81ba-b35482ff8fb3"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("5d0ca309-3b89-429d-9fbd-d1f30c235086"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("6a3e72f2-24a0-4020-8212-98d19a5d221e"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("74943104-fa1a-4451-893a-ddce7415937b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9f4c01e7-4ed1-4912-99f8-81ad9e621140"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("e29fc38e-bd3a-4997-a113-0dda5a648d04"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("eea0fb6d-95a9-439b-917f-2aa46ea4e0a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0049aa2d-1986-4ecb-9a01-38f38255143e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a0b5701-5fae-4a9e-b796-594b2a90c57f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32c96d0d-ae06-4f5b-9699-3742559dc878"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ce546d6-d68c-471b-aaf9-993f62761d0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1fc9a76-a6c0-406f-9aae-2e2a8868e664"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d94e2b69-6d43-4f2d-bf0a-a4fa3a8d748b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("2c4a3e7c-5874-4db8-84dc-50c84a16d4e1"), "Dustin_Schroeder55@hotmail.com", "Dustin", false, false, "Schroeder", "" },
                    { new Guid("46e9b799-2cac-4a2e-b496-e1a8353803c1"), "Tiffany.Wunsch21@hotmail.com", "Tiffany", false, false, "Wunsch", "" },
                    { new Guid("48b0a037-99ee-4db0-8f6f-06ef49e6f80a"), "Brent.Torp64@gmail.com", "Brent", false, false, "Torp", "" },
                    { new Guid("60efcc8b-5265-4d36-a94f-48ea4f9e3fab"), "Andy.Corwin49@hotmail.com", "Andy", false, false, "Corwin", "" },
                    { new Guid("61fef2d6-5335-4e06-a431-aac20fe8638b"), "otabek.r743@gmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("75008141-5aab-423e-8824-fec9dde7bc0b"), "Violet83@yahoo.com", "Violet", false, false, "Mante", "" },
                    { new Guid("c9be406d-7d44-43a7-8074-54c1a276073b"), "Anita4@gmail.com", "Anita", false, false, "Wintheiser", "" },
                    { new Guid("cae3ed0a-691d-4ce6-93c6-b44b0b679886"), "Traci.McKenzie37@hotmail.com", "Traci", false, false, "McKenzie", "" },
                    { new Guid("d4c8bd32-a473-4393-b9cb-e1f60634fa6c"), "Lola_Lueilwitz@hotmail.com", "Lola", false, false, "Lueilwitz", "" },
                    { new Guid("d956b6ee-48fe-490c-a26f-75bd9905c5c7"), "Denise.Miller27@gmail.com", "Denise", false, false, "Miller", "" },
                    { new Guid("f69fb4f6-6c9a-45e6-a099-a3cefd8bd6f3"), "Kathy27@hotmail.com", "Kathy", false, false, "Bosco", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("1aad8020-a44d-419b-ad09-dc76599aac43"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=101", "Licensed Rubber Table", "Gorgeous", new Guid("cae3ed0a-691d-4ce6-93c6-b44b0b679886") },
                    { new Guid("349e82da-20ab-4bc2-b763-18d3161c7ed9"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=695", "Intelligent Granite Bacon", "Unbranded", new Guid("60efcc8b-5265-4d36-a94f-48ea4f9e3fab") },
                    { new Guid("3a93d32e-7971-45ec-8b92-ebd38626961f"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=402", "Fantastic Granite Pizza", "Intelligent", new Guid("75008141-5aab-423e-8824-fec9dde7bc0b") },
                    { new Guid("3fa41386-370a-4177-ae6a-7183dfbb230d"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=985", "Refined Metal Sausages", "Sleek", new Guid("46e9b799-2cac-4a2e-b496-e1a8353803c1") },
                    { new Guid("5548e8fa-9b24-4236-ab7f-799a84e5143a"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=384", "Practical Plastic Pants", "Generic", new Guid("f69fb4f6-6c9a-45e6-a099-a3cefd8bd6f3") },
                    { new Guid("8f3d56e2-e69e-4617-a493-e33d2611878e"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=245", "Refined Soft Tuna", "Fantastic", new Guid("46e9b799-2cac-4a2e-b496-e1a8353803c1") },
                    { new Guid("9f678230-11ea-4826-8c55-434445e22539"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=953", "Practical Metal Mouse", "Refined", new Guid("60efcc8b-5265-4d36-a94f-48ea4f9e3fab") },
                    { new Guid("a188a239-5b6c-47e9-8f81-00db40ff5280"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=228", "Awesome Concrete Gloves", "Handcrafted", new Guid("46e9b799-2cac-4a2e-b496-e1a8353803c1") },
                    { new Guid("acb929b1-3c81-48b8-bf3b-6a3256adc2e9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=68", "Ergonomic Granite Bacon", "Handmade", new Guid("cae3ed0a-691d-4ce6-93c6-b44b0b679886") },
                    { new Guid("d60ab275-70e3-4fed-a05e-55c174073e4d"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=807", "Handmade Granite Shirt", "Rustic", new Guid("f69fb4f6-6c9a-45e6-a099-a3cefd8bd6f3") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperties",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("0ba63716-1fa8-42aa-a186-bd9a607d2e53"), new Guid("9f678230-11ea-4826-8c55-434445e22539"), "Volkman LLC", "boolean" },
                    { new Guid("11f5828c-1558-48d1-ba67-56bdcd9c811c"), new Guid("a188a239-5b6c-47e9-8f81-00db40ff5280"), "Hegmann - Graham", "string" },
                    { new Guid("1b1f9306-4f21-4d90-8021-4fae6e696177"), new Guid("acb929b1-3c81-48b8-bf3b-6a3256adc2e9"), "Davis, Spencer and Dare", "boolean" },
                    { new Guid("626e0e1a-712a-427e-96ec-8e0ea088a97b"), new Guid("3fa41386-370a-4177-ae6a-7183dfbb230d"), "Osinski and Sons", "number" },
                    { new Guid("6d681cb1-7c4e-459e-80f4-e84c06f229ae"), new Guid("5548e8fa-9b24-4236-ab7f-799a84e5143a"), "Brown Inc", "number" },
                    { new Guid("6e095e7e-6930-402d-b8e3-61924cb2135b"), new Guid("8f3d56e2-e69e-4617-a493-e33d2611878e"), "Wehner LLC", "string" },
                    { new Guid("718f5815-564b-455f-ac76-af3e55eb3e2b"), new Guid("349e82da-20ab-4bc2-b763-18d3161c7ed9"), "Upton, Ondricka and Nienow", "string" },
                    { new Guid("85544e5b-f336-4724-8429-a5707a537e68"), new Guid("3a93d32e-7971-45ec-8b92-ebd38626961f"), "Abernathy - Kassulke", "number" },
                    { new Guid("9016ad5f-9402-4529-a558-4157c17d3fc1"), new Guid("1aad8020-a44d-419b-ad09-dc76599aac43"), "Ziemann Group", "dateTime" },
                    { new Guid("99c45d62-9d51-4817-be49-20d877dc1517"), new Guid("d60ab275-70e3-4fed-a05e-55c174073e4d"), "Bogisich, Weimann and Farrell", "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1e0331ae-baad-4ba4-8b09-8141907e03ef"), new Guid("3fa41386-370a-4177-ae6a-7183dfbb230d"), new DateTime(2022, 9, 10, 12, 36, 29, 777, DateTimeKind.Local).AddTicks(1063), "Practical Steel Shirt" },
                    { new Guid("5cab4146-3f1f-43e7-95a9-1f82518b4a16"), new Guid("acb929b1-3c81-48b8-bf3b-6a3256adc2e9"), new DateTime(2023, 1, 12, 6, 55, 14, 295, DateTimeKind.Local).AddTicks(6569), "Incredible Metal Chicken" },
                    { new Guid("62da1db3-8edb-40f2-bfcf-ade0fe4ba783"), new Guid("5548e8fa-9b24-4236-ab7f-799a84e5143a"), new DateTime(2022, 10, 23, 9, 40, 53, 422, DateTimeKind.Local).AddTicks(6365), "Sleek Metal Mouse" },
                    { new Guid("6583da49-37b4-4fc2-9b95-9e425bb15093"), new Guid("1aad8020-a44d-419b-ad09-dc76599aac43"), new DateTime(2023, 4, 19, 6, 10, 51, 511, DateTimeKind.Local).AddTicks(7605), "Awesome Soft Tuna" },
                    { new Guid("6b553a0b-6c6b-40ec-9ee6-ecb0c488132f"), new Guid("9f678230-11ea-4826-8c55-434445e22539"), new DateTime(2023, 6, 24, 1, 30, 41, 479, DateTimeKind.Local).AddTicks(7015), "Incredible Plastic Fish" },
                    { new Guid("77cda0a2-f6f0-497c-933e-629e9f338c1d"), new Guid("d60ab275-70e3-4fed-a05e-55c174073e4d"), new DateTime(2023, 6, 12, 19, 53, 5, 657, DateTimeKind.Local).AddTicks(8371), "Handmade Wooden Salad" },
                    { new Guid("a20422f6-29f0-4820-9b9b-351aae427763"), new Guid("a188a239-5b6c-47e9-8f81-00db40ff5280"), new DateTime(2022, 12, 31, 7, 9, 36, 642, DateTimeKind.Local).AddTicks(9224), "Sleek Frozen Hat" },
                    { new Guid("b670afec-3724-404c-8370-49882acc5f7d"), new Guid("8f3d56e2-e69e-4617-a493-e33d2611878e"), new DateTime(2022, 9, 15, 10, 46, 21, 411, DateTimeKind.Local).AddTicks(8554), "Refined Granite Shoes" },
                    { new Guid("bdf2bdda-24fb-4fc2-b121-69209cbb6bde"), new Guid("349e82da-20ab-4bc2-b763-18d3161c7ed9"), new DateTime(2022, 9, 27, 18, 33, 7, 72, DateTimeKind.Local).AddTicks(7811), "Handmade Wooden Ball" },
                    { new Guid("fae1bf87-85af-4c03-8f59-c65cd922f90c"), new Guid("3a93d32e-7971-45ec-8b92-ebd38626961f"), new DateTime(2022, 7, 25, 1, 27, 38, 474, DateTimeKind.Local).AddTicks(3907), "Intelligent Steel Pants" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValues",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("4d768cc0-a8a7-4874-8ae9-5ef3bdfdc21c"), new Guid("85544e5b-f336-4724-8429-a5707a537e68"), new Guid("fae1bf87-85af-4c03-8f59-c65cd922f90c"), "Fantastic Concrete Mouse" },
                    { new Guid("50487bef-8ee4-41aa-a328-de30abe456ae"), new Guid("6d681cb1-7c4e-459e-80f4-e84c06f229ae"), new Guid("62da1db3-8edb-40f2-bfcf-ade0fe4ba783"), "Rustic Rubber Gloves" },
                    { new Guid("53d2757e-1311-435b-ab29-4f1485cd6172"), new Guid("718f5815-564b-455f-ac76-af3e55eb3e2b"), new Guid("bdf2bdda-24fb-4fc2-b121-69209cbb6bde"), "Incredible Fresh Shoes" },
                    { new Guid("a46355bd-a064-46ec-8a36-fe8d8c3726a7"), new Guid("6e095e7e-6930-402d-b8e3-61924cb2135b"), new Guid("b670afec-3724-404c-8370-49882acc5f7d"), "Practical Fresh Chips" },
                    { new Guid("a80aed97-0201-4144-ad4e-9cecdded40b9"), new Guid("9016ad5f-9402-4529-a558-4157c17d3fc1"), new Guid("6583da49-37b4-4fc2-9b95-9e425bb15093"), "Generic Steel Salad" },
                    { new Guid("b1463858-114b-405e-9d03-ad4a8449d435"), new Guid("626e0e1a-712a-427e-96ec-8e0ea088a97b"), new Guid("1e0331ae-baad-4ba4-8b09-8141907e03ef"), "Small Fresh Mouse" },
                    { new Guid("b6700ca2-83d3-4f89-9a79-3a74c4165e74"), new Guid("99c45d62-9d51-4817-be49-20d877dc1517"), new Guid("77cda0a2-f6f0-497c-933e-629e9f338c1d"), "Awesome Frozen Tuna" },
                    { new Guid("bf25ebc0-266b-42ce-8744-05dd8f3bd5d3"), new Guid("0ba63716-1fa8-42aa-a186-bd9a607d2e53"), new Guid("6b553a0b-6c6b-40ec-9ee6-ecb0c488132f"), "Fantastic Metal Table" },
                    { new Guid("c2a4292e-63dd-451f-b96a-d7a87022e4e0"), new Guid("11f5828c-1558-48d1-ba67-56bdcd9c811c"), new Guid("a20422f6-29f0-4820-9b9b-351aae427763"), "Fantastic Steel Hat" },
                    { new Guid("d2c7e18a-da79-4af6-ad0a-fb0165491602"), new Guid("1b1f9306-4f21-4d90-8021-4fae6e696177"), new Guid("5cab4146-3f1f-43e7-95a9-1f82518b4a16"), "Licensed Steel Chicken" }
                });
        }
    }
}
