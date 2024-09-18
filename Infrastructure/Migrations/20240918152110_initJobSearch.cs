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
                    StressAddress = table.Column<string>(type: "text", nullable: false),
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
                    PostingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                table: "BusinessStream",
                columns: new[] { "Id", "BusinessStreamName", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 1, "Tech", null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8043), "Tech Industry", false, null, null });

            migrationBuilder.InsertData(
                table: "JobLocation",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedDate", "District", "IsDeleted", "ModifiedBy", "ModifiedDate", "PostCode", "State", "StressAddress" },
                values: new object[] { 1, "HCM", "VietNam", null, new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(56), "District 9", false, null, null, "123", "state", "521 Le Van Si Stress" });

            migrationBuilder.InsertData(
                table: "JobType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A Full Time Job", "Full Time" },
                    { 2, "A Part Time Job", "Part Time" },
                    { 3, "A Remote Job", "Remote" }
                });

            migrationBuilder.InsertData(
                table: "SkillSet",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Shorthand" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4435), "Business Analyst", false, null, null, "Business Analyst", "BA" },
                    { 2, null, new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4437), "C#", false, null, null, "C#", "C#" },
                    { 3, null, new DateTime(2024, 9, 18, 15, 21, 10, 511, DateTimeKind.Utc).AddTicks(4438), "Java Script", false, null, null, "Java Script", "JS" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7340), "User1@gmail.com", null, false, "User1", null, null, new byte[] { 40, 25, 11, 158, 14, 229, 189, 72, 125, 215, 47, 98, 78, 177, 89, 179, 212, 171, 112, 195, 176, 241, 52, 118, 92, 126, 124, 57, 255, 88, 7, 89, 211, 52, 33, 45, 83, 35, 125, 229, 9, 12, 204, 102, 137, 241, 174, 204, 105, 196, 225, 178, 162, 197, 130, 169, 116, 61, 222, 189, 56, 32, 95, 14 }, new byte[] { 64, 145, 179, 171, 40, 48, 187, 242, 106, 215, 149, 38, 115, 73, 56, 139, 208, 176, 250, 231, 224, 251, 92, 114, 134, 73, 173, 14, 255, 204, 199, 227, 51, 114, 198, 220, 60, 215, 31, 104, 190, 6, 139, 184, 61, 137, 241, 87, 135, 104, 224, 1, 193, 5, 92, 93, 88, 225, 23, 100, 248, 148, 185, 135, 195, 91, 209, 156, 126, 202, 103, 68, 119, 142, 92, 143, 231, 215, 226, 72, 171, 19, 174, 67, 162, 103, 112, 76, 68, 103, 243, 136, 154, 226, 75, 179, 203, 159, 28, 165, 193, 56, 95, 188, 3, 229, 26, 204, 113, 237, 170, 208, 194, 235, 17, 46, 70, 158, 137, 152, 127, 111, 213, 119, 125, 58, 93, 235 }, null, 0, "User1" },
                    { 2, null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7348), "User2@gmail.com", null, false, "User2", null, null, new byte[] { 132, 233, 3, 199, 193, 117, 153, 111, 135, 182, 255, 34, 219, 182, 63, 98, 49, 93, 134, 18, 14, 42, 204, 11, 93, 190, 62, 192, 59, 221, 187, 200, 59, 163, 186, 50, 187, 71, 148, 87, 17, 57, 68, 108, 198, 227, 24, 4, 173, 252, 20, 117, 135, 100, 148, 250, 52, 87, 219, 196, 204, 64, 235, 48 }, new byte[] { 186, 241, 53, 150, 165, 22, 103, 142, 171, 198, 44, 242, 74, 231, 139, 210, 30, 108, 40, 141, 54, 56, 150, 251, 44, 213, 164, 55, 219, 26, 182, 10, 6, 39, 222, 60, 80, 17, 91, 93, 238, 13, 220, 175, 145, 142, 125, 32, 37, 210, 168, 22, 138, 40, 147, 171, 213, 252, 208, 63, 142, 72, 76, 159, 184, 151, 42, 239, 147, 130, 196, 160, 253, 204, 226, 13, 210, 153, 61, 46, 41, 110, 101, 170, 62, 74, 84, 123, 225, 245, 68, 120, 150, 192, 206, 75, 203, 191, 133, 37, 239, 138, 131, 60, 22, 188, 166, 43, 224, 65, 105, 105, 223, 91, 1, 162, 27, 88, 227, 85, 94, 179, 101, 164, 87, 156, 188, 201 }, null, 0, "User2" },
                    { 3, null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7354), "Employer@gmail.com", null, false, "Employer", null, null, new byte[] { 46, 167, 49, 167, 85, 82, 225, 67, 246, 130, 75, 251, 134, 64, 117, 217, 88, 33, 161, 117, 151, 123, 217, 156, 151, 171, 251, 83, 193, 251, 211, 235, 202, 160, 105, 163, 82, 76, 14, 155, 51, 26, 202, 11, 146, 103, 175, 250, 246, 27, 119, 14, 47, 110, 128, 127, 128, 211, 161, 156, 150, 5, 205, 196 }, new byte[] { 191, 242, 228, 243, 252, 66, 123, 108, 204, 113, 58, 25, 73, 147, 158, 202, 211, 97, 72, 108, 231, 25, 240, 131, 84, 77, 98, 69, 169, 227, 203, 108, 145, 50, 71, 71, 233, 62, 55, 187, 193, 169, 127, 11, 60, 238, 83, 82, 4, 46, 78, 206, 18, 232, 182, 88, 212, 39, 238, 79, 159, 222, 183, 226, 0, 55, 41, 12, 15, 227, 111, 100, 249, 108, 66, 38, 124, 91, 88, 6, 69, 143, 164, 41, 234, 255, 96, 148, 26, 3, 29, 79, 220, 37, 197, 195, 208, 159, 228, 64, 190, 33, 254, 180, 201, 142, 103, 184, 137, 233, 63, 56, 121, 181, 209, 90, 166, 33, 64, 198, 8, 69, 235, 98, 56, 215, 160, 132 }, null, 1, "Employer" },
                    { 4, null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(7355), "Admin@gmail.com", null, false, "Admin", null, null, new byte[] { 47, 170, 247, 52, 94, 85, 23, 80, 201, 83, 7, 218, 128, 255, 143, 134, 72, 135, 87, 201, 116, 64, 151, 40, 159, 40, 71, 254, 156, 205, 133, 76, 204, 231, 191, 6, 3, 144, 64, 114, 202, 239, 18, 233, 71, 246, 91, 211, 153, 140, 64, 127, 153, 77, 103, 108, 159, 183, 225, 39, 108, 30, 190, 109 }, new byte[] { 41, 178, 235, 170, 158, 117, 159, 217, 13, 46, 223, 46, 145, 229, 169, 198, 70, 206, 113, 181, 20, 139, 132, 157, 91, 128, 71, 57, 68, 232, 220, 158, 94, 111, 22, 54, 151, 177, 157, 15, 160, 171, 115, 30, 242, 235, 10, 118, 126, 239, 92, 117, 204, 25, 71, 248, 46, 232, 185, 139, 209, 230, 169, 133, 113, 147, 145, 61, 178, 216, 148, 39, 157, 95, 163, 41, 240, 48, 126, 70, 212, 32, 169, 247, 62, 34, 91, 146, 101, 20, 163, 75, 156, 167, 4, 27, 105, 186, 175, 129, 152, 156, 255, 106, 2, 206, 95, 189, 212, 238, 201, 71, 0, 148, 61, 252, 182, 209, 5, 138, 153, 144, 91, 16, 117, 1, 100, 144 }, null, 2, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "BusinessStreamId", "City", "CompanyDescription", "CompanyName", "Country", "CreatedBy", "CreatedDate", "EstablishedYear", "IsDeleted", "ModifiedBy", "ModifiedDate", "NumberOfEmployees", "WebsiteURL" },
                values: new object[,]
                {
                    { 1, "39 Vo Chi Cong Stress", 1, "HCM", "Tech Company", "Fpt Software", "VietNam", null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8716), 2008, false, null, null, 1000, "https://fpt.com/vi" },
                    { 2, "64 Le Van Si Stress", 1, "HCM", "Tech Company", "High Tech", "VietNam", null, new DateTime(2024, 9, 18, 15, 21, 10, 510, DateTimeKind.Utc).AddTicks(8720), 2008, false, null, null, 50, "https://fpt.com/vi" }
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
