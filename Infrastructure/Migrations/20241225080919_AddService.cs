using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.AddColumn<bool>(
                name: "IsHot",
                table: "JobPosts",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    NumberOfPost = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserServices_Users_UserId",
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
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 25, 8, 9, 18, 716, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(447), new byte[] { 14, 142, 73, 227, 172, 202, 8, 217, 150, 204, 34, 224, 206, 149, 117, 216, 137, 131, 121, 16, 34, 76, 175, 35, 123, 61, 180, 244, 240, 185, 123, 168, 204, 46, 188, 33, 13, 78, 120, 152, 230, 186, 13, 147, 240, 65, 225, 89, 77, 92, 92, 5, 207, 51, 207, 105, 99, 144, 169, 232, 139, 57, 23, 69 }, new byte[] { 62, 171, 201, 243, 197, 163, 128, 101, 146, 238, 83, 205, 201, 102, 49, 136, 158, 153, 103, 231, 65, 210, 78, 141, 3, 112, 188, 50, 61, 37, 159, 159, 202, 160, 246, 33, 51, 239, 227, 192, 45, 21, 84, 221, 54, 163, 60, 174, 120, 105, 131, 65, 68, 206, 73, 127, 234, 255, 72, 113, 122, 204, 45, 171, 226, 194, 11, 216, 150, 250, 144, 194, 123, 234, 168, 68, 40, 221, 226, 60, 105, 179, 203, 140, 121, 87, 77, 153, 253, 236, 201, 82, 78, 90, 243, 202, 98, 54, 172, 25, 62, 203, 230, 39, 79, 116, 194, 206, 119, 211, 154, 124, 202, 180, 188, 133, 9, 32, 183, 91, 131, 38, 102, 44, 253, 134, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(453), new byte[] { 50, 119, 189, 38, 243, 39, 201, 173, 58, 19, 200, 50, 65, 180, 143, 49, 8, 30, 62, 235, 63, 172, 116, 229, 210, 203, 157, 206, 34, 12, 83, 88, 1, 89, 167, 253, 191, 178, 3, 122, 172, 18, 39, 47, 134, 213, 163, 42, 19, 199, 4, 127, 159, 79, 37, 44, 246, 192, 227, 151, 114, 109, 72, 94 }, new byte[] { 135, 91, 254, 102, 2, 172, 119, 82, 191, 200, 123, 231, 111, 215, 18, 159, 119, 12, 57, 113, 213, 225, 92, 70, 87, 38, 156, 53, 248, 33, 83, 171, 56, 83, 47, 70, 179, 102, 118, 63, 208, 198, 198, 82, 5, 240, 156, 201, 194, 81, 117, 60, 241, 2, 146, 228, 202, 55, 247, 220, 242, 43, 67, 224, 118, 140, 86, 159, 206, 63, 149, 99, 209, 147, 225, 49, 237, 79, 39, 94, 204, 235, 243, 84, 217, 57, 191, 56, 166, 195, 115, 32, 69, 47, 6, 170, 106, 209, 171, 167, 211, 239, 166, 48, 53, 246, 23, 47, 255, 168, 4, 43, 99, 143, 240, 109, 243, 188, 154, 0, 121, 50, 189, 127, 26, 103, 2, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(455), new byte[] { 124, 164, 243, 219, 114, 126, 122, 100, 202, 66, 91, 136, 138, 211, 170, 85, 204, 41, 29, 94, 55, 157, 228, 15, 224, 103, 130, 227, 235, 255, 85, 181, 184, 78, 33, 44, 186, 215, 38, 135, 131, 5, 135, 113, 74, 244, 178, 201, 150, 30, 122, 174, 198, 233, 120, 238, 220, 181, 170, 137, 132, 131, 6, 93 }, new byte[] { 11, 251, 126, 68, 250, 14, 187, 192, 172, 202, 234, 91, 166, 54, 221, 0, 45, 207, 60, 20, 192, 223, 163, 3, 15, 240, 222, 20, 182, 244, 253, 182, 164, 98, 3, 19, 29, 244, 245, 194, 46, 144, 102, 192, 224, 127, 14, 224, 236, 10, 40, 172, 96, 162, 83, 156, 6, 222, 253, 193, 191, 140, 52, 1, 240, 237, 206, 65, 87, 144, 230, 110, 189, 104, 87, 130, 122, 79, 144, 40, 90, 61, 0, 102, 11, 163, 60, 212, 141, 202, 225, 113, 223, 196, 134, 80, 65, 123, 57, 172, 195, 251, 242, 205, 162, 241, 32, 33, 229, 26, 192, 135, 82, 45, 150, 2, 36, 116, 86, 167, 65, 69, 60, 132, 139, 203, 150, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 9, 18, 713, DateTimeKind.Utc).AddTicks(457), new byte[] { 251, 147, 90, 61, 157, 171, 187, 98, 183, 226, 188, 227, 180, 247, 155, 136, 34, 103, 228, 3, 1, 89, 202, 33, 8, 73, 62, 203, 100, 235, 242, 132, 97, 150, 79, 234, 202, 43, 163, 190, 244, 18, 169, 158, 208, 158, 95, 107, 99, 102, 239, 7, 24, 98, 76, 235, 137, 147, 81, 253, 255, 12, 28, 193 }, new byte[] { 46, 48, 85, 216, 76, 105, 150, 177, 51, 100, 121, 146, 61, 145, 174, 92, 4, 171, 159, 193, 97, 243, 236, 67, 214, 23, 124, 202, 247, 125, 181, 92, 210, 161, 124, 38, 85, 31, 242, 138, 228, 119, 34, 9, 63, 202, 213, 172, 23, 145, 124, 167, 142, 224, 139, 142, 9, 180, 226, 4, 221, 87, 177, 237, 126, 109, 248, 107, 217, 152, 120, 228, 74, 28, 87, 61, 109, 251, 179, 222, 240, 57, 69, 94, 179, 53, 150, 187, 19, 234, 217, 21, 92, 70, 209, 8, 55, 234, 23, 170, 3, 120, 96, 87, 147, 210, 183, 14, 248, 247, 75, 215, 229, 44, 143, 246, 23, 43, 62, 112, 136, 35, 44, 11, 158, 177, 1, 41 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_ServiceId",
                table: "UserServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserServices_UserId",
                table: "UserServices",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropColumn(
                name: "IsHot",
                table: "JobPosts");

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    StatusFeedBack = table.Column<int>(type: "integer", nullable: false)
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
                value: new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 208, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 208, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 14, 6, 52, 211, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8304), new byte[] { 74, 4, 36, 201, 59, 240, 96, 32, 205, 62, 125, 89, 46, 83, 162, 217, 124, 49, 54, 210, 150, 27, 63, 179, 125, 190, 253, 147, 165, 163, 93, 182, 203, 66, 132, 207, 12, 125, 39, 145, 212, 70, 51, 14, 18, 24, 225, 202, 5, 161, 197, 93, 46, 135, 72, 188, 148, 13, 160, 152, 172, 7, 77, 141 }, new byte[] { 25, 3, 191, 103, 136, 135, 55, 92, 120, 116, 102, 248, 246, 11, 200, 224, 216, 187, 104, 117, 240, 155, 132, 45, 156, 177, 30, 32, 173, 169, 220, 79, 20, 92, 27, 45, 216, 33, 160, 194, 233, 220, 188, 125, 187, 70, 125, 87, 172, 88, 194, 133, 225, 89, 69, 30, 245, 80, 170, 126, 219, 162, 64, 145, 205, 125, 249, 14, 9, 252, 34, 88, 106, 90, 234, 132, 17, 42, 154, 231, 139, 188, 18, 176, 45, 94, 247, 5, 60, 233, 111, 242, 71, 113, 229, 40, 145, 16, 30, 114, 8, 58, 208, 174, 60, 216, 81, 233, 14, 85, 177, 175, 246, 153, 13, 74, 86, 113, 42, 55, 74, 190, 123, 130, 174, 122, 120, 106 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8311), new byte[] { 201, 2, 145, 169, 45, 251, 166, 214, 11, 94, 174, 1, 99, 48, 218, 100, 40, 133, 41, 213, 167, 191, 217, 215, 105, 114, 209, 206, 200, 94, 154, 43, 196, 194, 231, 110, 56, 130, 212, 64, 117, 47, 190, 49, 40, 137, 149, 31, 251, 90, 233, 11, 96, 38, 197, 4, 182, 135, 209, 0, 245, 150, 227, 228 }, new byte[] { 89, 246, 179, 222, 219, 12, 15, 188, 191, 177, 10, 99, 85, 103, 220, 119, 93, 213, 73, 158, 158, 229, 240, 243, 36, 75, 4, 127, 74, 40, 69, 39, 189, 208, 228, 184, 255, 248, 61, 181, 158, 116, 251, 85, 54, 239, 49, 148, 156, 229, 219, 10, 92, 251, 38, 136, 67, 120, 94, 38, 11, 116, 12, 12, 126, 117, 67, 3, 8, 8, 222, 147, 77, 68, 163, 10, 122, 194, 197, 228, 118, 237, 20, 124, 143, 202, 233, 200, 81, 24, 183, 231, 158, 82, 130, 14, 51, 146, 112, 239, 6, 88, 165, 211, 234, 93, 212, 133, 59, 201, 183, 10, 202, 142, 176, 196, 253, 161, 89, 148, 217, 68, 142, 140, 167, 119, 182, 255 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8313), new byte[] { 233, 170, 57, 143, 140, 201, 82, 86, 186, 199, 91, 28, 210, 35, 169, 132, 113, 180, 93, 7, 40, 235, 62, 62, 221, 14, 90, 90, 164, 24, 217, 43, 162, 87, 197, 181, 57, 207, 40, 170, 219, 94, 19, 191, 216, 254, 70, 199, 243, 104, 158, 189, 58, 104, 242, 230, 196, 41, 81, 49, 123, 116, 138, 9 }, new byte[] { 230, 135, 201, 60, 136, 131, 25, 184, 58, 95, 135, 39, 255, 230, 163, 245, 65, 89, 148, 25, 162, 160, 94, 96, 102, 29, 120, 124, 85, 184, 100, 202, 10, 181, 200, 87, 109, 104, 198, 47, 131, 163, 207, 45, 21, 232, 86, 146, 179, 221, 114, 131, 155, 12, 23, 252, 94, 194, 128, 242, 77, 236, 146, 106, 228, 217, 38, 188, 254, 156, 48, 92, 215, 208, 68, 21, 99, 213, 237, 152, 170, 228, 32, 57, 95, 226, 118, 53, 247, 190, 21, 177, 105, 39, 71, 142, 77, 48, 63, 254, 15, 187, 56, 73, 116, 208, 86, 137, 40, 23, 240, 76, 85, 172, 201, 213, 23, 89, 251, 116, 76, 175, 192, 71, 91, 247, 74, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 6, 52, 207, DateTimeKind.Utc).AddTicks(8314), new byte[] { 113, 110, 58, 132, 162, 79, 136, 174, 253, 33, 81, 195, 121, 242, 38, 43, 65, 137, 20, 42, 186, 237, 110, 173, 32, 76, 222, 209, 166, 92, 120, 38, 59, 153, 168, 146, 128, 70, 121, 0, 201, 181, 193, 82, 73, 91, 125, 153, 109, 243, 151, 112, 192, 59, 217, 11, 139, 84, 169, 117, 87, 234, 179, 50 }, new byte[] { 238, 112, 20, 9, 71, 205, 86, 248, 203, 143, 68, 65, 49, 143, 135, 134, 185, 221, 89, 160, 42, 250, 132, 16, 148, 163, 51, 224, 64, 220, 209, 102, 181, 74, 52, 150, 95, 39, 64, 205, 145, 168, 23, 73, 224, 30, 5, 72, 5, 4, 67, 57, 24, 160, 31, 140, 210, 98, 20, 235, 86, 254, 26, 98, 13, 121, 141, 35, 220, 77, 154, 23, 117, 116, 93, 115, 53, 221, 50, 141, 77, 29, 252, 23, 45, 200, 36, 216, 43, 25, 199, 17, 124, 12, 28, 130, 8, 193, 95, 208, 237, 239, 20, 169, 122, 197, 0, 118, 253, 88, 168, 110, 113, 5, 89, 83, 121, 77, 210, 5, 122, 249, 109, 228, 67, 247, 114, 59 } });

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_CompanyId",
                table: "FeedBacks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_UserId",
                table: "FeedBacks",
                column: "UserId");
        }
    }
}
