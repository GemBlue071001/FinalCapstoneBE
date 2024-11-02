using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeSkillLvReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillLevelRequired",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 530, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 530, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 2, 18, 0, 46, 530, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(6302), new byte[] { 18, 209, 31, 20, 35, 131, 145, 81, 28, 117, 163, 69, 191, 90, 121, 75, 156, 164, 176, 25, 155, 145, 246, 44, 243, 131, 60, 45, 21, 120, 81, 251, 189, 222, 199, 6, 106, 150, 132, 44, 210, 135, 0, 237, 241, 159, 35, 43, 124, 84, 147, 83, 162, 200, 116, 196, 73, 20, 212, 146, 248, 252, 50, 215 }, new byte[] { 160, 53, 166, 167, 182, 186, 239, 126, 79, 147, 107, 26, 61, 117, 173, 155, 56, 225, 243, 105, 174, 105, 151, 92, 13, 133, 125, 86, 123, 137, 11, 159, 21, 187, 221, 11, 203, 210, 239, 196, 122, 14, 10, 117, 215, 119, 155, 231, 97, 101, 169, 108, 216, 3, 19, 118, 127, 78, 175, 206, 234, 39, 33, 202, 249, 162, 77, 63, 73, 250, 23, 205, 164, 123, 179, 35, 117, 227, 215, 16, 198, 125, 144, 21, 158, 123, 241, 40, 131, 24, 115, 105, 114, 184, 160, 254, 238, 173, 117, 140, 204, 234, 95, 67, 18, 63, 26, 246, 4, 137, 148, 93, 241, 221, 108, 129, 238, 198, 204, 172, 56, 240, 191, 242, 191, 5, 51, 198 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(6311), new byte[] { 3, 255, 150, 62, 219, 33, 155, 67, 105, 7, 189, 100, 114, 153, 58, 28, 229, 76, 235, 217, 89, 188, 140, 95, 233, 17, 231, 92, 106, 164, 247, 37, 168, 134, 105, 41, 111, 79, 21, 96, 180, 12, 156, 243, 14, 106, 17, 153, 128, 109, 206, 39, 177, 54, 225, 167, 225, 23, 197, 4, 109, 231, 240, 19 }, new byte[] { 68, 94, 207, 31, 84, 69, 90, 224, 69, 44, 61, 179, 178, 168, 142, 179, 248, 244, 187, 72, 22, 92, 130, 195, 161, 98, 78, 22, 109, 61, 12, 9, 245, 203, 68, 77, 157, 76, 126, 0, 12, 81, 148, 168, 165, 151, 221, 192, 115, 205, 232, 187, 120, 11, 89, 77, 86, 16, 229, 107, 173, 106, 18, 210, 222, 211, 83, 156, 26, 40, 22, 56, 174, 251, 4, 125, 197, 17, 51, 225, 174, 10, 59, 108, 187, 31, 121, 100, 212, 12, 124, 255, 89, 144, 155, 248, 202, 3, 86, 254, 216, 166, 211, 202, 169, 246, 118, 43, 176, 23, 21, 63, 25, 107, 177, 227, 214, 116, 214, 3, 144, 254, 35, 14, 95, 58, 92, 3 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(6313), new byte[] { 37, 69, 150, 75, 84, 31, 215, 164, 55, 168, 13, 81, 140, 231, 166, 249, 43, 49, 250, 133, 180, 199, 9, 9, 5, 183, 114, 44, 170, 96, 104, 218, 96, 5, 101, 119, 84, 170, 27, 26, 210, 76, 208, 193, 95, 220, 69, 108, 132, 149, 129, 17, 68, 216, 172, 115, 144, 237, 67, 210, 11, 150, 77, 107 }, new byte[] { 242, 216, 67, 152, 235, 150, 224, 91, 226, 112, 131, 2, 17, 205, 18, 109, 148, 50, 34, 162, 185, 97, 178, 222, 155, 115, 184, 159, 149, 238, 28, 75, 183, 122, 246, 76, 218, 66, 94, 247, 190, 59, 90, 250, 64, 175, 103, 18, 170, 85, 228, 155, 101, 252, 93, 47, 21, 199, 137, 34, 45, 44, 56, 177, 162, 70, 213, 131, 130, 28, 196, 38, 137, 201, 250, 102, 212, 189, 114, 6, 142, 54, 24, 25, 215, 9, 219, 35, 38, 209, 89, 30, 238, 77, 198, 232, 25, 117, 91, 222, 156, 24, 120, 84, 226, 122, 123, 60, 140, 235, 1, 220, 142, 9, 131, 48, 126, 13, 104, 254, 142, 28, 62, 233, 33, 97, 116, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 2, 18, 0, 46, 528, DateTimeKind.Utc).AddTicks(6314), new byte[] { 148, 107, 81, 91, 128, 227, 184, 157, 75, 107, 201, 148, 233, 65, 242, 119, 132, 245, 195, 44, 77, 92, 214, 22, 95, 232, 184, 209, 196, 163, 57, 176, 172, 48, 30, 120, 246, 208, 181, 66, 202, 46, 157, 29, 213, 31, 43, 63, 147, 155, 29, 79, 182, 179, 59, 148, 153, 250, 63, 113, 161, 181, 222, 172 }, new byte[] { 13, 229, 250, 118, 221, 171, 204, 247, 239, 200, 108, 29, 86, 241, 3, 232, 136, 59, 51, 51, 130, 71, 14, 219, 225, 175, 154, 26, 235, 134, 76, 94, 181, 64, 171, 135, 163, 100, 206, 224, 241, 254, 14, 30, 25, 29, 13, 189, 230, 92, 72, 82, 130, 49, 235, 2, 108, 196, 116, 227, 51, 192, 211, 238, 51, 32, 95, 22, 17, 42, 238, 132, 99, 8, 156, 185, 162, 157, 200, 164, 125, 196, 153, 125, 239, 164, 22, 255, 18, 67, 41, 18, 33, 220, 135, 38, 225, 2, 58, 70, 226, 79, 2, 184, 87, 4, 111, 96, 176, 38, 194, 85, 223, 70, 174, 28, 45, 219, 230, 46, 53, 3, 237, 155, 13, 117, 48, 69 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillLevelRequired",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}
