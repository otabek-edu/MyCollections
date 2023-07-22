using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDelte2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1069aa25-88f5-4ce9-a51e-572ff2b7b8ad"), "Jay.Stokes0@hotmail.com", "Jay", false, false, "Stokes", "" },
                    { new Guid("177932fd-662d-46a5-b16a-efd2f78e50f7"), "Garrett.Kub@yahoo.com", "Garrett", false, false, "Kub", "" },
                    { new Guid("1e538167-c699-4a8c-a984-77167152410c"), "Marjorie_Witting@yahoo.com", "Marjorie", false, false, "Witting", "" },
                    { new Guid("1fbbf25e-9b3b-4f89-b775-ba5afa9d70da"), "Darryl_Moore@gmail.com", "Darryl", false, false, "Moore", "" },
                    { new Guid("4a9b390e-19c8-41ce-9386-a15ea49c6841"), "Brandon.Krajcik@hotmail.com", "Brandon", false, false, "Krajcik", "" },
                    { new Guid("801f9690-4335-4377-9aec-ac971a0a2112"), "Rex.Leannon74@yahoo.com", "Rex", false, false, "Leannon", "" },
                    { new Guid("84719cf0-77a3-4f46-ba09-a911baae15a7"), "Amy.Rice@hotmail.com", "Amy", false, false, "Rice", "" },
                    { new Guid("a7498063-4bee-4ee4-8e92-29914e5d2517"), "otabek.r743@gmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("b70bba9e-7d66-4317-9e8f-330d86e57d76"), "Kate.Rippin@yahoo.com", "Kate", false, false, "Rippin", "" },
                    { new Guid("d87609de-2cd0-4526-b955-00a887793b43"), "Jerome_Berge@gmail.com", "Jerome", false, false, "Berge", "" },
                    { new Guid("e52c7178-9d41-41e9-b6c7-e5fca18a57ce"), "Stacy_Weissnat@gmail.com", "Stacy", false, false, "Weissnat", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("397616cd-3d19-4d76-8d57-a8cb666f13d8"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=299", "Rustic Wooden Cheese", "Handcrafted", new Guid("177932fd-662d-46a5-b16a-efd2f78e50f7") },
                    { new Guid("3f607394-c7c1-43b4-b6cf-44ac3a7ad002"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=668", "Gorgeous Concrete Pants", "Refined", new Guid("e52c7178-9d41-41e9-b6c7-e5fca18a57ce") },
                    { new Guid("5cddd6a6-074d-4e80-b4df-3e31b8125ba5"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=168", "Intelligent Metal Car", "Rustic", new Guid("d87609de-2cd0-4526-b955-00a887793b43") },
                    { new Guid("6badf3ba-7815-42c3-9b10-1a083d58ce3b"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=428", "Gorgeous Plastic Shirt", "Generic", new Guid("177932fd-662d-46a5-b16a-efd2f78e50f7") },
                    { new Guid("7e22cceb-24f1-4d79-a009-ba2c5a1b4f57"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=161", "Incredible Metal Fish", "Intelligent", new Guid("1069aa25-88f5-4ce9-a51e-572ff2b7b8ad") },
                    { new Guid("8aa80f67-c88b-4ef9-8bf5-1303d54e8fd3"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=450", "Incredible Concrete Computer", "Fantastic", new Guid("177932fd-662d-46a5-b16a-efd2f78e50f7") },
                    { new Guid("9e2efdb6-93ed-4091-bacf-8d611df2b3b8"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=421", "Refined Frozen Hat", "Licensed", new Guid("b70bba9e-7d66-4317-9e8f-330d86e57d76") },
                    { new Guid("a71f7fcd-a441-4883-aea4-1bcb27d23123"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=864", "Practical Soft Gloves", "Generic", new Guid("4a9b390e-19c8-41ce-9386-a15ea49c6841") },
                    { new Guid("aeb020c5-5ab0-4ff7-b13f-146f063390e7"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=698", "Intelligent Concrete Table", "Refined", new Guid("d87609de-2cd0-4526-b955-00a887793b43") },
                    { new Guid("cc8e8318-d7d9-4ed1-8f85-02165d3cce3d"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=293", "Ergonomic Plastic Chips", "Handmade", new Guid("4a9b390e-19c8-41ce-9386-a15ea49c6841") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperties",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("00324a93-3876-4195-bc45-7344045c1b62"), new Guid("a71f7fcd-a441-4883-aea4-1bcb27d23123"), "Prosacco, Cummings and Towne", "boolean" },
                    { new Guid("04f2755e-3944-4169-a79f-aff0d7f8aa10"), new Guid("397616cd-3d19-4d76-8d57-a8cb666f13d8"), "Renner LLC", "number" },
                    { new Guid("204120d3-7f3f-473f-b9d3-653de96692ff"), new Guid("5cddd6a6-074d-4e80-b4df-3e31b8125ba5"), "Shanahan Group", "string" },
                    { new Guid("4f645b06-7233-46d4-aa21-93e5a0797edb"), new Guid("9e2efdb6-93ed-4091-bacf-8d611df2b3b8"), "Hills, Predovic and Schinner", "string" },
                    { new Guid("5551a26a-53ff-4a0c-a663-cdf121def52a"), new Guid("aeb020c5-5ab0-4ff7-b13f-146f063390e7"), "Tromp - Osinski", "number" },
                    { new Guid("7f6967ba-d92a-458a-87d6-dead666529f9"), new Guid("6badf3ba-7815-42c3-9b10-1a083d58ce3b"), "Ullrich - McLaughlin", "string" },
                    { new Guid("92a7f956-e9d2-4fad-8c86-06d163921e9b"), new Guid("3f607394-c7c1-43b4-b6cf-44ac3a7ad002"), "Doyle - Kohler", "dateTime" },
                    { new Guid("bd44d173-026b-4d43-98d3-96ba64e53bbe"), new Guid("8aa80f67-c88b-4ef9-8bf5-1303d54e8fd3"), "Hammes - Boyle", "string" },
                    { new Guid("defe8ff0-10b3-4d49-bcb3-beb748c6616b"), new Guid("cc8e8318-d7d9-4ed1-8f85-02165d3cce3d"), "Hickle - Larkin", "boolean" },
                    { new Guid("f711de9b-b9ba-4b4a-b07b-397a5a0fae62"), new Guid("7e22cceb-24f1-4d79-a009-ba2c5a1b4f57"), "Graham LLC", "string" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("09352e71-1995-4610-bc7e-6cb035118db4"), new Guid("9e2efdb6-93ed-4091-bacf-8d611df2b3b8"), new DateTime(2023, 4, 21, 13, 41, 31, 30, DateTimeKind.Local).AddTicks(2865), "Gorgeous Wooden Cheese" },
                    { new Guid("2a91aee2-7c96-4601-b49c-08249ae3c377"), new Guid("5cddd6a6-074d-4e80-b4df-3e31b8125ba5"), new DateTime(2023, 3, 15, 0, 16, 8, 482, DateTimeKind.Local).AddTicks(5881), "Unbranded Cotton Soap" },
                    { new Guid("49bb409e-1f20-4821-b58a-3e745a6d3cca"), new Guid("a71f7fcd-a441-4883-aea4-1bcb27d23123"), new DateTime(2023, 1, 12, 6, 46, 37, 724, DateTimeKind.Local).AddTicks(7020), "Refined Metal Gloves" },
                    { new Guid("577b82b8-4ff9-45b8-8785-8652b80f177a"), new Guid("397616cd-3d19-4d76-8d57-a8cb666f13d8"), new DateTime(2022, 10, 1, 11, 0, 35, 171, DateTimeKind.Local).AddTicks(9044), "Handcrafted Concrete Towels" },
                    { new Guid("6bed9001-f3bf-495c-96d4-bfca6080c211"), new Guid("aeb020c5-5ab0-4ff7-b13f-146f063390e7"), new DateTime(2023, 2, 25, 16, 34, 44, 21, DateTimeKind.Local).AddTicks(5237), "Fantastic Concrete Computer" },
                    { new Guid("853921c3-73dd-481a-ade4-6d7b94810e1b"), new Guid("6badf3ba-7815-42c3-9b10-1a083d58ce3b"), new DateTime(2022, 11, 24, 4, 20, 40, 857, DateTimeKind.Local).AddTicks(3895), "Incredible Soft Towels" },
                    { new Guid("87c5e7be-4c52-479f-9952-9247363baf10"), new Guid("cc8e8318-d7d9-4ed1-8f85-02165d3cce3d"), new DateTime(2023, 2, 6, 19, 31, 44, 933, DateTimeKind.Local).AddTicks(5850), "Gorgeous Soft Chicken" },
                    { new Guid("a556b743-27cb-4c99-94d5-37678c173053"), new Guid("7e22cceb-24f1-4d79-a009-ba2c5a1b4f57"), new DateTime(2023, 6, 14, 5, 37, 18, 312, DateTimeKind.Local).AddTicks(2590), "Ergonomic Concrete Fish" },
                    { new Guid("df1ddb8a-8d94-4086-b0fc-a0cfb177d003"), new Guid("8aa80f67-c88b-4ef9-8bf5-1303d54e8fd3"), new DateTime(2022, 10, 1, 6, 35, 48, 745, DateTimeKind.Local).AddTicks(9625), "Handcrafted Frozen Shoes" },
                    { new Guid("efc7b34c-a6e3-4da4-9348-6a9f955c81ab"), new Guid("3f607394-c7c1-43b4-b6cf-44ac3a7ad002"), new DateTime(2023, 5, 5, 3, 36, 13, 320, DateTimeKind.Local).AddTicks(8603), "Refined Metal Bacon" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValues",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("20cd9e01-582f-4e4c-bf4c-5487dc80cdcf"), new Guid("92a7f956-e9d2-4fad-8c86-06d163921e9b"), new Guid("efc7b34c-a6e3-4da4-9348-6a9f955c81ab"), "Sleek Concrete Fish" },
                    { new Guid("297eb0b9-830e-4b58-a2e6-8da1fad628a2"), new Guid("bd44d173-026b-4d43-98d3-96ba64e53bbe"), new Guid("df1ddb8a-8d94-4086-b0fc-a0cfb177d003"), "Refined Rubber Computer" },
                    { new Guid("365a99d9-a052-4f6c-9887-98d9f43022fa"), new Guid("f711de9b-b9ba-4b4a-b07b-397a5a0fae62"), new Guid("a556b743-27cb-4c99-94d5-37678c173053"), "Sleek Soft Chicken" },
                    { new Guid("66c54df3-2d7a-425f-8b23-71f1bc1edec4"), new Guid("204120d3-7f3f-473f-b9d3-653de96692ff"), new Guid("2a91aee2-7c96-4601-b49c-08249ae3c377"), "Sleek Rubber Fish" },
                    { new Guid("946d2642-e47e-450a-96c2-8f03293662e5"), new Guid("7f6967ba-d92a-458a-87d6-dead666529f9"), new Guid("853921c3-73dd-481a-ade4-6d7b94810e1b"), "Intelligent Concrete Car" },
                    { new Guid("a3cfce01-c76b-4889-8579-113ad78dea40"), new Guid("5551a26a-53ff-4a0c-a663-cdf121def52a"), new Guid("6bed9001-f3bf-495c-96d4-bfca6080c211"), "Intelligent Plastic Ball" },
                    { new Guid("d3783308-8e1e-4b79-b7c6-6e290afdc081"), new Guid("4f645b06-7233-46d4-aa21-93e5a0797edb"), new Guid("09352e71-1995-4610-bc7e-6cb035118db4"), "Incredible Wooden Cheese" },
                    { new Guid("d50501bb-95a4-4309-9910-694bc06032fc"), new Guid("04f2755e-3944-4169-a79f-aff0d7f8aa10"), new Guid("577b82b8-4ff9-45b8-8785-8652b80f177a"), "Generic Rubber Pants" },
                    { new Guid("db79dadc-6526-4830-a5ba-4dfeefccf73a"), new Guid("defe8ff0-10b3-4d49-bcb3-beb748c6616b"), new Guid("87c5e7be-4c52-479f-9952-9247363baf10"), "Ergonomic Concrete Chair" },
                    { new Guid("ee0dcc24-9350-4702-bf42-b1fb68a127dd"), new Guid("00324a93-3876-4195-bc45-7344045c1b62"), new Guid("49bb409e-1f20-4821-b58a-3e745a6d3cca"), "Small Fresh Mouse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("20cd9e01-582f-4e4c-bf4c-5487dc80cdcf"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("297eb0b9-830e-4b58-a2e6-8da1fad628a2"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("365a99d9-a052-4f6c-9887-98d9f43022fa"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("66c54df3-2d7a-425f-8b23-71f1bc1edec4"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("946d2642-e47e-450a-96c2-8f03293662e5"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a3cfce01-c76b-4889-8579-113ad78dea40"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("d3783308-8e1e-4b79-b7c6-6e290afdc081"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("d50501bb-95a4-4309-9910-694bc06032fc"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("db79dadc-6526-4830-a5ba-4dfeefccf73a"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("ee0dcc24-9350-4702-bf42-b1fb68a127dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e538167-c699-4a8c-a984-77167152410c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fbbf25e-9b3b-4f89-b775-ba5afa9d70da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("801f9690-4335-4377-9aec-ac971a0a2112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84719cf0-77a3-4f46-ba09-a911baae15a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7498063-4bee-4ee4-8e92-29914e5d2517"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("00324a93-3876-4195-bc45-7344045c1b62"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("04f2755e-3944-4169-a79f-aff0d7f8aa10"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("204120d3-7f3f-473f-b9d3-653de96692ff"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("4f645b06-7233-46d4-aa21-93e5a0797edb"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("5551a26a-53ff-4a0c-a663-cdf121def52a"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("7f6967ba-d92a-458a-87d6-dead666529f9"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("92a7f956-e9d2-4fad-8c86-06d163921e9b"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("bd44d173-026b-4d43-98d3-96ba64e53bbe"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("defe8ff0-10b3-4d49-bcb3-beb748c6616b"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("f711de9b-b9ba-4b4a-b07b-397a5a0fae62"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09352e71-1995-4610-bc7e-6cb035118db4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2a91aee2-7c96-4601-b49c-08249ae3c377"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49bb409e-1f20-4821-b58a-3e745a6d3cca"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("577b82b8-4ff9-45b8-8785-8652b80f177a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6bed9001-f3bf-495c-96d4-bfca6080c211"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("853921c3-73dd-481a-ade4-6d7b94810e1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87c5e7be-4c52-479f-9952-9247363baf10"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a556b743-27cb-4c99-94d5-37678c173053"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("df1ddb8a-8d94-4086-b0fc-a0cfb177d003"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("efc7b34c-a6e3-4da4-9348-6a9f955c81ab"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("397616cd-3d19-4d76-8d57-a8cb666f13d8"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("3f607394-c7c1-43b4-b6cf-44ac3a7ad002"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("5cddd6a6-074d-4e80-b4df-3e31b8125ba5"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("6badf3ba-7815-42c3-9b10-1a083d58ce3b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("7e22cceb-24f1-4d79-a009-ba2c5a1b4f57"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("8aa80f67-c88b-4ef9-8bf5-1303d54e8fd3"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9e2efdb6-93ed-4091-bacf-8d611df2b3b8"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("a71f7fcd-a441-4883-aea4-1bcb27d23123"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("aeb020c5-5ab0-4ff7-b13f-146f063390e7"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("cc8e8318-d7d9-4ed1-8f85-02165d3cce3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1069aa25-88f5-4ce9-a51e-572ff2b7b8ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("177932fd-662d-46a5-b16a-efd2f78e50f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a9b390e-19c8-41ce-9386-a15ea49c6841"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b70bba9e-7d66-4317-9e8f-330d86e57d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d87609de-2cd0-4526-b955-00a887793b43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e52c7178-9d41-41e9-b6c7-e5fca18a57ce"));

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
    }
}
