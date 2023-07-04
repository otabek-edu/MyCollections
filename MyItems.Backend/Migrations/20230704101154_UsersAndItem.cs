using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyItems.Backend.Migrations
{
    /// <inheritdoc />
    public partial class UsersAndItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "IsAdmin", "LastName", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("005ad8a6-d1f5-48e0-83c0-7ec37edfa8ea"), "Marsha.Larkin@gmail.com", "Marsha", false, "Larkin", "" },
                    { new Guid("00ca218e-73a2-4a93-9cad-a0160f6ca0dd"), "Hazel69@yahoo.com", "Hazel", false, "Gulgowski", "" },
                    { new Guid("014f93e1-24a0-4771-91b2-03e14d08bce7"), "Lisa58@gmail.com", "Lisa", false, "Cormier", "" },
                    { new Guid("025ef259-0368-4643-9d98-f78a5fd79123"), "Beatrice.Gislason@gmail.com", "Beatrice", false, "Gislason", "" },
                    { new Guid("02b660ba-8f01-443a-935d-000b6a793285"), "Lucille.Langosh5@yahoo.com", "Lucille", false, "Langosh", "" },
                    { new Guid("05131e99-aaa8-4bd1-9bae-c93224e581f7"), "Myra58@hotmail.com", "Myra", false, "Kertzmann", "" },
                    { new Guid("085faca8-e4aa-4e18-9329-ae4b0e9a302f"), "Kristine67@gmail.com", "Kristine", false, "Beatty", "" },
                    { new Guid("089e6d5c-ec8c-472a-b0ba-fedcdeec67b8"), "Monica.Thompson64@hotmail.com", "Monica", false, "Thompson", "" },
                    { new Guid("0a64c8ec-ba89-4b31-9796-191726bd8b71"), "Olivia.Mertz9@yahoo.com", "Olivia", false, "Mertz", "" },
                    { new Guid("0a92702e-d715-4ed0-a785-cdf7e45d3c6e"), "Shawn_Schmeler@hotmail.com", "Shawn", false, "Schmeler", "" },
                    { new Guid("0cefaed9-cb19-4833-a953-f87a0d41dfce"), "Anthony12@gmail.com", "Anthony", false, "Schneider", "" },
                    { new Guid("111c7561-d2ce-4cf1-8b34-e282853ab7d4"), "Orlando.Kessler68@gmail.com", "Orlando", false, "Kessler", "" },
                    { new Guid("133883a7-2a84-4fd7-95b6-041a4dc18d6b"), "Winifred.Lakin@gmail.com", "Winifred", false, "Lakin", "" },
                    { new Guid("14ca4e81-c5f9-444e-b760-53b31b4f7c86"), "Elvira53@yahoo.com", "Elvira", false, "Pagac", "" },
                    { new Guid("1b6f00bd-2384-4909-9136-699aca0c8c9b"), "Gretchen.Bartell@yahoo.com", "Gretchen", false, "Bartell", "" },
                    { new Guid("20a4b67e-3d40-4b1e-94ca-152c84003f59"), "Ed.Goldner50@yahoo.com", "Ed", false, "Goldner", "" },
                    { new Guid("20e606ee-dec5-4d6a-868f-b06b8a60b537"), "Ruth_Boyer@yahoo.com", "Ruth", false, "Boyer", "" },
                    { new Guid("25d4b419-8796-4805-b92c-5b5ac7de71dd"), "Laura.Jacobi97@hotmail.com", "Laura", false, "Jacobi", "" },
                    { new Guid("29dcffc2-8a7c-4acc-b9f5-1c9107774e38"), "Jack.Fadel38@hotmail.com", "Jack", false, "Fadel", "" },
                    { new Guid("2a50c99b-2e0a-4934-977a-191191f7d1e8"), "Mike55@gmail.com", "Mike", false, "Ernser", "" },
                    { new Guid("2a77e367-ae20-4693-9893-538385400a83"), "Josh30@yahoo.com", "Josh", false, "Hodkiewicz", "" },
                    { new Guid("2ae6c847-18b5-4f62-8a34-5d3b31950115"), "Marie.Koch99@gmail.com", "Marie", false, "Koch", "" },
                    { new Guid("2ce8a8ce-b76e-49c7-9611-58b5fb060a4c"), "Pedro27@yahoo.com", "Pedro", false, "Schmidt", "" },
                    { new Guid("2f4d569a-37fb-4594-a9a5-767983ceec8d"), "Roxanne.Macejkovic@yahoo.com", "Roxanne", false, "Macejkovic", "" },
                    { new Guid("30a075c6-7226-4534-b99e-38d2a61cf948"), "Tony.Harvey55@yahoo.com", "Tony", false, "Harvey", "" },
                    { new Guid("34d2659b-0b69-4187-92c1-cbe800b827af"), "Jana_Murphy10@yahoo.com", "Jana", false, "Murphy", "" },
                    { new Guid("358180c2-0500-412d-bd5d-24289827a7a4"), "Sidney.Auer@hotmail.com", "Sidney", false, "Auer", "" },
                    { new Guid("35bb932c-bb9e-4f95-85e8-138d95218b24"), "Patty.Tillman@yahoo.com", "Patty", false, "Tillman", "" },
                    { new Guid("3879ee5f-3169-4655-bf2f-0ffd8324678a"), "Mary_Feest78@hotmail.com", "Mary", false, "Feest", "" },
                    { new Guid("38fb925b-4057-44fb-9460-61b6ca6351d9"), "Julius68@hotmail.com", "Julius", false, "Sanford", "" },
                    { new Guid("3b43581c-9a8e-4cba-9c06-f37650e88cb5"), "Amanda32@yahoo.com", "Amanda", false, "Fadel", "" },
                    { new Guid("41394ef8-2cd2-44ad-a532-1f254a19ee86"), "Lori.Bergnaum@gmail.com", "Lori", false, "Bergnaum", "" },
                    { new Guid("4342973b-ee5b-4e6c-942c-eeb2ef3f8958"), "Angel74@gmail.com", "Angel", false, "Funk", "" },
                    { new Guid("46f0c949-e55e-452e-a04e-b44a374d8279"), "Chad_Kuphal@gmail.com", "Chad", false, "Kuphal", "" },
                    { new Guid("47a7428c-9b35-460c-8e25-62d3be9147ab"), "Lawrence45@gmail.com", "Lawrence", false, "Ortiz", "" },
                    { new Guid("4cdc370a-5c9a-447e-b7aa-61406cc9e1a1"), "Hugo_OReilly@hotmail.com", "Hugo", false, "O'Reilly", "" },
                    { new Guid("51116616-2679-434c-8217-6c821576d73d"), "Bernadette79@gmail.com", "Bernadette", false, "Medhurst", "" },
                    { new Guid("55eb161a-44d2-46c2-8d37-d34b3e402e75"), "Lewis.Yost@yahoo.com", "Lewis", false, "Yost", "" },
                    { new Guid("5aa9c965-5dc2-40e5-9f63-97812c4df218"), "Ellis.Lockman@hotmail.com", "Ellis", false, "Lockman", "" },
                    { new Guid("5b7c7089-0efc-4be2-85f7-6c19f40ce596"), "Clarence_Bogan@hotmail.com", "Clarence", false, "Bogan", "" },
                    { new Guid("5bf3ca5e-a23d-42bc-be6f-167a0b6b0448"), "Myra_Brekke@yahoo.com", "Myra", false, "Brekke", "" },
                    { new Guid("5f279b36-9a31-41f9-a9a0-1fe1a3b637c9"), "Wendy2@hotmail.com", "Wendy", false, "Gaylord", "" },
                    { new Guid("64ad73e7-4756-48aa-af3e-c501d2a0559c"), "Emmett_Cronin10@gmail.com", "Emmett", false, "Cronin", "" },
                    { new Guid("6b1359de-5155-4f30-bb73-2400f1ce4d03"), "Isaac.King@gmail.com", "Isaac", false, "King", "" },
                    { new Guid("7bd52d86-49c5-4522-a2fa-3f7612f1f73a"), "Carla.West3@hotmail.com", "Carla", false, "West", "" },
                    { new Guid("7c9464bd-303c-4477-9f2f-b62e78ac290d"), "Garrett_Renner3@hotmail.com", "Garrett", false, "Renner", "" },
                    { new Guid("7e2eaf91-aa94-4e7c-80aa-1df2c70dcb04"), "Rolando_Medhurst51@hotmail.com", "Rolando", false, "Medhurst", "" },
                    { new Guid("7f3fee62-0670-48d8-9851-781e02b7667d"), "Corey.Kemmer77@yahoo.com", "Corey", false, "Kemmer", "" },
                    { new Guid("7f52b58c-4d3a-4063-a301-bd9642e5d11d"), "Fernando60@yahoo.com", "Fernando", false, "Simonis", "" },
                    { new Guid("7fdaa8e4-5188-4e70-bd11-440b9c61767f"), "Kelly37@gmail.com", "Kelly", false, "Hermann", "" },
                    { new Guid("80279985-6615-4b70-a57b-9f789ae279d4"), "Wade_Macejkovic55@hotmail.com", "Wade", false, "Macejkovic", "" },
                    { new Guid("808be1b0-5d0a-4060-8702-4fa7878ab121"), "Tanya.Collier@yahoo.com", "Tanya", false, "Collier", "" },
                    { new Guid("8154be14-b256-4fd8-af90-ccce5db6a81c"), "Raymond41@hotmail.com", "Raymond", false, "Gerlach", "" },
                    { new Guid("837fe6c9-8f2b-46d8-ac77-e0c03932d5fc"), "Lee50@gmail.com", "Lee", false, "Block", "" },
                    { new Guid("8d9b98df-3394-4e59-a76b-f04869286f96"), "Grady28@yahoo.com", "Grady", false, "Turner", "" },
                    { new Guid("8ea302c0-7fc0-46dc-86b5-005c38d0362f"), "Lionel.Konopelski@hotmail.com", "Lionel", false, "Konopelski", "" },
                    { new Guid("8fa387dd-17b8-4254-a840-f9a383d600ad"), "Kate95@yahoo.com", "Kate", false, "Halvorson", "" },
                    { new Guid("91bd6b32-654f-400f-923a-0caf76a0d0a4"), "Lynne2@gmail.com", "Lynne", false, "Orn", "" },
                    { new Guid("96db09c8-2f24-41d1-8f7c-44a90841c9c9"), "Melanie.Kunde@yahoo.com", "Melanie", false, "Kunde", "" },
                    { new Guid("98de820e-5bcd-4edf-a072-d9dfa25d1e7f"), "Adrienne.Kiehn1@yahoo.com", "Adrienne", false, "Kiehn", "" },
                    { new Guid("a0964213-378f-4a3d-8974-53fd886c2164"), "Gayle2@gmail.com", "Gayle", false, "Mayer", "" },
                    { new Guid("a64590cc-7014-4b6c-95c8-81797308a9fe"), "Leona_Graham@gmail.com", "Leona", false, "Graham", "" },
                    { new Guid("a80b2a2a-384e-44ba-9ce9-a1393510f7ac"), "Alfonso_Satterfield33@yahoo.com", "Alfonso", false, "Satterfield", "" },
                    { new Guid("a902f723-9ded-4e0a-8738-dbcddcd7b0b1"), "Tara_Rogahn@yahoo.com", "Tara", false, "Rogahn", "" },
                    { new Guid("ab707a80-1aeb-4241-af8e-e199cc627220"), "Stewart.Mertz77@gmail.com", "Stewart", false, "Mertz", "" },
                    { new Guid("abfa4bd0-2986-43bf-b86b-e69a9cf082bb"), "Stephanie.OKeefe@hotmail.com", "Stephanie", false, "O'Keefe", "" },
                    { new Guid("acf79066-bf70-49c2-8309-af7886309349"), "Jenna_Hegmann@yahoo.com", "Jenna", false, "Hegmann", "" },
                    { new Guid("aefdbc1a-df12-44fc-afe9-435d706efbff"), "Ruby.Ferry@gmail.com", "Ruby", false, "Ferry", "" },
                    { new Guid("b26d4843-0d6c-4b80-9fb8-4f3ab8a23433"), "Herbert.Kunde@yahoo.com", "Herbert", false, "Kunde", "" },
                    { new Guid("b4a84ee8-5c76-4338-bfed-2aaebfea6648"), "Ross.Steuber@yahoo.com", "Ross", false, "Steuber", "" },
                    { new Guid("b5973ea0-9c6c-46ab-ac59-fa2f47390513"), "Ray_Bernhard@yahoo.com", "Ray", false, "Bernhard", "" },
                    { new Guid("b5b51c3e-6122-4728-b3fb-a82de7190c76"), "Matthew.Cronin67@yahoo.com", "Matthew", false, "Cronin", "" },
                    { new Guid("b8ab0329-4cdf-4407-96fd-8d688a5d2035"), "Alyssa.Schiller17@yahoo.com", "Alyssa", false, "Schiller", "" },
                    { new Guid("b8acf611-188f-4bd0-b306-40ae0bbf2ea6"), "Eugene_Heller13@yahoo.com", "Eugene", false, "Heller", "" },
                    { new Guid("b9c37284-884c-4835-8535-6b0c9308a3f3"), "Alton29@hotmail.com", "Alton", false, "Bartell", "" },
                    { new Guid("bde60a12-6366-43b5-8a19-fac52cc90056"), "Kari52@hotmail.com", "Kari", false, "Murazik", "" },
                    { new Guid("be891714-6fc4-4548-b123-c165b22a0eb1"), "Kathy_Jones51@gmail.com", "Kathy", false, "Jones", "" },
                    { new Guid("c090bb74-e8ef-41f2-be19-512dc1a6a666"), "Paula32@gmail.com", "Paula", false, "Torp", "" },
                    { new Guid("c40db953-0063-4310-ac45-242fd51c9007"), "Barry.Moen@hotmail.com", "Barry", false, "Moen", "" },
                    { new Guid("c946b0b1-91df-423b-b374-bf1f6640b441"), "Jean.Fritsch77@hotmail.com", "Jean", false, "Fritsch", "" },
                    { new Guid("c9a059b7-1665-4855-8265-9cce3eef77de"), "Leslie64@yahoo.com", "Leslie", false, "Willms", "" },
                    { new Guid("cd2bd3f9-3632-49a4-be06-85ddd95ca2b4"), "Julie.Pacocha99@yahoo.com", "Julie", false, "Pacocha", "" },
                    { new Guid("cd357cf6-80c9-4049-aca6-6a678e7d77be"), "Pablo.Halvorson@hotmail.com", "Pablo", false, "Halvorson", "" },
                    { new Guid("d102f04b-c648-46c6-a2eb-0c29420dc242"), "Stacey.Heller11@hotmail.com", "Stacey", false, "Heller", "" },
                    { new Guid("d2337e58-e445-4dfc-96bf-c88814f06468"), "Clarence96@hotmail.com", "Clarence", false, "Rempel", "" },
                    { new Guid("d675faba-c3b9-4db3-a1d5-88bdf146390f"), "Chester_Sawayn5@gmail.com", "Chester", false, "Sawayn", "" },
                    { new Guid("d75319f7-5017-48b6-9d30-43be7050d1f7"), "Edwin49@yahoo.com", "Edwin", false, "Thompson", "" },
                    { new Guid("de7b6e24-dd13-4be0-a5a7-8c640feacd67"), "Eric_Ebert@hotmail.com", "Eric", false, "Ebert", "" },
                    { new Guid("e5ea9271-19b0-47f9-917e-47d7dfffb778"), "Marianne43@hotmail.com", "Marianne", false, "Hand", "" },
                    { new Guid("e740fc39-369d-42dd-9846-ae91f124014f"), "Colleen21@gmail.com", "Colleen", false, "Bergstrom", "" },
                    { new Guid("eafce636-a867-40ff-a234-9b3a8709a4d9"), "Sergio_Fay@gmail.com", "Sergio", false, "Fay", "" },
                    { new Guid("eb9a35f6-7385-4b95-9c57-18be76a43811"), "Marjorie96@gmail.com", "Marjorie", false, "Schmidt", "" },
                    { new Guid("f38cfe9c-38f2-44b2-b48c-bfc1e48d42da"), "Jean.Ledner@yahoo.com", "Jean", false, "Ledner", "" },
                    { new Guid("f48dac65-142e-4664-a6f8-d7159f0d03c0"), "Clifton.Keebler@hotmail.com", "Clifton", false, "Keebler", "" },
                    { new Guid("f52bcc59-493d-4a65-901c-085bf705c555"), "Gary.Haag@gmail.com", "Gary", false, "Haag", "" },
                    { new Guid("f571f135-193c-4a13-81bc-28698833f4d1"), "Tyrone_Huel@gmail.com", "Tyrone", false, "Huel", "" },
                    { new Guid("fafa0261-0cf9-48bd-9bb7-14b70715b70f"), "Mindy.Pfeffer@gmail.com", "Mindy", false, "Pfeffer", "" },
                    { new Guid("fc477cef-8030-4330-8057-20cef31571ee"), "Winston.Schmidt@hotmail.com", "Winston", false, "Schmidt", "" },
                    { new Guid("fd2a573e-4ec3-40c6-ac52-8e744f39fbc6"), "Kellie.Huel@yahoo.com", "Kellie", false, "Huel", "" },
                    { new Guid("ffc5cf32-0ac0-4335-b027-da65c048763c"), "Laura.Ebert80@hotmail.com", "Laura", false, "Ebert", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
