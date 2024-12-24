using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewReviewDetailAndReasonToRejectInReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReasonToReject",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReviewStatus",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReviewDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewDetail_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 974, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 975, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 975, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 979, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 9, 42, 40, 980, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 42, 40, 974, DateTimeKind.Utc).AddTicks(6955), new byte[] { 84, 32, 41, 134, 90, 177, 26, 174, 208, 235, 151, 247, 138, 91, 90, 76, 250, 141, 94, 208, 228, 182, 196, 252, 159, 65, 200, 8, 245, 74, 84, 187, 129, 178, 25, 226, 64, 56, 216, 65, 187, 84, 114, 96, 201, 59, 51, 213, 176, 212, 75, 196, 130, 115, 207, 18, 254, 180, 35, 97, 245, 124, 136, 222 }, new byte[] { 141, 220, 155, 141, 167, 226, 123, 191, 64, 211, 57, 204, 109, 231, 2, 238, 139, 153, 176, 142, 233, 143, 188, 88, 93, 26, 137, 55, 115, 240, 144, 144, 95, 39, 218, 217, 177, 236, 93, 167, 199, 7, 235, 176, 133, 168, 177, 218, 102, 55, 98, 160, 51, 95, 154, 238, 70, 14, 65, 146, 57, 138, 62, 92, 71, 71, 72, 173, 44, 154, 222, 212, 180, 255, 103, 75, 112, 52, 55, 194, 177, 171, 36, 209, 84, 13, 33, 251, 237, 22, 127, 68, 103, 118, 39, 87, 176, 208, 64, 112, 101, 92, 218, 252, 168, 43, 244, 185, 200, 183, 7, 108, 96, 252, 63, 72, 185, 81, 43, 182, 136, 128, 235, 128, 119, 29, 56, 153 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 42, 40, 974, DateTimeKind.Utc).AddTicks(6963), new byte[] { 105, 4, 10, 190, 139, 128, 124, 78, 0, 72, 75, 51, 167, 33, 25, 168, 113, 48, 59, 238, 172, 29, 247, 82, 58, 213, 106, 78, 108, 2, 248, 220, 246, 28, 140, 63, 217, 25, 187, 212, 63, 93, 35, 250, 133, 108, 145, 78, 69, 226, 29, 188, 26, 85, 180, 126, 61, 217, 28, 3, 4, 21, 4, 168 }, new byte[] { 154, 209, 223, 65, 16, 14, 52, 170, 21, 169, 193, 52, 113, 56, 83, 6, 254, 86, 86, 166, 76, 50, 6, 89, 126, 39, 139, 129, 168, 65, 143, 52, 235, 74, 255, 80, 44, 169, 82, 197, 227, 130, 165, 179, 55, 255, 146, 43, 119, 128, 35, 242, 166, 99, 223, 63, 137, 65, 75, 79, 214, 245, 45, 46, 181, 39, 119, 74, 5, 188, 237, 28, 198, 68, 68, 60, 243, 58, 27, 201, 111, 45, 109, 187, 226, 246, 69, 20, 218, 230, 23, 58, 95, 0, 60, 219, 145, 61, 185, 23, 118, 132, 96, 7, 245, 174, 133, 59, 179, 228, 107, 160, 240, 62, 161, 26, 206, 23, 131, 54, 97, 153, 248, 97, 107, 210, 218, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 42, 40, 974, DateTimeKind.Utc).AddTicks(6966), new byte[] { 56, 207, 130, 240, 1, 225, 145, 67, 28, 232, 224, 68, 68, 168, 111, 126, 123, 53, 33, 16, 18, 98, 167, 223, 63, 21, 175, 48, 122, 112, 130, 6, 224, 213, 102, 131, 221, 194, 68, 127, 234, 240, 243, 21, 54, 63, 64, 71, 246, 63, 143, 198, 151, 15, 1, 255, 82, 231, 165, 170, 66, 174, 44, 132 }, new byte[] { 239, 101, 234, 106, 239, 171, 126, 238, 116, 94, 73, 237, 60, 157, 159, 30, 10, 136, 153, 241, 38, 31, 154, 48, 155, 22, 252, 123, 213, 108, 114, 217, 210, 9, 146, 152, 148, 92, 112, 230, 247, 87, 169, 18, 227, 98, 248, 160, 229, 248, 172, 28, 147, 93, 142, 155, 50, 149, 77, 220, 120, 47, 161, 64, 181, 225, 30, 0, 137, 64, 248, 33, 144, 248, 39, 243, 117, 136, 56, 88, 104, 93, 195, 18, 44, 76, 178, 230, 246, 40, 44, 61, 11, 212, 29, 242, 205, 211, 220, 26, 86, 105, 199, 223, 223, 112, 11, 27, 251, 241, 160, 34, 16, 249, 161, 75, 228, 218, 150, 95, 123, 75, 193, 220, 224, 134, 140, 146 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 42, 40, 974, DateTimeKind.Utc).AddTicks(6968), new byte[] { 130, 166, 15, 70, 146, 0, 212, 112, 101, 2, 248, 141, 178, 177, 207, 33, 120, 207, 253, 139, 123, 46, 249, 13, 47, 255, 213, 112, 171, 48, 171, 182, 205, 90, 95, 118, 181, 238, 74, 70, 174, 38, 143, 30, 170, 180, 175, 74, 167, 171, 80, 242, 123, 103, 246, 153, 197, 1, 253, 100, 7, 110, 178, 73 }, new byte[] { 77, 4, 159, 151, 37, 9, 141, 62, 0, 217, 151, 152, 8, 250, 65, 115, 211, 65, 5, 131, 21, 5, 205, 36, 224, 208, 96, 108, 155, 151, 9, 99, 102, 17, 53, 242, 26, 144, 144, 251, 82, 15, 142, 48, 197, 228, 43, 40, 128, 232, 80, 39, 92, 244, 58, 231, 169, 23, 16, 55, 122, 54, 253, 55, 167, 28, 128, 143, 8, 218, 61, 156, 219, 71, 139, 101, 250, 35, 4, 109, 2, 178, 85, 70, 0, 62, 227, 186, 18, 197, 90, 198, 102, 125, 145, 215, 14, 64, 236, 254, 192, 49, 236, 126, 133, 136, 49, 53, 13, 193, 40, 9, 72, 39, 101, 95, 128, 23, 186, 135, 54, 165, 132, 57, 58, 150, 28, 191 } });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDetail_ReviewId",
                table: "ReviewDetail",
                column: "ReviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewDetail");

            migrationBuilder.DropColumn(
                name: "ReasonToReject",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewStatus",
                table: "Reviews");

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
        }
    }
}
