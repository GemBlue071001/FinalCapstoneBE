using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addJobPostStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobPostReviewStatus",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 540, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 541, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 541, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 542, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 542, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 56, 6, 542, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 56, 6, 540, DateTimeKind.Utc).AddTicks(6116), new byte[] { 129, 1, 226, 166, 197, 122, 104, 107, 195, 154, 223, 244, 255, 43, 164, 239, 189, 237, 252, 249, 211, 117, 17, 113, 129, 56, 101, 147, 178, 84, 215, 22, 244, 133, 47, 149, 124, 186, 119, 55, 47, 99, 106, 214, 88, 253, 191, 60, 86, 123, 243, 79, 226, 150, 35, 137, 235, 250, 26, 252, 143, 192, 72, 245 }, new byte[] { 71, 148, 81, 240, 161, 84, 110, 131, 29, 227, 18, 82, 123, 74, 88, 153, 141, 209, 116, 128, 180, 112, 255, 247, 253, 74, 38, 222, 143, 238, 13, 89, 140, 26, 77, 114, 5, 81, 54, 86, 89, 28, 146, 157, 116, 223, 208, 72, 251, 177, 96, 39, 49, 171, 87, 15, 87, 225, 111, 220, 220, 211, 226, 46, 24, 211, 62, 235, 70, 63, 125, 70, 2, 246, 224, 14, 227, 166, 31, 8, 9, 68, 124, 169, 4, 166, 99, 75, 105, 31, 237, 104, 179, 236, 85, 132, 165, 247, 174, 49, 251, 51, 39, 83, 72, 46, 226, 182, 57, 103, 8, 203, 28, 30, 42, 112, 106, 100, 197, 173, 251, 111, 222, 28, 214, 0, 95, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 56, 6, 540, DateTimeKind.Utc).AddTicks(6122), new byte[] { 1, 114, 91, 15, 41, 63, 8, 3, 216, 189, 1, 196, 178, 84, 131, 164, 43, 17, 128, 251, 173, 126, 116, 93, 94, 113, 48, 121, 143, 67, 198, 116, 80, 148, 93, 14, 176, 190, 207, 127, 182, 232, 84, 213, 28, 134, 189, 201, 52, 166, 116, 43, 198, 161, 125, 254, 130, 150, 125, 204, 223, 227, 161, 78 }, new byte[] { 133, 4, 188, 141, 213, 122, 62, 231, 234, 225, 243, 163, 231, 222, 71, 67, 243, 93, 169, 132, 147, 37, 39, 12, 71, 142, 26, 10, 212, 117, 31, 68, 112, 156, 112, 30, 160, 215, 224, 48, 166, 171, 67, 80, 66, 225, 41, 168, 174, 196, 206, 144, 151, 140, 49, 72, 137, 128, 222, 78, 45, 140, 107, 59, 97, 10, 40, 166, 243, 175, 5, 77, 58, 118, 142, 31, 113, 219, 161, 124, 206, 217, 116, 190, 64, 125, 64, 162, 55, 149, 157, 187, 148, 228, 172, 94, 133, 171, 209, 191, 161, 16, 158, 237, 14, 252, 143, 58, 237, 41, 255, 47, 222, 76, 7, 49, 242, 15, 99, 122, 219, 251, 20, 199, 129, 205, 187, 142 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 56, 6, 540, DateTimeKind.Utc).AddTicks(6124), new byte[] { 205, 86, 181, 167, 38, 252, 12, 225, 210, 233, 187, 83, 21, 85, 160, 249, 196, 142, 19, 1, 66, 247, 108, 173, 148, 99, 34, 234, 124, 255, 164, 111, 119, 88, 48, 186, 10, 219, 129, 201, 129, 238, 22, 77, 63, 97, 107, 178, 148, 158, 141, 145, 116, 241, 178, 127, 170, 102, 185, 164, 91, 135, 1, 246 }, new byte[] { 254, 246, 37, 248, 157, 226, 67, 63, 28, 255, 151, 240, 40, 143, 219, 30, 27, 151, 146, 235, 182, 34, 123, 219, 219, 104, 5, 252, 105, 245, 42, 245, 183, 221, 190, 98, 214, 146, 55, 129, 253, 17, 15, 127, 4, 231, 64, 52, 150, 20, 56, 115, 98, 205, 107, 244, 205, 95, 107, 51, 137, 26, 17, 12, 53, 131, 105, 11, 152, 170, 98, 99, 211, 36, 132, 27, 13, 238, 143, 251, 226, 30, 92, 165, 72, 106, 113, 24, 126, 42, 11, 243, 178, 206, 151, 250, 66, 134, 124, 61, 11, 75, 191, 159, 141, 184, 55, 250, 127, 48, 243, 178, 55, 66, 253, 181, 42, 207, 19, 224, 243, 2, 81, 214, 31, 2, 108, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 56, 6, 540, DateTimeKind.Utc).AddTicks(6126), new byte[] { 94, 142, 87, 29, 165, 4, 83, 102, 217, 58, 231, 76, 207, 227, 189, 142, 237, 166, 34, 187, 235, 64, 71, 67, 32, 22, 97, 48, 55, 45, 168, 44, 242, 217, 190, 13, 174, 78, 219, 63, 221, 116, 131, 108, 51, 197, 252, 55, 91, 235, 203, 240, 32, 212, 250, 82, 217, 38, 174, 165, 124, 145, 115, 188 }, new byte[] { 226, 226, 183, 52, 141, 163, 231, 119, 44, 243, 5, 145, 191, 209, 31, 202, 39, 248, 29, 85, 61, 121, 128, 91, 96, 173, 98, 102, 136, 247, 223, 45, 71, 251, 153, 69, 5, 60, 219, 182, 14, 135, 160, 177, 121, 63, 4, 189, 230, 179, 188, 28, 156, 140, 234, 78, 149, 67, 163, 70, 0, 8, 42, 206, 53, 249, 215, 57, 158, 129, 42, 240, 153, 141, 68, 231, 104, 36, 173, 140, 131, 198, 108, 165, 238, 204, 232, 136, 15, 235, 36, 246, 151, 14, 194, 186, 221, 126, 206, 79, 57, 116, 252, 24, 255, 42, 232, 100, 21, 49, 236, 210, 215, 100, 88, 73, 206, 96, 189, 68, 24, 192, 168, 81, 36, 147, 164, 228 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobPostReviewStatus",
                table: "JobPosts");

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
        }
    }
}
