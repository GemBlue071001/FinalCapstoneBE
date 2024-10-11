using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDataLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "SkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "SeekerSkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SeekerSkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobSkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobSkillSets",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "JobPosts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobPosts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "JobPosts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPosts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobPostActivities",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPostActivities",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplicationDate",
                table: "JobPostActivities",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobLocations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobLocations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ExperienceDetails",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ExperienceDetails",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "ExperienceDetails",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ExperienceDetails",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "EducationDetails",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "EducationDetails",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "EducationDetails",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EducationDetails",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Companys",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Companys",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BusinessStreams",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BusinessStreams",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "District", "PostCode" },
                values: new object[,]
                {
                    { 1, "HO CHI MINH", null, null },
                    { 2, "HA NOI", null, null },
                    { 3, "DA NANG", null, null },
                    { 4, "HAI PHONG", null, null },
                    { 5, "CAN THO", null, null },
                    { 6, "NHA TRANG", null, null }
                });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 15, 40, 23, 818, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4825), new byte[] { 42, 61, 140, 15, 8, 58, 168, 51, 118, 158, 169, 52, 149, 81, 119, 94, 80, 51, 118, 44, 191, 126, 41, 219, 124, 166, 91, 156, 42, 60, 151, 2, 36, 15, 114, 159, 67, 7, 159, 119, 155, 28, 219, 183, 137, 64, 22, 25, 53, 133, 176, 212, 33, 243, 148, 60, 99, 176, 254, 101, 94, 51, 236, 35 }, new byte[] { 215, 214, 47, 212, 170, 116, 69, 75, 93, 163, 22, 77, 45, 154, 159, 98, 252, 155, 29, 232, 63, 204, 144, 131, 207, 1, 253, 117, 83, 54, 128, 90, 6, 135, 137, 234, 95, 251, 83, 54, 146, 117, 48, 245, 39, 2, 195, 193, 4, 113, 224, 0, 227, 236, 25, 103, 123, 92, 210, 22, 214, 188, 198, 57, 222, 198, 117, 237, 64, 242, 252, 224, 120, 100, 73, 91, 143, 162, 227, 221, 67, 203, 59, 111, 255, 90, 202, 29, 95, 89, 74, 200, 252, 219, 61, 175, 15, 84, 87, 60, 49, 106, 214, 179, 28, 192, 190, 178, 250, 237, 77, 151, 82, 205, 105, 137, 143, 251, 71, 75, 163, 10, 209, 192, 100, 230, 30, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4831), new byte[] { 160, 82, 247, 140, 123, 245, 227, 28, 21, 239, 179, 255, 2, 82, 162, 254, 246, 102, 226, 196, 146, 51, 230, 54, 161, 165, 144, 165, 167, 101, 145, 183, 55, 68, 22, 72, 106, 122, 199, 18, 213, 144, 105, 176, 148, 5, 226, 106, 144, 156, 112, 88, 243, 128, 131, 145, 145, 102, 86, 153, 26, 209, 241, 85 }, new byte[] { 151, 243, 194, 84, 254, 97, 77, 29, 44, 174, 35, 119, 144, 104, 34, 73, 218, 184, 63, 237, 255, 76, 215, 101, 9, 48, 88, 253, 197, 123, 196, 195, 9, 174, 238, 251, 144, 104, 227, 129, 46, 206, 186, 69, 251, 192, 103, 130, 198, 67, 51, 148, 174, 143, 140, 168, 141, 95, 126, 160, 96, 250, 117, 55, 243, 250, 6, 27, 252, 145, 71, 134, 33, 16, 154, 232, 116, 177, 178, 174, 66, 180, 30, 0, 179, 183, 59, 251, 176, 107, 254, 243, 82, 150, 85, 199, 155, 85, 128, 231, 169, 12, 37, 72, 64, 116, 25, 216, 74, 161, 227, 31, 142, 182, 17, 187, 29, 234, 187, 129, 36, 252, 243, 195, 83, 197, 149, 87 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4834), new byte[] { 194, 5, 186, 228, 129, 69, 142, 2, 215, 153, 214, 190, 226, 116, 246, 56, 147, 37, 119, 57, 145, 250, 163, 153, 115, 192, 44, 171, 91, 9, 197, 72, 96, 239, 45, 224, 195, 141, 137, 22, 137, 242, 105, 227, 62, 182, 183, 44, 12, 164, 216, 247, 36, 154, 29, 35, 134, 177, 58, 154, 134, 254, 219, 92 }, new byte[] { 152, 11, 132, 165, 2, 56, 132, 147, 80, 250, 169, 195, 110, 137, 127, 235, 95, 226, 66, 71, 142, 218, 86, 134, 170, 253, 55, 166, 240, 117, 203, 1, 94, 158, 68, 192, 20, 101, 224, 186, 202, 77, 166, 186, 175, 140, 188, 132, 173, 150, 4, 232, 37, 202, 71, 119, 182, 55, 183, 244, 241, 233, 100, 13, 174, 151, 142, 50, 132, 168, 133, 154, 155, 108, 111, 138, 212, 103, 91, 207, 16, 219, 146, 59, 175, 224, 54, 10, 3, 22, 21, 212, 45, 85, 249, 103, 70, 160, 152, 102, 230, 144, 191, 131, 99, 2, 196, 17, 64, 20, 73, 153, 4, 85, 204, 152, 227, 225, 254, 170, 193, 214, 46, 161, 176, 129, 1, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 40, 23, 817, DateTimeKind.Utc).AddTicks(4836), new byte[] { 7, 210, 3, 216, 117, 119, 73, 138, 158, 97, 155, 89, 10, 137, 27, 104, 190, 71, 132, 233, 234, 54, 200, 70, 65, 194, 3, 136, 217, 223, 117, 140, 181, 129, 244, 244, 112, 170, 15, 234, 15, 150, 177, 131, 77, 94, 143, 78, 0, 37, 46, 56, 118, 146, 181, 247, 237, 28, 23, 149, 73, 190, 188, 88 }, new byte[] { 114, 105, 240, 32, 194, 51, 242, 48, 26, 96, 251, 242, 57, 183, 43, 66, 130, 243, 223, 147, 77, 109, 0, 63, 209, 9, 62, 180, 130, 93, 176, 93, 55, 145, 172, 3, 123, 98, 55, 51, 225, 173, 247, 186, 217, 184, 149, 5, 44, 106, 111, 94, 91, 125, 56, 175, 238, 152, 95, 175, 141, 80, 229, 40, 137, 216, 226, 68, 33, 96, 191, 162, 229, 126, 209, 126, 5, 3, 242, 219, 7, 147, 148, 239, 115, 239, 183, 77, 240, 58, 211, 68, 44, 237, 78, 117, 190, 251, 10, 243, 196, 148, 207, 243, 58, 174, 21, 17, 127, 245, 230, 81, 130, 145, 47, 220, 125, 44, 147, 3, 189, 121, 251, 164, 60, 28, 70, 38 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "SkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "SeekerSkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SeekerSkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobSkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobSkillSets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobPostActivities",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobPostActivities",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplicationDate",
                table: "JobPostActivities",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "JobLocations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "JobLocations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "ExperienceDetails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ExperienceDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "ExperienceDetails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ExperienceDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "EducationDetails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "EducationDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "EducationDetails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EducationDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Companys",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Companys",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "BusinessStreams",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BusinessStreams",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 8, 13, 27, 5, 510, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6109), new byte[] { 203, 63, 243, 219, 110, 252, 118, 100, 59, 177, 158, 247, 115, 151, 81, 165, 79, 22, 85, 16, 12, 79, 167, 184, 233, 95, 217, 220, 176, 31, 184, 35, 159, 205, 228, 117, 8, 234, 27, 30, 227, 152, 205, 24, 188, 181, 13, 195, 74, 169, 103, 78, 254, 103, 31, 202, 36, 65, 62, 104, 108, 249, 33, 109 }, new byte[] { 95, 125, 165, 155, 0, 1, 238, 42, 247, 41, 22, 112, 225, 27, 219, 179, 183, 21, 87, 111, 74, 204, 229, 124, 106, 211, 230, 114, 239, 107, 128, 147, 206, 38, 93, 174, 163, 249, 74, 233, 176, 146, 78, 215, 176, 157, 81, 16, 213, 17, 181, 61, 63, 103, 103, 105, 38, 10, 43, 144, 229, 5, 81, 245, 87, 0, 243, 182, 168, 0, 116, 72, 96, 96, 81, 154, 53, 15, 189, 137, 250, 208, 192, 24, 23, 250, 236, 134, 121, 116, 136, 10, 177, 171, 90, 213, 53, 118, 66, 97, 27, 26, 24, 60, 89, 144, 29, 119, 199, 221, 233, 33, 8, 31, 219, 71, 13, 37, 56, 124, 132, 68, 116, 230, 213, 95, 198, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6118), new byte[] { 3, 182, 221, 166, 220, 142, 178, 161, 120, 184, 161, 238, 130, 82, 104, 110, 11, 132, 46, 138, 246, 109, 166, 198, 3, 216, 244, 50, 252, 69, 179, 160, 133, 249, 2, 1, 166, 98, 34, 153, 174, 209, 58, 144, 110, 249, 1, 213, 193, 125, 203, 68, 38, 189, 165, 121, 84, 103, 58, 58, 231, 31, 214, 176 }, new byte[] { 145, 219, 117, 30, 98, 167, 191, 219, 190, 25, 111, 131, 241, 247, 215, 122, 140, 33, 211, 86, 29, 76, 206, 28, 169, 100, 197, 201, 5, 112, 206, 14, 77, 125, 10, 155, 61, 93, 169, 187, 6, 93, 185, 32, 185, 28, 211, 228, 82, 89, 227, 3, 232, 168, 179, 231, 178, 242, 31, 140, 52, 134, 207, 221, 179, 53, 88, 23, 50, 186, 8, 240, 169, 126, 191, 153, 242, 39, 127, 3, 75, 188, 45, 25, 221, 95, 177, 186, 26, 87, 178, 250, 89, 253, 220, 120, 166, 247, 195, 222, 191, 196, 50, 161, 37, 143, 109, 25, 42, 73, 110, 190, 91, 206, 50, 191, 197, 22, 51, 100, 119, 146, 97, 142, 61, 24, 137, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6120), new byte[] { 33, 228, 68, 102, 219, 185, 128, 158, 23, 99, 91, 185, 144, 77, 206, 3, 99, 9, 91, 67, 31, 227, 81, 138, 217, 137, 112, 18, 74, 250, 111, 175, 8, 105, 172, 253, 8, 130, 148, 173, 18, 105, 129, 233, 107, 52, 90, 229, 1, 79, 189, 233, 216, 73, 210, 66, 162, 195, 87, 222, 158, 42, 17, 177 }, new byte[] { 30, 203, 34, 106, 116, 113, 4, 193, 55, 71, 208, 152, 172, 250, 123, 163, 149, 97, 220, 120, 198, 97, 33, 72, 146, 72, 130, 159, 247, 11, 138, 178, 211, 221, 150, 67, 150, 9, 32, 46, 191, 26, 119, 207, 88, 242, 10, 252, 201, 34, 228, 184, 253, 151, 254, 142, 146, 69, 39, 8, 98, 85, 40, 245, 49, 35, 88, 65, 228, 145, 255, 77, 252, 16, 162, 177, 108, 247, 235, 40, 68, 161, 182, 169, 158, 168, 108, 3, 214, 15, 254, 172, 246, 102, 121, 221, 216, 194, 63, 148, 204, 156, 193, 223, 120, 62, 16, 111, 23, 134, 180, 27, 110, 234, 168, 50, 98, 153, 183, 42, 81, 239, 89, 60, 10, 149, 223, 249 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 27, 5, 509, DateTimeKind.Utc).AddTicks(6121), new byte[] { 140, 4, 28, 141, 124, 86, 123, 139, 22, 206, 121, 63, 66, 119, 19, 155, 28, 123, 244, 237, 62, 106, 134, 17, 16, 138, 7, 92, 129, 232, 163, 42, 5, 103, 185, 118, 212, 188, 135, 174, 93, 195, 83, 182, 176, 5, 67, 150, 4, 37, 211, 215, 95, 49, 218, 190, 94, 135, 50, 1, 137, 238, 19, 118 }, new byte[] { 219, 25, 57, 25, 69, 222, 193, 94, 132, 210, 36, 42, 66, 7, 77, 207, 159, 14, 8, 0, 21, 97, 100, 12, 49, 23, 205, 36, 56, 46, 34, 10, 131, 130, 38, 5, 36, 31, 156, 197, 170, 13, 79, 95, 54, 164, 48, 93, 78, 75, 161, 76, 95, 24, 203, 234, 171, 244, 4, 202, 80, 190, 202, 185, 9, 64, 25, 8, 29, 113, 127, 200, 41, 16, 176, 146, 62, 140, 233, 3, 125, 34, 253, 178, 191, 225, 139, 143, 177, 237, 9, 48, 153, 118, 154, 118, 138, 149, 194, 89, 5, 180, 36, 140, 11, 164, 110, 188, 106, 206, 195, 185, 127, 226, 99, 112, 107, 8, 205, 168, 233, 120, 57, 8, 216, 163, 224, 197 } });
        }
    }
}
