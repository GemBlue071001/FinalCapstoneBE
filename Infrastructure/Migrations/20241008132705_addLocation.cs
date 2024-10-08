using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_JobPosts_JobLocations_JobLocationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_JobLocationId",
                table: "JobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivitys",
                table: "JobPostActivitys");

            migrationBuilder.DeleteData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "City",
                table: "JobLocations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "JobLocations");

            migrationBuilder.DropColumn(
                name: "District",
                table: "JobLocations");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "JobLocations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "JobLocations");

            migrationBuilder.RenameTable(
                name: "JobPostActivitys",
                newName: "JobPostActivities");

            migrationBuilder.RenameColumn(
                name: "StressAddress",
                table: "JobLocations",
                newName: "StressAddressDetail");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivitys_UserId",
                table: "JobPostActivities",
                newName: "IX_JobPostActivities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivitys_JobPostId",
                table: "JobPostActivities",
                newName: "IX_JobPostActivities_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivitys_CvId",
                table: "JobPostActivities",
                newName: "IX_JobPostActivities_CvId");

            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "JobLocations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "JobLocations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivities",
                table: "JobPostActivities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6109), new byte[] { 203, 63, 243, 219, 110, 252, 118, 100, 59, 177, 158, 247, 115, 151, 81, 165, 79, 22, 85, 16, 12, 79, 167, 184, 233, 95, 217, 220, 176, 31, 184, 35, 159, 205, 228, 117, 8, 234, 27, 30, 227, 152, 205, 24, 188, 181, 13, 195, 74, 169, 103, 78, 254, 103, 31, 202, 36, 65, 62, 104, 108, 249, 33, 109 }, new byte[] { 95, 125, 165, 155, 0, 1, 238, 42, 247, 41, 22, 112, 225, 27, 219, 179, 183, 21, 87, 111, 74, 204, 229, 124, 106, 211, 230, 114, 239, 107, 128, 147, 206, 38, 93, 174, 163, 249, 74, 233, 176, 146, 78, 215, 176, 157, 81, 16, 213, 17, 181, 61, 63, 103, 103, 105, 38, 10, 43, 144, 229, 5, 81, 245, 87, 0, 243, 182, 168, 0, 116, 72, 96, 96, 81, 154, 53, 15, 189, 137, 250, 208, 192, 24, 23, 250, 236, 134, 121, 116, 136, 10, 177, 171, 90, 213, 53, 118, 66, 97, 27, 26, 24, 60, 89, 144, 29, 119, 199, 221, 233, 33, 8, 31, 219, 71, 13, 37, 56, 124, 132, 68, 116, 230, 213, 95, 198, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6118), new byte[] { 3, 182, 221, 166, 220, 142, 178, 161, 120, 184, 161, 238, 130, 82, 104, 110, 11, 132, 46, 138, 246, 109, 166, 198, 3, 216, 244, 50, 252, 69, 179, 160, 133, 249, 2, 1, 166, 98, 34, 153, 174, 209, 58, 144, 110, 249, 1, 213, 193, 125, 203, 68, 38, 189, 165, 121, 84, 103, 58, 58, 231, 31, 214, 176 }, new byte[] { 145, 219, 117, 30, 98, 167, 191, 219, 190, 25, 111, 131, 241, 247, 215, 122, 140, 33, 211, 86, 29, 76, 206, 28, 169, 100, 197, 201, 5, 112, 206, 14, 77, 125, 10, 155, 61, 93, 169, 187, 6, 93, 185, 32, 185, 28, 211, 228, 82, 89, 227, 3, 232, 168, 179, 231, 178, 242, 31, 140, 52, 134, 207, 221, 179, 53, 88, 23, 50, 186, 8, 240, 169, 126, 191, 153, 242, 39, 127, 3, 75, 188, 45, 25, 221, 95, 177, 186, 26, 87, 178, 250, 89, 253, 220, 120, 166, 247, 195, 222, 191, 196, 50, 161, 37, 143, 109, 25, 42, 73, 110, 190, 91, 206, 50, 191, 197, 22, 51, 100, 119, 146, 97, 142, 61, 24, 137, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6120), new byte[] { 33, 228, 68, 102, 219, 185, 128, 158, 23, 99, 91, 185, 144, 77, 206, 3, 99, 9, 91, 67, 31, 227, 81, 138, 217, 137, 112, 18, 74, 250, 111, 175, 8, 105, 172, 253, 8, 130, 148, 173, 18, 105, 129, 233, 107, 52, 90, 229, 1, 79, 189, 233, 216, 73, 210, 66, 162, 195, 87, 222, 158, 42, 17, 177 }, new byte[] { 30, 203, 34, 106, 116, 113, 4, 193, 55, 71, 208, 152, 172, 250, 123, 163, 149, 97, 220, 120, 198, 97, 33, 72, 146, 72, 130, 159, 247, 11, 138, 178, 211, 221, 150, 67, 150, 9, 32, 46, 191, 26, 119, 207, 88, 242, 10, 252, 201, 34, 228, 184, 253, 151, 254, 142, 146, 69, 39, 8, 98, 85, 40, 245, 49, 35, 88, 65, 228, 145, 255, 77, 252, 16, 162, 177, 108, 247, 235, 40, 68, 161, 182, 169, 158, 168, 108, 3, 214, 15, 254, 172, 246, 102, 121, 221, 216, 194, 63, 148, 204, 156, 193, 223, 120, 62, 16, 111, 23, 134, 180, 27, 110, 234, 168, 50, 98, 153, 183, 42, 81, 239, 89, 60, 10, 149, 223, 249 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6121), new byte[] { 140, 4, 28, 141, 124, 86, 123, 139, 22, 206, 121, 63, 66, 119, 19, 155, 28, 123, 244, 237, 62, 106, 134, 17, 16, 138, 7, 92, 129, 232, 163, 42, 5, 103, 185, 118, 212, 188, 135, 174, 93, 195, 83, 182, 176, 5, 67, 150, 4, 37, 211, 215, 95, 49, 218, 190, 94, 135, 50, 1, 137, 238, 19, 118 }, new byte[] { 219, 25, 57, 25, 69, 222, 193, 94, 132, 210, 36, 42, 66, 7, 77, 207, 159, 14, 8, 0, 21, 97, 100, 12, 49, 23, 205, 36, 56, 46, 34, 10, 131, 130, 38, 5, 36, 31, 156, 197, 170, 13, 79, 95, 54, 164, 48, 93, 78, 75, 161, 76, 95, 24, 203, 234, 171, 244, 4, 202, 80, 190, 202, 185, 9, 64, 25, 8, 29, 113, 127, 200, 41, 16, 176, 146, 62, 140, 233, 3, 125, 34, 253, 178, 191, 225, 139, 143, 177, 237, 9, 48, 153, 118, 154, 118, 138, 149, 194, 89, 5, 180, 36, 140, 11, 164, 110, 188, 106, 206, 195, 185, 127, 226, 99, 112, 107, 8, 205, 168, 233, 120, 57, 8, 216, 163, 224, 197 } });

            migrationBuilder.CreateIndex(
                name: "IX_JobLocations_JobPostId",
                table: "JobLocations",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobLocations_LocationId",
                table: "JobLocations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobLocations_JobPosts_JobPostId",
                table: "JobLocations",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobLocations_Locations_LocationId",
                table: "JobLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivities_CVs_CvId",
                table: "JobPostActivities",
                column: "CvId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivities_JobPosts_JobPostId",
                table: "JobPostActivities",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostActivities_Users_UserId",
                table: "JobPostActivities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobLocations_JobPosts_JobPostId",
                table: "JobLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_JobLocations_Locations_LocationId",
                table: "JobLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivities_CVs_CvId",
                table: "JobPostActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivities_JobPosts_JobPostId",
                table: "JobPostActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostActivities_Users_UserId",
                table: "JobPostActivities");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_JobLocations_JobPostId",
                table: "JobLocations");

            migrationBuilder.DropIndex(
                name: "IX_JobLocations_LocationId",
                table: "JobLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostActivities",
                table: "JobPostActivities");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "JobLocations");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "JobLocations");

            migrationBuilder.RenameTable(
                name: "JobPostActivities",
                newName: "JobPostActivitys");

            migrationBuilder.RenameColumn(
                name: "StressAddressDetail",
                table: "JobLocations",
                newName: "StressAddress");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivities_UserId",
                table: "JobPostActivitys",
                newName: "IX_JobPostActivitys_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivities_JobPostId",
                table: "JobPostActivitys",
                newName: "IX_JobPostActivitys_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostActivities_CvId",
                table: "JobPostActivitys",
                newName: "IX_JobPostActivitys_CvId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobLocations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "JobLocations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "JobLocations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "JobLocations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "JobLocations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostActivitys",
                table: "JobPostActivitys",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "JobLocations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedDate", "District", "IsDeleted", "ModifiedBy", "ModifiedDate", "PostCode", "State", "StressAddress" },
                values: new object[] { 1, "HCM", "VietNam", null, new DateTime(2024, 10, 7, 15, 27, 34, 438, DateTimeKind.Utc).AddTicks(4153), "District 9", false, null, null, "123", "state", "521 Le Van Si Stress" });

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

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobLocationId",
                table: "JobPosts",
                column: "JobLocationId");

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
                name: "FK_JobPosts_JobLocations_JobLocationId",
                table: "JobPosts",
                column: "JobLocationId",
                principalTable: "JobLocations",
                principalColumn: "Id");
        }
    }
}
