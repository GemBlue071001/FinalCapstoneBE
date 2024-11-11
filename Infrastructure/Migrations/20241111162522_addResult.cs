using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnalyzedResult",
                table: "JobPostActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 264, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 264, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7553), new byte[] { 98, 129, 80, 32, 90, 105, 248, 199, 94, 0, 79, 40, 144, 70, 90, 49, 124, 15, 132, 251, 216, 159, 49, 123, 185, 86, 25, 201, 143, 174, 151, 17, 6, 24, 246, 166, 52, 141, 94, 166, 109, 133, 104, 82, 190, 41, 19, 75, 92, 135, 23, 255, 185, 195, 0, 101, 98, 73, 34, 185, 126, 54, 141, 96 }, new byte[] { 81, 110, 204, 121, 2, 83, 9, 80, 160, 79, 136, 87, 107, 127, 61, 123, 147, 254, 168, 106, 94, 153, 10, 49, 129, 171, 117, 124, 122, 178, 161, 101, 34, 67, 30, 118, 164, 95, 229, 99, 13, 37, 104, 20, 145, 64, 177, 103, 95, 7, 88, 205, 252, 82, 229, 186, 139, 248, 238, 54, 170, 93, 143, 7, 85, 115, 34, 76, 171, 240, 65, 157, 83, 58, 150, 137, 237, 72, 209, 197, 115, 186, 163, 28, 60, 178, 179, 94, 201, 246, 67, 156, 11, 210, 108, 52, 242, 222, 102, 71, 27, 200, 180, 200, 128, 215, 97, 142, 109, 150, 135, 201, 96, 178, 15, 227, 167, 132, 14, 56, 39, 76, 118, 164, 162, 10, 9, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7561), new byte[] { 83, 254, 89, 175, 117, 118, 94, 175, 216, 113, 163, 177, 142, 114, 100, 34, 115, 173, 229, 210, 249, 227, 97, 124, 161, 157, 78, 166, 116, 10, 208, 7, 20, 75, 127, 107, 167, 251, 25, 86, 161, 48, 56, 36, 190, 80, 64, 84, 100, 3, 147, 16, 192, 65, 67, 241, 171, 175, 153, 110, 255, 49, 195, 199 }, new byte[] { 51, 35, 0, 242, 82, 253, 215, 230, 244, 30, 166, 195, 76, 15, 69, 214, 220, 166, 153, 218, 163, 204, 9, 153, 157, 87, 172, 31, 99, 214, 124, 78, 40, 26, 207, 76, 99, 140, 225, 44, 28, 160, 77, 233, 0, 237, 198, 33, 248, 169, 33, 11, 216, 100, 221, 156, 56, 82, 55, 152, 211, 8, 5, 25, 99, 36, 137, 49, 185, 143, 239, 180, 78, 48, 138, 143, 129, 45, 97, 128, 116, 142, 186, 78, 73, 169, 102, 127, 123, 63, 152, 247, 106, 14, 69, 190, 201, 232, 106, 121, 221, 152, 212, 75, 130, 93, 25, 245, 235, 100, 168, 152, 86, 79, 223, 210, 149, 2, 214, 208, 116, 149, 75, 73, 168, 27, 56, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7563), new byte[] { 143, 198, 51, 148, 44, 64, 61, 128, 95, 64, 174, 24, 243, 71, 210, 240, 41, 7, 135, 39, 133, 53, 38, 247, 88, 17, 163, 157, 171, 69, 174, 53, 12, 116, 52, 182, 87, 79, 246, 114, 123, 166, 42, 202, 101, 174, 153, 118, 203, 105, 183, 227, 158, 163, 208, 176, 31, 103, 225, 131, 228, 229, 36, 250 }, new byte[] { 159, 227, 114, 242, 26, 186, 239, 214, 98, 34, 143, 239, 89, 182, 187, 157, 65, 152, 173, 221, 225, 120, 253, 166, 191, 4, 207, 113, 181, 217, 135, 90, 72, 194, 32, 101, 106, 176, 32, 53, 98, 140, 175, 79, 91, 7, 145, 172, 39, 57, 179, 208, 11, 96, 85, 160, 186, 40, 33, 235, 87, 3, 43, 124, 214, 217, 64, 186, 230, 188, 102, 215, 192, 28, 171, 207, 33, 123, 93, 169, 97, 161, 166, 116, 109, 29, 103, 74, 179, 225, 47, 202, 126, 58, 93, 151, 47, 98, 95, 40, 229, 179, 239, 97, 75, 29, 127, 19, 230, 70, 61, 181, 52, 199, 31, 134, 159, 23, 102, 228, 100, 189, 172, 118, 46, 196, 241, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7564), new byte[] { 4, 234, 176, 168, 95, 166, 9, 245, 77, 39, 241, 12, 95, 9, 140, 45, 228, 63, 99, 200, 3, 214, 3, 11, 87, 230, 196, 206, 144, 215, 115, 158, 87, 115, 76, 207, 160, 243, 240, 55, 234, 177, 174, 171, 37, 40, 228, 93, 45, 181, 186, 94, 222, 69, 116, 244, 41, 105, 110, 249, 157, 61, 182, 142 }, new byte[] { 224, 176, 62, 87, 196, 8, 209, 224, 170, 196, 2, 28, 115, 215, 1, 42, 53, 88, 36, 34, 43, 129, 87, 139, 142, 170, 210, 91, 234, 45, 74, 170, 171, 58, 167, 76, 174, 46, 195, 130, 211, 156, 50, 104, 69, 37, 70, 131, 226, 174, 31, 92, 153, 66, 164, 111, 185, 160, 71, 252, 234, 31, 6, 133, 12, 115, 235, 182, 57, 98, 18, 203, 216, 168, 174, 150, 142, 34, 118, 184, 90, 128, 228, 149, 34, 93, 225, 245, 58, 192, 41, 173, 90, 160, 250, 55, 200, 46, 121, 35, 190, 95, 197, 2, 155, 68, 9, 150, 242, 15, 5, 200, 225, 211, 246, 202, 137, 36, 234, 92, 44, 57, 80, 237, 226, 116, 83, 207 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnalyzedResult",
                table: "JobPostActivities");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 98, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 98, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 15, 27, 19, 99, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7875), new byte[] { 126, 1, 67, 166, 217, 48, 165, 70, 81, 47, 130, 77, 139, 220, 212, 87, 125, 137, 155, 158, 214, 78, 210, 51, 220, 150, 59, 206, 129, 182, 150, 48, 127, 160, 64, 157, 128, 81, 55, 190, 252, 159, 196, 190, 84, 178, 226, 196, 30, 241, 212, 128, 213, 223, 8, 127, 189, 217, 80, 251, 168, 168, 214, 151 }, new byte[] { 180, 216, 221, 241, 193, 155, 229, 32, 215, 225, 168, 236, 81, 181, 51, 251, 206, 76, 31, 30, 82, 238, 64, 217, 64, 124, 152, 99, 60, 251, 12, 115, 162, 81, 209, 250, 174, 94, 216, 188, 134, 41, 121, 154, 36, 183, 54, 65, 213, 182, 231, 120, 242, 210, 38, 39, 231, 3, 134, 250, 97, 211, 58, 57, 188, 214, 118, 96, 91, 145, 185, 219, 103, 9, 122, 166, 198, 207, 96, 160, 15, 15, 105, 33, 162, 72, 158, 60, 202, 191, 254, 147, 213, 204, 91, 38, 166, 159, 246, 56, 26, 32, 50, 193, 29, 240, 91, 119, 186, 38, 222, 173, 132, 221, 96, 45, 177, 19, 203, 138, 237, 24, 122, 119, 92, 180, 250, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7883), new byte[] { 190, 204, 205, 209, 32, 199, 91, 90, 177, 248, 178, 68, 253, 153, 166, 196, 158, 42, 26, 140, 33, 238, 227, 69, 105, 138, 7, 154, 252, 1, 49, 241, 94, 240, 4, 176, 254, 128, 9, 213, 52, 23, 23, 79, 126, 84, 141, 192, 212, 223, 209, 191, 11, 28, 149, 171, 113, 216, 12, 168, 105, 41, 206, 72 }, new byte[] { 73, 145, 4, 148, 251, 31, 88, 53, 77, 237, 247, 161, 148, 205, 31, 6, 91, 136, 16, 252, 117, 23, 154, 230, 112, 78, 117, 254, 6, 199, 184, 238, 70, 92, 127, 105, 115, 123, 46, 76, 169, 149, 144, 39, 144, 138, 126, 223, 69, 6, 220, 14, 226, 202, 88, 203, 106, 208, 1, 220, 178, 211, 148, 52, 39, 50, 151, 160, 167, 162, 65, 123, 9, 177, 96, 243, 208, 61, 30, 5, 226, 176, 100, 99, 199, 66, 47, 245, 49, 182, 125, 112, 0, 190, 77, 106, 112, 166, 34, 151, 19, 236, 237, 175, 0, 120, 85, 209, 18, 85, 38, 247, 68, 139, 164, 170, 233, 236, 59, 5, 85, 176, 58, 235, 0, 149, 88, 61 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7885), new byte[] { 3, 180, 98, 17, 51, 92, 255, 138, 249, 37, 233, 22, 167, 190, 230, 38, 103, 147, 103, 253, 37, 6, 151, 34, 109, 172, 16, 130, 50, 184, 37, 130, 164, 5, 49, 163, 52, 215, 48, 182, 138, 233, 241, 186, 103, 212, 60, 111, 230, 150, 169, 64, 32, 149, 201, 121, 229, 145, 1, 217, 133, 77, 250, 28 }, new byte[] { 44, 105, 62, 159, 136, 223, 97, 23, 46, 211, 121, 116, 92, 8, 226, 79, 243, 198, 58, 119, 251, 45, 169, 148, 57, 57, 217, 202, 161, 45, 203, 43, 113, 206, 64, 19, 162, 5, 167, 39, 230, 72, 128, 57, 117, 164, 22, 50, 130, 232, 136, 137, 160, 201, 236, 148, 166, 127, 238, 18, 191, 73, 120, 182, 181, 162, 201, 221, 74, 175, 32, 218, 215, 168, 185, 193, 254, 24, 82, 140, 246, 224, 101, 58, 27, 38, 186, 152, 74, 43, 68, 194, 61, 0, 243, 104, 68, 157, 154, 93, 202, 96, 45, 229, 144, 58, 236, 38, 241, 210, 229, 57, 228, 191, 158, 151, 72, 27, 127, 80, 247, 37, 7, 233, 139, 38, 92, 19 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 27, 19, 97, DateTimeKind.Utc).AddTicks(7886), new byte[] { 41, 185, 40, 29, 90, 34, 44, 238, 199, 150, 39, 169, 63, 214, 87, 205, 185, 94, 245, 1, 3, 150, 248, 86, 101, 103, 55, 171, 24, 227, 73, 211, 77, 14, 48, 42, 80, 34, 75, 127, 101, 14, 9, 0, 239, 220, 219, 47, 204, 97, 11, 174, 183, 46, 99, 97, 157, 23, 158, 157, 78, 16, 176, 73 }, new byte[] { 163, 238, 216, 238, 186, 86, 143, 137, 246, 154, 170, 27, 100, 170, 243, 191, 255, 144, 219, 199, 220, 31, 5, 179, 40, 87, 121, 225, 76, 150, 47, 164, 125, 127, 132, 143, 44, 208, 237, 251, 233, 30, 141, 179, 28, 150, 212, 42, 210, 197, 111, 33, 15, 75, 128, 205, 153, 184, 2, 73, 73, 76, 184, 16, 125, 42, 128, 166, 128, 201, 236, 236, 178, 175, 113, 34, 242, 98, 89, 246, 153, 40, 145, 180, 7, 206, 15, 65, 32, 89, 186, 250, 158, 245, 59, 13, 70, 237, 249, 235, 50, 25, 61, 175, 31, 15, 117, 127, 14, 118, 186, 251, 226, 78, 132, 190, 251, 73, 86, 87, 42, 15, 105, 173, 165, 177, 120, 242 } });
        }
    }
}
