using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPremium : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPremium",
                table: "Users",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PremiumExpireDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true);

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
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt", "PremiumExpireDate" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(827), null, new byte[] { 176, 204, 22, 193, 214, 174, 201, 46, 37, 86, 87, 48, 22, 60, 236, 9, 35, 13, 231, 76, 203, 181, 136, 25, 101, 162, 252, 40, 208, 47, 136, 138, 198, 186, 76, 123, 137, 85, 143, 79, 213, 250, 247, 118, 98, 76, 239, 156, 136, 136, 172, 176, 15, 98, 111, 242, 205, 20, 15, 39, 146, 212, 99, 240 }, new byte[] { 15, 89, 67, 88, 242, 132, 168, 103, 144, 25, 47, 190, 21, 103, 9, 175, 172, 141, 87, 252, 16, 222, 45, 15, 136, 200, 71, 223, 124, 175, 215, 44, 19, 48, 204, 239, 88, 87, 201, 5, 21, 166, 250, 57, 202, 94, 40, 192, 151, 150, 58, 3, 177, 13, 209, 198, 131, 192, 123, 111, 2, 62, 114, 206, 140, 55, 50, 37, 194, 220, 61, 94, 31, 174, 155, 125, 123, 81, 135, 186, 236, 196, 36, 194, 254, 203, 115, 150, 192, 36, 105, 161, 108, 94, 70, 189, 142, 98, 245, 207, 73, 112, 159, 189, 152, 158, 110, 16, 81, 15, 74, 189, 109, 43, 233, 184, 93, 106, 17, 216, 232, 10, 144, 33, 147, 56, 186, 205 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt", "PremiumExpireDate" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(833), null, new byte[] { 130, 239, 66, 170, 154, 95, 158, 48, 24, 223, 86, 175, 47, 128, 247, 233, 147, 120, 159, 76, 123, 195, 133, 33, 135, 218, 68, 75, 146, 143, 39, 24, 48, 202, 208, 238, 28, 214, 84, 166, 180, 143, 7, 20, 53, 138, 148, 172, 181, 214, 36, 31, 187, 216, 241, 35, 238, 204, 143, 21, 177, 142, 234, 95 }, new byte[] { 194, 249, 32, 171, 233, 224, 230, 23, 130, 92, 185, 99, 31, 165, 14, 253, 36, 37, 122, 86, 94, 42, 78, 102, 150, 145, 88, 188, 249, 59, 223, 136, 120, 180, 13, 17, 16, 184, 152, 167, 14, 247, 164, 211, 249, 74, 113, 113, 82, 171, 70, 133, 0, 142, 228, 123, 48, 53, 26, 170, 23, 104, 34, 167, 214, 198, 224, 74, 6, 81, 210, 26, 219, 161, 184, 105, 173, 83, 114, 148, 234, 49, 127, 6, 220, 149, 184, 77, 61, 90, 58, 229, 189, 54, 7, 233, 94, 231, 126, 142, 13, 2, 148, 150, 90, 33, 137, 114, 29, 20, 17, 167, 126, 184, 151, 108, 76, 181, 116, 225, 90, 119, 153, 81, 170, 125, 21, 155 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt", "PremiumExpireDate" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(835), null, new byte[] { 57, 21, 54, 13, 0, 248, 158, 84, 121, 79, 99, 226, 111, 179, 117, 45, 152, 22, 73, 190, 14, 221, 211, 114, 50, 21, 176, 23, 204, 101, 164, 15, 147, 200, 247, 23, 101, 80, 236, 201, 86, 140, 9, 96, 52, 226, 187, 222, 185, 203, 196, 225, 119, 119, 55, 37, 207, 155, 106, 157, 106, 39, 113, 104 }, new byte[] { 89, 168, 199, 244, 105, 172, 73, 254, 80, 19, 241, 168, 117, 80, 167, 62, 122, 47, 223, 37, 110, 209, 207, 29, 79, 236, 234, 185, 246, 153, 55, 212, 15, 170, 102, 10, 36, 42, 186, 159, 246, 204, 55, 172, 149, 204, 34, 198, 61, 73, 19, 86, 138, 148, 154, 194, 15, 194, 98, 172, 94, 17, 182, 177, 193, 172, 115, 68, 215, 151, 90, 68, 63, 96, 135, 34, 97, 178, 91, 177, 24, 104, 133, 216, 137, 91, 45, 112, 211, 107, 81, 245, 164, 56, 230, 249, 3, 186, 115, 61, 26, 80, 126, 20, 192, 31, 134, 62, 253, 143, 221, 195, 90, 23, 182, 209, 123, 247, 2, 113, 59, 75, 148, 64, 42, 53, 202, 155 }, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsPremium", "PasswordHash", "PasswordSalt", "PremiumExpireDate" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 57, 58, 96, DateTimeKind.Utc).AddTicks(837), null, new byte[] { 190, 35, 158, 148, 169, 80, 58, 53, 44, 97, 198, 47, 15, 92, 67, 21, 224, 117, 106, 145, 255, 130, 186, 162, 96, 138, 208, 145, 157, 47, 122, 45, 215, 49, 172, 16, 126, 62, 89, 45, 65, 164, 8, 182, 18, 102, 40, 14, 238, 247, 75, 173, 99, 6, 38, 48, 51, 191, 83, 55, 238, 28, 66, 189 }, new byte[] { 179, 139, 59, 120, 157, 202, 125, 44, 181, 78, 228, 161, 210, 223, 115, 30, 132, 144, 51, 225, 247, 118, 96, 81, 92, 254, 190, 188, 64, 15, 180, 182, 169, 243, 90, 164, 150, 115, 225, 57, 0, 214, 43, 175, 45, 121, 65, 123, 149, 114, 247, 93, 181, 204, 38, 69, 32, 65, 163, 108, 148, 238, 59, 179, 11, 93, 244, 91, 125, 122, 242, 64, 65, 40, 117, 167, 254, 175, 137, 38, 7, 239, 129, 8, 157, 186, 66, 183, 64, 248, 99, 2, 168, 124, 17, 130, 116, 153, 80, 51, 177, 72, 141, 172, 15, 234, 122, 11, 135, 93, 220, 221, 136, 188, 237, 160, 116, 186, 208, 37, 33, 28, 232, 4, 27, 210, 150, 86 }, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPremium",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PremiumExpireDate",
                table: "Users");

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
    }
}
