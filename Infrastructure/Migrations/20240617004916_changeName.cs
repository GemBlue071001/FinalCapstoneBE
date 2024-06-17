using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingProgram_Jobs_JobId",
                table: "JobTrainingProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingProgram_TrainingProgram_TrainingProgramId",
                table: "JobTrainingProgram");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingProgram",
                table: "TrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTrainingProgram",
                table: "JobTrainingProgram");

            migrationBuilder.RenameTable(
                name: "TrainingProgram",
                newName: "TrainingPrograms");

            migrationBuilder.RenameTable(
                name: "JobTrainingProgram",
                newName: "JobTrainingPrograms");

            migrationBuilder.RenameIndex(
                name: "IX_JobTrainingProgram_TrainingProgramId",
                table: "JobTrainingPrograms",
                newName: "IX_JobTrainingPrograms_TrainingProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTrainingProgram_JobId",
                table: "JobTrainingPrograms",
                newName: "IX_JobTrainingPrograms_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingPrograms",
                table: "TrainingPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTrainingPrograms",
                table: "JobTrainingPrograms",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstimateTime = table.Column<int>(type: "integer", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActualTime = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_UserId",
                table: "Assessments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingPrograms",
                table: "TrainingPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTrainingPrograms",
                table: "JobTrainingPrograms");

            migrationBuilder.RenameTable(
                name: "TrainingPrograms",
                newName: "TrainingProgram");

            migrationBuilder.RenameTable(
                name: "JobTrainingPrograms",
                newName: "JobTrainingProgram");

            migrationBuilder.RenameIndex(
                name: "IX_JobTrainingPrograms_TrainingProgramId",
                table: "JobTrainingProgram",
                newName: "IX_JobTrainingProgram_TrainingProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTrainingPrograms_JobId",
                table: "JobTrainingProgram",
                newName: "IX_JobTrainingProgram_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingProgram",
                table: "TrainingProgram",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTrainingProgram",
                table: "JobTrainingProgram",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ActualTime = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstimateTime = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 229, 104, 183, 154, 203, 17, 220, 61, 86, 23, 103, 117, 119, 201, 245, 220, 139, 103, 171, 78, 100, 199, 31, 6, 253, 92, 10, 115, 79, 166, 25, 48, 220, 182, 207, 158, 10, 231, 244, 3, 246, 163, 119, 13, 34, 253, 237, 212, 76, 3, 27, 144, 116, 10, 68, 231, 73, 176, 9, 111, 63, 53, 207 }, new byte[] { 142, 165, 203, 252, 127, 185, 0, 143, 65, 80, 1, 108, 76, 138, 162, 19, 116, 134, 25, 50, 201, 60, 152, 172, 106, 199, 249, 16, 97, 238, 150, 168, 163, 17, 146, 186, 237, 167, 231, 233, 55, 139, 143, 176, 73, 10, 6, 7, 31, 250, 163, 79, 4, 68, 109, 115, 206, 69, 107, 171, 14, 139, 123, 165, 66, 113, 44, 129, 113, 210, 241, 147, 53, 85, 155, 250, 196, 178, 212, 147, 169, 164, 8, 3, 186, 69, 58, 11, 255, 249, 64, 161, 231, 149, 80, 171, 72, 116, 152, 181, 108, 191, 233, 44, 116, 146, 39, 126, 81, 11, 132, 142, 183, 117, 111, 15, 212, 93, 155, 73, 112, 28, 51, 142, 33, 90, 234, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 196, 230, 104, 2, 220, 162, 18, 193, 241, 110, 54, 0, 151, 155, 52, 79, 248, 39, 48, 123, 171, 37, 98, 241, 123, 222, 48, 71, 2, 151, 139, 73, 171, 215, 67, 185, 176, 187, 71, 49, 50, 217, 50, 116, 182, 243, 89, 173, 197, 43, 180, 54, 172, 56, 19, 25, 18, 46, 12, 155, 33, 178, 51, 10 }, new byte[] { 32, 119, 215, 96, 144, 32, 76, 75, 77, 162, 152, 197, 219, 62, 46, 94, 203, 213, 95, 189, 17, 7, 184, 117, 99, 231, 163, 191, 106, 62, 5, 137, 42, 87, 190, 46, 232, 249, 127, 26, 128, 109, 42, 128, 149, 240, 106, 249, 177, 115, 63, 33, 188, 148, 226, 10, 117, 132, 87, 119, 141, 120, 173, 11, 170, 235, 89, 138, 159, 198, 124, 90, 183, 36, 179, 47, 107, 17, 78, 55, 234, 17, 123, 43, 129, 51, 30, 231, 61, 86, 134, 160, 194, 182, 65, 7, 47, 219, 38, 174, 24, 237, 160, 224, 132, 143, 241, 106, 91, 197, 239, 216, 183, 90, 87, 4, 190, 188, 17, 26, 44, 147, 198, 197, 137, 19, 158, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 26, 46, 217, 126, 8, 83, 241, 145, 53, 155, 168, 14, 65, 19, 218, 18, 202, 227, 117, 189, 121, 69, 133, 104, 97, 208, 165, 80, 194, 94, 202, 132, 18, 90, 18, 198, 82, 140, 139, 21, 166, 61, 25, 53, 140, 52, 146, 31, 148, 46, 244, 108, 71, 2, 48, 12, 136, 207, 216, 59, 211, 207, 69 }, new byte[] { 48, 25, 45, 209, 29, 126, 151, 155, 37, 172, 179, 6, 153, 118, 183, 122, 205, 133, 2, 28, 252, 162, 183, 173, 216, 183, 219, 80, 244, 146, 17, 130, 80, 63, 196, 127, 78, 131, 167, 217, 21, 228, 196, 231, 127, 140, 243, 181, 124, 8, 80, 119, 115, 116, 188, 173, 97, 67, 211, 45, 37, 154, 194, 99, 89, 128, 228, 93, 9, 59, 212, 119, 211, 215, 82, 203, 173, 27, 42, 220, 172, 195, 88, 81, 119, 198, 128, 33, 245, 67, 81, 26, 31, 36, 58, 169, 2, 13, 52, 120, 176, 203, 248, 1, 66, 192, 211, 67, 164, 156, 118, 141, 109, 168, 73, 105, 172, 63, 247, 58, 62, 39, 93, 32, 248, 231, 181, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 91, 4, 189, 212, 244, 150, 190, 103, 168, 35, 51, 45, 81, 168, 106, 33, 16, 240, 251, 126, 121, 15, 138, 167, 223, 71, 233, 28, 170, 187, 136, 173, 101, 24, 151, 240, 20, 247, 175, 176, 43, 131, 18, 131, 158, 4, 34, 145, 164, 128, 190, 26, 130, 77, 174, 195, 45, 85, 192, 92, 126, 140, 81 }, new byte[] { 143, 220, 177, 58, 217, 155, 249, 190, 12, 66, 220, 27, 230, 92, 253, 141, 161, 147, 163, 26, 104, 87, 179, 218, 252, 151, 80, 212, 229, 168, 10, 130, 113, 157, 79, 95, 125, 55, 228, 36, 186, 57, 251, 15, 35, 172, 110, 119, 41, 82, 14, 152, 228, 232, 52, 60, 25, 56, 108, 160, 226, 103, 20, 103, 255, 145, 15, 37, 73, 138, 97, 50, 109, 67, 145, 234, 166, 189, 166, 80, 49, 145, 135, 9, 245, 76, 14, 170, 21, 77, 215, 70, 156, 171, 110, 100, 135, 49, 168, 186, 24, 7, 0, 211, 220, 255, 209, 108, 255, 132, 65, 242, 0, 45, 24, 13, 65, 105, 67, 151, 52, 137, 243, 42, 88, 9, 59, 219 } });

            migrationBuilder.CreateIndex(
                name: "IX_Task_UserId",
                table: "Task",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingProgram_Jobs_JobId",
                table: "JobTrainingProgram",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingProgram_TrainingProgram_TrainingProgramId",
                table: "JobTrainingProgram",
                column: "TrainingProgramId",
                principalTable: "TrainingProgram",
                principalColumn: "Id");
        }
    }
}
