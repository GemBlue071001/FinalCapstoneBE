using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPremium",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 98, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 98, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7875), false, new byte[] { 126, 1, 67, 166, 217, 48, 165, 70, 81, 47, 130, 77, 139, 220, 212, 87, 125, 137, 155, 158, 214, 78, 210, 51, 220, 150, 59, 206, 129, 182, 150, 48, 127, 160, 64, 157, 128, 81, 55, 190, 252, 159, 196, 190, 84, 178, 226, 196, 30, 241, 212, 128, 213, 223, 8, 127, 189, 217, 80, 251, 168, 168, 214, 151 }, new byte[] { 180, 216, 221, 241, 193, 155, 229, 32, 215, 225, 168, 236, 81, 181, 51, 251, 206, 76, 31, 30, 82, 238, 64, 217, 64, 124, 152, 99, 60, 251, 12, 115, 162, 81, 209, 250, 174, 94, 216, 188, 134, 41, 121, 154, 36, 183, 54, 65, 213, 182, 231, 120, 242, 210, 38, 39, 231, 3, 134, 250, 97, 211, 58, 57, 188, 214, 118, 96, 91, 145, 185, 219, 103, 9, 122, 166, 198, 207, 96, 160, 15, 15, 105, 33, 162, 72, 158, 60, 202, 191, 254, 147, 213, 204, 91, 38, 166, 159, 246, 56, 26, 32, 50, 193, 29, 240, 91, 119, 186, 38, 222, 173, 132, 221, 96, 45, 177, 19, 203, 138, 237, 24, 122, 119, 92, 180, 250, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7883), false, new byte[] { 190, 204, 205, 209, 32, 199, 91, 90, 177, 248, 178, 68, 253, 153, 166, 196, 158, 42, 26, 140, 33, 238, 227, 69, 105, 138, 7, 154, 252, 1, 49, 241, 94, 240, 4, 176, 254, 128, 9, 213, 52, 23, 23, 79, 126, 84, 141, 192, 212, 223, 209, 191, 11, 28, 149, 171, 113, 216, 12, 168, 105, 41, 206, 72 }, new byte[] { 73, 145, 4, 148, 251, 31, 88, 53, 77, 237, 247, 161, 148, 205, 31, 6, 91, 136, 16, 252, 117, 23, 154, 230, 112, 78, 117, 254, 6, 199, 184, 238, 70, 92, 127, 105, 115, 123, 46, 76, 169, 149, 144, 39, 144, 138, 126, 223, 69, 6, 220, 14, 226, 202, 88, 203, 106, 208, 1, 220, 178, 211, 148, 52, 39, 50, 151, 160, 167, 162, 65, 123, 9, 177, 96, 243, 208, 61, 30, 5, 226, 176, 100, 99, 199, 66, 47, 245, 49, 182, 125, 112, 0, 190, 77, 106, 112, 166, 34, 151, 19, 236, 237, 175, 0, 120, 85, 209, 18, 85, 38, 247, 68, 139, 164, 170, 233, 236, 59, 5, 85, 176, 58, 235, 0, 149, 88, 61 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7885), false, new byte[] { 3, 180, 98, 17, 51, 92, 255, 138, 249, 37, 233, 22, 167, 190, 230, 38, 103, 147, 103, 253, 37, 6, 151, 34, 109, 172, 16, 130, 50, 184, 37, 130, 164, 5, 49, 163, 52, 215, 48, 182, 138, 233, 241, 186, 103, 212, 60, 111, 230, 150, 169, 64, 32, 149, 201, 121, 229, 145, 1, 217, 133, 77, 250, 28 }, new byte[] { 44, 105, 62, 159, 136, 223, 97, 23, 46, 211, 121, 116, 92, 8, 226, 79, 243, 198, 58, 119, 251, 45, 169, 148, 57, 57, 217, 202, 161, 45, 203, 43, 113, 206, 64, 19, 162, 5, 167, 39, 230, 72, 128, 57, 117, 164, 22, 50, 130, 232, 136, 137, 160, 201, 236, 148, 166, 127, 238, 18, 191, 73, 120, 182, 181, 162, 201, 221, 74, 175, 32, 218, 215, 168, 185, 193, 254, 24, 82, 140, 246, 224, 101, 58, 27, 38, 186, 152, 74, 43, 68, 194, 61, 0, 243, 104, 68, 157, 154, 93, 202, 96, 45, 229, 144, 58, 236, 38, 241, 210, 229, 57, 228, 191, 158, 151, 72, 27, 127, 80, 247, 37, 7, 233, 139, 38, 92, 19 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7886), false, new byte[] { 41, 185, 40, 29, 90, 34, 44, 238, 199, 150, 39, 169, 63, 214, 87, 205, 185, 94, 245, 1, 3, 150, 248, 86, 101, 103, 55, 171, 24, 227, 73, 211, 77, 14, 48, 42, 80, 34, 75, 127, 101, 14, 9, 0, 239, 220, 219, 47, 204, 97, 11, 174, 183, 46, 99, 97, 157, 23, 158, 157, 78, 16, 176, 73 }, new byte[] { 163, 238, 216, 238, 186, 86, 143, 137, 246, 154, 170, 27, 100, 170, 243, 191, 255, 144, 219, 199, 220, 31, 5, 179, 40, 87, 121, 225, 76, 150, 47, 164, 125, 127, 132, 143, 44, 208, 237, 251, 233, 30, 141, 179, 28, 150, 212, 42, 210, 197, 111, 33, 15, 75, 128, 205, 153, 184, 2, 73, 73, 76, 184, 16, 125, 42, 128, 166, 128, 201, 236, 236, 178, 175, 113, 34, 242, 98, 89, 246, 153, 40, 145, 180, 7, 206, 15, 65, 32, 89, 186, 250, 158, 245, 59, 13, 70, 237, 249, 235, 50, 25, 61, 175, 31, 15, 117, 127, 14, 118, 186, 251, 226, 78, 132, 190, 251, 73, 86, 87, 42, 15, 105, 173, 165, 177, 120, 242 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPremium",
                table: "Users",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(548), null, new byte[] { 231, 202, 10, 121, 223, 217, 205, 31, 161, 199, 46, 182, 115, 27, 103, 159, 54, 72, 186, 105, 221, 161, 169, 179, 255, 126, 152, 160, 135, 208, 234, 40, 149, 52, 63, 180, 112, 163, 133, 77, 156, 222, 175, 182, 167, 51, 143, 227, 251, 25, 50, 54, 219, 103, 146, 250, 101, 107, 111, 33, 199, 15, 116, 75 }, new byte[] { 91, 53, 135, 111, 172, 61, 85, 240, 189, 94, 92, 80, 132, 49, 3, 18, 96, 43, 208, 61, 237, 62, 137, 10, 53, 161, 143, 156, 197, 76, 220, 131, 155, 120, 73, 32, 74, 168, 145, 241, 231, 103, 198, 22, 140, 135, 74, 3, 231, 24, 191, 184, 71, 204, 183, 210, 38, 23, 47, 228, 71, 74, 57, 28, 5, 177, 148, 7, 145, 201, 160, 2, 217, 185, 72, 208, 151, 213, 208, 113, 28, 179, 130, 183, 239, 66, 3, 125, 99, 43, 61, 189, 176, 47, 62, 204, 70, 61, 226, 177, 108, 114, 80, 237, 111, 91, 161, 235, 3, 219, 78, 179, 108, 145, 183, 239, 214, 97, 81, 64, 218, 97, 93, 235, 176, 81, 254, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(555), null, new byte[] { 222, 38, 76, 42, 135, 75, 126, 185, 127, 67, 120, 154, 134, 209, 78, 154, 82, 136, 158, 196, 44, 244, 117, 136, 72, 195, 118, 225, 101, 31, 21, 249, 52, 42, 201, 127, 195, 60, 56, 162, 40, 147, 127, 146, 130, 77, 20, 230, 254, 4, 214, 217, 78, 122, 86, 215, 219, 133, 26, 254, 90, 76, 182, 15 }, new byte[] { 84, 27, 15, 147, 245, 204, 29, 241, 121, 39, 84, 72, 86, 247, 152, 58, 140, 18, 133, 133, 131, 17, 59, 80, 104, 255, 110, 21, 24, 196, 34, 152, 143, 146, 42, 2, 151, 133, 26, 222, 238, 138, 72, 176, 41, 172, 14, 246, 205, 143, 193, 199, 105, 45, 71, 88, 146, 21, 100, 15, 251, 101, 224, 227, 104, 240, 191, 17, 45, 99, 179, 47, 94, 105, 104, 217, 74, 240, 174, 138, 250, 22, 223, 172, 45, 59, 198, 178, 170, 154, 210, 147, 59, 241, 219, 195, 59, 192, 186, 128, 135, 168, 124, 99, 157, 210, 245, 171, 183, 132, 134, 222, 178, 2, 33, 183, 246, 163, 109, 6, 169, 70, 206, 129, 7, 171, 24, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(557), null, new byte[] { 167, 59, 214, 54, 253, 44, 183, 113, 249, 244, 144, 135, 221, 222, 191, 89, 170, 86, 54, 106, 27, 178, 239, 79, 25, 95, 138, 186, 164, 33, 156, 221, 8, 84, 195, 178, 107, 188, 72, 77, 145, 172, 30, 17, 224, 42, 1, 194, 241, 43, 209, 67, 207, 183, 205, 161, 34, 54, 120, 49, 140, 236, 21, 120 }, new byte[] { 245, 0, 79, 30, 198, 223, 174, 19, 196, 57, 178, 69, 216, 126, 148, 123, 175, 158, 142, 53, 251, 130, 173, 151, 60, 125, 127, 61, 146, 55, 213, 200, 189, 39, 84, 32, 19, 171, 63, 195, 64, 255, 162, 151, 154, 150, 100, 73, 184, 244, 121, 230, 132, 22, 249, 242, 7, 102, 134, 102, 88, 205, 132, 159, 26, 156, 218, 209, 222, 191, 246, 54, 190, 141, 18, 56, 181, 228, 12, 175, 45, 54, 189, 73, 18, 45, 74, 198, 86, 71, 211, 243, 200, 187, 4, 113, 133, 179, 113, 253, 36, 137, 164, 36, 196, 109, 195, 120, 40, 209, 49, 49, 64, 52, 104, 76, 215, 132, 137, 86, 138, 6, 140, 12, 157, 156, 147, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(558), null, new byte[] { 158, 106, 11, 87, 132, 239, 215, 2, 18, 73, 130, 225, 167, 102, 219, 23, 17, 167, 38, 164, 115, 209, 29, 44, 77, 81, 140, 96, 151, 231, 208, 234, 141, 238, 132, 72, 23, 59, 17, 55, 206, 240, 125, 112, 133, 38, 128, 60, 37, 14, 241, 150, 147, 169, 35, 247, 69, 135, 254, 180, 237, 46, 232, 248 }, new byte[] { 145, 229, 82, 133, 25, 111, 213, 8, 233, 38, 85, 138, 9, 4, 61, 91, 167, 220, 137, 181, 181, 32, 127, 133, 82, 35, 71, 194, 28, 202, 26, 70, 233, 166, 226, 48, 124, 113, 42, 116, 132, 64, 254, 155, 51, 0, 50, 50, 193, 92, 221, 131, 52, 223, 116, 193, 63, 240, 102, 2, 136, 175, 146, 90, 186, 153, 177, 138, 199, 235, 203, 82, 168, 192, 85, 184, 225, 57, 185, 56, 213, 42, 167, 209, 43, 4, 236, 141, 217, 177, 109, 255, 93, 139, 247, 4, 86, 32, 138, 12, 114, 162, 89, 127, 24, 250, 244, 211, 92, 134, 178, 5, 221, 27, 111, 39, 197, 62, 22, 84, 241, 41, 30, 119, 87, 26, 134, 238 } });
        }
    }
}
