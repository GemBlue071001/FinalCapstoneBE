using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class optionKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Users_UserId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_CVs_CvId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_JobPosts_JobPostId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_Users_UserId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
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
                name: "FK_JobSkillSets_JobPosts_JobPostId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSets_SkillSets_SkillSetId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Companys_CompanyId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_Users_UserId",
                table: "SeekerSkillSets");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SeekerSkillSets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SkillSetId",
                table: "SeekerSkillSets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SkillSetId",
                table: "JobSkillSets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "JobPostId",
                table: "JobSkillSets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "JobPosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "JobTypeId",
                table: "JobPosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "JobLocationId",
                table: "JobPosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "JobPosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "JobPostId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CvId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CVs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BusinessStreamId",
                table: "Companys",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 438, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 439, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 439, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 15, 27, 34, 439, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(8164), new byte[] { 161, 85, 240, 172, 142, 38, 165, 52, 94, 221, 54, 239, 122, 238, 207, 9, 149, 168, 94, 120, 58, 150, 88, 189, 213, 29, 240, 34, 88, 130, 113, 37, 87, 128, 176, 46, 177, 194, 12, 143, 70, 70, 205, 48, 186, 220, 103, 156, 229, 223, 123, 206, 173, 217, 23, 136, 23, 17, 13, 179, 100, 233, 251, 61 }, new byte[] { 187, 213, 159, 201, 174, 130, 9, 253, 174, 244, 130, 162, 147, 159, 167, 83, 249, 226, 164, 237, 136, 2, 190, 251, 15, 84, 74, 216, 127, 166, 118, 136, 180, 86, 66, 54, 16, 138, 201, 212, 35, 87, 222, 131, 180, 9, 94, 90, 53, 78, 68, 26, 249, 7, 95, 194, 26, 223, 124, 47, 83, 94, 114, 164, 75, 65, 204, 22, 184, 57, 7, 70, 30, 168, 26, 83, 206, 87, 207, 235, 178, 145, 200, 70, 173, 238, 7, 188, 93, 149, 202, 109, 158, 39, 242, 3, 15, 79, 73, 71, 0, 70, 135, 32, 139, 28, 37, 86, 189, 229, 135, 205, 216, 45, 211, 8, 189, 151, 101, 188, 85, 241, 147, 73, 202, 203, 205, 238 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(8170), new byte[] { 13, 217, 138, 104, 229, 10, 62, 223, 221, 170, 114, 141, 215, 230, 225, 213, 241, 105, 97, 114, 9, 120, 122, 61, 90, 120, 223, 173, 155, 191, 42, 167, 211, 192, 133, 2, 207, 123, 231, 149, 84, 250, 36, 35, 90, 110, 195, 102, 90, 43, 200, 136, 161, 57, 78, 65, 252, 179, 0, 193, 186, 110, 112, 98 }, new byte[] { 141, 114, 112, 1, 245, 160, 65, 146, 98, 65, 170, 106, 105, 15, 184, 176, 127, 32, 0, 135, 125, 2, 68, 149, 177, 215, 111, 49, 184, 9, 24, 121, 87, 17, 236, 248, 254, 141, 88, 250, 26, 67, 168, 196, 129, 218, 52, 185, 55, 115, 69, 85, 254, 68, 66, 35, 19, 181, 202, 22, 47, 204, 233, 141, 153, 113, 191, 91, 25, 252, 108, 149, 12, 191, 99, 108, 33, 115, 126, 245, 104, 137, 71, 108, 48, 178, 170, 214, 37, 3, 153, 45, 92, 25, 78, 28, 179, 135, 117, 181, 89, 94, 204, 145, 158, 84, 60, 221, 36, 152, 189, 139, 88, 173, 252, 254, 246, 33, 174, 17, 128, 119, 189, 222, 17, 156, 124, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(8172), new byte[] { 194, 110, 242, 101, 211, 193, 105, 47, 40, 99, 28, 81, 162, 153, 138, 31, 243, 252, 66, 146, 42, 244, 147, 162, 81, 133, 232, 88, 116, 75, 224, 111, 233, 190, 89, 3, 236, 17, 85, 96, 136, 230, 224, 69, 159, 168, 221, 147, 186, 175, 235, 97, 37, 2, 62, 250, 111, 153, 150, 208, 184, 134, 153, 194 }, new byte[] { 254, 228, 128, 238, 57, 220, 223, 75, 120, 111, 155, 152, 111, 140, 171, 189, 0, 139, 216, 63, 217, 129, 172, 67, 87, 177, 59, 236, 54, 12, 219, 255, 105, 19, 136, 130, 220, 214, 3, 193, 42, 11, 116, 105, 134, 195, 147, 192, 40, 74, 228, 44, 151, 205, 239, 112, 241, 221, 30, 88, 88, 47, 209, 33, 36, 73, 229, 213, 178, 126, 176, 136, 167, 51, 53, 170, 12, 66, 0, 108, 59, 130, 15, 100, 135, 252, 9, 113, 72, 95, 65, 149, 212, 217, 46, 218, 242, 14, 163, 64, 109, 254, 23, 234, 134, 137, 108, 61, 182, 221, 210, 166, 4, 99, 228, 38, 160, 48, 194, 142, 212, 95, 60, 52, 198, 112, 254, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 27, 34, 437, DateTimeKind.Utc).AddTicks(8173), new byte[] { 156, 255, 139, 7, 219, 194, 47, 38, 33, 7, 14, 144, 167, 4, 124, 181, 166, 166, 227, 213, 121, 207, 100, 187, 125, 97, 117, 253, 29, 237, 192, 56, 255, 150, 208, 206, 36, 131, 146, 91, 57, 215, 184, 204, 123, 73, 45, 119, 204, 224, 26, 59, 236, 64, 224, 170, 66, 215, 95, 135, 106, 198, 80, 33 }, new byte[] { 155, 163, 123, 82, 28, 153, 150, 98, 116, 150, 207, 173, 122, 187, 152, 119, 21, 117, 69, 201, 254, 206, 72, 123, 208, 83, 115, 219, 214, 29, 173, 166, 119, 74, 163, 219, 37, 99, 34, 76, 48, 29, 229, 146, 211, 173, 97, 59, 177, 182, 229, 40, 41, 30, 67, 71, 54, 21, 237, 139, 12, 170, 126, 4, 121, 16, 61, 156, 87, 14, 87, 191, 124, 171, 137, 185, 2, 255, 51, 170, 188, 208, 58, 79, 217, 116, 36, 166, 11, 145, 82, 22, 28, 147, 140, 16, 40, 135, 117, 243, 105, 90, 166, 53, 112, 157, 253, 249, 122, 53, 24, 139, 187, 171, 136, 12, 6, 19, 94, 32, 13, 139, 41, 125, 45, 119, 17, 242 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId",
                principalTable: "BusinessStreams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Users_UserId",
                table: "CVs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_CVs_CvId",
                table: "JobPostActivitys",
                column: "CvId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_JobPosts_JobPostId",
                table: "JobPostActivitys",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_Users_UserId",
                table: "JobPostActivitys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobLocations_JobLocationId",
                table: "JobPosts",
                column: "JobLocationId",
                principalTable: "JobLocations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobTypes_JobTypeId",
                table: "JobPosts",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Users_UserId",
                table: "JobPosts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSets_JobPosts_JobPostId",
                table: "JobSkillSets",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSets_SkillSets_SkillSetId",
                table: "JobSkillSets",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Companys_CompanyId",
                table: "Reviews",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSets_Users_UserId",
                table: "SeekerSkillSets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Users_UserId",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_CVs_CvId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_JobPosts_JobPostId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_Users_UserId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
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
                name: "FK_JobSkillSets_JobPosts_JobPostId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSets_SkillSets_SkillSetId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Companys_CompanyId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_Users_UserId",
                table: "SeekerSkillSets");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SeekerSkillSets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillSetId",
                table: "SeekerSkillSets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillSetId",
                table: "JobSkillSets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobPostId",
                table: "JobSkillSets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTypeId",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobLocationId",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "JobPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobPostId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CvId",
                table: "JobPostActivitys",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CVs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BusinessStreamId",
                table: "Companys",
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
                value: new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 442, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 7, 12, 35, 54, 443, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8208), new byte[] { 252, 183, 229, 70, 148, 47, 212, 206, 92, 218, 147, 255, 73, 71, 192, 207, 224, 240, 189, 223, 152, 151, 139, 102, 184, 30, 83, 128, 213, 82, 51, 190, 143, 102, 30, 2, 27, 194, 242, 119, 160, 211, 24, 177, 11, 167, 98, 120, 237, 172, 95, 165, 118, 11, 243, 199, 53, 166, 25, 86, 107, 105, 169, 4 }, new byte[] { 9, 50, 98, 80, 30, 59, 142, 123, 32, 81, 160, 179, 193, 155, 177, 201, 5, 114, 48, 125, 11, 87, 218, 53, 188, 38, 133, 214, 0, 169, 126, 110, 178, 43, 25, 123, 4, 138, 156, 232, 90, 233, 84, 78, 247, 29, 232, 219, 175, 97, 250, 49, 240, 36, 57, 66, 67, 116, 101, 180, 109, 164, 105, 207, 147, 65, 200, 213, 92, 238, 247, 39, 185, 169, 38, 202, 14, 98, 172, 46, 31, 34, 47, 140, 116, 187, 245, 38, 26, 177, 140, 182, 105, 199, 151, 77, 34, 38, 99, 20, 144, 18, 187, 169, 9, 176, 159, 21, 158, 208, 243, 117, 200, 115, 41, 154, 247, 86, 17, 208, 139, 188, 207, 51, 127, 224, 88, 169 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8216), new byte[] { 87, 103, 214, 72, 252, 55, 31, 127, 161, 112, 166, 162, 131, 243, 201, 90, 155, 169, 135, 157, 207, 170, 209, 229, 152, 83, 111, 164, 149, 188, 208, 54, 163, 77, 235, 243, 15, 21, 157, 178, 103, 43, 70, 173, 252, 72, 37, 93, 49, 25, 127, 118, 206, 26, 239, 98, 18, 59, 7, 213, 96, 69, 100, 114 }, new byte[] { 148, 178, 112, 88, 149, 63, 245, 47, 191, 165, 114, 208, 196, 130, 149, 238, 209, 191, 194, 186, 14, 213, 131, 221, 243, 76, 140, 173, 2, 219, 16, 14, 211, 139, 155, 6, 109, 143, 49, 223, 190, 13, 202, 185, 159, 204, 0, 65, 198, 20, 57, 46, 1, 153, 151, 182, 127, 172, 35, 59, 133, 210, 201, 230, 100, 76, 50, 169, 157, 224, 250, 36, 120, 138, 43, 20, 151, 175, 202, 222, 48, 83, 106, 112, 57, 173, 106, 135, 20, 22, 72, 42, 174, 189, 79, 146, 141, 83, 135, 180, 58, 151, 187, 127, 33, 119, 14, 32, 234, 123, 132, 168, 77, 164, 208, 2, 95, 183, 15, 97, 227, 205, 3, 138, 143, 53, 84, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8218), new byte[] { 147, 145, 233, 227, 64, 88, 93, 15, 192, 246, 60, 23, 10, 199, 126, 255, 42, 76, 146, 157, 219, 71, 121, 2, 187, 171, 2, 184, 21, 185, 254, 141, 179, 185, 66, 103, 153, 30, 246, 219, 0, 65, 190, 149, 207, 227, 31, 201, 224, 2, 223, 82, 197, 72, 174, 59, 183, 166, 191, 24, 241, 67, 149, 126 }, new byte[] { 22, 79, 10, 30, 243, 186, 229, 219, 138, 234, 183, 26, 48, 149, 182, 206, 192, 175, 252, 60, 21, 171, 9, 220, 142, 41, 195, 133, 113, 136, 208, 64, 166, 83, 53, 32, 10, 97, 149, 235, 81, 83, 228, 212, 102, 222, 217, 112, 126, 245, 24, 128, 154, 65, 41, 194, 69, 172, 185, 147, 201, 14, 88, 225, 229, 243, 29, 219, 130, 210, 132, 252, 157, 26, 252, 239, 68, 216, 38, 68, 107, 205, 149, 135, 70, 168, 202, 86, 144, 114, 147, 55, 78, 149, 130, 0, 111, 229, 89, 35, 197, 19, 122, 197, 109, 60, 32, 100, 57, 136, 67, 150, 187, 205, 219, 143, 21, 171, 190, 71, 158, 13, 19, 42, 193, 180, 50, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 35, 54, 441, DateTimeKind.Utc).AddTicks(8220), new byte[] { 123, 151, 124, 75, 19, 208, 104, 155, 103, 188, 226, 173, 128, 2, 119, 241, 172, 92, 10, 135, 204, 162, 253, 180, 153, 241, 236, 64, 150, 136, 224, 140, 255, 157, 194, 18, 22, 228, 136, 173, 218, 188, 91, 33, 206, 210, 168, 246, 7, 134, 105, 79, 129, 27, 48, 26, 218, 85, 97, 21, 201, 190, 161, 59 }, new byte[] { 124, 204, 137, 94, 223, 253, 64, 116, 162, 49, 215, 252, 84, 6, 199, 246, 143, 221, 125, 39, 29, 149, 17, 115, 162, 121, 155, 176, 193, 173, 235, 162, 133, 178, 112, 110, 182, 21, 48, 157, 47, 43, 18, 156, 227, 53, 145, 195, 7, 30, 98, 91, 32, 160, 215, 38, 85, 58, 157, 56, 109, 90, 150, 48, 91, 132, 10, 148, 111, 3, 83, 115, 89, 86, 163, 41, 57, 36, 232, 13, 224, 96, 236, 106, 145, 105, 49, 72, 175, 131, 198, 58, 156, 157, 111, 95, 204, 200, 32, 80, 165, 22, 189, 94, 232, 233, 154, 179, 150, 35, 42, 232, 83, 24, 115, 20, 36, 147, 78, 38, 90, 58, 92, 127, 236, 223, 79, 137 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId",
                principalTable: "BusinessStreams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Users_UserId",
                table: "CVs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_CVs_CvId",
                table: "JobPostActivitys",
                column: "CvId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_JobPosts_JobPostId",
                table: "JobPostActivitys",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivitys_Users_UserId",
                table: "JobPostActivitys",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "Companys",
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
                name: "FK_JobSkillSets_JobPosts_JobPostId",
                table: "JobSkillSets",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSets_SkillSets_SkillSetId",
                table: "JobSkillSets",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Companys_CompanyId",
                table: "Reviews",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSets_Users_UserId",
                table: "SeekerSkillSets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
