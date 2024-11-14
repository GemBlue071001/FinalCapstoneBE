using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 414, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 414, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4286), new byte[] { 160, 163, 142, 34, 94, 207, 199, 193, 114, 155, 110, 118, 76, 81, 35, 180, 124, 10, 24, 178, 211, 187, 138, 107, 169, 15, 93, 136, 158, 85, 246, 220, 99, 225, 111, 191, 38, 190, 91, 15, 21, 167, 249, 106, 51, 11, 161, 136, 239, 117, 177, 208, 142, 92, 63, 43, 242, 83, 53, 120, 240, 20, 165, 91 }, new byte[] { 20, 54, 169, 212, 222, 29, 175, 186, 35, 220, 39, 67, 141, 159, 17, 180, 101, 179, 111, 49, 163, 238, 27, 133, 37, 216, 219, 102, 192, 19, 61, 119, 47, 136, 19, 77, 11, 76, 151, 186, 30, 252, 237, 74, 25, 163, 71, 45, 78, 65, 185, 94, 9, 234, 249, 162, 240, 30, 95, 141, 70, 4, 209, 159, 37, 23, 128, 18, 30, 208, 110, 185, 216, 180, 243, 45, 109, 196, 88, 240, 42, 193, 66, 32, 127, 132, 32, 125, 89, 116, 149, 38, 155, 255, 18, 85, 107, 98, 73, 141, 43, 86, 248, 63, 105, 216, 176, 216, 58, 141, 149, 166, 226, 57, 113, 176, 206, 74, 54, 254, 18, 36, 212, 214, 39, 92, 211, 52 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4294), new byte[] { 205, 210, 92, 137, 28, 190, 255, 236, 21, 85, 178, 46, 92, 120, 223, 29, 192, 255, 168, 132, 72, 156, 154, 106, 182, 223, 82, 29, 52, 66, 212, 114, 212, 233, 75, 36, 255, 155, 137, 114, 141, 6, 241, 33, 26, 83, 192, 164, 45, 75, 151, 96, 153, 221, 206, 105, 54, 152, 218, 138, 64, 171, 70, 0 }, new byte[] { 51, 145, 163, 129, 253, 44, 69, 36, 227, 131, 52, 228, 132, 130, 234, 182, 121, 25, 110, 190, 222, 244, 199, 120, 226, 48, 101, 194, 112, 104, 211, 214, 73, 96, 177, 70, 113, 73, 2, 183, 175, 157, 237, 77, 225, 25, 13, 11, 184, 124, 245, 44, 57, 126, 172, 128, 207, 66, 141, 179, 203, 215, 178, 243, 218, 27, 16, 196, 137, 13, 91, 215, 126, 160, 45, 50, 164, 174, 65, 49, 12, 150, 228, 30, 172, 2, 142, 212, 73, 199, 136, 202, 39, 32, 216, 102, 138, 61, 15, 202, 220, 88, 77, 29, 142, 238, 67, 173, 16, 157, 15, 104, 16, 113, 55, 117, 55, 5, 175, 89, 46, 65, 200, 94, 61, 241, 208, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4295), new byte[] { 216, 129, 31, 146, 139, 79, 165, 150, 44, 145, 29, 113, 201, 5, 186, 148, 57, 14, 224, 43, 144, 58, 86, 106, 213, 186, 98, 83, 3, 142, 85, 222, 231, 23, 185, 166, 178, 84, 109, 182, 169, 124, 118, 89, 112, 114, 27, 248, 50, 65, 241, 12, 210, 145, 225, 184, 206, 38, 43, 212, 102, 80, 124, 36 }, new byte[] { 2, 228, 26, 20, 142, 235, 221, 40, 127, 82, 115, 216, 195, 101, 87, 80, 192, 171, 84, 50, 181, 108, 186, 196, 67, 73, 79, 22, 197, 199, 242, 208, 56, 119, 58, 164, 78, 40, 184, 166, 223, 215, 133, 95, 158, 156, 28, 116, 246, 226, 25, 39, 35, 104, 54, 249, 132, 79, 249, 18, 194, 145, 188, 252, 24, 218, 225, 59, 21, 222, 90, 109, 215, 18, 51, 138, 159, 201, 212, 246, 114, 201, 123, 177, 21, 103, 182, 202, 238, 110, 53, 219, 215, 179, 83, 6, 139, 217, 196, 50, 170, 242, 113, 231, 64, 87, 148, 220, 237, 254, 32, 5, 79, 6, 132, 119, 92, 119, 118, 13, 180, 43, 104, 97, 137, 152, 139, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4296), new byte[] { 177, 180, 52, 230, 103, 3, 72, 146, 195, 111, 252, 144, 106, 109, 4, 95, 10, 30, 81, 225, 226, 24, 181, 13, 101, 109, 107, 22, 158, 210, 94, 27, 242, 198, 237, 244, 52, 140, 74, 32, 38, 5, 41, 244, 228, 3, 186, 84, 52, 144, 125, 249, 199, 81, 198, 110, 90, 146, 170, 60, 191, 146, 95, 223 }, new byte[] { 41, 164, 203, 231, 25, 40, 118, 45, 189, 178, 0, 177, 110, 86, 96, 7, 47, 175, 206, 152, 232, 47, 80, 190, 4, 153, 21, 178, 208, 138, 36, 171, 233, 167, 127, 144, 168, 95, 229, 243, 142, 225, 83, 106, 247, 194, 182, 34, 121, 215, 117, 70, 246, 200, 81, 186, 58, 240, 97, 215, 161, 222, 212, 47, 244, 198, 180, 25, 36, 110, 85, 137, 133, 76, 89, 85, 18, 63, 61, 208, 5, 51, 91, 40, 94, 50, 209, 137, 70, 109, 51, 228, 58, 222, 167, 152, 57, 109, 111, 227, 89, 118, 220, 61, 108, 126, 46, 179, 72, 66, 41, 74, 190, 237, 161, 4, 138, 131, 120, 4, 96, 63, 198, 228, 187, 93, 117, 122 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2241), new byte[] { 174, 211, 158, 143, 212, 43, 43, 148, 231, 94, 24, 17, 242, 145, 134, 76, 10, 155, 25, 249, 82, 135, 247, 70, 188, 251, 241, 254, 17, 180, 5, 97, 147, 11, 57, 155, 251, 17, 70, 33, 49, 26, 196, 8, 134, 132, 224, 2, 249, 140, 104, 255, 175, 64, 8, 240, 58, 172, 17, 45, 243, 178, 183, 161 }, new byte[] { 98, 33, 223, 66, 140, 105, 44, 148, 108, 159, 195, 215, 114, 63, 67, 139, 237, 116, 135, 129, 114, 78, 226, 10, 88, 158, 239, 181, 140, 92, 86, 212, 157, 87, 96, 183, 72, 73, 110, 187, 239, 119, 47, 241, 110, 31, 80, 111, 28, 127, 252, 213, 121, 250, 115, 110, 41, 135, 137, 159, 40, 191, 100, 99, 215, 159, 211, 24, 197, 102, 238, 248, 60, 223, 120, 119, 135, 20, 191, 158, 145, 31, 149, 103, 55, 183, 45, 173, 156, 56, 99, 247, 70, 98, 64, 88, 13, 243, 55, 161, 141, 135, 181, 185, 183, 24, 227, 10, 182, 57, 229, 227, 1, 98, 78, 143, 106, 192, 121, 141, 132, 218, 46, 68, 155, 216, 59, 21 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2249), new byte[] { 34, 47, 7, 139, 73, 119, 115, 141, 166, 144, 172, 26, 201, 15, 39, 177, 216, 62, 177, 133, 99, 79, 9, 14, 126, 126, 96, 158, 166, 91, 179, 85, 134, 187, 149, 71, 103, 65, 11, 174, 32, 67, 14, 171, 160, 34, 17, 245, 90, 57, 124, 205, 219, 218, 31, 16, 60, 180, 113, 99, 66, 42, 148, 20 }, new byte[] { 11, 11, 125, 152, 53, 73, 132, 221, 101, 99, 235, 248, 212, 37, 25, 230, 231, 16, 108, 190, 103, 132, 245, 150, 235, 6, 193, 76, 18, 222, 146, 75, 19, 62, 29, 3, 156, 188, 4, 205, 164, 183, 114, 142, 224, 109, 0, 224, 34, 31, 252, 181, 213, 181, 198, 116, 251, 141, 252, 248, 169, 85, 12, 99, 109, 198, 202, 90, 97, 41, 82, 232, 203, 40, 176, 153, 167, 61, 253, 88, 239, 188, 156, 182, 168, 176, 240, 110, 247, 150, 56, 134, 37, 121, 192, 6, 48, 165, 199, 108, 87, 70, 52, 66, 165, 1, 149, 103, 110, 192, 208, 28, 134, 178, 180, 195, 159, 66, 38, 34, 90, 220, 19, 184, 231, 234, 58, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2251), new byte[] { 138, 103, 56, 209, 128, 8, 38, 203, 127, 224, 18, 115, 81, 13, 62, 184, 244, 66, 7, 117, 29, 184, 141, 101, 205, 89, 187, 0, 48, 125, 247, 93, 16, 88, 121, 217, 176, 211, 132, 129, 13, 27, 161, 104, 206, 249, 160, 114, 232, 45, 9, 4, 158, 231, 140, 71, 202, 158, 178, 172, 225, 243, 217, 113 }, new byte[] { 177, 69, 27, 43, 182, 83, 157, 216, 119, 64, 43, 118, 4, 46, 160, 222, 4, 95, 122, 21, 149, 200, 4, 94, 201, 132, 80, 61, 156, 147, 246, 27, 213, 247, 27, 230, 83, 118, 160, 163, 141, 217, 34, 209, 243, 145, 60, 25, 47, 4, 70, 188, 163, 195, 208, 219, 172, 43, 132, 25, 98, 134, 134, 18, 155, 246, 182, 172, 250, 170, 82, 252, 126, 127, 27, 245, 238, 135, 14, 248, 91, 169, 89, 87, 148, 198, 57, 202, 195, 222, 96, 82, 76, 241, 133, 249, 158, 151, 59, 200, 163, 98, 229, 60, 45, 34, 5, 30, 236, 145, 199, 146, 33, 32, 210, 133, 162, 116, 98, 103, 20, 161, 151, 160, 39, 41, 201, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2253), new byte[] { 33, 114, 54, 24, 187, 100, 159, 66, 13, 65, 58, 52, 213, 120, 252, 96, 106, 247, 132, 142, 137, 185, 189, 39, 153, 238, 64, 126, 239, 116, 51, 159, 230, 47, 151, 197, 219, 74, 223, 39, 30, 51, 90, 59, 53, 223, 0, 255, 250, 174, 120, 72, 128, 16, 132, 246, 61, 205, 147, 225, 144, 167, 60, 223 }, new byte[] { 72, 105, 6, 149, 253, 158, 198, 219, 186, 102, 113, 197, 178, 109, 240, 227, 151, 91, 139, 16, 99, 134, 232, 211, 141, 99, 7, 170, 45, 26, 22, 119, 46, 82, 126, 206, 27, 143, 195, 145, 9, 33, 40, 135, 51, 110, 10, 169, 216, 143, 222, 15, 83, 224, 171, 191, 72, 5, 108, 20, 151, 27, 190, 33, 224, 108, 109, 53, 215, 143, 176, 203, 51, 56, 43, 27, 58, 23, 50, 82, 36, 210, 237, 100, 225, 232, 59, 58, 107, 100, 54, 46, 135, 127, 51, 193, 129, 198, 13, 180, 73, 130, 242, 136, 250, 244, 65, 180, 132, 239, 28, 38, 190, 108, 8, 62, 55, 227, 216, 26, 160, 30, 26, 151, 215, 28, 199, 127 } });
        }
    }
}
