using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aef3819-7804-4d72-a6ea-f008508ce3ed", "AQAAAAEAACcQAAAAEKp1SBAd0L941/+UTEr6GFzDRdAlw+0DFSM0V7GcntNShO9/CJn16rqj0vFFUjwCbw==", "da3e5b60-40d5-40b5-8f92-9be239332b98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee27733f-a4cd-4e64-9633-cf592a577265", "AQAAAAEAACcQAAAAEPvgIKX/f+KWHXV+Mqh/eHyK9dPm+zx5e78zTB1FpqpxtfuDuOHbvC+aSK75T6kwtA==", "51445601-7a4f-4db3-a853-f6acdbf071c4" });
        }
    }
}
