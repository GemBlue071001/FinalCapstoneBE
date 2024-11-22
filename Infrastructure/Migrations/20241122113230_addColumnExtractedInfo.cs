using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addColumnExtractedInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtractedInfo",
                table: "CVs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 11, 32, 30, 206, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(3707), new byte[] { 50, 183, 171, 121, 58, 100, 69, 128, 77, 106, 28, 135, 3, 168, 20, 196, 107, 21, 148, 170, 79, 57, 24, 20, 139, 18, 143, 61, 129, 50, 125, 185, 167, 65, 50, 15, 42, 243, 199, 144, 249, 166, 154, 128, 92, 22, 66, 193, 50, 190, 7, 38, 74, 238, 106, 250, 41, 162, 226, 191, 194, 158, 235, 182 }, new byte[] { 165, 79, 107, 166, 20, 185, 45, 21, 220, 81, 113, 79, 77, 103, 116, 230, 251, 81, 16, 20, 24, 38, 134, 43, 248, 197, 111, 240, 195, 195, 208, 196, 16, 252, 133, 7, 152, 229, 117, 220, 143, 250, 24, 10, 24, 244, 3, 178, 219, 104, 175, 151, 28, 7, 28, 0, 182, 203, 126, 105, 7, 186, 236, 164, 247, 92, 114, 113, 192, 41, 59, 18, 5, 44, 65, 61, 45, 10, 28, 241, 68, 178, 133, 51, 82, 85, 185, 79, 97, 41, 186, 214, 3, 214, 13, 16, 213, 214, 190, 175, 174, 57, 21, 224, 146, 30, 255, 152, 123, 154, 103, 188, 197, 29, 172, 15, 92, 245, 242, 27, 102, 74, 140, 102, 73, 162, 143, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(3721), new byte[] { 45, 151, 10, 211, 214, 102, 212, 112, 249, 224, 116, 168, 81, 166, 211, 124, 36, 131, 205, 245, 120, 86, 245, 147, 198, 41, 139, 140, 150, 57, 192, 41, 234, 150, 65, 148, 24, 39, 156, 196, 37, 114, 19, 99, 175, 146, 71, 181, 233, 14, 68, 151, 111, 200, 178, 115, 103, 38, 233, 70, 105, 98, 185, 82 }, new byte[] { 13, 94, 79, 210, 35, 163, 172, 30, 198, 60, 112, 81, 230, 44, 113, 163, 140, 161, 220, 64, 230, 129, 117, 171, 62, 210, 141, 30, 147, 13, 56, 232, 48, 179, 122, 178, 231, 35, 164, 207, 194, 180, 137, 190, 61, 158, 138, 228, 248, 46, 230, 223, 220, 86, 157, 77, 160, 161, 130, 57, 52, 98, 12, 21, 182, 120, 249, 97, 41, 7, 111, 78, 215, 92, 112, 151, 16, 33, 41, 213, 122, 251, 210, 250, 173, 182, 229, 135, 114, 79, 216, 34, 208, 59, 12, 151, 147, 32, 210, 148, 9, 161, 93, 125, 46, 110, 224, 254, 153, 40, 176, 185, 103, 49, 128, 35, 210, 145, 152, 170, 19, 34, 132, 229, 179, 91, 51, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(3724), new byte[] { 234, 164, 29, 244, 192, 85, 214, 245, 11, 235, 143, 196, 84, 72, 90, 7, 152, 156, 249, 175, 228, 170, 123, 56, 44, 0, 40, 180, 213, 183, 144, 240, 186, 150, 27, 181, 140, 167, 70, 166, 202, 79, 135, 122, 101, 18, 99, 43, 137, 89, 99, 223, 236, 67, 241, 55, 65, 1, 99, 187, 103, 142, 183, 252 }, new byte[] { 117, 50, 150, 248, 109, 212, 107, 138, 176, 9, 243, 110, 104, 1, 250, 147, 96, 15, 146, 95, 40, 43, 84, 216, 226, 42, 157, 92, 138, 52, 200, 168, 231, 196, 109, 164, 159, 21, 172, 134, 52, 30, 101, 39, 18, 1, 135, 181, 252, 43, 182, 185, 38, 24, 95, 189, 162, 30, 115, 84, 9, 235, 118, 74, 167, 60, 9, 25, 164, 216, 26, 220, 21, 174, 73, 183, 105, 108, 147, 129, 119, 80, 196, 89, 118, 34, 245, 23, 167, 56, 255, 13, 104, 21, 91, 157, 224, 108, 121, 132, 221, 132, 212, 201, 84, 104, 242, 132, 37, 45, 22, 29, 230, 32, 89, 231, 39, 113, 41, 6, 111, 87, 11, 40, 149, 244, 80, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 22, 11, 32, 30, 204, DateTimeKind.Utc).AddTicks(3726), new byte[] { 112, 97, 192, 14, 229, 78, 12, 28, 244, 49, 144, 79, 172, 214, 167, 151, 7, 187, 53, 225, 236, 12, 1, 193, 107, 145, 205, 65, 151, 239, 24, 120, 184, 145, 219, 201, 231, 130, 65, 230, 196, 36, 177, 112, 98, 197, 218, 155, 12, 163, 64, 20, 86, 125, 155, 152, 118, 136, 243, 23, 91, 150, 141, 97 }, new byte[] { 155, 164, 86, 72, 19, 251, 133, 206, 145, 205, 204, 137, 177, 157, 31, 193, 234, 197, 121, 78, 75, 197, 219, 74, 30, 213, 24, 217, 137, 227, 45, 95, 93, 104, 174, 189, 224, 255, 2, 228, 155, 187, 1, 21, 75, 157, 182, 246, 83, 24, 112, 217, 185, 96, 86, 193, 76, 120, 130, 60, 129, 185, 231, 71, 90, 171, 222, 113, 54, 203, 138, 60, 249, 41, 95, 99, 47, 240, 248, 166, 204, 103, 165, 20, 224, 3, 165, 246, 154, 90, 42, 122, 242, 21, 117, 166, 255, 65, 138, 95, 15, 147, 118, 177, 255, 203, 200, 213, 57, 28, 152, 5, 79, 104, 5, 7, 76, 160, 159, 83, 25, 174, 200, 139, 232, 220, 19, 225 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtractedInfo",
                table: "CVs");

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
    }
}
