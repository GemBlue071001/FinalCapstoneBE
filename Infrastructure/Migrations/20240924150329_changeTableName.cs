using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companys_BusinessStream_BusinessStreamId",
                table: "Companys");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetail_SeekerProfile_SeekerProfileId",
                table: "EducationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDetail_SeekerProfile_SeekerProfileId",
                table: "ExperienceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_JobPosts_JobPostId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivity_Users_UserId",
                table: "JobPostActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_JobPosts_JobPostId",
                table: "JobSkillSet");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_SkillSets_SkillSetId",
                table: "JobSkillSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSet_SeekerProfile_SeekerProfileId",
                table: "SeekerSkillSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSet_SkillSets_SkillSetId",
                table: "SeekerSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeekerSkillSet",
                table: "SeekerSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSkillSet",
                table: "JobSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivity",
                table: "JobPostActivity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperienceDetail",
                table: "ExperienceDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationDetail",
                table: "EducationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessStream",
                table: "BusinessStream");

            migrationBuilder.RenameTable(
                name: "SeekerSkillSet",
                newName: "SeekerSkillSets");

            migrationBuilder.RenameTable(
                name: "JobSkillSet",
                newName: "JobSkillSets");

            migrationBuilder.RenameTable(
                name: "JobPostActivity",
                newName: "JobPostActivitys");

            migrationBuilder.RenameTable(
                name: "ExperienceDetail",
                newName: "ExperienceDetails");

            migrationBuilder.RenameTable(
                name: "EducationDetail",
                newName: "EducationDetails");

            migrationBuilder.RenameTable(
                name: "BusinessStream",
                newName: "BusinessStreams");

            migrationBuilder.RenameIndex(
                name: "IX_SeekerSkillSet_SkillSetId",
                table: "SeekerSkillSets",
                newName: "IX_SeekerSkillSets_SkillSetId");

            migrationBuilder.RenameIndex(
                name: "IX_SeekerSkillSet_SeekerProfileId",
                table: "SeekerSkillSets",
                newName: "IX_SeekerSkillSets_SeekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkillSet_SkillSetId",
                table: "JobSkillSets",
                newName: "IX_JobSkillSets_SkillSetId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkillSet_JobPostId",
                table: "JobSkillSets",
                newName: "IX_JobSkillSets_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivity_UserId",
                table: "JobPostActivitys",
                newName: "IX_JobPostActivitys_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivity_JobPostId",
                table: "JobPostActivitys",
                newName: "IX_JobPostActivitys_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperienceDetail_SeekerProfileId",
                table: "ExperienceDetails",
                newName: "IX_ExperienceDetails_SeekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDetail_SeekerProfileId",
                table: "EducationDetails",
                newName: "IX_EducationDetails_SeekerProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeekerSkillSets",
                table: "SeekerSkillSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSkillSets",
                table: "JobSkillSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivitys",
                table: "JobPostActivitys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperienceDetails",
                table: "ExperienceDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationDetails",
                table: "EducationDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessStreams",
                table: "BusinessStreams",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 15, 3, 29, 266, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9601), new byte[] { 172, 178, 9, 204, 138, 27, 105, 211, 178, 87, 54, 3, 34, 203, 168, 120, 183, 38, 0, 105, 244, 108, 40, 229, 66, 96, 178, 118, 18, 239, 143, 227, 150, 254, 202, 137, 79, 113, 48, 75, 177, 206, 25, 35, 43, 31, 144, 4, 246, 17, 177, 111, 146, 18, 5, 31, 156, 106, 165, 214, 197, 120, 160, 152 }, new byte[] { 159, 63, 197, 227, 54, 68, 219, 235, 0, 79, 202, 61, 210, 82, 38, 153, 161, 173, 126, 166, 254, 159, 141, 189, 247, 75, 85, 184, 85, 204, 63, 137, 230, 131, 229, 162, 124, 137, 134, 77, 93, 28, 176, 15, 44, 174, 232, 210, 64, 145, 197, 111, 200, 146, 38, 197, 34, 164, 183, 108, 205, 253, 99, 184, 48, 93, 175, 154, 35, 29, 133, 216, 98, 214, 57, 132, 2, 5, 144, 252, 123, 2, 39, 18, 114, 164, 126, 91, 240, 52, 200, 225, 177, 46, 75, 90, 138, 168, 64, 199, 113, 150, 141, 201, 186, 0, 144, 167, 16, 89, 223, 86, 234, 60, 166, 137, 7, 69, 251, 32, 175, 35, 116, 61, 78, 144, 151, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9610), new byte[] { 30, 44, 19, 159, 203, 216, 80, 60, 209, 229, 134, 132, 85, 44, 112, 153, 231, 147, 20, 149, 24, 221, 119, 110, 54, 165, 224, 112, 171, 211, 21, 106, 159, 34, 7, 230, 152, 181, 213, 166, 1, 222, 127, 21, 14, 129, 197, 251, 115, 74, 106, 24, 254, 39, 214, 184, 182, 117, 66, 213, 32, 196, 218, 58 }, new byte[] { 65, 102, 164, 246, 115, 162, 62, 225, 78, 246, 34, 47, 18, 119, 169, 62, 213, 121, 131, 205, 48, 121, 193, 151, 119, 80, 41, 176, 227, 131, 68, 202, 78, 27, 71, 218, 102, 189, 139, 46, 154, 59, 217, 238, 185, 128, 225, 136, 172, 189, 6, 237, 226, 3, 135, 134, 70, 109, 112, 119, 205, 146, 24, 102, 171, 225, 69, 220, 252, 215, 174, 198, 16, 79, 127, 6, 88, 66, 50, 123, 171, 224, 36, 246, 31, 229, 168, 109, 137, 0, 71, 5, 130, 6, 208, 182, 31, 50, 41, 186, 65, 94, 155, 38, 159, 217, 103, 175, 18, 26, 209, 69, 223, 64, 226, 241, 152, 81, 161, 155, 148, 64, 82, 18, 164, 244, 94, 173 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9612), new byte[] { 146, 171, 133, 229, 155, 168, 26, 241, 180, 12, 144, 150, 33, 207, 125, 214, 205, 43, 174, 191, 86, 1, 54, 18, 197, 205, 59, 40, 157, 124, 221, 1, 183, 116, 125, 144, 244, 59, 31, 136, 224, 69, 217, 165, 153, 179, 87, 101, 232, 120, 212, 91, 2, 190, 120, 231, 247, 163, 24, 249, 127, 70, 156, 232 }, new byte[] { 129, 152, 66, 237, 198, 72, 94, 101, 25, 5, 121, 28, 253, 66, 183, 171, 220, 255, 198, 112, 164, 234, 14, 197, 45, 59, 72, 241, 70, 28, 102, 162, 100, 233, 98, 141, 111, 229, 246, 64, 242, 24, 162, 176, 58, 182, 112, 167, 188, 144, 158, 0, 140, 205, 110, 105, 67, 192, 225, 122, 243, 88, 139, 105, 198, 136, 226, 214, 92, 58, 123, 31, 125, 158, 150, 57, 94, 82, 22, 194, 211, 5, 250, 161, 242, 78, 158, 30, 250, 55, 1, 202, 22, 34, 86, 52, 33, 194, 233, 149, 244, 12, 35, 214, 197, 236, 226, 121, 186, 75, 72, 255, 113, 18, 133, 237, 240, 158, 44, 48, 68, 215, 196, 147, 81, 240, 40, 194 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 3, 29, 265, DateTimeKind.Utc).AddTicks(9614), new byte[] { 247, 66, 76, 204, 245, 248, 73, 225, 228, 236, 104, 17, 15, 237, 208, 47, 241, 201, 44, 131, 56, 185, 91, 85, 39, 166, 150, 163, 162, 74, 47, 31, 33, 250, 196, 1, 86, 135, 138, 30, 232, 190, 173, 119, 198, 121, 38, 114, 182, 77, 223, 97, 213, 5, 100, 230, 98, 228, 122, 182, 14, 93, 102, 79 }, new byte[] { 51, 128, 221, 82, 224, 50, 199, 150, 104, 36, 196, 245, 115, 194, 71, 91, 205, 15, 250, 203, 194, 172, 153, 205, 207, 116, 221, 4, 49, 164, 212, 31, 86, 251, 144, 246, 128, 69, 50, 99, 163, 37, 6, 228, 226, 191, 230, 189, 40, 159, 55, 175, 86, 107, 168, 116, 186, 74, 175, 251, 172, 151, 158, 124, 190, 55, 59, 117, 104, 161, 84, 132, 98, 225, 214, 137, 47, 121, 222, 66, 170, 108, 165, 189, 90, 92, 207, 254, 136, 83, 152, 217, 90, 171, 155, 52, 36, 143, 32, 75, 242, 141, 188, 212, 194, 160, 85, 22, 236, 218, 24, 248, 123, 13, 58, 213, 12, 218, 20, 216, 120, 1, 104, 30, 20, 77, 220, 173 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId",
                principalTable: "BusinessStreams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetails_SeekerProfile_SeekerProfileId",
                table: "EducationDetails",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDetails_SeekerProfile_SeekerProfileId",
                table: "ExperienceDetails",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
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
                name: "FK_SeekerSkillSets_SeekerProfile_SeekerProfileId",
                table: "SeekerSkillSets",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companys_BusinessStreams_BusinessStreamId",
                table: "Companys");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationDetails_SeekerProfile_SeekerProfileId",
                table: "EducationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperienceDetails_SeekerProfile_SeekerProfileId",
                table: "ExperienceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_JobPosts_JobPostId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivitys_Users_UserId",
                table: "JobPostActivitys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSets_JobPosts_JobPostId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSets_SkillSets_SkillSetId",
                table: "JobSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_SeekerProfile_SeekerProfileId",
                table: "SeekerSkillSets");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                table: "SeekerSkillSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeekerSkillSets",
                table: "SeekerSkillSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSkillSets",
                table: "JobSkillSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivitys",
                table: "JobPostActivitys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperienceDetails",
                table: "ExperienceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationDetails",
                table: "EducationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessStreams",
                table: "BusinessStreams");

            migrationBuilder.RenameTable(
                name: "SeekerSkillSets",
                newName: "SeekerSkillSet");

            migrationBuilder.RenameTable(
                name: "JobSkillSets",
                newName: "JobSkillSet");

            migrationBuilder.RenameTable(
                name: "JobPostActivitys",
                newName: "JobPostActivity");

            migrationBuilder.RenameTable(
                name: "ExperienceDetails",
                newName: "ExperienceDetail");

            migrationBuilder.RenameTable(
                name: "EducationDetails",
                newName: "EducationDetail");

            migrationBuilder.RenameTable(
                name: "BusinessStreams",
                newName: "BusinessStream");

            migrationBuilder.RenameIndex(
                name: "IX_SeekerSkillSets_SkillSetId",
                table: "SeekerSkillSet",
                newName: "IX_SeekerSkillSet_SkillSetId");

            migrationBuilder.RenameIndex(
                name: "IX_SeekerSkillSets_SeekerProfileId",
                table: "SeekerSkillSet",
                newName: "IX_SeekerSkillSet_SeekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkillSets_SkillSetId",
                table: "JobSkillSet",
                newName: "IX_JobSkillSet_SkillSetId");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkillSets_JobPostId",
                table: "JobSkillSet",
                newName: "IX_JobSkillSet_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivitys_UserId",
                table: "JobPostActivity",
                newName: "IX_JobPostActivity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivitys_JobPostId",
                table: "JobPostActivity",
                newName: "IX_JobPostActivity_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperienceDetails_SeekerProfileId",
                table: "ExperienceDetail",
                newName: "IX_ExperienceDetail_SeekerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDetails_SeekerProfileId",
                table: "EducationDetail",
                newName: "IX_EducationDetail_SeekerProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeekerSkillSet",
                table: "SeekerSkillSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSkillSet",
                table: "JobSkillSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivity",
                table: "JobPostActivity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperienceDetail",
                table: "ExperienceDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationDetail",
                table: "EducationDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessStream",
                table: "BusinessStream",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5244), new byte[] { 192, 76, 246, 226, 117, 41, 178, 129, 191, 143, 255, 47, 63, 64, 59, 142, 98, 145, 111, 152, 105, 25, 229, 200, 216, 195, 207, 64, 48, 1, 252, 39, 53, 144, 129, 252, 74, 19, 18, 222, 148, 60, 168, 208, 14, 13, 118, 131, 95, 45, 24, 14, 220, 86, 49, 68, 255, 137, 210, 101, 146, 58, 178, 56 }, new byte[] { 113, 114, 239, 3, 223, 215, 186, 185, 171, 134, 8, 75, 10, 217, 55, 211, 76, 255, 207, 230, 245, 22, 130, 179, 165, 34, 0, 33, 188, 73, 89, 182, 237, 61, 221, 126, 189, 114, 55, 196, 196, 190, 32, 109, 123, 100, 204, 179, 254, 150, 205, 64, 78, 145, 63, 135, 44, 240, 101, 38, 131, 157, 155, 194, 13, 89, 35, 58, 245, 154, 233, 207, 37, 65, 112, 242, 198, 62, 0, 188, 142, 31, 6, 188, 179, 0, 225, 66, 153, 46, 228, 184, 117, 48, 190, 182, 90, 3, 148, 228, 185, 185, 85, 171, 166, 52, 75, 147, 188, 48, 35, 110, 154, 111, 74, 61, 105, 105, 147, 149, 159, 184, 5, 7, 148, 30, 92, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5252), new byte[] { 248, 248, 2, 158, 12, 27, 170, 131, 211, 105, 159, 184, 215, 236, 87, 75, 22, 36, 29, 198, 0, 230, 117, 162, 114, 160, 77, 245, 202, 219, 49, 240, 243, 110, 46, 213, 125, 205, 16, 107, 86, 127, 45, 114, 56, 4, 88, 119, 64, 99, 103, 12, 245, 117, 199, 140, 33, 242, 101, 182, 183, 94, 237, 107 }, new byte[] { 184, 30, 78, 68, 85, 111, 20, 201, 55, 220, 16, 47, 76, 121, 245, 98, 32, 229, 39, 155, 183, 210, 72, 46, 236, 194, 20, 116, 228, 183, 254, 198, 193, 234, 99, 208, 234, 225, 16, 77, 205, 126, 48, 8, 65, 42, 14, 39, 140, 165, 218, 98, 101, 63, 150, 223, 58, 254, 54, 129, 187, 222, 105, 209, 213, 126, 75, 229, 204, 102, 104, 233, 26, 144, 169, 109, 47, 133, 38, 107, 204, 201, 107, 173, 187, 65, 175, 164, 81, 1, 96, 33, 156, 8, 185, 152, 216, 217, 98, 48, 136, 81, 117, 13, 124, 159, 237, 193, 20, 21, 195, 235, 95, 236, 93, 2, 50, 79, 27, 149, 35, 28, 25, 31, 176, 1, 143, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5254), new byte[] { 27, 116, 115, 189, 68, 92, 72, 170, 125, 213, 78, 251, 202, 213, 241, 122, 100, 138, 99, 64, 109, 249, 74, 214, 96, 33, 64, 35, 95, 227, 238, 50, 242, 99, 142, 108, 247, 234, 159, 115, 175, 91, 63, 173, 72, 241, 161, 32, 78, 121, 24, 211, 5, 84, 202, 217, 132, 78, 250, 209, 18, 31, 198, 235 }, new byte[] { 3, 56, 5, 126, 255, 23, 65, 39, 209, 132, 240, 168, 101, 2, 234, 197, 188, 225, 233, 234, 17, 188, 26, 86, 204, 139, 143, 248, 121, 223, 162, 35, 20, 6, 32, 134, 96, 187, 157, 140, 30, 243, 178, 232, 205, 87, 123, 60, 211, 3, 212, 186, 48, 242, 53, 99, 66, 224, 196, 129, 23, 193, 169, 115, 61, 102, 113, 6, 170, 122, 39, 61, 179, 71, 232, 84, 131, 161, 89, 77, 115, 180, 201, 198, 119, 117, 73, 242, 187, 15, 125, 127, 167, 109, 164, 173, 27, 206, 130, 241, 155, 232, 101, 232, 136, 26, 81, 14, 119, 123, 53, 80, 159, 171, 112, 200, 139, 163, 165, 102, 212, 210, 150, 170, 236, 30, 151, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5255), new byte[] { 227, 37, 20, 110, 221, 36, 44, 113, 161, 112, 68, 245, 128, 143, 5, 214, 125, 98, 133, 49, 124, 110, 104, 205, 164, 157, 220, 37, 91, 98, 182, 151, 15, 168, 197, 150, 241, 150, 217, 112, 182, 145, 99, 10, 167, 180, 89, 167, 205, 184, 201, 11, 156, 219, 53, 123, 73, 12, 116, 156, 150, 101, 143, 14 }, new byte[] { 60, 104, 53, 0, 22, 38, 160, 173, 163, 165, 121, 76, 176, 104, 244, 130, 33, 68, 8, 181, 143, 89, 151, 65, 215, 46, 130, 156, 179, 240, 119, 102, 248, 23, 145, 140, 209, 210, 109, 253, 6, 14, 142, 75, 25, 22, 128, 70, 28, 201, 3, 206, 197, 207, 116, 29, 221, 20, 240, 10, 134, 185, 49, 147, 149, 113, 156, 200, 112, 180, 19, 64, 202, 218, 242, 147, 42, 245, 211, 83, 51, 36, 241, 98, 88, 161, 226, 54, 166, 183, 221, 79, 213, 254, 202, 79, 192, 87, 80, 75, 19, 173, 93, 15, 69, 71, 151, 237, 203, 224, 42, 135, 134, 96, 46, 180, 136, 52, 184, 149, 150, 200, 80, 100, 203, 128, 11, 12 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Companys_BusinessStream_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId",
                principalTable: "BusinessStream",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDetail_SeekerProfile_SeekerProfileId",
                table: "EducationDetail",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceDetail_SeekerProfile_SeekerProfileId",
                table: "ExperienceDetail",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivity_JobPosts_JobPostId",
                table: "JobPostActivity",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivity_Users_UserId",
                table: "JobPostActivity",
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

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_SkillSets_SkillSetId",
                table: "JobSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSet_SeekerProfile_SeekerProfileId",
                table: "SeekerSkillSet",
                column: "SeekerProfileId",
                principalTable: "SeekerProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSet_SkillSets_SkillSetId",
                table: "SeekerSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
