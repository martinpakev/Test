using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f766526-ce3a-4cee-91b7-1d248dc4d81f", "Guest", "Guestov", "AQAAAAEAACcQAAAAECnsq00IXqtl6/Wy2YNhxSNPg3vsrxLqW5ed8FFYWn1oKp8vBEdHZ41RmX+qJ/i2aQ==", "61f96ed1-0904-4c73-b496-c4125047d91d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4a74a25-05b8-4846-81b9-d9b725af2f42", "Agent", "Agentov", "AQAAAAEAACcQAAAAELdiDIyrZbo4g1R+Fsi2uEkTheGb1Sjw0bPudY0Ee5ui9t2RVvQUm0izjTZcivm5Jg==", "ca2f1ab0-6a2a-4fc4-88c6-30cba849083b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aac73751-a9d7-4775-946a-cae9a1ebda1d", 0, "17d140ed-670b-458e-bd78-b1795fe5923f", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKIVyiexXAW6+THGPBtmDDYIzJ87gdhnpTaQ5yUy6UNNI4UmKI0/BrOn4w3SnWh9Zg==", null, false, "bd0d0683-895c-44bb-912f-69d98e571224", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 7, "+359858858588", "aac73751-a9d7-4775-946a-cae9a1ebda1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac73751-a9d7-4775-946a-cae9a1ebda1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c65d801-0848-4c89-ba94-d187e4e41759", "", "", "AQAAAAEAACcQAAAAEE3rD52DVSMwfLIlosH5Fws31FL5jlFW6FncnXp8eoFv6+jXtOC3OL7E6JL8Hr2RLQ==", "0fa0c366-548d-45d1-ba19-dac978a3c66e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a04a040-06d0-4bc9-9155-585c417f71d9", "", "", "AQAAAAEAACcQAAAAEMI9BZwMCi3vJ/HufkbnGUi5uZQnT1/iJ6tuceRQ/BLjt/W8qTJYUCJhTRqZInOVgQ==", "7b5f8fc7-a03e-4b9b-ba9b-a49a59ec431d" });
        }
    }
}
