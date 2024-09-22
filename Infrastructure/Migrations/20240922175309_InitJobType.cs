using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitJobType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_jobPosts_JobPostId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_Company_CompanyId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_JobType_JobTypeId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_Users_UserId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_jobPosts_jobLocations_JobLocationId",
                table: "jobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_jobPosts_JobPostId",
                table: "JobSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobPosts",
                table: "jobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobLocations",
                table: "jobLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobType",
                table: "JobType");

            migrationBuilder.RenameTable(
                name: "jobPosts",
                newName: "JobPosts");

            migrationBuilder.RenameTable(
                name: "jobLocations",
                newName: "JobLocations");

            migrationBuilder.RenameTable(
                name: "JobType",
                newName: "JobTypes");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_UserId",
                table: "JobPosts",
                newName: "IX_JobPosts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_JobTypeId",
                table: "JobPosts",
                newName: "IX_JobPosts_JobTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_JobLocationId",
                table: "JobPosts",
                newName: "IX_JobPosts_JobLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_jobPosts_CompanyId",
                table: "JobPosts",
                newName: "IX_JobPosts_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPosts",
                table: "JobPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobLocations",
                table: "JobLocations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTypes",
                table: "JobTypes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8675), new byte[] { 175, 112, 52, 216, 94, 110, 195, 166, 199, 30, 191, 190, 148, 105, 23, 223, 58, 243, 127, 100, 104, 114, 244, 62, 228, 213, 101, 158, 136, 150, 167, 92, 100, 215, 150, 61, 208, 135, 199, 166, 30, 98, 58, 82, 34, 218, 173, 203, 180, 98, 105, 220, 43, 122, 69, 12, 198, 213, 17, 159, 194, 6, 75, 189 }, new byte[] { 172, 202, 131, 142, 145, 21, 215, 68, 50, 48, 250, 159, 226, 75, 149, 14, 118, 193, 3, 34, 209, 165, 208, 38, 158, 30, 208, 230, 132, 34, 130, 87, 177, 149, 241, 199, 15, 116, 117, 84, 204, 61, 252, 39, 92, 20, 119, 231, 128, 69, 233, 42, 218, 211, 1, 1, 179, 162, 201, 80, 162, 255, 214, 80, 219, 49, 245, 217, 204, 19, 43, 190, 195, 231, 234, 225, 23, 140, 81, 151, 94, 202, 247, 23, 194, 118, 117, 68, 16, 231, 103, 81, 148, 125, 139, 54, 127, 9, 160, 243, 48, 252, 24, 126, 205, 242, 254, 216, 116, 148, 202, 27, 243, 139, 216, 180, 96, 229, 191, 6, 79, 57, 204, 246, 20, 39, 238, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8682), new byte[] { 134, 89, 118, 83, 217, 216, 183, 247, 87, 248, 74, 112, 64, 226, 190, 41, 210, 139, 107, 50, 249, 121, 223, 104, 54, 242, 155, 70, 233, 48, 93, 9, 157, 60, 200, 83, 30, 253, 68, 118, 201, 242, 135, 50, 87, 225, 190, 227, 41, 223, 42, 2, 178, 89, 75, 166, 7, 237, 95, 169, 137, 49, 203, 111 }, new byte[] { 108, 108, 131, 176, 40, 246, 116, 68, 45, 207, 246, 191, 152, 125, 183, 147, 196, 246, 179, 54, 2, 167, 22, 81, 173, 222, 169, 22, 220, 215, 189, 25, 221, 133, 249, 251, 93, 57, 242, 98, 168, 221, 27, 88, 163, 73, 151, 177, 232, 232, 89, 109, 170, 1, 6, 128, 222, 164, 166, 76, 80, 157, 113, 140, 5, 29, 11, 173, 118, 42, 141, 199, 22, 194, 65, 203, 57, 153, 54, 88, 112, 19, 153, 193, 120, 166, 48, 116, 57, 212, 5, 66, 179, 3, 113, 119, 210, 94, 7, 229, 93, 102, 210, 55, 194, 75, 213, 110, 52, 140, 154, 130, 151, 122, 142, 253, 197, 206, 153, 79, 224, 15, 52, 230, 235, 201, 90, 228 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8684), new byte[] { 39, 164, 171, 123, 76, 13, 198, 42, 154, 144, 251, 216, 35, 153, 195, 200, 251, 19, 240, 180, 41, 40, 135, 111, 204, 151, 165, 65, 239, 94, 49, 9, 25, 16, 143, 2, 123, 224, 18, 96, 43, 38, 180, 65, 70, 6, 120, 156, 71, 125, 154, 184, 117, 60, 147, 98, 5, 138, 129, 67, 109, 42, 156, 10 }, new byte[] { 108, 211, 113, 198, 207, 135, 243, 243, 203, 217, 92, 24, 200, 57, 154, 86, 16, 62, 3, 102, 176, 245, 127, 193, 122, 167, 244, 96, 31, 38, 37, 192, 199, 0, 204, 49, 220, 148, 237, 15, 180, 58, 126, 124, 44, 169, 28, 59, 115, 220, 2, 21, 241, 49, 102, 206, 40, 11, 6, 22, 169, 166, 221, 35, 249, 10, 135, 175, 250, 204, 232, 217, 228, 74, 24, 4, 67, 56, 51, 199, 118, 187, 241, 182, 96, 67, 66, 137, 74, 175, 3, 4, 224, 208, 4, 217, 56, 18, 196, 154, 176, 157, 86, 158, 114, 105, 23, 87, 17, 239, 185, 204, 39, 248, 100, 184, 124, 252, 228, 59, 207, 170, 112, 17, 54, 63, 34, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8685), new byte[] { 31, 84, 48, 161, 251, 224, 244, 202, 115, 165, 253, 253, 209, 132, 81, 60, 140, 21, 78, 45, 205, 187, 216, 14, 72, 31, 100, 68, 214, 86, 205, 228, 157, 7, 26, 64, 124, 107, 99, 88, 121, 0, 38, 63, 95, 37, 139, 65, 25, 233, 148, 128, 52, 188, 19, 230, 20, 60, 24, 201, 37, 128, 177, 124 }, new byte[] { 215, 30, 2, 159, 204, 29, 97, 180, 251, 130, 191, 173, 94, 128, 105, 29, 136, 24, 66, 73, 3, 11, 99, 139, 134, 230, 159, 130, 63, 146, 197, 211, 55, 1, 48, 35, 112, 132, 182, 158, 155, 208, 181, 230, 191, 119, 203, 177, 210, 23, 58, 3, 107, 226, 241, 100, 29, 2, 32, 230, 248, 109, 51, 182, 53, 39, 104, 124, 10, 138, 22, 196, 62, 204, 162, 228, 109, 97, 181, 128, 85, 162, 177, 141, 54, 63, 21, 184, 54, 225, 146, 167, 164, 6, 204, 120, 132, 3, 130, 147, 142, 172, 54, 119, 3, 171, 247, 66, 176, 227, 73, 192, 2, 24, 128, 113, 102, 45, 219, 220, 62, 36, 120, 34, 171, 252, 5, 76 } });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivity_JobPosts_JobPostId",
                table: "JobPostActivity",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Company_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobLocations_JobLocationId",
                table: "JobPosts",
                column: "JobLocationId",
                principalTable: "JobLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobTypes_JobTypeId",
                table: "JobPosts",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Users_UserId",
                table: "JobPosts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_JobPosts_JobPostId",
                table: "JobSkillSet",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_JobPosts_JobPostId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Company_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobLocations_JobLocationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobTypes_JobTypeId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Users_UserId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_JobPosts_JobPostId",
                table: "JobSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPosts",
                table: "JobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobLocations",
                table: "JobLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTypes",
                table: "JobTypes");

            migrationBuilder.RenameTable(
                name: "JobPosts",
                newName: "jobPosts");

            migrationBuilder.RenameTable(
                name: "JobLocations",
                newName: "jobLocations");

            migrationBuilder.RenameTable(
                name: "JobTypes",
                newName: "JobType");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_UserId",
                table: "jobPosts",
                newName: "IX_jobPosts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_JobTypeId",
                table: "jobPosts",
                newName: "IX_jobPosts_JobTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_JobLocationId",
                table: "jobPosts",
                newName: "IX_jobPosts_JobLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_CompanyId",
                table: "jobPosts",
                newName: "IX_jobPosts_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobPosts",
                table: "jobPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobLocations",
                table: "jobLocations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobType",
                table: "JobType",
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
                name: "FK_jobPosts_jobLocations_JobLocationId",
                table: "jobPosts",
                column: "JobLocationId",
                principalTable: "jobLocations",
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
    }
}
