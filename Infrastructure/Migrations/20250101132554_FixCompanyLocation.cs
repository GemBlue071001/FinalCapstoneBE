using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCompanyLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyLocations_Locations_CompanyId",
                table: "CompanyLocations");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 817, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 817, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 817, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 25, 52, 820, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 25, 52, 816, DateTimeKind.Utc).AddTicks(9720), new byte[] { 208, 160, 135, 151, 223, 112, 207, 232, 202, 110, 64, 225, 200, 163, 188, 163, 227, 229, 243, 233, 199, 16, 241, 149, 213, 241, 3, 81, 97, 188, 137, 17, 180, 235, 209, 224, 146, 29, 200, 42, 226, 65, 239, 248, 165, 163, 89, 132, 158, 240, 239, 40, 173, 189, 220, 80, 185, 181, 17, 167, 112, 159, 199, 85 }, new byte[] { 171, 170, 173, 244, 132, 30, 78, 191, 251, 180, 255, 223, 204, 5, 67, 149, 149, 2, 20, 23, 200, 66, 184, 104, 21, 66, 16, 7, 130, 108, 22, 178, 216, 227, 25, 97, 61, 153, 146, 6, 210, 82, 95, 114, 76, 230, 230, 115, 133, 20, 22, 12, 219, 67, 1, 42, 208, 186, 75, 26, 55, 184, 192, 66, 93, 93, 219, 125, 133, 13, 235, 200, 68, 252, 148, 174, 165, 251, 254, 34, 131, 49, 77, 170, 82, 53, 192, 130, 44, 39, 79, 55, 220, 130, 139, 1, 188, 23, 177, 95, 225, 165, 187, 201, 9, 174, 72, 161, 237, 71, 255, 236, 93, 128, 243, 13, 49, 83, 197, 71, 66, 205, 171, 140, 117, 102, 109, 162 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 25, 52, 816, DateTimeKind.Utc).AddTicks(9760), new byte[] { 177, 18, 169, 67, 20, 97, 59, 102, 21, 161, 52, 104, 88, 246, 87, 89, 226, 232, 46, 47, 14, 14, 96, 41, 11, 55, 0, 187, 104, 223, 106, 33, 44, 250, 180, 188, 9, 155, 132, 133, 136, 229, 187, 225, 131, 86, 7, 118, 230, 227, 172, 67, 28, 166, 1, 226, 70, 50, 9, 213, 14, 107, 206, 61 }, new byte[] { 58, 246, 248, 193, 202, 29, 215, 169, 210, 78, 187, 234, 40, 3, 190, 217, 101, 153, 205, 242, 113, 112, 84, 118, 0, 102, 77, 211, 203, 49, 171, 202, 92, 137, 203, 109, 173, 215, 218, 48, 58, 185, 160, 57, 239, 205, 22, 11, 42, 181, 48, 24, 232, 119, 128, 3, 179, 185, 243, 111, 154, 52, 28, 195, 175, 55, 173, 56, 151, 83, 129, 94, 135, 19, 106, 18, 52, 37, 130, 8, 64, 89, 68, 195, 33, 50, 195, 57, 16, 175, 114, 138, 230, 26, 4, 85, 76, 27, 151, 78, 48, 180, 183, 237, 195, 34, 46, 128, 16, 208, 202, 110, 185, 214, 230, 41, 96, 57, 150, 188, 89, 60, 13, 123, 192, 211, 253, 197 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 25, 52, 816, DateTimeKind.Utc).AddTicks(9763), new byte[] { 207, 157, 181, 108, 42, 181, 11, 16, 2, 33, 202, 120, 255, 213, 76, 32, 83, 80, 175, 194, 79, 98, 102, 30, 216, 234, 198, 34, 19, 193, 164, 156, 181, 141, 236, 191, 106, 103, 232, 121, 70, 249, 188, 3, 180, 118, 144, 19, 8, 73, 56, 128, 217, 219, 159, 254, 242, 213, 37, 138, 197, 24, 102, 220 }, new byte[] { 16, 37, 170, 99, 233, 142, 248, 94, 34, 213, 118, 39, 229, 196, 205, 41, 171, 9, 96, 69, 213, 238, 219, 62, 57, 77, 230, 103, 162, 221, 121, 23, 95, 97, 116, 49, 71, 199, 80, 219, 243, 219, 122, 181, 11, 101, 81, 155, 102, 94, 255, 217, 30, 251, 241, 111, 33, 224, 245, 122, 116, 112, 17, 228, 255, 177, 55, 43, 109, 169, 115, 174, 91, 243, 82, 59, 89, 226, 244, 128, 44, 6, 4, 44, 105, 255, 15, 231, 53, 158, 117, 5, 148, 242, 35, 38, 189, 249, 121, 244, 34, 127, 74, 241, 99, 202, 254, 103, 107, 68, 6, 66, 103, 190, 31, 102, 133, 28, 219, 172, 31, 249, 198, 234, 195, 107, 208, 167 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 25, 52, 816, DateTimeKind.Utc).AddTicks(9765), new byte[] { 136, 250, 10, 120, 199, 71, 224, 153, 172, 82, 162, 243, 217, 176, 241, 67, 175, 8, 120, 65, 121, 142, 55, 88, 109, 112, 216, 200, 239, 33, 40, 162, 76, 162, 55, 234, 191, 159, 255, 222, 180, 140, 61, 134, 77, 118, 16, 192, 119, 118, 230, 75, 251, 140, 146, 58, 202, 123, 206, 216, 117, 184, 220, 26 }, new byte[] { 46, 166, 164, 41, 66, 232, 191, 211, 134, 213, 51, 176, 107, 231, 24, 154, 199, 20, 32, 114, 124, 60, 189, 179, 73, 110, 183, 191, 11, 128, 50, 197, 79, 177, 199, 230, 206, 181, 106, 186, 99, 141, 101, 253, 52, 221, 245, 175, 242, 93, 130, 10, 136, 161, 116, 9, 60, 0, 193, 216, 186, 130, 101, 44, 112, 13, 177, 159, 132, 123, 52, 172, 108, 253, 61, 236, 74, 231, 181, 63, 204, 234, 247, 8, 71, 94, 117, 112, 229, 9, 42, 217, 3, 24, 205, 163, 0, 17, 128, 121, 231, 143, 87, 10, 99, 29, 116, 104, 193, 247, 135, 184, 15, 216, 229, 245, 115, 204, 28, 11, 73, 235, 30, 99, 63, 249, 66, 216 } });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLocations_LocationId",
                table: "CompanyLocations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyLocations_Locations_LocationId",
                table: "CompanyLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyLocations_Locations_LocationId",
                table: "CompanyLocations");

            migrationBuilder.DropIndex(
                name: "IX_CompanyLocations_LocationId",
                table: "CompanyLocations");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 775, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 9, 9, 43, 778, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8319), new byte[] { 172, 151, 69, 67, 178, 97, 13, 31, 163, 252, 163, 170, 163, 213, 132, 126, 208, 137, 169, 147, 124, 81, 67, 57, 254, 66, 26, 68, 144, 246, 198, 40, 121, 155, 77, 37, 56, 124, 97, 189, 135, 177, 1, 251, 195, 13, 160, 38, 194, 179, 201, 47, 77, 78, 236, 211, 29, 94, 125, 171, 91, 219, 38, 50 }, new byte[] { 208, 5, 100, 48, 72, 221, 118, 176, 164, 86, 52, 98, 5, 29, 18, 126, 91, 154, 79, 181, 27, 115, 77, 216, 26, 150, 152, 125, 244, 18, 62, 71, 86, 190, 3, 32, 155, 239, 118, 83, 107, 68, 115, 105, 172, 74, 184, 232, 154, 214, 39, 27, 124, 134, 155, 23, 66, 249, 66, 48, 180, 55, 24, 2, 130, 190, 160, 194, 208, 130, 67, 75, 72, 237, 232, 23, 239, 202, 163, 155, 201, 184, 30, 178, 60, 162, 28, 68, 237, 154, 166, 246, 22, 255, 73, 23, 157, 237, 24, 169, 134, 62, 243, 17, 147, 67, 42, 241, 173, 217, 71, 158, 239, 5, 179, 163, 123, 151, 36, 87, 3, 121, 245, 191, 76, 181, 185, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8327), new byte[] { 247, 117, 131, 208, 230, 127, 216, 11, 212, 238, 146, 27, 178, 102, 232, 45, 105, 35, 146, 80, 149, 12, 245, 128, 94, 192, 113, 78, 97, 198, 101, 21, 196, 167, 233, 181, 83, 190, 26, 102, 55, 238, 113, 101, 156, 61, 210, 191, 243, 142, 9, 13, 7, 143, 105, 199, 22, 250, 242, 202, 97, 188, 150, 12 }, new byte[] { 92, 247, 72, 157, 119, 48, 144, 218, 107, 254, 84, 226, 114, 135, 132, 154, 230, 190, 179, 162, 113, 6, 30, 16, 109, 18, 48, 165, 218, 212, 32, 143, 78, 2, 27, 178, 48, 210, 155, 84, 132, 73, 59, 197, 113, 155, 57, 69, 65, 114, 191, 131, 84, 57, 179, 23, 123, 94, 132, 87, 219, 148, 14, 68, 12, 103, 254, 45, 112, 246, 6, 167, 209, 194, 202, 253, 215, 10, 222, 190, 128, 143, 227, 149, 95, 87, 176, 71, 52, 199, 165, 221, 57, 98, 153, 18, 229, 37, 37, 136, 97, 160, 209, 39, 96, 251, 239, 219, 183, 69, 41, 4, 195, 229, 185, 117, 233, 29, 27, 42, 1, 23, 130, 224, 155, 193, 9, 151 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8329), new byte[] { 32, 251, 250, 125, 185, 227, 227, 64, 168, 134, 197, 18, 88, 83, 196, 66, 69, 111, 61, 65, 252, 118, 96, 92, 125, 104, 254, 97, 196, 99, 132, 152, 49, 201, 185, 174, 34, 144, 241, 235, 123, 175, 16, 9, 109, 58, 128, 64, 249, 202, 68, 217, 249, 133, 106, 109, 39, 120, 34, 210, 186, 246, 46, 219 }, new byte[] { 87, 207, 212, 194, 22, 197, 64, 24, 109, 242, 24, 248, 183, 101, 46, 205, 183, 9, 182, 237, 59, 98, 217, 35, 12, 138, 82, 247, 32, 197, 254, 18, 109, 24, 210, 175, 67, 224, 51, 119, 143, 236, 161, 32, 29, 134, 121, 210, 226, 126, 255, 228, 149, 4, 163, 148, 85, 81, 121, 239, 255, 23, 144, 61, 49, 66, 14, 34, 71, 177, 8, 124, 102, 105, 185, 1, 153, 129, 113, 97, 9, 141, 79, 175, 211, 111, 117, 57, 146, 104, 106, 106, 150, 187, 129, 65, 222, 214, 188, 171, 72, 140, 145, 232, 174, 46, 254, 42, 34, 66, 227, 81, 16, 4, 132, 49, 44, 21, 164, 171, 3, 181, 228, 88, 80, 238, 187, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 9, 9, 43, 774, DateTimeKind.Utc).AddTicks(8331), new byte[] { 164, 202, 53, 31, 170, 127, 156, 210, 84, 229, 185, 166, 228, 232, 180, 24, 46, 82, 179, 51, 170, 209, 178, 168, 128, 33, 8, 80, 255, 113, 57, 226, 21, 69, 213, 180, 14, 207, 125, 11, 23, 88, 59, 213, 99, 210, 44, 104, 69, 144, 106, 122, 12, 2, 127, 6, 121, 190, 11, 77, 62, 2, 176, 99 }, new byte[] { 3, 228, 143, 248, 103, 48, 101, 134, 52, 75, 156, 207, 135, 94, 84, 191, 251, 117, 103, 144, 213, 206, 100, 78, 51, 153, 203, 216, 27, 34, 222, 244, 131, 192, 254, 60, 45, 42, 24, 245, 60, 208, 180, 80, 220, 67, 105, 208, 125, 103, 173, 123, 38, 17, 204, 120, 15, 47, 211, 153, 189, 168, 68, 208, 70, 215, 89, 255, 2, 169, 106, 148, 201, 72, 100, 221, 113, 172, 218, 198, 19, 81, 40, 181, 7, 29, 233, 4, 189, 63, 220, 197, 99, 113, 200, 184, 115, 74, 236, 152, 249, 156, 0, 227, 164, 62, 159, 72, 49, 161, 54, 118, 57, 186, 194, 224, 176, 155, 250, 83, 14, 96, 196, 127, 0, 192, 121, 122 } });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyLocations_Locations_CompanyId",
                table: "CompanyLocations",
                column: "CompanyId",
                principalTable: "Locations",
                principalColumn: "Id");
        }
    }
}
