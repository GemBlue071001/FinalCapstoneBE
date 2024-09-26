using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeCol2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "JobPostActivitys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(2360), new byte[] { 140, 182, 101, 99, 198, 65, 2, 103, 12, 11, 54, 189, 143, 33, 151, 216, 22, 244, 213, 24, 27, 160, 27, 31, 7, 198, 73, 208, 139, 145, 63, 80, 29, 150, 180, 151, 89, 127, 95, 35, 115, 58, 110, 156, 47, 192, 115, 78, 151, 14, 177, 155, 4, 248, 50, 168, 49, 193, 27, 178, 16, 38, 156, 227 }, new byte[] { 71, 74, 130, 156, 17, 174, 49, 98, 10, 149, 189, 238, 42, 43, 7, 138, 24, 135, 105, 119, 18, 112, 233, 1, 244, 242, 63, 181, 255, 204, 167, 198, 221, 9, 66, 142, 190, 78, 22, 127, 134, 131, 170, 140, 45, 186, 80, 154, 66, 145, 9, 211, 64, 125, 209, 4, 98, 78, 37, 247, 15, 34, 185, 149, 140, 233, 240, 107, 11, 122, 109, 50, 170, 194, 117, 58, 240, 143, 98, 21, 106, 133, 128, 178, 36, 248, 90, 159, 241, 164, 240, 177, 166, 183, 125, 217, 77, 65, 127, 119, 24, 88, 94, 244, 45, 53, 100, 129, 219, 105, 250, 111, 96, 101, 143, 176, 231, 104, 194, 4, 246, 227, 243, 50, 196, 162, 121, 71 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(2366), new byte[] { 106, 151, 140, 29, 146, 100, 1, 194, 241, 239, 230, 218, 75, 42, 114, 79, 121, 37, 18, 76, 214, 231, 42, 36, 253, 78, 173, 149, 119, 34, 158, 70, 153, 68, 213, 166, 106, 127, 148, 58, 254, 224, 204, 182, 92, 213, 8, 60, 38, 74, 74, 202, 57, 165, 242, 78, 145, 24, 181, 214, 144, 171, 230, 214 }, new byte[] { 145, 83, 123, 88, 253, 153, 132, 34, 153, 104, 1, 185, 192, 213, 77, 53, 101, 171, 148, 89, 197, 132, 45, 236, 111, 197, 232, 148, 234, 6, 145, 187, 88, 106, 57, 27, 170, 106, 81, 203, 223, 119, 152, 9, 63, 210, 13, 238, 219, 173, 139, 243, 146, 171, 136, 70, 254, 53, 84, 9, 0, 214, 84, 229, 60, 189, 75, 245, 127, 173, 148, 63, 27, 36, 245, 66, 76, 112, 110, 118, 210, 205, 186, 178, 94, 79, 17, 239, 135, 244, 165, 213, 216, 179, 191, 77, 175, 201, 43, 214, 199, 205, 27, 81, 22, 169, 72, 70, 113, 184, 177, 100, 97, 35, 175, 51, 69, 28, 14, 216, 214, 15, 231, 232, 71, 7, 12, 105 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(2368), new byte[] { 180, 145, 69, 97, 120, 225, 69, 4, 248, 146, 162, 221, 231, 225, 214, 98, 5, 240, 229, 172, 47, 200, 165, 13, 94, 26, 134, 177, 185, 237, 53, 142, 18, 167, 147, 207, 198, 149, 64, 247, 11, 228, 1, 96, 37, 2, 151, 187, 130, 155, 57, 229, 46, 192, 215, 3, 49, 59, 210, 101, 119, 198, 106, 179 }, new byte[] { 201, 123, 175, 238, 101, 51, 69, 168, 68, 116, 67, 182, 183, 167, 6, 124, 47, 100, 82, 82, 186, 16, 54, 29, 4, 213, 133, 184, 95, 56, 248, 251, 44, 143, 202, 103, 179, 120, 121, 70, 105, 168, 181, 254, 215, 112, 49, 42, 225, 168, 7, 143, 129, 85, 226, 11, 46, 211, 62, 2, 44, 26, 99, 5, 170, 16, 47, 4, 52, 191, 152, 167, 108, 165, 243, 34, 56, 240, 109, 198, 105, 71, 106, 131, 201, 239, 246, 3, 199, 69, 118, 79, 252, 43, 43, 108, 156, 9, 25, 102, 209, 73, 246, 151, 0, 23, 185, 91, 223, 113, 2, 87, 13, 165, 13, 124, 183, 96, 96, 166, 104, 184, 43, 89, 164, 95, 212, 237 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 43, 58, 271, DateTimeKind.Utc).AddTicks(2370), new byte[] { 207, 4, 3, 137, 1, 127, 74, 197, 106, 118, 44, 37, 65, 160, 46, 173, 188, 220, 209, 169, 69, 155, 233, 176, 44, 14, 128, 27, 53, 56, 45, 80, 6, 1, 238, 166, 224, 210, 97, 121, 83, 175, 118, 245, 40, 120, 122, 133, 211, 144, 5, 198, 15, 122, 245, 175, 132, 253, 48, 212, 171, 121, 44, 10 }, new byte[] { 84, 205, 151, 198, 11, 2, 88, 245, 233, 118, 40, 1, 243, 99, 217, 188, 148, 119, 211, 166, 17, 242, 68, 158, 65, 200, 222, 87, 128, 106, 69, 120, 9, 203, 207, 80, 92, 121, 122, 169, 149, 229, 254, 13, 113, 17, 101, 133, 180, 94, 120, 179, 137, 25, 71, 15, 180, 156, 188, 242, 146, 67, 94, 185, 192, 254, 107, 45, 134, 34, 134, 3, 182, 111, 63, 37, 87, 153, 39, 130, 71, 124, 18, 181, 96, 105, 74, 194, 87, 95, 173, 201, 164, 58, 18, 69, 187, 63, 25, 101, 67, 196, 198, 61, 232, 10, 173, 45, 73, 138, 223, 166, 76, 217, 166, 0, 85, 196, 205, 138, 94, 223, 213, 117, 232, 114, 83, 155 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "JobPostActivitys",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4661), new byte[] { 197, 133, 141, 225, 116, 63, 17, 93, 204, 26, 62, 21, 149, 196, 126, 68, 72, 159, 167, 168, 116, 10, 228, 243, 206, 4, 92, 46, 50, 103, 212, 40, 230, 137, 166, 109, 167, 172, 182, 195, 225, 248, 68, 35, 161, 22, 106, 133, 36, 14, 140, 107, 36, 126, 144, 122, 127, 44, 243, 231, 103, 194, 163, 199 }, new byte[] { 125, 252, 120, 169, 212, 102, 58, 223, 233, 111, 119, 14, 150, 21, 62, 62, 193, 101, 217, 161, 107, 130, 200, 211, 127, 171, 74, 70, 170, 201, 53, 90, 136, 59, 22, 216, 80, 91, 91, 251, 201, 125, 12, 60, 60, 150, 139, 0, 81, 161, 142, 243, 128, 102, 151, 19, 118, 130, 99, 126, 65, 126, 44, 85, 85, 129, 35, 249, 233, 254, 70, 173, 46, 197, 195, 11, 226, 233, 113, 107, 53, 61, 59, 131, 186, 230, 118, 145, 65, 18, 34, 142, 248, 245, 111, 3, 190, 253, 123, 0, 9, 45, 146, 3, 226, 66, 254, 125, 122, 34, 249, 25, 8, 123, 159, 67, 232, 25, 50, 223, 169, 127, 185, 59, 37, 242, 133, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4670), new byte[] { 35, 165, 35, 175, 36, 134, 13, 3, 94, 65, 43, 141, 210, 84, 66, 183, 107, 55, 16, 113, 37, 10, 9, 203, 25, 56, 211, 131, 108, 36, 37, 134, 114, 123, 133, 223, 173, 255, 220, 64, 207, 22, 218, 86, 255, 94, 187, 20, 165, 174, 46, 46, 166, 122, 80, 210, 188, 232, 205, 251, 233, 143, 171, 19 }, new byte[] { 39, 179, 189, 131, 29, 168, 123, 228, 203, 99, 89, 251, 186, 49, 135, 214, 59, 102, 64, 17, 152, 98, 255, 55, 49, 132, 236, 242, 1, 76, 68, 180, 36, 34, 96, 123, 188, 227, 22, 172, 9, 10, 87, 22, 148, 98, 129, 45, 246, 252, 179, 217, 41, 215, 69, 227, 80, 87, 117, 178, 123, 215, 252, 119, 180, 18, 224, 33, 200, 145, 219, 8, 58, 191, 227, 162, 54, 10, 47, 36, 133, 73, 126, 113, 247, 171, 132, 187, 122, 14, 215, 205, 64, 211, 179, 57, 157, 228, 241, 56, 52, 67, 43, 44, 82, 28, 13, 19, 27, 94, 171, 103, 239, 89, 238, 247, 170, 125, 170, 245, 241, 141, 62, 41, 154, 133, 218, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4673), new byte[] { 83, 163, 239, 104, 121, 220, 89, 124, 5, 77, 203, 19, 170, 180, 207, 9, 103, 72, 177, 33, 8, 38, 54, 94, 230, 177, 122, 71, 241, 113, 50, 82, 4, 82, 129, 10, 80, 67, 109, 104, 78, 231, 149, 86, 168, 0, 157, 162, 141, 224, 37, 95, 227, 68, 75, 74, 156, 246, 38, 61, 28, 164, 203, 208 }, new byte[] { 98, 17, 115, 120, 183, 129, 77, 179, 50, 140, 103, 247, 181, 222, 239, 159, 160, 236, 191, 85, 155, 188, 60, 116, 167, 181, 184, 172, 6, 43, 16, 46, 21, 45, 142, 128, 148, 117, 199, 12, 116, 96, 113, 167, 8, 65, 193, 29, 51, 101, 177, 101, 134, 124, 126, 102, 32, 189, 207, 13, 147, 9, 53, 207, 168, 107, 252, 98, 215, 233, 30, 16, 77, 112, 99, 76, 237, 111, 101, 26, 158, 83, 169, 235, 55, 144, 87, 14, 47, 70, 76, 219, 198, 165, 238, 0, 61, 42, 230, 53, 189, 56, 238, 185, 17, 24, 95, 178, 160, 161, 41, 234, 26, 6, 60, 253, 220, 167, 21, 81, 117, 205, 241, 151, 165, 248, 157, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4675), new byte[] { 99, 224, 22, 143, 122, 162, 196, 65, 93, 23, 223, 223, 186, 118, 216, 20, 8, 44, 58, 109, 232, 161, 100, 82, 146, 193, 198, 169, 132, 208, 99, 57, 175, 55, 184, 153, 96, 8, 10, 6, 44, 121, 216, 126, 95, 243, 227, 238, 187, 246, 202, 221, 180, 104, 46, 40, 101, 16, 199, 17, 23, 6, 127, 153 }, new byte[] { 10, 167, 83, 80, 11, 78, 67, 229, 145, 85, 72, 83, 247, 211, 154, 160, 182, 196, 199, 10, 58, 242, 23, 29, 149, 236, 131, 69, 187, 177, 242, 99, 19, 71, 242, 73, 5, 250, 203, 78, 253, 250, 3, 174, 38, 111, 14, 27, 113, 228, 19, 160, 255, 143, 192, 238, 201, 163, 242, 0, 76, 121, 62, 149, 121, 190, 189, 220, 106, 221, 42, 94, 113, 115, 183, 124, 67, 146, 3, 32, 76, 200, 154, 187, 50, 207, 141, 224, 6, 90, 49, 138, 113, 128, 171, 224, 162, 218, 154, 199, 59, 28, 30, 44, 171, 187, 20, 43, 198, 182, 189, 223, 55, 228, 35, 131, 107, 32, 164, 176, 110, 152, 74, 108, 227, 12, 158, 159 } });
        }
    }
}
