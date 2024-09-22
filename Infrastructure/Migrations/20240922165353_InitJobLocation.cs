using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitJobLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_JobLocation_JobLocationId",
                table: "jobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobLocation",
                table: "JobLocation");

            migrationBuilder.RenameTable(
                name: "JobLocation",
                newName: "jobLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobLocations",
                table: "jobLocations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 271, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 271, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 271, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(3434), new byte[] { 92, 237, 147, 130, 129, 25, 238, 159, 72, 7, 244, 35, 144, 87, 44, 97, 143, 186, 183, 72, 48, 13, 226, 152, 171, 236, 166, 228, 123, 246, 77, 78, 53, 151, 179, 63, 202, 232, 158, 140, 11, 160, 109, 28, 26, 41, 101, 30, 194, 223, 60, 124, 224, 69, 176, 195, 224, 209, 240, 159, 150, 248, 58, 23 }, new byte[] { 100, 176, 228, 109, 219, 111, 203, 26, 168, 107, 103, 178, 175, 139, 180, 29, 169, 14, 122, 53, 211, 192, 115, 31, 177, 65, 78, 30, 12, 136, 73, 3, 139, 135, 201, 103, 188, 138, 128, 50, 212, 215, 98, 209, 236, 204, 213, 232, 20, 129, 197, 194, 53, 100, 112, 157, 142, 165, 104, 74, 39, 15, 82, 12, 233, 163, 141, 145, 157, 22, 175, 248, 26, 170, 30, 33, 73, 122, 144, 74, 56, 189, 248, 126, 198, 61, 24, 123, 202, 249, 124, 88, 1, 176, 131, 166, 103, 235, 253, 55, 53, 155, 74, 144, 41, 3, 196, 215, 225, 227, 166, 216, 136, 56, 192, 31, 108, 243, 171, 125, 129, 72, 152, 4, 57, 196, 61, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(3441), new byte[] { 141, 195, 214, 177, 62, 69, 51, 142, 22, 15, 85, 209, 23, 114, 232, 213, 119, 250, 125, 69, 123, 25, 39, 141, 127, 142, 101, 81, 218, 243, 212, 165, 212, 215, 116, 77, 150, 127, 74, 84, 196, 130, 160, 17, 197, 25, 115, 44, 123, 8, 226, 55, 216, 25, 145, 68, 244, 80, 126, 229, 132, 218, 60, 69 }, new byte[] { 250, 236, 213, 198, 186, 85, 185, 121, 223, 255, 130, 215, 4, 66, 68, 57, 101, 144, 98, 208, 23, 241, 50, 237, 178, 93, 162, 244, 215, 227, 223, 190, 219, 118, 102, 91, 150, 123, 219, 228, 151, 249, 121, 193, 205, 30, 135, 82, 246, 208, 103, 128, 166, 41, 237, 52, 199, 73, 235, 68, 176, 255, 57, 98, 220, 204, 10, 22, 214, 79, 133, 70, 152, 185, 29, 212, 18, 33, 88, 223, 104, 21, 164, 242, 189, 99, 220, 54, 255, 97, 65, 148, 124, 254, 25, 161, 247, 140, 213, 58, 156, 132, 105, 233, 13, 150, 137, 193, 101, 132, 192, 10, 54, 74, 137, 14, 247, 148, 195, 87, 155, 20, 108, 22, 4, 49, 86, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(3443), new byte[] { 45, 229, 24, 253, 201, 90, 179, 45, 232, 103, 4, 186, 189, 221, 217, 103, 32, 159, 211, 251, 155, 251, 50, 177, 179, 187, 69, 148, 185, 240, 14, 25, 7, 60, 133, 7, 153, 53, 145, 72, 103, 183, 221, 83, 192, 105, 187, 180, 8, 193, 232, 83, 140, 195, 118, 120, 51, 214, 128, 134, 219, 98, 72, 163 }, new byte[] { 196, 26, 249, 83, 33, 58, 188, 74, 137, 233, 47, 192, 218, 249, 183, 116, 76, 19, 89, 232, 60, 137, 140, 107, 236, 106, 169, 131, 157, 238, 19, 73, 6, 241, 135, 157, 253, 115, 47, 204, 216, 101, 54, 81, 253, 129, 15, 73, 94, 141, 136, 231, 23, 150, 156, 163, 57, 166, 160, 118, 245, 196, 75, 87, 181, 167, 100, 17, 125, 125, 38, 220, 2, 253, 32, 143, 42, 47, 73, 30, 35, 4, 33, 199, 184, 123, 112, 20, 168, 142, 9, 123, 160, 62, 110, 155, 66, 155, 101, 93, 110, 5, 231, 37, 65, 74, 195, 77, 60, 246, 246, 219, 10, 219, 36, 240, 211, 146, 224, 156, 44, 114, 253, 235, 2, 236, 219, 191 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(3444), new byte[] { 226, 149, 16, 82, 46, 186, 192, 120, 58, 34, 150, 174, 234, 206, 95, 216, 115, 28, 252, 89, 36, 106, 174, 203, 131, 66, 133, 142, 208, 80, 122, 71, 148, 50, 40, 200, 159, 1, 13, 225, 75, 214, 234, 50, 174, 69, 225, 16, 2, 196, 166, 3, 212, 176, 47, 131, 157, 144, 59, 16, 80, 223, 27, 158 }, new byte[] { 248, 134, 45, 248, 145, 133, 141, 55, 71, 11, 170, 174, 154, 107, 226, 111, 201, 250, 163, 147, 221, 81, 134, 194, 36, 104, 163, 66, 181, 144, 102, 148, 181, 213, 26, 101, 159, 254, 147, 61, 216, 5, 14, 135, 8, 58, 98, 144, 186, 20, 240, 32, 174, 72, 149, 94, 169, 155, 85, 217, 62, 252, 156, 233, 101, 78, 161, 103, 201, 240, 226, 37, 193, 202, 5, 119, 197, 3, 48, 15, 129, 191, 36, 14, 18, 1, 182, 249, 185, 107, 134, 200, 230, 52, 117, 83, 23, 202, 58, 145, 119, 102, 189, 129, 77, 52, 20, 153, 41, 239, 176, 106, 11, 103, 135, 28, 194, 166, 56, 98, 86, 132, 45, 230, 137, 46, 4, 97 } });

            migrationBuilder.UpdateData(
                table: "jobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 16, 53, 53, 270, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_jobLocations_JobLocationId",
                table: "jobPosts",
                column: "JobLocationId",
                principalTable: "jobLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_jobLocations_JobLocationId",
                table: "jobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobLocations",
                table: "jobLocations");

            migrationBuilder.RenameTable(
                name: "jobLocations",
                newName: "JobLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobLocation",
                table: "JobLocation",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "JobLocation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 49, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 49, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 49, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 19, 17, 15, 25, 49, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(7983), new byte[] { 169, 66, 14, 164, 57, 188, 168, 152, 152, 185, 14, 227, 175, 239, 95, 152, 185, 246, 181, 244, 204, 163, 155, 97, 229, 38, 37, 124, 71, 63, 183, 112, 105, 209, 159, 89, 151, 205, 126, 80, 93, 52, 69, 250, 51, 200, 152, 180, 18, 159, 62, 179, 12, 15, 227, 187, 138, 19, 180, 106, 151, 117, 170, 130 }, new byte[] { 124, 133, 245, 206, 4, 196, 184, 82, 255, 204, 179, 172, 78, 123, 119, 93, 255, 188, 79, 135, 123, 78, 181, 196, 60, 141, 110, 251, 93, 71, 8, 232, 107, 129, 209, 135, 141, 144, 191, 127, 148, 185, 65, 21, 76, 216, 18, 10, 123, 207, 177, 146, 105, 212, 220, 40, 195, 40, 47, 114, 69, 116, 55, 198, 44, 200, 148, 13, 104, 105, 0, 117, 150, 222, 37, 165, 194, 78, 57, 185, 200, 37, 107, 184, 232, 62, 183, 67, 90, 251, 216, 182, 3, 156, 45, 207, 76, 54, 9, 54, 219, 101, 222, 3, 176, 69, 21, 72, 125, 113, 43, 214, 206, 179, 219, 141, 4, 74, 195, 44, 189, 227, 149, 100, 225, 140, 145, 125 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(7990), new byte[] { 191, 221, 35, 131, 130, 133, 20, 81, 142, 204, 119, 197, 35, 192, 181, 207, 167, 181, 196, 229, 253, 95, 86, 184, 156, 59, 115, 184, 79, 200, 102, 212, 111, 240, 217, 34, 197, 75, 231, 41, 216, 207, 165, 63, 196, 77, 133, 41, 130, 252, 186, 241, 81, 117, 231, 48, 137, 72, 178, 142, 8, 27, 253, 111 }, new byte[] { 19, 28, 109, 103, 156, 104, 147, 121, 55, 189, 255, 6, 224, 191, 152, 39, 45, 113, 125, 66, 179, 197, 203, 219, 221, 182, 50, 87, 153, 230, 210, 30, 68, 195, 129, 220, 91, 101, 143, 68, 79, 114, 227, 56, 224, 201, 220, 236, 17, 211, 92, 77, 113, 85, 143, 134, 204, 79, 50, 138, 46, 146, 37, 239, 110, 192, 172, 45, 48, 246, 185, 97, 21, 173, 83, 143, 31, 45, 60, 97, 165, 221, 23, 228, 191, 56, 252, 196, 250, 240, 31, 2, 225, 145, 41, 134, 71, 208, 93, 103, 42, 130, 252, 27, 129, 113, 107, 249, 104, 79, 128, 51, 224, 117, 175, 232, 87, 59, 153, 205, 130, 83, 245, 129, 183, 87, 234, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(7992), new byte[] { 81, 120, 26, 141, 76, 189, 222, 218, 244, 20, 246, 236, 203, 122, 26, 169, 218, 206, 89, 222, 24, 27, 222, 17, 213, 156, 59, 27, 91, 187, 73, 36, 52, 228, 20, 80, 166, 226, 235, 147, 246, 204, 225, 151, 178, 26, 30, 118, 199, 174, 215, 79, 186, 81, 28, 157, 95, 57, 9, 198, 13, 63, 128, 33 }, new byte[] { 207, 104, 81, 113, 212, 205, 56, 94, 80, 215, 243, 230, 156, 98, 224, 248, 210, 48, 202, 133, 116, 217, 167, 4, 52, 124, 3, 158, 224, 150, 138, 49, 90, 169, 95, 113, 146, 144, 199, 238, 198, 8, 221, 140, 54, 232, 101, 78, 189, 132, 249, 164, 186, 227, 105, 7, 252, 192, 59, 5, 226, 8, 159, 230, 124, 8, 141, 186, 171, 162, 4, 47, 235, 94, 122, 72, 164, 95, 191, 180, 8, 68, 216, 180, 55, 121, 0, 2, 69, 107, 9, 128, 110, 68, 226, 54, 138, 88, 174, 41, 59, 26, 199, 168, 75, 238, 77, 42, 116, 125, 243, 118, 229, 84, 55, 121, 30, 169, 176, 45, 241, 166, 125, 203, 20, 141, 91, 206 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 15, 25, 48, DateTimeKind.Utc).AddTicks(7994), new byte[] { 78, 137, 250, 118, 208, 181, 198, 111, 29, 59, 200, 115, 247, 66, 122, 171, 62, 108, 111, 121, 57, 189, 46, 176, 52, 165, 95, 223, 141, 243, 10, 32, 16, 153, 101, 16, 217, 101, 232, 109, 208, 178, 3, 113, 18, 66, 25, 74, 138, 14, 29, 229, 60, 150, 229, 122, 100, 86, 218, 170, 16, 189, 167, 130 }, new byte[] { 230, 247, 90, 54, 30, 37, 251, 18, 32, 96, 244, 254, 236, 198, 75, 133, 185, 120, 75, 128, 33, 38, 189, 230, 198, 46, 79, 194, 146, 165, 227, 137, 36, 249, 143, 167, 128, 250, 250, 39, 146, 21, 232, 240, 189, 133, 174, 143, 152, 134, 49, 123, 66, 209, 105, 239, 146, 249, 16, 137, 48, 85, 87, 140, 242, 233, 195, 73, 182, 171, 82, 86, 80, 121, 115, 169, 130, 227, 200, 230, 31, 50, 201, 189, 54, 75, 131, 81, 104, 26, 250, 58, 142, 190, 182, 232, 55, 167, 107, 113, 40, 50, 231, 252, 147, 97, 114, 144, 156, 188, 193, 67, 139, 55, 169, 173, 74, 134, 214, 92, 32, 124, 123, 190, 48, 164, 131, 91 } });

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_JobLocation_JobLocationId",
                table: "jobPosts",
                column: "JobLocationId",
                principalTable: "JobLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
