using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Pgvector;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateVector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Vector>(
                name: "Embedding",
                table: "JobPosts",
                type: "vector(384)",
                nullable: true,
                oldClrType: typeof(Vector),
                oldType: "vector(500)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 13, 53, 55, 543, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(1700), new byte[] { 222, 255, 187, 200, 152, 155, 33, 177, 122, 90, 178, 211, 90, 28, 24, 130, 38, 72, 12, 160, 106, 169, 52, 126, 184, 105, 202, 50, 56, 29, 168, 156, 100, 228, 33, 140, 122, 179, 115, 184, 117, 114, 205, 135, 87, 116, 74, 237, 63, 47, 31, 197, 208, 71, 32, 219, 20, 164, 149, 111, 4, 27, 15, 164 }, new byte[] { 233, 23, 222, 200, 161, 208, 154, 66, 184, 181, 185, 196, 212, 250, 125, 134, 156, 11, 131, 229, 92, 33, 110, 161, 57, 11, 102, 164, 181, 81, 160, 63, 22, 254, 174, 82, 68, 214, 167, 79, 37, 37, 56, 76, 127, 0, 242, 221, 13, 173, 99, 210, 50, 71, 35, 1, 245, 212, 160, 1, 255, 112, 145, 110, 186, 119, 109, 251, 78, 190, 227, 142, 2, 234, 165, 99, 83, 172, 147, 192, 101, 185, 70, 27, 51, 158, 41, 14, 210, 177, 247, 241, 232, 223, 63, 128, 105, 167, 102, 50, 200, 125, 123, 234, 63, 122, 0, 66, 236, 148, 86, 136, 121, 20, 240, 80, 44, 226, 251, 94, 180, 173, 33, 103, 141, 91, 50, 198 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(1710), new byte[] { 40, 79, 151, 161, 244, 211, 228, 243, 24, 131, 20, 81, 58, 105, 108, 222, 123, 66, 59, 13, 223, 6, 206, 121, 71, 7, 132, 94, 143, 107, 74, 46, 177, 179, 133, 74, 36, 231, 67, 87, 132, 180, 2, 96, 207, 174, 201, 94, 39, 191, 90, 211, 217, 117, 165, 204, 60, 142, 176, 71, 184, 198, 48, 83 }, new byte[] { 84, 148, 141, 25, 13, 96, 132, 167, 33, 244, 10, 97, 41, 161, 139, 135, 102, 215, 67, 69, 234, 76, 243, 215, 81, 110, 27, 195, 150, 190, 163, 38, 88, 223, 41, 62, 14, 217, 149, 1, 130, 107, 195, 229, 142, 179, 221, 115, 18, 165, 175, 83, 207, 182, 106, 133, 99, 203, 225, 237, 7, 206, 138, 212, 183, 132, 106, 75, 232, 78, 53, 219, 111, 52, 158, 7, 52, 157, 25, 227, 227, 91, 12, 5, 127, 166, 197, 35, 39, 85, 27, 2, 155, 12, 150, 65, 215, 224, 49, 251, 179, 74, 75, 146, 228, 154, 159, 155, 178, 167, 66, 245, 55, 214, 225, 81, 23, 180, 122, 197, 9, 9, 67, 69, 221, 207, 242, 95 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(1712), new byte[] { 5, 114, 34, 127, 44, 248, 24, 97, 178, 240, 62, 62, 34, 11, 70, 27, 43, 54, 117, 172, 205, 140, 151, 176, 107, 142, 59, 82, 176, 14, 171, 191, 209, 35, 152, 127, 37, 23, 189, 201, 104, 0, 7, 196, 144, 54, 207, 36, 12, 129, 175, 29, 163, 138, 196, 191, 225, 140, 216, 55, 68, 237, 77, 194 }, new byte[] { 204, 252, 228, 94, 251, 48, 205, 79, 53, 199, 67, 22, 90, 168, 222, 212, 198, 193, 109, 205, 213, 81, 199, 229, 115, 62, 195, 80, 231, 228, 203, 250, 166, 219, 134, 122, 180, 136, 21, 92, 64, 183, 144, 61, 181, 93, 66, 159, 10, 73, 248, 143, 223, 203, 73, 140, 59, 104, 38, 21, 102, 7, 122, 182, 182, 244, 87, 38, 138, 112, 13, 0, 131, 62, 231, 176, 208, 166, 94, 124, 242, 164, 123, 24, 0, 209, 48, 36, 6, 135, 183, 255, 133, 116, 237, 10, 190, 238, 90, 95, 199, 250, 152, 210, 181, 8, 52, 143, 186, 10, 251, 139, 159, 155, 33, 234, 65, 104, 81, 33, 81, 245, 96, 24, 75, 48, 238, 14 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 53, 55, 542, DateTimeKind.Utc).AddTicks(1716), new byte[] { 51, 213, 55, 51, 22, 195, 84, 105, 170, 10, 196, 11, 242, 69, 72, 229, 144, 186, 4, 199, 214, 142, 114, 127, 221, 163, 126, 60, 51, 11, 78, 201, 57, 255, 101, 62, 85, 5, 132, 229, 249, 54, 248, 164, 212, 222, 87, 85, 145, 152, 89, 6, 211, 252, 75, 168, 27, 245, 49, 90, 189, 177, 253, 137 }, new byte[] { 110, 14, 125, 45, 0, 11, 98, 203, 114, 96, 94, 203, 195, 175, 110, 138, 60, 86, 190, 253, 228, 20, 205, 109, 172, 21, 180, 228, 178, 86, 70, 159, 139, 232, 77, 84, 52, 204, 197, 103, 198, 50, 254, 221, 245, 234, 126, 250, 49, 103, 158, 236, 63, 51, 231, 41, 214, 115, 50, 93, 61, 161, 85, 104, 154, 140, 242, 232, 145, 236, 93, 129, 79, 128, 121, 247, 233, 183, 50, 9, 113, 9, 250, 65, 93, 189, 179, 251, 94, 27, 34, 15, 136, 11, 133, 230, 230, 81, 95, 27, 18, 20, 98, 228, 19, 62, 44, 174, 27, 113, 226, 132, 34, 187, 63, 241, 235, 38, 46, 163, 180, 7, 211, 118, 64, 209, 221, 229 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Vector>(
                name: "Embedding",
                table: "JobPosts",
                type: "vector(500)",
                nullable: true,
                oldClrType: typeof(Vector),
                oldType: "vector(384)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2708), new byte[] { 168, 29, 188, 175, 204, 125, 133, 99, 77, 195, 49, 34, 23, 113, 30, 206, 77, 22, 19, 58, 233, 32, 143, 148, 23, 160, 254, 126, 167, 34, 137, 114, 78, 31, 10, 185, 133, 190, 3, 236, 147, 220, 221, 246, 63, 252, 181, 57, 42, 233, 40, 204, 248, 127, 60, 74, 118, 199, 200, 244, 188, 33, 212, 93 }, new byte[] { 127, 92, 215, 207, 127, 138, 140, 151, 78, 97, 240, 175, 237, 64, 174, 21, 248, 77, 117, 175, 78, 24, 241, 160, 203, 10, 113, 130, 178, 130, 128, 149, 26, 111, 165, 21, 129, 133, 197, 95, 140, 183, 52, 208, 34, 99, 147, 174, 209, 197, 193, 42, 141, 79, 253, 94, 105, 1, 143, 177, 148, 137, 54, 246, 41, 15, 108, 223, 229, 67, 253, 54, 20, 196, 74, 77, 233, 69, 237, 237, 166, 157, 148, 119, 151, 119, 28, 143, 205, 150, 83, 209, 89, 207, 26, 142, 138, 11, 22, 127, 40, 219, 121, 14, 114, 196, 36, 200, 182, 227, 13, 201, 132, 246, 211, 192, 33, 255, 213, 101, 172, 181, 12, 165, 183, 243, 232, 136 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2717), new byte[] { 34, 43, 253, 47, 111, 25, 189, 70, 15, 36, 156, 4, 151, 211, 101, 111, 68, 136, 1, 123, 122, 158, 57, 97, 181, 81, 113, 0, 230, 162, 206, 161, 80, 50, 207, 55, 57, 233, 218, 91, 214, 112, 57, 153, 195, 212, 40, 13, 132, 225, 163, 88, 47, 220, 106, 243, 175, 154, 247, 106, 35, 209, 172, 220 }, new byte[] { 8, 42, 122, 102, 146, 15, 11, 245, 99, 9, 160, 202, 234, 21, 82, 205, 211, 58, 64, 59, 82, 85, 84, 2, 197, 228, 96, 119, 1, 58, 166, 64, 196, 93, 0, 69, 77, 191, 20, 164, 193, 178, 104, 174, 162, 97, 207, 164, 70, 207, 52, 46, 100, 89, 247, 120, 41, 227, 216, 44, 197, 110, 116, 13, 93, 56, 198, 227, 190, 49, 183, 234, 138, 157, 115, 195, 99, 110, 233, 53, 100, 147, 219, 47, 6, 166, 25, 232, 161, 205, 222, 206, 19, 59, 122, 77, 107, 54, 130, 203, 21, 50, 172, 17, 175, 181, 70, 231, 160, 61, 3, 20, 138, 111, 245, 130, 8, 33, 231, 75, 35, 239, 168, 178, 214, 96, 216, 242 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2719), new byte[] { 26, 7, 247, 197, 252, 96, 95, 216, 90, 191, 48, 230, 139, 241, 110, 13, 253, 32, 217, 37, 37, 160, 152, 152, 132, 105, 190, 222, 202, 23, 41, 178, 134, 248, 205, 210, 187, 219, 227, 86, 22, 165, 68, 137, 212, 176, 38, 20, 206, 199, 55, 96, 13, 130, 146, 193, 9, 201, 218, 188, 45, 216, 190, 42 }, new byte[] { 18, 19, 129, 167, 2, 253, 92, 35, 239, 26, 220, 156, 117, 47, 43, 242, 117, 58, 160, 143, 114, 252, 241, 138, 233, 7, 112, 112, 100, 50, 36, 130, 112, 202, 55, 83, 241, 135, 168, 36, 92, 219, 184, 60, 116, 121, 172, 96, 240, 168, 223, 140, 136, 255, 179, 146, 207, 25, 142, 152, 173, 61, 217, 126, 255, 212, 148, 238, 130, 240, 220, 189, 117, 182, 139, 66, 100, 4, 222, 215, 17, 140, 223, 190, 85, 105, 218, 28, 142, 134, 98, 188, 173, 117, 158, 174, 226, 252, 109, 49, 42, 254, 41, 248, 118, 229, 73, 45, 122, 78, 43, 215, 232, 185, 241, 178, 187, 168, 67, 101, 110, 203, 226, 183, 149, 169, 251, 110 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2721), new byte[] { 239, 226, 184, 224, 221, 11, 205, 245, 99, 249, 20, 242, 195, 233, 28, 114, 47, 144, 234, 185, 44, 237, 45, 183, 103, 228, 213, 90, 92, 163, 177, 142, 133, 243, 116, 226, 121, 221, 41, 150, 64, 179, 63, 122, 221, 174, 52, 63, 63, 53, 117, 205, 175, 179, 180, 50, 28, 168, 251, 243, 153, 146, 44, 191 }, new byte[] { 249, 181, 21, 232, 189, 86, 27, 36, 41, 238, 82, 32, 103, 224, 187, 44, 117, 60, 144, 127, 74, 159, 242, 76, 178, 226, 154, 127, 236, 91, 55, 95, 240, 199, 244, 115, 250, 185, 204, 42, 140, 141, 246, 217, 123, 48, 53, 197, 49, 149, 215, 45, 147, 92, 88, 247, 57, 81, 91, 131, 25, 165, 228, 227, 102, 117, 126, 53, 132, 134, 121, 98, 19, 125, 253, 226, 146, 25, 218, 105, 39, 105, 25, 40, 235, 87, 191, 29, 83, 186, 217, 53, 47, 91, 155, 158, 70, 83, 133, 174, 7, 212, 45, 24, 241, 208, 49, 225, 15, 209, 46, 205, 183, 150, 172, 80, 104, 2, 100, 39, 197, 234, 28, 236, 115, 149, 206, 67 } });
        }
    }
}
