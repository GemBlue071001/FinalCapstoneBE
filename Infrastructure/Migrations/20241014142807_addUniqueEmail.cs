using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUniqueEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5515), new byte[] { 153, 124, 206, 27, 109, 122, 186, 109, 249, 25, 172, 200, 183, 75, 209, 14, 72, 69, 240, 106, 3, 22, 71, 196, 19, 127, 26, 142, 10, 156, 235, 137, 194, 187, 160, 140, 123, 151, 142, 241, 207, 18, 36, 15, 189, 184, 22, 59, 85, 212, 183, 180, 157, 38, 52, 143, 160, 175, 172, 87, 6, 99, 195, 209 }, new byte[] { 102, 202, 224, 152, 170, 201, 99, 134, 14, 171, 124, 34, 241, 133, 73, 147, 25, 43, 79, 81, 145, 38, 129, 247, 72, 252, 233, 145, 246, 186, 198, 214, 52, 193, 42, 158, 173, 97, 113, 108, 110, 52, 72, 123, 91, 184, 218, 182, 10, 189, 153, 16, 186, 211, 224, 163, 111, 138, 100, 170, 94, 233, 233, 27, 213, 138, 5, 164, 6, 110, 168, 21, 212, 252, 198, 106, 133, 59, 197, 183, 217, 216, 63, 227, 241, 124, 160, 239, 77, 28, 63, 178, 158, 167, 218, 76, 53, 137, 223, 29, 102, 229, 116, 226, 15, 216, 28, 111, 110, 229, 179, 164, 53, 120, 164, 231, 216, 104, 110, 123, 12, 81, 252, 1, 4, 166, 169, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5522), new byte[] { 194, 178, 244, 216, 102, 238, 182, 174, 86, 242, 196, 155, 59, 6, 70, 68, 112, 238, 182, 183, 137, 253, 74, 40, 155, 168, 176, 39, 232, 3, 68, 91, 251, 184, 196, 136, 123, 202, 205, 0, 148, 211, 105, 65, 214, 27, 74, 128, 13, 179, 77, 87, 185, 108, 48, 14, 9, 102, 69, 153, 89, 46, 137, 55 }, new byte[] { 102, 22, 80, 250, 74, 40, 252, 83, 196, 140, 80, 170, 163, 16, 131, 97, 248, 248, 171, 91, 191, 5, 205, 199, 230, 144, 96, 95, 1, 139, 19, 170, 141, 53, 81, 189, 38, 132, 232, 149, 35, 169, 129, 239, 166, 217, 38, 155, 232, 58, 49, 8, 98, 179, 174, 95, 86, 195, 114, 216, 39, 38, 164, 186, 220, 119, 45, 70, 158, 143, 142, 148, 221, 31, 69, 63, 158, 189, 136, 3, 124, 95, 29, 163, 123, 199, 118, 30, 247, 227, 121, 219, 18, 214, 25, 245, 198, 106, 150, 168, 35, 250, 247, 232, 13, 80, 255, 23, 120, 211, 213, 32, 162, 15, 205, 127, 102, 12, 76, 102, 218, 198, 85, 207, 178, 124, 214, 17 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5524), new byte[] { 34, 161, 33, 204, 23, 97, 22, 239, 11, 198, 172, 18, 13, 16, 187, 77, 84, 178, 30, 12, 86, 72, 240, 119, 131, 4, 29, 147, 206, 9, 224, 140, 157, 111, 96, 136, 109, 134, 96, 101, 214, 166, 209, 229, 77, 231, 113, 71, 162, 151, 224, 199, 217, 34, 153, 164, 140, 87, 245, 61, 136, 209, 223, 255 }, new byte[] { 84, 204, 170, 0, 235, 103, 109, 53, 65, 179, 81, 138, 1, 199, 66, 206, 32, 137, 185, 186, 139, 251, 42, 143, 36, 222, 234, 123, 97, 111, 48, 166, 91, 9, 203, 94, 17, 152, 37, 174, 146, 54, 50, 74, 107, 108, 142, 116, 186, 9, 89, 26, 105, 108, 113, 74, 5, 112, 16, 14, 33, 55, 8, 158, 120, 249, 207, 80, 59, 86, 135, 108, 120, 120, 67, 139, 248, 228, 66, 219, 121, 166, 230, 28, 29, 99, 202, 33, 249, 40, 134, 217, 93, 56, 1, 228, 28, 161, 140, 174, 194, 222, 54, 106, 200, 18, 22, 108, 80, 10, 19, 185, 203, 150, 137, 146, 23, 189, 70, 99, 113, 20, 156, 52, 154, 163, 115, 131 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5526), new byte[] { 72, 88, 135, 103, 209, 65, 15, 5, 19, 64, 195, 163, 212, 244, 193, 6, 242, 195, 181, 219, 143, 124, 245, 107, 70, 117, 154, 188, 63, 98, 25, 159, 24, 80, 160, 159, 176, 174, 38, 129, 146, 65, 13, 237, 204, 75, 186, 98, 68, 100, 123, 104, 139, 22, 99, 52, 235, 40, 49, 18, 139, 99, 240, 191 }, new byte[] { 92, 226, 71, 63, 96, 43, 157, 220, 66, 26, 249, 40, 100, 163, 14, 146, 73, 69, 181, 90, 66, 112, 192, 232, 82, 221, 114, 134, 132, 249, 80, 252, 16, 129, 34, 31, 49, 200, 194, 170, 216, 216, 214, 88, 176, 160, 215, 187, 61, 128, 33, 43, 68, 15, 207, 90, 254, 68, 164, 72, 109, 42, 99, 50, 110, 124, 34, 63, 211, 184, 14, 175, 120, 247, 56, 202, 85, 150, 159, 138, 128, 126, 201, 223, 103, 57, 62, 113, 254, 52, 158, 129, 163, 94, 185, 19, 227, 198, 185, 80, 58, 129, 83, 45, 151, 56, 252, 71, 10, 135, 74, 30, 231, 176, 147, 232, 30, 225, 36, 65, 75, 31, 253, 98, 16, 218, 84, 184 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4263), new byte[] { 10, 222, 75, 126, 168, 151, 194, 217, 45, 140, 119, 132, 52, 139, 156, 183, 101, 229, 28, 18, 102, 107, 111, 54, 73, 63, 222, 149, 217, 48, 233, 208, 71, 13, 83, 100, 171, 34, 52, 197, 104, 227, 138, 140, 170, 13, 42, 170, 7, 216, 124, 0, 16, 72, 180, 134, 134, 42, 229, 215, 226, 16, 87, 46 }, new byte[] { 69, 175, 198, 130, 22, 105, 204, 103, 9, 27, 36, 46, 120, 32, 161, 199, 249, 211, 123, 187, 110, 125, 48, 86, 237, 35, 118, 196, 224, 13, 86, 183, 222, 128, 55, 125, 81, 119, 109, 203, 77, 108, 124, 101, 138, 24, 3, 147, 201, 23, 38, 158, 123, 148, 88, 19, 75, 90, 236, 155, 240, 171, 227, 86, 68, 230, 228, 176, 217, 165, 47, 144, 128, 229, 175, 128, 141, 23, 176, 55, 12, 48, 60, 242, 198, 141, 148, 78, 208, 85, 61, 223, 196, 188, 119, 33, 152, 13, 135, 18, 226, 160, 4, 9, 56, 58, 1, 28, 62, 119, 42, 77, 203, 147, 172, 4, 64, 205, 42, 237, 238, 15, 49, 212, 62, 125, 180, 131 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4271), new byte[] { 35, 90, 32, 128, 42, 135, 202, 217, 86, 164, 117, 136, 197, 199, 31, 71, 208, 232, 175, 190, 153, 215, 153, 140, 128, 123, 32, 35, 63, 146, 113, 96, 110, 244, 31, 164, 183, 135, 64, 129, 229, 13, 93, 111, 12, 83, 73, 248, 228, 177, 33, 24, 54, 16, 143, 147, 182, 195, 159, 212, 169, 85, 92, 93 }, new byte[] { 166, 109, 141, 143, 245, 252, 154, 51, 50, 41, 179, 246, 141, 1, 224, 87, 72, 133, 88, 209, 80, 52, 32, 161, 225, 83, 40, 219, 40, 248, 96, 173, 192, 85, 199, 162, 113, 199, 243, 133, 205, 253, 179, 0, 6, 227, 115, 241, 55, 68, 193, 163, 246, 100, 13, 240, 239, 193, 235, 50, 16, 136, 177, 122, 85, 29, 29, 80, 214, 15, 11, 175, 167, 224, 136, 25, 80, 251, 245, 70, 222, 86, 39, 91, 93, 93, 39, 147, 31, 15, 229, 216, 152, 72, 230, 10, 132, 179, 33, 17, 97, 201, 194, 101, 105, 157, 98, 111, 216, 108, 100, 31, 25, 90, 235, 34, 228, 121, 182, 214, 247, 31, 74, 28, 225, 34, 180, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4274), new byte[] { 232, 133, 254, 27, 208, 66, 85, 157, 234, 78, 213, 34, 179, 87, 26, 2, 113, 168, 141, 236, 179, 147, 166, 47, 194, 117, 119, 94, 244, 180, 8, 13, 97, 157, 116, 59, 178, 75, 164, 65, 210, 136, 204, 8, 187, 36, 68, 125, 154, 95, 59, 98, 187, 174, 29, 116, 105, 37, 81, 239, 134, 150, 168, 108 }, new byte[] { 185, 20, 205, 43, 222, 93, 81, 50, 12, 220, 207, 46, 125, 124, 27, 53, 132, 20, 51, 169, 249, 131, 121, 243, 142, 93, 239, 218, 84, 155, 186, 91, 134, 91, 234, 54, 162, 136, 57, 152, 144, 65, 197, 203, 239, 31, 112, 110, 12, 56, 139, 40, 106, 95, 110, 183, 2, 0, 31, 118, 10, 139, 153, 219, 141, 196, 78, 109, 247, 252, 71, 232, 67, 28, 100, 154, 196, 233, 186, 14, 67, 23, 53, 211, 143, 17, 136, 8, 231, 75, 147, 66, 167, 53, 140, 46, 36, 214, 117, 130, 107, 141, 53, 120, 41, 243, 62, 186, 121, 239, 171, 153, 61, 212, 159, 110, 158, 192, 156, 113, 198, 253, 66, 251, 185, 236, 209, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4275), new byte[] { 149, 40, 19, 6, 113, 9, 137, 241, 14, 77, 192, 224, 230, 138, 143, 237, 109, 37, 27, 132, 163, 21, 184, 23, 7, 132, 244, 210, 90, 121, 141, 147, 87, 5, 145, 117, 69, 255, 106, 150, 107, 70, 238, 1, 181, 43, 80, 95, 163, 12, 96, 254, 30, 231, 230, 1, 14, 42, 31, 107, 119, 60, 65, 40 }, new byte[] { 30, 190, 129, 90, 29, 14, 172, 224, 245, 200, 173, 220, 231, 191, 3, 28, 228, 168, 82, 87, 50, 193, 71, 204, 183, 219, 192, 89, 240, 151, 48, 186, 88, 255, 23, 10, 161, 161, 171, 16, 46, 117, 117, 204, 81, 79, 61, 69, 32, 147, 135, 221, 213, 31, 240, 180, 175, 35, 194, 33, 108, 41, 162, 63, 138, 224, 208, 196, 237, 32, 50, 135, 197, 77, 23, 93, 102, 37, 34, 202, 213, 202, 74, 200, 222, 223, 182, 108, 38, 12, 174, 57, 43, 125, 227, 136, 250, 77, 107, 204, 170, 168, 166, 231, 189, 14, 202, 208, 19, 176, 47, 64, 143, 136, 254, 21, 91, 171, 10, 118, 181, 173, 52, 113, 106, 172, 2, 231 } });
        }
    }
}
