using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVectorJobPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float[]>(
                name: "Vector",
                table: "JobPosts",
                type: "real[]",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 14, 27, 34, 627, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(548), new byte[] { 231, 202, 10, 121, 223, 217, 205, 31, 161, 199, 46, 182, 115, 27, 103, 159, 54, 72, 186, 105, 221, 161, 169, 179, 255, 126, 152, 160, 135, 208, 234, 40, 149, 52, 63, 180, 112, 163, 133, 77, 156, 222, 175, 182, 167, 51, 143, 227, 251, 25, 50, 54, 219, 103, 146, 250, 101, 107, 111, 33, 199, 15, 116, 75 }, new byte[] { 91, 53, 135, 111, 172, 61, 85, 240, 189, 94, 92, 80, 132, 49, 3, 18, 96, 43, 208, 61, 237, 62, 137, 10, 53, 161, 143, 156, 197, 76, 220, 131, 155, 120, 73, 32, 74, 168, 145, 241, 231, 103, 198, 22, 140, 135, 74, 3, 231, 24, 191, 184, 71, 204, 183, 210, 38, 23, 47, 228, 71, 74, 57, 28, 5, 177, 148, 7, 145, 201, 160, 2, 217, 185, 72, 208, 151, 213, 208, 113, 28, 179, 130, 183, 239, 66, 3, 125, 99, 43, 61, 189, 176, 47, 62, 204, 70, 61, 226, 177, 108, 114, 80, 237, 111, 91, 161, 235, 3, 219, 78, 179, 108, 145, 183, 239, 214, 97, 81, 64, 218, 97, 93, 235, 176, 81, 254, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(555), new byte[] { 222, 38, 76, 42, 135, 75, 126, 185, 127, 67, 120, 154, 134, 209, 78, 154, 82, 136, 158, 196, 44, 244, 117, 136, 72, 195, 118, 225, 101, 31, 21, 249, 52, 42, 201, 127, 195, 60, 56, 162, 40, 147, 127, 146, 130, 77, 20, 230, 254, 4, 214, 217, 78, 122, 86, 215, 219, 133, 26, 254, 90, 76, 182, 15 }, new byte[] { 84, 27, 15, 147, 245, 204, 29, 241, 121, 39, 84, 72, 86, 247, 152, 58, 140, 18, 133, 133, 131, 17, 59, 80, 104, 255, 110, 21, 24, 196, 34, 152, 143, 146, 42, 2, 151, 133, 26, 222, 238, 138, 72, 176, 41, 172, 14, 246, 205, 143, 193, 199, 105, 45, 71, 88, 146, 21, 100, 15, 251, 101, 224, 227, 104, 240, 191, 17, 45, 99, 179, 47, 94, 105, 104, 217, 74, 240, 174, 138, 250, 22, 223, 172, 45, 59, 198, 178, 170, 154, 210, 147, 59, 241, 219, 195, 59, 192, 186, 128, 135, 168, 124, 99, 157, 210, 245, 171, 183, 132, 134, 222, 178, 2, 33, 183, 246, 163, 109, 6, 169, 70, 206, 129, 7, 171, 24, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(557), new byte[] { 167, 59, 214, 54, 253, 44, 183, 113, 249, 244, 144, 135, 221, 222, 191, 89, 170, 86, 54, 106, 27, 178, 239, 79, 25, 95, 138, 186, 164, 33, 156, 221, 8, 84, 195, 178, 107, 188, 72, 77, 145, 172, 30, 17, 224, 42, 1, 194, 241, 43, 209, 67, 207, 183, 205, 161, 34, 54, 120, 49, 140, 236, 21, 120 }, new byte[] { 245, 0, 79, 30, 198, 223, 174, 19, 196, 57, 178, 69, 216, 126, 148, 123, 175, 158, 142, 53, 251, 130, 173, 151, 60, 125, 127, 61, 146, 55, 213, 200, 189, 39, 84, 32, 19, 171, 63, 195, 64, 255, 162, 151, 154, 150, 100, 73, 184, 244, 121, 230, 132, 22, 249, 242, 7, 102, 134, 102, 88, 205, 132, 159, 26, 156, 218, 209, 222, 191, 246, 54, 190, 141, 18, 56, 181, 228, 12, 175, 45, 54, 189, 73, 18, 45, 74, 198, 86, 71, 211, 243, 200, 187, 4, 113, 133, 179, 113, 253, 36, 137, 164, 36, 196, 109, 195, 120, 40, 209, 49, 49, 64, 52, 104, 76, 215, 132, 137, 86, 138, 6, 140, 12, 157, 156, 147, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 9, 14, 27, 34, 626, DateTimeKind.Utc).AddTicks(558), new byte[] { 158, 106, 11, 87, 132, 239, 215, 2, 18, 73, 130, 225, 167, 102, 219, 23, 17, 167, 38, 164, 115, 209, 29, 44, 77, 81, 140, 96, 151, 231, 208, 234, 141, 238, 132, 72, 23, 59, 17, 55, 206, 240, 125, 112, 133, 38, 128, 60, 37, 14, 241, 150, 147, 169, 35, 247, 69, 135, 254, 180, 237, 46, 232, 248 }, new byte[] { 145, 229, 82, 133, 25, 111, 213, 8, 233, 38, 85, 138, 9, 4, 61, 91, 167, 220, 137, 181, 181, 32, 127, 133, 82, 35, 71, 194, 28, 202, 26, 70, 233, 166, 226, 48, 124, 113, 42, 116, 132, 64, 254, 155, 51, 0, 50, 50, 193, 92, 221, 131, 52, 223, 116, 193, 63, 240, 102, 2, 136, 175, 146, 90, 186, 153, 177, 138, 199, 235, 203, 82, 168, 192, 85, 184, 225, 57, 185, 56, 213, 42, 167, 209, 43, 4, 236, 141, 217, 177, 109, 255, 93, 139, 247, 4, 86, 32, 138, 12, 114, 162, 89, 127, 24, 250, 244, 211, 92, 134, 178, 5, 221, 27, 111, 39, 197, 62, 22, 84, 241, 41, 30, 119, 87, 26, 134, 238 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vector",
                table: "JobPosts");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 99, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 99, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 6, 15, 57, 58, 99, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(827), new byte[] { 176, 204, 22, 193, 214, 174, 201, 46, 37, 86, 87, 48, 22, 60, 236, 9, 35, 13, 231, 76, 203, 181, 136, 25, 101, 162, 252, 40, 208, 47, 136, 138, 198, 186, 76, 123, 137, 85, 143, 79, 213, 250, 247, 118, 98, 76, 239, 156, 136, 136, 172, 176, 15, 98, 111, 242, 205, 20, 15, 39, 146, 212, 99, 240 }, new byte[] { 15, 89, 67, 88, 242, 132, 168, 103, 144, 25, 47, 190, 21, 103, 9, 175, 172, 141, 87, 252, 16, 222, 45, 15, 136, 200, 71, 223, 124, 175, 215, 44, 19, 48, 204, 239, 88, 87, 201, 5, 21, 166, 250, 57, 202, 94, 40, 192, 151, 150, 58, 3, 177, 13, 209, 198, 131, 192, 123, 111, 2, 62, 114, 206, 140, 55, 50, 37, 194, 220, 61, 94, 31, 174, 155, 125, 123, 81, 135, 186, 236, 196, 36, 194, 254, 203, 115, 150, 192, 36, 105, 161, 108, 94, 70, 189, 142, 98, 245, 207, 73, 112, 159, 189, 152, 158, 110, 16, 81, 15, 74, 189, 109, 43, 233, 184, 93, 106, 17, 216, 232, 10, 144, 33, 147, 56, 186, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(833), new byte[] { 130, 239, 66, 170, 154, 95, 158, 48, 24, 223, 86, 175, 47, 128, 247, 233, 147, 120, 159, 76, 123, 195, 133, 33, 135, 218, 68, 75, 146, 143, 39, 24, 48, 202, 208, 238, 28, 214, 84, 166, 180, 143, 7, 20, 53, 138, 148, 172, 181, 214, 36, 31, 187, 216, 241, 35, 238, 204, 143, 21, 177, 142, 234, 95 }, new byte[] { 194, 249, 32, 171, 233, 224, 230, 23, 130, 92, 185, 99, 31, 165, 14, 253, 36, 37, 122, 86, 94, 42, 78, 102, 150, 145, 88, 188, 249, 59, 223, 136, 120, 180, 13, 17, 16, 184, 152, 167, 14, 247, 164, 211, 249, 74, 113, 113, 82, 171, 70, 133, 0, 142, 228, 123, 48, 53, 26, 170, 23, 104, 34, 167, 214, 198, 224, 74, 6, 81, 210, 26, 219, 161, 184, 105, 173, 83, 114, 148, 234, 49, 127, 6, 220, 149, 184, 77, 61, 90, 58, 229, 189, 54, 7, 233, 94, 231, 126, 142, 13, 2, 148, 150, 90, 33, 137, 114, 29, 20, 17, 167, 126, 184, 151, 108, 76, 181, 116, 225, 90, 119, 153, 81, 170, 125, 21, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(835), new byte[] { 57, 21, 54, 13, 0, 248, 158, 84, 121, 79, 99, 226, 111, 179, 117, 45, 152, 22, 73, 190, 14, 221, 211, 114, 50, 21, 176, 23, 204, 101, 164, 15, 147, 200, 247, 23, 101, 80, 236, 201, 86, 140, 9, 96, 52, 226, 187, 222, 185, 203, 196, 225, 119, 119, 55, 37, 207, 155, 106, 157, 106, 39, 113, 104 }, new byte[] { 89, 168, 199, 244, 105, 172, 73, 254, 80, 19, 241, 168, 117, 80, 167, 62, 122, 47, 223, 37, 110, 209, 207, 29, 79, 236, 234, 185, 246, 153, 55, 212, 15, 170, 102, 10, 36, 42, 186, 159, 246, 204, 55, 172, 149, 204, 34, 198, 61, 73, 19, 86, 138, 148, 154, 194, 15, 194, 98, 172, 94, 17, 182, 177, 193, 172, 115, 68, 215, 151, 90, 68, 63, 96, 135, 34, 97, 178, 91, 177, 24, 104, 133, 216, 137, 91, 45, 112, 211, 107, 81, 245, 164, 56, 230, 249, 3, 186, 115, 61, 26, 80, 126, 20, 192, 31, 134, 62, 253, 143, 221, 195, 90, 23, 182, 209, 123, 247, 2, 113, 59, 75, 148, 64, 42, 53, 202, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(837), new byte[] { 190, 35, 158, 148, 169, 80, 58, 53, 44, 97, 198, 47, 15, 92, 67, 21, 224, 117, 106, 145, 255, 130, 186, 162, 96, 138, 208, 145, 157, 47, 122, 45, 215, 49, 172, 16, 126, 62, 89, 45, 65, 164, 8, 182, 18, 102, 40, 14, 238, 247, 75, 173, 99, 6, 38, 48, 51, 191, 83, 55, 238, 28, 66, 189 }, new byte[] { 179, 139, 59, 120, 157, 202, 125, 44, 181, 78, 228, 161, 210, 223, 115, 30, 132, 144, 51, 225, 247, 118, 96, 81, 92, 254, 190, 188, 64, 15, 180, 182, 169, 243, 90, 164, 150, 115, 225, 57, 0, 214, 43, 175, 45, 121, 65, 123, 149, 114, 247, 93, 181, 204, 38, 69, 32, 65, 163, 108, 148, 238, 59, 179, 11, 93, 244, 91, 125, 122, 242, 64, 65, 40, 117, 167, 254, 175, 137, 38, 7, 239, 129, 8, 157, 186, 66, 183, 64, 248, 99, 2, 168, 124, 17, 130, 116, 153, 80, 51, 177, 72, 141, 172, 15, 234, 122, 11, 135, 93, 220, 221, 136, 188, 237, 160, 116, 186, 208, 37, 33, 28, 232, 4, 27, 210, 150, 86 } });
        }
    }
}
