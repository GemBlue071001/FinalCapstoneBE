﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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

                    b.ToTable("JobTrainingProgram");
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

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OutputObject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TrainingProgram");
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
                            PasswordHash = new byte[] { 187, 150, 127, 112, 67, 84, 113, 65, 139, 54, 5, 137, 56, 163, 112, 57, 157, 17, 22, 123, 55, 128, 18, 66, 241, 52, 97, 111, 111, 166, 67, 193, 208, 135, 64, 77, 217, 90, 238, 247, 58, 188, 225, 23, 204, 172, 123, 5, 68, 208, 255, 51, 238, 147, 84, 177, 139, 241, 118, 89, 55, 13, 9, 83 },
                            PasswordSalt = new byte[] { 71, 228, 63, 100, 225, 156, 108, 96, 61, 230, 160, 62, 214, 184, 94, 58, 242, 9, 82, 69, 223, 215, 101, 38, 43, 113, 244, 96, 77, 43, 141, 4, 225, 143, 201, 170, 148, 198, 111, 162, 54, 13, 82, 56, 118, 39, 116, 190, 201, 33, 26, 217, 138, 26, 133, 153, 249, 208, 177, 215, 184, 81, 99, 16, 175, 193, 38, 144, 107, 34, 154, 33, 43, 7, 57, 58, 200, 238, 43, 151, 99, 226, 208, 49, 70, 39, 196, 78, 154, 89, 110, 87, 20, 252, 52, 149, 31, 189, 36, 223, 26, 54, 161, 33, 239, 54, 254, 217, 10, 25, 84, 161, 28, 59, 58, 186, 149, 213, 184, 237, 154, 205, 177, 223, 207, 167, 86, 100 },
                            Role = 3,
                            UserName = "HRAccount"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ICAccountt@gmail.com",
                            IsDeleted = false,
                            LastName = "ICAccount",
                            PasswordHash = new byte[] { 251, 12, 80, 254, 8, 118, 188, 120, 254, 210, 196, 9, 36, 68, 249, 155, 236, 219, 221, 51, 81, 28, 58, 97, 169, 30, 65, 77, 250, 159, 94, 160, 133, 187, 217, 102, 45, 22, 93, 46, 115, 59, 196, 236, 95, 104, 163, 85, 210, 243, 131, 31, 206, 129, 250, 137, 15, 86, 216, 33, 54, 62, 123, 202 },
                            PasswordSalt = new byte[] { 216, 108, 73, 175, 62, 70, 178, 245, 121, 62, 12, 246, 60, 15, 183, 223, 67, 4, 102, 81, 131, 37, 98, 7, 62, 51, 5, 40, 91, 211, 242, 27, 250, 211, 114, 12, 31, 105, 5, 226, 79, 95, 90, 52, 154, 45, 221, 108, 204, 79, 168, 88, 151, 68, 0, 35, 19, 184, 169, 155, 42, 62, 136, 123, 189, 4, 197, 93, 252, 175, 13, 183, 82, 31, 87, 204, 134, 213, 167, 86, 213, 187, 33, 68, 32, 50, 203, 90, 194, 58, 192, 232, 48, 89, 22, 235, 38, 77, 19, 159, 250, 76, 57, 49, 156, 84, 169, 213, 119, 157, 38, 252, 228, 93, 67, 75, 36, 9, 224, 231, 215, 34, 7, 135, 55, 230, 2, 175 },
                            Role = 2,
                            UserName = "ICAccount"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mentorAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "mentorAccount",
                            PasswordHash = new byte[] { 248, 125, 89, 181, 144, 17, 228, 10, 253, 45, 38, 161, 145, 247, 246, 98, 201, 99, 209, 157, 128, 39, 25, 161, 7, 101, 226, 44, 108, 178, 175, 242, 194, 28, 55, 166, 45, 23, 147, 147, 4, 208, 246, 75, 162, 118, 152, 170, 70, 154, 47, 130, 45, 13, 110, 24, 134, 137, 18, 61, 15, 129, 145, 28 },
                            PasswordSalt = new byte[] { 166, 247, 162, 49, 144, 218, 202, 12, 242, 202, 159, 15, 237, 251, 202, 133, 181, 79, 34, 103, 240, 23, 85, 134, 16, 162, 222, 188, 219, 94, 254, 15, 22, 193, 77, 15, 141, 52, 87, 61, 78, 84, 136, 253, 47, 172, 160, 173, 130, 224, 231, 102, 32, 139, 195, 203, 3, 58, 80, 102, 15, 94, 253, 209, 13, 177, 168, 213, 5, 56, 112, 105, 122, 119, 186, 140, 65, 75, 70, 208, 169, 37, 160, 72, 72, 200, 124, 246, 183, 122, 241, 9, 181, 14, 146, 76, 81, 213, 120, 49, 48, 213, 220, 251, 147, 228, 88, 164, 202, 155, 183, 220, 172, 107, 0, 237, 35, 105, 224, 200, 94, 153, 211, 213, 180, 238, 29, 137 },
                            Role = 1,
                            UserName = "mentorAccount"
                        },
                        new
                        {
                            Id = 4,
                            Email = "InternAccount@gmail.com",
                            IsDeleted = false,
                            LastName = "InternAccount",
                            PasswordHash = new byte[] { 88, 214, 3, 64, 230, 220, 253, 50, 60, 42, 30, 116, 1, 98, 132, 132, 148, 109, 0, 86, 222, 42, 188, 40, 139, 128, 10, 241, 243, 134, 201, 85, 184, 46, 140, 100, 17, 188, 223, 129, 226, 222, 178, 210, 207, 24, 249, 120, 123, 39, 112, 128, 244, 79, 7, 45, 198, 187, 129, 144, 164, 206, 71, 7 },
                            PasswordSalt = new byte[] { 175, 91, 247, 61, 224, 148, 49, 54, 188, 210, 36, 233, 207, 138, 88, 206, 121, 191, 84, 165, 255, 67, 245, 91, 132, 189, 98, 161, 18, 111, 232, 54, 174, 125, 122, 127, 10, 108, 233, 19, 138, 18, 240, 113, 156, 222, 112, 244, 43, 152, 128, 89, 242, 243, 94, 198, 158, 238, 28, 87, 28, 65, 177, 179, 154, 236, 123, 121, 159, 74, 236, 239, 250, 114, 40, 211, 75, 166, 199, 10, 14, 153, 214, 97, 169, 95, 14, 185, 234, 76, 37, 114, 66, 198, 175, 80, 126, 193, 165, 244, 86, 254, 180, 89, 133, 144, 198, 212, 83, 19, 165, 74, 36, 89, 131, 253, 19, 6, 12, 18, 237, 115, 243, 73, 237, 188, 41, 41 },
                            Role = 0,
                            UserName = "InternAccount"
                        });
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
                        .HasForeignKey("CampaignJobId");

                    b.Navigation("CampaignJob");
                });

            modelBuilder.Entity("Domain.Entities.JobTrainingProgram", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("JobId");

                    b.HasOne("Domain.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("JobTrainingPrograms")
                        .HasForeignKey("TrainingProgramId");

                    b.Navigation("Job");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Entities.UserAccount", b =>
                {
                    b.HasOne("Domain.Entities.CampaignJob", "CampaignJob")
                        .WithMany("Interns")
                        .HasForeignKey("CampaignJobId");

                    b.Navigation("CampaignJob");
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

            modelBuilder.Entity("Domain.Entities.TrainingProgram", b =>
                {
                    b.Navigation("JobTrainingPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
