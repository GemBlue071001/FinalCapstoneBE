using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CvName",
                table: "JobPostActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExactedInfo",
                table: "JobPostActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "JobPostActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2816), new byte[] { 97, 102, 17, 60, 48, 183, 78, 50, 141, 187, 79, 253, 2, 85, 74, 226, 97, 174, 35, 39, 61, 94, 247, 56, 56, 24, 137, 215, 225, 56, 65, 199, 185, 53, 96, 83, 160, 136, 182, 153, 242, 182, 21, 48, 224, 226, 90, 79, 6, 113, 209, 21, 248, 132, 221, 214, 114, 213, 180, 150, 116, 254, 51, 42 }, new byte[] { 80, 77, 26, 222, 66, 85, 109, 39, 18, 12, 133, 223, 46, 88, 11, 32, 243, 64, 188, 223, 91, 248, 55, 207, 248, 81, 101, 51, 250, 34, 94, 159, 212, 226, 233, 6, 110, 170, 4, 8, 119, 51, 213, 114, 251, 175, 157, 101, 110, 69, 85, 101, 219, 155, 80, 103, 210, 9, 100, 235, 205, 30, 160, 252, 40, 198, 43, 18, 70, 205, 226, 161, 19, 141, 248, 18, 79, 31, 168, 126, 153, 165, 55, 66, 232, 149, 20, 162, 125, 219, 213, 251, 69, 160, 7, 158, 83, 225, 21, 167, 16, 30, 136, 151, 49, 17, 9, 224, 65, 221, 144, 115, 184, 72, 200, 96, 14, 137, 130, 41, 83, 114, 18, 66, 1, 79, 2, 211 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2823), new byte[] { 250, 129, 1, 185, 114, 63, 245, 177, 60, 55, 68, 164, 107, 135, 188, 163, 36, 102, 153, 128, 120, 3, 212, 134, 88, 141, 160, 158, 79, 100, 234, 54, 249, 222, 44, 83, 19, 100, 118, 237, 177, 41, 7, 2, 94, 224, 33, 191, 233, 180, 71, 113, 102, 205, 195, 152, 54, 80, 157, 78, 82, 231, 71, 51 }, new byte[] { 72, 219, 128, 133, 119, 15, 159, 87, 111, 32, 104, 101, 141, 158, 214, 36, 230, 173, 97, 185, 91, 214, 30, 20, 120, 32, 239, 85, 17, 130, 254, 78, 37, 217, 67, 170, 224, 240, 7, 92, 108, 191, 78, 10, 192, 225, 43, 145, 3, 134, 244, 13, 198, 76, 141, 127, 97, 197, 163, 23, 64, 79, 6, 56, 165, 212, 81, 40, 155, 189, 158, 129, 161, 156, 33, 90, 31, 58, 90, 97, 223, 219, 29, 246, 10, 186, 121, 77, 60, 146, 84, 172, 165, 3, 80, 79, 252, 246, 97, 3, 219, 160, 231, 108, 220, 43, 63, 10, 167, 73, 108, 19, 217, 116, 3, 123, 105, 162, 128, 80, 159, 158, 163, 109, 43, 29, 109, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2825), new byte[] { 120, 119, 201, 101, 75, 108, 154, 1, 32, 246, 143, 143, 229, 209, 227, 198, 187, 182, 106, 210, 91, 111, 6, 2, 226, 10, 35, 220, 141, 47, 188, 211, 161, 79, 158, 188, 77, 232, 60, 37, 6, 229, 7, 198, 194, 103, 122, 77, 252, 85, 243, 13, 134, 197, 250, 30, 173, 155, 200, 15, 222, 7, 112, 123 }, new byte[] { 19, 130, 108, 26, 23, 236, 72, 2, 6, 43, 247, 246, 120, 65, 36, 250, 175, 87, 79, 190, 17, 75, 191, 207, 66, 177, 226, 233, 24, 212, 168, 46, 2, 4, 200, 123, 142, 83, 46, 40, 164, 75, 216, 47, 225, 118, 58, 156, 112, 116, 219, 153, 45, 163, 114, 207, 225, 59, 79, 182, 153, 177, 144, 130, 42, 32, 184, 43, 248, 55, 238, 226, 143, 232, 216, 8, 18, 52, 180, 60, 190, 86, 99, 204, 36, 87, 0, 217, 8, 234, 199, 147, 189, 24, 175, 49, 75, 54, 239, 216, 75, 120, 65, 126, 136, 204, 127, 184, 225, 102, 14, 135, 109, 228, 35, 191, 133, 101, 177, 72, 239, 60, 67, 238, 244, 128, 240, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2826), new byte[] { 205, 114, 17, 207, 249, 87, 117, 108, 126, 171, 86, 249, 37, 173, 195, 2, 197, 179, 101, 6, 124, 136, 177, 117, 207, 81, 99, 162, 211, 109, 27, 170, 216, 153, 141, 65, 236, 238, 159, 115, 73, 255, 87, 125, 190, 110, 217, 229, 99, 33, 65, 147, 172, 18, 246, 83, 180, 122, 48, 34, 163, 121, 62, 126 }, new byte[] { 224, 253, 246, 202, 136, 185, 181, 171, 102, 3, 33, 220, 10, 95, 246, 187, 107, 229, 223, 174, 210, 24, 86, 237, 180, 132, 213, 233, 141, 183, 251, 118, 230, 235, 216, 250, 161, 148, 216, 89, 168, 45, 8, 4, 213, 71, 58, 100, 112, 77, 162, 2, 166, 66, 153, 244, 91, 157, 125, 124, 61, 79, 79, 239, 51, 146, 121, 163, 202, 59, 210, 196, 250, 66, 11, 115, 189, 252, 6, 224, 50, 197, 135, 157, 144, 115, 187, 176, 225, 227, 205, 159, 89, 107, 253, 105, 191, 126, 221, 205, 130, 179, 225, 199, 150, 125, 71, 51, 219, 132, 133, 8, 77, 243, 56, 146, 75, 186, 250, 191, 103, 74, 146, 198, 219, 159, 133, 6 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CvName",
                table: "JobPostActivities");

            migrationBuilder.DropColumn(
                name: "ExactedInfo",
                table: "JobPostActivities");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "JobPostActivities");

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
    }
}
