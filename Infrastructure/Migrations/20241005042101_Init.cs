using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_Users_UserId",
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_EducationDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_ExperienceDetails_Users_UserId",
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
                    ImageURL = table.Column<string>(type: "text", nullable: true),
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    ReviewContent = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_SeekerSkillSets_SkillSets_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeekerSkillSets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    CvId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_JobPostActivitys_CVs_CvId",
                        column: x => x.CvId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { 1, "Tech", null, new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(138), "Tech Industry", false, null, null });

            migrationBuilder.InsertData(
                table: "JobLocations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedDate", "District", "IsDeleted", "ModifiedBy", "ModifiedDate", "PostCode", "State", "StressAddress" },
                values: new object[] { 1, "HCM", "VietNam", null, new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(6718), "District 9", false, null, null, "123", "state", "521 Le Van Si Stress" });

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
                    { 1, null, new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4319), "Business Analyst", false, null, null, "Business Analyst", "BA" },
                    { 2, null, new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4322), "C#", false, null, null, "C#", "C#" },
                    { 3, null, new DateTime(2024, 10, 5, 4, 21, 0, 780, DateTimeKind.Utc).AddTicks(4324), "Java Script", false, null, null, "Java Script", "JS" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "CreatedBy", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "PasswordHash", "PasswordSalt", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9468), "User1@gmail.com", null, false, "User1", null, null, new byte[] { 155, 111, 137, 104, 57, 200, 238, 140, 131, 187, 65, 239, 251, 20, 37, 23, 224, 43, 207, 49, 61, 44, 86, 218, 68, 202, 233, 193, 198, 90, 188, 21, 69, 15, 179, 136, 163, 17, 31, 172, 33, 187, 117, 4, 77, 18, 139, 104, 87, 111, 209, 234, 79, 124, 137, 39, 17, 112, 236, 232, 17, 24, 147, 112 }, new byte[] { 174, 71, 119, 29, 113, 0, 20, 32, 234, 158, 108, 50, 160, 110, 188, 65, 37, 150, 109, 165, 38, 45, 39, 249, 197, 251, 97, 169, 241, 161, 165, 34, 137, 214, 199, 82, 56, 134, 229, 197, 3, 132, 214, 202, 145, 138, 17, 223, 254, 101, 125, 180, 20, 118, 217, 62, 90, 239, 175, 87, 137, 172, 234, 96, 61, 210, 217, 24, 254, 54, 167, 7, 254, 40, 190, 144, 76, 143, 111, 232, 8, 156, 222, 231, 84, 169, 196, 158, 82, 52, 246, 198, 237, 72, 150, 118, 54, 48, 72, 241, 19, 3, 130, 50, 208, 34, 72, 120, 238, 74, 195, 42, 82, 233, 241, 82, 197, 161, 17, 178, 35, 36, 46, 173, 51, 206, 34, 48 }, null, 0, "User1" },
                    { 2, null, null, new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9475), "User2@gmail.com", null, false, "User2", null, null, new byte[] { 89, 0, 216, 233, 155, 23, 38, 158, 60, 18, 128, 34, 162, 104, 72, 240, 218, 129, 160, 156, 238, 58, 155, 7, 91, 88, 10, 135, 29, 238, 140, 98, 79, 127, 79, 127, 251, 171, 250, 54, 84, 237, 21, 157, 251, 104, 31, 160, 143, 121, 153, 137, 197, 107, 243, 232, 49, 57, 26, 51, 17, 14, 11, 10 }, new byte[] { 45, 187, 175, 246, 125, 46, 198, 31, 233, 174, 61, 194, 43, 70, 187, 83, 76, 167, 173, 29, 229, 154, 115, 251, 52, 162, 76, 239, 206, 111, 130, 226, 82, 51, 40, 89, 13, 124, 230, 44, 158, 197, 68, 219, 152, 176, 7, 8, 208, 221, 48, 217, 50, 214, 26, 11, 16, 237, 190, 96, 193, 39, 193, 22, 220, 35, 38, 122, 65, 36, 41, 63, 235, 188, 128, 90, 166, 22, 91, 134, 204, 206, 152, 97, 70, 252, 201, 41, 140, 187, 13, 31, 229, 148, 164, 193, 110, 207, 63, 233, 249, 59, 59, 229, 91, 106, 38, 130, 221, 76, 117, 119, 0, 255, 129, 33, 253, 130, 140, 203, 221, 139, 252, 202, 116, 77, 58, 162 }, null, 0, "User2" },
                    { 3, null, null, new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9477), "Employer@gmail.com", null, false, "Employer", null, null, new byte[] { 150, 159, 85, 69, 52, 213, 244, 252, 50, 66, 199, 68, 77, 133, 222, 98, 87, 88, 190, 244, 251, 42, 161, 85, 180, 48, 171, 201, 16, 77, 17, 114, 252, 53, 57, 77, 222, 8, 216, 145, 71, 87, 118, 67, 250, 115, 81, 247, 211, 65, 34, 242, 72, 79, 34, 216, 191, 182, 110, 214, 138, 90, 143, 61 }, new byte[] { 97, 166, 15, 161, 81, 30, 12, 231, 234, 125, 44, 192, 103, 64, 61, 183, 70, 142, 216, 212, 210, 45, 32, 186, 62, 206, 4, 11, 68, 113, 205, 68, 229, 27, 224, 193, 154, 107, 116, 194, 187, 101, 200, 246, 159, 34, 146, 245, 248, 108, 178, 59, 213, 205, 21, 225, 146, 7, 159, 108, 164, 93, 218, 25, 246, 207, 105, 193, 6, 49, 45, 143, 225, 46, 248, 213, 133, 100, 63, 25, 19, 230, 223, 11, 139, 214, 237, 87, 7, 58, 211, 42, 177, 3, 95, 81, 66, 95, 81, 145, 242, 196, 147, 115, 75, 229, 98, 24, 157, 145, 187, 128, 169, 239, 160, 153, 63, 180, 152, 168, 224, 135, 123, 153, 136, 222, 23, 182 }, null, 1, "Employer" },
                    { 4, null, null, new DateTime(2024, 10, 5, 4, 21, 0, 778, DateTimeKind.Utc).AddTicks(9479), "Admin@gmail.com", null, false, "Admin", null, null, new byte[] { 113, 66, 232, 24, 62, 208, 111, 32, 131, 155, 207, 10, 200, 162, 158, 176, 121, 115, 93, 12, 148, 244, 219, 47, 145, 59, 68, 155, 165, 40, 127, 12, 250, 167, 246, 72, 243, 141, 58, 67, 111, 64, 64, 109, 61, 191, 182, 22, 80, 6, 134, 113, 64, 42, 248, 79, 19, 171, 251, 165, 242, 141, 23, 84 }, new byte[] { 181, 218, 124, 85, 23, 196, 61, 138, 193, 195, 161, 53, 7, 63, 20, 175, 79, 222, 27, 119, 115, 195, 103, 118, 95, 208, 125, 235, 120, 79, 39, 155, 251, 241, 135, 8, 7, 138, 204, 100, 115, 3, 156, 50, 202, 126, 173, 146, 11, 133, 67, 212, 9, 209, 139, 114, 28, 136, 117, 95, 131, 112, 56, 155, 213, 156, 85, 84, 116, 108, 162, 159, 107, 105, 255, 98, 131, 250, 234, 50, 209, 251, 223, 91, 79, 117, 3, 48, 211, 54, 69, 192, 33, 66, 154, 51, 243, 249, 189, 211, 154, 62, 199, 34, 233, 184, 96, 111, 116, 40, 57, 175, 52, 140, 243, 48, 99, 111, 26, 27, 201, 23, 135, 3, 175, 181, 40, 22 }, null, 2, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "Id", "Address", "BusinessStreamId", "City", "CompanyDescription", "CompanyName", "Country", "CreatedBy", "CreatedDate", "EstablishedYear", "IsDeleted", "ModifiedBy", "ModifiedDate", "NumberOfEmployees", "WebsiteURL" },
                values: new object[,]
                {
                    { 1, "39 Vo Chi Cong Stress", 1, "HCM", "Tech Company", "Fpt Software", "VietNam", null, new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(2346), 2008, false, null, null, 1000, "https://fpt.com/vi" },
                    { 2, "64 Le Van Si Stress", 1, "HCM", "Tech Company", "High Tech", "VietNam", null, new DateTime(2024, 10, 5, 4, 21, 0, 779, DateTimeKind.Utc).AddTicks(2350), 2008, false, null, null, 50, "https://fpt.com/vi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companys_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_UserId",
                table: "CVs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetails_UserId",
                table: "EducationDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceDetails_UserId",
                table: "ExperienceDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostActivitys_CvId",
                table: "JobPostActivitys",
                column: "CvId");

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
                name: "IX_Reviews_CompanyId",
                table: "Reviews",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSets_SkillSetId",
                table: "SeekerSkillSets",
                column: "SkillSetId");

            migrationBuilder.CreateIndex(
                name: "IX_SeekerSkillSets_UserId",
                table: "SeekerSkillSets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");

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
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SeekerSkillSets");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "JobPosts");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.DropTable(
                name: "JobLocations");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "BusinessStreams");
        }
    }
}
