using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addJobPostActivityComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FollowJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    JobPostId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowJobs_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowJobs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostActivityComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommentText = table.Column<string>(type: "text", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: true),
                    JobPostActivityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostActivityComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostActivityComment_JobPostActivities_JobPostActivityId",
                        column: x => x.JobPostActivityId,
                        principalTable: "JobPostActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FollowJobs_JobPostId",
                table: "FollowJobs",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowJobs_UserId",
                table: "FollowJobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivityComment_JobPostActivityId",
                table: "JobPostActivityComment",
                column: "JobPostActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowJobs");

            migrationBuilder.DropTable(
                name: "JobPostActivityComment");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 28, 6, 947, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5515), new byte[] { 153, 124, 206, 27, 109, 122, 186, 109, 249, 25, 172, 200, 183, 75, 209, 14, 72, 69, 240, 106, 3, 22, 71, 196, 19, 127, 26, 142, 10, 156, 235, 137, 194, 187, 160, 140, 123, 151, 142, 241, 207, 18, 36, 15, 189, 184, 22, 59, 85, 212, 183, 180, 157, 38, 52, 143, 160, 175, 172, 87, 6, 99, 195, 209 }, new byte[] { 102, 202, 224, 152, 170, 201, 99, 134, 14, 171, 124, 34, 241, 133, 73, 147, 25, 43, 79, 81, 145, 38, 129, 247, 72, 252, 233, 145, 246, 186, 198, 214, 52, 193, 42, 158, 173, 97, 113, 108, 110, 52, 72, 123, 91, 184, 218, 182, 10, 189, 153, 16, 186, 211, 224, 163, 111, 138, 100, 170, 94, 233, 233, 27, 213, 138, 5, 164, 6, 110, 168, 21, 212, 252, 198, 106, 133, 59, 197, 183, 217, 216, 63, 227, 241, 124, 160, 239, 77, 28, 63, 178, 158, 167, 218, 76, 53, 137, 223, 29, 102, 229, 116, 226, 15, 216, 28, 111, 110, 229, 179, 164, 53, 120, 164, 231, 216, 104, 110, 123, 12, 81, 252, 1, 4, 166, 169, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5522), new byte[] { 194, 178, 244, 216, 102, 238, 182, 174, 86, 242, 196, 155, 59, 6, 70, 68, 112, 238, 182, 183, 137, 253, 74, 40, 155, 168, 176, 39, 232, 3, 68, 91, 251, 184, 196, 136, 123, 202, 205, 0, 148, 211, 105, 65, 214, 27, 74, 128, 13, 179, 77, 87, 185, 108, 48, 14, 9, 102, 69, 153, 89, 46, 137, 55 }, new byte[] { 102, 22, 80, 250, 74, 40, 252, 83, 196, 140, 80, 170, 163, 16, 131, 97, 248, 248, 171, 91, 191, 5, 205, 199, 230, 144, 96, 95, 1, 139, 19, 170, 141, 53, 81, 189, 38, 132, 232, 149, 35, 169, 129, 239, 166, 217, 38, 155, 232, 58, 49, 8, 98, 179, 174, 95, 86, 195, 114, 216, 39, 38, 164, 186, 220, 119, 45, 70, 158, 143, 142, 148, 221, 31, 69, 63, 158, 189, 136, 3, 124, 95, 29, 163, 123, 199, 118, 30, 247, 227, 121, 219, 18, 214, 25, 245, 198, 106, 150, 168, 35, 250, 247, 232, 13, 80, 255, 23, 120, 211, 213, 32, 162, 15, 205, 127, 102, 12, 76, 102, 218, 198, 85, 207, 178, 124, 214, 17 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5524), new byte[] { 34, 161, 33, 204, 23, 97, 22, 239, 11, 198, 172, 18, 13, 16, 187, 77, 84, 178, 30, 12, 86, 72, 240, 119, 131, 4, 29, 147, 206, 9, 224, 140, 157, 111, 96, 136, 109, 134, 96, 101, 214, 166, 209, 229, 77, 231, 113, 71, 162, 151, 224, 199, 217, 34, 153, 164, 140, 87, 245, 61, 136, 209, 223, 255 }, new byte[] { 84, 204, 170, 0, 235, 103, 109, 53, 65, 179, 81, 138, 1, 199, 66, 206, 32, 137, 185, 186, 139, 251, 42, 143, 36, 222, 234, 123, 97, 111, 48, 166, 91, 9, 203, 94, 17, 152, 37, 174, 146, 54, 50, 74, 107, 108, 142, 116, 186, 9, 89, 26, 105, 108, 113, 74, 5, 112, 16, 14, 33, 55, 8, 158, 120, 249, 207, 80, 59, 86, 135, 108, 120, 120, 67, 139, 248, 228, 66, 219, 121, 166, 230, 28, 29, 99, 202, 33, 249, 40, 134, 217, 93, 56, 1, 228, 28, 161, 140, 174, 194, 222, 54, 106, 200, 18, 22, 108, 80, 10, 19, 185, 203, 150, 137, 146, 23, 189, 70, 99, 113, 20, 156, 52, 154, 163, 115, 131 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 28, 6, 946, DateTimeKind.Utc).AddTicks(5526), new byte[] { 72, 88, 135, 103, 209, 65, 15, 5, 19, 64, 195, 163, 212, 244, 193, 6, 242, 195, 181, 219, 143, 124, 245, 107, 70, 117, 154, 188, 63, 98, 25, 159, 24, 80, 160, 159, 176, 174, 38, 129, 146, 65, 13, 237, 204, 75, 186, 98, 68, 100, 123, 104, 139, 22, 99, 52, 235, 40, 49, 18, 139, 99, 240, 191 }, new byte[] { 92, 226, 71, 63, 96, 43, 157, 220, 66, 26, 249, 40, 100, 163, 14, 146, 73, 69, 181, 90, 66, 112, 192, 232, 82, 221, 114, 134, 132, 249, 80, 252, 16, 129, 34, 31, 49, 200, 194, 170, 216, 216, 214, 88, 176, 160, 215, 187, 61, 128, 33, 43, 68, 15, 207, 90, 254, 68, 164, 72, 109, 42, 99, 50, 110, 124, 34, 63, 211, 184, 14, 175, 120, 247, 56, 202, 85, 150, 159, 138, 128, 126, 201, 223, 103, 57, 62, 113, 254, 52, 158, 129, 163, 94, 185, 19, 227, 198, 185, 80, 58, 129, 83, 45, 151, 56, 252, 71, 10, 135, 74, 30, 231, 176, 147, 232, 30, 225, 36, 65, 75, 31, 253, 98, 16, 218, 84, 184 } });
        }
    }
}
