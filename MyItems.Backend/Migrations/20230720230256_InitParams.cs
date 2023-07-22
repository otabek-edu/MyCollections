using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitParams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomPropertyValues_CustomProperties_CustomPropertyId",
                table: "CustomPropertyValues");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ItemId",
                table: "CustomPropertyValues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomPropertyId",
                table: "CustomPropertyValues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "IsBlocked", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("0e59e516-c62a-444b-a5c3-e15a27d6055d"), "Rickey.Smith51@gmail.com", "Rickey", false, false, "Smith", "" },
                    { new Guid("32af82e2-a45a-425b-b49d-d2b7290f47e0"), "Richard_Zulauf@hotmail.com", "Richard", false, false, "Zulauf", "" },
                    { new Guid("44e71406-5828-4460-af12-d5a8e26c1ba3"), "Kelley_Franecki@yahoo.com", "Kelley", false, false, "Franecki", "" },
                    { new Guid("5cd547e5-3575-40b6-942a-51d32ad6b3e3"), "Kathryn47@hotmail.com", "Kathryn", false, false, "Corkery", "" },
                    { new Guid("77873d29-1f12-4159-b8bd-0c5149f8f257"), "Regina.Sporer86@hotmail.com", "Regina", false, false, "Sporer", "" },
                    { new Guid("84f4c24e-908d-4524-9f90-0f15a20ae9ec"), "otabek.r743@gmail.com", "Admin", true, false, "Admin", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==" },
                    { new Guid("8e347306-99ce-4d37-abb8-2bdabf353cc7"), "Hope28@gmail.com", "Hope", false, false, "Hettinger", "" },
                    { new Guid("bf466c09-3f00-4f16-a5cb-ff84fb7861e6"), "Eunice82@yahoo.com", "Eunice", false, false, "Mills", "" },
                    { new Guid("d3d4b2e0-1c22-4d61-9ba6-586555aa136a"), "Lora.Prosacco23@yahoo.com", "Lora", false, false, "Prosacco", "" },
                    { new Guid("f896d352-27af-472b-876e-5ca6a7e90100"), "Paula.Prohaska88@yahoo.com", "Paula", false, false, "Prohaska", "" },
                    { new Guid("ff4d07b3-241f-4f9f-8229-192bd1d0630d"), "Luz_Runolfsdottir32@yahoo.com", "Luz", false, false, "Runolfsdottir", "" }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Theme", "UserId" },
                values: new object[,]
                {
                    { new Guid("17cadfc1-a011-41da-9367-0d2947f88f15"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=422", "Handcrafted Metal Ball", "Licensed", new Guid("0e59e516-c62a-444b-a5c3-e15a27d6055d") },
                    { new Guid("1812560e-7327-410f-843d-013301cfbd4c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=496", "Practical Granite Soap", "Intelligent", new Guid("8e347306-99ce-4d37-abb8-2bdabf353cc7") },
                    { new Guid("280ae474-e15b-407c-94ae-328d5c32f867"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=307", "Handmade Frozen Soap", "Handcrafted", new Guid("bf466c09-3f00-4f16-a5cb-ff84fb7861e6") },
                    { new Guid("380588c3-8cec-42f2-9030-d9a7f1d9cf92"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=1076", "Gorgeous Frozen Chicken", "Handcrafted", new Guid("bf466c09-3f00-4f16-a5cb-ff84fb7861e6") },
                    { new Guid("75052dd1-b358-4a27-ba9d-52b803b8d4dc"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://picsum.photos/640/480/?image=842", "Practical Soft Cheese", "Refined", new Guid("77873d29-1f12-4159-b8bd-0c5149f8f257") },
                    { new Guid("77df4d2f-b143-4194-b5e8-f0656999e63b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://picsum.photos/640/480/?image=28", "Gorgeous Concrete Chicken", "Ergonomic", new Guid("8e347306-99ce-4d37-abb8-2bdabf353cc7") },
                    { new Guid("7a53ed42-6a05-458a-ae8e-1adf376232ff"), "The Football Is Good For Training And Recreational Purposes", "https://picsum.photos/640/480/?image=685", "Ergonomic Frozen Car", "Handcrafted", new Guid("77873d29-1f12-4159-b8bd-0c5149f8f257") },
                    { new Guid("80e89b88-ddf4-438d-87b5-9a73119dd626"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://picsum.photos/640/480/?image=0", "Sleek Rubber Chicken", "Licensed", new Guid("44e71406-5828-4460-af12-d5a8e26c1ba3") },
                    { new Guid("fb427abf-09ce-481c-ad68-1909d98c6474"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://picsum.photos/640/480/?image=689", "Unbranded Cotton Gloves", "Ergonomic", new Guid("f896d352-27af-472b-876e-5ca6a7e90100") },
                    { new Guid("fba61572-e08f-48a1-a92f-a0e9cc03db69"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://picsum.photos/640/480/?image=792", "Awesome Steel Car", "Licensed", new Guid("bf466c09-3f00-4f16-a5cb-ff84fb7861e6") }
                });

            migrationBuilder.InsertData(
                table: "CustomProperties",
                columns: new[] { "Id", "CollectionId", "Name", "TypeProperty" },
                values: new object[,]
                {
                    { new Guid("27eb8cfe-39c9-4e7b-9aeb-116ba147fbd5"), new Guid("380588c3-8cec-42f2-9030-d9a7f1d9cf92"), "Ward - Dickens", "dateTime" },
                    { new Guid("2e433225-c320-417d-b282-8a82d3280d96"), new Guid("280ae474-e15b-407c-94ae-328d5c32f867"), "Bailey and Sons", "dateTime" },
                    { new Guid("2f81bb1b-db00-4dc9-88f0-a51beb9bb41f"), new Guid("fba61572-e08f-48a1-a92f-a0e9cc03db69"), "Hirthe - Keeling", "dateTime" },
                    { new Guid("3d354896-040e-4f84-8340-9616bd30f871"), new Guid("75052dd1-b358-4a27-ba9d-52b803b8d4dc"), "Bruen, Buckridge and Bogisich", "boolean" },
                    { new Guid("64e23e76-13a5-4b89-892e-4828e5e16865"), new Guid("fb427abf-09ce-481c-ad68-1909d98c6474"), "Shields - West", "dateTime" },
                    { new Guid("6587a99d-8114-47e2-8955-86f8fbb476e3"), new Guid("17cadfc1-a011-41da-9367-0d2947f88f15"), "Considine Inc", "string" },
                    { new Guid("96f59deb-02bf-41a4-9010-53aa9afcdb88"), new Guid("1812560e-7327-410f-843d-013301cfbd4c"), "Ward - Douglas", "boolean" },
                    { new Guid("bafb518c-78b7-4bc0-b659-edb089369f07"), new Guid("80e89b88-ddf4-438d-87b5-9a73119dd626"), "Volkman - Koch", "boolean" },
                    { new Guid("f05ad174-b7a9-447b-a492-ce08a1ce8c84"), new Guid("77df4d2f-b143-4194-b5e8-f0656999e63b"), "Trantow Inc", "dateTime" },
                    { new Guid("f8902c15-6441-49da-af15-3d83dd925778"), new Guid("7a53ed42-6a05-458a-ae8e-1adf376232ff"), "Weimann - Predovic", "number" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("4d9d2cf8-8c47-43af-aff1-f5848aeddc70"), new Guid("fba61572-e08f-48a1-a92f-a0e9cc03db69"), new DateTime(2022, 10, 9, 2, 27, 18, 441, DateTimeKind.Local).AddTicks(3885), "Licensed Rubber Fish" },
                    { new Guid("5d343bee-0770-4fdb-bfc5-03350d66ec4d"), new Guid("380588c3-8cec-42f2-9030-d9a7f1d9cf92"), new DateTime(2022, 9, 21, 12, 6, 55, 494, DateTimeKind.Local).AddTicks(6970), "Fantastic Frozen Hat" },
                    { new Guid("5d9e1b3c-e1eb-4c45-b060-de615fbb2802"), new Guid("80e89b88-ddf4-438d-87b5-9a73119dd626"), new DateTime(2023, 4, 3, 5, 49, 13, 919, DateTimeKind.Local).AddTicks(689), "Gorgeous Soft Shoes" },
                    { new Guid("78649ca1-b9a2-46ac-99d3-aaf14071f0a2"), new Guid("280ae474-e15b-407c-94ae-328d5c32f867"), new DateTime(2022, 11, 9, 7, 12, 44, 164, DateTimeKind.Local).AddTicks(7455), "Generic Plastic Fish" },
                    { new Guid("9de54a09-5879-4060-aeea-5ccd403198cf"), new Guid("77df4d2f-b143-4194-b5e8-f0656999e63b"), new DateTime(2022, 8, 30, 13, 8, 19, 897, DateTimeKind.Local).AddTicks(1064), "Handmade Granite Salad" },
                    { new Guid("b4da7705-33e2-4a2a-9af8-ade7cf8b4672"), new Guid("1812560e-7327-410f-843d-013301cfbd4c"), new DateTime(2022, 11, 15, 13, 3, 40, 662, DateTimeKind.Local).AddTicks(2601), "Licensed Fresh Sausages" },
                    { new Guid("b9563f19-6d77-4e2a-b571-2658ac9ed01a"), new Guid("17cadfc1-a011-41da-9367-0d2947f88f15"), new DateTime(2022, 10, 2, 10, 39, 23, 296, DateTimeKind.Local).AddTicks(4177), "Incredible Concrete Chicken" },
                    { new Guid("c26728fc-8ed7-4c9e-9d9b-49c2a7271346"), new Guid("7a53ed42-6a05-458a-ae8e-1adf376232ff"), new DateTime(2022, 10, 15, 6, 31, 32, 150, DateTimeKind.Local).AddTicks(9640), "Awesome Plastic Chair" },
                    { new Guid("d08a3072-8503-45ee-a7bd-0010b04e33dc"), new Guid("fb427abf-09ce-481c-ad68-1909d98c6474"), new DateTime(2023, 3, 26, 2, 8, 43, 142, DateTimeKind.Local).AddTicks(5819), "Fantastic Plastic Pants" },
                    { new Guid("ffa6c91e-5c11-4811-94ee-30a66b48952b"), new Guid("75052dd1-b358-4a27-ba9d-52b803b8d4dc"), new DateTime(2023, 3, 16, 12, 42, 13, 976, DateTimeKind.Local).AddTicks(5181), "Sleek Frozen Cheese" }
                });

            migrationBuilder.InsertData(
                table: "CustomPropertyValues",
                columns: new[] { "Id", "CustomPropertyId", "ItemId", "Value" },
                values: new object[,]
                {
                    { new Guid("0557fc86-26e8-480e-aed1-a64b453db59f"), new Guid("f05ad174-b7a9-447b-a492-ce08a1ce8c84"), new Guid("9de54a09-5879-4060-aeea-5ccd403198cf"), "Practical Fresh Bacon" },
                    { new Guid("10938d8b-5e5b-400c-ab37-b77ae91bcc2a"), new Guid("bafb518c-78b7-4bc0-b659-edb089369f07"), new Guid("5d9e1b3c-e1eb-4c45-b060-de615fbb2802"), "Practical Granite Soap" },
                    { new Guid("154db740-488c-4f74-905f-347452207e98"), new Guid("27eb8cfe-39c9-4e7b-9aeb-116ba147fbd5"), new Guid("5d343bee-0770-4fdb-bfc5-03350d66ec4d"), "Licensed Fresh Table" },
                    { new Guid("2085c9bd-329f-4b58-9bc9-e325c5faec7f"), new Guid("f8902c15-6441-49da-af15-3d83dd925778"), new Guid("c26728fc-8ed7-4c9e-9d9b-49c2a7271346"), "Licensed Metal Chair" },
                    { new Guid("5d52c54d-4f41-4ede-9404-a922f45af407"), new Guid("6587a99d-8114-47e2-8955-86f8fbb476e3"), new Guid("b9563f19-6d77-4e2a-b571-2658ac9ed01a"), "Fantastic Frozen Tuna" },
                    { new Guid("65934031-3ca1-4796-a04b-ea7bbe5cb1b4"), new Guid("64e23e76-13a5-4b89-892e-4828e5e16865"), new Guid("d08a3072-8503-45ee-a7bd-0010b04e33dc"), "Refined Rubber Chips" },
                    { new Guid("7205cec8-0468-4fab-930e-6293138aa631"), new Guid("3d354896-040e-4f84-8340-9616bd30f871"), new Guid("ffa6c91e-5c11-4811-94ee-30a66b48952b"), "Tasty Granite Car" },
                    { new Guid("8a016c89-fb78-4e72-85aa-eb437f532f0c"), new Guid("2f81bb1b-db00-4dc9-88f0-a51beb9bb41f"), new Guid("4d9d2cf8-8c47-43af-aff1-f5848aeddc70"), "Sleek Wooden Sausages" },
                    { new Guid("cbbee14e-c972-4ee7-9ec1-2a38f27e618c"), new Guid("96f59deb-02bf-41a4-9010-53aa9afcdb88"), new Guid("b4da7705-33e2-4a2a-9af8-ade7cf8b4672"), "Rustic Concrete Bike" },
                    { new Guid("e73d21b1-5e42-43c2-b5b6-1ce85d3a195c"), new Guid("2e433225-c320-417d-b282-8a82d3280d96"), new Guid("78649ca1-b9a2-46ac-99d3-aaf14071f0a2"), "Licensed Wooden Towels" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPropertyValues_CustomProperties_CustomPropertyId",
                table: "CustomPropertyValues",
                column: "CustomPropertyId",
                principalTable: "CustomProperties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomPropertyValues_CustomProperties_CustomPropertyId",
                table: "CustomPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues");

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("0557fc86-26e8-480e-aed1-a64b453db59f"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("10938d8b-5e5b-400c-ab37-b77ae91bcc2a"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("154db740-488c-4f74-905f-347452207e98"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("2085c9bd-329f-4b58-9bc9-e325c5faec7f"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("5d52c54d-4f41-4ede-9404-a922f45af407"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("65934031-3ca1-4796-a04b-ea7bbe5cb1b4"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("7205cec8-0468-4fab-930e-6293138aa631"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("8a016c89-fb78-4e72-85aa-eb437f532f0c"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("cbbee14e-c972-4ee7-9ec1-2a38f27e618c"));

            migrationBuilder.DeleteData(
                table: "CustomPropertyValues",
                keyColumn: "Id",
                keyValue: new Guid("e73d21b1-5e42-43c2-b5b6-1ce85d3a195c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32af82e2-a45a-425b-b49d-d2b7290f47e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cd547e5-3575-40b6-942a-51d32ad6b3e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84f4c24e-908d-4524-9f90-0f15a20ae9ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3d4b2e0-1c22-4d61-9ba6-586555aa136a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff4d07b3-241f-4f9f-8229-192bd1d0630d"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("27eb8cfe-39c9-4e7b-9aeb-116ba147fbd5"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("2e433225-c320-417d-b282-8a82d3280d96"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("2f81bb1b-db00-4dc9-88f0-a51beb9bb41f"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("3d354896-040e-4f84-8340-9616bd30f871"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("64e23e76-13a5-4b89-892e-4828e5e16865"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("6587a99d-8114-47e2-8955-86f8fbb476e3"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("96f59deb-02bf-41a4-9010-53aa9afcdb88"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("bafb518c-78b7-4bc0-b659-edb089369f07"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("f05ad174-b7a9-447b-a492-ce08a1ce8c84"));

            migrationBuilder.DeleteData(
                table: "CustomProperties",
                keyColumn: "Id",
                keyValue: new Guid("f8902c15-6441-49da-af15-3d83dd925778"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4d9d2cf8-8c47-43af-aff1-f5848aeddc70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5d343bee-0770-4fdb-bfc5-03350d66ec4d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5d9e1b3c-e1eb-4c45-b060-de615fbb2802"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("78649ca1-b9a2-46ac-99d3-aaf14071f0a2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9de54a09-5879-4060-aeea-5ccd403198cf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4da7705-33e2-4a2a-9af8-ade7cf8b4672"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b9563f19-6d77-4e2a-b571-2658ac9ed01a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c26728fc-8ed7-4c9e-9d9b-49c2a7271346"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d08a3072-8503-45ee-a7bd-0010b04e33dc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ffa6c91e-5c11-4811-94ee-30a66b48952b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("17cadfc1-a011-41da-9367-0d2947f88f15"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("1812560e-7327-410f-843d-013301cfbd4c"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("280ae474-e15b-407c-94ae-328d5c32f867"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("380588c3-8cec-42f2-9030-d9a7f1d9cf92"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("75052dd1-b358-4a27-ba9d-52b803b8d4dc"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("77df4d2f-b143-4194-b5e8-f0656999e63b"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("7a53ed42-6a05-458a-ae8e-1adf376232ff"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("80e89b88-ddf4-438d-87b5-9a73119dd626"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("fb427abf-09ce-481c-ad68-1909d98c6474"));

            migrationBuilder.DeleteData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: new Guid("fba61572-e08f-48a1-a92f-a0e9cc03db69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e59e516-c62a-444b-a5c3-e15a27d6055d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44e71406-5828-4460-af12-d5a8e26c1ba3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77873d29-1f12-4159-b8bd-0c5149f8f257"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e347306-99ce-4d37-abb8-2bdabf353cc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bf466c09-3f00-4f16-a5cb-ff84fb7861e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f896d352-27af-472b-876e-5ca6a7e90100"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ItemId",
                table: "CustomPropertyValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomPropertyId",
                table: "CustomPropertyValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                name: "FK_CustomPropertyValues_CustomProperties_CustomPropertyId",
                table: "CustomPropertyValues",
                column: "CustomPropertyId",
                principalTable: "CustomProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomPropertyValues_Items_ItemId",
                table: "CustomPropertyValues",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
