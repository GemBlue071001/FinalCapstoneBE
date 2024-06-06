using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_TrainingPrograms_TrainingProgramId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_TrainingPrograms_TrainingProgramId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CampaignTrainingPrograms");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.RenameColumn(
                name: "TrainingProgramId",
                table: "Users",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TrainingProgramId",
                table: "Users",
                newName: "IX_Users_JobId");

            migrationBuilder.RenameColumn(
                name: "TrainingProgramId",
                table: "Candidates",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidates_TrainingProgramId",
                table: "Candidates",
                newName: "IX_Candidates_JobId");

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ScopeOfWork = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    Benefits = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    TotalMember = table.Column<int>(type: "integer", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CampaignId = table.Column<int>(type: "integer", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignJobs_Campaigns_JobId",
                        column: x => x.JobId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 57, 37, 224, 106, 194, 81, 96, 129, 179, 195, 202, 11, 97, 32, 7, 72, 27, 225, 229, 154, 90, 9, 110, 20, 229, 227, 123, 105, 163, 103, 56, 70, 138, 87, 8, 156, 226, 156, 11, 127, 4, 30, 231, 1, 122, 12, 158, 143, 156, 221, 53, 32, 247, 166, 78, 99, 56, 193, 147, 211, 109, 20, 28, 126 }, new byte[] { 12, 205, 109, 62, 66, 61, 59, 147, 100, 30, 225, 59, 200, 145, 78, 107, 35, 101, 81, 96, 176, 23, 144, 88, 36, 201, 8, 195, 86, 56, 117, 61, 107, 206, 122, 165, 216, 246, 107, 12, 53, 59, 154, 224, 130, 91, 239, 254, 181, 142, 116, 17, 82, 71, 156, 10, 247, 87, 226, 135, 120, 162, 173, 92, 31, 80, 115, 136, 169, 59, 62, 12, 31, 223, 150, 122, 159, 222, 100, 89, 51, 1, 87, 105, 68, 89, 127, 121, 23, 255, 226, 178, 249, 111, 122, 44, 30, 166, 63, 140, 207, 104, 85, 67, 94, 20, 202, 244, 219, 222, 138, 194, 61, 235, 67, 78, 114, 81, 32, 143, 99, 14, 105, 116, 149, 14, 182, 69 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 21, 120, 182, 16, 208, 86, 73, 31, 188, 5, 147, 202, 130, 157, 50, 26, 143, 177, 100, 11, 198, 241, 16, 123, 12, 181, 219, 193, 138, 234, 128, 51, 186, 202, 143, 98, 1, 179, 133, 141, 8, 8, 59, 215, 30, 225, 223, 8, 169, 189, 237, 170, 100, 242, 244, 218, 202, 55, 254, 107, 181, 228, 83 }, new byte[] { 164, 62, 15, 16, 78, 135, 211, 42, 29, 2, 254, 210, 154, 98, 207, 104, 231, 233, 41, 149, 79, 185, 13, 228, 79, 61, 250, 46, 116, 37, 77, 8, 56, 150, 169, 215, 88, 11, 181, 200, 192, 15, 236, 116, 61, 36, 84, 147, 232, 44, 154, 85, 157, 38, 204, 6, 168, 97, 232, 26, 36, 99, 110, 66, 210, 199, 219, 101, 212, 237, 72, 198, 67, 222, 124, 96, 104, 6, 166, 242, 44, 42, 121, 181, 68, 1, 3, 49, 246, 38, 194, 58, 17, 165, 64, 53, 65, 48, 82, 104, 194, 194, 76, 243, 195, 132, 220, 119, 37, 25, 190, 145, 218, 102, 184, 26, 45, 78, 87, 169, 63, 135, 109, 228, 249, 40, 163, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 195, 191, 172, 160, 175, 33, 60, 129, 28, 177, 166, 18, 63, 212, 199, 112, 43, 191, 121, 172, 233, 132, 10, 209, 149, 118, 46, 116, 229, 120, 35, 55, 37, 173, 254, 179, 89, 1, 39, 24, 38, 252, 144, 22, 0, 67, 98, 215, 68, 149, 169, 164, 171, 28, 248, 13, 191, 29, 232, 144, 8, 56, 254 }, new byte[] { 61, 235, 70, 13, 180, 241, 128, 54, 172, 220, 58, 123, 212, 66, 192, 225, 202, 238, 80, 232, 1, 175, 193, 63, 192, 239, 219, 101, 248, 229, 216, 47, 189, 189, 111, 249, 182, 114, 155, 242, 2, 137, 1, 121, 134, 67, 115, 97, 35, 229, 199, 13, 94, 58, 197, 24, 139, 48, 38, 6, 174, 112, 88, 215, 66, 158, 69, 134, 223, 212, 241, 171, 175, 180, 159, 78, 24, 202, 185, 124, 206, 41, 206, 52, 45, 18, 50, 47, 29, 109, 18, 200, 253, 237, 119, 157, 98, 233, 81, 217, 169, 113, 153, 10, 196, 134, 216, 173, 98, 199, 200, 2, 33, 46, 79, 111, 214, 1, 94, 5, 54, 87, 157, 102, 151, 34, 105, 140 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 69, 104, 255, 99, 188, 186, 161, 34, 231, 118, 49, 210, 114, 201, 67, 21, 141, 227, 79, 212, 187, 25, 14, 87, 69, 65, 56, 185, 151, 37, 48, 67, 8, 76, 221, 79, 100, 8, 120, 111, 248, 233, 91, 176, 71, 197, 67, 104, 162, 133, 103, 96, 56, 81, 79, 18, 172, 218, 68, 39, 86, 113, 147 }, new byte[] { 210, 145, 106, 109, 139, 96, 67, 51, 112, 142, 141, 202, 105, 11, 72, 171, 155, 1, 66, 83, 62, 159, 86, 253, 113, 24, 121, 173, 175, 156, 188, 53, 51, 89, 16, 221, 96, 47, 239, 85, 35, 94, 223, 4, 121, 101, 75, 191, 1, 83, 83, 201, 156, 202, 88, 206, 116, 186, 33, 12, 161, 197, 138, 79, 91, 214, 233, 241, 88, 250, 204, 197, 93, 221, 146, 183, 178, 41, 17, 215, 17, 250, 168, 106, 127, 55, 23, 124, 67, 139, 56, 25, 219, 1, 50, 128, 111, 152, 200, 236, 30, 64, 146, 28, 222, 240, 251, 17, 247, 53, 155, 215, 43, 57, 147, 250, 78, 203, 170, 254, 234, 166, 247, 75, 13, 189, 175, 67 } });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignJobs_JobId",
                table: "CampaignJobs",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Jobs_JobId",
                table: "Candidates",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Jobs_JobId",
                table: "Users",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Jobs_JobId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Jobs_JobId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CampaignJobs");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Users",
                newName: "TrainingProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_JobId",
                table: "Users",
                newName: "IX_Users_TrainingProgramId");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Candidates",
                newName: "TrainingProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_Candidates_JobId",
                table: "Candidates",
                newName: "IX_Candidates_TrainingProgramId");

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Benefits = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    ScopeOfWork = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TotalMember = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignTrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CampaignId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignTrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignTrainingPrograms_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignTrainingPrograms_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 164, 171, 15, 171, 219, 120, 216, 196, 128, 41, 86, 103, 246, 192, 184, 65, 133, 171, 188, 217, 56, 110, 149, 196, 98, 71, 148, 7, 253, 248, 208, 248, 204, 21, 141, 225, 41, 75, 131, 191, 119, 24, 16, 56, 80, 96, 145, 41, 127, 90, 191, 131, 244, 242, 243, 111, 91, 168, 129, 158, 1, 206, 37 }, new byte[] { 154, 16, 47, 172, 193, 45, 243, 127, 178, 191, 192, 60, 23, 218, 255, 18, 36, 160, 85, 249, 195, 15, 254, 147, 242, 27, 45, 72, 209, 184, 144, 105, 128, 5, 113, 84, 12, 7, 42, 11, 195, 79, 216, 134, 119, 22, 252, 155, 79, 15, 201, 120, 195, 171, 156, 200, 113, 74, 18, 92, 251, 1, 83, 163, 23, 49, 126, 215, 199, 204, 101, 241, 232, 32, 229, 24, 105, 49, 214, 232, 131, 37, 23, 95, 129, 62, 139, 118, 44, 180, 154, 43, 133, 217, 76, 84, 52, 216, 94, 43, 29, 199, 118, 195, 72, 7, 214, 207, 50, 182, 133, 165, 156, 145, 103, 147, 85, 222, 210, 116, 63, 27, 77, 55, 34, 219, 214, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 158, 227, 79, 68, 196, 94, 229, 245, 6, 167, 117, 1, 210, 235, 219, 96, 74, 148, 75, 7, 1, 208, 114, 144, 212, 78, 126, 151, 13, 83, 83, 191, 91, 197, 170, 81, 40, 42, 136, 161, 146, 63, 18, 147, 102, 99, 102, 85, 136, 211, 240, 87, 45, 193, 247, 229, 1, 216, 87, 86, 225, 112, 168 }, new byte[] { 227, 77, 37, 236, 110, 84, 211, 115, 161, 255, 137, 161, 56, 96, 37, 45, 173, 50, 2, 18, 126, 81, 5, 2, 65, 124, 72, 112, 143, 210, 122, 63, 246, 92, 219, 183, 116, 1, 214, 7, 22, 125, 40, 230, 14, 178, 66, 157, 171, 80, 7, 81, 171, 24, 55, 134, 166, 190, 78, 54, 189, 37, 157, 205, 155, 189, 157, 148, 177, 183, 254, 194, 111, 156, 48, 35, 224, 222, 74, 129, 76, 173, 227, 131, 105, 121, 45, 58, 191, 152, 7, 110, 253, 112, 179, 124, 244, 35, 147, 232, 142, 203, 204, 88, 41, 36, 97, 240, 70, 171, 100, 221, 224, 5, 245, 234, 161, 53, 250, 227, 1, 248, 47, 245, 235, 162, 104, 86 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 109, 169, 197, 21, 242, 91, 201, 188, 174, 10, 168, 224, 234, 132, 107, 111, 18, 179, 12, 217, 116, 116, 183, 92, 107, 252, 196, 35, 41, 209, 39, 167, 72, 16, 126, 239, 84, 255, 76, 175, 160, 243, 3, 56, 87, 54, 220, 73, 62, 50, 117, 83, 210, 85, 48, 178, 231, 99, 248, 85, 177, 228, 131 }, new byte[] { 134, 54, 197, 75, 183, 159, 21, 94, 217, 88, 155, 111, 237, 188, 25, 110, 73, 149, 112, 126, 119, 0, 244, 100, 137, 69, 11, 190, 90, 186, 102, 243, 5, 125, 83, 93, 228, 203, 95, 18, 229, 225, 65, 254, 253, 245, 218, 62, 98, 220, 149, 5, 115, 7, 49, 181, 250, 62, 6, 13, 178, 129, 59, 187, 235, 144, 42, 65, 94, 130, 33, 37, 73, 68, 177, 164, 44, 74, 51, 2, 154, 141, 70, 8, 50, 38, 51, 235, 102, 102, 43, 59, 56, 197, 139, 84, 157, 46, 58, 41, 231, 160, 54, 61, 173, 53, 57, 86, 33, 103, 117, 129, 57, 151, 195, 233, 159, 229, 56, 74, 16, 83, 118, 255, 62, 206, 14, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 99, 69, 134, 19, 12, 154, 4, 24, 160, 62, 72, 203, 220, 153, 188, 190, 156, 79, 210, 61, 219, 232, 204, 71, 15, 32, 195, 106, 186, 164, 190, 252, 231, 142, 136, 221, 167, 109, 249, 142, 159, 252, 197, 209, 188, 103, 43, 230, 234, 187, 64, 229, 131, 93, 31, 18, 58, 7, 10, 32, 220, 191, 221 }, new byte[] { 133, 227, 90, 198, 89, 90, 126, 53, 54, 146, 252, 237, 39, 223, 193, 70, 61, 123, 173, 9, 241, 195, 82, 65, 115, 229, 108, 104, 91, 255, 15, 86, 230, 151, 208, 200, 118, 123, 36, 158, 226, 247, 237, 78, 209, 49, 115, 239, 0, 252, 211, 156, 173, 225, 124, 16, 108, 22, 145, 251, 73, 11, 70, 142, 0, 11, 153, 233, 75, 85, 205, 24, 87, 43, 114, 70, 179, 112, 187, 31, 175, 218, 156, 172, 143, 81, 115, 2, 216, 165, 24, 81, 203, 212, 253, 151, 245, 153, 64, 89, 235, 134, 81, 111, 245, 176, 35, 26, 38, 228, 171, 27, 63, 210, 106, 165, 218, 60, 120, 190, 125, 91, 166, 58, 17, 105, 31, 157 } });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTrainingPrograms_CampaignId",
                table: "CampaignTrainingPrograms",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTrainingPrograms_TrainingProgramId",
                table: "CampaignTrainingPrograms",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_TrainingPrograms_TrainingProgramId",
                table: "Candidates",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TrainingPrograms_TrainingProgramId",
                table: "Users",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id");
        }
    }
}
