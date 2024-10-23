using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyIdToEmailVerifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "EmailVerifications",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 217, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 217, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 16, 23, 22, 217, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(5289), new byte[] { 3, 73, 118, 237, 147, 156, 43, 54, 119, 213, 26, 143, 161, 249, 37, 159, 139, 38, 87, 106, 0, 214, 225, 152, 208, 194, 126, 8, 147, 217, 47, 51, 162, 192, 246, 198, 176, 20, 61, 92, 184, 8, 82, 254, 230, 132, 205, 98, 23, 57, 88, 117, 183, 179, 72, 176, 179, 183, 153, 171, 24, 112, 194, 106 }, new byte[] { 154, 179, 217, 233, 174, 220, 158, 72, 27, 235, 114, 65, 6, 90, 83, 160, 232, 67, 64, 166, 117, 210, 34, 198, 25, 40, 158, 233, 109, 50, 150, 72, 158, 177, 48, 89, 5, 156, 158, 122, 246, 219, 147, 244, 1, 198, 42, 23, 224, 212, 77, 104, 232, 65, 107, 229, 28, 181, 144, 247, 186, 184, 131, 74, 11, 102, 114, 192, 142, 19, 139, 4, 12, 124, 138, 55, 138, 70, 189, 152, 219, 109, 137, 244, 6, 193, 94, 155, 27, 3, 61, 158, 51, 229, 189, 173, 115, 10, 91, 21, 215, 155, 71, 61, 66, 149, 74, 90, 253, 253, 234, 174, 170, 47, 200, 183, 72, 21, 182, 43, 112, 221, 16, 30, 17, 85, 236, 60 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(5296), new byte[] { 50, 226, 162, 208, 192, 227, 120, 229, 166, 64, 70, 181, 47, 32, 125, 41, 195, 139, 162, 55, 116, 224, 159, 168, 19, 26, 109, 156, 157, 170, 135, 107, 90, 213, 161, 251, 103, 126, 175, 182, 245, 67, 223, 73, 111, 38, 61, 235, 144, 209, 79, 19, 6, 136, 224, 135, 120, 111, 205, 96, 233, 59, 31, 180 }, new byte[] { 67, 255, 134, 127, 43, 124, 145, 96, 61, 81, 132, 189, 31, 128, 235, 173, 120, 124, 145, 52, 152, 228, 33, 87, 124, 101, 170, 254, 138, 1, 246, 87, 82, 122, 189, 94, 38, 73, 50, 232, 29, 255, 68, 11, 12, 105, 183, 77, 2, 239, 123, 2, 254, 29, 76, 97, 58, 187, 186, 70, 186, 106, 207, 143, 70, 184, 0, 46, 15, 54, 162, 158, 244, 208, 122, 98, 216, 121, 113, 151, 174, 82, 112, 8, 193, 211, 117, 161, 162, 229, 5, 116, 8, 236, 134, 244, 161, 52, 136, 92, 22, 195, 147, 234, 163, 144, 129, 67, 44, 100, 21, 81, 252, 190, 4, 183, 117, 23, 92, 93, 171, 173, 134, 202, 131, 95, 55, 27 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(5298), new byte[] { 146, 59, 214, 141, 231, 197, 228, 161, 48, 34, 153, 27, 71, 224, 119, 2, 204, 102, 247, 140, 76, 194, 125, 183, 77, 14, 227, 52, 165, 205, 200, 251, 125, 188, 244, 246, 209, 140, 211, 55, 153, 251, 140, 73, 149, 223, 154, 166, 83, 216, 218, 140, 60, 6, 129, 20, 149, 183, 158, 26, 232, 180, 44, 243 }, new byte[] { 111, 171, 104, 76, 43, 107, 210, 23, 5, 67, 217, 123, 218, 107, 253, 110, 180, 105, 143, 99, 242, 141, 101, 41, 48, 142, 61, 91, 182, 62, 97, 206, 238, 107, 209, 93, 47, 129, 33, 132, 25, 133, 230, 182, 146, 63, 70, 104, 245, 49, 216, 162, 248, 67, 216, 150, 4, 238, 222, 13, 124, 13, 139, 164, 75, 57, 118, 128, 153, 20, 15, 16, 52, 159, 210, 51, 70, 15, 221, 131, 17, 68, 192, 138, 33, 63, 185, 35, 64, 51, 25, 178, 168, 56, 98, 178, 77, 234, 4, 22, 202, 39, 127, 141, 238, 166, 90, 125, 176, 205, 56, 184, 98, 211, 201, 110, 91, 10, 1, 248, 143, 47, 230, 200, 222, 3, 115, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 23, 22, 216, DateTimeKind.Utc).AddTicks(5299), new byte[] { 94, 101, 246, 122, 177, 46, 5, 229, 241, 234, 217, 138, 254, 110, 30, 1, 127, 188, 72, 166, 238, 228, 15, 234, 125, 142, 40, 101, 167, 246, 208, 72, 105, 128, 95, 12, 135, 149, 236, 80, 248, 194, 3, 50, 8, 163, 7, 104, 222, 42, 208, 154, 36, 13, 95, 31, 172, 44, 191, 209, 191, 216, 156, 82 }, new byte[] { 208, 93, 180, 193, 160, 83, 222, 88, 133, 90, 60, 120, 102, 219, 214, 195, 26, 227, 184, 240, 37, 226, 107, 31, 90, 56, 51, 25, 28, 6, 160, 129, 194, 80, 206, 185, 73, 134, 126, 2, 123, 193, 249, 121, 62, 155, 83, 13, 233, 155, 252, 58, 90, 67, 32, 156, 250, 206, 169, 126, 251, 15, 241, 170, 124, 154, 122, 115, 37, 166, 68, 166, 136, 4, 74, 250, 105, 135, 180, 195, 79, 217, 129, 40, 252, 248, 185, 7, 207, 53, 90, 60, 252, 234, 182, 91, 120, 58, 22, 170, 40, 184, 194, 11, 11, 53, 8, 105, 107, 84, 225, 5, 31, 72, 40, 139, 134, 74, 33, 178, 189, 100, 203, 72, 152, 23, 199, 100 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerifications_CompanyId",
                table: "EmailVerifications",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailVerifications_Companys_CompanyId",
                table: "EmailVerifications",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailVerifications_Companys_CompanyId",
                table: "EmailVerifications");

            migrationBuilder.DropIndex(
                name: "IX_EmailVerifications_CompanyId",
                table: "EmailVerifications");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "EmailVerifications");

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
