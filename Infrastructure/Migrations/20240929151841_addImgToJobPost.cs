using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addImgToJobPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "JobPosts",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 471, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 471, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 29, 15, 18, 41, 471, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(6006), new byte[] { 24, 48, 177, 247, 55, 63, 215, 22, 46, 6, 71, 179, 31, 234, 72, 45, 17, 138, 12, 93, 106, 93, 87, 249, 186, 31, 41, 195, 198, 209, 146, 21, 78, 211, 71, 209, 59, 134, 94, 146, 178, 47, 254, 99, 136, 44, 137, 96, 195, 42, 163, 235, 47, 34, 218, 196, 87, 65, 255, 192, 47, 24, 153, 75 }, new byte[] { 157, 137, 152, 233, 72, 31, 148, 105, 28, 212, 238, 119, 51, 191, 255, 131, 59, 124, 106, 238, 76, 33, 165, 222, 177, 181, 131, 138, 163, 103, 153, 153, 131, 87, 9, 159, 252, 11, 205, 255, 22, 36, 86, 50, 108, 147, 227, 239, 14, 160, 218, 171, 107, 202, 211, 13, 161, 80, 57, 255, 235, 163, 250, 24, 67, 162, 228, 128, 255, 178, 168, 221, 50, 241, 242, 95, 190, 227, 45, 25, 131, 69, 55, 134, 109, 91, 79, 56, 111, 82, 248, 215, 34, 143, 242, 30, 173, 159, 78, 139, 124, 170, 51, 132, 155, 72, 91, 170, 236, 198, 32, 190, 231, 231, 170, 96, 28, 3, 52, 3, 228, 81, 64, 110, 252, 136, 254, 251 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(6068), new byte[] { 9, 180, 226, 172, 194, 75, 172, 206, 114, 162, 0, 156, 150, 184, 92, 105, 36, 166, 24, 0, 15, 163, 72, 96, 197, 80, 95, 100, 125, 173, 218, 77, 206, 28, 138, 114, 183, 220, 99, 153, 51, 176, 173, 128, 189, 244, 134, 208, 177, 3, 146, 153, 38, 29, 151, 40, 205, 46, 191, 17, 157, 169, 152, 83 }, new byte[] { 114, 155, 187, 12, 57, 237, 127, 120, 253, 154, 186, 249, 105, 226, 129, 220, 133, 59, 216, 154, 196, 155, 90, 223, 227, 15, 52, 170, 38, 78, 30, 250, 100, 168, 208, 143, 156, 119, 43, 178, 92, 234, 68, 148, 23, 13, 52, 39, 22, 2, 216, 149, 174, 34, 82, 232, 58, 60, 39, 65, 189, 167, 211, 222, 125, 81, 65, 110, 232, 248, 181, 178, 230, 65, 167, 147, 171, 143, 10, 147, 177, 122, 242, 20, 107, 252, 178, 17, 250, 152, 1, 171, 129, 89, 77, 83, 55, 198, 138, 85, 152, 113, 200, 124, 220, 178, 105, 250, 192, 123, 255, 29, 74, 229, 244, 88, 22, 74, 208, 121, 116, 144, 249, 233, 126, 149, 186, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(6071), new byte[] { 39, 95, 121, 223, 18, 113, 172, 71, 4, 203, 58, 226, 255, 8, 153, 172, 3, 130, 141, 7, 17, 49, 232, 27, 138, 130, 183, 59, 43, 122, 241, 178, 62, 176, 157, 55, 247, 179, 176, 138, 156, 11, 24, 184, 22, 54, 17, 132, 55, 175, 160, 90, 47, 144, 8, 13, 23, 221, 157, 9, 116, 96, 100, 12 }, new byte[] { 203, 197, 226, 78, 224, 118, 1, 175, 127, 218, 4, 190, 107, 228, 201, 212, 84, 129, 95, 213, 18, 13, 229, 6, 187, 157, 72, 113, 204, 34, 214, 79, 26, 144, 30, 130, 44, 63, 63, 153, 166, 67, 237, 101, 54, 82, 29, 106, 87, 248, 105, 170, 11, 200, 245, 124, 116, 202, 102, 40, 137, 40, 21, 114, 108, 57, 193, 29, 78, 157, 187, 30, 154, 124, 175, 114, 207, 243, 82, 113, 188, 208, 73, 7, 58, 178, 108, 121, 245, 58, 237, 122, 89, 89, 133, 101, 126, 51, 142, 152, 234, 171, 176, 252, 159, 26, 152, 28, 141, 41, 38, 56, 4, 44, 137, 21, 201, 239, 155, 88, 189, 3, 197, 14, 214, 217, 147, 19 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 18, 41, 470, DateTimeKind.Utc).AddTicks(6072), new byte[] { 177, 173, 58, 96, 228, 30, 177, 27, 116, 142, 114, 246, 69, 137, 70, 24, 234, 77, 223, 236, 255, 58, 208, 53, 3, 153, 89, 105, 43, 130, 152, 151, 195, 143, 177, 92, 8, 252, 206, 158, 18, 47, 156, 201, 77, 113, 182, 151, 166, 199, 174, 52, 42, 179, 141, 41, 222, 9, 8, 255, 67, 210, 22, 29 }, new byte[] { 23, 6, 14, 22, 165, 29, 158, 109, 149, 187, 35, 138, 173, 96, 69, 187, 202, 37, 114, 77, 170, 72, 35, 192, 215, 184, 15, 8, 162, 26, 154, 174, 179, 172, 82, 59, 105, 10, 180, 144, 58, 142, 102, 168, 223, 202, 176, 30, 67, 191, 59, 40, 166, 50, 34, 65, 149, 107, 48, 232, 36, 142, 199, 206, 5, 196, 198, 244, 129, 136, 242, 155, 247, 6, 7, 217, 134, 118, 0, 188, 223, 30, 253, 146, 96, 239, 27, 25, 93, 12, 41, 20, 168, 142, 121, 12, 243, 189, 138, 93, 247, 24, 69, 215, 252, 3, 190, 92, 216, 55, 188, 143, 15, 155, 158, 158, 92, 250, 222, 170, 2, 114, 216, 44, 33, 228, 156, 1 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "JobPosts");

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
