using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class RenterUserFKAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "Renter Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Renter Identifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f4fe677-9bc1-4080-8d73-f966366536f1", "AQAAAAEAACcQAAAAEHzvalOVLvjDG1H07gIfxg+1sym+CeBxw3pJJQN/Dn7GfKMCpBVU+u9EpNWH+DH98w==", "1606f19f-bb52-452a-88e2-7434fde36b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac73751-a9d7-4775-946a-cae9a1ebda1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61a84770-56a0-46fc-84ea-bfba1b235f07", "AQAAAAEAACcQAAAAEJ0lTq8ckKdzNeJ657de4m90rrRpS5SQMG6D2Tr3g4pMl3hPCMkn85G+yVI7nYgUyw==", "39b37fdc-3369-4885-bc3f-d9882b2dca7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09042a58-ee89-4b52-ad19-e2fea7a0db74", "AQAAAAEAACcQAAAAENfRDQ15gdyVYbIi9ptAnwite9I0746m9RpE7jSUMB5NwWfg6URk3+sibrzX1Nw2DA==", "4a31db51-fe27-47f6-b7d4-e5acefcfcd35" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Renter Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "Renter Identifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
