using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitSeekerProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_Company_CompanyId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobLocation_JobLocationId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_JobType_JobTypeId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPost_Users_UserId",
                table: "JobPost");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_JobPost_JobPostId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_JobPost_JobPostId",
                table: "JobSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPost",
                table: "JobPost");

            migrationBuilder.RenameTable(
                name: "JobPost",
                newName: "jobPosts");

            migrationBuilder.RenameIndex(
                name: "IX_JobPost_UserId",
                table: "jobPosts",
                newName: "IX_jobPosts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPost_JobTypeId",
                table: "jobPosts",
                newName: "IX_jobPosts_JobTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPost_JobLocationId",
                table: "jobPosts",
                newName: "IX_jobPosts_JobLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPost_CompanyId",
                table: "jobPosts",
                newName: "IX_jobPosts_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobPosts",
                table: "jobPosts",
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
                name: "FK_JobPostActivity_jobPosts_JobPostId",
                table: "JobPostActivity",
                column: "JobPostId",
                principalTable: "jobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_Company_CompanyId",
                table: "jobPosts",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_JobLocation_JobLocationId",
                table: "jobPosts",
                column: "JobLocationId",
                principalTable: "JobLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_JobType_JobTypeId",
                table: "jobPosts",
                column: "JobTypeId",
                principalTable: "JobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobPosts_Users_UserId",
                table: "jobPosts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_jobPosts_JobPostId",
                table: "JobSkillSet",
                column: "JobPostId",
                principalTable: "jobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_jobPosts_JobPostId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_Company_CompanyId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_JobLocation_JobLocationId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_JobType_JobTypeId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_Users_UserId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_jobPosts_JobPostId",
                table: "JobSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobPosts",
                table: "jobPosts");

            migrationBuilder.RenameTable(
                name: "jobPosts",
                newName: "JobPost");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_UserId",
                table: "JobPost",
                newName: "IX_JobPost_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_JobTypeId",
                table: "JobPost",
                newName: "IX_JobPost_JobTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_JobLocationId",
                table: "JobPost",
                newName: "IX_JobPost_JobLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_CompanyId",
                table: "JobPost",
                newName: "IX_JobPost_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPost",
                table: "JobPost",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "JobLocation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7340), new byte[] { 40, 25, 11, 158, 14, 229, 189, 72, 125, 215, 47, 98, 78, 177, 89, 179, 212, 171, 112, 195, 176, 241, 52, 118, 92, 126, 124, 57, 255, 88, 7, 89, 211, 52, 33, 45, 83, 35, 125, 229, 9, 12, 204, 102, 137, 241, 174, 204, 105, 196, 225, 178, 162, 197, 130, 169, 116, 61, 222, 189, 56, 32, 95, 14 }, new byte[] { 64, 145, 179, 171, 40, 48, 187, 242, 106, 215, 149, 38, 115, 73, 56, 139, 208, 176, 250, 231, 224, 251, 92, 114, 134, 73, 173, 14, 255, 204, 199, 227, 51, 114, 198, 220, 60, 215, 31, 104, 190, 6, 139, 184, 61, 137, 241, 87, 135, 104, 224, 1, 193, 5, 92, 93, 88, 225, 23, 100, 248, 148, 185, 135, 195, 91, 209, 156, 126, 202, 103, 68, 119, 142, 92, 143, 231, 215, 226, 72, 171, 19, 174, 67, 162, 103, 112, 76, 68, 103, 243, 136, 154, 226, 75, 179, 203, 159, 28, 165, 193, 56, 95, 188, 3, 229, 26, 204, 113, 237, 170, 208, 194, 235, 17, 46, 70, 158, 137, 152, 127, 111, 213, 119, 125, 58, 93, 235 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7348), new byte[] { 132, 233, 3, 199, 193, 117, 153, 111, 135, 182, 255, 34, 219, 182, 63, 98, 49, 93, 134, 18, 14, 42, 204, 11, 93, 190, 62, 192, 59, 221, 187, 200, 59, 163, 186, 50, 187, 71, 148, 87, 17, 57, 68, 108, 198, 227, 24, 4, 173, 252, 20, 117, 135, 100, 148, 250, 52, 87, 219, 196, 204, 64, 235, 48 }, new byte[] { 186, 241, 53, 150, 165, 22, 103, 142, 171, 198, 44, 242, 74, 231, 139, 210, 30, 108, 40, 141, 54, 56, 150, 251, 44, 213, 164, 55, 219, 26, 182, 10, 6, 39, 222, 60, 80, 17, 91, 93, 238, 13, 220, 175, 145, 142, 125, 32, 37, 210, 168, 22, 138, 40, 147, 171, 213, 252, 208, 63, 142, 72, 76, 159, 184, 151, 42, 239, 147, 130, 196, 160, 253, 204, 226, 13, 210, 153, 61, 46, 41, 110, 101, 170, 62, 74, 84, 123, 225, 245, 68, 120, 150, 192, 206, 75, 203, 191, 133, 37, 239, 138, 131, 60, 22, 188, 166, 43, 224, 65, 105, 105, 223, 91, 1, 162, 27, 88, 227, 85, 94, 179, 101, 164, 87, 156, 188, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7354), new byte[] { 46, 167, 49, 167, 85, 82, 225, 67, 246, 130, 75, 251, 134, 64, 117, 217, 88, 33, 161, 117, 151, 123, 217, 156, 151, 171, 251, 83, 193, 251, 211, 235, 202, 160, 105, 163, 82, 76, 14, 155, 51, 26, 202, 11, 146, 103, 175, 250, 246, 27, 119, 14, 47, 110, 128, 127, 128, 211, 161, 156, 150, 5, 205, 196 }, new byte[] { 191, 242, 228, 243, 252, 66, 123, 108, 204, 113, 58, 25, 73, 147, 158, 202, 211, 97, 72, 108, 231, 25, 240, 131, 84, 77, 98, 69, 169, 227, 203, 108, 145, 50, 71, 71, 233, 62, 55, 187, 193, 169, 127, 11, 60, 238, 83, 82, 4, 46, 78, 206, 18, 232, 182, 88, 212, 39, 238, 79, 159, 222, 183, 226, 0, 55, 41, 12, 15, 227, 111, 100, 249, 108, 66, 38, 124, 91, 88, 6, 69, 143, 164, 41, 234, 255, 96, 148, 26, 3, 29, 79, 220, 37, 197, 195, 208, 159, 228, 64, 190, 33, 254, 180, 201, 142, 103, 184, 137, 233, 63, 56, 121, 181, 209, 90, 166, 33, 64, 198, 8, 69, 235, 98, 56, 215, 160, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7355), new byte[] { 47, 170, 247, 52, 94, 85, 23, 80, 201, 83, 7, 218, 128, 255, 143, 134, 72, 135, 87, 201, 116, 64, 151, 40, 159, 40, 71, 254, 156, 205, 133, 76, 204, 231, 191, 6, 3, 144, 64, 114, 202, 239, 18, 233, 71, 246, 91, 211, 153, 140, 64, 127, 153, 77, 103, 108, 159, 183, 225, 39, 108, 30, 190, 109 }, new byte[] { 41, 178, 235, 170, 158, 117, 159, 217, 13, 46, 223, 46, 145, 229, 169, 198, 70, 206, 113, 181, 20, 139, 132, 157, 91, 128, 71, 57, 68, 232, 220, 158, 94, 111, 22, 54, 151, 177, 157, 15, 160, 171, 115, 30, 242, 235, 10, 118, 126, 239, 92, 117, 204, 25, 71, 248, 46, 232, 185, 139, 209, 230, 169, 133, 113, 147, 145, 61, 178, 216, 148, 39, 157, 95, 163, 41, 240, 48, 126, 70, 212, 32, 169, 247, 62, 34, 91, 146, 101, 20, 163, 75, 156, 167, 4, 27, 105, 186, 175, 129, 152, 156, 255, 106, 2, 206, 95, 189, 212, 238, 201, 71, 0, 148, 61, 252, 182, 209, 5, 138, 153, 144, 91, 16, 117, 1, 100, 144 } });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_Company_CompanyId",
                table: "JobPost",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobLocation_JobLocationId",
                table: "JobPost",
                column: "JobLocationId",
                principalTable: "JobLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_JobType_JobTypeId",
                table: "JobPost",
                column: "JobTypeId",
                principalTable: "JobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPost_Users_UserId",
                table: "JobPost",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivity_JobPost_JobPostId",
                table: "JobPostActivity",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_JobPost_JobPostId",
                table: "JobSkillSet",
                column: "JobPostId",
                principalTable: "JobPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
