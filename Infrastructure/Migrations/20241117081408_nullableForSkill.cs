using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nullableForSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Shorthand",
                table: "SkillSets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SkillSets",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9543), new byte[] { 63, 208, 131, 213, 12, 248, 26, 243, 122, 110, 43, 44, 174, 38, 183, 242, 147, 80, 8, 164, 0, 232, 23, 33, 200, 79, 36, 236, 48, 227, 134, 110, 116, 64, 77, 142, 13, 211, 242, 11, 113, 136, 186, 197, 142, 243, 18, 92, 132, 96, 2, 179, 67, 36, 111, 161, 241, 114, 213, 70, 166, 209, 18, 84 }, new byte[] { 230, 192, 31, 19, 33, 21, 29, 248, 213, 75, 15, 33, 240, 181, 162, 47, 135, 165, 29, 82, 183, 80, 37, 18, 93, 70, 210, 253, 255, 54, 12, 51, 34, 210, 47, 129, 5, 193, 97, 70, 126, 56, 48, 226, 213, 250, 184, 170, 153, 233, 116, 109, 175, 119, 110, 29, 13, 60, 157, 175, 51, 100, 113, 47, 49, 72, 61, 232, 44, 140, 254, 85, 228, 173, 124, 38, 24, 237, 213, 222, 65, 91, 93, 142, 49, 48, 155, 221, 63, 36, 110, 254, 192, 93, 192, 246, 237, 233, 224, 32, 148, 138, 64, 12, 31, 107, 163, 64, 92, 59, 186, 44, 230, 84, 77, 119, 20, 183, 163, 69, 113, 182, 203, 147, 89, 94, 2, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9550), new byte[] { 224, 229, 54, 58, 231, 134, 126, 132, 42, 31, 220, 108, 226, 225, 211, 178, 145, 196, 67, 14, 95, 247, 128, 87, 74, 23, 141, 246, 5, 232, 134, 84, 132, 229, 112, 251, 33, 161, 174, 143, 213, 85, 136, 196, 136, 157, 35, 201, 225, 26, 138, 82, 118, 8, 252, 14, 52, 175, 16, 186, 105, 216, 60, 55 }, new byte[] { 0, 181, 96, 101, 177, 10, 101, 154, 18, 171, 50, 187, 47, 28, 197, 144, 103, 6, 111, 91, 168, 182, 49, 200, 171, 76, 54, 243, 217, 221, 161, 1, 158, 71, 163, 147, 113, 129, 233, 89, 134, 168, 36, 97, 98, 48, 138, 179, 196, 217, 212, 100, 100, 83, 243, 152, 22, 127, 26, 32, 47, 156, 39, 214, 186, 61, 104, 53, 69, 56, 125, 160, 100, 164, 246, 68, 95, 70, 116, 44, 49, 60, 114, 159, 236, 6, 79, 230, 125, 116, 11, 79, 72, 227, 110, 118, 236, 8, 47, 253, 252, 85, 180, 45, 9, 207, 174, 191, 116, 33, 103, 122, 195, 127, 12, 72, 74, 68, 19, 153, 8, 199, 185, 224, 246, 55, 109, 14 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9552), new byte[] { 250, 194, 201, 100, 167, 200, 111, 192, 177, 146, 38, 24, 196, 231, 172, 127, 116, 171, 75, 158, 76, 152, 249, 215, 220, 64, 208, 56, 134, 22, 62, 62, 229, 240, 1, 166, 175, 49, 136, 75, 6, 21, 46, 108, 140, 43, 208, 220, 132, 86, 204, 119, 13, 107, 39, 170, 106, 53, 244, 130, 227, 213, 3, 88 }, new byte[] { 111, 122, 72, 183, 148, 186, 82, 134, 179, 241, 238, 133, 206, 28, 14, 173, 83, 26, 211, 246, 17, 196, 35, 65, 86, 120, 193, 231, 8, 228, 74, 201, 176, 239, 165, 205, 163, 7, 186, 23, 103, 29, 23, 17, 217, 159, 3, 64, 20, 241, 190, 218, 156, 155, 88, 28, 203, 36, 76, 94, 223, 249, 100, 84, 143, 243, 247, 221, 115, 210, 20, 86, 184, 199, 102, 140, 182, 59, 63, 214, 113, 213, 165, 158, 217, 10, 75, 121, 123, 253, 204, 11, 108, 117, 249, 166, 144, 2, 13, 38, 19, 111, 85, 62, 36, 136, 224, 135, 195, 178, 139, 128, 10, 177, 112, 31, 55, 123, 195, 60, 105, 16, 135, 28, 210, 179, 165, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9554), new byte[] { 142, 247, 186, 138, 85, 56, 99, 233, 124, 160, 16, 87, 114, 129, 198, 184, 161, 254, 210, 55, 19, 52, 233, 141, 106, 191, 204, 84, 191, 57, 125, 251, 52, 75, 216, 49, 102, 241, 11, 0, 228, 188, 206, 209, 138, 130, 189, 66, 168, 211, 52, 141, 49, 4, 217, 231, 224, 204, 207, 196, 240, 126, 208, 24 }, new byte[] { 26, 128, 108, 77, 16, 107, 223, 110, 57, 87, 75, 93, 174, 227, 136, 144, 4, 196, 20, 94, 206, 149, 67, 145, 24, 220, 169, 96, 96, 205, 37, 140, 46, 7, 206, 146, 8, 131, 19, 51, 35, 13, 106, 149, 117, 79, 112, 119, 51, 113, 120, 175, 87, 239, 187, 235, 137, 220, 6, 123, 186, 48, 131, 141, 250, 89, 71, 82, 157, 252, 10, 79, 224, 113, 237, 243, 48, 150, 150, 28, 0, 26, 186, 0, 178, 31, 1, 187, 27, 174, 92, 249, 107, 81, 232, 212, 80, 244, 196, 1, 64, 190, 150, 248, 223, 241, 97, 160, 88, 11, 79, 15, 120, 158, 128, 182, 129, 140, 153, 15, 184, 52, 224, 237, 146, 28, 186, 246 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Shorthand",
                table: "SkillSets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SkillSets",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 871, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 871, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 6, 26, 21, 871, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6746), new byte[] { 124, 251, 2, 98, 186, 102, 231, 7, 2, 0, 40, 118, 164, 252, 195, 187, 137, 90, 31, 220, 19, 52, 118, 103, 232, 141, 97, 143, 69, 102, 86, 19, 51, 152, 186, 253, 190, 68, 173, 23, 161, 249, 203, 167, 29, 9, 37, 238, 147, 10, 12, 226, 85, 91, 161, 26, 146, 139, 30, 41, 98, 155, 105, 38 }, new byte[] { 46, 171, 165, 126, 208, 129, 251, 12, 221, 66, 238, 39, 120, 129, 231, 33, 99, 22, 68, 62, 39, 143, 238, 178, 75, 61, 137, 91, 140, 88, 249, 52, 85, 219, 28, 42, 194, 11, 211, 184, 233, 109, 215, 45, 157, 188, 34, 7, 94, 100, 180, 26, 5, 116, 167, 241, 0, 29, 198, 15, 112, 220, 149, 31, 179, 15, 247, 115, 65, 95, 107, 181, 121, 116, 215, 153, 251, 228, 130, 172, 82, 206, 5, 248, 242, 66, 115, 176, 77, 100, 202, 158, 204, 59, 215, 95, 79, 117, 255, 30, 20, 6, 73, 251, 220, 199, 95, 224, 206, 93, 3, 110, 30, 137, 38, 159, 9, 1, 130, 116, 49, 180, 5, 221, 107, 114, 224, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6753), new byte[] { 15, 116, 136, 19, 226, 20, 238, 69, 229, 177, 147, 91, 192, 13, 123, 217, 89, 18, 189, 122, 208, 90, 166, 163, 182, 90, 144, 159, 69, 128, 109, 159, 136, 227, 12, 22, 142, 139, 163, 28, 156, 145, 226, 107, 59, 141, 99, 131, 238, 247, 20, 57, 133, 8, 150, 163, 249, 202, 77, 53, 122, 214, 98, 126 }, new byte[] { 148, 161, 69, 163, 209, 10, 154, 47, 165, 36, 90, 224, 4, 244, 235, 166, 183, 79, 127, 49, 102, 239, 126, 3, 242, 6, 62, 124, 171, 100, 130, 147, 234, 195, 220, 252, 100, 250, 194, 9, 241, 35, 77, 138, 46, 90, 164, 41, 217, 54, 40, 119, 126, 56, 219, 119, 75, 232, 76, 97, 92, 114, 179, 66, 8, 72, 75, 53, 198, 112, 73, 69, 122, 65, 224, 86, 241, 123, 235, 239, 140, 111, 120, 154, 215, 200, 153, 178, 206, 145, 232, 41, 233, 197, 151, 7, 218, 231, 205, 240, 13, 149, 251, 155, 95, 68, 9, 68, 239, 41, 17, 11, 143, 180, 85, 125, 5, 113, 203, 16, 224, 18, 51, 213, 115, 76, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6755), new byte[] { 147, 21, 141, 124, 36, 216, 109, 254, 128, 121, 166, 27, 69, 83, 113, 115, 112, 89, 138, 141, 22, 76, 166, 79, 194, 4, 114, 180, 210, 199, 145, 240, 184, 168, 31, 37, 95, 218, 162, 35, 177, 222, 190, 67, 120, 234, 243, 53, 36, 131, 137, 171, 61, 119, 67, 244, 117, 118, 82, 122, 151, 246, 113, 215 }, new byte[] { 157, 91, 220, 166, 176, 6, 207, 195, 160, 180, 85, 181, 230, 138, 93, 188, 82, 74, 150, 236, 208, 232, 197, 201, 48, 136, 215, 145, 55, 86, 23, 24, 142, 21, 221, 123, 189, 54, 191, 59, 46, 59, 217, 118, 66, 220, 250, 215, 127, 181, 37, 146, 29, 167, 178, 46, 235, 96, 45, 52, 24, 136, 74, 194, 9, 197, 188, 192, 119, 160, 9, 71, 28, 131, 37, 158, 210, 140, 0, 176, 85, 31, 120, 39, 155, 17, 225, 126, 213, 121, 80, 6, 93, 73, 84, 226, 5, 176, 217, 29, 36, 182, 219, 189, 165, 137, 125, 245, 28, 110, 239, 235, 24, 32, 223, 63, 83, 99, 64, 253, 85, 253, 83, 177, 149, 207, 89, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6757), new byte[] { 16, 36, 142, 6, 67, 85, 221, 136, 212, 186, 51, 12, 78, 106, 38, 92, 169, 195, 183, 23, 109, 249, 89, 2, 202, 212, 13, 252, 105, 34, 198, 124, 42, 73, 185, 250, 86, 1, 49, 203, 137, 145, 210, 190, 38, 156, 248, 160, 2, 11, 175, 238, 222, 227, 10, 193, 76, 176, 187, 2, 80, 136, 139, 36 }, new byte[] { 9, 211, 136, 88, 86, 184, 239, 45, 246, 150, 145, 126, 222, 78, 145, 61, 28, 235, 32, 129, 61, 101, 56, 176, 59, 31, 86, 112, 75, 202, 137, 13, 69, 78, 235, 12, 131, 146, 180, 135, 119, 12, 174, 252, 94, 245, 80, 186, 79, 64, 97, 87, 107, 14, 112, 162, 162, 27, 126, 158, 65, 84, 11, 115, 150, 55, 124, 74, 14, 0, 222, 34, 172, 36, 33, 151, 194, 111, 82, 115, 66, 13, 22, 89, 188, 216, 57, 42, 243, 46, 210, 176, 90, 208, 217, 77, 162, 211, 21, 151, 2, 17, 199, 163, 111, 36, 46, 65, 83, 231, 6, 27, 159, 66, 226, 32, 138, 133, 250, 41, 56, 217, 195, 14, 217, 192, 224, 54 } });
        }
    }
}
