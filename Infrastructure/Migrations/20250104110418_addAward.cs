using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAward : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AwardName = table.Column<string>(type: "text", nullable: false),
                    AwardOrganization = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Awards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Awards_UserId",
                table: "Awards",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9321), new byte[] { 164, 195, 157, 198, 83, 236, 26, 204, 114, 228, 54, 1, 162, 104, 195, 131, 178, 158, 60, 208, 251, 119, 165, 216, 114, 86, 48, 207, 247, 122, 80, 190, 120, 202, 203, 152, 104, 67, 114, 146, 63, 132, 148, 162, 54, 194, 192, 101, 251, 183, 103, 153, 18, 131, 237, 232, 114, 111, 208, 30, 194, 17, 241, 72 }, new byte[] { 55, 209, 152, 120, 95, 122, 127, 234, 50, 162, 110, 0, 192, 241, 28, 203, 55, 37, 205, 130, 238, 174, 89, 198, 130, 24, 189, 215, 17, 125, 24, 121, 88, 116, 251, 76, 78, 39, 181, 192, 252, 208, 2, 168, 174, 137, 162, 150, 215, 0, 118, 245, 197, 2, 254, 239, 121, 100, 154, 73, 54, 104, 220, 235, 142, 31, 25, 154, 239, 101, 232, 241, 252, 80, 168, 200, 150, 168, 1, 138, 4, 117, 76, 78, 32, 196, 126, 43, 154, 219, 146, 246, 237, 43, 95, 221, 161, 25, 24, 160, 9, 118, 66, 230, 149, 4, 136, 144, 204, 154, 248, 41, 235, 62, 233, 60, 242, 186, 59, 148, 113, 202, 146, 23, 130, 201, 215, 128 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9332), new byte[] { 71, 156, 19, 119, 122, 195, 204, 250, 189, 200, 69, 8, 21, 103, 32, 0, 176, 44, 56, 201, 125, 46, 145, 230, 201, 194, 3, 176, 232, 128, 98, 188, 221, 115, 224, 167, 236, 231, 14, 198, 16, 200, 161, 94, 163, 75, 146, 57, 39, 208, 158, 106, 33, 31, 141, 70, 226, 72, 118, 110, 91, 78, 101, 71 }, new byte[] { 208, 147, 185, 184, 131, 243, 96, 172, 110, 133, 92, 37, 99, 78, 143, 177, 186, 56, 129, 40, 36, 152, 201, 140, 193, 197, 72, 213, 77, 143, 190, 172, 213, 75, 153, 211, 149, 242, 209, 18, 216, 143, 33, 160, 117, 204, 162, 103, 112, 59, 106, 205, 54, 68, 197, 86, 153, 113, 242, 212, 96, 47, 153, 209, 32, 18, 196, 214, 198, 173, 162, 172, 170, 194, 166, 197, 151, 122, 36, 230, 232, 215, 195, 170, 156, 251, 57, 255, 228, 128, 104, 77, 209, 174, 224, 147, 205, 160, 43, 124, 117, 216, 252, 232, 242, 33, 184, 188, 207, 134, 152, 214, 52, 243, 146, 50, 7, 136, 135, 158, 33, 38, 45, 4, 192, 17, 178, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9358), new byte[] { 214, 160, 190, 169, 143, 159, 200, 163, 248, 48, 34, 164, 136, 127, 250, 145, 89, 200, 139, 247, 88, 41, 92, 141, 147, 25, 106, 19, 239, 39, 128, 161, 188, 254, 28, 169, 229, 23, 179, 33, 158, 62, 21, 28, 154, 135, 114, 12, 96, 67, 183, 186, 111, 70, 193, 28, 40, 69, 176, 232, 185, 156, 223, 160 }, new byte[] { 149, 3, 201, 240, 72, 59, 31, 160, 243, 40, 13, 98, 181, 242, 174, 54, 243, 218, 201, 83, 45, 84, 193, 75, 110, 72, 101, 81, 149, 64, 133, 92, 130, 155, 86, 190, 116, 159, 109, 6, 178, 73, 10, 34, 32, 1, 39, 184, 195, 172, 60, 126, 135, 3, 209, 184, 82, 182, 125, 180, 53, 54, 65, 234, 68, 191, 48, 36, 77, 231, 191, 60, 141, 101, 204, 219, 101, 126, 76, 70, 123, 141, 39, 157, 76, 208, 123, 20, 253, 209, 242, 201, 198, 16, 154, 23, 206, 198, 229, 240, 91, 110, 71, 34, 114, 210, 58, 174, 99, 112, 241, 145, 191, 177, 26, 122, 252, 18, 237, 75, 155, 62, 251, 254, 212, 51, 16, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9359), new byte[] { 133, 62, 95, 209, 28, 19, 178, 32, 127, 225, 119, 128, 168, 33, 162, 82, 143, 15, 180, 192, 53, 151, 63, 73, 91, 166, 209, 33, 150, 125, 236, 162, 8, 58, 214, 31, 116, 90, 176, 238, 74, 169, 15, 37, 222, 223, 208, 126, 204, 56, 115, 97, 80, 98, 44, 116, 64, 129, 156, 167, 57, 83, 133, 68 }, new byte[] { 194, 49, 203, 3, 212, 159, 200, 218, 94, 185, 232, 182, 71, 44, 15, 190, 46, 59, 163, 32, 119, 138, 225, 205, 229, 34, 4, 34, 188, 71, 61, 193, 52, 144, 54, 123, 131, 173, 210, 64, 210, 222, 140, 24, 55, 71, 244, 199, 121, 84, 63, 58, 64, 38, 177, 233, 183, 179, 93, 102, 214, 165, 90, 178, 18, 5, 159, 153, 151, 176, 170, 200, 114, 71, 181, 198, 99, 157, 132, 53, 86, 225, 191, 244, 197, 159, 208, 128, 175, 54, 228, 116, 98, 252, 229, 85, 242, 226, 95, 215, 128, 215, 241, 40, 50, 43, 37, 146, 145, 98, 154, 156, 187, 233, 53, 239, 49, 158, 22, 46, 210, 99, 30, 186, 0, 142, 44, 239 } });
        }
    }
}
