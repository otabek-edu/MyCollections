using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class NewUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("0be48fe7-9675-44f7-a407-28de50ce9cbb"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("21d15ec0-74ec-40ad-8956-135fd26250f8"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("26924022-6ef5-49f4-beb1-5d23c5761783"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("4901848a-f569-404a-bd1e-e44e6828e38e"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("9f0c1682-6400-4a96-9f64-8fde7b26732d"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("abb49153-9c49-4285-9f5c-095c85252e88"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("c3e48d35-5e85-416e-9b3e-9789b79054b3"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("d05bb013-8e75-4f00-b529-ec4b143fcc64"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("d70b4ac8-236c-4e5d-a53b-d6e9d0cf180d"));

            migrationBuilder.DeleteData(
                table: "CustomProperty",
                keyColumn: "Id",
                keyValue: new Guid("d901021d-a61f-4b8c-a3c0-2a52ae101ae7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31b88f88-b9e9-489d-8558-fe85927d0b58"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("426f1924-e7a5-4c24-bde1-dc7a34f6a1c0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a6c7d1b-72bb-4527-b67d-768b8f272f99"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5dd30e41-25c5-4cc6-b914-620ed9ddf4b6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60f65c20-aac8-454f-a794-cfad31299699"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8d729491-eb1d-4e97-9ef5-123a82a1fe6f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9d3c7540-b6e3-4f49-b83a-8aa2a2bb9dca"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a43a2e57-85d2-49e9-ad7b-2b520604f54f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ae3395e6-c49c-4384-b8b9-0adca43e1a87"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d3af5e7a-0022-4157-a91c-da6c64043f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26a628c9-6c3d-43b0-b09d-67d5044c3a27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6db41e55-7712-404c-8b84-1e9b78ec29db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("862796db-dda3-4c33-846a-624453bd00f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a0232b6-2718-4664-9b39-1c0948432595"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc9d79bb-5821-4f28-8a91-320047f281ed"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("10e0edbf-79cd-4353-90ef-06c058275bc5"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("39195399-ff7d-4a54-82be-3a89f500e02d"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("58855b8b-d02b-44ea-bf1c-3ae7bc7c3d42"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("5d4ba381-670d-48f9-8b6b-b369717c359b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("92d3a0ab-2605-489c-82d4-5abf4b86b0dc"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c072090c-7ca8-48c1-bc2b-23d031f6378b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("c71578c2-8471-48f5-9870-1723b539a4c5"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("d380640f-762b-448c-a34d-b29e9532e6e8"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("dd713b8b-f776-44ad-b208-7e54f837654d"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("fb727e43-98a7-41b3-a3c3-e62a5fbc3058"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5757d891-4ea8-484c-bda3-da26a608c069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ea66b52-c08b-4b2e-bcf5-c13ec1a66de8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d74393d-7d44-47bc-9fd0-f53ec075971c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5f7a66c-3b87-497b-80da-b01a058c5fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d522cf63-f321-4528-9d42-db2002a024e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f46b2092-b08f-42a1-b66f-f3c6f8af12c4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("26a628c9-6c3d-43b0-b09d-67d5044c3a27"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("5757d891-4ea8-484c-bda3-da26a608c069"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("5ea66b52-c08b-4b2e-bcf5-c13ec1a66de8"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("6db41e55-7712-404c-8b84-1e9b78ec29db"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("7d74393d-7d44-47bc-9fd0-f53ec075971c"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("862796db-dda3-4c33-846a-624453bd00f6"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("9a0232b6-2718-4664-9b39-1c0948432595"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("b5f7a66c-3b87-497b-80da-b01a058c5fd4"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("d522cf63-f321-4528-9d42-db2002a024e3"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" },
                    { new Guid("dc9d79bb-5821-4f28-8a91-320047f281ed"), "otabek.pro@hotmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("f46b2092-b08f-42a1-b66f-f3c6f8af12c4"), "Lloyd.Wehner35@yahoo.com", "Lloyd", false, false, "Wehner", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("10e0edbf-79cd-4353-90ef-06c058275bc5"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://picsum.photos/640/480/?image=621", "Ergonomic Wooden Chair", "Sleek", new Guid("d522cf63-f321-4528-9d42-db2002a024e3") },
                    { new Guid("39195399-ff7d-4a54-82be-3a89f500e02d"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=21", "Awesome Granite Pants", "Ergonomic", new Guid("d522cf63-f321-4528-9d42-db2002a024e3") },
                    { new Guid("58855b8b-d02b-44ea-bf1c-3ae7bc7c3d42"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://picsum.photos/640/480/?image=303", "Generic Steel Salad", "Fantastic", new Guid("f46b2092-b08f-42a1-b66f-f3c6f8af12c4") },
                    { new Guid("5d4ba381-670d-48f9-8b6b-b369717c359b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://picsum.photos/640/480/?image=372", "Generic Granite Cheese", "Practical", new Guid("f46b2092-b08f-42a1-b66f-f3c6f8af12c4") },
                    { new Guid("92d3a0ab-2605-489c-82d4-5abf4b86b0dc"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=791", "Refined Wooden Car", "Tasty", new Guid("d522cf63-f321-4528-9d42-db2002a024e3") },
                    { new Guid("c072090c-7ca8-48c1-bc2b-23d031f6378b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=394", "Refined Soft Tuna", "Intelligent", new Guid("b5f7a66c-3b87-497b-80da-b01a058c5fd4") },
                    { new Guid("c71578c2-8471-48f5-9870-1723b539a4c5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=115", "Practical Wooden Computer", "Tasty", new Guid("d522cf63-f321-4528-9d42-db2002a024e3") },
                    { new Guid("d380640f-762b-448c-a34d-b29e9532e6e8"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://picsum.photos/640/480/?image=915", "Intelligent Steel Keyboard", "Intelligent", new Guid("5757d891-4ea8-484c-bda3-da26a608c069") },
                    { new Guid("dd713b8b-f776-44ad-b208-7e54f837654d"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=470", "Tasty Rubber Bike", "Licensed", new Guid("5ea66b52-c08b-4b2e-bcf5-c13ec1a66de8") },
                    { new Guid("fb727e43-98a7-41b3-a3c3-e62a5fbc3058"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=122", "Small Granite Soap", "Fantastic", new Guid("7d74393d-7d44-47bc-9fd0-f53ec075971c") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperty",
                columns: new[] { "Id", "CollectionId", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("0be48fe7-9675-44f7-a407-28de50ce9cbb"), new Guid("92d3a0ab-2605-489c-82d4-5abf4b86b0dc"), "number" },
                    { new Guid("21d15ec0-74ec-40ad-8956-135fd26250f8"), new Guid("5d4ba381-670d-48f9-8b6b-b369717c359b"), "string" },
                    { new Guid("26924022-6ef5-49f4-beb1-5d23c5761783"), new Guid("d380640f-762b-448c-a34d-b29e9532e6e8"), "boolean" },
                    { new Guid("4901848a-f569-404a-bd1e-e44e6828e38e"), new Guid("39195399-ff7d-4a54-82be-3a89f500e02d"), "boolean" },
                    { new Guid("9f0c1682-6400-4a96-9f64-8fde7b26732d"), new Guid("58855b8b-d02b-44ea-bf1c-3ae7bc7c3d42"), "number" },
                    { new Guid("abb49153-9c49-4285-9f5c-095c85252e88"), new Guid("dd713b8b-f776-44ad-b208-7e54f837654d"), "boolean" },
                    { new Guid("c3e48d35-5e85-416e-9b3e-9789b79054b3"), new Guid("c71578c2-8471-48f5-9870-1723b539a4c5"), "boolean" },
                    { new Guid("d05bb013-8e75-4f00-b529-ec4b143fcc64"), new Guid("10e0edbf-79cd-4353-90ef-06c058275bc5"), "number" },
                    { new Guid("d70b4ac8-236c-4e5d-a53b-d6e9d0cf180d"), new Guid("c072090c-7ca8-48c1-bc2b-23d031f6378b"), "boolean" },
                    { new Guid("d901021d-a61f-4b8c-a3c0-2a52ae101ae7"), new Guid("fb727e43-98a7-41b3-a3c3-e62a5fbc3058"), "dateTime" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("31b88f88-b9e9-489d-8558-fe85927d0b58"), new Guid("c71578c2-8471-48f5-9870-1723b539a4c5"), new DateTime(2023, 6, 2, 14, 39, 30, 544, DateTimeKind.Local).AddTicks(796), "Practical Soft Hat" },
                    { new Guid("426f1924-e7a5-4c24-bde1-dc7a34f6a1c0"), new Guid("92d3a0ab-2605-489c-82d4-5abf4b86b0dc"), new DateTime(2022, 9, 5, 5, 35, 57, 515, DateTimeKind.Local).AddTicks(5768), "Unbranded Cotton Soap" },
                    { new Guid("5a6c7d1b-72bb-4527-b67d-768b8f272f99"), new Guid("58855b8b-d02b-44ea-bf1c-3ae7bc7c3d42"), new DateTime(2023, 2, 11, 5, 51, 23, 363, DateTimeKind.Local).AddTicks(8316), "Gorgeous Rubber Towels" },
                    { new Guid("5dd30e41-25c5-4cc6-b914-620ed9ddf4b6"), new Guid("5d4ba381-670d-48f9-8b6b-b369717c359b"), new DateTime(2023, 5, 8, 5, 6, 55, 26, DateTimeKind.Local).AddTicks(1439), "Tasty Concrete Pants" },
                    { new Guid("60f65c20-aac8-454f-a794-cfad31299699"), new Guid("10e0edbf-79cd-4353-90ef-06c058275bc5"), new DateTime(2023, 1, 13, 13, 43, 23, 509, DateTimeKind.Local).AddTicks(5227), "Ergonomic Cotton Fish" },
                    { new Guid("8d729491-eb1d-4e97-9ef5-123a82a1fe6f"), new Guid("39195399-ff7d-4a54-82be-3a89f500e02d"), new DateTime(2022, 8, 9, 23, 30, 47, 247, DateTimeKind.Local).AddTicks(4158), "Intelligent Rubber Pants" },
                    { new Guid("9d3c7540-b6e3-4f49-b83a-8aa2a2bb9dca"), new Guid("fb727e43-98a7-41b3-a3c3-e62a5fbc3058"), new DateTime(2022, 10, 7, 14, 37, 15, 51, DateTimeKind.Local).AddTicks(7857), "Handmade Wooden Keyboard" },
                    { new Guid("a43a2e57-85d2-49e9-ad7b-2b520604f54f"), new Guid("d380640f-762b-448c-a34d-b29e9532e6e8"), new DateTime(2023, 5, 28, 5, 2, 28, 656, DateTimeKind.Local).AddTicks(8574), "Handcrafted Frozen Hat" },
                    { new Guid("ae3395e6-c49c-4384-b8b9-0adca43e1a87"), new Guid("dd713b8b-f776-44ad-b208-7e54f837654d"), new DateTime(2023, 1, 1, 14, 34, 0, 843, DateTimeKind.Local).AddTicks(9244), "Gorgeous Wooden Pizza" },
                    { new Guid("d3af5e7a-0022-4157-a91c-da6c64043f37"), new Guid("c072090c-7ca8-48c1-bc2b-23d031f6378b"), new DateTime(2023, 6, 30, 16, 10, 51, 502, DateTimeKind.Local).AddTicks(7705), "Sleek Metal Bacon" }
                });
        }
    }
}
