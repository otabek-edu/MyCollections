using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CustomProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("09ba65e9-85fb-48c0-a28d-81e8ec58407e"), "Marcella.Beer@yahoo.com", "Marcella", false, false, "Beer", "" },
                    { new Guid("386eb670-6272-4aab-85a1-b9be2e66af07"), "Loren.Treutel@yahoo.com", "Loren", false, false, "Treutel", "" },
                    { new Guid("4c9b419d-eea1-4de1-b29c-5ca2e9761c2f"), "Milton91@hotmail.com", "Milton", false, false, "Wiza", "" },
                    { new Guid("6d3d7a33-0b09-40a7-8fad-50d41b4e44ca"), "Elisa.Kling87@yahoo.com", "Elisa", false, false, "Kling", "" },
                    { new Guid("74145330-b0d8-49bf-b35b-7a87d7017bd8"), "Bob_Davis@yahoo.com", "Bob", false, false, "Davis", "" },
                    { new Guid("85fb96ea-3d60-47be-b22d-d07d3141f978"), "Tomas88@yahoo.com", "Tomas", false, false, "Runte", "" },
                    { new Guid("87e473d0-05dc-4bfb-b43c-25ccc3b91893"), "Leona69@gmail.com", "Leona", false, false, "Waelchi", "" },
                    { new Guid("97efc793-9930-431e-8b26-29eb982da4ba"), "Harry19@yahoo.com", "Harry", false, false, "Labadie", "" },
                    { new Guid("c9bd1c74-3e2f-4c06-bb4d-3d2a797281ec"), "Rochelle.Davis86@hotmail.com", "Rochelle", false, false, "Davis", "" },
                    { new Guid("cad905b8-3d56-4c03-b5e1-a480cb9986d7"), "Bruce_Jacobi16@hotmail.com", "Bruce", false, false, "Jacobi", "" },
                    { new Guid("fa0fd5e1-15e3-4028-8f49-d5086b9fc19a"), "otabek.pro@hotmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("2bc1f455-bafd-4383-a201-707e477bff81"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=278", "Incredible Frozen Towels", "Incredible", new Guid("4c9b419d-eea1-4de1-b29c-5ca2e9761c2f") },
                    { new Guid("32992302-c094-45aa-ba77-8ff46e233e4d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=517", "Generic Granite Ball", "Ergonomic", new Guid("74145330-b0d8-49bf-b35b-7a87d7017bd8") },
                    { new Guid("582c0d1a-9b0f-4d00-a1c6-f29625d7a221"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://picsum.photos/640/480/?image=686", "Incredible Soft Chips", "Intelligent", new Guid("85fb96ea-3d60-47be-b22d-d07d3141f978") },
                    { new Guid("6366b3c6-5b43-4a80-8b80-4325b22afa4e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=568", "Refined Granite Towels", "Handmade", new Guid("85fb96ea-3d60-47be-b22d-d07d3141f978") },
                    { new Guid("8c714971-5a0e-4df8-8881-7587101c1dac"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=277", "Licensed Cotton Fish", "Gorgeous", new Guid("4c9b419d-eea1-4de1-b29c-5ca2e9761c2f") },
                    { new Guid("9fe96455-8f95-4f31-9384-80d1e2eb9ade"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=266", "Licensed Granite Computer", "Unbranded", new Guid("09ba65e9-85fb-48c0-a28d-81e8ec58407e") },
                    { new Guid("c5a9e7a0-23fb-47de-a48b-813b6aa22fac"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=337", "Generic Concrete Chair", "Handmade", new Guid("97efc793-9930-431e-8b26-29eb982da4ba") },
                    { new Guid("d749406e-f2b2-410e-a67f-70f78743e0c9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=130", "Fantastic Soft Chips", "Tasty", new Guid("c9bd1c74-3e2f-4c06-bb4d-3d2a797281ec") },
                    { new Guid("e08243ea-9887-4fd3-849c-a6f7ab52af0e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=607", "Refined Wooden Tuna", "Licensed", new Guid("386eb670-6272-4aab-85a1-b9be2e66af07") },
                    { new Guid("f3e8d31d-96f0-4170-8bed-d1e78d07732e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=1058", "Sleek Frozen Towels", "Sleek", new Guid("74145330-b0d8-49bf-b35b-7a87d7017bd8") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperty",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("06a0382f-b198-4fea-88c0-8180c994d164"), new Guid("8c714971-5a0e-4df8-8881-7587101c1dac"), "Welch - Feil", "number" },
                    { new Guid("1f04bfec-9eb9-421d-bd7a-94bf3aeddec6"), new Guid("9fe96455-8f95-4f31-9384-80d1e2eb9ade"), "Wilderman, Bradtke and Lind", "string" },
                    { new Guid("1f255537-eae2-4d23-8742-88ccc129d712"), new Guid("f3e8d31d-96f0-4170-8bed-d1e78d07732e"), "Renner Inc", "dateTime" },
                    { new Guid("4c668a87-63fe-4cf9-acf7-f3ac8f33779f"), new Guid("d749406e-f2b2-410e-a67f-70f78743e0c9"), "Schinner - Konopelski", "dateTime" },
                    { new Guid("59af4182-4457-4fb1-ad84-d7c4e83ef12e"), new Guid("582c0d1a-9b0f-4d00-a1c6-f29625d7a221"), "Pfeffer, Hermiston and Reichert", "boolean" },
                    { new Guid("6e12adc3-8f14-402d-9740-b8fbf57b6ab2"), new Guid("6366b3c6-5b43-4a80-8b80-4325b22afa4e"), "Lehner, Conroy and Kessler", "boolean" },
                    { new Guid("882b04aa-3643-4e26-9fe9-35cb17d83d2e"), new Guid("c5a9e7a0-23fb-47de-a48b-813b6aa22fac"), "Monahan, Sauer and McClure", "string" },
                    { new Guid("a4e116b8-c674-453f-b58a-7452f348f12f"), new Guid("32992302-c094-45aa-ba77-8ff46e233e4d"), "Kilback LLC", "number" },
                    { new Guid("bcbf3321-b78c-4e56-aa4a-872b87a5897b"), new Guid("2bc1f455-bafd-4383-a201-707e477bff81"), "Simonis, Huels and Wolff", "number" },
                    { new Guid("e24616ca-c5f0-4ad8-aacc-341c8f824802"), new Guid("e08243ea-9887-4fd3-849c-a6f7ab52af0e"), "Marvin, Kovacek and Cassin", "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("176a8e81-bf4b-4f07-a007-f12852e04efd"), new Guid("582c0d1a-9b0f-4d00-a1c6-f29625d7a221"), new DateTime(2022, 12, 2, 9, 7, 30, 384, DateTimeKind.Local).AddTicks(7350), "Tasty Plastic Chicken" },
                    { new Guid("42cebe18-5fbc-4042-9966-f75ddbc9fed5"), new Guid("9fe96455-8f95-4f31-9384-80d1e2eb9ade"), new DateTime(2023, 4, 9, 1, 7, 31, 710, DateTimeKind.Local).AddTicks(2200), "Fantastic Granite Shoes" },
                    { new Guid("4d7f8ade-b1d6-4bdc-a1ed-4a76ab793bcb"), new Guid("6366b3c6-5b43-4a80-8b80-4325b22afa4e"), new DateTime(2022, 10, 14, 19, 59, 49, 678, DateTimeKind.Local).AddTicks(3853), "Gorgeous Concrete Tuna" },
                    { new Guid("667ed1ef-2f2c-47fd-a82b-0c7c5bafa262"), new Guid("32992302-c094-45aa-ba77-8ff46e233e4d"), new DateTime(2023, 6, 30, 0, 4, 13, 736, DateTimeKind.Local).AddTicks(2942), "Gorgeous Cotton Pizza" },
                    { new Guid("77612384-ae54-4edb-8ba2-11a856e87933"), new Guid("e08243ea-9887-4fd3-849c-a6f7ab52af0e"), new DateTime(2023, 3, 19, 18, 4, 58, 650, DateTimeKind.Local).AddTicks(2236), "Sleek Cotton Pizza" },
                    { new Guid("7dbf0a04-fe8f-4263-8819-9554aec17db3"), new Guid("d749406e-f2b2-410e-a67f-70f78743e0c9"), new DateTime(2023, 6, 12, 14, 26, 34, 393, DateTimeKind.Local).AddTicks(2313), "Licensed Fresh Car" },
                    { new Guid("82bec1bc-4295-471c-a592-8f32489d3619"), new Guid("c5a9e7a0-23fb-47de-a48b-813b6aa22fac"), new DateTime(2023, 1, 17, 15, 57, 23, 820, DateTimeKind.Local).AddTicks(2243), "Unbranded Steel Salad" },
                    { new Guid("c690e7ce-ff94-4861-a9f3-605dc2adb245"), new Guid("8c714971-5a0e-4df8-8881-7587101c1dac"), new DateTime(2022, 8, 28, 16, 27, 47, 615, DateTimeKind.Local).AddTicks(2836), "Awesome Rubber Soap" },
                    { new Guid("edaca7eb-1117-4e45-94fc-a8938f842036"), new Guid("2bc1f455-bafd-4383-a201-707e477bff81"), new DateTime(2023, 7, 10, 17, 30, 17, 605, DateTimeKind.Local).AddTicks(5986), "Intelligent Soft Cheese" },
                    { new Guid("fb7815e1-ff14-495a-836c-8c99e60f14d3"), new Guid("f3e8d31d-96f0-4170-8bed-d1e78d07732e"), new DateTime(2022, 10, 9, 11, 19, 38, 668, DateTimeKind.Local).AddTicks(2097), "Fantastic Metal Computer" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValue",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("0bc918d3-eecb-4c5e-bb37-faa4a59cb38f"), new Guid("a4e116b8-c674-453f-b58a-7452f348f12f"), new Guid("667ed1ef-2f2c-47fd-a82b-0c7c5bafa262"), "Licensed Fresh Shoes" },
                    { new Guid("176c420e-7fcf-40b3-92a1-bc5c526adcc0"), new Guid("882b04aa-3643-4e26-9fe9-35cb17d83d2e"), new Guid("82bec1bc-4295-471c-a592-8f32489d3619"), "Fantastic Soft Keyboard" },
                    { new Guid("454ecb56-7b13-4971-b4db-feb61e506408"), new Guid("1f255537-eae2-4d23-8742-88ccc129d712"), new Guid("fb7815e1-ff14-495a-836c-8c99e60f14d3"), "Intelligent Soft Gloves" },
                    { new Guid("487bde21-3dba-4628-89aa-9f202919c2d2"), new Guid("1f04bfec-9eb9-421d-bd7a-94bf3aeddec6"), new Guid("42cebe18-5fbc-4042-9966-f75ddbc9fed5"), "Fantastic Plastic Car" },
                    { new Guid("6f83a17d-8e9b-477f-93de-ec5a292970d3"), new Guid("59af4182-4457-4fb1-ad84-d7c4e83ef12e"), new Guid("176a8e81-bf4b-4f07-a007-f12852e04efd"), "Awesome Metal Cheese" },
                    { new Guid("75efe29f-9a83-421c-b535-83e084a6b3fc"), new Guid("bcbf3321-b78c-4e56-aa4a-872b87a5897b"), new Guid("edaca7eb-1117-4e45-94fc-a8938f842036"), "Fantastic Metal Mouse" },
                    { new Guid("8c38ccf5-9fa8-4189-80b0-c8a52742459d"), new Guid("06a0382f-b198-4fea-88c0-8180c994d164"), new Guid("c690e7ce-ff94-4861-a9f3-605dc2adb245"), "Handcrafted Frozen Gloves" },
                    { new Guid("ac0828e4-d8a8-434d-8069-c29386dba8ea"), new Guid("4c668a87-63fe-4cf9-acf7-f3ac8f33779f"), new Guid("7dbf0a04-fe8f-4263-8819-9554aec17db3"), "Tasty Plastic Pizza" },
                    { new Guid("c5a86210-5703-42b0-91b8-c8226d257731"), new Guid("6e12adc3-8f14-402d-9740-b8fbf57b6ab2"), new Guid("4d7f8ade-b1d6-4bdc-a1ed-4a76ab793bcb"), "Sleek Granite Salad" },
                    { new Guid("ebf90893-46a7-4855-b602-83a8f4084ffc"), new Guid("e24616ca-c5f0-4ad8-aacc-341c8f824802"), new Guid("77612384-ae54-4edb-8ba2-11a856e87933"), "Ergonomic Granite Shirt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("0bc918d3-eecb-4c5e-bb37-faa4a59cb38f"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("176c420e-7fcf-40b3-92a1-bc5c526adcc0"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("454ecb56-7b13-4971-b4db-feb61e506408"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("487bde21-3dba-4628-89aa-9f202919c2d2"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("6f83a17d-8e9b-477f-93de-ec5a292970d3"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("75efe29f-9a83-421c-b535-83e084a6b3fc"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("8c38ccf5-9fa8-4189-80b0-c8a52742459d"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("ac0828e4-d8a8-434d-8069-c29386dba8ea"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("c5a86210-5703-42b0-91b8-c8226d257731"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValue",
                keyColumn: "Id",
                keyValue: new Guid("ebf90893-46a7-4855-b602-83a8f4084ffc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d3d7a33-0b09-40a7-8fad-50d41b4e44ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87e473d0-05dc-4bfb-b43c-25ccc3b91893"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cad905b8-3d56-4c03-b5e1-a480cb9986d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa0fd5e1-15e3-4028-8f49-d5086b9fc19a"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("06a0382f-b198-4fea-88c0-8180c994d164"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("1f04bfec-9eb9-421d-bd7a-94bf3aeddec6"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("1f255537-eae2-4d23-8742-88ccc129d712"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("4c668a87-63fe-4cf9-acf7-f3ac8f33779f"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("59af4182-4457-4fb1-ad84-d7c4e83ef12e"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("6e12adc3-8f14-402d-9740-b8fbf57b6ab2"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("882b04aa-3643-4e26-9fe9-35cb17d83d2e"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("a4e116b8-c674-453f-b58a-7452f348f12f"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("bcbf3321-b78c-4e56-aa4a-872b87a5897b"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("e24616ca-c5f0-4ad8-aacc-341c8f824802"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("176a8e81-bf4b-4f07-a007-f12852e04efd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42cebe18-5fbc-4042-9966-f75ddbc9fed5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4d7f8ade-b1d6-4bdc-a1ed-4a76ab793bcb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("667ed1ef-2f2c-47fd-a82b-0c7c5bafa262"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77612384-ae54-4edb-8ba2-11a856e87933"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7dbf0a04-fe8f-4263-8819-9554aec17db3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82bec1bc-4295-471c-a592-8f32489d3619"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c690e7ce-ff94-4861-a9f3-605dc2adb245"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("edaca7eb-1117-4e45-94fc-a8938f842036"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb7815e1-ff14-495a-836c-8c99e60f14d3"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("2bc1f455-bafd-4383-a201-707e477bff81"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("32992302-c094-45aa-ba77-8ff46e233e4d"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("582c0d1a-9b0f-4d00-a1c6-f29625d7a221"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("6366b3c6-5b43-4a80-8b80-4325b22afa4e"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("8c714971-5a0e-4df8-8881-7587101c1dac"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("9fe96455-8f95-4f31-9384-80d1e2eb9ade"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c5a9e7a0-23fb-47de-a48b-813b6aa22fac"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d749406e-f2b2-410e-a67f-70f78743e0c9"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("e08243ea-9887-4fd3-849c-a6f7ab52af0e"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("f3e8d31d-96f0-4170-8bed-d1e78d07732e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09ba65e9-85fb-48c0-a28d-81e8ec58407e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("386eb670-6272-4aab-85a1-b9be2e66af07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c9b419d-eea1-4de1-b29c-5ca2e9761c2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74145330-b0d8-49bf-b35b-7a87d7017bd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85fb96ea-3d60-47be-b22d-d07d3141f978"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97efc793-9930-431e-8b26-29eb982da4ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9bd1c74-3e2f-4c06-bb4d-3d2a797281ec"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CustomProperty");

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
    }
}
