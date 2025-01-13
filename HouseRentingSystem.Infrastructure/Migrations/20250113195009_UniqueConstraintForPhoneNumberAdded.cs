using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "499e5abc-6cbf-4979-9cbf-eaf8d4055f3d", "AQAAAAEAACcQAAAAEMbS/DsFasyro+LnismKDBru+KnXAfKFX1u/ybKVBGx78Ri502xqA9j+QLhkPZf+WQ==", "7515376d-0025-4d81-973a-a465d0feba25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2131358-3fa8-44fd-a83a-4e713f7871c9", "AQAAAAEAACcQAAAAEL8i2MXYkRbXnlEoJtJXSUKbnqDT1Vk7qoEJH6FqkpJgKiq3pWCSydHJH2bnh8BwlQ==", "cfa8b47b-8c80-4cf9-9542-9027fbf1466d" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d521324c-981a-49ac-9a9c-da0eb16a71ac", "AQAAAAEAACcQAAAAEGzt+ZREQ80FZOvXikgC8BR79jvIbUwCYqgw+TrSyZe8LmLBJVTMJKjsUPnCZ4uyEw==", "f3a2849e-19a1-42a5-99dc-22ede0d6479b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b53e2c10-095e-4156-8e20-d9b1ae718245", "AQAAAAEAACcQAAAAELhUHRDQIN8mDI6w65/c1NIUWIqmG2c15tA5nC9jXCCTyLxJYDbaYYeszoNxvXRJAQ==", "866fe8d8-164d-42c0-b9bf-8caf30b92785" });
        }
    }
}
