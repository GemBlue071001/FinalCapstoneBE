using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedDataForSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.InsertData(
                table: "SkillSets",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Shorthand" },
                values: new object[,]
                {
                    { 200, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(869), null, false, null, null, "Angular", null },
                    { 201, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(870), null, false, null, null, "AWS", null },
                    { 202, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(871), null, false, null, null, "Bridge Engineer", null },
                    { 203, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(872), null, false, null, null, "C++", null },
                    { 204, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(872), null, false, null, null, "CSS", null },
                    { 205, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(873), null, false, null, null, "Kotlin", null },
                    { 206, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(903), null, false, null, null, "Magento", null },
                    { 207, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(904), null, false, null, null, "MySQL", null },
                    { 208, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(905), null, false, null, null, "NextJS", null },
                    { 209, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(906), null, false, null, null, "OOP", null },
                    { 210, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(907), null, false, null, null, "PQA", null },
                    { 211, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(908), null, false, null, null, "ReactJS", null },
                    { 212, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(908), null, false, null, null, "Solution Architect", null },
                    { 213, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(909), null, false, null, null, "Security", null },
                    { 214, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(910), null, false, null, null, "TypeScript", null },
                    { 215, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(911), null, false, null, null, "Agile", null },
                    { 216, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(912), null, false, null, null, "ASP.NET", null },
                    { 217, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(912), null, false, null, null, "Big Data", null },
                    { 218, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(913), null, false, null, null, "Cloud", null },
                    { 219, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(914), null, false, null, null, "Data Analyst", null },
                    { 220, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(915), null, false, null, null, "DevSecOps", null },
                    { 221, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(915), null, false, null, null, "HTML5", null },
                    { 222, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(916), null, false, null, null, "JQuery", null },
                    { 223, null, new DateTime(2024, 11, 17, 8, 26, 56, 632, DateTimeKind.Utc).AddTicks(917), null, false, null, null, "SQL", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2708), new byte[] { 168, 29, 188, 175, 204, 125, 133, 99, 77, 195, 49, 34, 23, 113, 30, 206, 77, 22, 19, 58, 233, 32, 143, 148, 23, 160, 254, 126, 167, 34, 137, 114, 78, 31, 10, 185, 133, 190, 3, 236, 147, 220, 221, 246, 63, 252, 181, 57, 42, 233, 40, 204, 248, 127, 60, 74, 118, 199, 200, 244, 188, 33, 212, 93 }, new byte[] { 127, 92, 215, 207, 127, 138, 140, 151, 78, 97, 240, 175, 237, 64, 174, 21, 248, 77, 117, 175, 78, 24, 241, 160, 203, 10, 113, 130, 178, 130, 128, 149, 26, 111, 165, 21, 129, 133, 197, 95, 140, 183, 52, 208, 34, 99, 147, 174, 209, 197, 193, 42, 141, 79, 253, 94, 105, 1, 143, 177, 148, 137, 54, 246, 41, 15, 108, 223, 229, 67, 253, 54, 20, 196, 74, 77, 233, 69, 237, 237, 166, 157, 148, 119, 151, 119, 28, 143, 205, 150, 83, 209, 89, 207, 26, 142, 138, 11, 22, 127, 40, 219, 121, 14, 114, 196, 36, 200, 182, 227, 13, 201, 132, 246, 211, 192, 33, 255, 213, 101, 172, 181, 12, 165, 183, 243, 232, 136 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2717), new byte[] { 34, 43, 253, 47, 111, 25, 189, 70, 15, 36, 156, 4, 151, 211, 101, 111, 68, 136, 1, 123, 122, 158, 57, 97, 181, 81, 113, 0, 230, 162, 206, 161, 80, 50, 207, 55, 57, 233, 218, 91, 214, 112, 57, 153, 195, 212, 40, 13, 132, 225, 163, 88, 47, 220, 106, 243, 175, 154, 247, 106, 35, 209, 172, 220 }, new byte[] { 8, 42, 122, 102, 146, 15, 11, 245, 99, 9, 160, 202, 234, 21, 82, 205, 211, 58, 64, 59, 82, 85, 84, 2, 197, 228, 96, 119, 1, 58, 166, 64, 196, 93, 0, 69, 77, 191, 20, 164, 193, 178, 104, 174, 162, 97, 207, 164, 70, 207, 52, 46, 100, 89, 247, 120, 41, 227, 216, 44, 197, 110, 116, 13, 93, 56, 198, 227, 190, 49, 183, 234, 138, 157, 115, 195, 99, 110, 233, 53, 100, 147, 219, 47, 6, 166, 25, 232, 161, 205, 222, 206, 19, 59, 122, 77, 107, 54, 130, 203, 21, 50, 172, 17, 175, 181, 70, 231, 160, 61, 3, 20, 138, 111, 245, 130, 8, 33, 231, 75, 35, 239, 168, 178, 214, 96, 216, 242 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2719), new byte[] { 26, 7, 247, 197, 252, 96, 95, 216, 90, 191, 48, 230, 139, 241, 110, 13, 253, 32, 217, 37, 37, 160, 152, 152, 132, 105, 190, 222, 202, 23, 41, 178, 134, 248, 205, 210, 187, 219, 227, 86, 22, 165, 68, 137, 212, 176, 38, 20, 206, 199, 55, 96, 13, 130, 146, 193, 9, 201, 218, 188, 45, 216, 190, 42 }, new byte[] { 18, 19, 129, 167, 2, 253, 92, 35, 239, 26, 220, 156, 117, 47, 43, 242, 117, 58, 160, 143, 114, 252, 241, 138, 233, 7, 112, 112, 100, 50, 36, 130, 112, 202, 55, 83, 241, 135, 168, 36, 92, 219, 184, 60, 116, 121, 172, 96, 240, 168, 223, 140, 136, 255, 179, 146, 207, 25, 142, 152, 173, 61, 217, 126, 255, 212, 148, 238, 130, 240, 220, 189, 117, 182, 139, 66, 100, 4, 222, 215, 17, 140, 223, 190, 85, 105, 218, 28, 142, 134, 98, 188, 173, 117, 158, 174, 226, 252, 109, 49, 42, 254, 41, 248, 118, 229, 73, 45, 122, 78, 43, 215, 232, 185, 241, 178, 187, 168, 67, 101, 110, 203, 226, 183, 149, 169, 251, 110 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 26, 56, 630, DateTimeKind.Utc).AddTicks(2721), new byte[] { 239, 226, 184, 224, 221, 11, 205, 245, 99, 249, 20, 242, 195, 233, 28, 114, 47, 144, 234, 185, 44, 237, 45, 183, 103, 228, 213, 90, 92, 163, 177, 142, 133, 243, 116, 226, 121, 221, 41, 150, 64, 179, 63, 122, 221, 174, 52, 63, 63, 53, 117, 205, 175, 179, 180, 50, 28, 168, 251, 243, 153, 146, 44, 191 }, new byte[] { 249, 181, 21, 232, 189, 86, 27, 36, 41, 238, 82, 32, 103, 224, 187, 44, 117, 60, 144, 127, 74, 159, 242, 76, 178, 226, 154, 127, 236, 91, 55, 95, 240, 199, 244, 115, 250, 185, 204, 42, 140, 141, 246, 217, 123, 48, 53, 197, 49, 149, 215, 45, 147, 92, 88, 247, 57, 81, 91, 131, 25, 165, 228, 227, 102, 117, 126, 53, 132, 134, 121, 98, 19, 125, 253, 226, 146, 25, 218, 105, 39, 105, 25, 40, 235, 87, 191, 29, 83, 186, 217, 53, 47, 91, 155, 158, 70, 83, 133, 174, 7, 212, 45, 24, 241, 208, 49, 225, 15, 209, 46, 205, 183, 150, 172, 80, 104, 2, 100, 39, 197, 234, 28, 236, 115, 149, 206, 67 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 274, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 8, 14, 8, 275, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9543), new byte[] { 63, 208, 131, 213, 12, 248, 26, 243, 122, 110, 43, 44, 174, 38, 183, 242, 147, 80, 8, 164, 0, 232, 23, 33, 200, 79, 36, 236, 48, 227, 134, 110, 116, 64, 77, 142, 13, 211, 242, 11, 113, 136, 186, 197, 142, 243, 18, 92, 132, 96, 2, 179, 67, 36, 111, 161, 241, 114, 213, 70, 166, 209, 18, 84 }, new byte[] { 230, 192, 31, 19, 33, 21, 29, 248, 213, 75, 15, 33, 240, 181, 162, 47, 135, 165, 29, 82, 183, 80, 37, 18, 93, 70, 210, 253, 255, 54, 12, 51, 34, 210, 47, 129, 5, 193, 97, 70, 126, 56, 48, 226, 213, 250, 184, 170, 153, 233, 116, 109, 175, 119, 110, 29, 13, 60, 157, 175, 51, 100, 113, 47, 49, 72, 61, 232, 44, 140, 254, 85, 228, 173, 124, 38, 24, 237, 213, 222, 65, 91, 93, 142, 49, 48, 155, 221, 63, 36, 110, 254, 192, 93, 192, 246, 237, 233, 224, 32, 148, 138, 64, 12, 31, 107, 163, 64, 92, 59, 186, 44, 230, 84, 77, 119, 20, 183, 163, 69, 113, 182, 203, 147, 89, 94, 2, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9550), new byte[] { 224, 229, 54, 58, 231, 134, 126, 132, 42, 31, 220, 108, 226, 225, 211, 178, 145, 196, 67, 14, 95, 247, 128, 87, 74, 23, 141, 246, 5, 232, 134, 84, 132, 229, 112, 251, 33, 161, 174, 143, 213, 85, 136, 196, 136, 157, 35, 201, 225, 26, 138, 82, 118, 8, 252, 14, 52, 175, 16, 186, 105, 216, 60, 55 }, new byte[] { 0, 181, 96, 101, 177, 10, 101, 154, 18, 171, 50, 187, 47, 28, 197, 144, 103, 6, 111, 91, 168, 182, 49, 200, 171, 76, 54, 243, 217, 221, 161, 1, 158, 71, 163, 147, 113, 129, 233, 89, 134, 168, 36, 97, 98, 48, 138, 179, 196, 217, 212, 100, 100, 83, 243, 152, 22, 127, 26, 32, 47, 156, 39, 214, 186, 61, 104, 53, 69, 56, 125, 160, 100, 164, 246, 68, 95, 70, 116, 44, 49, 60, 114, 159, 236, 6, 79, 230, 125, 116, 11, 79, 72, 227, 110, 118, 236, 8, 47, 253, 252, 85, 180, 45, 9, 207, 174, 191, 116, 33, 103, 122, 195, 127, 12, 72, 74, 68, 19, 153, 8, 199, 185, 224, 246, 55, 109, 14 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9552), new byte[] { 250, 194, 201, 100, 167, 200, 111, 192, 177, 146, 38, 24, 196, 231, 172, 127, 116, 171, 75, 158, 76, 152, 249, 215, 220, 64, 208, 56, 134, 22, 62, 62, 229, 240, 1, 166, 175, 49, 136, 75, 6, 21, 46, 108, 140, 43, 208, 220, 132, 86, 204, 119, 13, 107, 39, 170, 106, 53, 244, 130, 227, 213, 3, 88 }, new byte[] { 111, 122, 72, 183, 148, 186, 82, 134, 179, 241, 238, 133, 206, 28, 14, 173, 83, 26, 211, 246, 17, 196, 35, 65, 86, 120, 193, 231, 8, 228, 74, 201, 176, 239, 165, 205, 163, 7, 186, 23, 103, 29, 23, 17, 217, 159, 3, 64, 20, 241, 190, 218, 156, 155, 88, 28, 203, 36, 76, 94, 223, 249, 100, 84, 143, 243, 247, 221, 115, 210, 20, 86, 184, 199, 102, 140, 182, 59, 63, 214, 113, 213, 165, 158, 217, 10, 75, 121, 123, 253, 204, 11, 108, 117, 249, 166, 144, 2, 13, 38, 19, 111, 85, 62, 36, 136, 224, 135, 195, 178, 139, 128, 10, 177, 112, 31, 55, 123, 195, 60, 105, 16, 135, 28, 210, 179, 165, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 17, 8, 14, 8, 273, DateTimeKind.Utc).AddTicks(9554), new byte[] { 142, 247, 186, 138, 85, 56, 99, 233, 124, 160, 16, 87, 114, 129, 198, 184, 161, 254, 210, 55, 19, 52, 233, 141, 106, 191, 204, 84, 191, 57, 125, 251, 52, 75, 216, 49, 102, 241, 11, 0, 228, 188, 206, 209, 138, 130, 189, 66, 168, 211, 52, 141, 49, 4, 217, 231, 224, 204, 207, 196, 240, 126, 208, 24 }, new byte[] { 26, 128, 108, 77, 16, 107, 223, 110, 57, 87, 75, 93, 174, 227, 136, 144, 4, 196, 20, 94, 206, 149, 67, 145, 24, 220, 169, 96, 96, 205, 37, 140, 46, 7, 206, 146, 8, 131, 19, 51, 35, 13, 106, 149, 117, 79, 112, 119, 51, 113, 120, 175, 87, 239, 187, 235, 137, 220, 6, 123, 186, 48, 131, 141, 250, 89, 71, 82, 157, 252, 10, 79, 224, 113, 237, 243, 48, 150, 150, 28, 0, 26, 186, 0, 178, 31, 1, 187, 27, 174, 92, 249, 107, 81, 232, 212, 80, 244, 196, 1, 64, 190, 150, 248, 223, 241, 97, 160, 88, 11, 79, 15, 120, 158, 128, 182, 129, 140, 153, 15, 184, 52, 224, 237, 146, 28, 186, 246 } });
        }
    }
}
