using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Attendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(3855),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CampaignJobId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_CampaignJobs_CampaignJobId",
                        column: x => x.CampaignJobId,
                        principalTable: "CampaignJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(183), new byte[] { 44, 104, 138, 155, 127, 15, 165, 163, 55, 37, 156, 158, 21, 76, 73, 141, 157, 189, 214, 184, 216, 57, 234, 160, 58, 47, 89, 10, 140, 144, 102, 169, 162, 140, 187, 136, 64, 227, 88, 86, 19, 236, 195, 165, 29, 210, 80, 32, 79, 217, 98, 146, 64, 251, 241, 68, 160, 163, 75, 134, 117, 134, 36, 92 }, new byte[] { 189, 113, 95, 52, 27, 72, 193, 233, 254, 88, 31, 30, 88, 232, 147, 73, 101, 217, 214, 199, 236, 27, 97, 82, 155, 126, 214, 188, 6, 183, 185, 160, 58, 24, 84, 147, 144, 4, 226, 111, 79, 130, 47, 8, 219, 118, 135, 74, 254, 87, 183, 240, 113, 88, 95, 225, 222, 168, 171, 147, 1, 101, 1, 206, 244, 82, 34, 2, 158, 219, 233, 228, 105, 58, 226, 212, 114, 32, 184, 45, 209, 114, 99, 135, 181, 186, 22, 225, 96, 101, 148, 121, 219, 5, 202, 233, 86, 112, 160, 175, 46, 237, 181, 251, 207, 69, 58, 184, 114, 82, 127, 169, 213, 73, 61, 158, 245, 29, 194, 78, 139, 126, 174, 133, 38, 86, 81, 136 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(195), new byte[] { 98, 234, 41, 246, 16, 219, 234, 104, 75, 53, 115, 235, 58, 230, 64, 224, 56, 7, 158, 185, 142, 165, 1, 158, 142, 77, 190, 36, 80, 41, 104, 123, 90, 140, 67, 122, 109, 6, 153, 153, 208, 220, 47, 97, 242, 81, 211, 22, 21, 248, 162, 32, 56, 202, 108, 231, 27, 63, 72, 151, 118, 232, 179, 161 }, new byte[] { 205, 181, 160, 70, 191, 46, 149, 89, 171, 102, 195, 0, 122, 44, 193, 188, 64, 91, 94, 134, 72, 178, 121, 36, 181, 125, 181, 128, 218, 175, 49, 51, 206, 187, 164, 19, 27, 162, 142, 240, 227, 1, 37, 223, 215, 234, 92, 72, 255, 114, 101, 153, 225, 107, 46, 218, 255, 38, 87, 63, 253, 60, 104, 172, 225, 245, 200, 189, 191, 255, 237, 53, 169, 75, 73, 91, 31, 189, 12, 145, 40, 98, 197, 133, 137, 58, 20, 35, 46, 69, 4, 238, 124, 140, 199, 200, 227, 193, 114, 121, 196, 54, 53, 32, 109, 201, 240, 74, 45, 58, 66, 96, 179, 248, 142, 17, 151, 85, 203, 233, 150, 91, 105, 205, 59, 76, 134, 181 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(196), new byte[] { 110, 127, 100, 245, 78, 104, 202, 160, 249, 90, 23, 193, 26, 218, 60, 249, 132, 31, 58, 5, 88, 31, 244, 129, 229, 129, 117, 251, 23, 159, 21, 158, 246, 16, 184, 250, 6, 149, 17, 129, 106, 253, 159, 239, 28, 198, 12, 142, 30, 94, 92, 95, 182, 148, 36, 9, 41, 33, 177, 161, 189, 103, 155, 213 }, new byte[] { 44, 196, 124, 213, 246, 206, 203, 85, 152, 101, 39, 174, 68, 4, 209, 234, 205, 245, 156, 150, 15, 11, 87, 245, 183, 137, 129, 211, 75, 209, 106, 164, 166, 133, 128, 26, 84, 183, 160, 16, 117, 4, 15, 86, 26, 255, 144, 196, 202, 69, 70, 236, 20, 153, 110, 158, 7, 200, 16, 210, 166, 148, 76, 193, 24, 78, 181, 181, 85, 169, 80, 103, 100, 7, 148, 71, 26, 208, 110, 239, 123, 37, 250, 10, 114, 137, 247, 125, 157, 82, 201, 78, 176, 105, 150, 157, 45, 144, 126, 44, 173, 133, 129, 59, 182, 186, 93, 8, 112, 176, 50, 70, 91, 249, 108, 114, 12, 46, 117, 110, 70, 36, 232, 87, 212, 134, 46, 101 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(197), new byte[] { 84, 161, 6, 4, 132, 65, 77, 134, 141, 182, 78, 235, 238, 93, 126, 45, 38, 18, 109, 249, 21, 216, 154, 90, 146, 185, 199, 33, 150, 56, 145, 116, 235, 112, 176, 179, 154, 68, 50, 169, 220, 224, 27, 195, 0, 236, 14, 205, 81, 82, 186, 116, 148, 32, 216, 236, 43, 121, 4, 7, 214, 62, 47, 226 }, new byte[] { 44, 140, 86, 181, 250, 185, 99, 46, 130, 24, 70, 85, 242, 36, 173, 121, 192, 54, 81, 131, 237, 153, 102, 115, 168, 45, 109, 30, 38, 41, 118, 161, 145, 63, 83, 52, 242, 111, 40, 77, 241, 235, 250, 174, 124, 136, 218, 253, 11, 163, 197, 27, 134, 15, 220, 4, 201, 185, 151, 37, 170, 180, 17, 174, 11, 158, 153, 163, 50, 179, 79, 70, 86, 3, 215, 223, 93, 162, 6, 69, 248, 81, 137, 246, 63, 177, 153, 62, 126, 41, 63, 105, 124, 56, 18, 249, 137, 42, 88, 78, 71, 252, 22, 78, 16, 179, 224, 200, 71, 250, 199, 106, 163, 224, 30, 165, 15, 45, 140, 111, 40, 235, 56, 117, 31, 160, 0, 7 } });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_CampaignJobId",
                table: "Attendances",
                column: "CampaignJobId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_UserId",
                table: "Attendances",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(8291),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 28, 14, 57, 24, 693, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(888), new byte[] { 132, 11, 203, 145, 183, 234, 235, 171, 226, 88, 240, 61, 105, 135, 172, 84, 49, 20, 222, 160, 129, 67, 31, 104, 25, 32, 40, 231, 198, 26, 217, 133, 6, 59, 183, 111, 70, 252, 114, 28, 186, 70, 91, 225, 192, 203, 165, 218, 159, 189, 37, 0, 201, 182, 91, 228, 81, 216, 28, 134, 204, 148, 245, 51 }, new byte[] { 127, 183, 169, 156, 56, 117, 184, 140, 255, 156, 13, 71, 220, 91, 187, 17, 88, 60, 1, 91, 243, 16, 144, 39, 221, 131, 188, 243, 28, 177, 30, 227, 162, 141, 24, 138, 5, 38, 165, 54, 207, 210, 43, 230, 208, 118, 7, 231, 169, 101, 166, 202, 194, 210, 143, 139, 132, 92, 105, 26, 193, 116, 4, 6, 103, 203, 41, 157, 57, 14, 220, 46, 39, 226, 65, 115, 56, 128, 230, 57, 240, 246, 133, 195, 134, 128, 119, 60, 43, 233, 218, 23, 183, 67, 4, 16, 76, 57, 112, 207, 158, 18, 64, 133, 148, 138, 54, 164, 89, 10, 30, 54, 69, 86, 163, 154, 193, 160, 118, 56, 120, 26, 128, 74, 185, 70, 135, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(895), new byte[] { 108, 254, 5, 237, 134, 164, 78, 38, 118, 220, 162, 141, 196, 90, 229, 64, 160, 245, 57, 153, 225, 44, 157, 86, 197, 45, 156, 166, 168, 169, 80, 190, 38, 85, 36, 247, 197, 71, 159, 213, 216, 209, 74, 142, 121, 5, 52, 194, 247, 67, 47, 145, 230, 188, 13, 202, 55, 241, 153, 30, 133, 121, 84, 149 }, new byte[] { 187, 124, 154, 213, 200, 215, 96, 220, 89, 24, 90, 176, 110, 34, 117, 122, 214, 105, 188, 254, 185, 137, 90, 205, 71, 141, 126, 161, 243, 217, 149, 96, 191, 149, 54, 248, 123, 80, 27, 173, 6, 17, 17, 52, 172, 149, 152, 133, 197, 95, 247, 31, 134, 247, 204, 127, 149, 64, 85, 148, 20, 109, 116, 47, 112, 240, 152, 125, 253, 45, 57, 35, 184, 246, 13, 59, 219, 34, 128, 176, 167, 169, 19, 50, 215, 182, 178, 225, 156, 176, 15, 203, 221, 126, 14, 138, 69, 71, 148, 0, 190, 201, 7, 74, 78, 240, 211, 34, 236, 15, 205, 144, 149, 43, 51, 50, 157, 38, 10, 58, 159, 51, 147, 223, 46, 194, 162, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(942), new byte[] { 56, 252, 32, 236, 155, 85, 158, 55, 20, 107, 133, 231, 72, 25, 146, 209, 247, 25, 143, 13, 233, 143, 12, 73, 182, 222, 146, 38, 252, 165, 179, 4, 232, 156, 233, 212, 100, 204, 11, 169, 39, 54, 204, 242, 250, 161, 111, 16, 163, 101, 121, 15, 217, 192, 46, 127, 106, 115, 79, 191, 250, 169, 155, 203 }, new byte[] { 17, 252, 72, 16, 82, 123, 176, 122, 202, 97, 161, 108, 207, 2, 81, 126, 132, 123, 198, 136, 95, 57, 229, 132, 97, 59, 119, 36, 233, 188, 237, 205, 17, 178, 25, 63, 220, 94, 42, 221, 16, 37, 149, 253, 31, 71, 38, 165, 135, 3, 186, 182, 233, 245, 52, 164, 185, 76, 48, 81, 243, 231, 235, 41, 203, 154, 172, 50, 128, 66, 162, 54, 178, 95, 39, 42, 211, 219, 76, 16, 22, 178, 36, 221, 5, 94, 171, 126, 134, 206, 84, 155, 140, 180, 54, 97, 45, 213, 48, 93, 65, 194, 68, 69, 175, 249, 207, 148, 206, 29, 219, 203, 104, 132, 96, 104, 196, 164, 35, 200, 33, 192, 149, 42, 25, 125, 80, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 17, 15, 5, 849, DateTimeKind.Utc).AddTicks(944), new byte[] { 86, 224, 131, 76, 125, 57, 86, 122, 178, 106, 80, 141, 22, 186, 26, 206, 40, 115, 116, 101, 70, 85, 70, 95, 95, 77, 105, 97, 79, 79, 214, 161, 254, 52, 129, 14, 214, 248, 226, 222, 10, 234, 5, 250, 174, 20, 244, 242, 161, 217, 6, 192, 29, 4, 200, 22, 71, 236, 111, 163, 108, 243, 125, 86 }, new byte[] { 50, 155, 188, 110, 54, 166, 117, 125, 244, 179, 100, 9, 82, 155, 128, 137, 109, 132, 249, 191, 198, 180, 242, 226, 175, 196, 97, 161, 202, 220, 122, 102, 254, 68, 138, 236, 183, 203, 76, 78, 153, 22, 247, 54, 148, 186, 57, 165, 224, 201, 158, 129, 21, 194, 179, 61, 29, 160, 141, 85, 110, 148, 173, 248, 29, 64, 255, 0, 237, 46, 1, 69, 206, 123, 38, 140, 76, 253, 253, 43, 93, 59, 97, 203, 219, 48, 220, 210, 39, 177, 183, 210, 97, 183, 235, 145, 194, 142, 204, 73, 145, 34, 218, 254, 1, 243, 181, 217, 148, 33, 174, 218, 177, 99, 100, 6, 32, 136, 232, 148, 152, 175, 134, 72, 133, 114, 129, 248 } });
        }
    }
}
