using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDelte3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues");

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
                    { new Guid("2e8019d7-603d-4b66-949f-63940adf828a"), "Penny_Quigley@yahoo.com", "Penny", false, false, "Quigley", "" },
                    { new Guid("353b8c94-eb78-4d2c-9cad-748dfecd7e16"), "Valerie_Senger@yahoo.com", "Valerie", false, false, "Senger", "" },
                    { new Guid("4b2559e3-db98-446c-a781-27733e204c9a"), "Ricky.West@gmail.com", "Ricky", false, false, "West", "" },
                    { new Guid("533dabbb-b813-4781-b26b-a11896db5e68"), "Raquel.Kozey57@yahoo.com", "Raquel", false, false, "Kozey", "" },
                    { new Guid("5b27c762-bb51-4710-a302-6c25ce8d9219"), "Stephen.Armstrong@yahoo.com", "Stephen", false, false, "Armstrong", "" },
                    { new Guid("74506b8c-79c6-4fe0-820b-c43f5bacf8eb"), "otabek.r743@gmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87"), "Pamela96@yahoo.com", "Pamela", false, false, "Treutel", "" },
                    { new Guid("a6298fe0-83b0-4638-b38a-1cb3566fd83d"), "Jason_Simonis@hotmail.com", "Jason", false, false, "Simonis", "" },
                    { new Guid("b7a00f42-eede-431d-94b7-de22a258705f"), "Raquel47@gmail.com", "Raquel", false, false, "Stokes", "" },
                    { new Guid("c7391c3f-72a1-4afa-b1e3-15fec33c9b4b"), "Stuart45@gmail.com", "Stuart", false, false, "Waelchi", "" },
                    { new Guid("f29e8883-b32b-4bd6-afc9-2a4a56b7529f"), "Jaime18@hotmail.com", "Jaime", false, false, "Wisoky", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("228c90ca-50ea-4357-9d5a-da6b70a1ffdb"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=120", "Gorgeous Fresh Keyboard", "Tasty", new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87") },
                    { new Guid("4231d379-fd0a-44e5-9c5b-7d926bd8fdbe"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=216", "Rustic Granite Car", "Tasty", new Guid("533dabbb-b813-4781-b26b-a11896db5e68") },
                    { new Guid("5d68491e-7009-43eb-908a-44cf68028eaa"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=986", "Awesome Fresh Car", "Awesome", new Guid("4b2559e3-db98-446c-a781-27733e204c9a") },
                    { new Guid("76e2f6cf-a9b1-459a-8084-f5ec21553990"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=53", "Refined Concrete Chicken", "Practical", new Guid("533dabbb-b813-4781-b26b-a11896db5e68") },
                    { new Guid("82ac6111-97a5-4ef5-b585-2ff4af3d4921"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=292", "Sleek Frozen Table", "Intelligent", new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87") },
                    { new Guid("9d257017-02a9-4a95-b0c1-029fea8c6057"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=214", "Handcrafted Rubber Bacon", "Practical", new Guid("353b8c94-eb78-4d2c-9cad-748dfecd7e16") },
                    { new Guid("a44ea579-0df7-4687-9823-741183a917d3"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=158", "Unbranded Frozen Car", "Practical", new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87") },
                    { new Guid("b8e227bb-1551-4ecc-b8d0-7b7b912c79db"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=498", "Intelligent Granite Bike", "Intelligent", new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87") },
                    { new Guid("d5789970-148f-46c0-8718-9fdd8d0caad2"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=1083", "Practical Rubber Keyboard", "Small", new Guid("a6298fe0-83b0-4638-b38a-1cb3566fd83d") },
                    { new Guid("efef1b27-3d45-49fd-86e6-ae8bd477dd8e"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=430", "Unbranded Metal Hat", "Gorgeous", new Guid("5b27c762-bb51-4710-a302-6c25ce8d9219") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperties",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("018979d4-14ea-4586-9a68-9b6564143b5c"), new Guid("9d257017-02a9-4a95-b0c1-029fea8c6057"), "Littel LLC", "number" },
                    { new Guid("14f81106-6bb2-434f-9d40-9e40271c390f"), new Guid("efef1b27-3d45-49fd-86e6-ae8bd477dd8e"), "Keeling - Schmidt", "number" },
                    { new Guid("48b470db-3a05-45a5-bdb4-2244bae40118"), new Guid("d5789970-148f-46c0-8718-9fdd8d0caad2"), "Streich, Pfeffer and Mitchell", "string" },
                    { new Guid("4c19cf2e-ecb6-4c7d-b70f-c57191fbbf56"), new Guid("5d68491e-7009-43eb-908a-44cf68028eaa"), "Greenfelder LLC", "dateTime" },
                    { new Guid("5da9ac92-e7c5-4231-8b10-edf9f152fc65"), new Guid("228c90ca-50ea-4357-9d5a-da6b70a1ffdb"), "Abshire - D'Amore", "boolean" },
                    { new Guid("603d007e-c90c-40fe-b730-5d1dcc5db3da"), new Guid("4231d379-fd0a-44e5-9c5b-7d926bd8fdbe"), "Runte, Boehm and Prosacco", "dateTime" },
                    { new Guid("6285c931-0cda-46dd-815c-d984fca0cad5"), new Guid("82ac6111-97a5-4ef5-b585-2ff4af3d4921"), "Schoen, Beer and Huel", "number" },
                    { new Guid("cbca66b5-3b77-4119-9e21-647e8914260e"), new Guid("a44ea579-0df7-4687-9823-741183a917d3"), "Schaefer - Kuhic", "boolean" },
                    { new Guid("e35ebda8-1e86-46b3-997f-b074fa69cc32"), new Guid("b8e227bb-1551-4ecc-b8d0-7b7b912c79db"), "Armstrong - Pacocha", "number" },
                    { new Guid("ffc324f9-407e-4d7f-ad4e-75193eed80e5"), new Guid("76e2f6cf-a9b1-459a-8084-f5ec21553990"), "Kohler, Ledner and Haley", "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("5b89745e-4de9-45b7-9fc4-f53e99efc26a"), new Guid("a44ea579-0df7-4687-9823-741183a917d3"), new DateTime(2022, 8, 23, 17, 31, 25, 173, DateTimeKind.Local).AddTicks(3073), "Small Fresh Towels" },
                    { new Guid("77b2f469-d432-4f8b-bff3-d6a2aa07faca"), new Guid("76e2f6cf-a9b1-459a-8084-f5ec21553990"), new DateTime(2023, 2, 28, 3, 57, 5, 90, DateTimeKind.Local).AddTicks(7270), "Sleek Wooden Pants" },
                    { new Guid("87b428f7-d1d1-44d3-9d83-88c53ea983d5"), new Guid("228c90ca-50ea-4357-9d5a-da6b70a1ffdb"), new DateTime(2023, 2, 19, 1, 8, 13, 585, DateTimeKind.Local).AddTicks(3232), "Unbranded Frozen Towels" },
                    { new Guid("8b7fdde1-df2f-48af-8a0d-87673ab34d99"), new Guid("4231d379-fd0a-44e5-9c5b-7d926bd8fdbe"), new DateTime(2023, 6, 19, 9, 48, 4, 369, DateTimeKind.Local).AddTicks(824), "Sleek Frozen Soap" },
                    { new Guid("9a9280c5-9506-472d-9088-494f671ed08e"), new Guid("5d68491e-7009-43eb-908a-44cf68028eaa"), new DateTime(2022, 9, 9, 14, 31, 5, 924, DateTimeKind.Local).AddTicks(7257), "Tasty Rubber Car" },
                    { new Guid("9b36e83f-13d6-4baa-b105-1b3030aee754"), new Guid("d5789970-148f-46c0-8718-9fdd8d0caad2"), new DateTime(2022, 9, 20, 13, 19, 44, 96, DateTimeKind.Local).AddTicks(5887), "Tasty Metal Sausages" },
                    { new Guid("b1bfe819-1de9-4475-bdf7-39755fcd94b8"), new Guid("9d257017-02a9-4a95-b0c1-029fea8c6057"), new DateTime(2023, 6, 1, 3, 37, 59, 764, DateTimeKind.Local).AddTicks(5377), "Intelligent Wooden Keyboard" },
                    { new Guid("b6461a06-7135-45f3-a4c2-774bf3183802"), new Guid("b8e227bb-1551-4ecc-b8d0-7b7b912c79db"), new DateTime(2022, 9, 9, 10, 22, 34, 516, DateTimeKind.Local).AddTicks(4453), "Handcrafted Cotton Car" },
                    { new Guid("b7e55469-a480-49cd-8f16-892a9cff156f"), new Guid("efef1b27-3d45-49fd-86e6-ae8bd477dd8e"), new DateTime(2023, 3, 16, 4, 26, 22, 359, DateTimeKind.Local).AddTicks(9106), "Generic Concrete Chips" },
                    { new Guid("cc463718-a8e3-47ac-8ad2-8b5a8d46c8be"), new Guid("82ac6111-97a5-4ef5-b585-2ff4af3d4921"), new DateTime(2023, 5, 30, 9, 54, 45, 535, DateTimeKind.Local).AddTicks(6325), "Refined Metal Shirt" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValues",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("0aab9cbe-5cfd-43d2-bc55-1096db61cf62"), new Guid("603d007e-c90c-40fe-b730-5d1dcc5db3da"), new Guid("8b7fdde1-df2f-48af-8a0d-87673ab34d99"), "Rustic Rubber Car" },
                    { new Guid("25bba17b-0ef7-403f-8dbe-661066202e35"), new Guid("5da9ac92-e7c5-4231-8b10-edf9f152fc65"), new Guid("87b428f7-d1d1-44d3-9d83-88c53ea983d5"), "Handcrafted Plastic Car" },
                    { new Guid("2e03d1f5-3c52-44ce-8a9a-640844277139"), new Guid("018979d4-14ea-4586-9a68-9b6564143b5c"), new Guid("b1bfe819-1de9-4475-bdf7-39755fcd94b8"), "Generic Wooden Tuna" },
                    { new Guid("4b810ef7-7216-4878-87d0-6f16b376d2f7"), new Guid("48b470db-3a05-45a5-bdb4-2244bae40118"), new Guid("9b36e83f-13d6-4baa-b105-1b3030aee754"), "Handmade Soft Chips" },
                    { new Guid("536b633c-3ab8-4f4a-be60-639730229af2"), new Guid("4c19cf2e-ecb6-4c7d-b70f-c57191fbbf56"), new Guid("9a9280c5-9506-472d-9088-494f671ed08e"), "Fantastic Fresh Chair" },
                    { new Guid("838987d1-44cc-4b42-8331-1ebc8ea04b1b"), new Guid("ffc324f9-407e-4d7f-ad4e-75193eed80e5"), new Guid("77b2f469-d432-4f8b-bff3-d6a2aa07faca"), "Rustic Rubber Bike" },
                    { new Guid("a1ddbfab-56eb-4f15-a05a-512c40c0f299"), new Guid("e35ebda8-1e86-46b3-997f-b074fa69cc32"), new Guid("b6461a06-7135-45f3-a4c2-774bf3183802"), "Sleek Concrete Chicken" },
                    { new Guid("a6d1691e-f9cf-452e-b514-c0b6c0ce0f37"), new Guid("cbca66b5-3b77-4119-9e21-647e8914260e"), new Guid("5b89745e-4de9-45b7-9fc4-f53e99efc26a"), "Tasty Cotton Bike" },
                    { new Guid("a92250c0-5b7a-4498-9137-08642feee952"), new Guid("6285c931-0cda-46dd-815c-d984fca0cad5"), new Guid("cc463718-a8e3-47ac-8ad2-8b5a8d46c8be"), "Practical Metal Table" },
                    { new Guid("e53c2fe2-ae14-4b98-9266-e006276dace6"), new Guid("14f81106-6bb2-434f-9d40-9e40271c390f"), new Guid("b7e55469-a480-49cd-8f16-892a9cff156f"), "Small Wooden Fish" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues");

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("0aab9cbe-5cfd-43d2-bc55-1096db61cf62"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("25bba17b-0ef7-403f-8dbe-661066202e35"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("2e03d1f5-3c52-44ce-8a9a-640844277139"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("4b810ef7-7216-4878-87d0-6f16b376d2f7"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("536b633c-3ab8-4f4a-be60-639730229af2"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("838987d1-44cc-4b42-8331-1ebc8ea04b1b"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a1ddbfab-56eb-4f15-a05a-512c40c0f299"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a6d1691e-f9cf-452e-b514-c0b6c0ce0f37"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("a92250c0-5b7a-4498-9137-08642feee952"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("e53c2fe2-ae14-4b98-9266-e006276dace6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e8019d7-603d-4b66-949f-63940adf828a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74506b8c-79c6-4fe0-820b-c43f5bacf8eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7a00f42-eede-431d-94b7-de22a258705f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7391c3f-72a1-4afa-b1e3-15fec33c9b4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29e8883-b32b-4bd6-afc9-2a4a56b7529f"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("018979d4-14ea-4586-9a68-9b6564143b5c"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("14f81106-6bb2-434f-9d40-9e40271c390f"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("48b470db-3a05-45a5-bdb4-2244bae40118"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("4c19cf2e-ecb6-4c7d-b70f-c57191fbbf56"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("5da9ac92-e7c5-4231-8b10-edf9f152fc65"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("603d007e-c90c-40fe-b730-5d1dcc5db3da"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("6285c931-0cda-46dd-815c-d984fca0cad5"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("cbca66b5-3b77-4119-9e21-647e8914260e"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("e35ebda8-1e86-46b3-997f-b074fa69cc32"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("ffc324f9-407e-4d7f-ad4e-75193eed80e5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5b89745e-4de9-45b7-9fc4-f53e99efc26a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77b2f469-d432-4f8b-bff3-d6a2aa07faca"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87b428f7-d1d1-44d3-9d83-88c53ea983d5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8b7fdde1-df2f-48af-8a0d-87673ab34d99"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9a9280c5-9506-472d-9088-494f671ed08e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9b36e83f-13d6-4baa-b105-1b3030aee754"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1bfe819-1de9-4475-bdf7-39755fcd94b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b6461a06-7135-45f3-a4c2-774bf3183802"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7e55469-a480-49cd-8f16-892a9cff156f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cc463718-a8e3-47ac-8ad2-8b5a8d46c8be"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("228c90ca-50ea-4357-9d5a-da6b70a1ffdb"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("4231d379-fd0a-44e5-9c5b-7d926bd8fdbe"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("5d68491e-7009-43eb-908a-44cf68028eaa"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("76e2f6cf-a9b1-459a-8084-f5ec21553990"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("82ac6111-97a5-4ef5-b585-2ff4af3d4921"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9d257017-02a9-4a95-b0c1-029fea8c6057"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("a44ea579-0df7-4687-9823-741183a917d3"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b8e227bb-1551-4ecc-b8d0-7b7b912c79db"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d5789970-148f-46c0-8718-9fdd8d0caad2"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("efef1b27-3d45-49fd-86e6-ae8bd477dd8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("353b8c94-eb78-4d2c-9cad-748dfecd7e16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b2559e3-db98-446c-a781-27733e204c9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("533dabbb-b813-4781-b26b-a11896db5e68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b27c762-bb51-4710-a302-6c25ce8d9219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92ac60de-e8ec-4bb5-ba54-582661737f87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6298fe0-83b0-4638-b38a-1cb3566fd83d"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
