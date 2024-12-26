using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsHotInService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isHot",
                table: "Services",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 664, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 664, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3561), new byte[] { 42, 33, 183, 182, 194, 154, 68, 135, 189, 96, 230, 187, 59, 186, 115, 249, 30, 114, 132, 152, 128, 70, 255, 30, 134, 64, 120, 23, 235, 213, 239, 77, 219, 252, 134, 23, 12, 76, 226, 32, 148, 46, 173, 160, 73, 156, 226, 27, 70, 211, 174, 164, 19, 198, 19, 206, 46, 252, 8, 89, 151, 136, 184, 105 }, new byte[] { 96, 22, 102, 253, 28, 124, 103, 129, 103, 11, 217, 56, 91, 169, 224, 184, 147, 76, 44, 188, 46, 45, 203, 47, 208, 115, 176, 177, 69, 135, 43, 39, 176, 238, 22, 50, 16, 214, 194, 215, 114, 179, 16, 66, 63, 105, 216, 161, 197, 178, 215, 250, 225, 197, 255, 227, 210, 241, 245, 180, 102, 77, 108, 32, 204, 205, 152, 61, 84, 1, 21, 87, 163, 134, 2, 67, 120, 38, 98, 197, 195, 214, 168, 130, 204, 254, 23, 254, 239, 229, 38, 66, 252, 168, 89, 179, 226, 242, 8, 225, 32, 83, 132, 74, 182, 196, 169, 226, 45, 72, 90, 26, 222, 201, 49, 139, 16, 145, 153, 174, 165, 132, 214, 255, 231, 237, 79, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3577), new byte[] { 236, 147, 216, 55, 91, 48, 126, 197, 183, 167, 57, 135, 238, 192, 63, 56, 180, 209, 64, 82, 129, 71, 229, 176, 184, 15, 95, 79, 233, 47, 147, 237, 159, 45, 45, 0, 157, 56, 218, 61, 74, 133, 237, 40, 113, 232, 217, 127, 68, 219, 71, 46, 122, 97, 57, 75, 20, 67, 157, 207, 73, 137, 115, 178 }, new byte[] { 240, 78, 45, 0, 236, 230, 96, 127, 133, 4, 144, 81, 56, 81, 34, 19, 174, 108, 20, 209, 126, 118, 64, 125, 49, 21, 150, 6, 227, 71, 22, 17, 215, 199, 247, 186, 67, 70, 109, 14, 117, 202, 132, 253, 252, 25, 215, 69, 35, 198, 21, 70, 245, 220, 176, 123, 227, 126, 216, 245, 104, 209, 33, 51, 8, 239, 183, 35, 133, 94, 21, 209, 198, 246, 52, 205, 41, 12, 77, 238, 145, 49, 209, 93, 24, 207, 194, 22, 242, 49, 182, 31, 17, 233, 214, 228, 128, 215, 104, 195, 66, 213, 172, 167, 14, 143, 218, 237, 156, 92, 151, 119, 164, 70, 62, 198, 128, 238, 127, 49, 7, 66, 127, 56, 56, 86, 166, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3580), new byte[] { 106, 25, 192, 177, 51, 206, 197, 158, 61, 87, 195, 15, 140, 121, 91, 145, 33, 195, 233, 34, 102, 222, 200, 163, 238, 47, 197, 35, 68, 120, 214, 40, 1, 29, 255, 133, 80, 152, 228, 116, 200, 229, 56, 236, 126, 85, 153, 30, 121, 44, 94, 242, 147, 79, 90, 97, 15, 244, 23, 185, 104, 136, 39, 122 }, new byte[] { 5, 214, 176, 138, 123, 25, 215, 158, 233, 118, 68, 59, 24, 77, 180, 188, 55, 83, 158, 180, 160, 251, 173, 134, 77, 55, 60, 192, 148, 228, 133, 74, 153, 64, 3, 115, 242, 91, 62, 248, 144, 181, 27, 189, 91, 123, 152, 20, 204, 84, 203, 222, 24, 214, 109, 28, 44, 125, 64, 199, 66, 11, 138, 86, 134, 156, 236, 1, 76, 146, 180, 119, 94, 34, 9, 10, 93, 150, 160, 162, 246, 173, 66, 255, 199, 5, 82, 46, 52, 192, 122, 68, 46, 197, 52, 29, 85, 51, 90, 165, 215, 142, 111, 33, 73, 168, 134, 106, 249, 106, 74, 37, 173, 182, 135, 70, 32, 197, 182, 241, 65, 106, 175, 199, 5, 253, 223, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3582), new byte[] { 165, 33, 53, 186, 28, 53, 132, 232, 115, 143, 226, 190, 71, 173, 65, 105, 247, 121, 200, 14, 88, 15, 205, 25, 132, 242, 185, 251, 202, 104, 74, 237, 223, 101, 59, 154, 179, 248, 252, 167, 35, 115, 88, 92, 192, 117, 35, 186, 222, 25, 229, 54, 179, 77, 154, 42, 113, 82, 77, 99, 24, 84, 5, 229 }, new byte[] { 4, 24, 161, 87, 175, 196, 0, 249, 150, 15, 69, 144, 37, 223, 10, 194, 235, 48, 241, 250, 78, 231, 120, 121, 104, 98, 20, 226, 182, 94, 41, 64, 184, 233, 188, 162, 189, 122, 235, 139, 183, 107, 193, 114, 124, 108, 68, 179, 196, 210, 21, 225, 4, 194, 204, 10, 74, 204, 32, 171, 209, 10, 132, 6, 44, 25, 226, 156, 183, 53, 169, 99, 177, 126, 91, 91, 251, 18, 69, 196, 204, 203, 177, 227, 210, 14, 70, 56, 171, 26, 39, 118, 233, 176, 213, 217, 124, 116, 39, 66, 216, 25, 159, 89, 165, 185, 80, 227, 90, 248, 169, 73, 41, 0, 255, 229, 147, 246, 237, 221, 14, 147, 7, 120, 68, 27, 163, 215 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isHot",
                table: "Services");

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
        }
    }
}
