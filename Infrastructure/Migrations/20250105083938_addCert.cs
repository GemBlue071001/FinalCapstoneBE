using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addCert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CertificateName = table.Column<string>(type: "text", nullable: false),
                    CertificateOrganization = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CertificateURL = table.Column<string>(type: "text", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificate_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 219, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 220, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 220, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 5, 8, 39, 36, 222, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 5, 8, 39, 36, 219, DateTimeKind.Utc).AddTicks(6154), new byte[] { 161, 217, 157, 60, 114, 81, 201, 157, 228, 13, 104, 36, 24, 1, 172, 87, 252, 150, 61, 146, 88, 66, 47, 171, 173, 139, 106, 169, 40, 200, 27, 33, 52, 3, 172, 177, 25, 5, 13, 157, 152, 106, 31, 185, 23, 20, 28, 164, 3, 58, 60, 110, 119, 154, 6, 170, 132, 173, 218, 36, 64, 122, 88, 50 }, new byte[] { 112, 64, 54, 141, 38, 95, 42, 149, 13, 123, 130, 210, 99, 66, 211, 208, 65, 64, 201, 78, 120, 75, 161, 59, 236, 61, 20, 68, 43, 113, 152, 199, 46, 100, 11, 73, 140, 245, 176, 118, 220, 246, 59, 102, 53, 158, 164, 65, 126, 14, 62, 213, 45, 194, 37, 246, 17, 180, 63, 43, 156, 78, 110, 185, 37, 206, 205, 71, 240, 247, 168, 27, 141, 190, 49, 49, 213, 70, 192, 123, 64, 175, 150, 108, 98, 44, 183, 145, 119, 20, 173, 184, 147, 120, 153, 152, 225, 236, 87, 227, 69, 204, 27, 40, 147, 28, 135, 111, 239, 136, 77, 13, 219, 67, 193, 29, 135, 191, 121, 228, 4, 36, 97, 37, 185, 213, 115, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 5, 8, 39, 36, 219, DateTimeKind.Utc).AddTicks(6162), new byte[] { 82, 85, 77, 206, 232, 104, 85, 176, 82, 159, 58, 158, 217, 148, 126, 130, 92, 162, 225, 53, 245, 107, 243, 56, 173, 35, 45, 79, 108, 94, 119, 37, 142, 37, 19, 76, 168, 67, 234, 78, 30, 45, 207, 181, 239, 174, 227, 19, 48, 69, 113, 124, 46, 187, 56, 165, 120, 40, 211, 57, 0, 248, 153, 203 }, new byte[] { 122, 229, 92, 169, 246, 34, 28, 85, 112, 103, 40, 199, 66, 103, 21, 131, 72, 118, 144, 131, 115, 176, 120, 66, 67, 17, 147, 126, 127, 181, 226, 184, 166, 148, 33, 13, 118, 171, 17, 181, 159, 57, 250, 70, 193, 107, 168, 164, 132, 8, 204, 162, 169, 107, 197, 134, 47, 24, 195, 231, 246, 165, 150, 130, 98, 131, 121, 248, 128, 9, 216, 139, 229, 24, 41, 6, 144, 222, 203, 79, 16, 174, 248, 60, 64, 255, 17, 27, 62, 224, 31, 250, 137, 58, 10, 141, 52, 83, 96, 40, 246, 221, 46, 29, 84, 0, 164, 2, 35, 25, 110, 2, 36, 17, 30, 88, 162, 128, 133, 166, 164, 10, 216, 89, 152, 191, 104, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 5, 8, 39, 36, 219, DateTimeKind.Utc).AddTicks(6164), new byte[] { 162, 121, 224, 30, 13, 128, 90, 131, 110, 225, 107, 127, 70, 150, 216, 202, 174, 153, 232, 156, 142, 94, 174, 105, 97, 51, 91, 17, 113, 149, 219, 216, 96, 132, 99, 186, 66, 76, 103, 142, 93, 194, 52, 223, 156, 222, 38, 215, 221, 102, 253, 243, 55, 192, 212, 94, 149, 60, 33, 171, 45, 239, 222, 76 }, new byte[] { 92, 232, 244, 137, 132, 171, 57, 199, 215, 254, 249, 177, 224, 241, 58, 205, 98, 239, 161, 251, 193, 97, 163, 105, 219, 149, 159, 18, 172, 28, 16, 74, 1, 47, 64, 246, 79, 228, 133, 39, 37, 176, 94, 135, 107, 174, 6, 37, 20, 175, 147, 222, 180, 98, 38, 20, 181, 197, 120, 26, 11, 25, 142, 67, 108, 135, 95, 55, 88, 122, 18, 180, 248, 97, 115, 239, 148, 16, 193, 42, 0, 185, 63, 87, 244, 134, 38, 147, 171, 157, 205, 238, 250, 223, 91, 203, 163, 78, 152, 189, 117, 83, 123, 236, 108, 24, 194, 219, 93, 28, 60, 52, 93, 75, 85, 234, 240, 111, 76, 8, 187, 136, 184, 220, 209, 189, 159, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 5, 8, 39, 36, 219, DateTimeKind.Utc).AddTicks(6166), new byte[] { 247, 224, 165, 129, 152, 73, 200, 0, 215, 153, 194, 11, 62, 191, 22, 120, 155, 41, 33, 195, 156, 249, 145, 103, 193, 190, 30, 243, 153, 53, 30, 2, 157, 236, 193, 84, 246, 123, 135, 70, 88, 215, 143, 210, 214, 11, 128, 100, 160, 112, 59, 211, 142, 28, 206, 135, 18, 108, 207, 4, 223, 216, 214, 71 }, new byte[] { 120, 172, 191, 75, 189, 195, 33, 8, 128, 189, 176, 46, 252, 5, 181, 102, 255, 81, 61, 91, 31, 73, 125, 196, 130, 13, 65, 242, 181, 234, 34, 49, 218, 102, 76, 151, 209, 112, 213, 84, 107, 145, 68, 198, 110, 225, 157, 39, 186, 58, 56, 185, 75, 170, 244, 159, 247, 214, 62, 104, 231, 62, 193, 217, 79, 164, 64, 215, 180, 217, 92, 69, 182, 106, 168, 70, 21, 42, 99, 0, 59, 200, 242, 64, 95, 121, 27, 36, 213, 167, 142, 55, 123, 192, 9, 6, 83, 113, 64, 118, 102, 163, 214, 32, 121, 111, 84, 13, 222, 204, 238, 141, 207, 176, 240, 24, 20, 147, 185, 31, 47, 165, 223, 232, 8, 129, 42, 217 } });

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_UserId",
                table: "Certificate",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 144, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 145, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 145, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 4, 11, 4, 16, 147, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 4, 11, 4, 16, 144, DateTimeKind.Utc).AddTicks(5887), new byte[] { 164, 145, 216, 15, 241, 188, 68, 20, 22, 40, 70, 21, 219, 47, 142, 134, 199, 27, 138, 132, 3, 178, 245, 193, 60, 188, 140, 174, 6, 228, 140, 159, 114, 130, 147, 49, 112, 119, 155, 221, 46, 227, 235, 117, 103, 215, 235, 81, 166, 152, 40, 201, 90, 143, 91, 71, 182, 55, 215, 35, 38, 168, 119, 63 }, new byte[] { 12, 240, 92, 177, 132, 52, 133, 176, 2, 31, 247, 137, 183, 151, 201, 243, 20, 232, 148, 236, 57, 223, 99, 80, 29, 16, 53, 254, 46, 113, 35, 67, 66, 138, 253, 148, 157, 53, 85, 236, 230, 97, 105, 199, 62, 124, 44, 149, 252, 229, 157, 94, 168, 102, 222, 188, 228, 158, 248, 63, 238, 10, 39, 11, 32, 122, 176, 203, 92, 47, 254, 95, 121, 24, 191, 148, 130, 174, 57, 97, 17, 99, 227, 7, 183, 54, 84, 92, 58, 164, 31, 67, 81, 71, 249, 22, 74, 169, 218, 102, 26, 95, 141, 192, 126, 149, 136, 45, 232, 100, 138, 96, 34, 123, 170, 246, 232, 219, 252, 99, 33, 154, 101, 115, 50, 112, 190, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 4, 11, 4, 16, 144, DateTimeKind.Utc).AddTicks(5895), new byte[] { 134, 212, 226, 11, 64, 125, 69, 75, 105, 106, 18, 198, 54, 134, 19, 216, 109, 218, 206, 178, 68, 38, 201, 151, 242, 168, 45, 107, 193, 4, 34, 117, 203, 121, 206, 64, 142, 181, 67, 88, 2, 212, 121, 82, 227, 28, 146, 86, 163, 154, 165, 176, 169, 131, 108, 213, 36, 170, 133, 71, 19, 199, 78, 136 }, new byte[] { 32, 171, 192, 51, 20, 245, 77, 60, 130, 57, 105, 93, 101, 192, 165, 17, 60, 126, 213, 70, 51, 51, 38, 83, 54, 166, 0, 71, 230, 24, 4, 101, 49, 159, 156, 201, 192, 12, 249, 6, 48, 116, 126, 6, 58, 148, 170, 147, 133, 182, 253, 2, 204, 247, 175, 66, 163, 44, 56, 164, 25, 62, 146, 182, 12, 58, 185, 233, 59, 164, 1, 208, 60, 95, 121, 97, 105, 121, 136, 181, 253, 153, 112, 113, 47, 91, 143, 70, 56, 111, 20, 44, 51, 127, 35, 35, 168, 73, 190, 166, 193, 112, 238, 190, 58, 78, 158, 222, 59, 60, 66, 102, 153, 155, 220, 207, 137, 24, 93, 222, 113, 217, 141, 170, 218, 121, 51, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 4, 11, 4, 16, 144, DateTimeKind.Utc).AddTicks(5897), new byte[] { 56, 60, 103, 226, 195, 40, 40, 229, 182, 169, 47, 180, 12, 108, 92, 132, 202, 47, 201, 22, 131, 218, 206, 94, 120, 35, 210, 234, 23, 137, 9, 124, 82, 80, 184, 79, 219, 63, 206, 6, 220, 26, 140, 161, 68, 41, 100, 213, 114, 11, 254, 99, 214, 211, 73, 177, 56, 90, 113, 61, 46, 225, 38, 12 }, new byte[] { 93, 1, 52, 77, 65, 36, 102, 94, 198, 7, 103, 105, 252, 61, 250, 251, 253, 54, 214, 69, 125, 52, 71, 230, 186, 198, 86, 254, 244, 93, 141, 237, 27, 71, 131, 152, 41, 125, 157, 235, 54, 177, 119, 60, 105, 147, 119, 10, 72, 138, 206, 124, 220, 49, 167, 172, 233, 27, 53, 123, 73, 162, 149, 99, 73, 34, 42, 88, 233, 176, 55, 134, 176, 255, 32, 131, 40, 166, 43, 4, 50, 215, 163, 48, 171, 11, 51, 237, 129, 183, 102, 247, 80, 230, 164, 83, 155, 210, 77, 224, 108, 219, 176, 107, 166, 225, 85, 74, 246, 251, 79, 161, 196, 101, 124, 128, 21, 187, 40, 215, 239, 150, 74, 74, 144, 114, 57, 179 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 4, 11, 4, 16, 144, DateTimeKind.Utc).AddTicks(5898), new byte[] { 190, 14, 98, 190, 255, 8, 0, 185, 75, 145, 49, 206, 62, 13, 131, 14, 118, 177, 148, 226, 236, 48, 44, 52, 43, 86, 113, 206, 119, 218, 57, 23, 12, 109, 165, 45, 110, 209, 234, 148, 210, 26, 154, 136, 91, 237, 155, 162, 52, 51, 62, 204, 169, 236, 16, 16, 70, 106, 173, 81, 182, 128, 148, 17 }, new byte[] { 86, 51, 138, 104, 188, 23, 114, 254, 115, 87, 32, 37, 50, 74, 219, 179, 164, 160, 254, 34, 17, 97, 56, 215, 195, 116, 51, 101, 97, 106, 230, 103, 105, 183, 12, 81, 233, 82, 38, 112, 227, 157, 145, 69, 240, 141, 173, 158, 145, 14, 112, 169, 0, 45, 134, 82, 223, 40, 23, 44, 131, 64, 8, 100, 187, 143, 134, 254, 202, 29, 215, 150, 224, 180, 37, 95, 86, 10, 69, 254, 225, 138, 83, 196, 126, 24, 66, 85, 51, 21, 123, 111, 188, 217, 34, 116, 162, 240, 102, 241, 79, 122, 130, 68, 118, 177, 108, 212, 36, 226, 94, 139, 144, 58, 70, 255, 18, 89, 22, 218, 178, 163, 196, 166, 158, 82, 138, 232 } });
        }
    }
}
