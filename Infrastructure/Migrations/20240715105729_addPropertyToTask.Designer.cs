﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240715105729_addPropertyToTask")]
    partial class addPropertyToTask
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ActualTime")
                        .HasColumnType("integer");

                    b.Property<int>("AssessmentStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EstimateTime")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Benefits")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EstimateEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EstimateStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.Property<string>("ScopeOfWork")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CampaignId")
                        .HasColumnType("integer");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("JobId");

                    b.ToTable("CampaignJobs");
                });

            modelBuilder.Entity("Domain.Entities.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CVPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CampaignJobId")
                        .HasColumnType("integer");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CampaignJobId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Benefits")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.Property<string>("ScopeOfWork")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TotalMember")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Domain.Entities.JobTrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("JobId")
                        .HasColumnType("integer");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("JobTrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.KPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("KPI");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Minutes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Domain.Entities.ProgramKPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KPIId")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("KPIId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("ProgramKPI");
                });

            modelBuilder.Entity("Domain.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseObject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OutputObject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgramResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResourceId")
                        .HasColumnType("integer");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingProgramResource");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CampaignJobId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CampaignJobId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "HRAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "HRAccount",
                            PasswordHash = new byte[] { 51, 28, 64, 229, 251, 77, 186, 144, 21, 180, 1, 120, 233, 36, 241, 215, 246, 96, 36, 199, 80, 11, 29, 6, 202, 32, 120, 135, 181, 55, 17, 87, 108, 92, 140, 211, 50, 116, 200, 240, 1, 195, 131, 235, 102, 177, 75, 169, 93, 218, 190, 88, 96, 54, 232, 167, 167, 182, 50, 140, 63, 142, 218, 146 },
                            PasswordSalt = new byte[] { 207, 111, 107, 130, 122, 143, 66, 201, 220, 113, 214, 249, 18, 137, 40, 58, 176, 50, 166, 171, 95, 60, 111, 31, 138, 243, 15, 196, 172, 253, 123, 188, 96, 193, 147, 220, 187, 106, 36, 238, 36, 252, 1, 111, 120, 107, 236, 48, 126, 161, 46, 122, 128, 226, 170, 167, 185, 166, 154, 13, 254, 105, 49, 134, 57, 112, 142, 135, 245, 70, 111, 206, 49, 150, 56, 69, 66, 169, 160, 199, 183, 97, 155, 14, 228, 93, 218, 37, 176, 103, 209, 49, 229, 59, 89, 195, 160, 217, 8, 154, 24, 5, 23, 168, 176, 39, 199, 52, 119, 76, 45, 221, 42, 231, 69, 4, 248, 83, 111, 28, 252, 42, 126, 168, 16, 242, 111, 241 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 207, 179, 157, 6, 107, 230, 94, 236, 99, 159, 208, 101, 115, 51, 105, 197, 164, 250, 94, 130, 220, 64, 144, 38, 148, 131, 226, 250, 225, 198, 50, 179, 78, 19, 50, 124, 194, 65, 40, 71, 193, 121, 217, 144, 84, 253, 154, 112, 216, 135, 34, 205, 164, 197, 190, 87, 146, 144, 223, 181, 36, 216, 108, 232 },
                            PasswordSalt = new byte[] { 45, 184, 27, 90, 251, 146, 52, 53, 204, 192, 215, 39, 15, 172, 37, 162, 120, 201, 240, 8, 236, 219, 64, 229, 83, 236, 161, 83, 141, 239, 82, 192, 133, 166, 127, 228, 177, 38, 230, 194, 226, 217, 22, 144, 141, 32, 131, 25, 53, 180, 120, 113, 124, 130, 41, 83, 103, 36, 3, 249, 255, 96, 105, 171, 20, 173, 20, 149, 44, 244, 152, 19, 73, 251, 242, 145, 214, 140, 61, 25, 149, 116, 167, 26, 182, 82, 152, 120, 167, 70, 58, 105, 239, 164, 224, 14, 230, 250, 106, 119, 89, 190, 225, 204, 43, 168, 207, 220, 137, 205, 251, 110, 213, 241, 218, 141, 0, 109, 65, 26, 45, 34, 44, 82, 175, 117, 28, 236 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 200, 102, 128, 187, 41, 104, 232, 142, 21, 219, 0, 88, 219, 147, 51, 89, 167, 178, 89, 44, 23, 255, 35, 18, 252, 26, 161, 134, 100, 80, 42, 205, 64, 46, 217, 41, 56, 46, 4, 29, 231, 136, 200, 172, 150, 123, 112, 72, 169, 61, 89, 37, 63, 37, 233, 20, 179, 37, 66, 194, 113, 220, 204, 201 },
                            PasswordSalt = new byte[] { 108, 80, 69, 147, 250, 79, 228, 93, 112, 129, 17, 150, 103, 93, 219, 218, 165, 157, 24, 248, 82, 105, 112, 173, 82, 180, 48, 139, 238, 37, 250, 135, 168, 255, 51, 167, 155, 138, 205, 206, 26, 94, 165, 71, 125, 255, 235, 122, 165, 251, 164, 158, 58, 98, 109, 227, 213, 230, 11, 23, 157, 165, 189, 210, 16, 62, 69, 224, 5, 171, 22, 138, 138, 211, 125, 23, 180, 0, 255, 211, 178, 36, 67, 180, 10, 54, 177, 212, 118, 218, 110, 245, 70, 82, 170, 191, 227, 118, 132, 218, 25, 109, 29, 146, 153, 82, 36, 85, 168, 177, 140, 166, 205, 211, 92, 65, 4, 11, 184, 11, 62, 61, 63, 34, 38, 201, 206, 53 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 138, 147, 219, 252, 163, 95, 102, 96, 124, 187, 231, 121, 241, 179, 132, 246, 210, 41, 31, 159, 96, 173, 61, 207, 163, 164, 212, 157, 130, 42, 68, 177, 26, 142, 122, 72, 143, 171, 33, 100, 160, 86, 211, 17, 3, 139, 88, 202, 206, 191, 244, 0, 131, 129, 58, 94, 79, 63, 131, 111, 178, 167, 242, 199 },
                            PasswordSalt = new byte[] { 104, 77, 202, 251, 96, 82, 148, 225, 177, 184, 119, 31, 135, 81, 245, 4, 133, 66, 6, 149, 35, 60, 99, 159, 3, 232, 218, 194, 241, 141, 247, 189, 187, 49, 236, 99, 103, 85, 191, 88, 156, 80, 245, 191, 70, 201, 232, 195, 202, 104, 118, 64, 69, 155, 192, 240, 31, 0, 228, 2, 154, 11, 215, 204, 224, 111, 25, 25, 42, 176, 61, 48, 205, 247, 179, 171, 219, 143, 194, 90, 171, 15, 171, 120, 144, 122, 61, 120, 114, 8, 124, 199, 90, 160, 169, 29, 250, 214, 72, 137, 110, 100, 61, 56, 58, 205, 183, 35, 232, 1, 56, 40, 233, 52, 82, 12, 4, 77, 195, 146, 92, 239, 21, 231, 111, 207, 105, 189 },
                            Role = 0,
                            UserName = "InternAccount"
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserMeeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MeetingId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMeeting");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProgramId")
                        .HasColumnType("integer");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserResultDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserResultId")
                        .HasColumnType("integer");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserResultId");

                    b.ToTable("UserResultDetail");
                });

            modelBuilder.Entity("Domain.Entities.Assessment", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Assessments")
                        .HasForeignKey("TrainingProgramId");

                    b.HasOne("Domain.Entities.UserAccount", "Owner")
                        .WithMany("Assessments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.HasOne("Domain.Entities.Campaign", "Campaign")
                        .WithMany("CampaignJobs")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("CampaignJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.Candidate", b =>
                {
                    b.HasOne("Domain.Entities.CampaignJob", "CampaignJob")
                        .WithMany("Candidates")
                        .HasForeignKey("CampaignJobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("CampaignJob");
                });

            modelBuilder.Entity("Domain.Entities.JobTrainingProgram", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Job");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.ProgramKPI", b =>
                {
                    b.HasOne("Domain.Entities.KPI", "KPI")
                        .WithMany("ProgramKPI")
                        .HasForeignKey("KPIId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("ProgramKPI")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KPI");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgramResource", b =>
                {
                    b.HasOne("Domain.Entities.Resource", "Resource")
                        .WithMany("TrainingProgramResources")
                        .HasForeignKey("ResourceId");

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("TrainingProgramResources")
                        .HasForeignKey("TrainingProgramId");

                    b.Navigation("Resource");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.HasOne("Domain.Entities.CampaignJob", "CampaignJob")
                        .WithMany("Interns")
                        .HasForeignKey("CampaignJobId");

                    b.Navigation("CampaignJob");
                });

            modelBuilder.Entity("Domain.Entities.UserMeeting", b =>
                {
                    b.HasOne("Domain.Entities.Meeting", "Meeting")
                        .WithMany("UserMeetings")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserAccount", "User")
                        .WithMany("UserMeetings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.HasOne("Domain.Entities.TrainingProgram", "Program")
                        .WithMany("UserResults")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserAccount", "User")
                        .WithMany("UserResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserResultDetail", b =>
                {
                    b.HasOne("Domain.Entities.UserResult", "UserResult")
                        .WithMany("UserResultDetails")
                        .HasForeignKey("UserResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserResult");
                });

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Navigation("CampaignJobs");
                });

            modelBuilder.Entity("Domain.Entities.CampaignJob", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Interns");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Navigation("CampaignJobs");

                    b.Navigation("JobTrainingPrograms");
                });

            modelBuilder.Entity("Domain.Entities.KPI", b =>
                {
                    b.Navigation("ProgramKPI");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Navigation("UserMeetings");
                });

            modelBuilder.Entity("Domain.Entities.Resource", b =>
                {
                    b.Navigation("TrainingProgramResources");
                });

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("JobTrainingPrograms");

                    b.Navigation("ProgramKPI");

                    b.Navigation("TrainingProgramResources");

                    b.Navigation("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("UserMeetings");

                    b.Navigation("UserResults");
                });

            modelBuilder.Entity("Domain.Entities.UserResult", b =>
                {
                    b.Navigation("UserResultDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
