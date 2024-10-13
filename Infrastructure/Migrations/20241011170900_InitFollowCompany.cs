using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitFollowCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FollowCompanys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    table.PrimaryKey("PK_FollowCompanys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowCompanys_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowCompanys_Users_UserId",
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
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5772), new byte[] { 115, 126, 19, 90, 30, 100, 162, 242, 213, 162, 85, 17, 23, 197, 205, 229, 213, 131, 137, 180, 71, 221, 36, 7, 11, 171, 239, 167, 123, 215, 0, 188, 221, 167, 63, 97, 78, 181, 252, 53, 154, 127, 93, 254, 23, 86, 30, 27, 53, 113, 225, 226, 182, 138, 158, 170, 67, 62, 153, 155, 95, 116, 87, 56 }, new byte[] { 70, 218, 92, 107, 177, 7, 204, 51, 237, 195, 21, 56, 80, 136, 219, 69, 14, 94, 169, 211, 246, 167, 63, 155, 11, 87, 127, 85, 185, 181, 251, 248, 166, 170, 67, 4, 27, 174, 80, 235, 81, 44, 232, 72, 245, 166, 181, 231, 81, 244, 236, 5, 67, 77, 39, 123, 220, 160, 38, 67, 200, 17, 89, 213, 38, 49, 201, 158, 238, 204, 167, 72, 60, 173, 163, 121, 82, 210, 42, 219, 22, 209, 193, 192, 114, 36, 73, 88, 175, 96, 218, 146, 71, 196, 167, 71, 65, 247, 33, 106, 242, 70, 132, 107, 138, 213, 246, 70, 75, 142, 225, 56, 172, 26, 46, 252, 19, 17, 9, 177, 254, 46, 234, 163, 51, 109, 175, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5778), new byte[] { 79, 165, 141, 65, 121, 254, 70, 23, 107, 197, 209, 233, 140, 222, 203, 186, 150, 242, 234, 19, 106, 111, 68, 66, 211, 108, 92, 55, 232, 227, 219, 30, 203, 149, 169, 198, 178, 19, 180, 53, 165, 225, 112, 189, 100, 65, 23, 140, 26, 0, 220, 98, 157, 86, 77, 172, 74, 54, 24, 21, 223, 215, 63, 67 }, new byte[] { 194, 135, 248, 157, 134, 64, 7, 37, 2, 127, 15, 139, 10, 146, 193, 197, 193, 153, 104, 193, 123, 200, 100, 32, 45, 206, 137, 142, 99, 137, 176, 90, 125, 250, 204, 90, 128, 201, 139, 34, 104, 8, 120, 44, 176, 127, 129, 37, 39, 53, 137, 0, 75, 195, 192, 92, 207, 106, 9, 126, 234, 119, 119, 40, 187, 246, 213, 142, 215, 254, 44, 182, 183, 28, 85, 75, 110, 163, 130, 164, 109, 94, 214, 209, 33, 184, 162, 32, 225, 104, 195, 216, 168, 73, 214, 43, 126, 223, 178, 28, 15, 2, 169, 84, 32, 118, 153, 233, 82, 99, 80, 218, 184, 237, 101, 74, 52, 151, 234, 193, 222, 130, 150, 182, 76, 7, 206, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5780), new byte[] { 141, 224, 115, 127, 82, 163, 88, 63, 37, 184, 136, 199, 32, 50, 230, 68, 254, 172, 103, 105, 224, 140, 93, 162, 100, 249, 248, 32, 71, 110, 242, 188, 204, 174, 0, 48, 143, 176, 211, 188, 31, 222, 189, 198, 186, 178, 133, 112, 154, 173, 145, 1, 30, 86, 201, 129, 132, 194, 155, 156, 220, 150, 170, 68 }, new byte[] { 166, 209, 63, 33, 149, 157, 14, 184, 253, 93, 218, 94, 81, 57, 9, 92, 249, 58, 88, 100, 181, 125, 247, 110, 107, 70, 247, 130, 147, 51, 61, 218, 91, 170, 204, 240, 66, 123, 56, 72, 172, 23, 199, 197, 118, 203, 174, 223, 55, 209, 134, 163, 149, 19, 106, 2, 21, 12, 96, 210, 220, 108, 116, 221, 201, 93, 90, 35, 118, 127, 185, 30, 115, 55, 251, 21, 219, 107, 207, 251, 69, 183, 154, 153, 165, 125, 241, 225, 164, 162, 45, 54, 16, 210, 55, 161, 222, 111, 51, 209, 200, 222, 69, 31, 157, 141, 4, 162, 157, 48, 23, 68, 255, 127, 61, 228, 163, 217, 166, 185, 53, 35, 12, 255, 207, 248, 92, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5781), new byte[] { 132, 224, 218, 120, 83, 112, 29, 85, 174, 20, 201, 85, 44, 236, 107, 40, 55, 2, 50, 59, 62, 240, 161, 31, 3, 57, 86, 106, 200, 173, 196, 63, 6, 241, 153, 212, 199, 158, 80, 249, 175, 115, 217, 222, 35, 216, 41, 154, 199, 114, 76, 39, 1, 156, 61, 28, 20, 192, 195, 19, 199, 196, 187, 48 }, new byte[] { 165, 63, 240, 203, 214, 47, 103, 2, 254, 178, 12, 167, 136, 22, 110, 46, 52, 107, 236, 43, 160, 130, 189, 63, 28, 193, 95, 157, 184, 188, 160, 205, 34, 118, 49, 238, 172, 30, 33, 131, 4, 99, 203, 119, 7, 177, 161, 13, 171, 92, 245, 31, 134, 195, 115, 15, 124, 91, 97, 147, 83, 143, 215, 5, 169, 245, 78, 162, 84, 243, 161, 202, 134, 253, 163, 240, 96, 186, 59, 114, 182, 168, 12, 201, 154, 220, 242, 127, 131, 224, 221, 140, 121, 50, 122, 140, 115, 128, 66, 49, 92, 151, 90, 211, 177, 23, 74, 175, 102, 75, 56, 84, 115, 187, 114, 203, 88, 135, 47, 205, 18, 44, 114, 120, 133, 142, 5, 99 } });

            migrationBuilder.CreateIndex(
                name: "IX_FollowCompanys_CompanyId",
                table: "FollowCompanys",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowCompanys_UserId",
                table: "FollowCompanys",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowCompanys");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 529, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 529, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 14, 23, 49, 530, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8385), new byte[] { 134, 159, 52, 119, 73, 255, 101, 65, 132, 183, 83, 1, 124, 60, 227, 229, 119, 111, 184, 231, 34, 191, 122, 163, 231, 171, 73, 54, 14, 50, 19, 183, 41, 132, 127, 213, 75, 123, 132, 207, 209, 171, 96, 56, 84, 223, 52, 130, 98, 41, 201, 248, 8, 220, 46, 109, 40, 156, 27, 54, 180, 247, 96, 68 }, new byte[] { 73, 106, 237, 128, 165, 26, 169, 137, 129, 171, 96, 173, 189, 162, 160, 15, 83, 241, 8, 134, 197, 246, 134, 206, 189, 222, 104, 75, 228, 182, 100, 188, 192, 121, 115, 71, 86, 246, 96, 145, 165, 39, 189, 230, 245, 159, 216, 3, 85, 249, 135, 210, 81, 246, 51, 84, 180, 73, 203, 215, 11, 188, 19, 154, 130, 23, 35, 181, 15, 22, 179, 16, 135, 209, 32, 128, 200, 62, 118, 158, 242, 103, 227, 128, 244, 35, 158, 1, 238, 172, 44, 199, 52, 8, 60, 116, 172, 120, 52, 83, 5, 139, 178, 105, 85, 236, 71, 131, 3, 245, 29, 108, 185, 88, 65, 14, 20, 161, 148, 95, 62, 240, 103, 101, 247, 171, 18, 170 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8393), new byte[] { 166, 222, 215, 6, 42, 184, 99, 155, 160, 73, 171, 118, 166, 80, 25, 34, 245, 205, 124, 69, 96, 219, 204, 91, 164, 206, 211, 1, 137, 124, 229, 224, 2, 187, 244, 237, 12, 208, 214, 106, 66, 69, 139, 204, 101, 71, 84, 185, 72, 21, 253, 99, 137, 231, 217, 168, 241, 38, 255, 53, 129, 228, 216, 24 }, new byte[] { 223, 175, 15, 222, 239, 115, 74, 113, 140, 120, 49, 61, 116, 18, 22, 69, 163, 184, 117, 4, 214, 163, 12, 226, 30, 184, 69, 122, 50, 223, 111, 32, 180, 168, 21, 191, 41, 93, 47, 18, 28, 52, 171, 165, 31, 33, 140, 58, 175, 195, 210, 121, 211, 178, 222, 216, 220, 222, 242, 171, 188, 84, 204, 143, 113, 69, 158, 116, 211, 144, 183, 20, 39, 226, 27, 49, 93, 189, 1, 47, 205, 216, 254, 10, 202, 24, 191, 2, 148, 190, 210, 151, 73, 99, 110, 213, 107, 58, 230, 61, 79, 69, 164, 44, 113, 111, 46, 144, 242, 78, 181, 124, 16, 34, 148, 191, 9, 253, 34, 77, 6, 55, 187, 105, 94, 185, 109, 6 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8395), new byte[] { 180, 74, 124, 42, 241, 29, 222, 230, 200, 88, 7, 121, 219, 144, 72, 20, 34, 120, 178, 43, 169, 2, 154, 233, 204, 140, 241, 145, 195, 220, 114, 248, 148, 216, 161, 255, 147, 127, 94, 136, 125, 119, 191, 143, 197, 135, 102, 111, 208, 170, 123, 93, 226, 8, 0, 75, 124, 56, 80, 197, 79, 82, 255, 45 }, new byte[] { 209, 217, 175, 162, 71, 34, 227, 165, 25, 227, 114, 107, 161, 96, 222, 183, 164, 82, 172, 9, 54, 135, 200, 122, 92, 146, 124, 206, 184, 252, 252, 243, 83, 116, 94, 251, 122, 229, 254, 9, 86, 36, 205, 197, 98, 16, 76, 11, 132, 84, 185, 154, 97, 6, 221, 56, 172, 171, 103, 208, 16, 194, 124, 189, 40, 117, 71, 157, 154, 108, 147, 204, 42, 25, 29, 154, 113, 164, 250, 8, 37, 231, 111, 63, 100, 123, 101, 154, 152, 162, 103, 11, 87, 166, 90, 216, 157, 34, 233, 114, 204, 226, 61, 43, 52, 217, 141, 14, 84, 187, 59, 213, 240, 224, 164, 41, 92, 216, 154, 224, 2, 157, 53, 221, 227, 252, 10, 60 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 23, 49, 528, DateTimeKind.Utc).AddTicks(8397), new byte[] { 114, 138, 202, 19, 3, 147, 56, 191, 27, 47, 151, 34, 168, 12, 148, 118, 157, 227, 131, 109, 201, 16, 209, 168, 30, 155, 143, 212, 110, 50, 98, 18, 143, 132, 105, 89, 63, 1, 69, 100, 90, 225, 135, 146, 240, 87, 129, 243, 67, 163, 249, 76, 90, 10, 251, 244, 225, 83, 181, 148, 208, 121, 28, 128 }, new byte[] { 87, 11, 203, 221, 107, 35, 104, 17, 44, 209, 76, 253, 198, 68, 251, 154, 209, 56, 107, 109, 80, 160, 245, 202, 36, 134, 99, 174, 100, 12, 1, 240, 223, 105, 254, 147, 244, 203, 147, 180, 240, 201, 243, 57, 86, 174, 191, 209, 19, 52, 140, 206, 191, 28, 52, 224, 202, 251, 135, 20, 88, 109, 173, 252, 238, 154, 217, 155, 191, 170, 51, 67, 189, 43, 174, 198, 200, 17, 227, 226, 126, 57, 137, 25, 57, 104, 56, 185, 187, 168, 90, 111, 53, 153, 60, 106, 76, 168, 139, 162, 63, 165, 254, 148, 147, 70, 254, 27, 145, 189, 236, 0, 172, 220, 111, 106, 157, 136, 146, 122, 144, 166, 8, 16, 16, 39, 27, 197 } });
        }
    }
}
