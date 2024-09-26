using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitJobSkillSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4113), new byte[] { 72, 255, 17, 116, 26, 108, 202, 42, 171, 100, 153, 71, 184, 136, 245, 9, 109, 252, 168, 120, 176, 87, 223, 53, 172, 88, 73, 146, 208, 144, 128, 214, 185, 211, 229, 82, 209, 119, 245, 203, 171, 240, 149, 140, 250, 239, 115, 201, 35, 68, 114, 54, 98, 194, 201, 48, 181, 250, 14, 81, 100, 133, 227, 58 }, new byte[] { 209, 72, 111, 223, 217, 107, 72, 229, 176, 3, 159, 66, 157, 60, 174, 161, 143, 163, 89, 78, 52, 148, 198, 100, 199, 187, 139, 105, 60, 130, 194, 7, 70, 247, 185, 147, 2, 37, 51, 92, 188, 148, 168, 226, 167, 55, 194, 172, 7, 89, 12, 81, 34, 249, 6, 163, 70, 149, 110, 153, 124, 148, 244, 60, 52, 53, 179, 11, 155, 209, 227, 21, 110, 20, 166, 20, 134, 141, 149, 226, 35, 54, 236, 80, 106, 161, 135, 174, 158, 16, 110, 19, 22, 99, 202, 96, 89, 1, 89, 77, 38, 214, 241, 230, 116, 125, 192, 251, 209, 166, 154, 199, 86, 67, 55, 54, 141, 93, 72, 247, 198, 133, 14, 0, 145, 111, 70, 197 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4164), new byte[] { 129, 126, 192, 21, 175, 98, 10, 204, 203, 200, 101, 249, 112, 15, 21, 118, 140, 28, 96, 188, 0, 55, 21, 146, 176, 215, 226, 101, 173, 94, 28, 158, 238, 220, 217, 183, 32, 52, 167, 28, 203, 165, 47, 139, 22, 71, 219, 36, 23, 38, 158, 198, 122, 178, 22, 184, 70, 212, 181, 87, 127, 15, 94, 158 }, new byte[] { 86, 51, 88, 71, 53, 170, 31, 7, 104, 165, 217, 117, 172, 38, 188, 110, 32, 190, 231, 133, 180, 198, 0, 33, 27, 107, 67, 251, 200, 68, 62, 113, 225, 195, 141, 232, 35, 170, 26, 134, 77, 161, 169, 47, 243, 71, 35, 68, 221, 240, 134, 142, 225, 93, 83, 252, 16, 112, 3, 163, 9, 28, 140, 93, 254, 245, 103, 203, 27, 76, 83, 65, 242, 197, 213, 110, 133, 111, 107, 192, 137, 138, 52, 33, 46, 12, 55, 212, 27, 117, 149, 154, 227, 64, 241, 75, 180, 63, 238, 91, 252, 39, 237, 202, 35, 37, 193, 181, 194, 249, 198, 222, 212, 218, 78, 110, 27, 7, 67, 0, 3, 230, 4, 202, 26, 222, 162, 96 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4166), new byte[] { 247, 114, 44, 162, 150, 47, 44, 192, 252, 128, 119, 131, 67, 237, 87, 45, 98, 195, 156, 166, 28, 159, 42, 248, 23, 119, 98, 65, 85, 145, 166, 167, 42, 162, 177, 139, 124, 3, 193, 111, 80, 19, 124, 149, 84, 250, 230, 220, 205, 227, 123, 7, 182, 183, 3, 136, 105, 198, 100, 89, 51, 191, 201, 64 }, new byte[] { 63, 138, 121, 131, 18, 90, 178, 206, 110, 46, 161, 145, 223, 88, 137, 0, 23, 115, 221, 160, 157, 164, 38, 60, 142, 218, 153, 35, 140, 213, 49, 200, 215, 76, 91, 136, 56, 65, 0, 80, 92, 196, 94, 230, 189, 3, 200, 18, 187, 208, 26, 211, 144, 213, 105, 22, 127, 218, 45, 206, 122, 90, 146, 146, 103, 115, 114, 46, 43, 239, 221, 30, 32, 17, 215, 4, 228, 40, 242, 24, 113, 233, 71, 155, 156, 103, 191, 45, 46, 91, 193, 177, 56, 53, 26, 44, 203, 54, 226, 97, 123, 239, 26, 254, 18, 6, 179, 53, 31, 236, 157, 30, 33, 243, 127, 226, 199, 249, 111, 84, 96, 148, 246, 144, 46, 174, 159, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4167), new byte[] { 253, 43, 96, 206, 50, 75, 122, 150, 21, 205, 159, 12, 49, 145, 174, 79, 98, 103, 165, 182, 140, 203, 47, 59, 67, 67, 104, 35, 236, 111, 20, 176, 64, 166, 126, 192, 151, 169, 40, 43, 196, 166, 27, 190, 31, 89, 201, 247, 96, 74, 61, 216, 201, 96, 17, 145, 84, 177, 182, 153, 144, 243, 7, 209 }, new byte[] { 119, 90, 184, 84, 52, 84, 80, 96, 7, 210, 97, 197, 96, 4, 217, 160, 134, 245, 154, 5, 255, 122, 114, 171, 102, 136, 155, 145, 137, 49, 209, 177, 100, 205, 207, 236, 54, 80, 41, 179, 73, 165, 51, 85, 173, 149, 94, 159, 152, 54, 117, 243, 102, 178, 78, 86, 66, 53, 233, 219, 234, 254, 134, 55, 247, 22, 83, 129, 4, 200, 87, 30, 151, 89, 71, 221, 70, 122, 106, 71, 26, 146, 224, 162, 209, 62, 74, 193, 120, 164, 15, 206, 196, 215, 200, 174, 190, 96, 67, 225, 9, 122, 143, 158, 201, 30, 192, 63, 94, 204, 196, 116, 250, 71, 125, 223, 144, 223, 85, 79, 245, 13, 90, 175, 140, 202, 85, 248 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9601), new byte[] { 172, 178, 9, 204, 138, 27, 105, 211, 178, 87, 54, 3, 34, 203, 168, 120, 183, 38, 0, 105, 244, 108, 40, 229, 66, 96, 178, 118, 18, 239, 143, 227, 150, 254, 202, 137, 79, 113, 48, 75, 177, 206, 25, 35, 43, 31, 144, 4, 246, 17, 177, 111, 146, 18, 5, 31, 156, 106, 165, 214, 197, 120, 160, 152 }, new byte[] { 159, 63, 197, 227, 54, 68, 219, 235, 0, 79, 202, 61, 210, 82, 38, 153, 161, 173, 126, 166, 254, 159, 141, 189, 247, 75, 85, 184, 85, 204, 63, 137, 230, 131, 229, 162, 124, 137, 134, 77, 93, 28, 176, 15, 44, 174, 232, 210, 64, 145, 197, 111, 200, 146, 38, 197, 34, 164, 183, 108, 205, 253, 99, 184, 48, 93, 175, 154, 35, 29, 133, 216, 98, 214, 57, 132, 2, 5, 144, 252, 123, 2, 39, 18, 114, 164, 126, 91, 240, 52, 200, 225, 177, 46, 75, 90, 138, 168, 64, 199, 113, 150, 141, 201, 186, 0, 144, 167, 16, 89, 223, 86, 234, 60, 166, 137, 7, 69, 251, 32, 175, 35, 116, 61, 78, 144, 151, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9610), new byte[] { 30, 44, 19, 159, 203, 216, 80, 60, 209, 229, 134, 132, 85, 44, 112, 153, 231, 147, 20, 149, 24, 221, 119, 110, 54, 165, 224, 112, 171, 211, 21, 106, 159, 34, 7, 230, 152, 181, 213, 166, 1, 222, 127, 21, 14, 129, 197, 251, 115, 74, 106, 24, 254, 39, 214, 184, 182, 117, 66, 213, 32, 196, 218, 58 }, new byte[] { 65, 102, 164, 246, 115, 162, 62, 225, 78, 246, 34, 47, 18, 119, 169, 62, 213, 121, 131, 205, 48, 121, 193, 151, 119, 80, 41, 176, 227, 131, 68, 202, 78, 27, 71, 218, 102, 189, 139, 46, 154, 59, 217, 238, 185, 128, 225, 136, 172, 189, 6, 237, 226, 3, 135, 134, 70, 109, 112, 119, 205, 146, 24, 102, 171, 225, 69, 220, 252, 215, 174, 198, 16, 79, 127, 6, 88, 66, 50, 123, 171, 224, 36, 246, 31, 229, 168, 109, 137, 0, 71, 5, 130, 6, 208, 182, 31, 50, 41, 186, 65, 94, 155, 38, 159, 217, 103, 175, 18, 26, 209, 69, 223, 64, 226, 241, 152, 81, 161, 155, 148, 64, 82, 18, 164, 244, 94, 173 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9612), new byte[] { 146, 171, 133, 229, 155, 168, 26, 241, 180, 12, 144, 150, 33, 207, 125, 214, 205, 43, 174, 191, 86, 1, 54, 18, 197, 205, 59, 40, 157, 124, 221, 1, 183, 116, 125, 144, 244, 59, 31, 136, 224, 69, 217, 165, 153, 179, 87, 101, 232, 120, 212, 91, 2, 190, 120, 231, 247, 163, 24, 249, 127, 70, 156, 232 }, new byte[] { 129, 152, 66, 237, 198, 72, 94, 101, 25, 5, 121, 28, 253, 66, 183, 171, 220, 255, 198, 112, 164, 234, 14, 197, 45, 59, 72, 241, 70, 28, 102, 162, 100, 233, 98, 141, 111, 229, 246, 64, 242, 24, 162, 176, 58, 182, 112, 167, 188, 144, 158, 0, 140, 205, 110, 105, 67, 192, 225, 122, 243, 88, 139, 105, 198, 136, 226, 214, 92, 58, 123, 31, 125, 158, 150, 57, 94, 82, 22, 194, 211, 5, 250, 161, 242, 78, 158, 30, 250, 55, 1, 202, 22, 34, 86, 52, 33, 194, 233, 149, 244, 12, 35, 214, 197, 236, 226, 121, 186, 75, 72, 255, 113, 18, 133, 237, 240, 158, 44, 48, 68, 215, 196, 147, 81, 240, 40, 194 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9614), new byte[] { 247, 66, 76, 204, 245, 248, 73, 225, 228, 236, 104, 17, 15, 237, 208, 47, 241, 201, 44, 131, 56, 185, 91, 85, 39, 166, 150, 163, 162, 74, 47, 31, 33, 250, 196, 1, 86, 135, 138, 30, 232, 190, 173, 119, 198, 121, 38, 114, 182, 77, 223, 97, 213, 5, 100, 230, 98, 228, 122, 182, 14, 93, 102, 79 }, new byte[] { 51, 128, 221, 82, 224, 50, 199, 150, 104, 36, 196, 245, 115, 194, 71, 91, 205, 15, 250, 203, 194, 172, 153, 205, 207, 116, 221, 4, 49, 164, 212, 31, 86, 251, 144, 246, 128, 69, 50, 99, 163, 37, 6, 228, 226, 191, 230, 189, 40, 159, 55, 175, 86, 107, 168, 116, 186, 74, 175, 251, 172, 151, 158, 124, 190, 55, 59, 117, 104, 161, 84, 132, 98, 225, 214, 137, 47, 121, 222, 66, 170, 108, 165, 189, 90, 92, 207, 254, 136, 83, 152, 217, 90, 171, 155, 52, 36, 143, 32, 75, 242, 141, 188, 212, 194, 160, 85, 22, 236, 218, 24, 248, 123, 13, 58, 213, 12, 218, 20, 216, 120, 1, 104, 30, 20, 77, 220, 173 } });
        }
    }
}
