using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomPropertyValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("0318c508-fc0f-4f22-a236-2180353ffd4c"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("14eddbec-2c4c-4c99-a452-b27a7688bfe5"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("1d4fd7e5-1530-40eb-9374-f877b1f6d49d"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("1d8caf32-055f-49fe-a933-5bb52902d399"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("990c65bf-1cfe-47fe-a645-ac37573ea24f"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("9a39faa8-8c98-4d22-a962-44510d9da441"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("ac79ec1a-315c-462e-8600-85a230f7ae86"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("dff3b429-7e16-46c1-8fc9-0ce4d628dce7"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("fcdefcae-d34a-4ce8-84c2-bcb91a24019b"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("ff6779e8-cbd3-41a7-bd6a-0b8f3394e44f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0a30e119-a43b-433b-aefa-2d231bcb8594"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c34ead9-0aaa-4e19-8e98-c5d56dec3b14"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("36251514-e1b4-4e8e-8828-715cf9d8714e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3b83f47a-4a93-4594-9682-5326334969b3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6ad58535-ceac-4cb2-8f84-53687fd8e13a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8ad0df35-099e-4e98-8427-accce1a44cbf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8bad0c06-262f-4b9b-90fe-5800b5a96191"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8d284fb8-346b-4b7a-bfe8-b3f6347e1399"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f7026fb6-1f84-451e-8cb6-3698a17060f9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb6bfd95-a97e-477b-819f-2f1f263a104f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00ce7784-cde6-453e-b823-d91245e73bf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("152f066d-d6ea-4d5e-9e19-a4469b4a1fc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2370ec1f-059b-424c-aa72-36e5aae04eb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7c48246-08c1-4338-b2f9-5dd61b019f32"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("285625a2-a0ea-4cb6-a4b3-6537ac44aedd"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("569292fa-23ba-42bf-b2f8-f14414f84313"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("70a5b1f9-58fa-4f4a-af34-8125d4349062"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("8093cefc-1f93-4f1c-b2a1-82ea038f3b57"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("97896179-1eee-467a-870e-c1fe9922092b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9f3b4a38-90ee-47de-8b17-1f47627f0376"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b374fe94-1676-48d6-9e9f-7f77a0d853bf"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d682552f-2881-43b2-8b69-7231c80cfb65"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("e3d17e8e-b7ff-4dfc-9926-7ad8db9b6306"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("f234067e-1ec5-491a-bf6d-32f1c39ffca7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("009f517c-a274-4046-afe4-e1ec0e278cf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("013c4915-ffe7-43cc-8100-c34a490566e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29a30a04-12a8-49de-bf04-5698db18eeb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a211183-7a42-4696-9935-d7f14976a496"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b539dcc-b47c-43eb-9947-3d3493c386ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ea3daa1-e45c-44a6-8fa2-5553b4d256e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c320f0e3-5d58-47e1-bae3-2b872ec12035"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("10d8b4ae-f5d3-4de7-9c65-95cdf29e8f41"), "Lillie.Wisozk90@yahoo.com", "Lillie", false, false, "Wisozk", "" },
                    { new Guid("1c88fe6f-711c-4c95-be53-3024d95c1522"), "Jill.Lesch@hotmail.com", "Jill", false, false, "Lesch", "" },
                    { new Guid("4d9d26cc-0632-4cd6-aeb8-e2541eda0276"), "Kathleen93@gmail.com", "Kathleen", false, false, "Kuvalis", "" },
                    { new Guid("59705464-8fac-4b63-8dcd-e2d355fc6371"), "Lori_Kutch4@yahoo.com", "Lori", false, false, "Kutch", "" },
                    { new Guid("821fc148-61f5-494f-b616-10998cfacd64"), "otabek.pro@hotmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("8a65f70f-4341-431e-a85f-ace7a76d3361"), "Lucia65@gmail.com", "Lucia", false, false, "Predovic", "" },
                    { new Guid("8b44c494-ce8c-433d-b54d-e4a4451a5b61"), "Gina_Friesen@yahoo.com", "Gina", false, false, "Friesen", "" },
                    { new Guid("9ecf9876-d630-4e71-bd10-ab47d11a622d"), "Maureen.Willms53@yahoo.com", "Maureen", false, false, "Willms", "" },
                    { new Guid("a50a0c05-9a8e-4d37-a2a5-699faef074db"), "Zachary73@gmail.com", "Zachary", false, false, "Braun", "" },
                    { new Guid("aa33a6d5-bc0d-4b08-a0d7-62fa302a2d0a"), "Julio_Schulist51@hotmail.com", "Julio", false, false, "Schulist", "" },
                    { new Guid("cb7ef5b1-00f2-4e48-8524-da383a17d9c2"), "Phil_Nader@yahoo.com", "Phil", false, false, "Nader", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("15bcd2f5-f1d9-473c-bcf1-5206093e7ed0"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=434", "Small Fresh Bike", "Practical", new Guid("59705464-8fac-4b63-8dcd-e2d355fc6371") },
                    { new Guid("23e12790-846f-4b35-b255-d69bcf3b226b"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=25", "Small Metal Fish", "Fantastic", new Guid("10d8b4ae-f5d3-4de7-9c65-95cdf29e8f41") },
                    { new Guid("65bbf142-d7cb-4584-b4e3-b370adee8289"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=991", "Refined Wooden Car", "Intelligent", new Guid("59705464-8fac-4b63-8dcd-e2d355fc6371") },
                    { new Guid("7cc56c20-554e-4231-8cfc-32478b91d14e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=843", "Gorgeous Rubber Mouse", "Practical", new Guid("a50a0c05-9a8e-4d37-a2a5-699faef074db") },
                    { new Guid("88f035c3-752e-4cef-8b78-be1118067f25"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=1080", "Incredible Wooden Computer", "Handcrafted", new Guid("4d9d26cc-0632-4cd6-aeb8-e2541eda0276") },
                    { new Guid("b18cd452-10dc-40c5-b0fb-f36c38532544"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=348", "Refined Steel Keyboard", "Incredible", new Guid("a50a0c05-9a8e-4d37-a2a5-699faef074db") },
                    { new Guid("d3f2bc65-bf24-4e42-931f-2bb524158001"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=528", "Sleek Steel Pants", "Intelligent", new Guid("59705464-8fac-4b63-8dcd-e2d355fc6371") },
                    { new Guid("e159584b-8151-4811-bbae-498a7c093595"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=169", "Fantastic Soft Mouse", "Unbranded", new Guid("cb7ef5b1-00f2-4e48-8524-da383a17d9c2") },
                    { new Guid("ea827064-7b18-4239-9b3e-1cc9c026dc43"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=989", "Small Wooden Cheese", "Handmade", new Guid("cb7ef5b1-00f2-4e48-8524-da383a17d9c2") },
                    { new Guid("f252614f-8355-4306-9b92-ff5e300effb6"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=993", "Awesome Steel Chair", "Tasty", new Guid("8a65f70f-4341-431e-a85f-ace7a76d3361") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperty",
                columns: new[] { "Id", "CollectionId", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("267e62da-3277-437e-b079-f7d766527a4d"), new Guid("d3f2bc65-bf24-4e42-931f-2bb524158001"), "boolean" },
                    { new Guid("324f36e4-e92b-4ef0-a007-dedaf07b7427"), new Guid("f252614f-8355-4306-9b92-ff5e300effb6"), "boolean" },
                    { new Guid("37517b7c-5413-46d6-b737-2dcf398166a5"), new Guid("15bcd2f5-f1d9-473c-bcf1-5206093e7ed0"), "dateTime" },
                    { new Guid("3f1917e0-d9d9-45c0-a17e-bd277a66bad3"), new Guid("23e12790-846f-4b35-b255-d69bcf3b226b"), "boolean" },
                    { new Guid("4e59dfe1-3da4-4165-b0e0-484d08cb3c6a"), new Guid("7cc56c20-554e-4231-8cfc-32478b91d14e"), "boolean" },
                    { new Guid("90417749-2f79-48da-a304-f11dbc2dc53b"), new Guid("ea827064-7b18-4239-9b3e-1cc9c026dc43"), "string" },
                    { new Guid("ab1f2876-cece-49ef-950e-d3027e4c9751"), new Guid("b18cd452-10dc-40c5-b0fb-f36c38532544"), "dateTime" },
                    { new Guid("ab236aaf-1be6-4578-91e0-57bbc546b46f"), new Guid("65bbf142-d7cb-4584-b4e3-b370adee8289"), "string" },
                    { new Guid("c668685b-2bbe-4fd0-9824-84f3888b15db"), new Guid("88f035c3-752e-4cef-8b78-be1118067f25"), "dateTime" },
                    { new Guid("fa8becf1-49f9-4ad1-b754-92ac082b5896"), new Guid("e159584b-8151-4811-bbae-498a7c093595"), "boolean" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("7f36e017-e629-4585-b350-ec7a6c11f6e0"), new Guid("7cc56c20-554e-4231-8cfc-32478b91d14e"), new DateTime(2022, 8, 31, 23, 56, 35, 67, DateTimeKind.Local).AddTicks(5636), "Incredible Metal Gloves" },
                    { new Guid("93af4d22-ee7d-4d66-8468-f0d6c6d02c29"), new Guid("65bbf142-d7cb-4584-b4e3-b370adee8289"), new DateTime(2022, 12, 16, 7, 29, 48, 624, DateTimeKind.Local).AddTicks(4497), "Incredible Steel Pizza" },
                    { new Guid("97f66092-f963-4047-84e4-108a3579505b"), new Guid("15bcd2f5-f1d9-473c-bcf1-5206093e7ed0"), new DateTime(2022, 7, 27, 12, 32, 41, 347, DateTimeKind.Local).AddTicks(9756), "Intelligent Fresh Shirt" },
                    { new Guid("9e9475cd-496b-4638-a3b9-5b3055dfc495"), new Guid("b18cd452-10dc-40c5-b0fb-f36c38532544"), new DateTime(2022, 9, 23, 23, 21, 18, 449, DateTimeKind.Local).AddTicks(3548), "Practical Fresh Chips" },
                    { new Guid("b7b24758-4f86-4d10-a576-83879fb25cda"), new Guid("88f035c3-752e-4cef-8b78-be1118067f25"), new DateTime(2023, 6, 9, 5, 24, 0, 484, DateTimeKind.Local).AddTicks(1828), "Ergonomic Concrete Ball" },
                    { new Guid("c3c22420-5e86-457c-835f-21fe9b77a6e5"), new Guid("e159584b-8151-4811-bbae-498a7c093595"), new DateTime(2023, 1, 31, 3, 55, 33, 681, DateTimeKind.Local).AddTicks(5003), "Intelligent Fresh Hat" },
                    { new Guid("d35067de-1598-4a6b-943d-804c835b530e"), new Guid("d3f2bc65-bf24-4e42-931f-2bb524158001"), new DateTime(2023, 3, 1, 5, 19, 6, 98, DateTimeKind.Local).AddTicks(2387), "Awesome Fresh Shirt" },
                    { new Guid("dba960fd-ea8a-466d-b7b8-3877e639da1b"), new Guid("23e12790-846f-4b35-b255-d69bcf3b226b"), new DateTime(2022, 12, 17, 22, 30, 33, 695, DateTimeKind.Local).AddTicks(2762), "Gorgeous Frozen Mouse" },
                    { new Guid("f4eecdec-b74a-4a09-a1ee-bb987329ff59"), new Guid("ea827064-7b18-4239-9b3e-1cc9c026dc43"), new DateTime(2023, 6, 2, 2, 41, 26, 435, DateTimeKind.Local).AddTicks(225), "Intelligent Cotton Gloves" },
                    { new Guid("fa064a27-d6d7-48b5-9871-ead8cd4dc7bd"), new Guid("f252614f-8355-4306-9b92-ff5e300effb6"), new DateTime(2022, 12, 20, 12, 15, 15, 370, DateTimeKind.Local).AddTicks(5879), "Ergonomic Fresh Pizza" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValue",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("03ccafe1-dee7-449a-8dc0-d7056e6a51a3"), new Guid("ab236aaf-1be6-4578-91e0-57bbc546b46f"), new Guid("93af4d22-ee7d-4d66-8468-f0d6c6d02c29"), "Incredible Steel Fish" },
                    { new Guid("0c8c6ae8-5d60-4001-8396-6c78fa241771"), new Guid("324f36e4-e92b-4ef0-a007-dedaf07b7427"), new Guid("fa064a27-d6d7-48b5-9871-ead8cd4dc7bd"), "Rustic Steel Bike" },
                    { new Guid("114c9de2-83c7-4f59-a39c-59c37afaf42d"), new Guid("267e62da-3277-437e-b079-f7d766527a4d"), new Guid("d35067de-1598-4a6b-943d-804c835b530e"), "Small Cotton Chicken" },
                    { new Guid("3552c213-fd7e-4862-b61c-c705006e0338"), new Guid("c668685b-2bbe-4fd0-9824-84f3888b15db"), new Guid("b7b24758-4f86-4d10-a576-83879fb25cda"), "Incredible Frozen Tuna" },
                    { new Guid("4624f7d3-8c92-42b7-ba4e-4ece588d0297"), new Guid("90417749-2f79-48da-a304-f11dbc2dc53b"), new Guid("f4eecdec-b74a-4a09-a1ee-bb987329ff59"), "Awesome Wooden Hat" },
                    { new Guid("57545b46-14ca-4fbf-91ec-defbfb106235"), new Guid("fa8becf1-49f9-4ad1-b754-92ac082b5896"), new Guid("c3c22420-5e86-457c-835f-21fe9b77a6e5"), "Intelligent Metal Bacon" },
                    { new Guid("b8f2ed5d-7709-4299-92bf-99d347f37876"), new Guid("37517b7c-5413-46d6-b737-2dcf398166a5"), new Guid("97f66092-f963-4047-84e4-108a3579505b"), "Generic Rubber Sausages" },
                    { new Guid("c621b611-a0c8-412c-8284-3a733ff3386b"), new Guid("3f1917e0-d9d9-45c0-a17e-bd277a66bad3"), new Guid("dba960fd-ea8a-466d-b7b8-3877e639da1b"), "Gorgeous Frozen Shirt" },
                    { new Guid("da611f50-ec0c-419a-81bd-c4819a479158"), new Guid("ab1f2876-cece-49ef-950e-d3027e4c9751"), new Guid("9e9475cd-496b-4638-a3b9-5b3055dfc495"), "Handmade Plastic Table" },
                    { new Guid("fd1b6394-c0e2-440a-bc99-6ec0d61e7028"), new Guid("4e59dfe1-3da4-4165-b0e0-484d08cb3c6a"), new Guid("7f36e017-e629-4585-b350-ec7a6c11f6e0"), "Handcrafted Wooden Chips" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("03ccafe1-dee7-449a-8dc0-d7056e6a51a3"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("0c8c6ae8-5d60-4001-8396-6c78fa241771"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("114c9de2-83c7-4f59-a39c-59c37afaf42d"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("3552c213-fd7e-4862-b61c-c705006e0338"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("4624f7d3-8c92-42b7-ba4e-4ece588d0297"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("57545b46-14ca-4fbf-91ec-defbfb106235"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("b8f2ed5d-7709-4299-92bf-99d347f37876"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("c621b611-a0c8-412c-8284-3a733ff3386b"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("da611f50-ec0c-419a-81bd-c4819a479158"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("fd1b6394-c0e2-440a-bc99-6ec0d61e7028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c88fe6f-711c-4c95-be53-3024d95c1522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("821fc148-61f5-494f-b616-10998cfacd64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b44c494-ce8c-433d-b54d-e4a4451a5b61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ecf9876-d630-4e71-bd10-ab47d11a622d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa33a6d5-bc0d-4b08-a0d7-62fa302a2d0a"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("267e62da-3277-437e-b079-f7d766527a4d"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("324f36e4-e92b-4ef0-a007-dedaf07b7427"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("37517b7c-5413-46d6-b737-2dcf398166a5"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("3f1917e0-d9d9-45c0-a17e-bd277a66bad3"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("4e59dfe1-3da4-4165-b0e0-484d08cb3c6a"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("90417749-2f79-48da-a304-f11dbc2dc53b"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("ab1f2876-cece-49ef-950e-d3027e4c9751"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("ab236aaf-1be6-4578-91e0-57bbc546b46f"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("c668685b-2bbe-4fd0-9824-84f3888b15db"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("fa8becf1-49f9-4ad1-b754-92ac082b5896"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f36e017-e629-4585-b350-ec7a6c11f6e0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("93af4d22-ee7d-4d66-8468-f0d6c6d02c29"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("97f66092-f963-4047-84e4-108a3579505b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e9475cd-496b-4638-a3b9-5b3055dfc495"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7b24758-4f86-4d10-a576-83879fb25cda"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c3c22420-5e86-457c-835f-21fe9b77a6e5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d35067de-1598-4a6b-943d-804c835b530e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dba960fd-ea8a-466d-b7b8-3877e639da1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4eecdec-b74a-4a09-a1ee-bb987329ff59"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fa064a27-d6d7-48b5-9871-ead8cd4dc7bd"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("15bcd2f5-f1d9-473c-bcf1-5206093e7ed0"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("23e12790-846f-4b35-b255-d69bcf3b226b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("65bbf142-d7cb-4584-b4e3-b370adee8289"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("7cc56c20-554e-4231-8cfc-32478b91d14e"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("88f035c3-752e-4cef-8b78-be1118067f25"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("b18cd452-10dc-40c5-b0fb-f36c38532544"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d3f2bc65-bf24-4e42-931f-2bb524158001"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("e159584b-8151-4811-bbae-498a7c093595"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("ea827064-7b18-4239-9b3e-1cc9c026dc43"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("f252614f-8355-4306-9b92-ff5e300effb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10d8b4ae-f5d3-4de7-9c65-95cdf29e8f41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d9d26cc-0632-4cd6-aeb8-e2541eda0276"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59705464-8fac-4b63-8dcd-e2d355fc6371"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a65f70f-4341-431e-a85f-ace7a76d3361"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a50a0c05-9a8e-4d37-a2a5-699faef074db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb7ef5b1-00f2-4e48-8524-da383a17d9c2"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("009f517c-a274-4046-afe4-e1ec0e278cf0"), "Leon82@hotmail.com", "Leon", false, false, "Orn", "" },
                    { new Guid("00ce7784-cde6-453e-b823-d91245e73bf1"), "otabek.pro@hotmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("013c4915-ffe7-43cc-8100-c34a490566e3"), "Rosemary74@gmail.com", "Rosemary", false, false, "Rau", "" },
                    { new Guid("152f066d-d6ea-4d5e-9e19-a4469b4a1fc9"), "Jorge25@hotmail.com", "Jorge", false, false, "Cummerata", "" },
                    { new Guid("2370ec1f-059b-424c-aa72-36e5aae04eb4"), "Jay_Howe76@yahoo.com", "Jay", false, false, "Howe", "" },
                    { new Guid("29a30a04-12a8-49de-bf04-5698db18eeb9"), "Marsha10@gmail.com", "Marsha", false, false, "Harris", "" },
                    { new Guid("5a211183-7a42-4696-9935-d7f14976a496"), "Alfonso.Kulas63@yahoo.com", "Alfonso", false, false, "Kulas", "" },
                    { new Guid("5b539dcc-b47c-43eb-9947-3d3493c386ad"), "Emilio92@yahoo.com", "Emilio", false, false, "Swaniawski", "" },
                    { new Guid("6ea3daa1-e45c-44a6-8fa2-5553b4d256e4"), "Darin.Mueller65@hotmail.com", "Darin", false, false, "Mueller", "" },
                    { new Guid("b7c48246-08c1-4338-b2f9-5dd61b019f32"), "Gordon3@hotmail.com", "Gordon", false, false, "Ullrich", "" },
                    { new Guid("c320f0e3-5d58-47e1-bae3-2b872ec12035"), "Aaron97@yahoo.com", "Aaron", false, false, "DuBuque", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("285625a2-a0ea-4cb6-a4b3-6537ac44aedd"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=607", "Sleek Plastic Gloves", "Refined", new Guid("009f517c-a274-4046-afe4-e1ec0e278cf0") },
                    { new Guid("569292fa-23ba-42bf-b2f8-f14414f84313"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=437", "Awesome Frozen Tuna", "Handcrafted", new Guid("c320f0e3-5d58-47e1-bae3-2b872ec12035") },
                    { new Guid("70a5b1f9-58fa-4f4a-af34-8125d4349062"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=670", "Licensed Fresh Sausages", "Handmade", new Guid("5a211183-7a42-4696-9935-d7f14976a496") },
                    { new Guid("8093cefc-1f93-4f1c-b2a1-82ea038f3b57"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=342", "Fantastic Frozen Cheese", "Gorgeous", new Guid("5b539dcc-b47c-43eb-9947-3d3493c386ad") },
                    { new Guid("97896179-1eee-467a-870e-c1fe9922092b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=958", "Rustic Soft Towels", "Handmade", new Guid("013c4915-ffe7-43cc-8100-c34a490566e3") },
                    { new Guid("9f3b4a38-90ee-47de-8b17-1f47627f0376"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=3", "Intelligent Fresh Sausages", "Licensed", new Guid("c320f0e3-5d58-47e1-bae3-2b872ec12035") },
                    { new Guid("b374fe94-1676-48d6-9e9f-7f77a0d853bf"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=226", "Sleek Wooden Shirt", "Licensed", new Guid("6ea3daa1-e45c-44a6-8fa2-5553b4d256e4") },
                    { new Guid("d682552f-2881-43b2-8b69-7231c80cfb65"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=225", "Practical Cotton Cheese", "Small", new Guid("013c4915-ffe7-43cc-8100-c34a490566e3") },
                    { new Guid("e3d17e8e-b7ff-4dfc-9926-7ad8db9b6306"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://picsum.photos/640/480/?image=628", "Small Steel Chicken", "Rustic", new Guid("29a30a04-12a8-49de-bf04-5698db18eeb9") },
                    { new Guid("f234067e-1ec5-491a-bf6d-32f1c39ffca7"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=829", "Licensed Wooden Cheese", "Ergonomic", new Guid("009f517c-a274-4046-afe4-e1ec0e278cf0") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperty",
                columns: new[] { "Id", "CollectionId", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("0318c508-fc0f-4f22-a236-2180353ffd4c"), new Guid("8093cefc-1f93-4f1c-b2a1-82ea038f3b57"), "boolean" },
                    { new Guid("14eddbec-2c4c-4c99-a452-b27a7688bfe5"), new Guid("e3d17e8e-b7ff-4dfc-9926-7ad8db9b6306"), "number" },
                    { new Guid("1d4fd7e5-1530-40eb-9374-f877b1f6d49d"), new Guid("9f3b4a38-90ee-47de-8b17-1f47627f0376"), "dateTime" },
                    { new Guid("1d8caf32-055f-49fe-a933-5bb52902d399"), new Guid("70a5b1f9-58fa-4f4a-af34-8125d4349062"), "number" },
                    { new Guid("990c65bf-1cfe-47fe-a645-ac37573ea24f"), new Guid("d682552f-2881-43b2-8b69-7231c80cfb65"), "number" },
                    { new Guid("9a39faa8-8c98-4d22-a962-44510d9da441"), new Guid("285625a2-a0ea-4cb6-a4b3-6537ac44aedd"), "boolean" },
                    { new Guid("ac79ec1a-315c-462e-8600-85a230f7ae86"), new Guid("f234067e-1ec5-491a-bf6d-32f1c39ffca7"), "boolean" },
                    { new Guid("dff3b429-7e16-46c1-8fc9-0ce4d628dce7"), new Guid("b374fe94-1676-48d6-9e9f-7f77a0d853bf"), "dateTime" },
                    { new Guid("fcdefcae-d34a-4ce8-84c2-bcb91a24019b"), new Guid("569292fa-23ba-42bf-b2f8-f14414f84313"), "boolean" },
                    { new Guid("ff6779e8-cbd3-41a7-bd6a-0b8f3394e44f"), new Guid("97896179-1eee-467a-870e-c1fe9922092b"), "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("0a30e119-a43b-433b-aefa-2d231bcb8594"), new Guid("8093cefc-1f93-4f1c-b2a1-82ea038f3b57"), new DateTime(2022, 7, 27, 10, 34, 42, 874, DateTimeKind.Local).AddTicks(8769), "Awesome Steel Tuna" },
                    { new Guid("2c34ead9-0aaa-4e19-8e98-c5d56dec3b14"), new Guid("b374fe94-1676-48d6-9e9f-7f77a0d853bf"), new DateTime(2023, 7, 3, 10, 51, 8, 718, DateTimeKind.Local).AddTicks(274), "Licensed Steel Pizza" },
                    { new Guid("36251514-e1b4-4e8e-8828-715cf9d8714e"), new Guid("569292fa-23ba-42bf-b2f8-f14414f84313"), new DateTime(2022, 7, 20, 6, 56, 34, 185, DateTimeKind.Local).AddTicks(1575), "Practical Soft Car" },
                    { new Guid("3b83f47a-4a93-4594-9682-5326334969b3"), new Guid("70a5b1f9-58fa-4f4a-af34-8125d4349062"), new DateTime(2022, 8, 6, 8, 33, 11, 245, DateTimeKind.Local).AddTicks(5709), "Tasty Concrete Pants" },
                    { new Guid("6ad58535-ceac-4cb2-8f84-53687fd8e13a"), new Guid("285625a2-a0ea-4cb6-a4b3-6537ac44aedd"), new DateTime(2022, 12, 21, 7, 18, 29, 69, DateTimeKind.Local).AddTicks(2392), "Awesome Rubber Towels" },
                    { new Guid("8ad0df35-099e-4e98-8427-accce1a44cbf"), new Guid("9f3b4a38-90ee-47de-8b17-1f47627f0376"), new DateTime(2022, 9, 5, 13, 12, 2, 575, DateTimeKind.Local).AddTicks(6102), "Tasty Granite Table" },
                    { new Guid("8bad0c06-262f-4b9b-90fe-5800b5a96191"), new Guid("d682552f-2881-43b2-8b69-7231c80cfb65"), new DateTime(2023, 6, 10, 2, 37, 9, 978, DateTimeKind.Local).AddTicks(6), "Tasty Steel Bike" },
                    { new Guid("8d284fb8-346b-4b7a-bfe8-b3f6347e1399"), new Guid("f234067e-1ec5-491a-bf6d-32f1c39ffca7"), new DateTime(2023, 6, 16, 2, 22, 24, 306, DateTimeKind.Local).AddTicks(2577), "Fantastic Metal Ball" },
                    { new Guid("f7026fb6-1f84-451e-8cb6-3698a17060f9"), new Guid("97896179-1eee-467a-870e-c1fe9922092b"), new DateTime(2022, 8, 5, 8, 57, 10, 216, DateTimeKind.Local).AddTicks(9512), "Licensed Concrete Soap" },
                    { new Guid("fb6bfd95-a97e-477b-819f-2f1f263a104f"), new Guid("e3d17e8e-b7ff-4dfc-9926-7ad8db9b6306"), new DateTime(2022, 10, 30, 20, 52, 44, 546, DateTimeKind.Local).AddTicks(6036), "Rustic Soft Chips" }
                });
        }
    }
}
