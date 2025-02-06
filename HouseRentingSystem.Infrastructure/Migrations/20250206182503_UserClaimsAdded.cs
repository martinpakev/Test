using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Gestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "aac73751-a9d7-4775-946a-cae9a1ebda1d" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b741785b-34a3-4583-a63c-72c9fc6b2808", "AQAAAAEAACcQAAAAEBtgbmyrrGkqCvSR1C7ZhpA+QiqEbuHhD2Ae/iuQ3vDiCdCJJd5OG28eKNqqpjiBlg==", "947df20f-f85f-4b41-8161-a1faed020c6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac73751-a9d7-4775-946a-cae9a1ebda1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "482afe60-5da7-4f4c-a81b-5c65659f5e0f", "AQAAAAEAACcQAAAAEGc1it2LRLbh3D6YWxDXecI/hYlEWXkQYZD8IKMAfIy+mV0rhpKcGSV0tLbBo3OOtg==", "e6931494-15e8-45e2-8dac-2416ae956aea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "383628dd-54c3-46c2-ade7-27ed6ece58ad", "AQAAAAEAACcQAAAAEAGCgVuaZeuoxaFjMGr3xBvSpDqH2NnjC1qtNOlsGX7KzQ4MvNAAb2HlOe4j3Ke1XA==", "5f9fd4db-1b3f-46ec-b5d3-d563fc44bed5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
