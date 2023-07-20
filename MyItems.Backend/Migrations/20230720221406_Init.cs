using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeProperty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomProperties_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomPropertyValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomPropertyValues_CustomProperties_CustomPropertyId",
                        column: x => x.CustomPropertyId,
                        principalTable: "CustomProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomPropertyValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Collections_UserId",
                table: "Collections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomProperties_CollectionId",
                table: "CustomProperties",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPropertyValues_CustomPropertyId",
                table: "CustomPropertyValues",
                column: "CustomPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPropertyValues_ItemId",
                table: "CustomPropertyValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CollectionId",
                table: "Items",
                column: "CollectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomPropertyValues");

            migrationBuilder.DropTable(
                name: "CustomProperties");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
