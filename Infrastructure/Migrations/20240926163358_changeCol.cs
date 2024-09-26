using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillLevelRequired",
                table: "JobSkillSets");

            migrationBuilder.AlterColumn<string>(
                name: "QualificationRequired",
                table: "JobPosts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "JobPosts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 16, 33, 58, 532, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4661), new byte[] { 197, 133, 141, 225, 116, 63, 17, 93, 204, 26, 62, 21, 149, 196, 126, 68, 72, 159, 167, 168, 116, 10, 228, 243, 206, 4, 92, 46, 50, 103, 212, 40, 230, 137, 166, 109, 167, 172, 182, 195, 225, 248, 68, 35, 161, 22, 106, 133, 36, 14, 140, 107, 36, 126, 144, 122, 127, 44, 243, 231, 103, 194, 163, 199 }, new byte[] { 125, 252, 120, 169, 212, 102, 58, 223, 233, 111, 119, 14, 150, 21, 62, 62, 193, 101, 217, 161, 107, 130, 200, 211, 127, 171, 74, 70, 170, 201, 53, 90, 136, 59, 22, 216, 80, 91, 91, 251, 201, 125, 12, 60, 60, 150, 139, 0, 81, 161, 142, 243, 128, 102, 151, 19, 118, 130, 99, 126, 65, 126, 44, 85, 85, 129, 35, 249, 233, 254, 70, 173, 46, 197, 195, 11, 226, 233, 113, 107, 53, 61, 59, 131, 186, 230, 118, 145, 65, 18, 34, 142, 248, 245, 111, 3, 190, 253, 123, 0, 9, 45, 146, 3, 226, 66, 254, 125, 122, 34, 249, 25, 8, 123, 159, 67, 232, 25, 50, 223, 169, 127, 185, 59, 37, 242, 133, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4670), new byte[] { 35, 165, 35, 175, 36, 134, 13, 3, 94, 65, 43, 141, 210, 84, 66, 183, 107, 55, 16, 113, 37, 10, 9, 203, 25, 56, 211, 131, 108, 36, 37, 134, 114, 123, 133, 223, 173, 255, 220, 64, 207, 22, 218, 86, 255, 94, 187, 20, 165, 174, 46, 46, 166, 122, 80, 210, 188, 232, 205, 251, 233, 143, 171, 19 }, new byte[] { 39, 179, 189, 131, 29, 168, 123, 228, 203, 99, 89, 251, 186, 49, 135, 214, 59, 102, 64, 17, 152, 98, 255, 55, 49, 132, 236, 242, 1, 76, 68, 180, 36, 34, 96, 123, 188, 227, 22, 172, 9, 10, 87, 22, 148, 98, 129, 45, 246, 252, 179, 217, 41, 215, 69, 227, 80, 87, 117, 178, 123, 215, 252, 119, 180, 18, 224, 33, 200, 145, 219, 8, 58, 191, 227, 162, 54, 10, 47, 36, 133, 73, 126, 113, 247, 171, 132, 187, 122, 14, 215, 205, 64, 211, 179, 57, 157, 228, 241, 56, 52, 67, 43, 44, 82, 28, 13, 19, 27, 94, 171, 103, 239, 89, 238, 247, 170, 125, 170, 245, 241, 141, 62, 41, 154, 133, 218, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4673), new byte[] { 83, 163, 239, 104, 121, 220, 89, 124, 5, 77, 203, 19, 170, 180, 207, 9, 103, 72, 177, 33, 8, 38, 54, 94, 230, 177, 122, 71, 241, 113, 50, 82, 4, 82, 129, 10, 80, 67, 109, 104, 78, 231, 149, 86, 168, 0, 157, 162, 141, 224, 37, 95, 227, 68, 75, 74, 156, 246, 38, 61, 28, 164, 203, 208 }, new byte[] { 98, 17, 115, 120, 183, 129, 77, 179, 50, 140, 103, 247, 181, 222, 239, 159, 160, 236, 191, 85, 155, 188, 60, 116, 167, 181, 184, 172, 6, 43, 16, 46, 21, 45, 142, 128, 148, 117, 199, 12, 116, 96, 113, 167, 8, 65, 193, 29, 51, 101, 177, 101, 134, 124, 126, 102, 32, 189, 207, 13, 147, 9, 53, 207, 168, 107, 252, 98, 215, 233, 30, 16, 77, 112, 99, 76, 237, 111, 101, 26, 158, 83, 169, 235, 55, 144, 87, 14, 47, 70, 76, 219, 198, 165, 238, 0, 61, 42, 230, 53, 189, 56, 238, 185, 17, 24, 95, 178, 160, 161, 41, 234, 26, 6, 60, 253, 220, 167, 21, 81, 117, 205, 241, 151, 165, 248, 157, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 33, 58, 531, DateTimeKind.Utc).AddTicks(4675), new byte[] { 99, 224, 22, 143, 122, 162, 196, 65, 93, 23, 223, 223, 186, 118, 216, 20, 8, 44, 58, 109, 232, 161, 100, 82, 146, 193, 198, 169, 132, 208, 99, 57, 175, 55, 184, 153, 96, 8, 10, 6, 44, 121, 216, 126, 95, 243, 227, 238, 187, 246, 202, 221, 180, 104, 46, 40, 101, 16, 199, 17, 23, 6, 127, 153 }, new byte[] { 10, 167, 83, 80, 11, 78, 67, 229, 145, 85, 72, 83, 247, 211, 154, 160, 182, 196, 199, 10, 58, 242, 23, 29, 149, 236, 131, 69, 187, 177, 242, 99, 19, 71, 242, 73, 5, 250, 203, 78, 253, 250, 3, 174, 38, 111, 14, 27, 113, 228, 19, 160, 255, 143, 192, 238, 201, 163, 242, 0, 76, 121, 62, 149, 121, 190, 189, 220, 106, 221, 42, 94, 113, 115, 183, 124, 67, 146, 3, 32, 76, 200, 154, 187, 50, 207, 141, 224, 6, 90, 49, 138, 113, 128, 171, 224, 162, 218, 154, 199, 59, 28, 30, 44, 171, 187, 20, 43, 198, 182, 189, 223, 55, 228, 35, 131, 107, 32, 164, 176, 110, 152, 74, 108, 227, 12, 158, 159 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillLevelRequired",
                table: "JobPosts");

            migrationBuilder.AddColumn<string>(
                name: "SkillLevelRequired",
                table: "JobSkillSets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "QualificationRequired",
                table: "JobPosts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "JobPosts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 15, 43, 14, 547, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4113), new byte[] { 72, 255, 17, 116, 26, 108, 202, 42, 171, 100, 153, 71, 184, 136, 245, 9, 109, 252, 168, 120, 176, 87, 223, 53, 172, 88, 73, 146, 208, 144, 128, 214, 185, 211, 229, 82, 209, 119, 245, 203, 171, 240, 149, 140, 250, 239, 115, 201, 35, 68, 114, 54, 98, 194, 201, 48, 181, 250, 14, 81, 100, 133, 227, 58 }, new byte[] { 209, 72, 111, 223, 217, 107, 72, 229, 176, 3, 159, 66, 157, 60, 174, 161, 143, 163, 89, 78, 52, 148, 198, 100, 199, 187, 139, 105, 60, 130, 194, 7, 70, 247, 185, 147, 2, 37, 51, 92, 188, 148, 168, 226, 167, 55, 194, 172, 7, 89, 12, 81, 34, 249, 6, 163, 70, 149, 110, 153, 124, 148, 244, 60, 52, 53, 179, 11, 155, 209, 227, 21, 110, 20, 166, 20, 134, 141, 149, 226, 35, 54, 236, 80, 106, 161, 135, 174, 158, 16, 110, 19, 22, 99, 202, 96, 89, 1, 89, 77, 38, 214, 241, 230, 116, 125, 192, 251, 209, 166, 154, 199, 86, 67, 55, 54, 141, 93, 72, 247, 198, 133, 14, 0, 145, 111, 70, 197 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4164), new byte[] { 129, 126, 192, 21, 175, 98, 10, 204, 203, 200, 101, 249, 112, 15, 21, 118, 140, 28, 96, 188, 0, 55, 21, 146, 176, 215, 226, 101, 173, 94, 28, 158, 238, 220, 217, 183, 32, 52, 167, 28, 203, 165, 47, 139, 22, 71, 219, 36, 23, 38, 158, 198, 122, 178, 22, 184, 70, 212, 181, 87, 127, 15, 94, 158 }, new byte[] { 86, 51, 88, 71, 53, 170, 31, 7, 104, 165, 217, 117, 172, 38, 188, 110, 32, 190, 231, 133, 180, 198, 0, 33, 27, 107, 67, 251, 200, 68, 62, 113, 225, 195, 141, 232, 35, 170, 26, 134, 77, 161, 169, 47, 243, 71, 35, 68, 221, 240, 134, 142, 225, 93, 83, 252, 16, 112, 3, 163, 9, 28, 140, 93, 254, 245, 103, 203, 27, 76, 83, 65, 242, 197, 213, 110, 133, 111, 107, 192, 137, 138, 52, 33, 46, 12, 55, 212, 27, 117, 149, 154, 227, 64, 241, 75, 180, 63, 238, 91, 252, 39, 237, 202, 35, 37, 193, 181, 194, 249, 198, 222, 212, 218, 78, 110, 27, 7, 67, 0, 3, 230, 4, 202, 26, 222, 162, 96 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4166), new byte[] { 247, 114, 44, 162, 150, 47, 44, 192, 252, 128, 119, 131, 67, 237, 87, 45, 98, 195, 156, 166, 28, 159, 42, 248, 23, 119, 98, 65, 85, 145, 166, 167, 42, 162, 177, 139, 124, 3, 193, 111, 80, 19, 124, 149, 84, 250, 230, 220, 205, 227, 123, 7, 182, 183, 3, 136, 105, 198, 100, 89, 51, 191, 201, 64 }, new byte[] { 63, 138, 121, 131, 18, 90, 178, 206, 110, 46, 161, 145, 223, 88, 137, 0, 23, 115, 221, 160, 157, 164, 38, 60, 142, 218, 153, 35, 140, 213, 49, 200, 215, 76, 91, 136, 56, 65, 0, 80, 92, 196, 94, 230, 189, 3, 200, 18, 187, 208, 26, 211, 144, 213, 105, 22, 127, 218, 45, 206, 122, 90, 146, 146, 103, 115, 114, 46, 43, 239, 221, 30, 32, 17, 215, 4, 228, 40, 242, 24, 113, 233, 71, 155, 156, 103, 191, 45, 46, 91, 193, 177, 56, 53, 26, 44, 203, 54, 226, 97, 123, 239, 26, 254, 18, 6, 179, 53, 31, 236, 157, 30, 33, 243, 127, 226, 199, 249, 111, 84, 96, 148, 246, 144, 46, 174, 159, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 43, 14, 546, DateTimeKind.Utc).AddTicks(4167), new byte[] { 253, 43, 96, 206, 50, 75, 122, 150, 21, 205, 159, 12, 49, 145, 174, 79, 98, 103, 165, 182, 140, 203, 47, 59, 67, 67, 104, 35, 236, 111, 20, 176, 64, 166, 126, 192, 151, 169, 40, 43, 196, 166, 27, 190, 31, 89, 201, 247, 96, 74, 61, 216, 201, 96, 17, 145, 84, 177, 182, 153, 144, 243, 7, 209 }, new byte[] { 119, 90, 184, 84, 52, 84, 80, 96, 7, 210, 97, 197, 96, 4, 217, 160, 134, 245, 154, 5, 255, 122, 114, 171, 102, 136, 155, 145, 137, 49, 209, 177, 100, 205, 207, 236, 54, 80, 41, 179, 73, 165, 51, 85, 173, 149, 94, 159, 152, 54, 117, 243, 102, 178, 78, 86, 66, 53, 233, 219, 234, 254, 134, 55, 247, 22, 83, 129, 4, 200, 87, 30, 151, 89, 71, 221, 70, 122, 106, 71, 26, 146, 224, 162, 209, 62, 74, 193, 120, 164, 15, 206, 196, 215, 200, 174, 190, 96, 67, 225, 9, 122, 143, 158, 201, 30, 192, 63, 94, 204, 196, 116, 250, 71, 125, 223, 144, 223, 85, 79, 245, 13, 90, 175, 140, 202, 85, 248 } });
        }
    }
}
