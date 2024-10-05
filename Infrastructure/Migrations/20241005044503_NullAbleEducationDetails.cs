using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NullAbleEducationDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetails_Users_UserId",
                table: "EducationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDetails_Users_UserId",
                table: "ExperienceDetails");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ExperienceDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "EducationDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 89, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 45, 3, 90, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8812), new byte[] { 90, 5, 12, 53, 35, 66, 252, 43, 197, 125, 68, 211, 93, 108, 117, 19, 97, 118, 169, 197, 170, 156, 239, 222, 168, 255, 20, 106, 89, 31, 10, 87, 101, 53, 232, 47, 130, 100, 131, 47, 40, 130, 115, 198, 93, 48, 120, 215, 26, 129, 94, 15, 232, 152, 186, 158, 31, 38, 2, 50, 12, 176, 196, 18 }, new byte[] { 58, 87, 181, 132, 31, 24, 117, 58, 241, 154, 127, 230, 235, 168, 193, 166, 90, 145, 68, 91, 228, 66, 122, 242, 105, 3, 241, 18, 165, 255, 127, 93, 153, 98, 14, 253, 124, 148, 23, 86, 138, 204, 141, 197, 29, 45, 185, 246, 84, 127, 117, 105, 167, 101, 29, 215, 182, 96, 217, 41, 238, 248, 94, 252, 52, 129, 221, 241, 159, 206, 179, 5, 180, 155, 71, 232, 128, 139, 197, 119, 127, 193, 85, 143, 58, 253, 39, 235, 108, 228, 88, 16, 136, 107, 164, 11, 32, 165, 16, 118, 232, 170, 248, 44, 145, 11, 238, 252, 201, 209, 92, 173, 125, 217, 107, 109, 72, 59, 120, 228, 168, 34, 98, 110, 153, 201, 5, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8819), new byte[] { 186, 20, 130, 83, 82, 178, 250, 64, 41, 172, 26, 7, 213, 47, 71, 96, 121, 2, 236, 13, 121, 58, 8, 42, 193, 199, 225, 195, 113, 226, 218, 216, 151, 195, 70, 16, 115, 216, 113, 152, 95, 62, 160, 34, 75, 77, 163, 130, 161, 3, 248, 237, 195, 151, 217, 236, 2, 41, 228, 46, 105, 4, 168, 32 }, new byte[] { 195, 199, 46, 57, 193, 161, 171, 166, 30, 126, 100, 164, 31, 245, 213, 161, 217, 87, 43, 175, 200, 63, 171, 114, 222, 26, 4, 23, 89, 114, 217, 82, 151, 91, 58, 73, 165, 33, 75, 67, 152, 158, 216, 44, 56, 106, 89, 161, 93, 114, 243, 18, 63, 26, 217, 68, 100, 229, 158, 254, 156, 54, 28, 205, 6, 223, 202, 134, 48, 7, 248, 168, 27, 215, 51, 15, 121, 124, 197, 27, 223, 96, 113, 196, 110, 246, 135, 131, 15, 45, 7, 44, 202, 44, 149, 11, 211, 80, 177, 75, 112, 2, 192, 100, 188, 128, 10, 179, 147, 204, 115, 28, 162, 243, 73, 118, 228, 200, 86, 24, 254, 37, 226, 104, 139, 119, 32, 189 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8842), new byte[] { 118, 239, 10, 150, 102, 222, 147, 25, 255, 175, 82, 82, 56, 255, 145, 168, 242, 33, 130, 126, 170, 111, 223, 14, 111, 13, 136, 9, 169, 172, 47, 173, 250, 140, 6, 191, 122, 162, 182, 93, 66, 211, 154, 45, 173, 158, 168, 234, 151, 84, 6, 111, 172, 215, 97, 122, 28, 150, 133, 244, 202, 203, 75, 132 }, new byte[] { 71, 187, 16, 242, 144, 196, 29, 15, 20, 80, 8, 116, 31, 199, 157, 254, 119, 98, 118, 18, 198, 226, 50, 16, 168, 255, 101, 206, 154, 155, 128, 30, 181, 30, 244, 86, 96, 59, 152, 185, 185, 249, 3, 23, 247, 161, 24, 114, 31, 41, 222, 155, 162, 64, 68, 211, 19, 251, 122, 213, 107, 162, 42, 252, 130, 13, 174, 48, 184, 124, 60, 229, 69, 81, 28, 186, 230, 196, 163, 237, 153, 243, 93, 210, 218, 49, 124, 36, 175, 167, 100, 200, 33, 122, 232, 11, 19, 182, 184, 218, 242, 73, 57, 125, 135, 234, 129, 165, 55, 152, 154, 173, 237, 158, 77, 73, 93, 37, 50, 93, 187, 219, 142, 84, 254, 185, 63, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 45, 3, 88, DateTimeKind.Utc).AddTicks(8843), new byte[] { 125, 160, 124, 92, 64, 110, 142, 253, 197, 131, 59, 157, 81, 115, 163, 155, 102, 65, 101, 196, 129, 9, 165, 144, 203, 170, 213, 5, 215, 189, 155, 55, 208, 211, 18, 98, 238, 186, 13, 119, 241, 47, 159, 253, 15, 113, 204, 95, 70, 168, 107, 176, 30, 132, 103, 54, 204, 168, 106, 42, 115, 202, 238, 125 }, new byte[] { 229, 125, 99, 8, 14, 231, 195, 128, 133, 79, 202, 108, 133, 171, 191, 175, 181, 153, 130, 128, 52, 234, 175, 151, 45, 112, 14, 109, 173, 162, 68, 255, 122, 35, 217, 89, 0, 28, 41, 94, 132, 64, 212, 251, 193, 10, 45, 145, 210, 184, 138, 28, 74, 128, 53, 25, 254, 49, 49, 232, 116, 112, 67, 185, 33, 167, 203, 217, 172, 158, 135, 128, 191, 238, 15, 2, 107, 198, 192, 38, 128, 25, 37, 56, 193, 226, 188, 198, 159, 140, 16, 32, 164, 24, 63, 181, 86, 155, 249, 7, 146, 155, 193, 28, 10, 124, 13, 246, 171, 151, 251, 107, 59, 66, 162, 94, 171, 118, 50, 191, 51, 145, 144, 248, 113, 33, 184, 201 } });

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetails_Users_UserId",
                table: "EducationDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDetails_Users_UserId",
                table: "ExperienceDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetails_Users_UserId",
                table: "EducationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDetails_Users_UserId",
                table: "ExperienceDetails");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ExperienceDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "EducationDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9468), new byte[] { 155, 111, 137, 104, 57, 200, 238, 140, 131, 187, 65, 239, 251, 20, 37, 23, 224, 43, 207, 49, 61, 44, 86, 218, 68, 202, 233, 193, 198, 90, 188, 21, 69, 15, 179, 136, 163, 17, 31, 172, 33, 187, 117, 4, 77, 18, 139, 104, 87, 111, 209, 234, 79, 124, 137, 39, 17, 112, 236, 232, 17, 24, 147, 112 }, new byte[] { 174, 71, 119, 29, 113, 0, 20, 32, 234, 158, 108, 50, 160, 110, 188, 65, 37, 150, 109, 165, 38, 45, 39, 249, 197, 251, 97, 169, 241, 161, 165, 34, 137, 214, 199, 82, 56, 134, 229, 197, 3, 132, 214, 202, 145, 138, 17, 223, 254, 101, 125, 180, 20, 118, 217, 62, 90, 239, 175, 87, 137, 172, 234, 96, 61, 210, 217, 24, 254, 54, 167, 7, 254, 40, 190, 144, 76, 143, 111, 232, 8, 156, 222, 231, 84, 169, 196, 158, 82, 52, 246, 198, 237, 72, 150, 118, 54, 48, 72, 241, 19, 3, 130, 50, 208, 34, 72, 120, 238, 74, 195, 42, 82, 233, 241, 82, 197, 161, 17, 178, 35, 36, 46, 173, 51, 206, 34, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9475), new byte[] { 89, 0, 216, 233, 155, 23, 38, 158, 60, 18, 128, 34, 162, 104, 72, 240, 218, 129, 160, 156, 238, 58, 155, 7, 91, 88, 10, 135, 29, 238, 140, 98, 79, 127, 79, 127, 251, 171, 250, 54, 84, 237, 21, 157, 251, 104, 31, 160, 143, 121, 153, 137, 197, 107, 243, 232, 49, 57, 26, 51, 17, 14, 11, 10 }, new byte[] { 45, 187, 175, 246, 125, 46, 198, 31, 233, 174, 61, 194, 43, 70, 187, 83, 76, 167, 173, 29, 229, 154, 115, 251, 52, 162, 76, 239, 206, 111, 130, 226, 82, 51, 40, 89, 13, 124, 230, 44, 158, 197, 68, 219, 152, 176, 7, 8, 208, 221, 48, 217, 50, 214, 26, 11, 16, 237, 190, 96, 193, 39, 193, 22, 220, 35, 38, 122, 65, 36, 41, 63, 235, 188, 128, 90, 166, 22, 91, 134, 204, 206, 152, 97, 70, 252, 201, 41, 140, 187, 13, 31, 229, 148, 164, 193, 110, 207, 63, 233, 249, 59, 59, 229, 91, 106, 38, 130, 221, 76, 117, 119, 0, 255, 129, 33, 253, 130, 140, 203, 221, 139, 252, 202, 116, 77, 58, 162 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9477), new byte[] { 150, 159, 85, 69, 52, 213, 244, 252, 50, 66, 199, 68, 77, 133, 222, 98, 87, 88, 190, 244, 251, 42, 161, 85, 180, 48, 171, 201, 16, 77, 17, 114, 252, 53, 57, 77, 222, 8, 216, 145, 71, 87, 118, 67, 250, 115, 81, 247, 211, 65, 34, 242, 72, 79, 34, 216, 191, 182, 110, 214, 138, 90, 143, 61 }, new byte[] { 97, 166, 15, 161, 81, 30, 12, 231, 234, 125, 44, 192, 103, 64, 61, 183, 70, 142, 216, 212, 210, 45, 32, 186, 62, 206, 4, 11, 68, 113, 205, 68, 229, 27, 224, 193, 154, 107, 116, 194, 187, 101, 200, 246, 159, 34, 146, 245, 248, 108, 178, 59, 213, 205, 21, 225, 146, 7, 159, 108, 164, 93, 218, 25, 246, 207, 105, 193, 6, 49, 45, 143, 225, 46, 248, 213, 133, 100, 63, 25, 19, 230, 223, 11, 139, 214, 237, 87, 7, 58, 211, 42, 177, 3, 95, 81, 66, 95, 81, 145, 242, 196, 147, 115, 75, 229, 98, 24, 157, 145, 187, 128, 169, 239, 160, 153, 63, 180, 152, 168, 224, 135, 123, 153, 136, 222, 23, 182 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9479), new byte[] { 113, 66, 232, 24, 62, 208, 111, 32, 131, 155, 207, 10, 200, 162, 158, 176, 121, 115, 93, 12, 148, 244, 219, 47, 145, 59, 68, 155, 165, 40, 127, 12, 250, 167, 246, 72, 243, 141, 58, 67, 111, 64, 64, 109, 61, 191, 182, 22, 80, 6, 134, 113, 64, 42, 248, 79, 19, 171, 251, 165, 242, 141, 23, 84 }, new byte[] { 181, 218, 124, 85, 23, 196, 61, 138, 193, 195, 161, 53, 7, 63, 20, 175, 79, 222, 27, 119, 115, 195, 103, 118, 95, 208, 125, 235, 120, 79, 39, 155, 251, 241, 135, 8, 7, 138, 204, 100, 115, 3, 156, 50, 202, 126, 173, 146, 11, 133, 67, 212, 9, 209, 139, 114, 28, 136, 117, 95, 131, 112, 56, 155, 213, 156, 85, 84, 116, 108, 162, 159, 107, 105, 255, 98, 131, 250, 234, 50, 209, 251, 223, 91, 79, 117, 3, 48, 211, 54, 69, 192, 33, 66, 154, 51, 243, 249, 189, 211, 154, 62, 199, 34, 233, 184, 96, 111, 116, 40, 57, 175, 52, 140, 243, 48, 99, 111, 26, 27, 201, 23, 135, 3, 175, 181, 40, 22 } });

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetails_Users_UserId",
                table: "EducationDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDetails_Users_UserId",
                table: "ExperienceDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
