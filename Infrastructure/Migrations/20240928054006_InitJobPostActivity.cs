using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitJobPostActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 638, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 638, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 638, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 40, 5, 638, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(6899), new byte[] { 36, 121, 189, 110, 142, 4, 252, 55, 70, 229, 168, 138, 93, 76, 128, 76, 171, 154, 191, 153, 52, 44, 80, 90, 80, 102, 95, 239, 78, 51, 23, 81, 235, 128, 17, 178, 103, 193, 48, 98, 46, 46, 63, 0, 170, 174, 35, 179, 105, 52, 47, 229, 61, 219, 210, 218, 6, 77, 177, 35, 96, 231, 245, 216 }, new byte[] { 121, 249, 57, 23, 221, 98, 116, 8, 123, 34, 175, 220, 68, 108, 23, 56, 104, 9, 30, 211, 58, 108, 247, 75, 3, 13, 188, 239, 48, 31, 69, 24, 171, 247, 205, 55, 176, 53, 17, 184, 127, 206, 56, 135, 195, 198, 71, 123, 21, 243, 107, 40, 218, 6, 207, 98, 34, 121, 7, 43, 248, 145, 48, 237, 79, 1, 208, 63, 149, 187, 135, 42, 221, 180, 34, 163, 91, 253, 93, 82, 196, 41, 17, 41, 253, 28, 123, 165, 75, 117, 86, 188, 81, 105, 214, 236, 159, 233, 101, 127, 82, 105, 4, 133, 231, 79, 102, 219, 12, 151, 42, 27, 220, 241, 233, 242, 221, 114, 237, 245, 199, 166, 163, 84, 120, 123, 9, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(6905), new byte[] { 243, 30, 237, 216, 171, 51, 66, 101, 43, 81, 137, 46, 220, 183, 86, 221, 41, 97, 16, 182, 205, 192, 157, 133, 98, 50, 18, 38, 42, 164, 84, 91, 149, 125, 65, 64, 40, 169, 241, 11, 41, 181, 193, 138, 42, 42, 129, 45, 169, 225, 54, 120, 200, 194, 166, 111, 171, 254, 69, 209, 83, 199, 41, 8 }, new byte[] { 113, 150, 252, 29, 141, 23, 40, 123, 38, 63, 151, 72, 68, 189, 95, 250, 165, 66, 167, 2, 28, 30, 194, 148, 224, 0, 34, 87, 248, 126, 40, 149, 196, 3, 240, 63, 35, 144, 152, 110, 231, 210, 167, 200, 88, 31, 128, 47, 162, 83, 26, 174, 224, 138, 81, 55, 163, 23, 147, 241, 167, 108, 44, 70, 120, 171, 121, 243, 112, 108, 80, 85, 49, 243, 184, 208, 34, 175, 227, 15, 155, 99, 142, 19, 108, 57, 30, 104, 190, 172, 226, 214, 107, 217, 146, 87, 33, 30, 167, 8, 6, 222, 206, 50, 3, 132, 114, 126, 153, 66, 180, 7, 146, 100, 238, 235, 90, 11, 178, 159, 115, 125, 36, 38, 235, 232, 237, 234 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(6907), new byte[] { 31, 173, 146, 196, 105, 50, 201, 144, 168, 186, 66, 66, 204, 108, 234, 203, 180, 61, 241, 35, 158, 94, 190, 165, 184, 173, 60, 133, 37, 215, 100, 135, 146, 75, 168, 228, 44, 17, 187, 23, 170, 132, 237, 192, 77, 6, 3, 93, 21, 25, 171, 23, 168, 106, 201, 71, 247, 228, 127, 49, 67, 84, 118, 89 }, new byte[] { 89, 174, 15, 173, 166, 47, 37, 153, 215, 215, 252, 132, 199, 198, 243, 240, 88, 173, 194, 76, 141, 203, 240, 42, 33, 40, 232, 109, 136, 230, 144, 27, 92, 169, 99, 29, 28, 216, 74, 88, 63, 211, 113, 17, 36, 14, 241, 63, 73, 28, 57, 102, 170, 51, 170, 83, 126, 63, 113, 232, 219, 0, 241, 246, 5, 210, 223, 94, 39, 150, 34, 169, 233, 242, 202, 212, 172, 253, 87, 209, 238, 204, 252, 18, 54, 51, 82, 2, 221, 44, 93, 224, 164, 222, 147, 127, 167, 93, 116, 82, 116, 208, 181, 74, 106, 97, 195, 87, 90, 135, 202, 22, 178, 243, 239, 160, 171, 77, 123, 17, 216, 54, 18, 112, 64, 77, 106, 15 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 40, 5, 637, DateTimeKind.Utc).AddTicks(6908), new byte[] { 200, 39, 86, 168, 209, 134, 125, 43, 146, 92, 49, 20, 231, 23, 147, 142, 243, 227, 64, 106, 4, 239, 133, 238, 13, 255, 131, 104, 86, 254, 224, 151, 15, 16, 90, 174, 171, 96, 249, 165, 250, 3, 62, 174, 144, 158, 170, 95, 134, 98, 41, 17, 115, 209, 255, 145, 113, 159, 79, 121, 178, 52, 26, 167 }, new byte[] { 204, 90, 5, 113, 247, 149, 239, 29, 44, 112, 97, 212, 39, 120, 240, 150, 216, 143, 182, 17, 86, 254, 202, 59, 188, 183, 142, 129, 48, 80, 80, 95, 54, 39, 153, 189, 198, 15, 46, 56, 107, 156, 45, 213, 88, 19, 100, 203, 198, 249, 219, 209, 149, 147, 197, 171, 152, 58, 246, 155, 244, 89, 61, 179, 4, 108, 221, 65, 145, 176, 236, 125, 250, 44, 207, 108, 8, 24, 151, 16, 246, 113, 140, 133, 150, 174, 230, 154, 30, 92, 175, 43, 124, 154, 236, 166, 8, 171, 109, 192, 41, 169, 185, 177, 93, 112, 132, 43, 135, 237, 244, 95, 157, 152, 78, 101, 54, 121, 144, 176, 150, 220, 188, 162, 65, 183, 201, 153 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 13, 17, 32, 946, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 13, 17, 32, 945, DateTimeKind.Utc).AddTicks(9652), new byte[] { 137, 243, 187, 60, 25, 196, 204, 237, 120, 13, 54, 78, 71, 183, 134, 30, 251, 90, 29, 18, 58, 153, 198, 241, 61, 165, 50, 181, 5, 3, 140, 154, 205, 132, 81, 228, 241, 1, 125, 78, 211, 136, 82, 55, 71, 96, 124, 188, 38, 194, 14, 24, 120, 209, 14, 12, 154, 37, 33, 153, 24, 118, 96, 13 }, new byte[] { 160, 1, 100, 14, 195, 204, 126, 4, 228, 249, 156, 57, 172, 4, 145, 163, 250, 35, 34, 37, 226, 115, 109, 160, 254, 96, 192, 163, 10, 247, 226, 240, 148, 56, 96, 66, 26, 5, 179, 129, 81, 78, 51, 181, 123, 45, 159, 158, 143, 168, 173, 86, 134, 226, 58, 71, 158, 106, 82, 223, 167, 220, 234, 155, 234, 133, 7, 68, 15, 52, 254, 242, 161, 50, 193, 200, 96, 112, 35, 227, 48, 87, 25, 227, 146, 33, 44, 6, 13, 31, 49, 105, 111, 164, 145, 51, 14, 98, 196, 106, 42, 205, 251, 60, 64, 187, 194, 126, 51, 21, 49, 79, 239, 37, 152, 112, 29, 135, 63, 38, 135, 44, 139, 165, 234, 128, 28, 176 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 13, 17, 32, 945, DateTimeKind.Utc).AddTicks(9660), new byte[] { 79, 241, 44, 100, 55, 51, 162, 143, 212, 36, 32, 138, 135, 164, 216, 251, 222, 166, 237, 167, 105, 112, 160, 3, 45, 27, 104, 89, 123, 110, 147, 239, 198, 171, 177, 215, 119, 7, 50, 148, 255, 251, 178, 124, 204, 197, 80, 238, 10, 96, 107, 49, 110, 237, 9, 109, 142, 107, 96, 38, 17, 33, 111, 104 }, new byte[] { 9, 0, 125, 47, 19, 185, 247, 154, 36, 130, 27, 77, 252, 120, 55, 126, 127, 64, 161, 71, 11, 40, 20, 142, 29, 71, 134, 221, 63, 220, 92, 108, 215, 187, 96, 37, 35, 88, 24, 112, 71, 195, 138, 37, 236, 135, 253, 187, 62, 147, 117, 51, 244, 91, 146, 43, 207, 148, 93, 112, 171, 63, 223, 241, 0, 146, 227, 181, 24, 128, 181, 221, 87, 89, 239, 73, 26, 46, 131, 112, 253, 90, 8, 77, 184, 127, 66, 255, 247, 163, 147, 30, 156, 221, 251, 56, 33, 120, 28, 235, 75, 74, 226, 208, 190, 84, 134, 158, 168, 239, 42, 119, 20, 54, 63, 98, 248, 197, 69, 39, 53, 216, 164, 227, 195, 49, 86, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 13, 17, 32, 945, DateTimeKind.Utc).AddTicks(9662), new byte[] { 45, 164, 81, 242, 10, 12, 145, 3, 168, 125, 53, 135, 68, 138, 15, 59, 199, 64, 244, 62, 105, 233, 235, 42, 115, 250, 248, 69, 245, 96, 162, 79, 47, 17, 71, 117, 207, 42, 224, 165, 3, 85, 153, 122, 204, 138, 4, 220, 214, 187, 233, 246, 27, 235, 198, 189, 239, 198, 25, 11, 126, 164, 107, 1 }, new byte[] { 167, 212, 36, 215, 115, 80, 169, 31, 32, 52, 179, 79, 158, 150, 185, 199, 62, 97, 90, 148, 26, 46, 4, 75, 199, 109, 229, 162, 203, 178, 228, 200, 156, 128, 206, 60, 134, 190, 118, 143, 188, 1, 114, 209, 147, 246, 98, 229, 147, 171, 80, 3, 206, 133, 249, 87, 224, 66, 42, 130, 17, 127, 224, 180, 253, 149, 99, 215, 30, 87, 190, 136, 139, 166, 21, 98, 222, 137, 253, 240, 97, 169, 143, 73, 39, 173, 178, 198, 113, 77, 54, 9, 188, 144, 237, 126, 102, 55, 105, 32, 111, 3, 182, 118, 131, 159, 213, 24, 131, 199, 255, 246, 47, 242, 123, 158, 14, 193, 83, 74, 194, 223, 225, 96, 52, 130, 126, 148 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 13, 17, 32, 945, DateTimeKind.Utc).AddTicks(9663), new byte[] { 149, 90, 33, 216, 185, 130, 79, 183, 197, 243, 105, 44, 212, 239, 146, 38, 167, 21, 119, 216, 94, 155, 95, 41, 102, 106, 17, 13, 88, 159, 15, 30, 21, 131, 64, 119, 169, 231, 10, 44, 84, 132, 89, 243, 71, 229, 202, 240, 248, 247, 74, 163, 90, 145, 20, 94, 213, 228, 37, 158, 196, 15, 107, 213 }, new byte[] { 10, 19, 3, 62, 46, 234, 188, 24, 130, 127, 50, 104, 35, 82, 12, 61, 172, 1, 215, 117, 98, 242, 213, 51, 174, 41, 122, 63, 52, 124, 200, 231, 30, 160, 238, 27, 2, 25, 166, 88, 109, 128, 10, 5, 123, 205, 249, 225, 13, 216, 12, 136, 207, 160, 11, 5, 222, 185, 201, 39, 6, 113, 254, 109, 20, 139, 171, 79, 141, 24, 77, 250, 200, 112, 123, 138, 99, 204, 92, 77, 109, 210, 117, 85, 34, 197, 71, 188, 120, 168, 213, 113, 105, 79, 87, 241, 246, 24, 225, 243, 154, 110, 243, 153, 175, 27, 146, 136, 75, 53, 39, 231, 35, 19, 44, 223, 38, 131, 211, 131, 27, 240, 65, 147, 223, 17, 67, 211 } });
        }
    }
}
