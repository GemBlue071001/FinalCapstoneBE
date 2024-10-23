using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivityComment_JobPostActivities_JobPostActivityId",
                table: "JobPostActivityComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivityComment",
                table: "JobPostActivityComment");

            migrationBuilder.RenameTable(
                name: "JobPostActivityComment",
                newName: "JobPostActivityComments");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivityComment_JobPostActivityId",
                table: "JobPostActivityComments",
                newName: "IX_JobPostActivityComments_JobPostActivityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivityComments",
                table: "JobPostActivityComments",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivityComments_JobPostActivities_JobPostActivityId",
                table: "JobPostActivityComments",
                column: "JobPostActivityId",
                principalTable: "JobPostActivities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivityComments_JobPostActivities_JobPostActivityId",
                table: "JobPostActivityComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivityComments",
                table: "JobPostActivityComments");

            migrationBuilder.RenameTable(
                name: "JobPostActivityComments",
                newName: "JobPostActivityComment");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivityComments_JobPostActivityId",
                table: "JobPostActivityComment",
                newName: "IX_JobPostActivityComment_JobPostActivityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivityComment",
                table: "JobPostActivityComment",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 297, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 298, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 298, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 299, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 299, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 13, 50, 12, 299, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 50, 12, 297, DateTimeKind.Utc).AddTicks(6744), new byte[] { 249, 5, 237, 16, 173, 179, 31, 230, 70, 104, 48, 62, 210, 125, 96, 171, 193, 96, 168, 60, 67, 144, 29, 42, 118, 230, 164, 100, 195, 79, 131, 178, 124, 239, 56, 254, 72, 191, 48, 70, 163, 74, 75, 169, 198, 47, 9, 148, 78, 131, 146, 251, 32, 254, 208, 126, 36, 36, 90, 56, 112, 37, 29, 253 }, new byte[] { 165, 4, 77, 52, 130, 59, 124, 126, 208, 154, 6, 41, 110, 2, 224, 251, 135, 253, 97, 187, 154, 159, 105, 178, 8, 57, 44, 136, 54, 151, 29, 39, 185, 194, 160, 40, 179, 195, 96, 14, 92, 150, 162, 88, 206, 242, 250, 11, 8, 250, 86, 183, 238, 154, 82, 138, 17, 243, 171, 132, 59, 132, 76, 215, 225, 199, 163, 253, 156, 43, 183, 228, 21, 164, 84, 75, 236, 106, 82, 53, 48, 55, 184, 62, 240, 228, 34, 206, 14, 248, 206, 28, 120, 37, 250, 251, 171, 76, 233, 171, 144, 25, 153, 112, 54, 206, 133, 171, 129, 22, 234, 198, 63, 84, 107, 0, 94, 242, 73, 185, 174, 219, 174, 19, 53, 104, 62, 189 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 50, 12, 297, DateTimeKind.Utc).AddTicks(6752), new byte[] { 30, 203, 71, 176, 238, 145, 135, 215, 250, 234, 181, 67, 14, 71, 156, 15, 179, 4, 250, 72, 206, 168, 216, 245, 23, 100, 55, 192, 214, 127, 212, 232, 1, 22, 223, 8, 28, 178, 124, 146, 18, 59, 161, 171, 48, 193, 24, 186, 38, 158, 249, 93, 209, 43, 172, 100, 237, 159, 112, 153, 36, 202, 233, 232 }, new byte[] { 133, 239, 107, 136, 26, 89, 145, 165, 129, 116, 220, 219, 46, 113, 123, 46, 67, 50, 164, 49, 238, 56, 247, 23, 1, 132, 141, 199, 74, 4, 198, 198, 239, 105, 171, 103, 69, 205, 223, 210, 131, 2, 34, 247, 249, 184, 213, 84, 161, 80, 124, 160, 31, 82, 123, 49, 82, 224, 190, 38, 25, 119, 219, 206, 241, 173, 133, 65, 103, 18, 7, 232, 100, 228, 180, 7, 23, 79, 249, 16, 46, 15, 206, 57, 40, 89, 199, 151, 96, 171, 2, 243, 176, 88, 115, 243, 13, 44, 58, 9, 77, 217, 121, 62, 209, 6, 138, 224, 190, 216, 40, 152, 148, 38, 16, 178, 237, 163, 253, 152, 250, 106, 47, 133, 112, 233, 79, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 50, 12, 297, DateTimeKind.Utc).AddTicks(6755), new byte[] { 220, 121, 1, 54, 100, 204, 162, 205, 163, 120, 129, 129, 189, 27, 174, 218, 244, 166, 27, 237, 206, 189, 129, 213, 52, 206, 26, 82, 185, 202, 51, 152, 246, 57, 149, 233, 224, 7, 45, 245, 48, 234, 13, 144, 39, 190, 37, 14, 40, 141, 235, 76, 247, 124, 127, 55, 193, 49, 35, 75, 45, 16, 53, 22 }, new byte[] { 70, 84, 254, 72, 232, 107, 168, 137, 228, 71, 35, 95, 190, 95, 205, 104, 93, 163, 99, 37, 148, 71, 40, 6, 31, 237, 163, 186, 186, 168, 200, 237, 165, 194, 29, 224, 205, 80, 115, 126, 137, 211, 29, 203, 170, 185, 93, 196, 121, 17, 87, 151, 193, 116, 143, 78, 209, 134, 70, 110, 95, 241, 57, 75, 48, 101, 118, 32, 33, 104, 0, 17, 251, 164, 204, 203, 122, 202, 3, 66, 1, 158, 185, 222, 87, 83, 189, 149, 76, 254, 35, 204, 137, 53, 174, 50, 13, 59, 99, 220, 225, 82, 42, 186, 195, 208, 4, 15, 137, 187, 100, 148, 64, 127, 72, 27, 141, 243, 232, 220, 64, 183, 232, 64, 17, 109, 150, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 50, 12, 297, DateTimeKind.Utc).AddTicks(6756), new byte[] { 134, 181, 116, 77, 235, 243, 91, 72, 187, 164, 32, 184, 91, 201, 67, 195, 253, 16, 236, 244, 242, 191, 37, 51, 164, 118, 109, 16, 145, 198, 241, 230, 58, 106, 44, 6, 201, 240, 121, 57, 48, 50, 128, 108, 204, 83, 8, 203, 38, 219, 182, 197, 112, 232, 231, 26, 223, 238, 245, 169, 178, 47, 173, 40 }, new byte[] { 58, 36, 210, 48, 99, 69, 136, 151, 222, 60, 254, 217, 241, 192, 86, 56, 82, 5, 202, 241, 21, 153, 118, 113, 167, 179, 216, 101, 118, 50, 189, 250, 247, 17, 38, 230, 44, 107, 3, 24, 53, 140, 248, 223, 111, 238, 127, 239, 175, 230, 87, 88, 246, 142, 189, 75, 67, 178, 206, 100, 243, 1, 15, 189, 238, 158, 87, 138, 91, 155, 50, 218, 177, 208, 215, 112, 108, 213, 116, 135, 229, 214, 91, 151, 19, 242, 42, 92, 24, 48, 134, 178, 218, 115, 41, 30, 130, 183, 92, 198, 33, 129, 35, 152, 30, 117, 12, 144, 23, 207, 68, 55, 189, 204, 50, 163, 90, 9, 208, 232, 245, 168, 3, 25, 136, 32, 80, 7 } });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivityComment_JobPostActivities_JobPostActivityId",
                table: "JobPostActivityComment",
                column: "JobPostActivityId",
                principalTable: "JobPostActivities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
