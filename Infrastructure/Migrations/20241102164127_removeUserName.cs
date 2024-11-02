using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 630, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 630, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 631, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 631, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 14, 32, 11, 631, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9368), new byte[] { 233, 144, 26, 99, 107, 33, 230, 149, 10, 191, 51, 18, 146, 191, 107, 176, 173, 45, 42, 136, 47, 250, 40, 153, 221, 159, 161, 211, 4, 63, 135, 33, 200, 231, 137, 163, 87, 116, 42, 192, 177, 254, 169, 239, 221, 154, 138, 174, 88, 25, 225, 20, 220, 173, 91, 26, 93, 186, 103, 11, 229, 114, 37, 159 }, new byte[] { 211, 60, 220, 36, 147, 120, 142, 38, 222, 135, 79, 38, 74, 152, 9, 0, 85, 29, 75, 70, 22, 81, 63, 174, 162, 234, 16, 238, 181, 87, 169, 41, 225, 85, 175, 149, 138, 199, 102, 67, 164, 184, 145, 177, 202, 94, 194, 138, 226, 126, 254, 73, 238, 34, 45, 37, 96, 38, 202, 117, 136, 38, 26, 233, 223, 233, 69, 129, 131, 140, 215, 112, 89, 15, 168, 233, 233, 188, 238, 1, 95, 174, 242, 182, 203, 149, 30, 195, 198, 152, 27, 26, 81, 152, 37, 23, 150, 126, 162, 252, 254, 172, 84, 161, 119, 63, 221, 214, 32, 93, 64, 28, 194, 220, 92, 90, 210, 79, 91, 116, 63, 84, 143, 182, 29, 59, 80, 88 }, "User1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9375), new byte[] { 100, 152, 172, 128, 104, 160, 111, 110, 109, 137, 47, 134, 138, 87, 101, 179, 148, 4, 41, 249, 73, 165, 127, 135, 6, 201, 19, 2, 56, 158, 170, 255, 41, 43, 242, 18, 131, 244, 5, 147, 86, 19, 15, 147, 24, 159, 103, 208, 9, 102, 255, 213, 152, 46, 136, 197, 242, 16, 43, 240, 82, 70, 168, 76 }, new byte[] { 47, 83, 99, 45, 140, 241, 151, 245, 33, 45, 123, 124, 218, 23, 240, 187, 101, 117, 33, 130, 36, 179, 7, 252, 7, 170, 228, 209, 132, 138, 2, 183, 52, 214, 251, 86, 120, 56, 113, 40, 179, 64, 209, 13, 201, 152, 98, 172, 92, 19, 146, 112, 223, 56, 174, 163, 137, 100, 192, 25, 246, 193, 193, 95, 85, 238, 229, 207, 148, 18, 159, 23, 240, 17, 118, 246, 230, 65, 16, 196, 117, 222, 69, 111, 244, 202, 106, 61, 142, 239, 188, 184, 66, 182, 252, 32, 153, 165, 219, 6, 203, 9, 218, 34, 7, 219, 97, 230, 1, 97, 113, 188, 127, 126, 9, 73, 191, 8, 33, 167, 40, 98, 89, 236, 229, 247, 101, 9 }, "User2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9377), new byte[] { 9, 210, 35, 166, 81, 108, 107, 10, 152, 173, 214, 42, 35, 78, 247, 143, 155, 114, 135, 131, 226, 135, 119, 15, 141, 59, 178, 141, 84, 253, 188, 78, 251, 238, 153, 235, 182, 184, 48, 237, 111, 28, 112, 14, 72, 136, 76, 197, 123, 190, 163, 181, 168, 174, 117, 235, 164, 55, 70, 60, 222, 201, 30, 39 }, new byte[] { 112, 6, 8, 112, 161, 101, 170, 0, 83, 209, 137, 207, 254, 197, 87, 247, 37, 2, 33, 249, 92, 159, 137, 175, 3, 74, 167, 82, 248, 70, 93, 107, 112, 98, 156, 249, 238, 191, 227, 214, 60, 21, 112, 163, 22, 31, 231, 111, 159, 182, 184, 31, 130, 113, 184, 191, 112, 0, 177, 141, 236, 143, 217, 190, 199, 19, 96, 220, 246, 216, 209, 186, 201, 218, 27, 106, 106, 103, 38, 77, 215, 190, 133, 197, 194, 92, 145, 243, 107, 248, 168, 67, 204, 230, 77, 95, 98, 26, 119, 169, 179, 108, 205, 229, 68, 206, 137, 131, 235, 133, 223, 108, 80, 149, 54, 172, 122, 160, 52, 9, 101, 47, 179, 86, 164, 208, 225, 2 }, "Employer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9379), new byte[] { 21, 24, 15, 141, 171, 115, 167, 147, 183, 216, 62, 117, 111, 224, 213, 248, 24, 18, 159, 77, 47, 68, 133, 224, 131, 238, 33, 30, 81, 193, 204, 220, 213, 123, 27, 52, 248, 181, 54, 138, 194, 191, 10, 179, 9, 146, 165, 145, 244, 212, 33, 112, 210, 155, 165, 60, 47, 54, 201, 170, 9, 62, 244, 76 }, new byte[] { 196, 5, 201, 179, 87, 31, 75, 253, 123, 23, 251, 139, 215, 116, 46, 55, 102, 144, 121, 8, 253, 53, 48, 208, 139, 244, 185, 195, 145, 198, 201, 128, 99, 138, 121, 52, 143, 129, 105, 65, 114, 52, 213, 119, 251, 62, 212, 172, 37, 205, 147, 99, 95, 70, 254, 139, 183, 39, 71, 125, 64, 123, 133, 112, 70, 31, 143, 17, 170, 16, 45, 2, 152, 12, 96, 92, 180, 255, 223, 212, 61, 16, 95, 42, 170, 171, 140, 123, 101, 254, 12, 80, 80, 219, 200, 38, 210, 157, 136, 69, 48, 249, 225, 85, 231, 71, 151, 33, 176, 0, 44, 66, 102, 89, 13, 139, 87, 238, 28, 236, 53, 117, 186, 75, 65, 15, 124, 220 }, "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }
    }
}
