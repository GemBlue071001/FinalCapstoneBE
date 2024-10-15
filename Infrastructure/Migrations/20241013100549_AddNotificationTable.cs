using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ReceiverId = table.Column<int>(type: "integer", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    JobPostActivityId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_JobPostActivities_JobPostActivityId",
                        column: x => x.JobPostActivityId,
                        principalTable: "JobPostActivities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 641, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 641, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 10, 5, 47, 641, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(3695), new byte[] { 117, 129, 117, 60, 97, 23, 158, 42, 10, 32, 160, 127, 223, 5, 40, 98, 51, 10, 152, 134, 100, 237, 17, 68, 55, 22, 104, 222, 89, 81, 37, 167, 120, 102, 166, 249, 47, 12, 100, 169, 127, 83, 49, 122, 122, 110, 180, 61, 102, 16, 242, 25, 217, 104, 107, 118, 162, 209, 118, 129, 202, 75, 72, 190 }, new byte[] { 154, 245, 15, 33, 102, 54, 44, 118, 125, 132, 255, 0, 194, 4, 133, 0, 166, 177, 184, 109, 135, 61, 87, 197, 34, 244, 26, 127, 185, 228, 24, 231, 205, 177, 29, 152, 190, 67, 239, 124, 34, 106, 108, 11, 10, 203, 109, 196, 25, 252, 42, 108, 102, 133, 49, 123, 164, 135, 26, 76, 85, 242, 184, 4, 199, 166, 9, 103, 207, 118, 250, 86, 35, 183, 108, 240, 36, 239, 239, 74, 196, 51, 121, 247, 91, 106, 16, 210, 82, 18, 65, 62, 152, 60, 199, 68, 102, 166, 22, 136, 227, 0, 107, 148, 176, 210, 197, 153, 154, 190, 194, 61, 34, 100, 181, 97, 128, 158, 84, 166, 102, 151, 112, 59, 155, 201, 243, 181 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(3709), new byte[] { 133, 8, 133, 1, 156, 236, 103, 144, 98, 45, 61, 235, 174, 70, 176, 167, 35, 251, 250, 185, 171, 74, 226, 195, 4, 25, 21, 27, 86, 177, 10, 134, 132, 12, 21, 185, 50, 156, 232, 39, 92, 16, 32, 181, 153, 97, 82, 146, 65, 7, 171, 92, 74, 31, 136, 138, 207, 151, 71, 138, 40, 75, 221, 166 }, new byte[] { 123, 101, 157, 225, 59, 245, 223, 23, 217, 77, 173, 2, 119, 178, 176, 54, 192, 16, 180, 98, 72, 196, 245, 162, 100, 119, 19, 26, 35, 193, 171, 144, 212, 126, 154, 252, 95, 200, 135, 88, 59, 224, 51, 68, 203, 188, 99, 140, 113, 107, 39, 170, 112, 9, 145, 226, 112, 222, 166, 66, 40, 51, 195, 69, 225, 156, 187, 160, 76, 50, 116, 48, 195, 241, 210, 153, 240, 99, 133, 134, 147, 13, 85, 170, 219, 84, 182, 22, 7, 218, 4, 23, 76, 118, 69, 132, 255, 189, 21, 169, 152, 111, 19, 47, 61, 26, 255, 57, 250, 102, 50, 213, 130, 140, 99, 251, 117, 128, 204, 255, 174, 240, 96, 133, 64, 115, 167, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(3711), new byte[] { 153, 64, 149, 139, 127, 40, 222, 137, 74, 110, 105, 243, 62, 188, 100, 248, 163, 112, 139, 127, 153, 201, 203, 111, 151, 127, 155, 245, 142, 40, 50, 238, 251, 51, 17, 131, 157, 41, 89, 212, 145, 0, 92, 146, 177, 75, 38, 146, 191, 67, 30, 136, 110, 85, 235, 108, 50, 138, 94, 41, 104, 27, 30, 145 }, new byte[] { 31, 180, 168, 99, 98, 42, 99, 44, 32, 181, 145, 57, 113, 26, 64, 198, 111, 122, 25, 216, 250, 142, 90, 228, 167, 69, 207, 245, 63, 154, 35, 234, 144, 220, 210, 74, 101, 177, 185, 168, 133, 154, 216, 126, 145, 216, 198, 166, 217, 124, 3, 184, 52, 214, 58, 42, 78, 99, 116, 211, 76, 221, 55, 247, 156, 162, 111, 74, 97, 6, 254, 36, 37, 32, 142, 182, 92, 129, 105, 86, 229, 80, 78, 136, 205, 197, 11, 86, 220, 226, 41, 63, 156, 130, 114, 108, 153, 205, 62, 142, 106, 64, 131, 216, 155, 238, 214, 250, 236, 105, 206, 145, 161, 135, 86, 212, 152, 162, 37, 158, 35, 127, 122, 249, 32, 60, 60, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 10, 5, 47, 638, DateTimeKind.Utc).AddTicks(3712), new byte[] { 25, 135, 45, 77, 148, 141, 42, 251, 148, 142, 157, 4, 59, 46, 49, 193, 129, 81, 159, 252, 206, 3, 104, 47, 193, 111, 155, 129, 149, 93, 81, 212, 154, 155, 93, 52, 33, 7, 154, 192, 34, 119, 208, 6, 249, 121, 89, 61, 59, 59, 7, 9, 115, 61, 128, 120, 155, 28, 199, 157, 169, 97, 120, 242 }, new byte[] { 124, 31, 240, 96, 55, 163, 194, 169, 84, 86, 108, 152, 109, 203, 64, 219, 126, 133, 58, 58, 202, 80, 170, 38, 63, 60, 194, 19, 185, 246, 189, 190, 191, 81, 171, 108, 251, 236, 196, 220, 4, 83, 87, 120, 119, 142, 204, 51, 75, 49, 172, 110, 170, 181, 136, 25, 140, 253, 136, 93, 80, 70, 204, 49, 89, 215, 169, 26, 36, 59, 74, 57, 140, 76, 88, 118, 108, 231, 50, 101, 91, 24, 6, 210, 237, 139, 129, 33, 41, 175, 215, 152, 227, 197, 11, 59, 210, 96, 141, 105, 16, 102, 51, 103, 78, 148, 81, 119, 92, 226, 187, 234, 146, 70, 156, 187, 136, 69, 59, 71, 94, 140, 207, 145, 19, 75, 245, 113 } });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_JobPostActivityId",
                table: "Notifications",
                column: "JobPostActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ReceiverId",
                table: "Notifications",
                column: "ReceiverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5772), new byte[] { 115, 126, 19, 90, 30, 100, 162, 242, 213, 162, 85, 17, 23, 197, 205, 229, 213, 131, 137, 180, 71, 221, 36, 7, 11, 171, 239, 167, 123, 215, 0, 188, 221, 167, 63, 97, 78, 181, 252, 53, 154, 127, 93, 254, 23, 86, 30, 27, 53, 113, 225, 226, 182, 138, 158, 170, 67, 62, 153, 155, 95, 116, 87, 56 }, new byte[] { 70, 218, 92, 107, 177, 7, 204, 51, 237, 195, 21, 56, 80, 136, 219, 69, 14, 94, 169, 211, 246, 167, 63, 155, 11, 87, 127, 85, 185, 181, 251, 248, 166, 170, 67, 4, 27, 174, 80, 235, 81, 44, 232, 72, 245, 166, 181, 231, 81, 244, 236, 5, 67, 77, 39, 123, 220, 160, 38, 67, 200, 17, 89, 213, 38, 49, 201, 158, 238, 204, 167, 72, 60, 173, 163, 121, 82, 210, 42, 219, 22, 209, 193, 192, 114, 36, 73, 88, 175, 96, 218, 146, 71, 196, 167, 71, 65, 247, 33, 106, 242, 70, 132, 107, 138, 213, 246, 70, 75, 142, 225, 56, 172, 26, 46, 252, 19, 17, 9, 177, 254, 46, 234, 163, 51, 109, 175, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5778), new byte[] { 79, 165, 141, 65, 121, 254, 70, 23, 107, 197, 209, 233, 140, 222, 203, 186, 150, 242, 234, 19, 106, 111, 68, 66, 211, 108, 92, 55, 232, 227, 219, 30, 203, 149, 169, 198, 178, 19, 180, 53, 165, 225, 112, 189, 100, 65, 23, 140, 26, 0, 220, 98, 157, 86, 77, 172, 74, 54, 24, 21, 223, 215, 63, 67 }, new byte[] { 194, 135, 248, 157, 134, 64, 7, 37, 2, 127, 15, 139, 10, 146, 193, 197, 193, 153, 104, 193, 123, 200, 100, 32, 45, 206, 137, 142, 99, 137, 176, 90, 125, 250, 204, 90, 128, 201, 139, 34, 104, 8, 120, 44, 176, 127, 129, 37, 39, 53, 137, 0, 75, 195, 192, 92, 207, 106, 9, 126, 234, 119, 119, 40, 187, 246, 213, 142, 215, 254, 44, 182, 183, 28, 85, 75, 110, 163, 130, 164, 109, 94, 214, 209, 33, 184, 162, 32, 225, 104, 195, 216, 168, 73, 214, 43, 126, 223, 178, 28, 15, 2, 169, 84, 32, 118, 153, 233, 82, 99, 80, 218, 184, 237, 101, 74, 52, 151, 234, 193, 222, 130, 150, 182, 76, 7, 206, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5780), new byte[] { 141, 224, 115, 127, 82, 163, 88, 63, 37, 184, 136, 199, 32, 50, 230, 68, 254, 172, 103, 105, 224, 140, 93, 162, 100, 249, 248, 32, 71, 110, 242, 188, 204, 174, 0, 48, 143, 176, 211, 188, 31, 222, 189, 198, 186, 178, 133, 112, 154, 173, 145, 1, 30, 86, 201, 129, 132, 194, 155, 156, 220, 150, 170, 68 }, new byte[] { 166, 209, 63, 33, 149, 157, 14, 184, 253, 93, 218, 94, 81, 57, 9, 92, 249, 58, 88, 100, 181, 125, 247, 110, 107, 70, 247, 130, 147, 51, 61, 218, 91, 170, 204, 240, 66, 123, 56, 72, 172, 23, 199, 197, 118, 203, 174, 223, 55, 209, 134, 163, 149, 19, 106, 2, 21, 12, 96, 210, 220, 108, 116, 221, 201, 93, 90, 35, 118, 127, 185, 30, 115, 55, 251, 21, 219, 107, 207, 251, 69, 183, 154, 153, 165, 125, 241, 225, 164, 162, 45, 54, 16, 210, 55, 161, 222, 111, 51, 209, 200, 222, 69, 31, 157, 141, 4, 162, 157, 48, 23, 68, 255, 127, 61, 228, 163, 217, 166, 185, 53, 35, 12, 255, 207, 248, 92, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5781), new byte[] { 132, 224, 218, 120, 83, 112, 29, 85, 174, 20, 201, 85, 44, 236, 107, 40, 55, 2, 50, 59, 62, 240, 161, 31, 3, 57, 86, 106, 200, 173, 196, 63, 6, 241, 153, 212, 199, 158, 80, 249, 175, 115, 217, 222, 35, 216, 41, 154, 199, 114, 76, 39, 1, 156, 61, 28, 20, 192, 195, 19, 199, 196, 187, 48 }, new byte[] { 165, 63, 240, 203, 214, 47, 103, 2, 254, 178, 12, 167, 136, 22, 110, 46, 52, 107, 236, 43, 160, 130, 189, 63, 28, 193, 95, 157, 184, 188, 160, 205, 34, 118, 49, 238, 172, 30, 33, 131, 4, 99, 203, 119, 7, 177, 161, 13, 171, 92, 245, 31, 134, 195, 115, 15, 124, 91, 97, 147, 83, 143, 215, 5, 169, 245, 78, 162, 84, 243, 161, 202, 134, 253, 163, 240, 96, 186, 59, 114, 182, 168, 12, 201, 154, 220, 242, 127, 131, 224, 221, 140, 121, 50, 122, 140, 115, 128, 66, 49, 92, 151, 90, 211, 177, 23, 74, 175, 102, 75, 56, 84, 115, 187, 114, 203, 88, 135, 47, 205, 18, 44, 114, 120, 133, 142, 5, 99 } });
        }
    }
}
