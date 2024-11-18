using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVectorEmbedding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float[]>(
                name: "VectorEmbedding",
                table: "JobPosts",
                type: "real[]",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VectorEmbedding",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 17, 34, 43, 907, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(2650), new byte[] { 231, 132, 116, 11, 165, 112, 26, 234, 10, 123, 86, 210, 124, 67, 124, 110, 104, 16, 122, 184, 242, 26, 185, 224, 13, 13, 93, 81, 4, 71, 61, 13, 177, 166, 194, 2, 24, 177, 125, 43, 119, 7, 14, 225, 131, 28, 243, 132, 113, 4, 207, 95, 197, 178, 244, 187, 238, 119, 216, 74, 202, 2, 12, 165 }, new byte[] { 147, 30, 131, 223, 33, 237, 62, 7, 132, 116, 127, 10, 31, 171, 144, 188, 205, 20, 127, 206, 250, 231, 77, 241, 3, 64, 189, 66, 199, 71, 224, 139, 152, 186, 165, 79, 171, 255, 245, 97, 248, 112, 248, 35, 136, 228, 58, 27, 69, 118, 41, 43, 152, 2, 129, 47, 52, 19, 239, 215, 178, 76, 166, 157, 147, 61, 38, 145, 151, 170, 81, 195, 111, 165, 39, 123, 206, 118, 57, 60, 240, 99, 167, 81, 154, 1, 94, 179, 126, 6, 183, 156, 228, 87, 12, 228, 197, 174, 59, 102, 216, 139, 8, 218, 45, 244, 180, 126, 217, 188, 165, 216, 83, 53, 5, 132, 62, 166, 147, 48, 135, 75, 133, 120, 120, 74, 28, 107 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(2659), new byte[] { 177, 236, 183, 29, 105, 117, 222, 74, 39, 7, 172, 33, 153, 177, 125, 91, 1, 207, 177, 12, 93, 115, 132, 185, 88, 238, 108, 18, 4, 206, 136, 195, 254, 94, 91, 16, 187, 14, 202, 169, 195, 117, 151, 219, 115, 126, 105, 87, 13, 179, 123, 216, 0, 96, 192, 92, 6, 189, 5, 117, 60, 23, 14, 156 }, new byte[] { 171, 35, 123, 203, 20, 49, 166, 26, 167, 241, 48, 18, 139, 118, 201, 89, 78, 5, 178, 23, 221, 59, 5, 98, 199, 176, 28, 69, 183, 88, 165, 88, 151, 237, 163, 8, 108, 230, 78, 12, 252, 212, 4, 163, 245, 49, 215, 152, 64, 46, 143, 85, 16, 241, 92, 20, 202, 180, 226, 185, 78, 242, 177, 8, 83, 243, 27, 49, 197, 128, 17, 79, 219, 138, 3, 194, 235, 99, 70, 94, 42, 125, 174, 173, 163, 132, 170, 10, 209, 7, 121, 96, 29, 160, 179, 91, 3, 246, 37, 183, 4, 79, 74, 21, 214, 141, 168, 221, 242, 211, 24, 87, 196, 188, 123, 39, 5, 196, 57, 28, 121, 138, 52, 73, 9, 173, 198, 229 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(2662), new byte[] { 86, 230, 236, 248, 113, 57, 111, 22, 124, 95, 99, 172, 247, 28, 134, 212, 9, 74, 71, 123, 177, 33, 229, 219, 214, 158, 80, 231, 209, 37, 220, 123, 10, 201, 113, 40, 33, 11, 13, 26, 5, 4, 111, 94, 48, 152, 34, 223, 182, 200, 164, 104, 12, 239, 69, 191, 16, 6, 191, 117, 33, 167, 124, 94 }, new byte[] { 100, 4, 102, 144, 89, 237, 9, 188, 221, 69, 165, 53, 186, 214, 246, 253, 220, 179, 130, 73, 89, 248, 253, 75, 41, 80, 110, 241, 232, 86, 127, 80, 101, 69, 254, 228, 93, 244, 84, 206, 147, 122, 226, 114, 229, 214, 9, 222, 244, 103, 116, 245, 224, 125, 175, 64, 203, 146, 171, 237, 31, 105, 230, 188, 36, 91, 223, 104, 41, 193, 244, 95, 84, 33, 102, 115, 21, 194, 249, 175, 89, 116, 196, 56, 157, 115, 39, 145, 78, 100, 26, 88, 232, 35, 13, 230, 156, 139, 157, 159, 37, 144, 119, 28, 67, 60, 230, 136, 236, 71, 45, 172, 210, 247, 54, 127, 225, 49, 23, 114, 61, 235, 60, 161, 103, 178, 38, 240 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 34, 43, 906, DateTimeKind.Utc).AddTicks(2663), new byte[] { 150, 140, 211, 12, 52, 18, 30, 88, 65, 239, 149, 232, 131, 226, 99, 10, 175, 249, 68, 175, 192, 8, 85, 71, 174, 85, 222, 7, 225, 185, 56, 171, 131, 148, 173, 153, 234, 127, 199, 223, 131, 181, 32, 226, 254, 88, 42, 214, 121, 113, 110, 151, 104, 100, 119, 102, 1, 163, 223, 70, 54, 49, 210, 216 }, new byte[] { 23, 244, 243, 219, 33, 145, 130, 60, 12, 252, 197, 229, 7, 105, 114, 127, 20, 32, 99, 12, 85, 216, 38, 94, 4, 11, 211, 185, 146, 202, 149, 55, 6, 205, 40, 70, 163, 190, 149, 110, 206, 141, 35, 218, 101, 16, 187, 167, 8, 143, 251, 27, 108, 129, 49, 78, 143, 160, 59, 200, 37, 110, 91, 118, 224, 207, 230, 124, 85, 15, 240, 252, 154, 96, 128, 177, 228, 170, 93, 153, 113, 121, 230, 87, 153, 79, 23, 218, 101, 70, 4, 81, 40, 166, 82, 193, 40, 141, 18, 230, 169, 79, 102, 216, 218, 154, 164, 147, 215, 171, 84, 149, 38, 150, 136, 40, 7, 118, 140, 202, 177, 26, 25, 162, 86, 214, 1, 86 } });
        }
    }
}
