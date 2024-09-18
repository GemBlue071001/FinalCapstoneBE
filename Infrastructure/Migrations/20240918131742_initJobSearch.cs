using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initJobSearch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessStream",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusinessStreamName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessStream", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    District = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostCode = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Shorthand = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SkillLevel = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CompanyDescription = table.Column<string>(type: "text", nullable: false),
                    WebsiteURL = table.Column<string>(type: "text", nullable: false),
                    EstablishedYear = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "integer", nullable: false),
                    BusinessStreamId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_BusinessStream_BusinessStreamId",
                        column: x => x.BusinessStreamId,
                        principalTable: "BusinessStream",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeekerProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CvPath = table.Column<string>(type: "text", nullable: false),
                    YearOfExperience = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<string>(type: "text", nullable: false),
                    LinkedInProfileURL = table.Column<string>(type: "text", nullable: false),
                    GitHubProfileURL = table.Column<string>(type: "text", nullable: false),
                    PortfolioURL = table.Column<string>(type: "text", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeekerProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeekerProfile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    JobDescription = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    EmploymentType = table.Column<string>(type: "text", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfVacancies = table.Column<int>(type: "integer", nullable: false),
                    ExperienceRequired = table.Column<int>(type: "integer", nullable: false),
                    QualificationRequired = table.Column<string>(type: "text", nullable: false),
                    Benefits = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    JobTypeId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    JobLocationId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPost_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPost_JobLocation_JobLocationId",
                        column: x => x.JobLocationId,
                        principalTable: "JobLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPost_JobType_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPost_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    InstitutionName = table.Column<string>(type: "text", nullable: false),
                    Degree = table.Column<string>(type: "text", nullable: false),
                    FieldOfStudy = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GPA = table.Column<decimal>(type: "numeric", nullable: false),
                    SeekerProfileId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetail_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Responsibilities = table.Column<string>(type: "text", nullable: false),
                    Achievements = table.Column<string>(type: "text", nullable: false),
                    SeekerProfileId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceDetail_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeekerSkillSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProficiencyLevel = table.Column<string>(type: "text", nullable: false),
                    SeekerProfileId = table.Column<int>(type: "integer", nullable: false),
                    SkillSetId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeekerSkillSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeekerSkillSet_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeekerSkillSet_SkillSet_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    JobPostId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostActivity_JobPost_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostActivity_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSkillSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillLevelRequired = table.Column<string>(type: "text", nullable: false),
                    SkillSetId = table.Column<int>(type: "integer", nullable: false),
                    JobPostId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSkillSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSkillSet_JobPost_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobSkillSet_SkillSet_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 18, 13, 17, 42, 213, DateTimeKind.Utc).AddTicks(4781), "HRAccount@gmail.com", null, false, "HRAccount", null, null, new byte[] { 229, 161, 2, 127, 217, 108, 217, 216, 48, 55, 41, 119, 249, 58, 87, 90, 97, 99, 221, 52, 154, 34, 1, 207, 32, 31, 98, 111, 196, 197, 104, 66, 186, 247, 93, 1, 214, 151, 137, 128, 222, 52, 225, 181, 245, 91, 68, 68, 103, 218, 234, 237, 94, 134, 62, 182, 148, 232, 215, 92, 243, 176, 48, 18 }, new byte[] { 242, 66, 74, 235, 107, 125, 4, 170, 205, 235, 115, 118, 228, 109, 44, 187, 171, 94, 239, 250, 147, 232, 199, 198, 253, 156, 138, 81, 100, 116, 254, 159, 171, 247, 218, 195, 230, 230, 144, 179, 152, 2, 237, 73, 23, 8, 41, 175, 36, 176, 241, 217, 235, 240, 251, 227, 130, 31, 47, 112, 100, 163, 153, 229, 93, 128, 181, 212, 92, 215, 84, 14, 88, 251, 39, 164, 248, 122, 114, 134, 41, 110, 220, 249, 98, 197, 1, 208, 226, 152, 11, 23, 192, 105, 146, 128, 80, 191, 199, 187, 176, 1, 38, 88, 112, 114, 126, 242, 75, 58, 172, 22, 254, 69, 246, 109, 165, 25, 131, 68, 147, 213, 252, 164, 17, 144, 58, 222 }, null, 3, "HRAccount" },
                    { 2, null, new DateTime(2024, 9, 18, 13, 17, 42, 213, DateTimeKind.Utc).AddTicks(4788), "ICAccountt@gmail.com", null, false, "ICAccount", null, null, new byte[] { 94, 251, 70, 6, 165, 89, 49, 117, 92, 21, 97, 231, 4, 214, 27, 148, 215, 149, 99, 130, 51, 210, 181, 143, 63, 221, 126, 28, 190, 150, 181, 121, 143, 28, 171, 247, 152, 2, 174, 133, 20, 193, 98, 29, 13, 205, 103, 251, 153, 90, 180, 63, 114, 213, 109, 103, 39, 67, 205, 216, 7, 145, 41, 233 }, new byte[] { 97, 198, 57, 15, 15, 199, 43, 82, 146, 239, 126, 26, 23, 255, 210, 208, 89, 172, 229, 206, 36, 43, 3, 225, 180, 135, 191, 2, 194, 166, 86, 253, 34, 34, 67, 4, 222, 170, 59, 116, 138, 202, 106, 178, 98, 117, 164, 93, 224, 113, 89, 185, 130, 162, 165, 248, 100, 95, 79, 217, 116, 95, 93, 158, 173, 111, 77, 251, 82, 45, 18, 209, 213, 75, 91, 109, 173, 174, 219, 185, 103, 188, 221, 182, 92, 242, 231, 225, 244, 185, 163, 190, 107, 238, 65, 253, 191, 227, 14, 127, 31, 107, 154, 98, 107, 229, 217, 207, 179, 33, 254, 241, 211, 227, 165, 41, 130, 111, 222, 183, 214, 6, 157, 16, 81, 162, 76, 197 }, null, 2, "ICAccount" },
                    { 3, null, new DateTime(2024, 9, 18, 13, 17, 42, 213, DateTimeKind.Utc).AddTicks(4790), "mentorAccount@gmail.com", null, false, "mentorAccount", null, null, new byte[] { 180, 24, 115, 65, 35, 77, 91, 116, 0, 57, 167, 180, 161, 19, 125, 57, 216, 5, 158, 209, 132, 232, 83, 64, 24, 216, 189, 18, 108, 175, 95, 245, 180, 64, 160, 150, 222, 63, 224, 210, 118, 150, 254, 65, 70, 83, 148, 124, 226, 161, 125, 135, 33, 100, 140, 236, 19, 13, 67, 145, 62, 136, 180, 200 }, new byte[] { 234, 32, 159, 164, 244, 142, 160, 160, 76, 90, 197, 8, 50, 245, 224, 70, 70, 166, 91, 233, 106, 112, 205, 204, 35, 227, 60, 161, 132, 90, 122, 115, 134, 16, 153, 192, 136, 234, 167, 115, 83, 64, 104, 92, 86, 220, 232, 82, 252, 35, 174, 161, 65, 215, 122, 217, 185, 1, 231, 24, 105, 118, 177, 100, 177, 75, 137, 124, 7, 158, 38, 194, 206, 254, 186, 185, 145, 149, 211, 125, 223, 245, 144, 139, 114, 210, 35, 224, 91, 54, 49, 237, 37, 164, 73, 166, 192, 248, 88, 90, 212, 2, 21, 117, 120, 132, 156, 154, 155, 241, 26, 187, 145, 139, 77, 40, 105, 190, 23, 87, 83, 168, 94, 40, 151, 120, 158, 194 }, null, 1, "mentorAccount" },
                    { 4, null, new DateTime(2024, 9, 18, 13, 17, 42, 213, DateTimeKind.Utc).AddTicks(4792), "InternAccount@gmail.com", null, false, "InternAccount", null, null, new byte[] { 142, 199, 160, 58, 46, 84, 93, 195, 238, 200, 54, 251, 36, 69, 224, 141, 161, 24, 87, 166, 33, 133, 82, 1, 180, 71, 106, 229, 70, 74, 124, 49, 249, 192, 249, 163, 77, 132, 199, 21, 9, 102, 6, 218, 11, 11, 50, 205, 115, 50, 17, 114, 138, 56, 97, 114, 246, 216, 17, 131, 26, 238, 35, 173 }, new byte[] { 39, 40, 94, 21, 90, 235, 173, 206, 90, 115, 46, 240, 23, 197, 31, 86, 101, 245, 234, 26, 5, 59, 151, 171, 9, 227, 206, 210, 115, 150, 147, 157, 139, 81, 213, 210, 161, 130, 27, 41, 79, 234, 209, 125, 125, 47, 129, 116, 238, 6, 72, 177, 107, 105, 22, 135, 37, 251, 45, 236, 15, 185, 2, 246, 80, 221, 84, 105, 204, 70, 69, 166, 32, 100, 207, 162, 156, 33, 234, 32, 70, 225, 152, 251, 239, 170, 203, 250, 217, 142, 113, 99, 11, 78, 72, 176, 7, 169, 41, 157, 65, 73, 194, 132, 51, 155, 105, 2, 66, 53, 92, 104, 173, 189, 65, 173, 116, 164, 102, 28, 145, 70, 71, 147, 69, 192, 117, 113 }, null, 0, "InternAccount" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_BusinessStreamId",
                table: "Company",
                column: "BusinessStreamId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_SeekerProfileId",
                table: "EducationDetail",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDetail_SeekerProfileId",
                table: "ExperienceDetail",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_CompanyId",
                table: "JobPost",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobLocationId",
                table: "JobPost",
                column: "JobLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_JobTypeId",
                table: "JobPost",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPost_UserId",
                table: "JobPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivity_JobPostId",
                table: "JobPostActivity",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivity_UserId",
                table: "JobPostActivity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkillSet_JobPostId",
                table: "JobSkillSet",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkillSet_SkillSetId",
                table: "JobSkillSet",
                column: "SkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerProfile_UserId",
                table: "SeekerProfile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSet_SeekerProfileId",
                table: "SeekerSkillSet",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSet_SkillSetId",
                table: "SeekerSkillSet",
                column: "SkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetail");

            migrationBuilder.DropTable(
                name: "ExperienceDetail");

            migrationBuilder.DropTable(
                name: "JobPostActivity");

            migrationBuilder.DropTable(
                name: "JobSkillSet");

            migrationBuilder.DropTable(
                name: "SeekerSkillSet");

            migrationBuilder.DropTable(
                name: "JobPost");

            migrationBuilder.DropTable(
                name: "SeekerProfile");

            migrationBuilder.DropTable(
                name: "SkillSet");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "JobLocation");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BusinessStream");
        }
    }
}
