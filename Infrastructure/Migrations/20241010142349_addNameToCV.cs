using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addNameToCV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CVs",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 529, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 529, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8385), new byte[] { 134, 159, 52, 119, 73, 255, 101, 65, 132, 183, 83, 1, 124, 60, 227, 229, 119, 111, 184, 231, 34, 191, 122, 163, 231, 171, 73, 54, 14, 50, 19, 183, 41, 132, 127, 213, 75, 123, 132, 207, 209, 171, 96, 56, 84, 223, 52, 130, 98, 41, 201, 248, 8, 220, 46, 109, 40, 156, 27, 54, 180, 247, 96, 68 }, new byte[] { 73, 106, 237, 128, 165, 26, 169, 137, 129, 171, 96, 173, 189, 162, 160, 15, 83, 241, 8, 134, 197, 246, 134, 206, 189, 222, 104, 75, 228, 182, 100, 188, 192, 121, 115, 71, 86, 246, 96, 145, 165, 39, 189, 230, 245, 159, 216, 3, 85, 249, 135, 210, 81, 246, 51, 84, 180, 73, 203, 215, 11, 188, 19, 154, 130, 23, 35, 181, 15, 22, 179, 16, 135, 209, 32, 128, 200, 62, 118, 158, 242, 103, 227, 128, 244, 35, 158, 1, 238, 172, 44, 199, 52, 8, 60, 116, 172, 120, 52, 83, 5, 139, 178, 105, 85, 236, 71, 131, 3, 245, 29, 108, 185, 88, 65, 14, 20, 161, 148, 95, 62, 240, 103, 101, 247, 171, 18, 170 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8393), new byte[] { 166, 222, 215, 6, 42, 184, 99, 155, 160, 73, 171, 118, 166, 80, 25, 34, 245, 205, 124, 69, 96, 219, 204, 91, 164, 206, 211, 1, 137, 124, 229, 224, 2, 187, 244, 237, 12, 208, 214, 106, 66, 69, 139, 204, 101, 71, 84, 185, 72, 21, 253, 99, 137, 231, 217, 168, 241, 38, 255, 53, 129, 228, 216, 24 }, new byte[] { 223, 175, 15, 222, 239, 115, 74, 113, 140, 120, 49, 61, 116, 18, 22, 69, 163, 184, 117, 4, 214, 163, 12, 226, 30, 184, 69, 122, 50, 223, 111, 32, 180, 168, 21, 191, 41, 93, 47, 18, 28, 52, 171, 165, 31, 33, 140, 58, 175, 195, 210, 121, 211, 178, 222, 216, 220, 222, 242, 171, 188, 84, 204, 143, 113, 69, 158, 116, 211, 144, 183, 20, 39, 226, 27, 49, 93, 189, 1, 47, 205, 216, 254, 10, 202, 24, 191, 2, 148, 190, 210, 151, 73, 99, 110, 213, 107, 58, 230, 61, 79, 69, 164, 44, 113, 111, 46, 144, 242, 78, 181, 124, 16, 34, 148, 191, 9, 253, 34, 77, 6, 55, 187, 105, 94, 185, 109, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8395), new byte[] { 180, 74, 124, 42, 241, 29, 222, 230, 200, 88, 7, 121, 219, 144, 72, 20, 34, 120, 178, 43, 169, 2, 154, 233, 204, 140, 241, 145, 195, 220, 114, 248, 148, 216, 161, 255, 147, 127, 94, 136, 125, 119, 191, 143, 197, 135, 102, 111, 208, 170, 123, 93, 226, 8, 0, 75, 124, 56, 80, 197, 79, 82, 255, 45 }, new byte[] { 209, 217, 175, 162, 71, 34, 227, 165, 25, 227, 114, 107, 161, 96, 222, 183, 164, 82, 172, 9, 54, 135, 200, 122, 92, 146, 124, 206, 184, 252, 252, 243, 83, 116, 94, 251, 122, 229, 254, 9, 86, 36, 205, 197, 98, 16, 76, 11, 132, 84, 185, 154, 97, 6, 221, 56, 172, 171, 103, 208, 16, 194, 124, 189, 40, 117, 71, 157, 154, 108, 147, 204, 42, 25, 29, 154, 113, 164, 250, 8, 37, 231, 111, 63, 100, 123, 101, 154, 152, 162, 103, 11, 87, 166, 90, 216, 157, 34, 233, 114, 204, 226, 61, 43, 52, 217, 141, 14, 84, 187, 59, 213, 240, 224, 164, 41, 92, 216, 154, 224, 2, 157, 53, 221, 227, 252, 10, 60 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8397), new byte[] { 114, 138, 202, 19, 3, 147, 56, 191, 27, 47, 151, 34, 168, 12, 148, 118, 157, 227, 131, 109, 201, 16, 209, 168, 30, 155, 143, 212, 110, 50, 98, 18, 143, 132, 105, 89, 63, 1, 69, 100, 90, 225, 135, 146, 240, 87, 129, 243, 67, 163, 249, 76, 90, 10, 251, 244, 225, 83, 181, 148, 208, 121, 28, 128 }, new byte[] { 87, 11, 203, 221, 107, 35, 104, 17, 44, 209, 76, 253, 198, 68, 251, 154, 209, 56, 107, 109, 80, 160, 245, 202, 36, 134, 99, 174, 100, 12, 1, 240, 223, 105, 254, 147, 244, 203, 147, 180, 240, 201, 243, 57, 86, 174, 191, 209, 19, 52, 140, 206, 191, 28, 52, 224, 202, 251, 135, 20, 88, 109, 173, 252, 238, 154, 217, 155, 191, 170, 51, 67, 189, 43, 174, 198, 200, 17, 227, 226, 126, 57, 137, 25, 57, 104, 56, 185, 187, 168, 90, 111, 53, 153, 60, 106, 76, 168, 139, 162, 63, 165, 254, 148, 147, 70, 254, 27, 145, 189, 236, 0, 172, 220, 111, 106, 157, 136, 146, 122, 144, 166, 8, 16, 16, 39, 27, 197 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CVs");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4825), new byte[] { 42, 61, 140, 15, 8, 58, 168, 51, 118, 158, 169, 52, 149, 81, 119, 94, 80, 51, 118, 44, 191, 126, 41, 219, 124, 166, 91, 156, 42, 60, 151, 2, 36, 15, 114, 159, 67, 7, 159, 119, 155, 28, 219, 183, 137, 64, 22, 25, 53, 133, 176, 212, 33, 243, 148, 60, 99, 176, 254, 101, 94, 51, 236, 35 }, new byte[] { 215, 214, 47, 212, 170, 116, 69, 75, 93, 163, 22, 77, 45, 154, 159, 98, 252, 155, 29, 232, 63, 204, 144, 131, 207, 1, 253, 117, 83, 54, 128, 90, 6, 135, 137, 234, 95, 251, 83, 54, 146, 117, 48, 245, 39, 2, 195, 193, 4, 113, 224, 0, 227, 236, 25, 103, 123, 92, 210, 22, 214, 188, 198, 57, 222, 198, 117, 237, 64, 242, 252, 224, 120, 100, 73, 91, 143, 162, 227, 221, 67, 203, 59, 111, 255, 90, 202, 29, 95, 89, 74, 200, 252, 219, 61, 175, 15, 84, 87, 60, 49, 106, 214, 179, 28, 192, 190, 178, 250, 237, 77, 151, 82, 205, 105, 137, 143, 251, 71, 75, 163, 10, 209, 192, 100, 230, 30, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4831), new byte[] { 160, 82, 247, 140, 123, 245, 227, 28, 21, 239, 179, 255, 2, 82, 162, 254, 246, 102, 226, 196, 146, 51, 230, 54, 161, 165, 144, 165, 167, 101, 145, 183, 55, 68, 22, 72, 106, 122, 199, 18, 213, 144, 105, 176, 148, 5, 226, 106, 144, 156, 112, 88, 243, 128, 131, 145, 145, 102, 86, 153, 26, 209, 241, 85 }, new byte[] { 151, 243, 194, 84, 254, 97, 77, 29, 44, 174, 35, 119, 144, 104, 34, 73, 218, 184, 63, 237, 255, 76, 215, 101, 9, 48, 88, 253, 197, 123, 196, 195, 9, 174, 238, 251, 144, 104, 227, 129, 46, 206, 186, 69, 251, 192, 103, 130, 198, 67, 51, 148, 174, 143, 140, 168, 141, 95, 126, 160, 96, 250, 117, 55, 243, 250, 6, 27, 252, 145, 71, 134, 33, 16, 154, 232, 116, 177, 178, 174, 66, 180, 30, 0, 179, 183, 59, 251, 176, 107, 254, 243, 82, 150, 85, 199, 155, 85, 128, 231, 169, 12, 37, 72, 64, 116, 25, 216, 74, 161, 227, 31, 142, 182, 17, 187, 29, 234, 187, 129, 36, 252, 243, 195, 83, 197, 149, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4834), new byte[] { 194, 5, 186, 228, 129, 69, 142, 2, 215, 153, 214, 190, 226, 116, 246, 56, 147, 37, 119, 57, 145, 250, 163, 153, 115, 192, 44, 171, 91, 9, 197, 72, 96, 239, 45, 224, 195, 141, 137, 22, 137, 242, 105, 227, 62, 182, 183, 44, 12, 164, 216, 247, 36, 154, 29, 35, 134, 177, 58, 154, 134, 254, 219, 92 }, new byte[] { 152, 11, 132, 165, 2, 56, 132, 147, 80, 250, 169, 195, 110, 137, 127, 235, 95, 226, 66, 71, 142, 218, 86, 134, 170, 253, 55, 166, 240, 117, 203, 1, 94, 158, 68, 192, 20, 101, 224, 186, 202, 77, 166, 186, 175, 140, 188, 132, 173, 150, 4, 232, 37, 202, 71, 119, 182, 55, 183, 244, 241, 233, 100, 13, 174, 151, 142, 50, 132, 168, 133, 154, 155, 108, 111, 138, 212, 103, 91, 207, 16, 219, 146, 59, 175, 224, 54, 10, 3, 22, 21, 212, 45, 85, 249, 103, 70, 160, 152, 102, 230, 144, 191, 131, 99, 2, 196, 17, 64, 20, 73, 153, 4, 85, 204, 152, 227, 225, 254, 170, 193, 214, 46, 161, 176, 129, 1, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4836), new byte[] { 7, 210, 3, 216, 117, 119, 73, 138, 158, 97, 155, 89, 10, 137, 27, 104, 190, 71, 132, 233, 234, 54, 200, 70, 65, 194, 3, 136, 217, 223, 117, 140, 181, 129, 244, 244, 112, 170, 15, 234, 15, 150, 177, 131, 77, 94, 143, 78, 0, 37, 46, 56, 118, 146, 181, 247, 237, 28, 23, 149, 73, 190, 188, 88 }, new byte[] { 114, 105, 240, 32, 194, 51, 242, 48, 26, 96, 251, 242, 57, 183, 43, 66, 130, 243, 223, 147, 77, 109, 0, 63, 209, 9, 62, 180, 130, 93, 176, 93, 55, 145, 172, 3, 123, 98, 55, 51, 225, 173, 247, 186, 217, 184, 149, 5, 44, 106, 111, 94, 91, 125, 56, 175, 238, 152, 95, 175, 141, 80, 229, 40, 137, 216, 226, 68, 33, 96, 191, 162, 229, 126, 209, 126, 5, 3, 242, 219, 7, 147, 148, 239, 115, 239, 183, 77, 240, 58, 211, 68, 44, 237, 78, 117, 190, 251, 10, 243, 196, 148, 207, 243, 58, 174, 21, 17, 127, 245, 230, 81, 130, 145, 47, 220, 125, 44, 147, 3, 189, 121, 251, 164, 60, 28, 70, 38 } });
        }
    }
}
