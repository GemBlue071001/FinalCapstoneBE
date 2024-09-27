using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessStreams",
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
                    table.PrimaryKey("PK_BusinessStreams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobLocations",
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
                    table.PrimaryKey("PK_JobLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
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
                    table.PrimaryKey("PK_SkillSets", x => x.Id);
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
                name: "Companys",
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
                    table.PrimaryKey("PK_Companys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companys_BusinessStreams_BusinessStreamId",
                        column: x => x.BusinessStreamId,
                        principalTable: "BusinessStreams",
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
                name: "JobPosts",
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
                    QualificationRequired = table.Column<string>(type: "text", nullable: true),
                    SkillLevelRequired = table.Column<int>(type: "integer", nullable: false),
                    Benefits = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_JobPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPosts_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosts_JobLocations_JobLocationId",
                        column: x => x.JobLocationId,
                        principalTable: "JobLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosts_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetails",
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
                    table.PrimaryKey("PK_EducationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetails_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceDetails",
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
                    table.PrimaryKey("PK_ExperienceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceDetails_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeekerSkillSets",
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
                    table.PrimaryKey("PK_SeekerSkillSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeekerSkillSets_SeekerProfile_SeekerProfileId",
                        column: x => x.SeekerProfileId,
                        principalTable: "SeekerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostActivitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_JobPostActivitys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostActivitys_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostActivitys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSkillSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    table.PrimaryKey("PK_JobSkillSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSkillSets_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobSkillSets_SkillSets_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BusinessStreams",
                columns: new[] { "Id", "BusinessStreamName", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 1, "Tech", null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(2975), "Tech Industry", false, null, null });

            migrationBuilder.InsertData(
                table: "JobLocations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedDate", "District", "IsDeleted", "ModifiedBy", "ModifiedDate", "PostCode", "State", "StressAddress" },
                values: new object[] { 1, "HCM", "VietNam", null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(8273), "District 9", false, null, null, "123", "state", "521 Le Van Si Stress" });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A Full Time Job", "Full Time" },
                    { 2, "A Part Time Job", "Part Time" },
                    { 3, "A Remote Job", "Remote" }
                });

            migrationBuilder.InsertData(
                table: "SkillSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Shorthand" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2267), "Business Analyst", false, null, null, "Business Analyst", "BA" },
                    { 2, null, new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2272), "C#", false, null, null, "C#", "C#" },
                    { 3, null, new DateTime(2024, 9, 27, 3, 13, 11, 153, DateTimeKind.Utc).AddTicks(2273), "Java Script", false, null, null, "Java Script", "JS" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1009), "User1@gmail.com", null, false, "User1", null, null, new byte[] { 245, 244, 88, 216, 128, 168, 67, 109, 115, 185, 77, 168, 90, 152, 245, 112, 152, 111, 93, 144, 100, 89, 20, 34, 196, 221, 40, 229, 146, 80, 40, 31, 148, 197, 90, 221, 198, 138, 219, 211, 41, 85, 129, 239, 41, 131, 101, 28, 50, 194, 108, 207, 0, 155, 121, 236, 85, 68, 29, 155, 189, 184, 70, 149 }, new byte[] { 88, 181, 240, 125, 222, 105, 135, 143, 18, 99, 153, 69, 96, 236, 109, 91, 212, 21, 147, 17, 144, 120, 160, 33, 129, 168, 222, 122, 135, 67, 161, 244, 42, 32, 217, 207, 135, 245, 124, 159, 233, 169, 131, 13, 230, 187, 187, 170, 240, 168, 142, 152, 253, 173, 68, 100, 69, 148, 195, 64, 22, 126, 239, 36, 151, 24, 72, 24, 50, 100, 176, 154, 53, 128, 20, 88, 42, 244, 61, 95, 236, 250, 143, 229, 72, 8, 149, 38, 98, 76, 181, 52, 75, 121, 92, 118, 48, 225, 42, 175, 250, 36, 161, 96, 103, 224, 94, 103, 188, 78, 194, 220, 133, 88, 223, 38, 119, 157, 236, 127, 160, 132, 214, 141, 239, 74, 101, 125 }, null, 0, "User1" },
                    { 2, null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1016), "User2@gmail.com", null, false, "User2", null, null, new byte[] { 152, 86, 161, 191, 139, 67, 100, 42, 66, 73, 49, 131, 26, 166, 128, 127, 164, 105, 56, 229, 157, 232, 230, 186, 92, 137, 93, 204, 234, 66, 224, 90, 244, 18, 88, 90, 144, 22, 76, 142, 7, 93, 164, 46, 1, 233, 82, 178, 0, 197, 55, 137, 108, 153, 45, 123, 169, 125, 34, 149, 8, 253, 3, 154 }, new byte[] { 148, 72, 25, 253, 61, 210, 207, 50, 39, 63, 64, 213, 32, 159, 159, 101, 151, 242, 130, 167, 226, 5, 113, 197, 150, 58, 53, 112, 71, 135, 68, 92, 252, 228, 168, 236, 169, 135, 226, 183, 130, 134, 94, 41, 227, 224, 12, 79, 79, 52, 28, 84, 153, 147, 102, 220, 93, 40, 97, 231, 168, 22, 162, 48, 230, 51, 33, 79, 241, 33, 25, 71, 232, 90, 235, 141, 205, 199, 43, 37, 181, 48, 157, 87, 164, 252, 186, 216, 242, 61, 38, 239, 21, 6, 71, 12, 144, 6, 172, 203, 143, 69, 16, 3, 158, 254, 71, 216, 125, 119, 72, 118, 113, 75, 142, 164, 43, 198, 12, 96, 5, 149, 7, 1, 250, 105, 108, 204 }, null, 0, "User2" },
                    { 3, null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1018), "Employer@gmail.com", null, false, "Employer", null, null, new byte[] { 47, 1, 209, 182, 181, 13, 63, 33, 129, 14, 51, 0, 152, 91, 205, 134, 11, 184, 53, 133, 247, 0, 160, 8, 142, 145, 159, 217, 240, 73, 20, 111, 11, 165, 132, 253, 46, 197, 73, 118, 68, 49, 145, 213, 135, 181, 249, 24, 72, 140, 179, 240, 182, 91, 141, 71, 72, 188, 64, 220, 205, 35, 127, 230 }, new byte[] { 96, 205, 204, 32, 142, 239, 33, 95, 214, 135, 234, 215, 162, 209, 74, 234, 36, 190, 216, 117, 88, 173, 148, 182, 12, 123, 238, 240, 179, 71, 111, 120, 247, 68, 157, 153, 81, 93, 243, 155, 157, 29, 166, 203, 198, 102, 101, 191, 26, 16, 147, 241, 156, 103, 168, 178, 41, 107, 74, 244, 96, 164, 112, 191, 227, 249, 19, 86, 61, 222, 144, 182, 188, 46, 130, 54, 72, 154, 31, 34, 43, 29, 198, 154, 132, 2, 35, 197, 72, 220, 182, 121, 49, 147, 172, 177, 71, 194, 45, 199, 234, 76, 14, 246, 121, 193, 156, 195, 203, 179, 50, 26, 57, 186, 92, 230, 26, 160, 121, 48, 106, 74, 103, 136, 175, 100, 195, 155 }, null, 1, "Employer" },
                    { 4, null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(1019), "Admin@gmail.com", null, false, "Admin", null, null, new byte[] { 87, 75, 202, 33, 77, 77, 168, 32, 154, 77, 225, 88, 232, 167, 187, 8, 34, 33, 152, 236, 94, 107, 99, 151, 209, 159, 63, 66, 245, 154, 66, 44, 194, 116, 172, 7, 222, 240, 67, 30, 42, 75, 237, 217, 35, 238, 57, 2, 41, 198, 2, 186, 69, 9, 16, 3, 62, 177, 234, 104, 145, 162, 55, 20 }, new byte[] { 47, 95, 90, 137, 243, 145, 199, 206, 93, 179, 201, 137, 29, 188, 193, 60, 39, 83, 109, 38, 243, 136, 0, 162, 73, 39, 100, 252, 29, 55, 240, 69, 123, 197, 244, 80, 205, 113, 200, 239, 79, 164, 143, 85, 154, 45, 127, 213, 194, 176, 102, 197, 192, 168, 232, 165, 175, 148, 255, 208, 141, 181, 92, 129, 236, 65, 225, 151, 147, 169, 167, 222, 87, 102, 199, 57, 99, 186, 187, 6, 247, 249, 211, 254, 222, 65, 87, 185, 100, 216, 132, 12, 98, 9, 10, 246, 238, 15, 239, 213, 74, 134, 111, 107, 132, 22, 170, 247, 203, 129, 92, 157, 12, 175, 248, 232, 7, 13, 15, 51, 123, 221, 223, 57, 240, 140, 174, 19 }, null, 2, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "Address", "BusinessStreamId", "City", "CompanyDescription", "CompanyName", "Country", "CreatedBy", "CreatedDate", "EstablishedYear", "IsDeleted", "ModifiedBy", "ModifiedDate", "NumberOfEmployees", "WebsiteURL" },
                values: new object[,]
                {
                    { 1, "39 Vo Chi Cong Stress", 1, "HCM", "Tech Company", "Fpt Software", "VietNam", null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(4543), 2008, false, null, null, 1000, "https://fpt.com/vi" },
                    { 2, "64 Le Van Si Stress", 1, "HCM", "Tech Company", "High Tech", "VietNam", null, new DateTime(2024, 9, 27, 3, 13, 11, 151, DateTimeKind.Utc).AddTicks(4548), 2008, false, null, null, 50, "https://fpt.com/vi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companys_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetails_SeekerProfileId",
                table: "EducationDetails",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDetails_SeekerProfileId",
                table: "ExperienceDetails",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivitys_JobPostId",
                table: "JobPostActivitys",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivitys_UserId",
                table: "JobPostActivitys",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobLocationId",
                table: "JobPosts",
                column: "JobLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobTypeId",
                table: "JobPosts",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_UserId",
                table: "JobPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkillSets_JobPostId",
                table: "JobSkillSets",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkillSets_SkillSetId",
                table: "JobSkillSets",
                column: "SkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerProfile_UserId",
                table: "SeekerProfile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSets_SeekerProfileId",
                table: "SeekerSkillSets",
                column: "SeekerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSets_SkillSetId",
                table: "SeekerSkillSets",
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
                name: "EducationDetails");

            migrationBuilder.DropTable(
                name: "ExperienceDetails");

            migrationBuilder.DropTable(
                name: "JobPostActivitys");

            migrationBuilder.DropTable(
                name: "JobSkillSets");

            migrationBuilder.DropTable(
                name: "SeekerSkillSets");

            migrationBuilder.DropTable(
                name: "JobPosts");

            migrationBuilder.DropTable(
                name: "SeekerProfile");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "JobLocations");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BusinessStreams");
        }
    }
}
