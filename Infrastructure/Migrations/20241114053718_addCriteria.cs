using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCriteria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserJobAlertCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTile = table.Column<string>(type: "text", nullable: false),
                    MinSalary = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxSalary = table.Column<decimal>(type: "numeric", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: true),
                    SkillSetId = table.Column<int>(type: "integer", nullable: true),
                    JobTypeId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJobAlertCriterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserJobAlertCriterias_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserJobAlertCriterias_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserJobAlertCriterias_SkillSets_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserJobAlertCriterias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 534, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 534, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 37, 17, 536, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3660), new byte[] { 157, 173, 238, 170, 58, 10, 214, 122, 115, 12, 118, 122, 225, 136, 189, 1, 188, 139, 234, 154, 202, 119, 64, 32, 183, 235, 235, 144, 209, 132, 6, 24, 186, 235, 89, 148, 223, 206, 219, 129, 76, 145, 99, 46, 65, 139, 254, 246, 35, 57, 134, 133, 81, 234, 7, 197, 101, 250, 129, 25, 83, 97, 4, 144 }, new byte[] { 179, 5, 238, 40, 136, 56, 5, 195, 201, 20, 242, 222, 51, 223, 17, 244, 20, 39, 91, 141, 43, 150, 82, 228, 250, 35, 52, 243, 101, 10, 203, 131, 95, 112, 113, 65, 110, 59, 35, 249, 235, 10, 30, 216, 10, 139, 107, 203, 239, 157, 182, 20, 146, 34, 250, 24, 117, 232, 85, 63, 35, 162, 22, 43, 38, 84, 162, 25, 210, 196, 61, 117, 162, 142, 244, 108, 3, 82, 11, 85, 31, 213, 205, 126, 231, 137, 142, 162, 98, 2, 121, 161, 119, 241, 161, 187, 202, 63, 216, 112, 55, 208, 193, 51, 147, 23, 253, 16, 58, 196, 17, 135, 250, 71, 119, 216, 191, 103, 104, 245, 156, 228, 95, 220, 193, 73, 135, 84 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3667), new byte[] { 195, 89, 246, 49, 207, 43, 1, 16, 134, 97, 20, 77, 178, 191, 15, 75, 10, 101, 85, 29, 214, 169, 157, 77, 171, 93, 124, 112, 58, 22, 17, 107, 121, 150, 69, 191, 185, 9, 226, 36, 67, 74, 71, 179, 253, 184, 116, 107, 186, 155, 187, 30, 0, 54, 123, 93, 210, 106, 112, 36, 87, 105, 63, 118 }, new byte[] { 112, 106, 198, 132, 124, 235, 203, 37, 182, 159, 12, 33, 225, 92, 137, 204, 230, 209, 113, 96, 238, 169, 196, 2, 219, 193, 243, 255, 190, 154, 67, 118, 248, 141, 80, 11, 199, 23, 107, 84, 122, 237, 37, 254, 37, 115, 199, 165, 132, 246, 103, 201, 198, 37, 62, 233, 194, 77, 97, 155, 226, 228, 26, 149, 185, 241, 60, 204, 182, 1, 53, 231, 238, 127, 147, 159, 12, 5, 70, 195, 79, 102, 168, 36, 199, 190, 156, 183, 91, 244, 205, 87, 87, 117, 102, 245, 75, 94, 225, 119, 222, 5, 23, 65, 139, 218, 244, 33, 165, 74, 85, 170, 7, 61, 218, 213, 125, 209, 135, 88, 60, 204, 26, 86, 164, 206, 26, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3669), new byte[] { 184, 108, 68, 131, 9, 32, 0, 85, 112, 159, 115, 211, 134, 72, 152, 40, 87, 9, 202, 218, 4, 122, 232, 58, 158, 127, 24, 119, 16, 74, 46, 48, 191, 251, 192, 11, 48, 225, 180, 194, 150, 70, 175, 250, 154, 233, 130, 214, 215, 224, 92, 80, 28, 196, 40, 240, 35, 199, 39, 75, 152, 232, 127, 134 }, new byte[] { 91, 250, 167, 4, 229, 234, 68, 218, 127, 224, 41, 69, 6, 132, 197, 59, 231, 107, 218, 193, 48, 113, 219, 13, 65, 249, 52, 136, 113, 152, 141, 1, 83, 84, 63, 82, 100, 198, 21, 234, 241, 55, 0, 8, 75, 191, 190, 15, 227, 158, 10, 54, 201, 174, 28, 70, 147, 169, 203, 12, 118, 220, 166, 242, 95, 78, 249, 3, 146, 140, 20, 201, 52, 176, 134, 48, 91, 246, 34, 239, 191, 158, 13, 39, 37, 233, 145, 46, 119, 29, 11, 27, 109, 190, 144, 233, 122, 218, 172, 165, 149, 182, 41, 47, 34, 2, 182, 107, 246, 110, 158, 159, 78, 149, 146, 101, 155, 230, 103, 89, 139, 115, 37, 73, 28, 232, 142, 64 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 37, 17, 533, DateTimeKind.Utc).AddTicks(3671), new byte[] { 103, 218, 115, 157, 22, 255, 4, 27, 90, 14, 160, 50, 203, 170, 136, 44, 5, 19, 203, 17, 139, 144, 46, 227, 140, 90, 16, 180, 202, 66, 5, 233, 198, 11, 11, 220, 23, 70, 121, 22, 72, 8, 205, 109, 17, 4, 125, 160, 239, 55, 89, 18, 205, 102, 141, 70, 139, 182, 255, 142, 106, 97, 222, 165 }, new byte[] { 239, 85, 56, 2, 239, 102, 118, 0, 31, 72, 33, 231, 126, 189, 28, 212, 16, 151, 147, 134, 55, 45, 95, 159, 204, 252, 134, 149, 22, 34, 90, 88, 101, 9, 93, 80, 204, 231, 87, 128, 22, 78, 14, 200, 73, 202, 199, 168, 202, 196, 140, 59, 203, 233, 158, 242, 210, 202, 130, 253, 177, 145, 10, 22, 39, 104, 184, 234, 239, 98, 167, 121, 72, 57, 1, 42, 205, 92, 55, 177, 27, 247, 38, 57, 26, 199, 208, 43, 93, 101, 195, 16, 15, 213, 210, 15, 2, 227, 126, 210, 160, 233, 111, 31, 193, 254, 186, 80, 185, 83, 44, 14, 188, 127, 132, 156, 204, 92, 61, 224, 161, 229, 74, 11, 82, 253, 147, 49 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserJobAlertCriterias_JobTypeId",
                table: "UserJobAlertCriterias",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobAlertCriterias_LocationId",
                table: "UserJobAlertCriterias",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobAlertCriterias_SkillSetId",
                table: "UserJobAlertCriterias",
                column: "SkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobAlertCriterias_UserId",
                table: "UserJobAlertCriterias",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserJobAlertCriterias");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 414, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 414, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 14, 5, 31, 58, 416, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4286), new byte[] { 160, 163, 142, 34, 94, 207, 199, 193, 114, 155, 110, 118, 76, 81, 35, 180, 124, 10, 24, 178, 211, 187, 138, 107, 169, 15, 93, 136, 158, 85, 246, 220, 99, 225, 111, 191, 38, 190, 91, 15, 21, 167, 249, 106, 51, 11, 161, 136, 239, 117, 177, 208, 142, 92, 63, 43, 242, 83, 53, 120, 240, 20, 165, 91 }, new byte[] { 20, 54, 169, 212, 222, 29, 175, 186, 35, 220, 39, 67, 141, 159, 17, 180, 101, 179, 111, 49, 163, 238, 27, 133, 37, 216, 219, 102, 192, 19, 61, 119, 47, 136, 19, 77, 11, 76, 151, 186, 30, 252, 237, 74, 25, 163, 71, 45, 78, 65, 185, 94, 9, 234, 249, 162, 240, 30, 95, 141, 70, 4, 209, 159, 37, 23, 128, 18, 30, 208, 110, 185, 216, 180, 243, 45, 109, 196, 88, 240, 42, 193, 66, 32, 127, 132, 32, 125, 89, 116, 149, 38, 155, 255, 18, 85, 107, 98, 73, 141, 43, 86, 248, 63, 105, 216, 176, 216, 58, 141, 149, 166, 226, 57, 113, 176, 206, 74, 54, 254, 18, 36, 212, 214, 39, 92, 211, 52 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4294), new byte[] { 205, 210, 92, 137, 28, 190, 255, 236, 21, 85, 178, 46, 92, 120, 223, 29, 192, 255, 168, 132, 72, 156, 154, 106, 182, 223, 82, 29, 52, 66, 212, 114, 212, 233, 75, 36, 255, 155, 137, 114, 141, 6, 241, 33, 26, 83, 192, 164, 45, 75, 151, 96, 153, 221, 206, 105, 54, 152, 218, 138, 64, 171, 70, 0 }, new byte[] { 51, 145, 163, 129, 253, 44, 69, 36, 227, 131, 52, 228, 132, 130, 234, 182, 121, 25, 110, 190, 222, 244, 199, 120, 226, 48, 101, 194, 112, 104, 211, 214, 73, 96, 177, 70, 113, 73, 2, 183, 175, 157, 237, 77, 225, 25, 13, 11, 184, 124, 245, 44, 57, 126, 172, 128, 207, 66, 141, 179, 203, 215, 178, 243, 218, 27, 16, 196, 137, 13, 91, 215, 126, 160, 45, 50, 164, 174, 65, 49, 12, 150, 228, 30, 172, 2, 142, 212, 73, 199, 136, 202, 39, 32, 216, 102, 138, 61, 15, 202, 220, 88, 77, 29, 142, 238, 67, 173, 16, 157, 15, 104, 16, 113, 55, 117, 55, 5, 175, 89, 46, 65, 200, 94, 61, 241, 208, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4295), new byte[] { 216, 129, 31, 146, 139, 79, 165, 150, 44, 145, 29, 113, 201, 5, 186, 148, 57, 14, 224, 43, 144, 58, 86, 106, 213, 186, 98, 83, 3, 142, 85, 222, 231, 23, 185, 166, 178, 84, 109, 182, 169, 124, 118, 89, 112, 114, 27, 248, 50, 65, 241, 12, 210, 145, 225, 184, 206, 38, 43, 212, 102, 80, 124, 36 }, new byte[] { 2, 228, 26, 20, 142, 235, 221, 40, 127, 82, 115, 216, 195, 101, 87, 80, 192, 171, 84, 50, 181, 108, 186, 196, 67, 73, 79, 22, 197, 199, 242, 208, 56, 119, 58, 164, 78, 40, 184, 166, 223, 215, 133, 95, 158, 156, 28, 116, 246, 226, 25, 39, 35, 104, 54, 249, 132, 79, 249, 18, 194, 145, 188, 252, 24, 218, 225, 59, 21, 222, 90, 109, 215, 18, 51, 138, 159, 201, 212, 246, 114, 201, 123, 177, 21, 103, 182, 202, 238, 110, 53, 219, 215, 179, 83, 6, 139, 217, 196, 50, 170, 242, 113, 231, 64, 87, 148, 220, 237, 254, 32, 5, 79, 6, 132, 119, 92, 119, 118, 13, 180, 43, 104, 97, 137, 152, 139, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 14, 5, 31, 58, 413, DateTimeKind.Utc).AddTicks(4296), new byte[] { 177, 180, 52, 230, 103, 3, 72, 146, 195, 111, 252, 144, 106, 109, 4, 95, 10, 30, 81, 225, 226, 24, 181, 13, 101, 109, 107, 22, 158, 210, 94, 27, 242, 198, 237, 244, 52, 140, 74, 32, 38, 5, 41, 244, 228, 3, 186, 84, 52, 144, 125, 249, 199, 81, 198, 110, 90, 146, 170, 60, 191, 146, 95, 223 }, new byte[] { 41, 164, 203, 231, 25, 40, 118, 45, 189, 178, 0, 177, 110, 86, 96, 7, 47, 175, 206, 152, 232, 47, 80, 190, 4, 153, 21, 178, 208, 138, 36, 171, 233, 167, 127, 144, 168, 95, 229, 243, 142, 225, 83, 106, 247, 194, 182, 34, 121, 215, 117, 70, 246, 200, 81, 186, 58, 240, 97, 215, 161, 222, 212, 47, 244, 198, 180, 25, 36, 110, 85, 137, 133, 76, 89, 85, 18, 63, 61, 208, 5, 51, 91, 40, 94, 50, 209, 137, 70, 109, 51, 228, 58, 222, 167, 152, 57, 109, 111, 227, 89, 118, 220, 61, 108, 126, 46, 179, 72, 66, 41, 74, 190, 237, 161, 4, 138, 131, 120, 4, 96, 63, 198, 228, 187, 93, 117, 122 } });
        }
    }
}
