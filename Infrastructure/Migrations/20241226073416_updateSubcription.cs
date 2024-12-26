using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateSubcription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiredDate",
                table: "Subscriptions");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Subscriptions",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 350, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 351, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 351, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 7, 34, 14, 354, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 7, 34, 14, 350, DateTimeKind.Utc).AddTicks(7867), new byte[] { 191, 82, 97, 146, 215, 129, 206, 171, 11, 125, 175, 164, 14, 241, 153, 96, 238, 30, 143, 245, 40, 228, 72, 32, 194, 168, 45, 67, 12, 240, 82, 157, 126, 19, 253, 116, 91, 158, 52, 1, 186, 79, 195, 26, 179, 174, 77, 131, 221, 90, 235, 95, 189, 164, 127, 27, 168, 146, 64, 97, 11, 32, 169, 69 }, new byte[] { 225, 12, 99, 56, 44, 254, 105, 144, 226, 197, 50, 96, 87, 20, 57, 121, 113, 236, 194, 31, 49, 216, 202, 40, 19, 195, 144, 183, 236, 233, 83, 110, 131, 201, 63, 194, 103, 78, 56, 51, 83, 91, 253, 81, 75, 231, 220, 5, 124, 126, 90, 110, 82, 128, 21, 175, 41, 143, 151, 181, 168, 2, 225, 12, 143, 152, 158, 92, 59, 231, 104, 179, 142, 4, 207, 150, 9, 213, 61, 234, 157, 142, 37, 85, 167, 173, 164, 241, 85, 15, 46, 112, 57, 65, 207, 250, 171, 0, 52, 70, 251, 56, 187, 110, 228, 122, 0, 74, 53, 29, 66, 110, 243, 102, 218, 131, 144, 48, 98, 233, 87, 207, 145, 194, 254, 154, 127, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 7, 34, 14, 350, DateTimeKind.Utc).AddTicks(7875), new byte[] { 252, 239, 182, 142, 72, 80, 138, 139, 30, 56, 59, 171, 29, 97, 116, 110, 143, 200, 55, 158, 124, 7, 247, 56, 78, 243, 40, 9, 233, 117, 174, 139, 212, 32, 224, 171, 25, 164, 15, 230, 6, 105, 128, 224, 147, 83, 204, 11, 155, 26, 103, 106, 80, 48, 151, 176, 17, 165, 169, 155, 252, 195, 31, 241 }, new byte[] { 174, 101, 221, 87, 139, 172, 189, 246, 219, 27, 186, 183, 109, 46, 123, 244, 194, 123, 198, 76, 220, 190, 133, 142, 59, 195, 126, 130, 62, 252, 130, 105, 167, 207, 111, 208, 83, 163, 10, 160, 91, 10, 25, 155, 216, 83, 186, 71, 44, 51, 13, 90, 147, 182, 189, 233, 79, 185, 96, 35, 236, 229, 87, 127, 80, 98, 41, 152, 204, 166, 15, 42, 183, 111, 181, 250, 93, 155, 55, 9, 253, 192, 218, 39, 140, 246, 229, 240, 31, 245, 79, 207, 19, 109, 55, 223, 83, 139, 165, 120, 34, 154, 30, 40, 39, 251, 169, 202, 2, 165, 141, 194, 27, 98, 201, 252, 86, 72, 58, 17, 155, 25, 185, 169, 214, 67, 17, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 7, 34, 14, 350, DateTimeKind.Utc).AddTicks(7877), new byte[] { 254, 221, 146, 188, 197, 183, 159, 255, 50, 226, 10, 92, 67, 31, 224, 4, 39, 154, 71, 59, 101, 165, 240, 102, 236, 240, 77, 43, 26, 182, 78, 87, 100, 2, 197, 165, 65, 27, 180, 220, 148, 89, 40, 58, 221, 158, 161, 245, 204, 200, 176, 102, 215, 32, 181, 74, 41, 205, 157, 74, 155, 65, 105, 58 }, new byte[] { 94, 159, 100, 18, 212, 25, 255, 48, 212, 186, 91, 78, 165, 24, 231, 233, 241, 179, 186, 144, 94, 114, 125, 0, 91, 111, 182, 1, 104, 14, 182, 140, 137, 113, 230, 179, 95, 57, 247, 246, 89, 211, 83, 93, 23, 242, 108, 12, 243, 22, 68, 63, 60, 239, 55, 204, 10, 23, 167, 240, 141, 99, 104, 216, 217, 179, 54, 41, 237, 63, 142, 204, 230, 236, 69, 43, 156, 186, 97, 64, 211, 60, 3, 41, 226, 249, 184, 88, 173, 238, 90, 127, 66, 142, 175, 216, 154, 33, 247, 160, 254, 47, 1, 238, 214, 112, 210, 130, 229, 104, 119, 222, 182, 79, 160, 246, 82, 78, 99, 172, 97, 133, 50, 141, 39, 150, 109, 107 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 7, 34, 14, 350, DateTimeKind.Utc).AddTicks(7878), new byte[] { 40, 163, 121, 87, 143, 82, 33, 180, 209, 165, 154, 227, 7, 205, 31, 34, 204, 250, 240, 103, 42, 56, 22, 183, 248, 76, 186, 224, 125, 214, 39, 105, 43, 36, 204, 200, 4, 1, 77, 126, 25, 205, 80, 91, 48, 221, 240, 242, 47, 54, 3, 94, 196, 22, 39, 152, 138, 220, 198, 88, 162, 56, 56, 51 }, new byte[] { 191, 69, 248, 204, 244, 207, 91, 9, 106, 212, 231, 230, 224, 193, 70, 255, 149, 59, 69, 174, 142, 141, 163, 89, 14, 139, 29, 185, 105, 40, 187, 41, 198, 106, 95, 68, 19, 111, 48, 205, 254, 27, 114, 156, 185, 240, 218, 66, 29, 241, 208, 149, 161, 218, 51, 92, 213, 171, 174, 194, 147, 160, 138, 251, 202, 18, 15, 244, 201, 97, 169, 89, 246, 5, 90, 181, 171, 79, 203, 99, 77, 66, 190, 249, 15, 32, 183, 195, 59, 227, 233, 7, 251, 83, 114, 5, 57, 195, 63, 174, 34, 225, 180, 113, 171, 236, 214, 161, 56, 250, 163, 78, 162, 92, 21, 235, 253, 93, 188, 179, 219, 179, 111, 164, 220, 58, 73, 68 } });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_ServiceId",
                table: "Subscriptions",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Services_ServiceId",
                table: "Subscriptions",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Services_ServiceId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_ServiceId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Subscriptions");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredDate",
                table: "Subscriptions",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 854, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 855, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 855, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 9, 40, 28, 858, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 9, 40, 28, 854, DateTimeKind.Utc).AddTicks(6907), new byte[] { 206, 112, 134, 30, 137, 109, 223, 56, 180, 240, 114, 58, 180, 55, 39, 156, 74, 191, 47, 198, 7, 43, 60, 96, 42, 2, 122, 117, 73, 160, 199, 165, 92, 2, 116, 106, 34, 203, 85, 10, 46, 111, 134, 19, 203, 255, 83, 15, 178, 31, 79, 71, 75, 48, 21, 143, 3, 195, 242, 45, 51, 218, 40, 142 }, new byte[] { 176, 231, 28, 135, 202, 79, 167, 186, 236, 81, 136, 94, 58, 132, 70, 190, 244, 235, 101, 45, 129, 41, 117, 104, 8, 146, 229, 131, 173, 63, 97, 36, 168, 227, 243, 58, 59, 171, 56, 170, 180, 243, 88, 50, 99, 166, 116, 143, 119, 18, 83, 99, 83, 140, 123, 188, 110, 135, 243, 243, 29, 37, 57, 46, 183, 79, 173, 190, 224, 39, 43, 80, 173, 246, 143, 175, 108, 253, 217, 144, 15, 7, 96, 228, 169, 84, 148, 245, 168, 49, 226, 255, 109, 227, 41, 62, 124, 198, 231, 206, 214, 220, 91, 64, 171, 50, 137, 187, 66, 184, 81, 53, 250, 178, 235, 108, 234, 96, 195, 179, 191, 37, 209, 97, 127, 211, 201, 1 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 9, 40, 28, 854, DateTimeKind.Utc).AddTicks(6916), new byte[] { 84, 157, 3, 35, 78, 101, 44, 3, 109, 73, 198, 133, 95, 16, 169, 199, 97, 140, 52, 228, 178, 130, 84, 6, 68, 97, 36, 156, 222, 173, 93, 163, 67, 94, 100, 17, 185, 170, 222, 2, 87, 135, 189, 153, 155, 12, 242, 250, 177, 78, 254, 235, 163, 154, 216, 250, 241, 101, 135, 167, 240, 29, 164, 152 }, new byte[] { 141, 223, 46, 59, 141, 125, 139, 174, 46, 225, 94, 159, 65, 197, 169, 95, 32, 231, 134, 154, 158, 157, 107, 64, 1, 46, 34, 220, 113, 53, 8, 169, 166, 9, 126, 181, 44, 25, 100, 3, 95, 32, 60, 249, 87, 74, 121, 87, 203, 149, 217, 95, 52, 169, 115, 136, 1, 96, 8, 210, 213, 211, 36, 197, 185, 43, 41, 109, 25, 80, 108, 81, 197, 174, 12, 170, 178, 207, 97, 242, 19, 93, 29, 104, 232, 159, 73, 191, 164, 83, 167, 183, 29, 17, 251, 247, 101, 151, 226, 18, 128, 234, 140, 196, 97, 75, 45, 1, 69, 67, 53, 94, 233, 210, 40, 81, 169, 52, 137, 81, 196, 133, 212, 215, 153, 210, 82, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 9, 40, 28, 854, DateTimeKind.Utc).AddTicks(6918), new byte[] { 106, 105, 108, 41, 240, 67, 10, 15, 134, 182, 115, 96, 29, 219, 210, 134, 145, 46, 83, 243, 36, 208, 182, 224, 229, 123, 241, 251, 107, 229, 115, 21, 122, 170, 5, 41, 193, 71, 84, 86, 174, 71, 53, 66, 148, 184, 254, 239, 194, 127, 43, 135, 189, 135, 162, 69, 50, 136, 160, 138, 7, 215, 246, 125 }, new byte[] { 44, 248, 239, 116, 186, 65, 95, 39, 51, 72, 221, 160, 222, 31, 168, 211, 173, 201, 147, 28, 110, 70, 3, 189, 186, 114, 17, 9, 199, 149, 254, 71, 167, 5, 233, 101, 133, 3, 218, 26, 75, 152, 232, 223, 144, 76, 246, 183, 45, 179, 91, 232, 136, 129, 237, 230, 6, 74, 159, 198, 236, 121, 255, 164, 119, 26, 129, 85, 199, 170, 254, 205, 117, 59, 220, 47, 110, 181, 138, 129, 235, 215, 106, 14, 84, 248, 182, 184, 111, 26, 9, 55, 92, 188, 23, 171, 99, 97, 122, 45, 149, 55, 194, 227, 231, 120, 203, 135, 247, 19, 175, 233, 44, 87, 3, 167, 125, 68, 172, 197, 247, 195, 1, 3, 75, 72, 228, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 9, 40, 28, 854, DateTimeKind.Utc).AddTicks(6920), new byte[] { 139, 139, 48, 108, 104, 99, 46, 26, 99, 230, 12, 226, 180, 65, 124, 30, 86, 49, 230, 218, 7, 70, 43, 225, 173, 153, 191, 148, 121, 206, 40, 146, 42, 255, 221, 102, 111, 61, 149, 49, 182, 17, 199, 252, 105, 158, 235, 193, 124, 110, 48, 237, 74, 56, 46, 91, 113, 13, 150, 205, 80, 40, 151, 131 }, new byte[] { 145, 158, 192, 44, 49, 53, 37, 201, 238, 14, 100, 97, 201, 122, 207, 239, 254, 108, 149, 45, 53, 0, 72, 188, 175, 184, 110, 62, 102, 191, 106, 172, 153, 78, 223, 119, 251, 206, 104, 82, 78, 85, 203, 233, 32, 87, 203, 208, 247, 176, 172, 143, 101, 220, 131, 159, 29, 168, 20, 74, 196, 67, 211, 171, 93, 127, 6, 102, 202, 36, 208, 237, 8, 211, 205, 226, 53, 48, 110, 196, 89, 244, 54, 243, 41, 188, 255, 127, 202, 52, 151, 87, 219, 98, 108, 70, 48, 95, 101, 198, 231, 27, 46, 0, 93, 18, 3, 22, 87, 251, 78, 113, 86, 189, 176, 20, 166, 1, 91, 244, 37, 112, 234, 67, 114, 184, 183, 144 } });
        }
    }
}
