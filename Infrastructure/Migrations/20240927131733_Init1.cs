using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1009), new byte[] { 245, 244, 88, 216, 128, 168, 67, 109, 115, 185, 77, 168, 90, 152, 245, 112, 152, 111, 93, 144, 100, 89, 20, 34, 196, 221, 40, 229, 146, 80, 40, 31, 148, 197, 90, 221, 198, 138, 219, 211, 41, 85, 129, 239, 41, 131, 101, 28, 50, 194, 108, 207, 0, 155, 121, 236, 85, 68, 29, 155, 189, 184, 70, 149 }, new byte[] { 88, 181, 240, 125, 222, 105, 135, 143, 18, 99, 153, 69, 96, 236, 109, 91, 212, 21, 147, 17, 144, 120, 160, 33, 129, 168, 222, 122, 135, 67, 161, 244, 42, 32, 217, 207, 135, 245, 124, 159, 233, 169, 131, 13, 230, 187, 187, 170, 240, 168, 142, 152, 253, 173, 68, 100, 69, 148, 195, 64, 22, 126, 239, 36, 151, 24, 72, 24, 50, 100, 176, 154, 53, 128, 20, 88, 42, 244, 61, 95, 236, 250, 143, 229, 72, 8, 149, 38, 98, 76, 181, 52, 75, 121, 92, 118, 48, 225, 42, 175, 250, 36, 161, 96, 103, 224, 94, 103, 188, 78, 194, 220, 133, 88, 223, 38, 119, 157, 236, 127, 160, 132, 214, 141, 239, 74, 101, 125 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1016), new byte[] { 152, 86, 161, 191, 139, 67, 100, 42, 66, 73, 49, 131, 26, 166, 128, 127, 164, 105, 56, 229, 157, 232, 230, 186, 92, 137, 93, 204, 234, 66, 224, 90, 244, 18, 88, 90, 144, 22, 76, 142, 7, 93, 164, 46, 1, 233, 82, 178, 0, 197, 55, 137, 108, 153, 45, 123, 169, 125, 34, 149, 8, 253, 3, 154 }, new byte[] { 148, 72, 25, 253, 61, 210, 207, 50, 39, 63, 64, 213, 32, 159, 159, 101, 151, 242, 130, 167, 226, 5, 113, 197, 150, 58, 53, 112, 71, 135, 68, 92, 252, 228, 168, 236, 169, 135, 226, 183, 130, 134, 94, 41, 227, 224, 12, 79, 79, 52, 28, 84, 153, 147, 102, 220, 93, 40, 97, 231, 168, 22, 162, 48, 230, 51, 33, 79, 241, 33, 25, 71, 232, 90, 235, 141, 205, 199, 43, 37, 181, 48, 157, 87, 164, 252, 186, 216, 242, 61, 38, 239, 21, 6, 71, 12, 144, 6, 172, 203, 143, 69, 16, 3, 158, 254, 71, 216, 125, 119, 72, 118, 113, 75, 142, 164, 43, 198, 12, 96, 5, 149, 7, 1, 250, 105, 108, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1018), new byte[] { 47, 1, 209, 182, 181, 13, 63, 33, 129, 14, 51, 0, 152, 91, 205, 134, 11, 184, 53, 133, 247, 0, 160, 8, 142, 145, 159, 217, 240, 73, 20, 111, 11, 165, 132, 253, 46, 197, 73, 118, 68, 49, 145, 213, 135, 181, 249, 24, 72, 140, 179, 240, 182, 91, 141, 71, 72, 188, 64, 220, 205, 35, 127, 230 }, new byte[] { 96, 205, 204, 32, 142, 239, 33, 95, 214, 135, 234, 215, 162, 209, 74, 234, 36, 190, 216, 117, 88, 173, 148, 182, 12, 123, 238, 240, 179, 71, 111, 120, 247, 68, 157, 153, 81, 93, 243, 155, 157, 29, 166, 203, 198, 102, 101, 191, 26, 16, 147, 241, 156, 103, 168, 178, 41, 107, 74, 244, 96, 164, 112, 191, 227, 249, 19, 86, 61, 222, 144, 182, 188, 46, 130, 54, 72, 154, 31, 34, 43, 29, 198, 154, 132, 2, 35, 197, 72, 220, 182, 121, 49, 147, 172, 177, 71, 194, 45, 199, 234, 76, 14, 246, 121, 193, 156, 195, 203, 179, 50, 26, 57, 186, 92, 230, 26, 160, 121, 48, 106, 74, 103, 136, 175, 100, 195, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1019), new byte[] { 87, 75, 202, 33, 77, 77, 168, 32, 154, 77, 225, 88, 232, 167, 187, 8, 34, 33, 152, 236, 94, 107, 99, 151, 209, 159, 63, 66, 245, 154, 66, 44, 194, 116, 172, 7, 222, 240, 67, 30, 42, 75, 237, 217, 35, 238, 57, 2, 41, 198, 2, 186, 69, 9, 16, 3, 62, 177, 234, 104, 145, 162, 55, 20 }, new byte[] { 47, 95, 90, 137, 243, 145, 199, 206, 93, 179, 201, 137, 29, 188, 193, 60, 39, 83, 109, 38, 243, 136, 0, 162, 73, 39, 100, 252, 29, 55, 240, 69, 123, 197, 244, 80, 205, 113, 200, 239, 79, 164, 143, 85, 154, 45, 127, 213, 194, 176, 102, 197, 192, 168, 232, 165, 175, 148, 255, 208, 141, 181, 92, 129, 236, 65, 225, 151, 147, 169, 167, 222, 87, 102, 199, 57, 99, 186, 187, 6, 247, 249, 211, 254, 222, 65, 87, 185, 100, 216, 132, 12, 98, 9, 10, 246, 238, 15, 239, 213, 74, 134, 111, 107, 132, 22, 170, 247, 203, 129, 92, 157, 12, 175, 248, 232, 7, 13, 15, 51, 123, 221, 223, 57, 240, 140, 174, 19 } });
        }
    }
}
