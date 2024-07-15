using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addSubmitionRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentSubmition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SubmitDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    AssessmentId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentSubmition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentSubmition_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 10, 28, 401, DateTimeKind.Utc).AddTicks(4471), new byte[] { 208, 116, 29, 67, 117, 45, 16, 15, 243, 214, 79, 232, 200, 130, 174, 86, 214, 100, 164, 239, 244, 190, 20, 184, 172, 65, 37, 6, 154, 121, 60, 115, 78, 14, 116, 97, 224, 232, 73, 215, 245, 186, 75, 115, 230, 222, 30, 189, 97, 162, 22, 0, 160, 236, 84, 102, 206, 90, 188, 17, 244, 163, 253, 119 }, new byte[] { 129, 38, 127, 164, 64, 28, 25, 220, 3, 45, 94, 250, 192, 157, 161, 16, 7, 143, 87, 158, 158, 199, 111, 160, 187, 135, 255, 42, 211, 68, 46, 131, 6, 234, 63, 80, 119, 182, 45, 135, 105, 227, 15, 140, 185, 244, 225, 175, 126, 156, 96, 138, 185, 225, 254, 35, 10, 69, 63, 101, 111, 149, 210, 2, 162, 145, 89, 96, 145, 76, 66, 203, 198, 176, 156, 165, 53, 86, 46, 217, 240, 24, 88, 125, 106, 200, 191, 101, 135, 250, 133, 168, 60, 62, 8, 67, 242, 190, 248, 88, 123, 166, 241, 252, 43, 213, 46, 245, 94, 153, 200, 194, 245, 121, 252, 74, 67, 242, 44, 184, 45, 236, 66, 43, 129, 55, 102, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 10, 28, 401, DateTimeKind.Utc).AddTicks(4477), new byte[] { 33, 211, 26, 254, 100, 62, 26, 64, 15, 223, 1, 147, 227, 9, 48, 255, 128, 96, 101, 108, 204, 146, 123, 53, 47, 82, 157, 178, 36, 247, 108, 158, 248, 218, 172, 193, 74, 249, 11, 151, 185, 23, 63, 156, 223, 13, 212, 178, 237, 70, 33, 79, 115, 164, 232, 112, 99, 94, 254, 12, 171, 176, 67, 138 }, new byte[] { 193, 223, 17, 173, 26, 87, 146, 227, 2, 151, 242, 36, 181, 211, 255, 145, 48, 0, 89, 226, 78, 75, 110, 62, 239, 174, 238, 130, 201, 175, 190, 196, 158, 154, 62, 34, 42, 3, 202, 249, 192, 174, 99, 232, 173, 82, 40, 240, 114, 19, 175, 134, 137, 105, 165, 117, 176, 44, 102, 216, 77, 167, 106, 8, 44, 142, 75, 42, 12, 68, 217, 120, 218, 209, 240, 141, 89, 33, 196, 253, 234, 231, 1, 91, 120, 186, 68, 66, 81, 249, 111, 144, 185, 163, 161, 94, 22, 174, 143, 77, 218, 196, 71, 55, 240, 248, 202, 104, 191, 69, 211, 230, 154, 115, 239, 237, 65, 170, 47, 31, 87, 144, 47, 38, 236, 138, 151, 141 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 10, 28, 401, DateTimeKind.Utc).AddTicks(4509), new byte[] { 217, 118, 120, 127, 134, 194, 66, 92, 148, 161, 214, 111, 34, 222, 114, 168, 171, 228, 18, 103, 122, 225, 24, 108, 91, 28, 105, 158, 224, 12, 31, 193, 214, 240, 189, 72, 186, 146, 33, 199, 106, 57, 86, 220, 31, 165, 24, 242, 194, 180, 39, 98, 36, 140, 141, 64, 251, 116, 182, 223, 237, 154, 151, 175 }, new byte[] { 183, 224, 184, 189, 40, 250, 89, 229, 104, 37, 101, 34, 105, 45, 33, 243, 2, 250, 98, 195, 132, 148, 189, 197, 172, 237, 123, 53, 48, 55, 53, 22, 64, 78, 67, 122, 86, 56, 203, 158, 40, 4, 20, 10, 26, 225, 22, 161, 108, 85, 176, 137, 45, 62, 117, 203, 142, 164, 38, 234, 209, 169, 37, 30, 147, 99, 9, 230, 69, 8, 249, 118, 33, 45, 37, 70, 158, 127, 47, 183, 248, 128, 129, 138, 93, 108, 81, 240, 104, 19, 103, 71, 33, 22, 176, 216, 138, 141, 148, 38, 220, 127, 159, 230, 184, 166, 207, 154, 59, 159, 100, 213, 54, 174, 106, 115, 141, 64, 50, 7, 91, 178, 32, 42, 235, 7, 23, 12 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 10, 28, 401, DateTimeKind.Utc).AddTicks(4510), new byte[] { 39, 184, 141, 213, 103, 91, 249, 156, 224, 2, 37, 8, 127, 96, 185, 240, 214, 188, 38, 40, 93, 29, 184, 4, 207, 255, 33, 74, 80, 58, 97, 195, 116, 17, 207, 165, 160, 113, 62, 141, 61, 185, 66, 77, 69, 254, 207, 162, 80, 52, 57, 123, 99, 165, 160, 176, 80, 55, 241, 47, 186, 244, 63, 140 }, new byte[] { 235, 64, 162, 35, 209, 240, 209, 81, 178, 126, 33, 166, 160, 124, 50, 104, 48, 183, 120, 99, 78, 134, 233, 77, 132, 249, 47, 175, 14, 26, 128, 146, 112, 31, 216, 135, 70, 36, 207, 151, 87, 3, 196, 26, 240, 83, 122, 174, 157, 172, 15, 166, 36, 11, 60, 27, 92, 1, 175, 174, 28, 185, 180, 22, 221, 226, 31, 98, 86, 225, 146, 108, 208, 108, 71, 41, 98, 119, 194, 167, 142, 216, 142, 248, 205, 108, 86, 208, 249, 127, 90, 124, 171, 183, 232, 103, 96, 219, 182, 175, 218, 208, 148, 212, 2, 177, 232, 233, 127, 103, 27, 88, 218, 28, 149, 190, 19, 234, 185, 48, 82, 18, 109, 41, 209, 24, 72, 182 } });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentSubmition_AssessmentId",
                table: "AssessmentSubmition",
                column: "AssessmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentSubmition");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 4, 56, 800, DateTimeKind.Utc).AddTicks(1393), new byte[] { 88, 208, 35, 7, 201, 45, 113, 210, 201, 146, 106, 217, 208, 3, 243, 3, 72, 198, 236, 172, 153, 154, 34, 46, 79, 214, 107, 14, 188, 193, 32, 162, 159, 25, 194, 56, 181, 88, 144, 122, 63, 169, 154, 160, 241, 121, 128, 45, 182, 34, 252, 18, 82, 255, 72, 206, 21, 127, 152, 199, 237, 187, 220, 128 }, new byte[] { 100, 178, 122, 159, 160, 16, 189, 237, 36, 138, 36, 196, 180, 35, 227, 198, 139, 255, 118, 89, 65, 190, 237, 48, 23, 69, 135, 174, 7, 102, 39, 97, 127, 231, 246, 18, 208, 152, 251, 217, 34, 26, 234, 105, 231, 109, 82, 182, 216, 81, 117, 28, 121, 91, 130, 200, 106, 36, 240, 59, 149, 253, 50, 172, 53, 118, 225, 178, 13, 157, 201, 242, 13, 132, 166, 201, 39, 176, 185, 201, 139, 125, 212, 127, 110, 118, 32, 42, 44, 128, 63, 122, 230, 170, 232, 161, 94, 247, 1, 87, 86, 202, 117, 97, 255, 130, 92, 253, 102, 98, 207, 125, 20, 228, 15, 54, 29, 171, 120, 238, 79, 88, 57, 227, 154, 124, 218, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 4, 56, 800, DateTimeKind.Utc).AddTicks(1401), new byte[] { 139, 210, 165, 90, 213, 67, 169, 234, 148, 147, 114, 178, 218, 68, 252, 203, 113, 110, 70, 47, 222, 192, 149, 183, 42, 60, 62, 117, 66, 35, 232, 84, 214, 93, 37, 230, 150, 149, 29, 95, 125, 172, 111, 82, 64, 31, 58, 185, 88, 247, 223, 41, 170, 33, 25, 231, 81, 216, 115, 30, 217, 167, 177, 86 }, new byte[] { 100, 115, 137, 121, 30, 124, 97, 62, 189, 244, 147, 147, 97, 102, 143, 91, 233, 8, 54, 249, 233, 136, 34, 185, 183, 15, 248, 29, 108, 196, 165, 118, 193, 169, 171, 169, 147, 25, 159, 5, 9, 155, 218, 55, 22, 245, 111, 16, 124, 158, 170, 54, 247, 29, 229, 96, 125, 107, 122, 40, 39, 112, 68, 249, 100, 36, 93, 173, 123, 218, 109, 172, 152, 119, 69, 96, 175, 186, 156, 205, 56, 96, 69, 173, 201, 110, 70, 172, 151, 83, 216, 214, 207, 174, 225, 88, 18, 219, 94, 84, 58, 78, 111, 57, 130, 254, 165, 120, 190, 70, 238, 59, 26, 170, 117, 116, 158, 192, 22, 145, 195, 130, 201, 155, 102, 225, 48, 182 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 4, 56, 800, DateTimeKind.Utc).AddTicks(1403), new byte[] { 101, 184, 62, 166, 155, 129, 62, 79, 174, 57, 30, 127, 42, 117, 241, 51, 98, 234, 186, 163, 11, 207, 163, 229, 117, 192, 199, 62, 144, 201, 3, 244, 226, 223, 166, 19, 164, 236, 166, 126, 8, 82, 232, 131, 166, 114, 60, 44, 11, 58, 94, 123, 90, 106, 53, 187, 230, 36, 163, 151, 201, 240, 16, 74 }, new byte[] { 164, 63, 43, 154, 10, 220, 89, 217, 88, 99, 186, 147, 64, 239, 33, 35, 180, 255, 147, 151, 52, 228, 179, 57, 43, 78, 161, 32, 198, 195, 85, 19, 244, 72, 180, 109, 193, 122, 32, 44, 71, 239, 228, 116, 86, 11, 146, 54, 160, 144, 92, 88, 156, 128, 101, 83, 97, 23, 125, 137, 4, 109, 231, 245, 139, 108, 50, 212, 172, 244, 157, 242, 163, 7, 30, 92, 206, 100, 142, 38, 250, 181, 206, 138, 103, 192, 217, 214, 65, 16, 239, 153, 131, 212, 200, 107, 52, 234, 114, 15, 62, 62, 254, 166, 140, 246, 149, 10, 218, 95, 181, 139, 122, 133, 214, 85, 45, 45, 229, 162, 153, 158, 134, 234, 91, 110, 63, 197 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 15, 11, 4, 56, 800, DateTimeKind.Utc).AddTicks(1405), new byte[] { 60, 177, 48, 221, 163, 28, 90, 121, 84, 154, 43, 56, 179, 77, 199, 132, 148, 51, 116, 114, 205, 187, 125, 16, 36, 26, 16, 140, 115, 33, 197, 94, 177, 107, 183, 247, 17, 124, 171, 230, 67, 192, 155, 40, 1, 135, 98, 231, 34, 27, 212, 213, 215, 84, 108, 72, 36, 104, 218, 159, 110, 244, 213, 211 }, new byte[] { 242, 17, 108, 84, 231, 67, 132, 92, 247, 31, 74, 80, 226, 235, 121, 79, 85, 51, 168, 121, 0, 133, 54, 122, 18, 54, 77, 201, 183, 165, 199, 98, 230, 79, 96, 224, 194, 75, 60, 255, 157, 6, 17, 195, 39, 190, 112, 62, 86, 58, 98, 42, 62, 214, 227, 10, 3, 33, 226, 101, 86, 64, 165, 181, 186, 32, 166, 224, 230, 4, 192, 7, 41, 161, 94, 210, 111, 251, 26, 175, 50, 82, 0, 226, 211, 26, 241, 237, 42, 8, 11, 187, 19, 194, 217, 21, 90, 40, 16, 14, 62, 54, 98, 123, 118, 143, 195, 144, 231, 105, 45, 140, 54, 84, 133, 3, 131, 37, 112, 226, 173, 253, 121, 50, 192, 224, 126, 18 } });
        }
    }
}
