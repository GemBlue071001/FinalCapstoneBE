using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPayperpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverLetter",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOFPostLeft",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Minsalary",
                table: "JobPosts",
                type: "numeric",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 208, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 208, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverLetter", "CreatedDate", "NumberOFPostLeft", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8304), null, new byte[] { 74, 4, 36, 201, 59, 240, 96, 32, 205, 62, 125, 89, 46, 83, 162, 217, 124, 49, 54, 210, 150, 27, 63, 179, 125, 190, 253, 147, 165, 163, 93, 182, 203, 66, 132, 207, 12, 125, 39, 145, 212, 70, 51, 14, 18, 24, 225, 202, 5, 161, 197, 93, 46, 135, 72, 188, 148, 13, 160, 152, 172, 7, 77, 141 }, new byte[] { 25, 3, 191, 103, 136, 135, 55, 92, 120, 116, 102, 248, 246, 11, 200, 224, 216, 187, 104, 117, 240, 155, 132, 45, 156, 177, 30, 32, 173, 169, 220, 79, 20, 92, 27, 45, 216, 33, 160, 194, 233, 220, 188, 125, 187, 70, 125, 87, 172, 88, 194, 133, 225, 89, 69, 30, 245, 80, 170, 126, 219, 162, 64, 145, 205, 125, 249, 14, 9, 252, 34, 88, 106, 90, 234, 132, 17, 42, 154, 231, 139, 188, 18, 176, 45, 94, 247, 5, 60, 233, 111, 242, 71, 113, 229, 40, 145, 16, 30, 114, 8, 58, 208, 174, 60, 216, 81, 233, 14, 85, 177, 175, 246, 153, 13, 74, 86, 113, 42, 55, 74, 190, 123, 130, 174, 122, 120, 106 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverLetter", "CreatedDate", "NumberOFPostLeft", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8311), null, new byte[] { 201, 2, 145, 169, 45, 251, 166, 214, 11, 94, 174, 1, 99, 48, 218, 100, 40, 133, 41, 213, 167, 191, 217, 215, 105, 114, 209, 206, 200, 94, 154, 43, 196, 194, 231, 110, 56, 130, 212, 64, 117, 47, 190, 49, 40, 137, 149, 31, 251, 90, 233, 11, 96, 38, 197, 4, 182, 135, 209, 0, 245, 150, 227, 228 }, new byte[] { 89, 246, 179, 222, 219, 12, 15, 188, 191, 177, 10, 99, 85, 103, 220, 119, 93, 213, 73, 158, 158, 229, 240, 243, 36, 75, 4, 127, 74, 40, 69, 39, 189, 208, 228, 184, 255, 248, 61, 181, 158, 116, 251, 85, 54, 239, 49, 148, 156, 229, 219, 10, 92, 251, 38, 136, 67, 120, 94, 38, 11, 116, 12, 12, 126, 117, 67, 3, 8, 8, 222, 147, 77, 68, 163, 10, 122, 194, 197, 228, 118, 237, 20, 124, 143, 202, 233, 200, 81, 24, 183, 231, 158, 82, 130, 14, 51, 146, 112, 239, 6, 88, 165, 211, 234, 93, 212, 133, 59, 201, 183, 10, 202, 142, 176, 196, 253, 161, 89, 148, 217, 68, 142, 140, 167, 119, 182, 255 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverLetter", "CreatedDate", "NumberOFPostLeft", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8313), null, new byte[] { 233, 170, 57, 143, 140, 201, 82, 86, 186, 199, 91, 28, 210, 35, 169, 132, 113, 180, 93, 7, 40, 235, 62, 62, 221, 14, 90, 90, 164, 24, 217, 43, 162, 87, 197, 181, 57, 207, 40, 170, 219, 94, 19, 191, 216, 254, 70, 199, 243, 104, 158, 189, 58, 104, 242, 230, 196, 41, 81, 49, 123, 116, 138, 9 }, new byte[] { 230, 135, 201, 60, 136, 131, 25, 184, 58, 95, 135, 39, 255, 230, 163, 245, 65, 89, 148, 25, 162, 160, 94, 96, 102, 29, 120, 124, 85, 184, 100, 202, 10, 181, 200, 87, 109, 104, 198, 47, 131, 163, 207, 45, 21, 232, 86, 146, 179, 221, 114, 131, 155, 12, 23, 252, 94, 194, 128, 242, 77, 236, 146, 106, 228, 217, 38, 188, 254, 156, 48, 92, 215, 208, 68, 21, 99, 213, 237, 152, 170, 228, 32, 57, 95, 226, 118, 53, 247, 190, 21, 177, 105, 39, 71, 142, 77, 48, 63, 254, 15, 187, 56, 73, 116, 208, 86, 137, 40, 23, 240, 76, 85, 172, 201, 213, 23, 89, 251, 116, 76, 175, 192, 71, 91, 247, 74, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverLetter", "CreatedDate", "NumberOFPostLeft", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8314), null, new byte[] { 113, 110, 58, 132, 162, 79, 136, 174, 253, 33, 81, 195, 121, 242, 38, 43, 65, 137, 20, 42, 186, 237, 110, 173, 32, 76, 222, 209, 166, 92, 120, 38, 59, 153, 168, 146, 128, 70, 121, 0, 201, 181, 193, 82, 73, 91, 125, 153, 109, 243, 151, 112, 192, 59, 217, 11, 139, 84, 169, 117, 87, 234, 179, 50 }, new byte[] { 238, 112, 20, 9, 71, 205, 86, 248, 203, 143, 68, 65, 49, 143, 135, 134, 185, 221, 89, 160, 42, 250, 132, 16, 148, 163, 51, 224, 64, 220, 209, 102, 181, 74, 52, 150, 95, 39, 64, 205, 145, 168, 23, 73, 224, 30, 5, 72, 5, 4, 67, 57, 24, 160, 31, 140, 210, 98, 20, 235, 86, 254, 26, 98, 13, 121, 141, 35, 220, 77, 154, 23, 117, 116, 93, 115, 53, 221, 50, 141, 77, 29, 252, 23, 45, 200, 36, 216, 43, 25, 199, 17, 124, 12, 28, 130, 8, 193, 95, 208, 237, 239, 20, 169, 122, 197, 0, 118, 253, 88, 168, 110, 113, 5, 89, 83, 121, 77, 210, 5, 122, 249, 109, 228, 67, 247, 114, 59 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverLetter",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NumberOFPostLeft",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Minsalary",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 867, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 867, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6473), new byte[] { 249, 141, 139, 178, 124, 121, 20, 3, 235, 99, 63, 21, 185, 60, 199, 73, 44, 134, 43, 28, 53, 154, 193, 62, 109, 247, 222, 43, 3, 160, 101, 50, 106, 228, 126, 78, 206, 117, 17, 15, 119, 101, 173, 160, 193, 18, 76, 34, 67, 201, 82, 79, 58, 161, 188, 234, 229, 247, 49, 7, 108, 40, 60, 81 }, new byte[] { 186, 239, 159, 13, 132, 118, 3, 196, 75, 201, 146, 65, 205, 55, 64, 137, 20, 24, 148, 85, 203, 120, 100, 39, 206, 68, 70, 196, 254, 57, 149, 227, 80, 41, 160, 195, 66, 162, 153, 69, 246, 172, 104, 0, 226, 200, 254, 152, 229, 198, 48, 100, 165, 147, 122, 2, 236, 251, 54, 50, 141, 69, 45, 242, 206, 192, 33, 7, 206, 231, 135, 143, 107, 207, 42, 252, 79, 53, 130, 224, 185, 243, 79, 250, 0, 244, 255, 181, 224, 238, 163, 135, 28, 15, 71, 7, 253, 56, 168, 119, 73, 107, 100, 24, 67, 208, 217, 43, 58, 187, 45, 240, 106, 145, 124, 71, 180, 8, 228, 184, 65, 241, 230, 213, 106, 153, 213, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6487), new byte[] { 50, 2, 28, 62, 89, 239, 28, 166, 35, 242, 199, 120, 237, 144, 227, 248, 160, 122, 230, 196, 143, 68, 241, 50, 229, 133, 202, 7, 1, 179, 122, 56, 74, 162, 131, 1, 244, 178, 18, 78, 66, 28, 138, 83, 40, 42, 64, 194, 174, 43, 172, 97, 121, 196, 207, 13, 103, 148, 79, 170, 54, 112, 98, 21 }, new byte[] { 101, 193, 27, 2, 115, 66, 212, 237, 188, 37, 69, 135, 46, 18, 27, 253, 151, 120, 177, 223, 51, 144, 222, 217, 248, 212, 156, 215, 195, 127, 199, 3, 4, 54, 121, 226, 51, 184, 7, 15, 187, 58, 235, 242, 136, 52, 169, 115, 97, 139, 230, 196, 227, 37, 166, 244, 203, 79, 72, 209, 76, 147, 153, 93, 10, 4, 158, 102, 186, 87, 216, 228, 9, 107, 133, 149, 31, 21, 151, 241, 123, 221, 243, 213, 102, 133, 159, 118, 235, 201, 99, 176, 215, 220, 89, 6, 114, 122, 74, 122, 42, 186, 244, 80, 135, 184, 153, 12, 81, 52, 5, 69, 233, 176, 176, 132, 34, 36, 47, 67, 201, 24, 94, 88, 174, 42, 214, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6488), new byte[] { 91, 152, 101, 134, 151, 226, 205, 43, 26, 73, 167, 22, 30, 151, 134, 245, 33, 193, 150, 129, 187, 105, 216, 58, 202, 187, 71, 193, 82, 80, 213, 21, 107, 166, 75, 229, 233, 123, 60, 18, 108, 36, 91, 107, 85, 66, 50, 129, 13, 255, 51, 206, 230, 124, 6, 243, 204, 245, 215, 79, 94, 28, 116, 229 }, new byte[] { 60, 237, 16, 195, 28, 181, 143, 166, 247, 148, 237, 175, 163, 227, 158, 32, 216, 46, 193, 252, 152, 93, 177, 242, 170, 45, 244, 226, 42, 161, 155, 221, 164, 215, 198, 210, 63, 78, 5, 61, 138, 141, 92, 204, 125, 254, 63, 43, 203, 236, 240, 162, 199, 216, 44, 87, 95, 146, 75, 79, 70, 250, 213, 43, 7, 206, 187, 189, 178, 139, 101, 125, 85, 113, 98, 28, 38, 102, 86, 183, 224, 105, 141, 73, 162, 253, 62, 113, 156, 161, 180, 126, 117, 210, 100, 98, 137, 148, 154, 176, 2, 0, 128, 114, 21, 175, 143, 200, 161, 127, 163, 196, 195, 189, 108, 9, 69, 56, 109, 164, 87, 187, 188, 4, 151, 130, 172, 120 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6490), new byte[] { 131, 94, 128, 240, 125, 26, 133, 39, 106, 158, 158, 251, 231, 72, 233, 42, 55, 250, 112, 239, 231, 139, 13, 121, 162, 92, 74, 205, 187, 69, 2, 77, 142, 176, 250, 206, 10, 11, 33, 107, 41, 56, 230, 239, 228, 56, 117, 179, 121, 149, 55, 43, 6, 170, 55, 35, 17, 176, 10, 94, 211, 2, 243, 32 }, new byte[] { 70, 125, 43, 33, 66, 103, 78, 50, 29, 210, 85, 67, 31, 252, 176, 195, 114, 229, 78, 40, 72, 201, 134, 146, 151, 237, 255, 104, 183, 56, 196, 201, 123, 16, 39, 132, 181, 191, 14, 169, 12, 65, 211, 177, 213, 58, 156, 139, 86, 150, 237, 162, 82, 120, 79, 228, 105, 101, 176, 144, 227, 164, 41, 131, 41, 60, 236, 9, 20, 205, 44, 230, 77, 41, 141, 226, 219, 42, 16, 155, 14, 18, 58, 202, 245, 65, 89, 3, 119, 83, 220, 61, 87, 82, 230, 38, 232, 170, 45, 61, 198, 124, 201, 211, 72, 210, 39, 98, 182, 119, 210, 143, 38, 224, 209, 70, 218, 124, 52, 4, 231, 46, 20, 228, 184, 64, 37, 198 } });
        }
    }
}
