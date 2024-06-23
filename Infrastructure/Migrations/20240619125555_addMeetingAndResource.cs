using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMeetingAndResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramResource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ResourceId = table.Column<int>(type: "integer", nullable: true),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramResource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramResource_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resource",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrainingProgramResource_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 58, 188, 198, 130, 251, 64, 133, 232, 229, 134, 230, 45, 222, 96, 188, 52, 1, 74, 141, 40, 219, 40, 40, 50, 128, 226, 138, 155, 109, 170, 43, 252, 58, 94, 161, 192, 130, 49, 221, 106, 73, 111, 181, 15, 184, 255, 243, 35, 94, 204, 42, 254, 9, 42, 186, 47, 3, 218, 73, 92, 215, 37, 32 }, new byte[] { 142, 29, 20, 102, 100, 97, 60, 0, 71, 144, 60, 42, 165, 25, 142, 113, 253, 161, 133, 225, 89, 251, 89, 120, 148, 165, 184, 76, 158, 134, 200, 24, 248, 69, 86, 229, 207, 139, 253, 195, 195, 53, 40, 224, 180, 230, 165, 11, 51, 133, 129, 185, 29, 40, 88, 156, 5, 91, 225, 209, 226, 28, 159, 147, 241, 86, 144, 107, 227, 70, 21, 189, 191, 138, 246, 78, 249, 232, 145, 226, 164, 116, 145, 185, 165, 200, 59, 96, 69, 69, 135, 84, 38, 210, 239, 142, 187, 60, 80, 84, 92, 106, 247, 108, 153, 239, 123, 210, 180, 8, 65, 147, 104, 63, 138, 58, 195, 239, 64, 171, 144, 17, 4, 180, 226, 227, 225, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 247, 74, 77, 198, 197, 232, 125, 1, 94, 6, 199, 12, 170, 185, 103, 218, 136, 11, 172, 99, 91, 132, 61, 169, 245, 71, 114, 37, 147, 65, 153, 208, 107, 3, 124, 178, 20, 72, 239, 217, 76, 135, 174, 239, 206, 229, 200, 216, 104, 199, 151, 36, 180, 197, 51, 91, 52, 38, 134, 110, 20, 145, 231 }, new byte[] { 32, 44, 239, 23, 32, 182, 161, 59, 120, 213, 41, 68, 11, 197, 89, 91, 115, 17, 136, 8, 185, 182, 110, 237, 128, 162, 32, 238, 6, 210, 45, 123, 135, 246, 151, 92, 128, 103, 137, 216, 76, 128, 41, 163, 217, 170, 207, 108, 201, 154, 126, 48, 118, 161, 249, 229, 47, 178, 46, 215, 46, 250, 149, 64, 119, 64, 45, 12, 124, 21, 22, 115, 80, 88, 22, 208, 239, 21, 151, 2, 189, 36, 8, 43, 86, 230, 66, 134, 13, 206, 235, 65, 4, 27, 60, 72, 104, 220, 138, 252, 23, 162, 63, 20, 113, 224, 127, 5, 134, 7, 196, 37, 161, 158, 239, 78, 70, 128, 205, 166, 225, 218, 159, 71, 18, 40, 238, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 45, 108, 95, 55, 116, 81, 211, 173, 138, 208, 252, 197, 43, 108, 183, 179, 253, 189, 243, 71, 177, 22, 3, 24, 49, 134, 102, 148, 37, 135, 73, 177, 113, 110, 1, 5, 16, 23, 23, 56, 201, 216, 70, 158, 210, 36, 200, 255, 237, 204, 222, 166, 74, 140, 127, 189, 27, 236, 30, 83, 169, 59, 202 }, new byte[] { 116, 193, 129, 14, 92, 62, 84, 208, 190, 25, 26, 166, 66, 54, 96, 80, 124, 166, 87, 120, 170, 23, 35, 11, 251, 98, 111, 28, 39, 87, 158, 7, 248, 223, 51, 150, 60, 105, 15, 33, 112, 69, 200, 112, 212, 193, 7, 48, 169, 147, 26, 91, 236, 162, 50, 75, 23, 189, 234, 225, 9, 238, 108, 0, 96, 152, 23, 222, 128, 42, 10, 15, 236, 99, 184, 107, 70, 96, 231, 30, 253, 150, 121, 209, 238, 149, 194, 184, 240, 194, 232, 210, 176, 71, 252, 117, 116, 149, 67, 161, 3, 97, 130, 192, 15, 139, 99, 83, 47, 66, 202, 71, 112, 180, 138, 180, 209, 192, 91, 203, 106, 249, 171, 234, 232, 101, 73, 158 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 132, 185, 27, 254, 35, 225, 170, 102, 103, 78, 85, 230, 91, 2, 36, 253, 114, 166, 222, 3, 187, 14, 125, 2, 112, 15, 55, 205, 90, 192, 174, 231, 164, 94, 110, 61, 249, 12, 210, 142, 58, 186, 83, 22, 88, 11, 185, 78, 227, 249, 18, 37, 151, 209, 249, 91, 193, 136, 72, 94, 195, 14, 189, 253 }, new byte[] { 71, 236, 240, 54, 116, 123, 175, 229, 166, 121, 245, 236, 212, 214, 89, 237, 180, 208, 110, 102, 135, 249, 85, 173, 10, 109, 130, 60, 114, 87, 240, 137, 112, 94, 126, 85, 219, 242, 76, 233, 217, 249, 124, 224, 33, 195, 115, 225, 96, 69, 202, 171, 128, 3, 181, 230, 113, 149, 207, 103, 231, 180, 177, 132, 61, 121, 140, 28, 145, 172, 64, 125, 120, 45, 222, 241, 168, 46, 66, 145, 26, 21, 0, 12, 140, 147, 52, 184, 240, 111, 230, 42, 103, 153, 183, 105, 123, 225, 18, 116, 156, 47, 232, 37, 61, 67, 148, 207, 169, 107, 41, 195, 93, 124, 21, 85, 95, 121, 14, 123, 164, 73, 74, 71, 153, 98, 62, 174 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramResource_ResourceId",
                table: "TrainingProgramResource",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramResource_TrainingProgramId",
                table: "TrainingProgramResource",
                column: "TrainingProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingProgramResource");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 185, 85, 113, 216, 198, 107, 134, 30, 208, 105, 128, 180, 174, 93, 107, 56, 152, 67, 115, 176, 75, 224, 191, 166, 29, 163, 2, 11, 96, 27, 22, 106, 181, 238, 187, 233, 97, 38, 129, 122, 38, 41, 139, 213, 248, 74, 218, 131, 212, 53, 150, 234, 1, 233, 117, 230, 165, 55, 50, 91, 216, 60, 225, 171 }, new byte[] { 209, 132, 89, 142, 134, 47, 181, 217, 13, 82, 174, 0, 247, 133, 167, 3, 220, 46, 98, 108, 186, 194, 19, 175, 74, 224, 18, 203, 109, 194, 11, 186, 84, 75, 138, 158, 202, 157, 111, 1, 149, 78, 129, 30, 216, 168, 131, 77, 91, 33, 180, 103, 6, 191, 4, 220, 73, 239, 118, 154, 190, 239, 122, 185, 116, 141, 34, 184, 163, 53, 88, 115, 20, 4, 47, 220, 0, 241, 194, 188, 7, 124, 12, 33, 45, 246, 232, 138, 168, 125, 151, 4, 193, 95, 29, 166, 240, 109, 123, 246, 93, 26, 222, 115, 167, 23, 220, 222, 193, 50, 0, 112, 225, 55, 75, 118, 143, 108, 13, 91, 195, 213, 182, 46, 120, 20, 64, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 244, 195, 197, 116, 187, 236, 190, 61, 202, 15, 149, 111, 127, 86, 252, 85, 121, 164, 146, 161, 165, 255, 6, 179, 217, 197, 239, 253, 157, 11, 187, 182, 38, 94, 18, 77, 163, 187, 207, 65, 242, 230, 154, 217, 146, 238, 29, 76, 233, 156, 9, 30, 192, 102, 103, 164, 173, 165, 165, 84, 241, 45, 29, 247 }, new byte[] { 230, 215, 57, 147, 192, 83, 23, 14, 61, 90, 212, 47, 132, 82, 43, 64, 186, 207, 8, 80, 181, 13, 59, 203, 6, 155, 11, 211, 7, 64, 245, 229, 135, 123, 231, 21, 137, 99, 73, 253, 92, 208, 135, 230, 137, 8, 42, 95, 181, 210, 97, 166, 235, 164, 242, 154, 151, 36, 62, 178, 115, 37, 94, 231, 33, 254, 239, 19, 93, 201, 118, 193, 0, 210, 8, 101, 143, 8, 198, 117, 244, 182, 179, 128, 174, 164, 105, 148, 200, 174, 161, 146, 243, 30, 255, 58, 247, 190, 50, 223, 193, 126, 80, 48, 19, 141, 159, 159, 231, 210, 30, 0, 190, 181, 44, 17, 14, 4, 48, 198, 79, 13, 37, 141, 64, 76, 173, 86 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 194, 77, 155, 221, 196, 40, 141, 33, 215, 97, 192, 229, 198, 211, 131, 8, 154, 37, 58, 131, 15, 18, 75, 6, 201, 255, 151, 182, 190, 177, 126, 12, 195, 56, 67, 96, 136, 67, 96, 80, 15, 148, 52, 25, 41, 62, 204, 153, 251, 103, 194, 237, 22, 104, 90, 195, 177, 55, 11, 12, 25, 127, 98, 225 }, new byte[] { 21, 164, 37, 64, 0, 248, 91, 26, 192, 34, 15, 245, 37, 66, 124, 243, 5, 224, 212, 233, 201, 24, 165, 152, 141, 132, 69, 123, 113, 107, 97, 44, 145, 13, 125, 44, 200, 161, 42, 134, 110, 134, 83, 228, 94, 62, 224, 223, 159, 13, 86, 79, 86, 95, 165, 212, 181, 147, 166, 147, 181, 84, 186, 186, 193, 187, 9, 2, 226, 174, 31, 89, 179, 68, 61, 171, 144, 140, 81, 122, 252, 237, 144, 93, 40, 240, 120, 230, 10, 113, 94, 153, 72, 16, 192, 40, 18, 99, 243, 211, 24, 255, 22, 213, 233, 15, 132, 53, 182, 70, 168, 54, 179, 140, 18, 95, 113, 103, 191, 89, 154, 222, 17, 41, 123, 222, 89, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 227, 142, 227, 176, 41, 5, 212, 68, 69, 194, 228, 250, 96, 8, 109, 19, 31, 200, 199, 8, 118, 123, 50, 251, 59, 177, 147, 215, 183, 74, 184, 102, 128, 7, 53, 196, 222, 89, 2, 123, 64, 40, 205, 203, 181, 2, 81, 47, 28, 17, 242, 119, 180, 41, 254, 34, 181, 248, 4, 99, 194, 72, 76 }, new byte[] { 18, 221, 10, 13, 33, 88, 204, 127, 25, 222, 21, 62, 152, 225, 222, 107, 63, 253, 34, 177, 168, 238, 30, 160, 123, 127, 4, 130, 25, 141, 135, 238, 45, 136, 241, 225, 180, 193, 167, 102, 141, 108, 238, 152, 129, 26, 176, 94, 164, 184, 225, 163, 35, 24, 80, 107, 9, 154, 216, 32, 201, 155, 217, 52, 22, 206, 98, 123, 162, 244, 253, 252, 126, 124, 127, 114, 113, 108, 78, 255, 79, 51, 236, 120, 150, 156, 156, 173, 153, 197, 204, 16, 88, 213, 119, 248, 251, 157, 147, 28, 130, 7, 106, 225, 191, 125, 218, 56, 176, 44, 89, 82, 66, 97, 137, 130, 4, 101, 190, 15, 106, 96, 55, 199, 185, 156, 168, 240 } });
        }
    }
}
