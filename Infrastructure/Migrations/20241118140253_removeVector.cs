using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Pgvector;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeVector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobPosts_Embedding",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Embedding",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 14, 2, 53, 183, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(6), new byte[] { 109, 168, 168, 108, 6, 15, 164, 185, 171, 130, 103, 53, 165, 34, 139, 42, 175, 107, 193, 142, 26, 30, 107, 71, 238, 173, 188, 77, 25, 62, 244, 162, 10, 223, 114, 138, 250, 18, 58, 252, 225, 218, 108, 16, 117, 172, 164, 249, 24, 221, 203, 99, 27, 197, 160, 132, 42, 188, 207, 232, 244, 58, 247, 93 }, new byte[] { 144, 224, 204, 125, 22, 209, 7, 98, 73, 194, 37, 75, 118, 185, 47, 22, 194, 138, 242, 199, 38, 148, 37, 116, 1, 20, 11, 116, 143, 141, 215, 76, 49, 128, 28, 206, 199, 57, 210, 113, 96, 188, 37, 247, 216, 78, 245, 188, 184, 78, 20, 246, 201, 235, 205, 36, 52, 152, 153, 183, 62, 139, 251, 222, 113, 94, 149, 64, 120, 85, 59, 221, 91, 160, 233, 18, 3, 188, 10, 44, 16, 193, 105, 170, 70, 73, 157, 84, 246, 115, 179, 137, 244, 194, 68, 233, 101, 200, 39, 33, 190, 67, 44, 95, 45, 195, 203, 4, 166, 165, 3, 241, 191, 34, 82, 231, 193, 162, 200, 219, 213, 225, 175, 131, 99, 210, 227, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(18), new byte[] { 124, 175, 158, 171, 164, 5, 6, 139, 240, 80, 205, 79, 28, 22, 196, 186, 152, 13, 101, 48, 47, 14, 250, 26, 233, 175, 209, 230, 36, 242, 77, 248, 82, 182, 131, 119, 188, 29, 231, 128, 243, 224, 214, 186, 36, 24, 46, 91, 240, 232, 145, 228, 211, 6, 157, 231, 238, 48, 66, 33, 68, 44, 172, 217 }, new byte[] { 143, 114, 163, 46, 203, 199, 198, 49, 253, 102, 183, 59, 18, 246, 29, 80, 122, 22, 127, 226, 171, 19, 169, 232, 117, 211, 149, 191, 206, 30, 59, 55, 60, 53, 38, 38, 77, 202, 227, 135, 212, 231, 129, 209, 98, 214, 13, 210, 67, 140, 206, 186, 125, 167, 123, 99, 171, 148, 48, 20, 52, 141, 64, 245, 49, 190, 223, 92, 239, 71, 213, 215, 53, 180, 99, 209, 125, 156, 103, 138, 8, 249, 195, 101, 78, 220, 248, 68, 124, 200, 16, 99, 215, 245, 134, 135, 8, 181, 0, 202, 138, 104, 128, 94, 121, 212, 22, 167, 128, 66, 109, 44, 62, 113, 159, 87, 160, 76, 246, 86, 198, 36, 33, 197, 47, 103, 226, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(20), new byte[] { 241, 150, 132, 8, 240, 86, 190, 16, 94, 65, 85, 88, 30, 93, 248, 35, 239, 205, 251, 241, 77, 121, 96, 184, 245, 33, 209, 202, 98, 125, 96, 137, 242, 222, 31, 94, 158, 122, 0, 76, 140, 117, 43, 138, 29, 140, 239, 199, 102, 179, 173, 4, 2, 55, 108, 234, 229, 43, 106, 9, 188, 149, 193, 94 }, new byte[] { 27, 138, 54, 36, 217, 103, 193, 28, 36, 32, 128, 241, 161, 25, 15, 113, 128, 177, 122, 191, 180, 104, 208, 171, 136, 170, 183, 238, 252, 195, 229, 242, 177, 150, 116, 53, 94, 199, 121, 3, 15, 63, 161, 90, 15, 183, 89, 75, 177, 214, 28, 33, 8, 41, 5, 145, 159, 91, 124, 254, 190, 223, 60, 227, 203, 183, 235, 234, 114, 162, 84, 231, 49, 27, 229, 222, 152, 86, 150, 185, 93, 21, 2, 106, 17, 12, 86, 139, 45, 185, 46, 158, 108, 175, 253, 36, 129, 170, 58, 87, 31, 107, 251, 133, 54, 135, 246, 61, 156, 90, 26, 162, 5, 164, 48, 51, 179, 21, 250, 14, 181, 56, 57, 242, 107, 190, 10, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 14, 2, 53, 182, DateTimeKind.Utc).AddTicks(48), new byte[] { 252, 5, 130, 94, 174, 25, 43, 194, 5, 79, 234, 148, 139, 104, 248, 7, 7, 55, 96, 173, 222, 193, 218, 154, 90, 169, 140, 245, 216, 18, 84, 55, 204, 51, 30, 28, 121, 174, 81, 113, 28, 177, 207, 202, 113, 122, 244, 189, 150, 106, 73, 180, 149, 17, 243, 43, 253, 69, 22, 8, 109, 21, 238, 55 }, new byte[] { 103, 78, 98, 61, 226, 39, 104, 225, 28, 10, 121, 178, 226, 186, 55, 7, 29, 22, 184, 38, 40, 209, 42, 174, 248, 56, 165, 54, 142, 155, 240, 227, 178, 186, 25, 50, 253, 84, 138, 220, 248, 216, 136, 10, 254, 33, 255, 153, 91, 22, 192, 47, 7, 112, 168, 98, 189, 229, 84, 75, 95, 113, 97, 48, 114, 75, 184, 182, 66, 106, 55, 149, 94, 35, 215, 25, 201, 140, 20, 236, 185, 9, 68, 15, 146, 223, 112, 31, 151, 97, 255, 93, 82, 107, 49, 182, 175, 25, 101, 67, 37, 109, 27, 134, 134, 149, 62, 124, 54, 93, 120, 194, 162, 53, 24, 12, 179, 142, 91, 172, 169, 58, 59, 143, 204, 127, 145, 19 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Vector>(
                name: "Embedding",
                table: "JobPosts",
                type: "vector(384)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 13, 49, 47, 399, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(7119), new byte[] { 159, 222, 179, 161, 14, 55, 162, 26, 18, 211, 39, 101, 70, 163, 108, 172, 175, 110, 191, 41, 100, 24, 162, 43, 67, 54, 75, 179, 229, 179, 0, 166, 19, 143, 207, 41, 204, 121, 119, 254, 133, 101, 116, 41, 101, 44, 107, 27, 192, 71, 204, 46, 13, 65, 175, 89, 167, 51, 3, 69, 5, 205, 206, 165 }, new byte[] { 205, 207, 236, 146, 113, 173, 75, 71, 45, 8, 147, 21, 145, 153, 165, 112, 72, 178, 210, 24, 115, 13, 141, 147, 110, 4, 98, 155, 56, 196, 148, 55, 153, 220, 121, 130, 181, 49, 112, 84, 50, 216, 194, 79, 33, 175, 164, 26, 198, 58, 53, 123, 167, 204, 2, 172, 42, 100, 182, 2, 244, 246, 244, 75, 146, 26, 99, 14, 86, 196, 117, 227, 150, 100, 244, 81, 254, 94, 112, 85, 72, 175, 201, 181, 202, 23, 224, 228, 7, 196, 54, 135, 211, 180, 20, 176, 174, 48, 12, 69, 132, 224, 21, 167, 87, 255, 220, 80, 82, 52, 133, 65, 34, 137, 173, 226, 70, 78, 102, 17, 29, 123, 31, 113, 146, 101, 15, 214 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(7128), new byte[] { 138, 61, 184, 254, 255, 85, 4, 30, 70, 202, 189, 158, 112, 119, 30, 53, 200, 173, 35, 105, 164, 30, 234, 180, 218, 100, 251, 134, 29, 138, 227, 206, 149, 249, 134, 225, 32, 51, 49, 8, 100, 44, 159, 188, 200, 6, 30, 83, 24, 1, 50, 68, 144, 59, 71, 148, 49, 21, 71, 38, 246, 146, 72, 84 }, new byte[] { 11, 35, 107, 76, 19, 209, 85, 23, 143, 233, 242, 154, 106, 179, 25, 26, 24, 28, 108, 59, 167, 162, 43, 184, 246, 15, 67, 111, 177, 114, 161, 9, 38, 19, 121, 98, 141, 254, 49, 197, 65, 54, 121, 89, 141, 127, 0, 158, 235, 197, 158, 46, 61, 25, 252, 157, 117, 105, 107, 27, 50, 241, 2, 151, 110, 231, 136, 67, 51, 14, 145, 162, 27, 232, 5, 157, 106, 27, 193, 167, 80, 139, 138, 169, 61, 40, 90, 7, 22, 173, 220, 183, 160, 111, 95, 216, 162, 127, 143, 92, 78, 235, 188, 221, 116, 129, 203, 93, 48, 73, 166, 39, 226, 5, 94, 209, 83, 214, 155, 15, 113, 47, 5, 40, 63, 223, 251, 200 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(7130), new byte[] { 90, 213, 25, 62, 228, 91, 241, 37, 30, 211, 154, 49, 65, 242, 97, 35, 3, 54, 216, 190, 15, 130, 133, 46, 215, 123, 106, 134, 119, 118, 40, 58, 105, 92, 136, 130, 85, 7, 107, 237, 205, 214, 42, 84, 252, 76, 137, 115, 81, 185, 184, 180, 244, 222, 223, 137, 196, 62, 236, 180, 245, 93, 127, 180 }, new byte[] { 101, 61, 22, 120, 60, 183, 19, 165, 136, 235, 10, 60, 179, 51, 164, 205, 145, 169, 160, 196, 152, 91, 6, 249, 107, 58, 216, 204, 211, 106, 66, 214, 206, 103, 188, 77, 155, 48, 91, 190, 3, 7, 161, 173, 131, 191, 19, 174, 11, 27, 59, 203, 131, 238, 7, 92, 125, 29, 64, 126, 66, 20, 48, 123, 139, 148, 76, 111, 212, 1, 253, 75, 248, 180, 23, 156, 130, 77, 74, 192, 187, 232, 254, 77, 219, 94, 205, 46, 108, 48, 27, 26, 212, 134, 86, 87, 97, 150, 86, 188, 47, 17, 169, 101, 189, 71, 125, 161, 17, 230, 5, 65, 105, 241, 21, 45, 0, 92, 91, 169, 63, 179, 191, 156, 5, 213, 167, 128 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 13, 49, 47, 397, DateTimeKind.Utc).AddTicks(7131), new byte[] { 6, 125, 0, 102, 151, 22, 180, 118, 72, 40, 81, 115, 184, 9, 132, 91, 115, 222, 109, 32, 131, 141, 45, 231, 213, 112, 117, 231, 248, 137, 142, 248, 135, 27, 182, 134, 182, 183, 123, 68, 199, 37, 3, 2, 248, 172, 162, 127, 5, 81, 183, 232, 151, 195, 76, 137, 205, 77, 233, 26, 63, 228, 117, 244 }, new byte[] { 71, 154, 74, 100, 82, 147, 108, 207, 91, 46, 150, 43, 208, 37, 19, 10, 105, 46, 11, 112, 37, 48, 137, 161, 231, 203, 37, 52, 154, 60, 201, 62, 225, 244, 158, 49, 219, 55, 147, 210, 112, 97, 174, 58, 87, 59, 86, 125, 27, 89, 202, 247, 66, 244, 33, 27, 183, 119, 178, 173, 13, 165, 192, 87, 167, 155, 137, 207, 220, 253, 54, 151, 85, 74, 45, 145, 67, 219, 221, 147, 63, 47, 161, 150, 90, 97, 26, 164, 148, 82, 218, 96, 211, 141, 246, 76, 11, 93, 123, 73, 11, 26, 2, 109, 172, 210, 247, 116, 40, 54, 15, 45, 117, 228, 183, 130, 78, 144, 53, 179, 42, 147, 152, 40, 189, 197, 175, 119 } });

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_Embedding",
                table: "JobPosts",
                column: "Embedding")
                .Annotation("Npgsql:IndexMethod", "hnsw")
                .Annotation("Npgsql:IndexOperators", new[] { "vector_l2_ops" })
                .Annotation("Npgsql:StorageParameter:ef_construction", 64)
                .Annotation("Npgsql:StorageParameter:m", 16);
        }
    }
}
