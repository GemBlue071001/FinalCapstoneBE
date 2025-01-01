using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StressAddressDetail = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    LocationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyLocations_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyLocations_Locations_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8319), new byte[] { 172, 151, 69, 67, 178, 97, 13, 31, 163, 252, 163, 170, 163, 213, 132, 126, 208, 137, 169, 147, 124, 81, 67, 57, 254, 66, 26, 68, 144, 246, 198, 40, 121, 155, 77, 37, 56, 124, 97, 189, 135, 177, 1, 251, 195, 13, 160, 38, 194, 179, 201, 47, 77, 78, 236, 211, 29, 94, 125, 171, 91, 219, 38, 50 }, new byte[] { 208, 5, 100, 48, 72, 221, 118, 176, 164, 86, 52, 98, 5, 29, 18, 126, 91, 154, 79, 181, 27, 115, 77, 216, 26, 150, 152, 125, 244, 18, 62, 71, 86, 190, 3, 32, 155, 239, 118, 83, 107, 68, 115, 105, 172, 74, 184, 232, 154, 214, 39, 27, 124, 134, 155, 23, 66, 249, 66, 48, 180, 55, 24, 2, 130, 190, 160, 194, 208, 130, 67, 75, 72, 237, 232, 23, 239, 202, 163, 155, 201, 184, 30, 178, 60, 162, 28, 68, 237, 154, 166, 246, 22, 255, 73, 23, 157, 237, 24, 169, 134, 62, 243, 17, 147, 67, 42, 241, 173, 217, 71, 158, 239, 5, 179, 163, 123, 151, 36, 87, 3, 121, 245, 191, 76, 181, 185, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8327), new byte[] { 247, 117, 131, 208, 230, 127, 216, 11, 212, 238, 146, 27, 178, 102, 232, 45, 105, 35, 146, 80, 149, 12, 245, 128, 94, 192, 113, 78, 97, 198, 101, 21, 196, 167, 233, 181, 83, 190, 26, 102, 55, 238, 113, 101, 156, 61, 210, 191, 243, 142, 9, 13, 7, 143, 105, 199, 22, 250, 242, 202, 97, 188, 150, 12 }, new byte[] { 92, 247, 72, 157, 119, 48, 144, 218, 107, 254, 84, 226, 114, 135, 132, 154, 230, 190, 179, 162, 113, 6, 30, 16, 109, 18, 48, 165, 218, 212, 32, 143, 78, 2, 27, 178, 48, 210, 155, 84, 132, 73, 59, 197, 113, 155, 57, 69, 65, 114, 191, 131, 84, 57, 179, 23, 123, 94, 132, 87, 219, 148, 14, 68, 12, 103, 254, 45, 112, 246, 6, 167, 209, 194, 202, 253, 215, 10, 222, 190, 128, 143, 227, 149, 95, 87, 176, 71, 52, 199, 165, 221, 57, 98, 153, 18, 229, 37, 37, 136, 97, 160, 209, 39, 96, 251, 239, 219, 183, 69, 41, 4, 195, 229, 185, 117, 233, 29, 27, 42, 1, 23, 130, 224, 155, 193, 9, 151 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8329), new byte[] { 32, 251, 250, 125, 185, 227, 227, 64, 168, 134, 197, 18, 88, 83, 196, 66, 69, 111, 61, 65, 252, 118, 96, 92, 125, 104, 254, 97, 196, 99, 132, 152, 49, 201, 185, 174, 34, 144, 241, 235, 123, 175, 16, 9, 109, 58, 128, 64, 249, 202, 68, 217, 249, 133, 106, 109, 39, 120, 34, 210, 186, 246, 46, 219 }, new byte[] { 87, 207, 212, 194, 22, 197, 64, 24, 109, 242, 24, 248, 183, 101, 46, 205, 183, 9, 182, 237, 59, 98, 217, 35, 12, 138, 82, 247, 32, 197, 254, 18, 109, 24, 210, 175, 67, 224, 51, 119, 143, 236, 161, 32, 29, 134, 121, 210, 226, 126, 255, 228, 149, 4, 163, 148, 85, 81, 121, 239, 255, 23, 144, 61, 49, 66, 14, 34, 71, 177, 8, 124, 102, 105, 185, 1, 153, 129, 113, 97, 9, 141, 79, 175, 211, 111, 117, 57, 146, 104, 106, 106, 150, 187, 129, 65, 222, 214, 188, 171, 72, 140, 145, 232, 174, 46, 254, 42, 34, 66, 227, 81, 16, 4, 132, 49, 44, 21, 164, 171, 3, 181, 228, 88, 80, 238, 187, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8331), new byte[] { 164, 202, 53, 31, 170, 127, 156, 210, 84, 229, 185, 166, 228, 232, 180, 24, 46, 82, 179, 51, 170, 209, 178, 168, 128, 33, 8, 80, 255, 113, 57, 226, 21, 69, 213, 180, 14, 207, 125, 11, 23, 88, 59, 213, 99, 210, 44, 104, 69, 144, 106, 122, 12, 2, 127, 6, 121, 190, 11, 77, 62, 2, 176, 99 }, new byte[] { 3, 228, 143, 248, 103, 48, 101, 134, 52, 75, 156, 207, 135, 94, 84, 191, 251, 117, 103, 144, 213, 206, 100, 78, 51, 153, 203, 216, 27, 34, 222, 244, 131, 192, 254, 60, 45, 42, 24, 245, 60, 208, 180, 80, 220, 67, 105, 208, 125, 103, 173, 123, 38, 17, 204, 120, 15, 47, 211, 153, 189, 168, 68, 208, 70, 215, 89, 255, 2, 169, 106, 148, 201, 72, 100, 221, 113, 172, 218, 198, 19, 81, 40, 181, 7, 29, 233, 4, 189, 63, 220, 197, 99, 113, 200, 184, 115, 74, 236, 152, 249, 156, 0, 227, 164, 62, 159, 72, 49, 161, 54, 118, 57, 186, 194, 224, 176, 155, 250, 83, 14, 96, 196, 127, 0, 192, 121, 122 } });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLocations_CompanyId",
                table: "CompanyLocations",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyLocations");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 664, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 664, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 26, 8, 35, 24, 668, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3561), new byte[] { 42, 33, 183, 182, 194, 154, 68, 135, 189, 96, 230, 187, 59, 186, 115, 249, 30, 114, 132, 152, 128, 70, 255, 30, 134, 64, 120, 23, 235, 213, 239, 77, 219, 252, 134, 23, 12, 76, 226, 32, 148, 46, 173, 160, 73, 156, 226, 27, 70, 211, 174, 164, 19, 198, 19, 206, 46, 252, 8, 89, 151, 136, 184, 105 }, new byte[] { 96, 22, 102, 253, 28, 124, 103, 129, 103, 11, 217, 56, 91, 169, 224, 184, 147, 76, 44, 188, 46, 45, 203, 47, 208, 115, 176, 177, 69, 135, 43, 39, 176, 238, 22, 50, 16, 214, 194, 215, 114, 179, 16, 66, 63, 105, 216, 161, 197, 178, 215, 250, 225, 197, 255, 227, 210, 241, 245, 180, 102, 77, 108, 32, 204, 205, 152, 61, 84, 1, 21, 87, 163, 134, 2, 67, 120, 38, 98, 197, 195, 214, 168, 130, 204, 254, 23, 254, 239, 229, 38, 66, 252, 168, 89, 179, 226, 242, 8, 225, 32, 83, 132, 74, 182, 196, 169, 226, 45, 72, 90, 26, 222, 201, 49, 139, 16, 145, 153, 174, 165, 132, 214, 255, 231, 237, 79, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3577), new byte[] { 236, 147, 216, 55, 91, 48, 126, 197, 183, 167, 57, 135, 238, 192, 63, 56, 180, 209, 64, 82, 129, 71, 229, 176, 184, 15, 95, 79, 233, 47, 147, 237, 159, 45, 45, 0, 157, 56, 218, 61, 74, 133, 237, 40, 113, 232, 217, 127, 68, 219, 71, 46, 122, 97, 57, 75, 20, 67, 157, 207, 73, 137, 115, 178 }, new byte[] { 240, 78, 45, 0, 236, 230, 96, 127, 133, 4, 144, 81, 56, 81, 34, 19, 174, 108, 20, 209, 126, 118, 64, 125, 49, 21, 150, 6, 227, 71, 22, 17, 215, 199, 247, 186, 67, 70, 109, 14, 117, 202, 132, 253, 252, 25, 215, 69, 35, 198, 21, 70, 245, 220, 176, 123, 227, 126, 216, 245, 104, 209, 33, 51, 8, 239, 183, 35, 133, 94, 21, 209, 198, 246, 52, 205, 41, 12, 77, 238, 145, 49, 209, 93, 24, 207, 194, 22, 242, 49, 182, 31, 17, 233, 214, 228, 128, 215, 104, 195, 66, 213, 172, 167, 14, 143, 218, 237, 156, 92, 151, 119, 164, 70, 62, 198, 128, 238, 127, 49, 7, 66, 127, 56, 56, 86, 166, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3580), new byte[] { 106, 25, 192, 177, 51, 206, 197, 158, 61, 87, 195, 15, 140, 121, 91, 145, 33, 195, 233, 34, 102, 222, 200, 163, 238, 47, 197, 35, 68, 120, 214, 40, 1, 29, 255, 133, 80, 152, 228, 116, 200, 229, 56, 236, 126, 85, 153, 30, 121, 44, 94, 242, 147, 79, 90, 97, 15, 244, 23, 185, 104, 136, 39, 122 }, new byte[] { 5, 214, 176, 138, 123, 25, 215, 158, 233, 118, 68, 59, 24, 77, 180, 188, 55, 83, 158, 180, 160, 251, 173, 134, 77, 55, 60, 192, 148, 228, 133, 74, 153, 64, 3, 115, 242, 91, 62, 248, 144, 181, 27, 189, 91, 123, 152, 20, 204, 84, 203, 222, 24, 214, 109, 28, 44, 125, 64, 199, 66, 11, 138, 86, 134, 156, 236, 1, 76, 146, 180, 119, 94, 34, 9, 10, 93, 150, 160, 162, 246, 173, 66, 255, 199, 5, 82, 46, 52, 192, 122, 68, 46, 197, 52, 29, 85, 51, 90, 165, 215, 142, 111, 33, 73, 168, 134, 106, 249, 106, 74, 37, 173, 182, 135, 70, 32, 197, 182, 241, 65, 106, 175, 199, 5, 253, 223, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 26, 8, 35, 24, 663, DateTimeKind.Utc).AddTicks(3582), new byte[] { 165, 33, 53, 186, 28, 53, 132, 232, 115, 143, 226, 190, 71, 173, 65, 105, 247, 121, 200, 14, 88, 15, 205, 25, 132, 242, 185, 251, 202, 104, 74, 237, 223, 101, 59, 154, 179, 248, 252, 167, 35, 115, 88, 92, 192, 117, 35, 186, 222, 25, 229, 54, 179, 77, 154, 42, 113, 82, 77, 99, 24, 84, 5, 229 }, new byte[] { 4, 24, 161, 87, 175, 196, 0, 249, 150, 15, 69, 144, 37, 223, 10, 194, 235, 48, 241, 250, 78, 231, 120, 121, 104, 98, 20, 226, 182, 94, 41, 64, 184, 233, 188, 162, 189, 122, 235, 139, 183, 107, 193, 114, 124, 108, 68, 179, 196, 210, 21, 225, 4, 194, 204, 10, 74, 204, 32, 171, 209, 10, 132, 6, 44, 25, 226, 156, 183, 53, 169, 99, 177, 126, 91, 91, 251, 18, 69, 196, 204, 203, 177, 227, 210, 14, 70, 56, 171, 26, 39, 118, 233, 176, 213, 217, 124, 116, 39, 66, 216, 25, 159, 89, 165, 185, 80, 227, 90, 248, 169, 73, 41, 0, 255, 229, 147, 246, 237, 221, 14, 147, 7, 120, 68, 27, 163, 215 } });
        }
    }
}
