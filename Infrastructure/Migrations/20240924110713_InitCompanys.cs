using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitCompanys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3368), new byte[] { 103, 152, 158, 164, 56, 132, 230, 27, 120, 126, 173, 147, 230, 179, 219, 17, 171, 52, 175, 180, 156, 113, 87, 121, 64, 72, 152, 217, 18, 81, 5, 228, 94, 6, 116, 79, 127, 29, 73, 27, 60, 39, 233, 138, 134, 65, 9, 241, 16, 140, 195, 0, 140, 248, 170, 46, 126, 11, 55, 150, 213, 74, 218, 45 }, new byte[] { 220, 69, 170, 102, 28, 151, 219, 11, 90, 57, 62, 249, 51, 145, 134, 76, 245, 182, 42, 190, 43, 171, 244, 233, 11, 114, 212, 156, 19, 34, 224, 195, 217, 96, 26, 118, 74, 229, 0, 145, 27, 46, 200, 213, 208, 74, 117, 23, 20, 82, 56, 152, 66, 12, 234, 232, 17, 141, 14, 170, 13, 4, 61, 240, 152, 17, 147, 65, 147, 91, 113, 37, 223, 53, 32, 26, 56, 122, 92, 113, 132, 49, 113, 195, 160, 171, 186, 49, 93, 50, 9, 62, 118, 232, 210, 16, 233, 195, 235, 157, 194, 111, 89, 33, 42, 191, 112, 216, 220, 92, 73, 151, 81, 145, 80, 206, 153, 32, 124, 32, 35, 103, 165, 82, 171, 200, 98, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3380), new byte[] { 37, 113, 158, 61, 156, 231, 81, 23, 200, 87, 57, 97, 108, 19, 215, 187, 61, 124, 63, 74, 106, 96, 174, 129, 44, 52, 246, 16, 30, 72, 174, 194, 143, 18, 66, 123, 139, 133, 135, 32, 154, 232, 128, 82, 113, 165, 20, 55, 233, 45, 9, 184, 106, 239, 185, 75, 128, 225, 223, 54, 11, 191, 81, 97 }, new byte[] { 21, 72, 219, 61, 255, 211, 36, 82, 58, 110, 77, 153, 121, 158, 28, 232, 150, 176, 157, 27, 162, 124, 253, 196, 30, 183, 14, 6, 106, 234, 243, 49, 193, 29, 201, 130, 226, 157, 231, 207, 24, 248, 193, 11, 185, 29, 220, 121, 41, 30, 75, 145, 3, 195, 0, 25, 148, 154, 142, 48, 138, 16, 185, 87, 178, 9, 130, 164, 101, 187, 15, 90, 206, 26, 65, 67, 191, 53, 153, 31, 172, 0, 85, 208, 12, 199, 171, 216, 180, 160, 228, 138, 102, 174, 2, 198, 84, 88, 199, 116, 142, 220, 49, 24, 192, 216, 141, 152, 233, 45, 47, 143, 18, 40, 224, 130, 221, 121, 40, 228, 101, 6, 163, 156, 48, 40, 1, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3381), new byte[] { 243, 31, 187, 205, 4, 245, 174, 21, 6, 12, 52, 183, 112, 9, 49, 200, 242, 184, 191, 158, 96, 86, 4, 87, 223, 153, 109, 125, 45, 110, 197, 156, 24, 46, 137, 107, 188, 103, 27, 146, 211, 15, 228, 16, 19, 14, 243, 23, 171, 102, 195, 21, 247, 172, 153, 55, 211, 81, 89, 168, 48, 67, 221, 58 }, new byte[] { 182, 254, 162, 118, 35, 142, 198, 79, 123, 210, 2, 40, 185, 142, 234, 37, 140, 219, 55, 236, 115, 230, 215, 24, 112, 175, 173, 62, 224, 210, 0, 51, 228, 119, 67, 228, 138, 64, 0, 242, 226, 247, 211, 50, 225, 222, 227, 16, 224, 246, 126, 29, 205, 93, 31, 61, 27, 112, 128, 209, 56, 56, 26, 167, 110, 73, 135, 81, 119, 128, 38, 90, 127, 36, 82, 217, 137, 91, 195, 147, 101, 198, 62, 174, 60, 102, 166, 112, 250, 93, 83, 143, 249, 220, 159, 110, 117, 12, 133, 19, 210, 194, 43, 25, 248, 74, 54, 211, 249, 131, 8, 182, 202, 19, 92, 59, 41, 82, 125, 190, 201, 55, 184, 138, 92, 113, 228, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3383), new byte[] { 67, 220, 234, 192, 11, 194, 8, 167, 81, 188, 93, 31, 166, 246, 225, 153, 168, 245, 67, 1, 4, 23, 64, 14, 155, 152, 135, 179, 25, 96, 37, 110, 238, 53, 175, 160, 152, 225, 138, 79, 241, 25, 21, 108, 155, 129, 73, 99, 51, 251, 1, 124, 28, 88, 136, 125, 1, 230, 80, 238, 13, 57, 131, 241 }, new byte[] { 234, 35, 210, 18, 255, 133, 50, 253, 72, 163, 102, 137, 107, 59, 95, 105, 72, 244, 22, 206, 48, 119, 25, 139, 7, 154, 165, 35, 185, 183, 222, 44, 18, 2, 163, 19, 188, 135, 230, 191, 35, 118, 28, 171, 108, 128, 151, 29, 10, 169, 8, 169, 60, 124, 13, 95, 31, 124, 28, 79, 109, 215, 136, 248, 224, 252, 116, 163, 163, 112, 182, 105, 156, 233, 171, 18, 225, 153, 51, 168, 101, 200, 215, 161, 101, 10, 58, 48, 167, 7, 84, 250, 210, 158, 132, 160, 60, 213, 104, 241, 185, 122, 105, 210, 167, 41, 186, 192, 167, 201, 214, 119, 41, 180, 206, 236, 189, 197, 93, 85, 53, 20, 1, 173, 105, 246, 215, 166 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2158), new byte[] { 146, 15, 123, 240, 44, 151, 141, 228, 18, 115, 44, 245, 147, 59, 113, 72, 228, 132, 220, 29, 252, 26, 90, 131, 219, 0, 200, 179, 184, 254, 157, 133, 133, 120, 172, 184, 5, 184, 232, 235, 184, 130, 225, 226, 160, 26, 180, 241, 40, 23, 26, 5, 109, 51, 153, 89, 80, 35, 221, 91, 217, 37, 237, 104 }, new byte[] { 145, 13, 113, 156, 246, 128, 245, 47, 163, 127, 151, 88, 48, 208, 188, 211, 11, 70, 93, 239, 100, 38, 1, 200, 24, 23, 4, 49, 50, 18, 148, 112, 91, 10, 60, 95, 157, 18, 9, 71, 45, 34, 190, 169, 49, 5, 57, 26, 158, 43, 206, 139, 212, 168, 59, 87, 63, 208, 50, 235, 147, 18, 98, 180, 26, 141, 132, 91, 206, 221, 174, 169, 117, 134, 20, 129, 100, 122, 3, 67, 12, 171, 254, 221, 69, 151, 132, 145, 64, 29, 222, 201, 55, 165, 163, 35, 207, 150, 226, 202, 100, 44, 31, 250, 112, 226, 50, 203, 5, 99, 8, 76, 132, 150, 235, 211, 184, 131, 59, 210, 28, 36, 109, 225, 118, 21, 161, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2166), new byte[] { 18, 148, 131, 51, 243, 182, 203, 38, 18, 100, 20, 69, 184, 2, 26, 137, 190, 0, 5, 252, 72, 30, 65, 96, 221, 186, 221, 233, 152, 151, 247, 38, 181, 32, 221, 173, 190, 226, 193, 183, 108, 215, 79, 126, 152, 248, 187, 186, 255, 60, 86, 249, 155, 185, 166, 76, 138, 119, 131, 77, 255, 178, 2, 5 }, new byte[] { 191, 91, 157, 72, 103, 5, 86, 227, 223, 89, 223, 156, 101, 37, 242, 238, 122, 111, 58, 13, 143, 157, 110, 187, 27, 183, 22, 197, 220, 36, 194, 101, 19, 178, 110, 225, 98, 59, 69, 149, 188, 81, 208, 208, 124, 80, 209, 126, 241, 157, 32, 65, 162, 126, 168, 188, 191, 18, 57, 4, 146, 217, 37, 15, 34, 30, 185, 60, 253, 139, 215, 169, 21, 168, 252, 29, 222, 67, 9, 144, 83, 246, 224, 225, 79, 47, 37, 199, 255, 247, 231, 129, 206, 117, 216, 166, 170, 12, 83, 72, 169, 9, 10, 136, 26, 193, 116, 214, 149, 45, 177, 242, 51, 138, 42, 177, 12, 157, 198, 214, 223, 26, 79, 74, 115, 20, 198, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2168), new byte[] { 255, 212, 206, 187, 68, 178, 254, 73, 33, 101, 118, 208, 134, 21, 84, 77, 71, 154, 215, 227, 212, 164, 58, 179, 118, 12, 159, 159, 62, 31, 143, 10, 69, 18, 207, 134, 231, 76, 241, 41, 227, 253, 111, 167, 35, 223, 123, 62, 51, 25, 116, 193, 0, 103, 148, 196, 65, 22, 182, 75, 237, 50, 174, 78 }, new byte[] { 195, 221, 232, 185, 114, 148, 241, 60, 158, 90, 23, 112, 152, 31, 60, 37, 60, 3, 160, 22, 12, 89, 79, 248, 233, 180, 50, 107, 129, 93, 62, 215, 203, 133, 64, 30, 217, 161, 145, 223, 133, 227, 234, 38, 171, 107, 30, 249, 189, 19, 155, 33, 185, 142, 35, 192, 232, 117, 53, 249, 98, 53, 98, 11, 62, 112, 65, 92, 37, 89, 243, 195, 56, 46, 70, 150, 181, 173, 38, 6, 24, 64, 123, 229, 92, 22, 184, 245, 175, 104, 194, 13, 28, 84, 245, 94, 162, 211, 128, 24, 135, 168, 177, 67, 216, 14, 89, 214, 178, 238, 215, 56, 182, 183, 188, 85, 54, 44, 52, 184, 54, 74, 107, 223, 228, 32, 140, 58 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2169), new byte[] { 71, 132, 89, 175, 129, 88, 235, 34, 64, 188, 166, 126, 218, 82, 243, 157, 228, 93, 112, 104, 185, 6, 13, 248, 188, 134, 26, 243, 46, 252, 210, 16, 233, 225, 225, 24, 254, 146, 220, 34, 225, 86, 115, 21, 239, 98, 24, 111, 68, 229, 35, 116, 233, 95, 193, 45, 250, 204, 43, 134, 172, 70, 118, 134 }, new byte[] { 166, 149, 133, 167, 158, 170, 142, 163, 236, 240, 6, 250, 12, 97, 38, 54, 65, 186, 248, 239, 101, 91, 67, 134, 114, 249, 2, 103, 76, 248, 177, 118, 41, 41, 236, 106, 206, 132, 132, 253, 147, 168, 120, 206, 17, 242, 115, 221, 45, 171, 93, 23, 80, 147, 117, 55, 13, 90, 9, 2, 90, 8, 214, 54, 167, 147, 196, 112, 132, 39, 19, 94, 66, 119, 128, 19, 105, 184, 192, 67, 62, 77, 117, 159, 72, 228, 116, 85, 177, 239, 185, 212, 93, 159, 223, 47, 119, 195, 115, 64, 51, 198, 1, 123, 74, 218, 120, 91, 219, 205, 39, 99, 8, 114, 227, 174, 53, 44, 66, 95, 212, 241, 184, 117, 49, 187, 107, 10 } });
        }
    }
}
