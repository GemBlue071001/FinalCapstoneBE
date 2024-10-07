using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addImgToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Companys",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(953), null });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(959), null });

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8208), new byte[] { 252, 183, 229, 70, 148, 47, 212, 206, 92, 218, 147, 255, 73, 71, 192, 207, 224, 240, 189, 223, 152, 151, 139, 102, 184, 30, 83, 128, 213, 82, 51, 190, 143, 102, 30, 2, 27, 194, 242, 119, 160, 211, 24, 177, 11, 167, 98, 120, 237, 172, 95, 165, 118, 11, 243, 199, 53, 166, 25, 86, 107, 105, 169, 4 }, new byte[] { 9, 50, 98, 80, 30, 59, 142, 123, 32, 81, 160, 179, 193, 155, 177, 201, 5, 114, 48, 125, 11, 87, 218, 53, 188, 38, 133, 214, 0, 169, 126, 110, 178, 43, 25, 123, 4, 138, 156, 232, 90, 233, 84, 78, 247, 29, 232, 219, 175, 97, 250, 49, 240, 36, 57, 66, 67, 116, 101, 180, 109, 164, 105, 207, 147, 65, 200, 213, 92, 238, 247, 39, 185, 169, 38, 202, 14, 98, 172, 46, 31, 34, 47, 140, 116, 187, 245, 38, 26, 177, 140, 182, 105, 199, 151, 77, 34, 38, 99, 20, 144, 18, 187, 169, 9, 176, 159, 21, 158, 208, 243, 117, 200, 115, 41, 154, 247, 86, 17, 208, 139, 188, 207, 51, 127, 224, 88, 169 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8216), new byte[] { 87, 103, 214, 72, 252, 55, 31, 127, 161, 112, 166, 162, 131, 243, 201, 90, 155, 169, 135, 157, 207, 170, 209, 229, 152, 83, 111, 164, 149, 188, 208, 54, 163, 77, 235, 243, 15, 21, 157, 178, 103, 43, 70, 173, 252, 72, 37, 93, 49, 25, 127, 118, 206, 26, 239, 98, 18, 59, 7, 213, 96, 69, 100, 114 }, new byte[] { 148, 178, 112, 88, 149, 63, 245, 47, 191, 165, 114, 208, 196, 130, 149, 238, 209, 191, 194, 186, 14, 213, 131, 221, 243, 76, 140, 173, 2, 219, 16, 14, 211, 139, 155, 6, 109, 143, 49, 223, 190, 13, 202, 185, 159, 204, 0, 65, 198, 20, 57, 46, 1, 153, 151, 182, 127, 172, 35, 59, 133, 210, 201, 230, 100, 76, 50, 169, 157, 224, 250, 36, 120, 138, 43, 20, 151, 175, 202, 222, 48, 83, 106, 112, 57, 173, 106, 135, 20, 22, 72, 42, 174, 189, 79, 146, 141, 83, 135, 180, 58, 151, 187, 127, 33, 119, 14, 32, 234, 123, 132, 168, 77, 164, 208, 2, 95, 183, 15, 97, 227, 205, 3, 138, 143, 53, 84, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8218), new byte[] { 147, 145, 233, 227, 64, 88, 93, 15, 192, 246, 60, 23, 10, 199, 126, 255, 42, 76, 146, 157, 219, 71, 121, 2, 187, 171, 2, 184, 21, 185, 254, 141, 179, 185, 66, 103, 153, 30, 246, 219, 0, 65, 190, 149, 207, 227, 31, 201, 224, 2, 223, 82, 197, 72, 174, 59, 183, 166, 191, 24, 241, 67, 149, 126 }, new byte[] { 22, 79, 10, 30, 243, 186, 229, 219, 138, 234, 183, 26, 48, 149, 182, 206, 192, 175, 252, 60, 21, 171, 9, 220, 142, 41, 195, 133, 113, 136, 208, 64, 166, 83, 53, 32, 10, 97, 149, 235, 81, 83, 228, 212, 102, 222, 217, 112, 126, 245, 24, 128, 154, 65, 41, 194, 69, 172, 185, 147, 201, 14, 88, 225, 229, 243, 29, 219, 130, 210, 132, 252, 157, 26, 252, 239, 68, 216, 38, 68, 107, 205, 149, 135, 70, 168, 202, 86, 144, 114, 147, 55, 78, 149, 130, 0, 111, 229, 89, 35, 197, 19, 122, 197, 109, 60, 32, 100, 57, 136, 67, 150, 187, 205, 219, 143, 21, 171, 190, 71, 158, 13, 19, 42, 193, 180, 50, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8220), new byte[] { 123, 151, 124, 75, 19, 208, 104, 155, 103, 188, 226, 173, 128, 2, 119, 241, 172, 92, 10, 135, 204, 162, 253, 180, 153, 241, 236, 64, 150, 136, 224, 140, 255, 157, 194, 18, 22, 228, 136, 173, 218, 188, 91, 33, 206, 210, 168, 246, 7, 134, 105, 79, 129, 27, 48, 26, 218, 85, 97, 21, 201, 190, 161, 59 }, new byte[] { 124, 204, 137, 94, 223, 253, 64, 116, 162, 49, 215, 252, 84, 6, 199, 246, 143, 221, 125, 39, 29, 149, 17, 115, 162, 121, 155, 176, 193, 173, 235, 162, 133, 178, 112, 110, 182, 21, 48, 157, 47, 43, 18, 156, 227, 53, 145, 195, 7, 30, 98, 91, 32, 160, 215, 38, 85, 58, 157, 56, 109, 90, 150, 48, 91, 132, 10, 148, 111, 3, 83, 115, 89, 86, 163, 41, 57, 36, 232, 13, 224, 96, 236, 106, 145, 105, 49, 72, 175, 131, 198, 58, 156, 157, 111, 95, 204, 200, 32, 80, 165, 22, 189, 94, 232, 233, 154, 179, 150, 35, 42, 232, 83, 24, 115, 20, 36, 147, 78, 38, 90, 58, 92, 127, 236, 223, 79, 137 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Companys");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8812), new byte[] { 90, 5, 12, 53, 35, 66, 252, 43, 197, 125, 68, 211, 93, 108, 117, 19, 97, 118, 169, 197, 170, 156, 239, 222, 168, 255, 20, 106, 89, 31, 10, 87, 101, 53, 232, 47, 130, 100, 131, 47, 40, 130, 115, 198, 93, 48, 120, 215, 26, 129, 94, 15, 232, 152, 186, 158, 31, 38, 2, 50, 12, 176, 196, 18 }, new byte[] { 58, 87, 181, 132, 31, 24, 117, 58, 241, 154, 127, 230, 235, 168, 193, 166, 90, 145, 68, 91, 228, 66, 122, 242, 105, 3, 241, 18, 165, 255, 127, 93, 153, 98, 14, 253, 124, 148, 23, 86, 138, 204, 141, 197, 29, 45, 185, 246, 84, 127, 117, 105, 167, 101, 29, 215, 182, 96, 217, 41, 238, 248, 94, 252, 52, 129, 221, 241, 159, 206, 179, 5, 180, 155, 71, 232, 128, 139, 197, 119, 127, 193, 85, 143, 58, 253, 39, 235, 108, 228, 88, 16, 136, 107, 164, 11, 32, 165, 16, 118, 232, 170, 248, 44, 145, 11, 238, 252, 201, 209, 92, 173, 125, 217, 107, 109, 72, 59, 120, 228, 168, 34, 98, 110, 153, 201, 5, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8819), new byte[] { 186, 20, 130, 83, 82, 178, 250, 64, 41, 172, 26, 7, 213, 47, 71, 96, 121, 2, 236, 13, 121, 58, 8, 42, 193, 199, 225, 195, 113, 226, 218, 216, 151, 195, 70, 16, 115, 216, 113, 152, 95, 62, 160, 34, 75, 77, 163, 130, 161, 3, 248, 237, 195, 151, 217, 236, 2, 41, 228, 46, 105, 4, 168, 32 }, new byte[] { 195, 199, 46, 57, 193, 161, 171, 166, 30, 126, 100, 164, 31, 245, 213, 161, 217, 87, 43, 175, 200, 63, 171, 114, 222, 26, 4, 23, 89, 114, 217, 82, 151, 91, 58, 73, 165, 33, 75, 67, 152, 158, 216, 44, 56, 106, 89, 161, 93, 114, 243, 18, 63, 26, 217, 68, 100, 229, 158, 254, 156, 54, 28, 205, 6, 223, 202, 134, 48, 7, 248, 168, 27, 215, 51, 15, 121, 124, 197, 27, 223, 96, 113, 196, 110, 246, 135, 131, 15, 45, 7, 44, 202, 44, 149, 11, 211, 80, 177, 75, 112, 2, 192, 100, 188, 128, 10, 179, 147, 204, 115, 28, 162, 243, 73, 118, 228, 200, 86, 24, 254, 37, 226, 104, 139, 119, 32, 189 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8842), new byte[] { 118, 239, 10, 150, 102, 222, 147, 25, 255, 175, 82, 82, 56, 255, 145, 168, 242, 33, 130, 126, 170, 111, 223, 14, 111, 13, 136, 9, 169, 172, 47, 173, 250, 140, 6, 191, 122, 162, 182, 93, 66, 211, 154, 45, 173, 158, 168, 234, 151, 84, 6, 111, 172, 215, 97, 122, 28, 150, 133, 244, 202, 203, 75, 132 }, new byte[] { 71, 187, 16, 242, 144, 196, 29, 15, 20, 80, 8, 116, 31, 199, 157, 254, 119, 98, 118, 18, 198, 226, 50, 16, 168, 255, 101, 206, 154, 155, 128, 30, 181, 30, 244, 86, 96, 59, 152, 185, 185, 249, 3, 23, 247, 161, 24, 114, 31, 41, 222, 155, 162, 64, 68, 211, 19, 251, 122, 213, 107, 162, 42, 252, 130, 13, 174, 48, 184, 124, 60, 229, 69, 81, 28, 186, 230, 196, 163, 237, 153, 243, 93, 210, 218, 49, 124, 36, 175, 167, 100, 200, 33, 122, 232, 11, 19, 182, 184, 218, 242, 73, 57, 125, 135, 234, 129, 165, 55, 152, 154, 173, 237, 158, 77, 73, 93, 37, 50, 93, 187, 219, 142, 84, 254, 185, 63, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8843), new byte[] { 125, 160, 124, 92, 64, 110, 142, 253, 197, 131, 59, 157, 81, 115, 163, 155, 102, 65, 101, 196, 129, 9, 165, 144, 203, 170, 213, 5, 215, 189, 155, 55, 208, 211, 18, 98, 238, 186, 13, 119, 241, 47, 159, 253, 15, 113, 204, 95, 70, 168, 107, 176, 30, 132, 103, 54, 204, 168, 106, 42, 115, 202, 238, 125 }, new byte[] { 229, 125, 99, 8, 14, 231, 195, 128, 133, 79, 202, 108, 133, 171, 191, 175, 181, 153, 130, 128, 52, 234, 175, 151, 45, 112, 14, 109, 173, 162, 68, 255, 122, 35, 217, 89, 0, 28, 41, 94, 132, 64, 212, 251, 193, 10, 45, 145, 210, 184, 138, 28, 74, 128, 53, 25, 254, 49, 49, 232, 116, 112, 67, 185, 33, 167, 203, 217, 172, 158, 135, 128, 191, 238, 15, 2, 107, 198, 192, 38, 128, 25, 37, 56, 193, 226, 188, 198, 159, 140, 16, 32, 164, 24, 63, 181, 86, 155, 249, 7, 146, 155, 193, 28, 10, 124, 13, 246, 171, 151, 251, 107, 59, 66, 162, 94, 171, 118, 50, 191, 51, 145, 144, 248, 113, 33, 184, 201 } });
        }
    }
}
