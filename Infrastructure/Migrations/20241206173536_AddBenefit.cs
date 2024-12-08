using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBenefit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPostBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BenefitId = table.Column<int>(type: "integer", nullable: true),
                    JobPostId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostBenefits_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobPostBenefits_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SeekerBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    BenefitId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeekerBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeekerBenefits_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeekerBenefits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 17, 35, 36, 520, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3842), new byte[] { 78, 112, 88, 167, 120, 94, 245, 75, 222, 40, 91, 138, 18, 151, 168, 4, 209, 46, 221, 125, 245, 88, 139, 40, 61, 90, 59, 10, 196, 67, 203, 158, 86, 100, 208, 82, 21, 51, 70, 139, 221, 31, 125, 190, 71, 153, 100, 78, 13, 49, 49, 80, 8, 168, 251, 67, 202, 244, 149, 146, 102, 177, 148, 145 }, new byte[] { 140, 117, 58, 246, 13, 139, 246, 37, 100, 106, 70, 188, 57, 245, 106, 213, 215, 238, 108, 153, 88, 204, 50, 231, 57, 255, 202, 164, 44, 72, 37, 38, 72, 218, 7, 115, 124, 125, 232, 240, 254, 247, 167, 151, 168, 65, 89, 21, 36, 86, 186, 198, 130, 50, 83, 40, 18, 93, 102, 183, 18, 75, 141, 97, 115, 46, 110, 63, 167, 188, 236, 210, 46, 194, 90, 75, 59, 124, 151, 60, 211, 77, 137, 167, 226, 39, 148, 221, 237, 158, 135, 211, 79, 46, 129, 85, 120, 177, 147, 211, 154, 245, 121, 54, 223, 55, 88, 183, 173, 49, 192, 190, 102, 30, 215, 99, 170, 237, 195, 56, 9, 210, 94, 204, 122, 106, 126, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3851), new byte[] { 212, 158, 197, 92, 104, 133, 92, 188, 113, 186, 5, 222, 78, 179, 113, 35, 184, 50, 93, 85, 73, 0, 171, 148, 0, 38, 183, 229, 128, 126, 144, 113, 39, 177, 217, 155, 209, 228, 209, 66, 238, 120, 167, 112, 158, 102, 103, 81, 230, 66, 195, 87, 126, 35, 202, 129, 46, 96, 145, 83, 89, 50, 144, 137 }, new byte[] { 169, 254, 61, 47, 136, 220, 64, 53, 47, 44, 101, 242, 117, 246, 224, 113, 3, 180, 185, 101, 23, 54, 3, 16, 255, 168, 89, 167, 0, 21, 174, 123, 113, 68, 68, 169, 168, 225, 72, 191, 112, 33, 250, 24, 133, 196, 18, 91, 178, 178, 87, 215, 217, 208, 160, 56, 24, 251, 168, 8, 199, 171, 158, 44, 111, 101, 132, 102, 24, 218, 71, 91, 41, 81, 155, 25, 7, 182, 159, 26, 19, 160, 79, 168, 151, 6, 86, 205, 112, 226, 43, 108, 45, 234, 48, 253, 240, 116, 227, 2, 5, 198, 154, 245, 229, 159, 215, 170, 43, 168, 19, 138, 59, 214, 177, 105, 74, 210, 77, 156, 223, 96, 181, 109, 163, 201, 233, 16 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3852), new byte[] { 42, 175, 253, 188, 180, 246, 88, 195, 194, 1, 223, 3, 64, 125, 204, 188, 114, 214, 130, 129, 207, 87, 142, 252, 185, 254, 186, 184, 165, 21, 148, 64, 83, 37, 248, 3, 195, 80, 210, 49, 19, 171, 234, 28, 13, 254, 137, 198, 60, 22, 245, 84, 55, 118, 110, 137, 49, 252, 7, 60, 214, 37, 145, 240 }, new byte[] { 20, 12, 166, 124, 20, 253, 66, 142, 96, 45, 250, 231, 98, 56, 195, 98, 198, 62, 204, 46, 16, 66, 102, 128, 228, 96, 224, 88, 232, 239, 101, 91, 1, 243, 35, 119, 3, 128, 174, 5, 69, 113, 172, 88, 46, 135, 144, 226, 94, 242, 210, 148, 255, 218, 111, 61, 176, 87, 56, 220, 147, 150, 151, 195, 64, 56, 237, 83, 121, 148, 238, 242, 9, 86, 27, 206, 107, 250, 40, 4, 180, 251, 136, 138, 75, 72, 149, 207, 45, 176, 56, 209, 99, 23, 74, 112, 225, 138, 176, 152, 5, 35, 125, 165, 212, 118, 169, 179, 43, 26, 86, 81, 107, 177, 236, 6, 232, 33, 32, 36, 243, 90, 95, 129, 197, 206, 47, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 35, 36, 518, DateTimeKind.Utc).AddTicks(3854), new byte[] { 189, 85, 40, 177, 153, 173, 218, 203, 120, 84, 242, 237, 41, 18, 243, 31, 208, 163, 137, 121, 240, 109, 198, 161, 216, 53, 236, 27, 13, 216, 54, 198, 29, 192, 197, 203, 236, 11, 69, 227, 46, 211, 177, 14, 49, 18, 195, 198, 36, 161, 240, 250, 255, 136, 19, 213, 80, 32, 10, 227, 117, 137, 97, 239 }, new byte[] { 208, 114, 35, 98, 113, 160, 102, 254, 127, 54, 197, 227, 234, 42, 156, 87, 78, 227, 94, 198, 234, 88, 91, 192, 64, 217, 122, 131, 98, 153, 42, 131, 181, 149, 154, 55, 86, 190, 28, 92, 40, 180, 31, 18, 80, 214, 145, 146, 127, 186, 178, 63, 0, 29, 243, 51, 118, 131, 147, 222, 219, 67, 141, 8, 186, 90, 85, 89, 42, 91, 104, 242, 132, 17, 173, 189, 186, 117, 9, 117, 100, 115, 214, 253, 178, 94, 217, 76, 92, 250, 2, 254, 193, 229, 89, 131, 58, 21, 43, 164, 178, 199, 3, 73, 103, 33, 230, 162, 222, 8, 50, 248, 110, 140, 69, 83, 13, 26, 143, 255, 188, 227, 45, 221, 214, 149, 199, 182 } });

            migrationBuilder.CreateIndex(
                name: "IX_JobPostBenefits_BenefitId",
                table: "JobPostBenefits",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostBenefits_JobPostId",
                table: "JobPostBenefits",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerBenefits_BenefitId",
                table: "SeekerBenefits",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerBenefits_UserId",
                table: "SeekerBenefits",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPostBenefits");

            migrationBuilder.DropTable(
                name: "SeekerBenefits");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 23, 9, 2, 39, 615, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2816), new byte[] { 97, 102, 17, 60, 48, 183, 78, 50, 141, 187, 79, 253, 2, 85, 74, 226, 97, 174, 35, 39, 61, 94, 247, 56, 56, 24, 137, 215, 225, 56, 65, 199, 185, 53, 96, 83, 160, 136, 182, 153, 242, 182, 21, 48, 224, 226, 90, 79, 6, 113, 209, 21, 248, 132, 221, 214, 114, 213, 180, 150, 116, 254, 51, 42 }, new byte[] { 80, 77, 26, 222, 66, 85, 109, 39, 18, 12, 133, 223, 46, 88, 11, 32, 243, 64, 188, 223, 91, 248, 55, 207, 248, 81, 101, 51, 250, 34, 94, 159, 212, 226, 233, 6, 110, 170, 4, 8, 119, 51, 213, 114, 251, 175, 157, 101, 110, 69, 85, 101, 219, 155, 80, 103, 210, 9, 100, 235, 205, 30, 160, 252, 40, 198, 43, 18, 70, 205, 226, 161, 19, 141, 248, 18, 79, 31, 168, 126, 153, 165, 55, 66, 232, 149, 20, 162, 125, 219, 213, 251, 69, 160, 7, 158, 83, 225, 21, 167, 16, 30, 136, 151, 49, 17, 9, 224, 65, 221, 144, 115, 184, 72, 200, 96, 14, 137, 130, 41, 83, 114, 18, 66, 1, 79, 2, 211 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2823), new byte[] { 250, 129, 1, 185, 114, 63, 245, 177, 60, 55, 68, 164, 107, 135, 188, 163, 36, 102, 153, 128, 120, 3, 212, 134, 88, 141, 160, 158, 79, 100, 234, 54, 249, 222, 44, 83, 19, 100, 118, 237, 177, 41, 7, 2, 94, 224, 33, 191, 233, 180, 71, 113, 102, 205, 195, 152, 54, 80, 157, 78, 82, 231, 71, 51 }, new byte[] { 72, 219, 128, 133, 119, 15, 159, 87, 111, 32, 104, 101, 141, 158, 214, 36, 230, 173, 97, 185, 91, 214, 30, 20, 120, 32, 239, 85, 17, 130, 254, 78, 37, 217, 67, 170, 224, 240, 7, 92, 108, 191, 78, 10, 192, 225, 43, 145, 3, 134, 244, 13, 198, 76, 141, 127, 97, 197, 163, 23, 64, 79, 6, 56, 165, 212, 81, 40, 155, 189, 158, 129, 161, 156, 33, 90, 31, 58, 90, 97, 223, 219, 29, 246, 10, 186, 121, 77, 60, 146, 84, 172, 165, 3, 80, 79, 252, 246, 97, 3, 219, 160, 231, 108, 220, 43, 63, 10, 167, 73, 108, 19, 217, 116, 3, 123, 105, 162, 128, 80, 159, 158, 163, 109, 43, 29, 109, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2825), new byte[] { 120, 119, 201, 101, 75, 108, 154, 1, 32, 246, 143, 143, 229, 209, 227, 198, 187, 182, 106, 210, 91, 111, 6, 2, 226, 10, 35, 220, 141, 47, 188, 211, 161, 79, 158, 188, 77, 232, 60, 37, 6, 229, 7, 198, 194, 103, 122, 77, 252, 85, 243, 13, 134, 197, 250, 30, 173, 155, 200, 15, 222, 7, 112, 123 }, new byte[] { 19, 130, 108, 26, 23, 236, 72, 2, 6, 43, 247, 246, 120, 65, 36, 250, 175, 87, 79, 190, 17, 75, 191, 207, 66, 177, 226, 233, 24, 212, 168, 46, 2, 4, 200, 123, 142, 83, 46, 40, 164, 75, 216, 47, 225, 118, 58, 156, 112, 116, 219, 153, 45, 163, 114, 207, 225, 59, 79, 182, 153, 177, 144, 130, 42, 32, 184, 43, 248, 55, 238, 226, 143, 232, 216, 8, 18, 52, 180, 60, 190, 86, 99, 204, 36, 87, 0, 217, 8, 234, 199, 147, 189, 24, 175, 49, 75, 54, 239, 216, 75, 120, 65, 126, 136, 204, 127, 184, 225, 102, 14, 135, 109, 228, 35, 191, 133, 101, 177, 72, 239, 60, 67, 238, 244, 128, 240, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 23, 9, 2, 39, 614, DateTimeKind.Utc).AddTicks(2826), new byte[] { 205, 114, 17, 207, 249, 87, 117, 108, 126, 171, 86, 249, 37, 173, 195, 2, 197, 179, 101, 6, 124, 136, 177, 117, 207, 81, 99, 162, 211, 109, 27, 170, 216, 153, 141, 65, 236, 238, 159, 115, 73, 255, 87, 125, 190, 110, 217, 229, 99, 33, 65, 147, 172, 18, 246, 83, 180, 122, 48, 34, 163, 121, 62, 126 }, new byte[] { 224, 253, 246, 202, 136, 185, 181, 171, 102, 3, 33, 220, 10, 95, 246, 187, 107, 229, 223, 174, 210, 24, 86, 237, 180, 132, 213, 233, 141, 183, 251, 118, 230, 235, 216, 250, 161, 148, 216, 89, 168, 45, 8, 4, 213, 71, 58, 100, 112, 77, 162, 2, 166, 66, 153, 244, 91, 157, 125, 124, 61, 79, 79, 239, 51, 146, 121, 163, 202, 59, 210, 196, 250, 66, 11, 115, 189, 252, 6, 224, 50, 197, 135, 157, 144, 115, 187, 176, 225, 227, 205, 159, 89, 107, 253, 105, 191, 126, 221, 205, 130, 179, 225, 199, 150, 125, 71, 51, 219, 132, 133, 8, 77, 243, 56, 146, 75, 186, 250, 191, 103, 74, 146, 198, 219, 159, 133, 6 } });
        }
    }
}
