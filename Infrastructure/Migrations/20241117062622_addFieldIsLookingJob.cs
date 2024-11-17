using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addFieldIsLookingJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLookingForJob",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedDate", "IsLookingForJob", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6746), false, new byte[] { 124, 251, 2, 98, 186, 102, 231, 7, 2, 0, 40, 118, 164, 252, 195, 187, 137, 90, 31, 220, 19, 52, 118, 103, 232, 141, 97, 143, 69, 102, 86, 19, 51, 152, 186, 253, 190, 68, 173, 23, 161, 249, 203, 167, 29, 9, 37, 238, 147, 10, 12, 226, 85, 91, 161, 26, 146, 139, 30, 41, 98, 155, 105, 38 }, new byte[] { 46, 171, 165, 126, 208, 129, 251, 12, 221, 66, 238, 39, 120, 129, 231, 33, 99, 22, 68, 62, 39, 143, 238, 178, 75, 61, 137, 91, 140, 88, 249, 52, 85, 219, 28, 42, 194, 11, 211, 184, 233, 109, 215, 45, 157, 188, 34, 7, 94, 100, 180, 26, 5, 116, 167, 241, 0, 29, 198, 15, 112, 220, 149, 31, 179, 15, 247, 115, 65, 95, 107, 181, 121, 116, 215, 153, 251, 228, 130, 172, 82, 206, 5, 248, 242, 66, 115, 176, 77, 100, 202, 158, 204, 59, 215, 95, 79, 117, 255, 30, 20, 6, 73, 251, 220, 199, 95, 224, 206, 93, 3, 110, 30, 137, 38, 159, 9, 1, 130, 116, 49, 180, 5, 221, 107, 114, 224, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsLookingForJob", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6753), false, new byte[] { 15, 116, 136, 19, 226, 20, 238, 69, 229, 177, 147, 91, 192, 13, 123, 217, 89, 18, 189, 122, 208, 90, 166, 163, 182, 90, 144, 159, 69, 128, 109, 159, 136, 227, 12, 22, 142, 139, 163, 28, 156, 145, 226, 107, 59, 141, 99, 131, 238, 247, 20, 57, 133, 8, 150, 163, 249, 202, 77, 53, 122, 214, 98, 126 }, new byte[] { 148, 161, 69, 163, 209, 10, 154, 47, 165, 36, 90, 224, 4, 244, 235, 166, 183, 79, 127, 49, 102, 239, 126, 3, 242, 6, 62, 124, 171, 100, 130, 147, 234, 195, 220, 252, 100, 250, 194, 9, 241, 35, 77, 138, 46, 90, 164, 41, 217, 54, 40, 119, 126, 56, 219, 119, 75, 232, 76, 97, 92, 114, 179, 66, 8, 72, 75, 53, 198, 112, 73, 69, 122, 65, 224, 86, 241, 123, 235, 239, 140, 111, 120, 154, 215, 200, 153, 178, 206, 145, 232, 41, 233, 197, 151, 7, 218, 231, 205, 240, 13, 149, 251, 155, 95, 68, 9, 68, 239, 41, 17, 11, 143, 180, 85, 125, 5, 113, 203, 16, 224, 18, 51, 213, 115, 76, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsLookingForJob", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6755), false, new byte[] { 147, 21, 141, 124, 36, 216, 109, 254, 128, 121, 166, 27, 69, 83, 113, 115, 112, 89, 138, 141, 22, 76, 166, 79, 194, 4, 114, 180, 210, 199, 145, 240, 184, 168, 31, 37, 95, 218, 162, 35, 177, 222, 190, 67, 120, 234, 243, 53, 36, 131, 137, 171, 61, 119, 67, 244, 117, 118, 82, 122, 151, 246, 113, 215 }, new byte[] { 157, 91, 220, 166, 176, 6, 207, 195, 160, 180, 85, 181, 230, 138, 93, 188, 82, 74, 150, 236, 208, 232, 197, 201, 48, 136, 215, 145, 55, 86, 23, 24, 142, 21, 221, 123, 189, 54, 191, 59, 46, 59, 217, 118, 66, 220, 250, 215, 127, 181, 37, 146, 29, 167, 178, 46, 235, 96, 45, 52, 24, 136, 74, 194, 9, 197, 188, 192, 119, 160, 9, 71, 28, 131, 37, 158, 210, 140, 0, 176, 85, 31, 120, 39, 155, 17, 225, 126, 213, 121, 80, 6, 93, 73, 84, 226, 5, 176, 217, 29, 36, 182, 219, 189, 165, 137, 125, 245, 28, 110, 239, 235, 24, 32, 223, 63, 83, 99, 64, 253, 85, 253, 83, 177, 149, 207, 89, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsLookingForJob", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 6, 26, 21, 869, DateTimeKind.Utc).AddTicks(6757), false, new byte[] { 16, 36, 142, 6, 67, 85, 221, 136, 212, 186, 51, 12, 78, 106, 38, 92, 169, 195, 183, 23, 109, 249, 89, 2, 202, 212, 13, 252, 105, 34, 198, 124, 42, 73, 185, 250, 86, 1, 49, 203, 137, 145, 210, 190, 38, 156, 248, 160, 2, 11, 175, 238, 222, 227, 10, 193, 76, 176, 187, 2, 80, 136, 139, 36 }, new byte[] { 9, 211, 136, 88, 86, 184, 239, 45, 246, 150, 145, 126, 222, 78, 145, 61, 28, 235, 32, 129, 61, 101, 56, 176, 59, 31, 86, 112, 75, 202, 137, 13, 69, 78, 235, 12, 131, 146, 180, 135, 119, 12, 174, 252, 94, 245, 80, 186, 79, 64, 97, 87, 107, 14, 112, 162, 162, 27, 126, 158, 65, 84, 11, 115, 150, 55, 124, 74, 14, 0, 222, 34, 172, 36, 33, 151, 194, 111, 82, 115, 66, 13, 22, 89, 188, 216, 57, 42, 243, 46, 210, 176, 90, 208, 217, 77, 162, 211, 21, 151, 2, 17, 199, 163, 111, 36, 46, 65, 83, 231, 6, 27, 159, 66, 226, 32, 138, 133, 250, 41, 56, 217, 195, 14, 217, 192, 224, 54 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLookingForJob",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 534, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 534, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3660), new byte[] { 157, 173, 238, 170, 58, 10, 214, 122, 115, 12, 118, 122, 225, 136, 189, 1, 188, 139, 234, 154, 202, 119, 64, 32, 183, 235, 235, 144, 209, 132, 6, 24, 186, 235, 89, 148, 223, 206, 219, 129, 76, 145, 99, 46, 65, 139, 254, 246, 35, 57, 134, 133, 81, 234, 7, 197, 101, 250, 129, 25, 83, 97, 4, 144 }, new byte[] { 179, 5, 238, 40, 136, 56, 5, 195, 201, 20, 242, 222, 51, 223, 17, 244, 20, 39, 91, 141, 43, 150, 82, 228, 250, 35, 52, 243, 101, 10, 203, 131, 95, 112, 113, 65, 110, 59, 35, 249, 235, 10, 30, 216, 10, 139, 107, 203, 239, 157, 182, 20, 146, 34, 250, 24, 117, 232, 85, 63, 35, 162, 22, 43, 38, 84, 162, 25, 210, 196, 61, 117, 162, 142, 244, 108, 3, 82, 11, 85, 31, 213, 205, 126, 231, 137, 142, 162, 98, 2, 121, 161, 119, 241, 161, 187, 202, 63, 216, 112, 55, 208, 193, 51, 147, 23, 253, 16, 58, 196, 17, 135, 250, 71, 119, 216, 191, 103, 104, 245, 156, 228, 95, 220, 193, 73, 135, 84 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3667), new byte[] { 195, 89, 246, 49, 207, 43, 1, 16, 134, 97, 20, 77, 178, 191, 15, 75, 10, 101, 85, 29, 214, 169, 157, 77, 171, 93, 124, 112, 58, 22, 17, 107, 121, 150, 69, 191, 185, 9, 226, 36, 67, 74, 71, 179, 253, 184, 116, 107, 186, 155, 187, 30, 0, 54, 123, 93, 210, 106, 112, 36, 87, 105, 63, 118 }, new byte[] { 112, 106, 198, 132, 124, 235, 203, 37, 182, 159, 12, 33, 225, 92, 137, 204, 230, 209, 113, 96, 238, 169, 196, 2, 219, 193, 243, 255, 190, 154, 67, 118, 248, 141, 80, 11, 199, 23, 107, 84, 122, 237, 37, 254, 37, 115, 199, 165, 132, 246, 103, 201, 198, 37, 62, 233, 194, 77, 97, 155, 226, 228, 26, 149, 185, 241, 60, 204, 182, 1, 53, 231, 238, 127, 147, 159, 12, 5, 70, 195, 79, 102, 168, 36, 199, 190, 156, 183, 91, 244, 205, 87, 87, 117, 102, 245, 75, 94, 225, 119, 222, 5, 23, 65, 139, 218, 244, 33, 165, 74, 85, 170, 7, 61, 218, 213, 125, 209, 135, 88, 60, 204, 26, 86, 164, 206, 26, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3669), new byte[] { 184, 108, 68, 131, 9, 32, 0, 85, 112, 159, 115, 211, 134, 72, 152, 40, 87, 9, 202, 218, 4, 122, 232, 58, 158, 127, 24, 119, 16, 74, 46, 48, 191, 251, 192, 11, 48, 225, 180, 194, 150, 70, 175, 250, 154, 233, 130, 214, 215, 224, 92, 80, 28, 196, 40, 240, 35, 199, 39, 75, 152, 232, 127, 134 }, new byte[] { 91, 250, 167, 4, 229, 234, 68, 218, 127, 224, 41, 69, 6, 132, 197, 59, 231, 107, 218, 193, 48, 113, 219, 13, 65, 249, 52, 136, 113, 152, 141, 1, 83, 84, 63, 82, 100, 198, 21, 234, 241, 55, 0, 8, 75, 191, 190, 15, 227, 158, 10, 54, 201, 174, 28, 70, 147, 169, 203, 12, 118, 220, 166, 242, 95, 78, 249, 3, 146, 140, 20, 201, 52, 176, 134, 48, 91, 246, 34, 239, 191, 158, 13, 39, 37, 233, 145, 46, 119, 29, 11, 27, 109, 190, 144, 233, 122, 218, 172, 165, 149, 182, 41, 47, 34, 2, 182, 107, 246, 110, 158, 159, 78, 149, 146, 101, 155, 230, 103, 89, 139, 115, 37, 73, 28, 232, 142, 64 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3671), new byte[] { 103, 218, 115, 157, 22, 255, 4, 27, 90, 14, 160, 50, 203, 170, 136, 44, 5, 19, 203, 17, 139, 144, 46, 227, 140, 90, 16, 180, 202, 66, 5, 233, 198, 11, 11, 220, 23, 70, 121, 22, 72, 8, 205, 109, 17, 4, 125, 160, 239, 55, 89, 18, 205, 102, 141, 70, 139, 182, 255, 142, 106, 97, 222, 165 }, new byte[] { 239, 85, 56, 2, 239, 102, 118, 0, 31, 72, 33, 231, 126, 189, 28, 212, 16, 151, 147, 134, 55, 45, 95, 159, 204, 252, 134, 149, 22, 34, 90, 88, 101, 9, 93, 80, 204, 231, 87, 128, 22, 78, 14, 200, 73, 202, 199, 168, 202, 196, 140, 59, 203, 233, 158, 242, 210, 202, 130, 253, 177, 145, 10, 22, 39, 104, 184, 234, 239, 98, 167, 121, 72, 57, 1, 42, 205, 92, 55, 177, 27, 247, 38, 57, 26, 199, 208, 43, 93, 101, 195, 16, 15, 213, 210, 15, 2, 227, 126, 210, 160, 233, 111, 31, 193, 254, 186, 80, 185, 83, 44, 14, 188, 127, 132, 156, 204, 92, 61, 224, 161, 229, 74, 11, 82, 253, 147, 49 } });
        }
    }
}
