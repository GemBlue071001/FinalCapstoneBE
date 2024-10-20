using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "JobPostActivities",
                type: "double precision",
                nullable: true);

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
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9368), new byte[] { 233, 144, 26, 99, 107, 33, 230, 149, 10, 191, 51, 18, 146, 191, 107, 176, 173, 45, 42, 136, 47, 250, 40, 153, 221, 159, 161, 211, 4, 63, 135, 33, 200, 231, 137, 163, 87, 116, 42, 192, 177, 254, 169, 239, 221, 154, 138, 174, 88, 25, 225, 20, 220, 173, 91, 26, 93, 186, 103, 11, 229, 114, 37, 159 }, new byte[] { 211, 60, 220, 36, 147, 120, 142, 38, 222, 135, 79, 38, 74, 152, 9, 0, 85, 29, 75, 70, 22, 81, 63, 174, 162, 234, 16, 238, 181, 87, 169, 41, 225, 85, 175, 149, 138, 199, 102, 67, 164, 184, 145, 177, 202, 94, 194, 138, 226, 126, 254, 73, 238, 34, 45, 37, 96, 38, 202, 117, 136, 38, 26, 233, 223, 233, 69, 129, 131, 140, 215, 112, 89, 15, 168, 233, 233, 188, 238, 1, 95, 174, 242, 182, 203, 149, 30, 195, 198, 152, 27, 26, 81, 152, 37, 23, 150, 126, 162, 252, 254, 172, 84, 161, 119, 63, 221, 214, 32, 93, 64, 28, 194, 220, 92, 90, 210, 79, 91, 116, 63, 84, 143, 182, 29, 59, 80, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9375), new byte[] { 100, 152, 172, 128, 104, 160, 111, 110, 109, 137, 47, 134, 138, 87, 101, 179, 148, 4, 41, 249, 73, 165, 127, 135, 6, 201, 19, 2, 56, 158, 170, 255, 41, 43, 242, 18, 131, 244, 5, 147, 86, 19, 15, 147, 24, 159, 103, 208, 9, 102, 255, 213, 152, 46, 136, 197, 242, 16, 43, 240, 82, 70, 168, 76 }, new byte[] { 47, 83, 99, 45, 140, 241, 151, 245, 33, 45, 123, 124, 218, 23, 240, 187, 101, 117, 33, 130, 36, 179, 7, 252, 7, 170, 228, 209, 132, 138, 2, 183, 52, 214, 251, 86, 120, 56, 113, 40, 179, 64, 209, 13, 201, 152, 98, 172, 92, 19, 146, 112, 223, 56, 174, 163, 137, 100, 192, 25, 246, 193, 193, 95, 85, 238, 229, 207, 148, 18, 159, 23, 240, 17, 118, 246, 230, 65, 16, 196, 117, 222, 69, 111, 244, 202, 106, 61, 142, 239, 188, 184, 66, 182, 252, 32, 153, 165, 219, 6, 203, 9, 218, 34, 7, 219, 97, 230, 1, 97, 113, 188, 127, 126, 9, 73, 191, 8, 33, 167, 40, 98, 89, 236, 229, 247, 101, 9 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9377), new byte[] { 9, 210, 35, 166, 81, 108, 107, 10, 152, 173, 214, 42, 35, 78, 247, 143, 155, 114, 135, 131, 226, 135, 119, 15, 141, 59, 178, 141, 84, 253, 188, 78, 251, 238, 153, 235, 182, 184, 48, 237, 111, 28, 112, 14, 72, 136, 76, 197, 123, 190, 163, 181, 168, 174, 117, 235, 164, 55, 70, 60, 222, 201, 30, 39 }, new byte[] { 112, 6, 8, 112, 161, 101, 170, 0, 83, 209, 137, 207, 254, 197, 87, 247, 37, 2, 33, 249, 92, 159, 137, 175, 3, 74, 167, 82, 248, 70, 93, 107, 112, 98, 156, 249, 238, 191, 227, 214, 60, 21, 112, 163, 22, 31, 231, 111, 159, 182, 184, 31, 130, 113, 184, 191, 112, 0, 177, 141, 236, 143, 217, 190, 199, 19, 96, 220, 246, 216, 209, 186, 201, 218, 27, 106, 106, 103, 38, 77, 215, 190, 133, 197, 194, 92, 145, 243, 107, 248, 168, 67, 204, 230, 77, 95, 98, 26, 119, 169, 179, 108, 205, 229, 68, 206, 137, 131, 235, 133, 223, 108, 80, 149, 54, 172, 122, 160, 52, 9, 101, 47, 179, 86, 164, 208, 225, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 14, 32, 11, 629, DateTimeKind.Utc).AddTicks(9379), new byte[] { 21, 24, 15, 141, 171, 115, 167, 147, 183, 216, 62, 117, 111, 224, 213, 248, 24, 18, 159, 77, 47, 68, 133, 224, 131, 238, 33, 30, 81, 193, 204, 220, 213, 123, 27, 52, 248, 181, 54, 138, 194, 191, 10, 179, 9, 146, 165, 145, 244, 212, 33, 112, 210, 155, 165, 60, 47, 54, 201, 170, 9, 62, 244, 76 }, new byte[] { 196, 5, 201, 179, 87, 31, 75, 253, 123, 23, 251, 139, 215, 116, 46, 55, 102, 144, 121, 8, 253, 53, 48, 208, 139, 244, 185, 195, 145, 198, 201, 128, 99, 138, 121, 52, 143, 129, 105, 65, 114, 52, 213, 119, 251, 62, 212, 172, 37, 205, 147, 99, 95, 70, 254, 139, 183, 39, 71, 125, 64, 123, 133, 112, 70, 31, 143, 17, 170, 16, 45, 2, 152, 12, 96, 92, 180, 255, 223, 212, 61, 16, 95, 42, 170, 171, 140, 123, 101, 254, 12, 80, 80, 219, 200, 38, 210, 157, 136, 69, 48, 249, 225, 85, 231, 71, 151, 33, 176, 0, 44, 66, 102, 89, 13, 139, 87, 238, 28, 236, 53, 117, 186, 75, 65, 15, 124, 220 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "JobPostActivities");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 909, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 909, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 17, 54, 51, 909, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(4983), new byte[] { 233, 73, 137, 133, 106, 123, 115, 168, 114, 105, 7, 23, 29, 21, 48, 0, 146, 24, 76, 140, 183, 54, 203, 181, 190, 136, 89, 243, 158, 222, 240, 170, 240, 251, 95, 67, 15, 170, 134, 106, 239, 240, 124, 175, 105, 94, 95, 56, 230, 65, 199, 125, 70, 39, 46, 254, 111, 238, 140, 178, 98, 27, 104, 190 }, new byte[] { 128, 74, 87, 198, 140, 11, 243, 109, 210, 225, 176, 223, 159, 221, 67, 187, 135, 73, 221, 188, 208, 40, 187, 138, 11, 87, 6, 225, 217, 229, 171, 210, 193, 188, 50, 202, 88, 142, 134, 25, 156, 65, 193, 168, 231, 152, 91, 158, 197, 225, 140, 168, 204, 87, 202, 43, 126, 82, 162, 200, 162, 205, 158, 39, 189, 218, 35, 175, 250, 80, 226, 144, 95, 55, 178, 38, 222, 142, 147, 196, 208, 221, 68, 40, 246, 157, 221, 204, 0, 117, 91, 63, 172, 204, 172, 94, 126, 89, 52, 160, 166, 254, 128, 51, 244, 148, 2, 90, 28, 13, 81, 235, 180, 90, 162, 99, 188, 8, 224, 18, 209, 25, 252, 25, 174, 107, 67, 139 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(4999), new byte[] { 9, 19, 52, 63, 234, 172, 29, 115, 89, 178, 219, 140, 13, 160, 31, 218, 218, 95, 147, 126, 194, 186, 173, 218, 67, 165, 116, 57, 189, 116, 112, 110, 96, 186, 65, 171, 158, 118, 228, 239, 236, 151, 66, 198, 72, 163, 58, 212, 180, 220, 113, 88, 90, 178, 195, 155, 210, 130, 122, 27, 31, 233, 232, 221 }, new byte[] { 134, 87, 62, 212, 177, 149, 27, 218, 216, 54, 187, 207, 255, 161, 177, 72, 124, 118, 108, 222, 171, 20, 48, 74, 141, 52, 0, 227, 151, 30, 53, 4, 87, 78, 121, 136, 80, 176, 71, 182, 21, 154, 3, 33, 47, 23, 23, 203, 103, 114, 199, 9, 159, 242, 37, 17, 98, 208, 2, 62, 112, 133, 33, 19, 148, 13, 123, 212, 16, 227, 10, 34, 169, 76, 85, 104, 11, 191, 48, 22, 139, 182, 194, 145, 198, 132, 5, 47, 232, 159, 166, 80, 253, 125, 106, 246, 192, 209, 64, 94, 173, 189, 52, 165, 110, 109, 240, 82, 127, 17, 153, 51, 7, 177, 34, 242, 248, 213, 186, 223, 236, 142, 112, 244, 169, 149, 155, 15 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(5001), new byte[] { 58, 53, 176, 43, 100, 38, 176, 34, 58, 25, 223, 250, 247, 119, 79, 56, 5, 163, 65, 93, 58, 11, 165, 193, 161, 95, 36, 34, 65, 179, 235, 95, 30, 50, 54, 120, 207, 181, 71, 136, 13, 72, 181, 84, 204, 10, 56, 16, 162, 190, 104, 173, 174, 196, 2, 80, 103, 41, 123, 172, 95, 132, 160, 98 }, new byte[] { 62, 255, 216, 175, 241, 41, 166, 194, 228, 116, 241, 117, 67, 254, 19, 184, 39, 231, 211, 207, 30, 141, 133, 227, 64, 28, 162, 86, 53, 180, 28, 253, 217, 29, 247, 42, 225, 115, 46, 188, 192, 178, 58, 154, 240, 127, 219, 187, 54, 21, 106, 79, 83, 140, 122, 213, 100, 180, 71, 155, 44, 126, 245, 218, 38, 75, 126, 130, 78, 49, 37, 198, 93, 200, 248, 209, 251, 169, 62, 224, 165, 229, 162, 139, 37, 45, 157, 65, 56, 38, 222, 168, 124, 58, 188, 254, 53, 238, 220, 86, 128, 208, 24, 195, 5, 169, 67, 55, 82, 157, 47, 204, 243, 96, 183, 170, 76, 135, 32, 195, 190, 72, 51, 216, 193, 119, 79, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 54, 51, 908, DateTimeKind.Utc).AddTicks(5003), new byte[] { 239, 37, 199, 130, 31, 207, 70, 154, 128, 61, 230, 216, 177, 75, 94, 203, 179, 43, 150, 199, 191, 39, 251, 56, 124, 174, 109, 124, 59, 65, 136, 49, 122, 74, 199, 116, 206, 126, 129, 138, 15, 27, 198, 109, 93, 45, 113, 224, 180, 43, 28, 99, 84, 118, 228, 203, 245, 253, 179, 207, 53, 142, 164, 167 }, new byte[] { 60, 109, 7, 22, 45, 82, 146, 132, 100, 194, 224, 6, 129, 36, 38, 137, 226, 181, 36, 205, 61, 105, 45, 42, 132, 123, 164, 174, 123, 60, 37, 243, 145, 181, 214, 192, 87, 107, 6, 209, 140, 19, 177, 51, 146, 155, 179, 189, 122, 224, 53, 7, 232, 62, 190, 54, 110, 17, 241, 35, 77, 124, 34, 136, 131, 120, 2, 158, 146, 223, 25, 118, 73, 73, 55, 163, 131, 62, 159, 54, 35, 97, 90, 119, 177, 208, 48, 16, 139, 89, 91, 16, 159, 245, 57, 199, 238, 24, 51, 166, 129, 2, 174, 142, 166, 178, 127, 89, 41, 63, 124, 59, 180, 74, 203, 110, 21, 115, 162, 153, 114, 43, 197, 108, 228, 187, 240, 23 } });
        }
    }
}
