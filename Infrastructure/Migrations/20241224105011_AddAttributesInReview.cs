using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAttributesInReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewDetail");

            migrationBuilder.AlterColumn<string>(
                name: "ReasonToReject",
                table: "Reviews",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "CareRating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CultureRating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceContent",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OfficeRating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReasonContent",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Recommened",
                table: "Reviews",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SalaryRating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SuggestionContent",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SummaryContent",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TrainingRating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 867, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 867, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 10, 50, 9, 869, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6473), new byte[] { 249, 141, 139, 178, 124, 121, 20, 3, 235, 99, 63, 21, 185, 60, 199, 73, 44, 134, 43, 28, 53, 154, 193, 62, 109, 247, 222, 43, 3, 160, 101, 50, 106, 228, 126, 78, 206, 117, 17, 15, 119, 101, 173, 160, 193, 18, 76, 34, 67, 201, 82, 79, 58, 161, 188, 234, 229, 247, 49, 7, 108, 40, 60, 81 }, new byte[] { 186, 239, 159, 13, 132, 118, 3, 196, 75, 201, 146, 65, 205, 55, 64, 137, 20, 24, 148, 85, 203, 120, 100, 39, 206, 68, 70, 196, 254, 57, 149, 227, 80, 41, 160, 195, 66, 162, 153, 69, 246, 172, 104, 0, 226, 200, 254, 152, 229, 198, 48, 100, 165, 147, 122, 2, 236, 251, 54, 50, 141, 69, 45, 242, 206, 192, 33, 7, 206, 231, 135, 143, 107, 207, 42, 252, 79, 53, 130, 224, 185, 243, 79, 250, 0, 244, 255, 181, 224, 238, 163, 135, 28, 15, 71, 7, 253, 56, 168, 119, 73, 107, 100, 24, 67, 208, 217, 43, 58, 187, 45, 240, 106, 145, 124, 71, 180, 8, 228, 184, 65, 241, 230, 213, 106, 153, 213, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6487), new byte[] { 50, 2, 28, 62, 89, 239, 28, 166, 35, 242, 199, 120, 237, 144, 227, 248, 160, 122, 230, 196, 143, 68, 241, 50, 229, 133, 202, 7, 1, 179, 122, 56, 74, 162, 131, 1, 244, 178, 18, 78, 66, 28, 138, 83, 40, 42, 64, 194, 174, 43, 172, 97, 121, 196, 207, 13, 103, 148, 79, 170, 54, 112, 98, 21 }, new byte[] { 101, 193, 27, 2, 115, 66, 212, 237, 188, 37, 69, 135, 46, 18, 27, 253, 151, 120, 177, 223, 51, 144, 222, 217, 248, 212, 156, 215, 195, 127, 199, 3, 4, 54, 121, 226, 51, 184, 7, 15, 187, 58, 235, 242, 136, 52, 169, 115, 97, 139, 230, 196, 227, 37, 166, 244, 203, 79, 72, 209, 76, 147, 153, 93, 10, 4, 158, 102, 186, 87, 216, 228, 9, 107, 133, 149, 31, 21, 151, 241, 123, 221, 243, 213, 102, 133, 159, 118, 235, 201, 99, 176, 215, 220, 89, 6, 114, 122, 74, 122, 42, 186, 244, 80, 135, 184, 153, 12, 81, 52, 5, 69, 233, 176, 176, 132, 34, 36, 47, 67, 201, 24, 94, 88, 174, 42, 214, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6488), new byte[] { 91, 152, 101, 134, 151, 226, 205, 43, 26, 73, 167, 22, 30, 151, 134, 245, 33, 193, 150, 129, 187, 105, 216, 58, 202, 187, 71, 193, 82, 80, 213, 21, 107, 166, 75, 229, 233, 123, 60, 18, 108, 36, 91, 107, 85, 66, 50, 129, 13, 255, 51, 206, 230, 124, 6, 243, 204, 245, 215, 79, 94, 28, 116, 229 }, new byte[] { 60, 237, 16, 195, 28, 181, 143, 166, 247, 148, 237, 175, 163, 227, 158, 32, 216, 46, 193, 252, 152, 93, 177, 242, 170, 45, 244, 226, 42, 161, 155, 221, 164, 215, 198, 210, 63, 78, 5, 61, 138, 141, 92, 204, 125, 254, 63, 43, 203, 236, 240, 162, 199, 216, 44, 87, 95, 146, 75, 79, 70, 250, 213, 43, 7, 206, 187, 189, 178, 139, 101, 125, 85, 113, 98, 28, 38, 102, 86, 183, 224, 105, 141, 73, 162, 253, 62, 113, 156, 161, 180, 126, 117, 210, 100, 98, 137, 148, 154, 176, 2, 0, 128, 114, 21, 175, 143, 200, 161, 127, 163, 196, 195, 189, 108, 9, 69, 56, 109, 164, 87, 187, 188, 4, 151, 130, 172, 120 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 10, 50, 9, 866, DateTimeKind.Utc).AddTicks(6490), new byte[] { 131, 94, 128, 240, 125, 26, 133, 39, 106, 158, 158, 251, 231, 72, 233, 42, 55, 250, 112, 239, 231, 139, 13, 121, 162, 92, 74, 205, 187, 69, 2, 77, 142, 176, 250, 206, 10, 11, 33, 107, 41, 56, 230, 239, 228, 56, 117, 179, 121, 149, 55, 43, 6, 170, 55, 35, 17, 176, 10, 94, 211, 2, 243, 32 }, new byte[] { 70, 125, 43, 33, 66, 103, 78, 50, 29, 210, 85, 67, 31, 252, 176, 195, 114, 229, 78, 40, 72, 201, 134, 146, 151, 237, 255, 104, 183, 56, 196, 201, 123, 16, 39, 132, 181, 191, 14, 169, 12, 65, 211, 177, 213, 58, 156, 139, 86, 150, 237, 162, 82, 120, 79, 228, 105, 101, 176, 144, 227, 164, 41, 131, 41, 60, 236, 9, 20, 205, 44, 230, 77, 41, 141, 226, 219, 42, 16, 155, 14, 18, 58, 202, 245, 65, 89, 3, 119, 83, 220, 61, 87, 82, 230, 38, 232, 170, 45, 61, 198, 124, 201, 211, 72, 210, 39, 98, 182, 119, 210, 143, 38, 224, 209, 70, 218, 124, 52, 4, 231, 46, 20, 228, 184, 64, 37, 198 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareRating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CultureRating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ExperienceContent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "OfficeRating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReasonContent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Recommened",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "SalaryRating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "SuggestionContent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "SummaryContent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "TrainingRating",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "ReasonToReject",
                table: "Reviews",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ReviewDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReviewId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false)
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
    }
}
