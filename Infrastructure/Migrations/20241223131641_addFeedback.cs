using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    StatusFeedBack = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Users_UserId",
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
                value: new DateTime(2024, 12, 23, 13, 16, 40, 22, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 23, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 23, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 23, 13, 16, 40, 25, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 16, 40, 22, DateTimeKind.Utc).AddTicks(4801), new byte[] { 20, 227, 27, 77, 108, 156, 47, 138, 116, 162, 243, 132, 57, 1, 119, 113, 119, 168, 213, 159, 241, 29, 200, 237, 57, 163, 136, 29, 46, 39, 237, 248, 199, 59, 96, 4, 57, 197, 20, 10, 209, 74, 105, 86, 245, 220, 250, 143, 251, 185, 184, 46, 68, 67, 250, 64, 130, 210, 141, 83, 255, 148, 126, 229 }, new byte[] { 138, 25, 226, 132, 52, 93, 210, 101, 78, 152, 134, 112, 184, 202, 49, 246, 100, 58, 187, 99, 3, 196, 244, 189, 114, 120, 252, 131, 121, 86, 164, 114, 16, 230, 138, 70, 164, 161, 234, 164, 100, 236, 130, 28, 221, 148, 119, 162, 200, 53, 152, 166, 24, 241, 209, 245, 126, 14, 87, 110, 103, 211, 248, 199, 156, 135, 63, 94, 176, 101, 137, 27, 24, 254, 47, 172, 191, 80, 83, 133, 11, 119, 250, 96, 124, 233, 248, 55, 213, 15, 158, 151, 117, 25, 182, 183, 90, 234, 186, 51, 105, 167, 238, 39, 162, 175, 76, 78, 47, 133, 38, 25, 24, 35, 215, 90, 58, 105, 54, 180, 53, 97, 203, 116, 52, 130, 244, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 16, 40, 22, DateTimeKind.Utc).AddTicks(4807), new byte[] { 116, 44, 127, 127, 169, 93, 161, 255, 100, 172, 47, 5, 3, 191, 145, 154, 97, 81, 96, 129, 78, 135, 89, 108, 157, 199, 124, 222, 218, 216, 206, 51, 126, 217, 59, 13, 75, 136, 211, 227, 195, 74, 83, 0, 53, 189, 128, 173, 132, 81, 64, 255, 185, 187, 183, 226, 254, 218, 113, 191, 47, 210, 173, 32 }, new byte[] { 164, 124, 163, 42, 47, 60, 217, 17, 94, 113, 205, 244, 76, 215, 83, 133, 17, 158, 208, 125, 48, 168, 65, 108, 37, 249, 87, 121, 38, 39, 154, 71, 140, 139, 192, 61, 134, 14, 75, 65, 166, 72, 118, 94, 213, 223, 93, 255, 79, 148, 183, 72, 169, 55, 147, 246, 137, 168, 119, 19, 17, 92, 38, 250, 73, 241, 55, 10, 173, 217, 249, 160, 23, 184, 30, 201, 19, 89, 41, 119, 56, 142, 201, 84, 233, 53, 55, 66, 171, 29, 76, 139, 143, 147, 209, 175, 168, 105, 183, 189, 238, 5, 112, 252, 102, 17, 76, 77, 145, 15, 254, 1, 94, 93, 23, 165, 84, 156, 154, 67, 121, 46, 234, 124, 40, 197, 162, 194 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 16, 40, 22, DateTimeKind.Utc).AddTicks(4809), new byte[] { 121, 156, 3, 188, 150, 193, 169, 49, 106, 152, 247, 34, 22, 68, 67, 77, 110, 121, 254, 20, 143, 151, 215, 200, 241, 208, 118, 136, 44, 237, 170, 57, 241, 37, 183, 228, 125, 72, 214, 203, 245, 19, 93, 70, 84, 234, 185, 187, 17, 212, 2, 106, 0, 214, 53, 191, 169, 11, 223, 61, 233, 96, 18, 32 }, new byte[] { 205, 100, 209, 21, 180, 81, 71, 226, 84, 144, 49, 73, 38, 231, 144, 35, 43, 110, 28, 54, 69, 47, 166, 87, 102, 46, 172, 113, 7, 24, 51, 201, 253, 233, 234, 235, 198, 112, 212, 164, 156, 88, 42, 121, 224, 141, 106, 17, 129, 124, 8, 52, 6, 144, 93, 179, 214, 239, 109, 150, 248, 18, 156, 216, 169, 118, 169, 227, 126, 96, 43, 189, 131, 167, 250, 251, 157, 164, 222, 136, 19, 108, 86, 228, 244, 155, 213, 15, 238, 149, 238, 65, 66, 243, 115, 180, 212, 31, 146, 186, 109, 219, 190, 34, 229, 118, 185, 176, 194, 86, 178, 110, 143, 36, 249, 58, 92, 14, 59, 22, 150, 244, 141, 139, 122, 95, 239, 68 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 23, 13, 16, 40, 22, DateTimeKind.Utc).AddTicks(4811), new byte[] { 149, 2, 172, 13, 11, 4, 115, 186, 121, 17, 14, 189, 230, 175, 211, 27, 168, 167, 164, 70, 224, 230, 14, 163, 172, 200, 201, 21, 208, 241, 53, 192, 43, 78, 168, 16, 215, 246, 238, 230, 169, 38, 187, 189, 5, 91, 161, 42, 114, 85, 159, 193, 84, 236, 156, 107, 93, 203, 215, 51, 21, 209, 57, 225 }, new byte[] { 134, 134, 169, 163, 104, 118, 197, 240, 181, 129, 197, 168, 8, 6, 68, 247, 4, 92, 21, 151, 30, 72, 101, 206, 89, 226, 85, 55, 176, 97, 172, 84, 220, 43, 249, 83, 13, 130, 223, 246, 118, 186, 233, 8, 210, 212, 109, 50, 42, 13, 199, 213, 57, 24, 80, 103, 120, 114, 41, 131, 194, 177, 60, 227, 132, 3, 58, 37, 63, 142, 180, 103, 175, 41, 193, 114, 102, 29, 195, 239, 242, 186, 201, 83, 98, 238, 179, 23, 61, 1, 137, 159, 117, 9, 46, 159, 42, 66, 227, 64, 233, 209, 110, 89, 104, 67, 43, 245, 101, 184, 173, 115, 10, 223, 80, 237, 111, 212, 91, 71, 22, 250, 100, 183, 12, 36, 165, 218 } });

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_CompanyId",
                table: "FeedBacks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_UserId",
                table: "FeedBacks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 21, 2, 55, 27, 901, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4817), new byte[] { 173, 61, 238, 50, 8, 142, 87, 188, 83, 87, 140, 175, 14, 159, 175, 14, 157, 212, 95, 227, 57, 132, 72, 198, 15, 67, 13, 219, 195, 39, 97, 86, 153, 237, 109, 58, 46, 135, 68, 215, 116, 219, 159, 158, 2, 250, 209, 26, 160, 6, 207, 67, 116, 253, 231, 252, 97, 154, 71, 144, 224, 113, 19, 96 }, new byte[] { 195, 21, 168, 138, 62, 250, 61, 23, 50, 89, 150, 68, 96, 95, 67, 229, 154, 132, 26, 132, 25, 71, 146, 58, 59, 179, 163, 223, 170, 218, 72, 252, 138, 18, 136, 40, 151, 111, 58, 252, 147, 93, 89, 126, 160, 237, 167, 164, 255, 28, 100, 38, 242, 215, 118, 107, 183, 33, 180, 28, 193, 187, 139, 107, 145, 32, 207, 195, 186, 213, 244, 201, 155, 55, 17, 68, 185, 127, 18, 94, 49, 101, 67, 61, 81, 208, 123, 209, 30, 246, 83, 103, 2, 175, 5, 139, 215, 184, 25, 68, 76, 99, 122, 79, 155, 109, 211, 171, 170, 148, 173, 25, 135, 239, 210, 43, 126, 234, 46, 250, 242, 55, 69, 133, 22, 50, 14, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4826), new byte[] { 92, 56, 70, 178, 206, 255, 222, 195, 44, 246, 136, 76, 117, 43, 247, 225, 9, 127, 27, 41, 118, 107, 1, 141, 21, 12, 219, 200, 220, 218, 87, 182, 90, 131, 38, 197, 239, 197, 125, 206, 212, 93, 227, 13, 74, 2, 118, 191, 139, 21, 131, 44, 250, 25, 207, 145, 237, 163, 46, 59, 169, 93, 174, 131 }, new byte[] { 179, 109, 249, 211, 50, 62, 243, 44, 65, 1, 126, 209, 96, 217, 213, 21, 86, 94, 80, 106, 207, 227, 150, 248, 78, 15, 133, 120, 141, 67, 208, 54, 186, 203, 92, 197, 59, 62, 48, 150, 212, 198, 23, 145, 97, 222, 147, 162, 234, 231, 92, 29, 16, 120, 74, 202, 131, 70, 121, 173, 247, 122, 207, 222, 158, 48, 21, 25, 173, 5, 15, 238, 192, 219, 186, 58, 69, 245, 157, 71, 246, 148, 250, 36, 109, 220, 101, 71, 47, 67, 56, 175, 147, 24, 138, 102, 12, 235, 171, 35, 226, 29, 94, 188, 227, 179, 236, 184, 34, 137, 179, 124, 55, 151, 212, 226, 255, 34, 69, 45, 10, 115, 29, 228, 74, 135, 106, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4828), new byte[] { 148, 167, 43, 107, 99, 114, 13, 248, 213, 190, 140, 1, 160, 241, 223, 144, 240, 71, 84, 172, 57, 182, 72, 134, 55, 182, 25, 147, 182, 85, 40, 147, 77, 222, 177, 208, 170, 192, 60, 12, 216, 69, 105, 226, 160, 49, 16, 163, 200, 210, 229, 113, 230, 80, 119, 199, 250, 182, 155, 39, 143, 204, 221, 136 }, new byte[] { 131, 119, 52, 128, 203, 155, 223, 232, 88, 195, 143, 189, 133, 228, 47, 44, 39, 179, 186, 181, 95, 12, 121, 11, 170, 15, 231, 44, 135, 80, 223, 105, 40, 173, 1, 178, 81, 81, 3, 180, 79, 174, 44, 127, 210, 238, 215, 161, 202, 246, 198, 84, 60, 52, 248, 139, 148, 231, 207, 61, 41, 61, 192, 241, 191, 232, 248, 248, 42, 145, 209, 197, 249, 7, 110, 116, 1, 107, 28, 143, 195, 43, 88, 208, 61, 157, 236, 207, 4, 221, 50, 216, 24, 170, 219, 161, 213, 221, 43, 105, 163, 14, 113, 185, 222, 237, 82, 241, 175, 243, 198, 66, 75, 219, 64, 127, 73, 41, 90, 173, 241, 191, 117, 103, 149, 118, 237, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 21, 2, 55, 27, 899, DateTimeKind.Utc).AddTicks(4830), new byte[] { 131, 167, 109, 97, 68, 153, 134, 198, 123, 82, 48, 189, 224, 215, 48, 160, 22, 146, 163, 152, 223, 9, 78, 207, 26, 176, 234, 207, 105, 187, 158, 113, 182, 130, 226, 129, 228, 139, 17, 45, 24, 94, 226, 14, 105, 206, 51, 189, 136, 230, 178, 100, 248, 220, 32, 116, 220, 244, 140, 72, 196, 165, 177, 32 }, new byte[] { 31, 48, 158, 70, 243, 46, 195, 238, 117, 115, 83, 94, 63, 226, 70, 144, 44, 41, 235, 112, 247, 66, 209, 134, 123, 53, 0, 123, 46, 17, 17, 83, 177, 170, 148, 41, 118, 248, 169, 205, 140, 135, 177, 199, 24, 5, 70, 57, 177, 99, 163, 47, 227, 189, 12, 87, 241, 166, 177, 173, 73, 13, 150, 214, 4, 135, 255, 118, 128, 155, 201, 116, 168, 243, 94, 253, 108, 128, 245, 132, 47, 36, 255, 190, 187, 158, 43, 19, 19, 98, 4, 122, 216, 132, 150, 91, 48, 101, 70, 8, 121, 100, 114, 152, 94, 30, 220, 103, 196, 203, 105, 51, 196, 79, 169, 59, 147, 246, 192, 162, 227, 10, 157, 66, 175, 126, 0, 248 } });
        }
    }
}
