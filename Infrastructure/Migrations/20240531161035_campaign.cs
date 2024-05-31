using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class campaign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingProgramId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ScopeOfWork = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ScopeOfWork = table.Column<string>(type: "text", nullable: false),
                    Requirements = table.Column<string>(type: "text", nullable: false),
                    Benefits = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    TotalMember = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Education = table.Column<string>(type: "text", nullable: false),
                    CVPath = table.Column<string>(type: "text", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "TrainingProgramId", "UserName" },
                values: new object[,]
                {
                    { 1, null, null, "HRAccount@gmail.com", null, false, "HRAccount", null, null, new byte[] { 105, 215, 141, 246, 143, 177, 8, 132, 97, 35, 83, 161, 12, 114, 226, 157, 254, 121, 196, 143, 218, 74, 216, 121, 130, 60, 167, 64, 231, 198, 208, 252, 25, 104, 182, 85, 144, 36, 53, 248, 44, 54, 172, 5, 165, 144, 121, 19, 74, 5, 133, 23, 14, 180, 123, 212, 81, 157, 20, 164, 104, 255, 34, 100 }, new byte[] { 13, 109, 162, 195, 222, 109, 130, 99, 222, 196, 147, 138, 61, 101, 66, 19, 127, 229, 61, 16, 177, 17, 127, 110, 33, 119, 77, 186, 119, 250, 135, 39, 237, 11, 251, 152, 39, 101, 52, 83, 129, 144, 64, 120, 252, 120, 68, 27, 158, 54, 36, 79, 70, 139, 156, 45, 1, 137, 95, 109, 37, 128, 115, 11, 102, 154, 13, 26, 200, 119, 163, 56, 16, 155, 249, 236, 23, 146, 31, 158, 247, 190, 212, 225, 199, 246, 172, 158, 89, 214, 20, 208, 251, 255, 81, 45, 218, 14, 125, 19, 40, 216, 35, 84, 147, 204, 130, 220, 193, 158, 131, 96, 230, 69, 189, 190, 63, 116, 82, 165, 183, 119, 83, 114, 195, 211, 94, 7 }, null, 3, null, "HRAccount" },
                    { 2, null, null, "ICAccountt@gmail.com", null, false, "ICAccount", null, null, new byte[] { 30, 138, 103, 181, 107, 132, 151, 99, 211, 236, 66, 194, 128, 241, 65, 150, 31, 151, 244, 115, 224, 157, 186, 62, 122, 191, 150, 124, 196, 197, 96, 143, 228, 246, 80, 127, 126, 51, 156, 213, 181, 129, 188, 28, 252, 181, 12, 166, 116, 4, 103, 91, 77, 87, 198, 64, 156, 74, 213, 214, 57, 152, 12, 121 }, new byte[] { 74, 184, 155, 143, 179, 151, 28, 75, 242, 6, 42, 7, 102, 9, 203, 118, 132, 247, 139, 152, 25, 43, 4, 76, 124, 31, 228, 233, 112, 188, 251, 192, 230, 82, 156, 230, 167, 110, 172, 83, 43, 37, 25, 118, 233, 183, 135, 35, 87, 15, 103, 206, 176, 160, 7, 217, 225, 117, 67, 228, 221, 169, 183, 198, 224, 212, 87, 155, 29, 125, 223, 179, 210, 4, 173, 244, 136, 38, 187, 209, 122, 132, 237, 122, 24, 109, 178, 216, 77, 159, 67, 50, 36, 36, 219, 197, 191, 176, 37, 83, 144, 215, 233, 16, 232, 38, 33, 86, 130, 247, 230, 241, 96, 17, 19, 215, 151, 213, 169, 2, 244, 2, 236, 88, 55, 166, 186, 215 }, null, 2, null, "ICAccount" },
                    { 3, null, null, "mentorAccount@gmail.com", null, false, "mentorAccount", null, null, new byte[] { 209, 190, 248, 199, 244, 144, 164, 195, 187, 241, 103, 114, 124, 190, 162, 11, 121, 117, 11, 195, 52, 205, 175, 222, 83, 222, 164, 109, 124, 214, 139, 46, 81, 42, 253, 190, 223, 199, 45, 56, 139, 249, 24, 83, 94, 101, 131, 74, 237, 49, 10, 82, 61, 29, 62, 73, 45, 151, 194, 32, 201, 34, 194, 37 }, new byte[] { 158, 1, 198, 60, 81, 46, 149, 35, 25, 235, 180, 75, 146, 168, 207, 10, 145, 157, 211, 101, 251, 213, 65, 42, 90, 234, 52, 247, 78, 76, 44, 51, 29, 140, 125, 1, 178, 145, 178, 180, 140, 121, 27, 10, 123, 175, 233, 12, 217, 114, 232, 236, 144, 229, 195, 160, 126, 231, 119, 57, 160, 57, 143, 137, 192, 21, 71, 224, 67, 82, 128, 76, 5, 2, 11, 68, 55, 204, 169, 247, 82, 209, 79, 8, 169, 147, 217, 144, 147, 2, 212, 155, 50, 216, 165, 111, 182, 22, 103, 218, 109, 175, 54, 147, 82, 58, 129, 115, 197, 32, 127, 170, 226, 141, 212, 78, 117, 58, 6, 170, 140, 32, 129, 129, 162, 190, 6, 149 }, null, 1, null, "mentorAccount" },
                    { 4, null, null, "InternAccount@gmail.com", null, false, "InternAccount", null, null, new byte[] { 231, 89, 11, 6, 21, 190, 108, 76, 71, 180, 125, 145, 105, 173, 60, 190, 168, 108, 2, 150, 202, 35, 44, 137, 3, 65, 85, 67, 167, 240, 108, 41, 205, 234, 139, 85, 110, 110, 201, 133, 29, 124, 168, 147, 38, 52, 8, 204, 167, 129, 40, 117, 68, 40, 91, 172, 212, 93, 94, 49, 44, 146, 201, 190 }, new byte[] { 106, 253, 41, 87, 183, 56, 114, 164, 73, 231, 184, 162, 92, 51, 35, 156, 133, 242, 151, 81, 206, 73, 42, 39, 94, 244, 250, 59, 255, 200, 130, 125, 157, 164, 77, 96, 121, 195, 194, 99, 232, 57, 145, 210, 56, 10, 255, 210, 175, 202, 71, 91, 63, 158, 228, 186, 36, 200, 235, 254, 241, 139, 6, 255, 105, 242, 11, 38, 124, 121, 131, 221, 217, 225, 74, 233, 192, 205, 97, 31, 42, 206, 164, 234, 68, 87, 136, 73, 250, 51, 220, 147, 73, 213, 237, 209, 160, 109, 28, 23, 241, 17, 170, 65, 79, 46, 211, 181, 141, 175, 158, 133, 157, 230, 9, 195, 42, 100, 216, 230, 13, 48, 11, 217, 17, 47, 197, 242 }, null, 0, null, "InternAccount" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrainingProgramId",
                table: "Users",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTrainingPrograms_CampaignId",
                table: "CampaignTrainingPrograms",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTrainingPrograms_TrainingProgramId",
                table: "CampaignTrainingPrograms",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_TrainingProgramId",
                table: "Candidates",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TrainingPrograms_TrainingProgramId",
                table: "Users",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_TrainingPrograms_TrainingProgramId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CampaignTrainingPrograms");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_Users_TrainingProgramId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TrainingProgramId",
                table: "Users");
        }
    }
}
