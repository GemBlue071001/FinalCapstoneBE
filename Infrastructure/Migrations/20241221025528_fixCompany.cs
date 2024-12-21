using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyStatus",
                table: "Companys",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Evidence",
                table: "Companys",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxCode",
                table: "Companys",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyStatus", "CreatedDate", "Evidence", "TaxCode" },
                values: new object[] { null, new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(7896), null, null });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyStatus", "CreatedDate", "Evidence", "TaxCode" },
                values: new object[] { null, new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(7916), null, null });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4817), new byte[] { 173, 61, 238, 50, 8, 142, 87, 188, 83, 87, 140, 175, 14, 159, 175, 14, 157, 212, 95, 227, 57, 132, 72, 198, 15, 67, 13, 219, 195, 39, 97, 86, 153, 237, 109, 58, 46, 135, 68, 215, 116, 219, 159, 158, 2, 250, 209, 26, 160, 6, 207, 67, 116, 253, 231, 252, 97, 154, 71, 144, 224, 113, 19, 96 }, new byte[] { 195, 21, 168, 138, 62, 250, 61, 23, 50, 89, 150, 68, 96, 95, 67, 229, 154, 132, 26, 132, 25, 71, 146, 58, 59, 179, 163, 223, 170, 218, 72, 252, 138, 18, 136, 40, 151, 111, 58, 252, 147, 93, 89, 126, 160, 237, 167, 164, 255, 28, 100, 38, 242, 215, 118, 107, 183, 33, 180, 28, 193, 187, 139, 107, 145, 32, 207, 195, 186, 213, 244, 201, 155, 55, 17, 68, 185, 127, 18, 94, 49, 101, 67, 61, 81, 208, 123, 209, 30, 246, 83, 103, 2, 175, 5, 139, 215, 184, 25, 68, 76, 99, 122, 79, 155, 109, 211, 171, 170, 148, 173, 25, 135, 239, 210, 43, 126, 234, 46, 250, 242, 55, 69, 133, 22, 50, 14, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4826), new byte[] { 92, 56, 70, 178, 206, 255, 222, 195, 44, 246, 136, 76, 117, 43, 247, 225, 9, 127, 27, 41, 118, 107, 1, 141, 21, 12, 219, 200, 220, 218, 87, 182, 90, 131, 38, 197, 239, 197, 125, 206, 212, 93, 227, 13, 74, 2, 118, 191, 139, 21, 131, 44, 250, 25, 207, 145, 237, 163, 46, 59, 169, 93, 174, 131 }, new byte[] { 179, 109, 249, 211, 50, 62, 243, 44, 65, 1, 126, 209, 96, 217, 213, 21, 86, 94, 80, 106, 207, 227, 150, 248, 78, 15, 133, 120, 141, 67, 208, 54, 186, 203, 92, 197, 59, 62, 48, 150, 212, 198, 23, 145, 97, 222, 147, 162, 234, 231, 92, 29, 16, 120, 74, 202, 131, 70, 121, 173, 247, 122, 207, 222, 158, 48, 21, 25, 173, 5, 15, 238, 192, 219, 186, 58, 69, 245, 157, 71, 246, 148, 250, 36, 109, 220, 101, 71, 47, 67, 56, 175, 147, 24, 138, 102, 12, 235, 171, 35, 226, 29, 94, 188, 227, 179, 236, 184, 34, 137, 179, 124, 55, 151, 212, 226, 255, 34, 69, 45, 10, 115, 29, 228, 74, 135, 106, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4828), new byte[] { 148, 167, 43, 107, 99, 114, 13, 248, 213, 190, 140, 1, 160, 241, 223, 144, 240, 71, 84, 172, 57, 182, 72, 134, 55, 182, 25, 147, 182, 85, 40, 147, 77, 222, 177, 208, 170, 192, 60, 12, 216, 69, 105, 226, 160, 49, 16, 163, 200, 210, 229, 113, 230, 80, 119, 199, 250, 182, 155, 39, 143, 204, 221, 136 }, new byte[] { 131, 119, 52, 128, 203, 155, 223, 232, 88, 195, 143, 189, 133, 228, 47, 44, 39, 179, 186, 181, 95, 12, 121, 11, 170, 15, 231, 44, 135, 80, 223, 105, 40, 173, 1, 178, 81, 81, 3, 180, 79, 174, 44, 127, 210, 238, 215, 161, 202, 246, 198, 84, 60, 52, 248, 139, 148, 231, 207, 61, 41, 61, 192, 241, 191, 232, 248, 248, 42, 145, 209, 197, 249, 7, 110, 116, 1, 107, 28, 143, 195, 43, 88, 208, 61, 157, 236, 207, 4, 221, 50, 216, 24, 170, 219, 161, 213, 221, 43, 105, 163, 14, 113, 185, 222, 237, 82, 241, 175, 243, 198, 66, 75, 219, 64, 127, 73, 41, 90, 173, 241, 191, 117, 103, 149, 118, 237, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4830), new byte[] { 131, 167, 109, 97, 68, 153, 134, 198, 123, 82, 48, 189, 224, 215, 48, 160, 22, 146, 163, 152, 223, 9, 78, 207, 26, 176, 234, 207, 105, 187, 158, 113, 182, 130, 226, 129, 228, 139, 17, 45, 24, 94, 226, 14, 105, 206, 51, 189, 136, 230, 178, 100, 248, 220, 32, 116, 220, 244, 140, 72, 196, 165, 177, 32 }, new byte[] { 31, 48, 158, 70, 243, 46, 195, 238, 117, 115, 83, 94, 63, 226, 70, 144, 44, 41, 235, 112, 247, 66, 209, 134, 123, 53, 0, 123, 46, 17, 17, 83, 177, 170, 148, 41, 118, 248, 169, 205, 140, 135, 177, 199, 24, 5, 70, 57, 177, 99, 163, 47, 227, 189, 12, 87, 241, 166, 177, 173, 73, 13, 150, 214, 4, 135, 255, 118, 128, 155, 201, 116, 168, 243, 94, 253, 108, 128, 245, 132, 47, 36, 255, 190, 187, 158, 43, 19, 19, 98, 4, 122, 216, 132, 150, 91, 48, 101, 70, 8, 121, 100, 114, 152, 94, 30, 220, 103, 196, 203, 105, 51, 196, 79, 169, 59, 147, 246, 192, 162, 227, 10, 157, 66, 175, 126, 0, 248 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyStatus",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Companys");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3842), new byte[] { 78, 112, 88, 167, 120, 94, 245, 75, 222, 40, 91, 138, 18, 151, 168, 4, 209, 46, 221, 125, 245, 88, 139, 40, 61, 90, 59, 10, 196, 67, 203, 158, 86, 100, 208, 82, 21, 51, 70, 139, 221, 31, 125, 190, 71, 153, 100, 78, 13, 49, 49, 80, 8, 168, 251, 67, 202, 244, 149, 146, 102, 177, 148, 145 }, new byte[] { 140, 117, 58, 246, 13, 139, 246, 37, 100, 106, 70, 188, 57, 245, 106, 213, 215, 238, 108, 153, 88, 204, 50, 231, 57, 255, 202, 164, 44, 72, 37, 38, 72, 218, 7, 115, 124, 125, 232, 240, 254, 247, 167, 151, 168, 65, 89, 21, 36, 86, 186, 198, 130, 50, 83, 40, 18, 93, 102, 183, 18, 75, 141, 97, 115, 46, 110, 63, 167, 188, 236, 210, 46, 194, 90, 75, 59, 124, 151, 60, 211, 77, 137, 167, 226, 39, 148, 221, 237, 158, 135, 211, 79, 46, 129, 85, 120, 177, 147, 211, 154, 245, 121, 54, 223, 55, 88, 183, 173, 49, 192, 190, 102, 30, 215, 99, 170, 237, 195, 56, 9, 210, 94, 204, 122, 106, 126, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3851), new byte[] { 212, 158, 197, 92, 104, 133, 92, 188, 113, 186, 5, 222, 78, 179, 113, 35, 184, 50, 93, 85, 73, 0, 171, 148, 0, 38, 183, 229, 128, 126, 144, 113, 39, 177, 217, 155, 209, 228, 209, 66, 238, 120, 167, 112, 158, 102, 103, 81, 230, 66, 195, 87, 126, 35, 202, 129, 46, 96, 145, 83, 89, 50, 144, 137 }, new byte[] { 169, 254, 61, 47, 136, 220, 64, 53, 47, 44, 101, 242, 117, 246, 224, 113, 3, 180, 185, 101, 23, 54, 3, 16, 255, 168, 89, 167, 0, 21, 174, 123, 113, 68, 68, 169, 168, 225, 72, 191, 112, 33, 250, 24, 133, 196, 18, 91, 178, 178, 87, 215, 217, 208, 160, 56, 24, 251, 168, 8, 199, 171, 158, 44, 111, 101, 132, 102, 24, 218, 71, 91, 41, 81, 155, 25, 7, 182, 159, 26, 19, 160, 79, 168, 151, 6, 86, 205, 112, 226, 43, 108, 45, 234, 48, 253, 240, 116, 227, 2, 5, 198, 154, 245, 229, 159, 215, 170, 43, 168, 19, 138, 59, 214, 177, 105, 74, 210, 77, 156, 223, 96, 181, 109, 163, 201, 233, 16 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3852), new byte[] { 42, 175, 253, 188, 180, 246, 88, 195, 194, 1, 223, 3, 64, 125, 204, 188, 114, 214, 130, 129, 207, 87, 142, 252, 185, 254, 186, 184, 165, 21, 148, 64, 83, 37, 248, 3, 195, 80, 210, 49, 19, 171, 234, 28, 13, 254, 137, 198, 60, 22, 245, 84, 55, 118, 110, 137, 49, 252, 7, 60, 214, 37, 145, 240 }, new byte[] { 20, 12, 166, 124, 20, 253, 66, 142, 96, 45, 250, 231, 98, 56, 195, 98, 198, 62, 204, 46, 16, 66, 102, 128, 228, 96, 224, 88, 232, 239, 101, 91, 1, 243, 35, 119, 3, 128, 174, 5, 69, 113, 172, 88, 46, 135, 144, 226, 94, 242, 210, 148, 255, 218, 111, 61, 176, 87, 56, 220, 147, 150, 151, 195, 64, 56, 237, 83, 121, 148, 238, 242, 9, 86, 27, 206, 107, 250, 40, 4, 180, 251, 136, 138, 75, 72, 149, 207, 45, 176, 56, 209, 99, 23, 74, 112, 225, 138, 176, 152, 5, 35, 125, 165, 212, 118, 169, 179, 43, 26, 86, 81, 107, 177, 236, 6, 232, 33, 32, 36, 243, 90, 95, 129, 197, 206, 47, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3854), new byte[] { 189, 85, 40, 177, 153, 173, 218, 203, 120, 84, 242, 237, 41, 18, 243, 31, 208, 163, 137, 121, 240, 109, 198, 161, 216, 53, 236, 27, 13, 216, 54, 198, 29, 192, 197, 203, 236, 11, 69, 227, 46, 211, 177, 14, 49, 18, 195, 198, 36, 161, 240, 250, 255, 136, 19, 213, 80, 32, 10, 227, 117, 137, 97, 239 }, new byte[] { 208, 114, 35, 98, 113, 160, 102, 254, 127, 54, 197, 227, 234, 42, 156, 87, 78, 227, 94, 198, 234, 88, 91, 192, 64, 217, 122, 131, 98, 153, 42, 131, 181, 149, 154, 55, 86, 190, 28, 92, 40, 180, 31, 18, 80, 214, 145, 146, 127, 186, 178, 63, 0, 29, 243, 51, 118, 131, 147, 222, 219, 67, 141, 8, 186, 90, 85, 89, 42, 91, 104, 242, 132, 17, 173, 189, 186, 117, 9, 117, 100, 115, 214, 253, 178, 94, 217, 76, 92, 250, 2, 254, 193, 229, 89, 131, 58, 21, 43, 164, 178, 199, 3, 73, 103, 33, 230, 162, 222, 8, 50, 248, 110, 140, 69, 83, 13, 26, 143, 255, 188, 227, 45, 221, 214, 149, 199, 182 } });
        }
    }
}
