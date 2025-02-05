using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb847566-90ff-4812-93bf-c78257e3fc68", "AQAAAAEAACcQAAAAEDFFS0ytY9VRYkSJxRWx52/tKGImkwmlizkekebtS/QCU8o8KAkTfDw/3PGRNjGXbA==", "4b0a7f55-5f68-47e6-8e3d-03ee1b19e26b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac73751-a9d7-4775-946a-cae9a1ebda1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "926c71c0-5f9b-4c75-8c23-2e17e7dfd5df", "AQAAAAEAACcQAAAAEOz2zIx7X5riK0Dy2PQMjgeqCAXZwJfa1Vxa/OeqhgrYIZw6c3IslmWkMurebeuefg==", "fbd0a598-46be-498e-b79a-18749ae19262" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b629c32-cf52-4cd4-80ce-55ee709d7e55", "AQAAAAEAACcQAAAAEFIJVkttab+OgcdjUBb+fNpM8shRg13lRUEcivmUPoLeXyY5t2bO489AVVK6uisX8g==", "1f9acc00-e3bf-4f70-9e12-8e4355838d0e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f766526-ce3a-4cee-91b7-1d248dc4d81f", "AQAAAAEAACcQAAAAECnsq00IXqtl6/Wy2YNhxSNPg3vsrxLqW5ed8FFYWn1oKp8vBEdHZ41RmX+qJ/i2aQ==", "61f96ed1-0904-4c73-b496-c4125047d91d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac73751-a9d7-4775-946a-cae9a1ebda1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17d140ed-670b-458e-bd78-b1795fe5923f", "AQAAAAEAACcQAAAAEKIVyiexXAW6+THGPBtmDDYIzJ87gdhnpTaQ5yUy6UNNI4UmKI0/BrOn4w3SnWh9Zg==", "bd0d0683-895c-44bb-912f-69d98e571224" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4a74a25-05b8-4846-81b9-d9b725af2f42", "AQAAAAEAACcQAAAAELdiDIyrZbo4g1R+Fsi2uEkTheGb1Sjw0bPudY0Ee5ui9t2RVvQUm0izjTZcivm5Jg==", "ca2f1ab0-6a2a-4fc4-88c6-30cba849083b" });
        }
    }
}
