using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addEmailVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VerificationCode = table.Column<string>(type: "text", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailVerifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailVerifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 14, 25, 32, 75, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsEmailVerified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4263), false, new byte[] { 10, 222, 75, 126, 168, 151, 194, 217, 45, 140, 119, 132, 52, 139, 156, 183, 101, 229, 28, 18, 102, 107, 111, 54, 73, 63, 222, 149, 217, 48, 233, 208, 71, 13, 83, 100, 171, 34, 52, 197, 104, 227, 138, 140, 170, 13, 42, 170, 7, 216, 124, 0, 16, 72, 180, 134, 134, 42, 229, 215, 226, 16, 87, 46 }, new byte[] { 69, 175, 198, 130, 22, 105, 204, 103, 9, 27, 36, 46, 120, 32, 161, 199, 249, 211, 123, 187, 110, 125, 48, 86, 237, 35, 118, 196, 224, 13, 86, 183, 222, 128, 55, 125, 81, 119, 109, 203, 77, 108, 124, 101, 138, 24, 3, 147, 201, 23, 38, 158, 123, 148, 88, 19, 75, 90, 236, 155, 240, 171, 227, 86, 68, 230, 228, 176, 217, 165, 47, 144, 128, 229, 175, 128, 141, 23, 176, 55, 12, 48, 60, 242, 198, 141, 148, 78, 208, 85, 61, 223, 196, 188, 119, 33, 152, 13, 135, 18, 226, 160, 4, 9, 56, 58, 1, 28, 62, 119, 42, 77, 203, 147, 172, 4, 64, 205, 42, 237, 238, 15, 49, 212, 62, 125, 180, 131 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsEmailVerified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4271), false, new byte[] { 35, 90, 32, 128, 42, 135, 202, 217, 86, 164, 117, 136, 197, 199, 31, 71, 208, 232, 175, 190, 153, 215, 153, 140, 128, 123, 32, 35, 63, 146, 113, 96, 110, 244, 31, 164, 183, 135, 64, 129, 229, 13, 93, 111, 12, 83, 73, 248, 228, 177, 33, 24, 54, 16, 143, 147, 182, 195, 159, 212, 169, 85, 92, 93 }, new byte[] { 166, 109, 141, 143, 245, 252, 154, 51, 50, 41, 179, 246, 141, 1, 224, 87, 72, 133, 88, 209, 80, 52, 32, 161, 225, 83, 40, 219, 40, 248, 96, 173, 192, 85, 199, 162, 113, 199, 243, 133, 205, 253, 179, 0, 6, 227, 115, 241, 55, 68, 193, 163, 246, 100, 13, 240, 239, 193, 235, 50, 16, 136, 177, 122, 85, 29, 29, 80, 214, 15, 11, 175, 167, 224, 136, 25, 80, 251, 245, 70, 222, 86, 39, 91, 93, 93, 39, 147, 31, 15, 229, 216, 152, 72, 230, 10, 132, 179, 33, 17, 97, 201, 194, 101, 105, 157, 98, 111, 216, 108, 100, 31, 25, 90, 235, 34, 228, 121, 182, 214, 247, 31, 74, 28, 225, 34, 180, 2 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsEmailVerified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4274), false, new byte[] { 232, 133, 254, 27, 208, 66, 85, 157, 234, 78, 213, 34, 179, 87, 26, 2, 113, 168, 141, 236, 179, 147, 166, 47, 194, 117, 119, 94, 244, 180, 8, 13, 97, 157, 116, 59, 178, 75, 164, 65, 210, 136, 204, 8, 187, 36, 68, 125, 154, 95, 59, 98, 187, 174, 29, 116, 105, 37, 81, 239, 134, 150, 168, 108 }, new byte[] { 185, 20, 205, 43, 222, 93, 81, 50, 12, 220, 207, 46, 125, 124, 27, 53, 132, 20, 51, 169, 249, 131, 121, 243, 142, 93, 239, 218, 84, 155, 186, 91, 134, 91, 234, 54, 162, 136, 57, 152, 144, 65, 197, 203, 239, 31, 112, 110, 12, 56, 139, 40, 106, 95, 110, 183, 2, 0, 31, 118, 10, 139, 153, 219, 141, 196, 78, 109, 247, 252, 71, 232, 67, 28, 100, 154, 196, 233, 186, 14, 67, 23, 53, 211, 143, 17, 136, 8, 231, 75, 147, 66, 167, 53, 140, 46, 36, 214, 117, 130, 107, 141, 53, 120, 41, 243, 62, 186, 121, 239, 171, 153, 61, 212, 159, 110, 158, 192, 156, 113, 198, 253, 66, 251, 185, 236, 209, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsEmailVerified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 25, 32, 74, DateTimeKind.Utc).AddTicks(4275), false, new byte[] { 149, 40, 19, 6, 113, 9, 137, 241, 14, 77, 192, 224, 230, 138, 143, 237, 109, 37, 27, 132, 163, 21, 184, 23, 7, 132, 244, 210, 90, 121, 141, 147, 87, 5, 145, 117, 69, 255, 106, 150, 107, 70, 238, 1, 181, 43, 80, 95, 163, 12, 96, 254, 30, 231, 230, 1, 14, 42, 31, 107, 119, 60, 65, 40 }, new byte[] { 30, 190, 129, 90, 29, 14, 172, 224, 245, 200, 173, 220, 231, 191, 3, 28, 228, 168, 82, 87, 50, 193, 71, 204, 183, 219, 192, 89, 240, 151, 48, 186, 88, 255, 23, 10, 161, 161, 171, 16, 46, 117, 117, 204, 81, 79, 61, 69, 32, 147, 135, 221, 213, 31, 240, 180, 175, 35, 194, 33, 108, 41, 162, 63, 138, 224, 208, 196, 237, 32, 50, 135, 197, 77, 23, 93, 102, 37, 34, 202, 213, 202, 74, 200, 222, 223, 182, 108, 38, 12, 174, 57, 43, 125, 227, 136, 250, 77, 107, 204, 170, 168, 166, 231, 189, 14, 202, 208, 19, 176, 47, 64, 143, 136, 254, 21, 91, 171, 10, 118, 181, 173, 52, 113, 106, 172, 2, 231 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailVerifications_UserId",
                table: "EmailVerifications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailVerifications");

            migrationBuilder.DropColumn(
                name: "IsEmailVerified",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(357), new byte[] { 23, 52, 124, 225, 120, 162, 11, 12, 71, 41, 7, 191, 48, 68, 147, 253, 143, 14, 76, 144, 22, 233, 126, 156, 133, 207, 221, 13, 100, 151, 54, 90, 198, 95, 137, 82, 0, 65, 45, 188, 208, 21, 115, 66, 97, 70, 74, 43, 200, 132, 203, 25, 146, 172, 65, 233, 65, 216, 28, 157, 184, 92, 151, 202 }, new byte[] { 196, 141, 23, 169, 79, 150, 16, 253, 93, 177, 137, 29, 94, 155, 120, 128, 65, 35, 220, 213, 89, 95, 55, 247, 216, 196, 173, 250, 127, 154, 216, 227, 99, 51, 242, 81, 157, 200, 181, 166, 43, 200, 75, 83, 194, 234, 149, 174, 132, 117, 18, 156, 230, 249, 70, 173, 230, 202, 228, 0, 250, 80, 19, 61, 226, 105, 165, 48, 13, 107, 64, 66, 77, 148, 16, 195, 203, 104, 246, 85, 24, 191, 189, 217, 244, 6, 67, 213, 96, 112, 70, 22, 7, 84, 214, 219, 11, 34, 121, 64, 86, 127, 253, 157, 25, 216, 154, 13, 98, 87, 229, 166, 55, 193, 185, 132, 54, 115, 163, 101, 122, 151, 34, 6, 181, 241, 252, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(364), new byte[] { 192, 11, 254, 248, 73, 9, 155, 241, 246, 29, 91, 193, 90, 236, 217, 173, 127, 204, 55, 120, 230, 82, 49, 174, 4, 117, 80, 68, 242, 102, 149, 219, 6, 145, 108, 114, 3, 236, 174, 143, 143, 223, 34, 190, 248, 202, 146, 247, 169, 233, 31, 22, 62, 195, 223, 179, 238, 228, 67, 167, 113, 160, 112, 154 }, new byte[] { 178, 116, 147, 32, 219, 199, 235, 174, 215, 83, 24, 75, 220, 39, 233, 66, 101, 21, 227, 212, 136, 159, 157, 154, 71, 216, 234, 49, 56, 122, 148, 59, 117, 164, 60, 107, 200, 202, 14, 195, 185, 149, 128, 120, 161, 117, 43, 103, 177, 58, 197, 23, 181, 227, 230, 206, 133, 132, 55, 44, 202, 30, 108, 157, 232, 175, 199, 1, 142, 118, 165, 243, 64, 231, 147, 74, 1, 77, 245, 245, 110, 103, 68, 122, 117, 251, 168, 103, 61, 171, 250, 161, 38, 251, 48, 29, 10, 200, 197, 198, 241, 86, 139, 14, 216, 197, 226, 72, 83, 51, 164, 221, 145, 146, 24, 223, 21, 214, 6, 209, 185, 19, 225, 126, 244, 9, 60, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(366), new byte[] { 207, 152, 152, 104, 112, 122, 87, 38, 14, 33, 24, 168, 40, 213, 183, 190, 203, 97, 231, 171, 77, 10, 80, 131, 53, 204, 215, 6, 12, 206, 59, 51, 109, 210, 180, 228, 57, 227, 208, 168, 148, 108, 67, 225, 233, 96, 85, 73, 83, 198, 63, 87, 38, 162, 1, 140, 13, 2, 114, 240, 187, 180, 187, 45 }, new byte[] { 53, 45, 22, 151, 152, 126, 216, 113, 173, 241, 110, 238, 242, 86, 43, 66, 121, 78, 29, 47, 185, 79, 180, 45, 87, 154, 167, 253, 251, 207, 78, 192, 50, 195, 24, 182, 130, 130, 221, 55, 17, 171, 48, 30, 23, 43, 88, 66, 104, 196, 17, 93, 50, 26, 164, 105, 118, 219, 136, 32, 71, 191, 203, 59, 180, 224, 137, 215, 39, 67, 231, 153, 61, 105, 219, 188, 88, 89, 213, 59, 234, 125, 225, 100, 191, 156, 54, 149, 26, 143, 130, 69, 189, 143, 77, 68, 4, 219, 198, 214, 130, 26, 186, 130, 141, 185, 35, 168, 13, 93, 239, 16, 86, 14, 49, 14, 152, 151, 216, 92, 77, 242, 215, 197, 242, 154, 197, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(368), new byte[] { 130, 172, 102, 181, 182, 105, 98, 22, 116, 62, 249, 107, 112, 149, 121, 134, 65, 175, 111, 158, 148, 231, 30, 91, 7, 53, 105, 0, 209, 57, 96, 143, 10, 58, 43, 51, 147, 235, 168, 241, 95, 120, 171, 227, 124, 223, 98, 40, 127, 216, 224, 142, 58, 7, 99, 93, 250, 175, 81, 222, 208, 52, 214, 208 }, new byte[] { 113, 132, 158, 234, 62, 6, 104, 129, 1, 241, 235, 26, 20, 211, 179, 236, 100, 172, 2, 117, 89, 31, 144, 140, 84, 114, 247, 53, 167, 152, 179, 85, 140, 249, 41, 77, 150, 216, 231, 57, 85, 214, 168, 119, 195, 130, 141, 97, 98, 82, 90, 187, 167, 133, 25, 60, 244, 37, 22, 151, 87, 21, 46, 110, 117, 123, 94, 149, 40, 232, 89, 124, 172, 233, 177, 65, 133, 75, 106, 35, 240, 35, 148, 244, 203, 142, 35, 92, 0, 162, 65, 108, 221, 112, 45, 172, 232, 210, 46, 1, 72, 110, 88, 200, 237, 105, 98, 63, 20, 192, 227, 173, 220, 158, 209, 86, 117, 109, 71, 212, 103, 243, 14, 58, 15, 109, 167, 134 } });
        }
    }
}
