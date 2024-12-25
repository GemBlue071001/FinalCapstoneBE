using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Services",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(447), new byte[] { 14, 142, 73, 227, 172, 202, 8, 217, 150, 204, 34, 224, 206, 149, 117, 216, 137, 131, 121, 16, 34, 76, 175, 35, 123, 61, 180, 244, 240, 185, 123, 168, 204, 46, 188, 33, 13, 78, 120, 152, 230, 186, 13, 147, 240, 65, 225, 89, 77, 92, 92, 5, 207, 51, 207, 105, 99, 144, 169, 232, 139, 57, 23, 69 }, new byte[] { 62, 171, 201, 243, 197, 163, 128, 101, 146, 238, 83, 205, 201, 102, 49, 136, 158, 153, 103, 231, 65, 210, 78, 141, 3, 112, 188, 50, 61, 37, 159, 159, 202, 160, 246, 33, 51, 239, 227, 192, 45, 21, 84, 221, 54, 163, 60, 174, 120, 105, 131, 65, 68, 206, 73, 127, 234, 255, 72, 113, 122, 204, 45, 171, 226, 194, 11, 216, 150, 250, 144, 194, 123, 234, 168, 68, 40, 221, 226, 60, 105, 179, 203, 140, 121, 87, 77, 153, 253, 236, 201, 82, 78, 90, 243, 202, 98, 54, 172, 25, 62, 203, 230, 39, 79, 116, 194, 206, 119, 211, 154, 124, 202, 180, 188, 133, 9, 32, 183, 91, 131, 38, 102, 44, 253, 134, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(453), new byte[] { 50, 119, 189, 38, 243, 39, 201, 173, 58, 19, 200, 50, 65, 180, 143, 49, 8, 30, 62, 235, 63, 172, 116, 229, 210, 203, 157, 206, 34, 12, 83, 88, 1, 89, 167, 253, 191, 178, 3, 122, 172, 18, 39, 47, 134, 213, 163, 42, 19, 199, 4, 127, 159, 79, 37, 44, 246, 192, 227, 151, 114, 109, 72, 94 }, new byte[] { 135, 91, 254, 102, 2, 172, 119, 82, 191, 200, 123, 231, 111, 215, 18, 159, 119, 12, 57, 113, 213, 225, 92, 70, 87, 38, 156, 53, 248, 33, 83, 171, 56, 83, 47, 70, 179, 102, 118, 63, 208, 198, 198, 82, 5, 240, 156, 201, 194, 81, 117, 60, 241, 2, 146, 228, 202, 55, 247, 220, 242, 43, 67, 224, 118, 140, 86, 159, 206, 63, 149, 99, 209, 147, 225, 49, 237, 79, 39, 94, 204, 235, 243, 84, 217, 57, 191, 56, 166, 195, 115, 32, 69, 47, 6, 170, 106, 209, 171, 167, 211, 239, 166, 48, 53, 246, 23, 47, 255, 168, 4, 43, 99, 143, 240, 109, 243, 188, 154, 0, 121, 50, 189, 127, 26, 103, 2, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(455), new byte[] { 124, 164, 243, 219, 114, 126, 122, 100, 202, 66, 91, 136, 138, 211, 170, 85, 204, 41, 29, 94, 55, 157, 228, 15, 224, 103, 130, 227, 235, 255, 85, 181, 184, 78, 33, 44, 186, 215, 38, 135, 131, 5, 135, 113, 74, 244, 178, 201, 150, 30, 122, 174, 198, 233, 120, 238, 220, 181, 170, 137, 132, 131, 6, 93 }, new byte[] { 11, 251, 126, 68, 250, 14, 187, 192, 172, 202, 234, 91, 166, 54, 221, 0, 45, 207, 60, 20, 192, 223, 163, 3, 15, 240, 222, 20, 182, 244, 253, 182, 164, 98, 3, 19, 29, 244, 245, 194, 46, 144, 102, 192, 224, 127, 14, 224, 236, 10, 40, 172, 96, 162, 83, 156, 6, 222, 253, 193, 191, 140, 52, 1, 240, 237, 206, 65, 87, 144, 230, 110, 189, 104, 87, 130, 122, 79, 144, 40, 90, 61, 0, 102, 11, 163, 60, 212, 141, 202, 225, 113, 223, 196, 134, 80, 65, 123, 57, 172, 195, 251, 242, 205, 162, 241, 32, 33, 229, 26, 192, 135, 82, 45, 150, 2, 36, 116, 86, 167, 65, 69, 60, 132, 139, 203, 150, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(457), new byte[] { 251, 147, 90, 61, 157, 171, 187, 98, 183, 226, 188, 227, 180, 247, 155, 136, 34, 103, 228, 3, 1, 89, 202, 33, 8, 73, 62, 203, 100, 235, 242, 132, 97, 150, 79, 234, 202, 43, 163, 190, 244, 18, 169, 158, 208, 158, 95, 107, 99, 102, 239, 7, 24, 98, 76, 235, 137, 147, 81, 253, 255, 12, 28, 193 }, new byte[] { 46, 48, 85, 216, 76, 105, 150, 177, 51, 100, 121, 146, 61, 145, 174, 92, 4, 171, 159, 193, 97, 243, 236, 67, 214, 23, 124, 202, 247, 125, 181, 92, 210, 161, 124, 38, 85, 31, 242, 138, 228, 119, 34, 9, 63, 202, 213, 172, 23, 145, 124, 167, 142, 224, 139, 142, 9, 180, 226, 4, 221, 87, 177, 237, 126, 109, 248, 107, 217, 152, 120, 228, 74, 28, 87, 61, 109, 251, 179, 222, 240, 57, 69, 94, 179, 53, 150, 187, 19, 234, 217, 21, 92, 70, 209, 8, 55, 234, 23, 170, 3, 120, 96, 87, 147, 210, 183, 14, 248, 247, 75, 215, 229, 44, 143, 246, 23, 43, 62, 112, 136, 35, 44, 11, 158, 177, 1, 41 } });
        }
    }
}
