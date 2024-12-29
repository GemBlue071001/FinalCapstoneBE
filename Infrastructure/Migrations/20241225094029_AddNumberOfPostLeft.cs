using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberOfPostLeft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfPostLeft",
                table: "UserServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPostLeft",
                table: "UserServices");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 374, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 375, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 375, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 20, 56, 377, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 20, 56, 374, DateTimeKind.Utc).AddTicks(7750), new byte[] { 147, 138, 36, 231, 199, 184, 208, 62, 255, 74, 231, 255, 228, 56, 255, 173, 112, 68, 166, 9, 171, 77, 114, 200, 167, 50, 229, 250, 63, 17, 33, 128, 10, 126, 48, 248, 191, 130, 15, 55, 38, 109, 120, 155, 56, 187, 197, 116, 39, 250, 210, 78, 232, 35, 220, 29, 155, 71, 206, 4, 168, 205, 18, 86 }, new byte[] { 46, 117, 51, 82, 113, 56, 143, 2, 253, 20, 198, 197, 21, 219, 222, 145, 159, 194, 190, 212, 61, 86, 175, 1, 73, 102, 125, 194, 67, 237, 242, 149, 118, 3, 151, 108, 149, 121, 185, 66, 174, 62, 165, 112, 145, 71, 190, 26, 102, 88, 169, 221, 17, 61, 249, 49, 27, 22, 9, 124, 45, 218, 238, 185, 215, 72, 162, 198, 1, 159, 136, 43, 218, 58, 23, 30, 192, 205, 246, 221, 119, 10, 55, 162, 189, 158, 195, 59, 144, 222, 170, 118, 108, 206, 31, 75, 147, 10, 148, 45, 228, 42, 41, 6, 177, 134, 80, 182, 189, 53, 177, 148, 140, 229, 57, 173, 41, 255, 25, 31, 84, 88, 246, 106, 246, 113, 76, 120 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 20, 56, 374, DateTimeKind.Utc).AddTicks(7757), new byte[] { 156, 166, 190, 81, 146, 197, 226, 43, 65, 67, 134, 105, 27, 220, 195, 154, 168, 248, 250, 88, 122, 176, 166, 96, 182, 97, 33, 1, 50, 10, 23, 114, 199, 94, 166, 51, 56, 233, 92, 233, 101, 99, 244, 168, 242, 245, 255, 35, 20, 61, 33, 172, 130, 7, 108, 137, 132, 124, 63, 76, 168, 23, 58, 251 }, new byte[] { 223, 253, 53, 197, 4, 2, 197, 176, 1, 200, 27, 24, 173, 246, 155, 147, 248, 192, 103, 55, 202, 183, 39, 119, 184, 32, 46, 247, 4, 155, 245, 235, 41, 21, 192, 51, 180, 67, 193, 233, 244, 221, 172, 189, 48, 57, 212, 58, 98, 191, 48, 61, 123, 96, 140, 20, 95, 30, 188, 109, 75, 179, 179, 157, 248, 111, 227, 7, 50, 216, 73, 9, 123, 184, 54, 41, 90, 47, 39, 188, 4, 37, 73, 4, 104, 76, 175, 128, 80, 93, 0, 133, 182, 216, 200, 15, 250, 39, 111, 170, 245, 14, 187, 30, 22, 220, 5, 204, 75, 93, 130, 169, 203, 90, 206, 169, 58, 125, 7, 141, 138, 217, 58, 20, 175, 40, 7, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 20, 56, 374, DateTimeKind.Utc).AddTicks(7759), new byte[] { 124, 125, 33, 53, 168, 111, 49, 161, 131, 66, 135, 47, 28, 253, 198, 63, 230, 125, 221, 222, 83, 15, 208, 86, 252, 10, 94, 48, 191, 3, 41, 95, 68, 133, 23, 70, 73, 4, 95, 114, 106, 87, 154, 218, 74, 192, 219, 183, 122, 45, 40, 81, 169, 205, 107, 23, 128, 207, 155, 243, 82, 49, 253, 159 }, new byte[] { 15, 156, 24, 62, 30, 254, 158, 15, 72, 106, 253, 241, 158, 143, 203, 203, 218, 96, 234, 225, 20, 82, 73, 83, 24, 194, 199, 100, 20, 202, 179, 151, 187, 96, 253, 216, 255, 2, 140, 203, 186, 94, 72, 138, 220, 173, 16, 97, 150, 73, 107, 183, 173, 90, 208, 208, 243, 131, 215, 54, 107, 224, 132, 217, 18, 14, 251, 86, 204, 33, 122, 167, 168, 255, 209, 58, 207, 253, 104, 131, 121, 166, 49, 3, 181, 124, 200, 106, 98, 215, 155, 112, 108, 210, 204, 19, 133, 89, 56, 207, 101, 255, 18, 195, 150, 33, 171, 63, 63, 201, 185, 28, 160, 138, 140, 224, 70, 169, 151, 211, 201, 31, 201, 211, 63, 37, 84, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 20, 56, 374, DateTimeKind.Utc).AddTicks(7761), new byte[] { 28, 107, 90, 95, 99, 246, 178, 98, 105, 220, 253, 141, 59, 47, 160, 252, 59, 164, 118, 129, 210, 141, 2, 88, 217, 185, 29, 250, 57, 26, 224, 187, 222, 43, 153, 75, 150, 117, 209, 41, 23, 49, 40, 201, 254, 67, 86, 172, 189, 22, 168, 115, 243, 115, 130, 132, 114, 159, 145, 103, 110, 99, 70, 223 }, new byte[] { 126, 18, 216, 31, 50, 83, 217, 99, 208, 17, 39, 229, 142, 0, 36, 18, 136, 17, 161, 92, 28, 187, 94, 94, 78, 98, 95, 107, 28, 116, 148, 97, 144, 117, 227, 171, 61, 102, 221, 12, 222, 170, 249, 231, 4, 38, 15, 25, 217, 48, 213, 13, 28, 215, 200, 135, 25, 50, 50, 235, 83, 251, 6, 178, 39, 174, 196, 75, 201, 122, 194, 7, 96, 128, 57, 126, 38, 166, 207, 46, 132, 38, 46, 248, 128, 205, 7, 107, 224, 21, 0, 106, 95, 115, 115, 165, 142, 194, 110, 240, 95, 231, 82, 20, 208, 50, 106, 171, 151, 202, 119, 111, 47, 249, 27, 93, 253, 171, 229, 227, 143, 82, 93, 4, 65, 166, 210, 222 } });
        }
    }
}
