using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "EducationDetails");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 674, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 675, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 675, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 676, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 676, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 17, 14, 9, 676, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 14, 9, 674, DateTimeKind.Utc).AddTicks(7089), new byte[] { 55, 193, 37, 190, 164, 0, 83, 169, 5, 145, 221, 190, 251, 98, 159, 122, 170, 183, 56, 94, 54, 138, 203, 195, 75, 109, 165, 137, 156, 243, 163, 239, 93, 51, 49, 234, 172, 252, 18, 159, 206, 35, 211, 84, 254, 118, 195, 43, 101, 96, 198, 243, 112, 78, 112, 79, 143, 195, 93, 212, 78, 178, 46, 21 }, new byte[] { 8, 26, 142, 37, 39, 0, 177, 41, 150, 97, 217, 255, 31, 128, 246, 253, 57, 132, 111, 208, 241, 67, 16, 184, 110, 21, 100, 228, 212, 235, 135, 31, 227, 115, 206, 74, 67, 33, 250, 225, 223, 6, 46, 186, 101, 178, 234, 1, 249, 192, 185, 5, 95, 33, 252, 30, 178, 217, 203, 205, 243, 149, 127, 35, 178, 229, 80, 112, 52, 56, 88, 207, 40, 143, 23, 72, 132, 97, 92, 213, 52, 240, 146, 184, 161, 45, 11, 128, 48, 93, 128, 120, 214, 215, 23, 154, 236, 139, 31, 135, 86, 57, 209, 165, 103, 188, 149, 171, 217, 215, 157, 119, 5, 38, 47, 226, 58, 39, 164, 153, 47, 228, 35, 70, 22, 49, 241, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 14, 9, 674, DateTimeKind.Utc).AddTicks(7098), new byte[] { 166, 74, 46, 203, 69, 16, 12, 55, 12, 154, 229, 160, 111, 190, 122, 132, 61, 173, 66, 147, 196, 198, 14, 164, 40, 254, 35, 215, 149, 182, 207, 214, 250, 77, 150, 198, 75, 204, 200, 175, 21, 80, 177, 209, 220, 146, 59, 15, 80, 85, 58, 195, 185, 164, 71, 66, 251, 13, 117, 68, 93, 231, 48, 53 }, new byte[] { 132, 126, 224, 34, 51, 138, 60, 128, 238, 170, 209, 144, 52, 116, 241, 132, 23, 91, 83, 200, 164, 162, 106, 75, 63, 193, 115, 253, 233, 28, 222, 98, 175, 249, 204, 208, 117, 198, 191, 70, 190, 184, 244, 213, 19, 147, 232, 123, 182, 253, 118, 148, 227, 219, 140, 110, 192, 30, 47, 14, 141, 126, 15, 159, 94, 109, 3, 170, 192, 128, 16, 174, 76, 133, 78, 106, 169, 194, 180, 40, 180, 244, 30, 108, 6, 143, 28, 237, 193, 54, 223, 38, 196, 91, 160, 182, 54, 169, 19, 95, 27, 26, 99, 82, 79, 223, 97, 1, 26, 9, 32, 249, 249, 107, 201, 243, 236, 70, 166, 168, 162, 119, 230, 43, 17, 135, 24, 178 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 14, 9, 674, DateTimeKind.Utc).AddTicks(7099), new byte[] { 183, 133, 3, 51, 245, 136, 50, 133, 245, 28, 116, 179, 140, 75, 29, 83, 185, 249, 160, 51, 85, 110, 90, 56, 150, 141, 43, 65, 131, 159, 35, 97, 56, 43, 215, 147, 111, 28, 103, 249, 38, 226, 155, 239, 188, 21, 233, 229, 126, 18, 206, 50, 155, 189, 255, 26, 55, 86, 31, 186, 124, 73, 93, 188 }, new byte[] { 236, 27, 145, 127, 121, 3, 202, 206, 171, 220, 129, 17, 184, 176, 79, 36, 54, 175, 189, 209, 50, 100, 7, 145, 226, 125, 13, 13, 234, 206, 129, 149, 20, 44, 143, 128, 136, 152, 146, 118, 208, 62, 92, 131, 252, 54, 252, 186, 245, 205, 176, 4, 11, 109, 90, 227, 230, 209, 137, 171, 219, 234, 26, 224, 184, 173, 17, 142, 110, 16, 110, 163, 33, 159, 48, 75, 144, 86, 48, 212, 36, 52, 11, 193, 211, 234, 109, 82, 193, 249, 255, 189, 203, 226, 0, 110, 235, 3, 170, 183, 73, 253, 20, 169, 160, 148, 210, 211, 110, 85, 118, 50, 218, 86, 77, 174, 182, 184, 145, 232, 214, 211, 47, 129, 11, 122, 88, 43 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 14, 9, 674, DateTimeKind.Utc).AddTicks(7101), new byte[] { 58, 188, 122, 56, 118, 83, 67, 145, 65, 204, 213, 87, 113, 253, 251, 234, 232, 201, 152, 240, 181, 191, 153, 108, 182, 217, 177, 199, 202, 138, 13, 216, 121, 170, 227, 121, 64, 72, 45, 82, 191, 100, 27, 115, 44, 163, 121, 189, 242, 35, 68, 220, 136, 102, 188, 215, 59, 176, 148, 30, 162, 209, 184, 180 }, new byte[] { 101, 215, 73, 180, 146, 56, 39, 201, 191, 86, 175, 90, 120, 31, 29, 62, 203, 48, 20, 221, 220, 16, 167, 21, 103, 12, 229, 163, 194, 83, 0, 243, 175, 196, 52, 156, 176, 40, 74, 204, 110, 157, 221, 209, 52, 96, 120, 73, 155, 29, 195, 188, 23, 205, 206, 11, 140, 74, 173, 191, 183, 255, 86, 81, 151, 82, 236, 150, 161, 2, 181, 213, 41, 64, 198, 140, 105, 177, 87, 169, 222, 218, 46, 77, 244, 1, 254, 81, 130, 133, 170, 71, 251, 186, 178, 126, 99, 144, 221, 27, 52, 5, 69, 209, 54, 78, 37, 240, 71, 189, 61, 138, 226, 6, 235, 108, 149, 126, 22, 140, 36, 24, 152, 159, 34, 127, 90, 88 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EducationDetails",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 968, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 968, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 16, 41, 26, 968, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(602), new byte[] { 137, 234, 245, 130, 128, 178, 42, 197, 185, 95, 86, 251, 0, 66, 250, 205, 246, 163, 178, 27, 248, 209, 137, 163, 205, 11, 175, 187, 225, 192, 103, 208, 58, 1, 116, 88, 196, 185, 252, 70, 165, 159, 79, 245, 68, 170, 19, 155, 67, 60, 13, 8, 198, 20, 133, 16, 150, 245, 134, 217, 103, 91, 81, 200 }, new byte[] { 128, 210, 178, 164, 57, 43, 239, 92, 196, 25, 111, 107, 176, 255, 121, 51, 217, 200, 73, 149, 15, 216, 178, 184, 207, 227, 24, 185, 52, 8, 64, 138, 204, 173, 154, 145, 187, 90, 137, 55, 215, 205, 140, 97, 107, 180, 250, 25, 39, 92, 53, 83, 14, 67, 207, 224, 203, 209, 229, 211, 188, 134, 13, 92, 187, 8, 147, 62, 174, 86, 210, 8, 167, 10, 190, 41, 136, 103, 50, 125, 210, 170, 0, 94, 205, 46, 70, 236, 223, 195, 38, 130, 243, 81, 125, 28, 38, 121, 224, 33, 45, 110, 53, 92, 43, 8, 185, 65, 252, 113, 89, 29, 237, 92, 104, 17, 129, 95, 96, 96, 253, 201, 58, 210, 49, 219, 152, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(609), new byte[] { 39, 192, 216, 156, 234, 121, 213, 236, 201, 72, 46, 26, 132, 24, 236, 90, 49, 223, 139, 112, 187, 191, 251, 254, 134, 46, 94, 84, 134, 7, 115, 96, 219, 154, 54, 91, 250, 231, 7, 234, 53, 132, 191, 0, 128, 5, 174, 74, 220, 176, 78, 104, 1, 3, 43, 20, 116, 42, 215, 188, 143, 215, 116, 88 }, new byte[] { 224, 211, 246, 78, 192, 209, 148, 187, 97, 134, 43, 252, 52, 192, 138, 249, 15, 30, 181, 17, 65, 107, 252, 237, 249, 67, 202, 100, 195, 144, 34, 149, 6, 249, 134, 229, 253, 78, 234, 136, 45, 68, 237, 107, 108, 82, 96, 182, 250, 60, 233, 11, 93, 22, 222, 122, 229, 171, 69, 190, 15, 249, 44, 228, 127, 226, 196, 193, 154, 198, 245, 53, 251, 152, 17, 100, 245, 218, 164, 19, 235, 127, 151, 110, 60, 165, 15, 87, 143, 16, 215, 56, 246, 143, 74, 126, 230, 63, 253, 238, 33, 156, 71, 193, 161, 35, 138, 198, 87, 179, 230, 34, 71, 39, 148, 59, 32, 223, 60, 58, 95, 213, 235, 235, 69, 254, 229, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(611), new byte[] { 121, 97, 50, 119, 10, 212, 87, 198, 27, 65, 15, 131, 109, 196, 99, 74, 173, 195, 255, 177, 91, 131, 193, 42, 94, 248, 109, 123, 153, 25, 62, 164, 171, 133, 250, 137, 106, 20, 36, 56, 67, 177, 178, 184, 188, 159, 56, 159, 163, 212, 21, 165, 14, 50, 232, 104, 52, 76, 225, 177, 8, 189, 86, 130 }, new byte[] { 2, 255, 100, 168, 48, 40, 251, 223, 72, 198, 55, 73, 184, 53, 65, 14, 21, 107, 169, 73, 69, 76, 175, 175, 212, 157, 246, 192, 101, 159, 160, 166, 150, 135, 173, 194, 114, 22, 253, 249, 90, 163, 238, 9, 12, 26, 61, 7, 131, 116, 55, 79, 219, 226, 158, 167, 72, 28, 24, 110, 214, 192, 233, 68, 196, 26, 18, 188, 179, 120, 60, 85, 131, 73, 18, 107, 129, 202, 237, 173, 94, 60, 72, 236, 151, 188, 9, 206, 95, 237, 92, 43, 164, 63, 97, 134, 206, 119, 51, 90, 122, 154, 146, 247, 146, 188, 157, 29, 88, 92, 172, 81, 243, 85, 200, 228, 136, 193, 233, 46, 77, 105, 12, 192, 214, 157, 123, 108 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 41, 26, 967, DateTimeKind.Utc).AddTicks(612), new byte[] { 88, 91, 242, 90, 153, 24, 230, 163, 184, 86, 56, 99, 68, 21, 99, 35, 222, 215, 207, 221, 32, 12, 46, 83, 224, 250, 219, 128, 32, 131, 105, 213, 236, 240, 199, 56, 96, 222, 104, 33, 116, 251, 172, 53, 27, 122, 194, 220, 65, 77, 115, 137, 40, 208, 49, 244, 105, 48, 248, 134, 214, 165, 24, 176 }, new byte[] { 205, 17, 160, 10, 121, 166, 117, 111, 132, 127, 20, 106, 87, 63, 178, 22, 243, 15, 4, 246, 221, 99, 42, 135, 106, 213, 93, 255, 224, 9, 115, 140, 64, 243, 54, 152, 149, 153, 12, 29, 180, 55, 150, 254, 115, 27, 238, 107, 145, 50, 149, 194, 111, 119, 133, 12, 227, 105, 148, 67, 10, 163, 246, 38, 182, 170, 209, 118, 226, 43, 249, 175, 19, 180, 239, 68, 248, 72, 185, 83, 123, 222, 242, 125, 22, 52, 24, 53, 225, 197, 124, 231, 121, 219, 169, 156, 4, 17, 109, 231, 48, 73, 246, 22, 232, 162, 255, 215, 227, 157, 2, 146, 21, 188, 45, 136, 118, 126, 251, 40, 251, 125, 161, 245, 99, 172, 250, 133 } });
        }
    }
}
