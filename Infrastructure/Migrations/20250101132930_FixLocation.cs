using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 363, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 1, 13, 29, 29, 366, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9321), new byte[] { 164, 195, 157, 198, 83, 236, 26, 204, 114, 228, 54, 1, 162, 104, 195, 131, 178, 158, 60, 208, 251, 119, 165, 216, 114, 86, 48, 207, 247, 122, 80, 190, 120, 202, 203, 152, 104, 67, 114, 146, 63, 132, 148, 162, 54, 194, 192, 101, 251, 183, 103, 153, 18, 131, 237, 232, 114, 111, 208, 30, 194, 17, 241, 72 }, new byte[] { 55, 209, 152, 120, 95, 122, 127, 234, 50, 162, 110, 0, 192, 241, 28, 203, 55, 37, 205, 130, 238, 174, 89, 198, 130, 24, 189, 215, 17, 125, 24, 121, 88, 116, 251, 76, 78, 39, 181, 192, 252, 208, 2, 168, 174, 137, 162, 150, 215, 0, 118, 245, 197, 2, 254, 239, 121, 100, 154, 73, 54, 104, 220, 235, 142, 31, 25, 154, 239, 101, 232, 241, 252, 80, 168, 200, 150, 168, 1, 138, 4, 117, 76, 78, 32, 196, 126, 43, 154, 219, 146, 246, 237, 43, 95, 221, 161, 25, 24, 160, 9, 118, 66, 230, 149, 4, 136, 144, 204, 154, 248, 41, 235, 62, 233, 60, 242, 186, 59, 148, 113, 202, 146, 23, 130, 201, 215, 128 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9332), new byte[] { 71, 156, 19, 119, 122, 195, 204, 250, 189, 200, 69, 8, 21, 103, 32, 0, 176, 44, 56, 201, 125, 46, 145, 230, 201, 194, 3, 176, 232, 128, 98, 188, 221, 115, 224, 167, 236, 231, 14, 198, 16, 200, 161, 94, 163, 75, 146, 57, 39, 208, 158, 106, 33, 31, 141, 70, 226, 72, 118, 110, 91, 78, 101, 71 }, new byte[] { 208, 147, 185, 184, 131, 243, 96, 172, 110, 133, 92, 37, 99, 78, 143, 177, 186, 56, 129, 40, 36, 152, 201, 140, 193, 197, 72, 213, 77, 143, 190, 172, 213, 75, 153, 211, 149, 242, 209, 18, 216, 143, 33, 160, 117, 204, 162, 103, 112, 59, 106, 205, 54, 68, 197, 86, 153, 113, 242, 212, 96, 47, 153, 209, 32, 18, 196, 214, 198, 173, 162, 172, 170, 194, 166, 197, 151, 122, 36, 230, 232, 215, 195, 170, 156, 251, 57, 255, 228, 128, 104, 77, 209, 174, 224, 147, 205, 160, 43, 124, 117, 216, 252, 232, 242, 33, 184, 188, 207, 134, 152, 214, 52, 243, 146, 50, 7, 136, 135, 158, 33, 38, 45, 4, 192, 17, 178, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9358), new byte[] { 214, 160, 190, 169, 143, 159, 200, 163, 248, 48, 34, 164, 136, 127, 250, 145, 89, 200, 139, 247, 88, 41, 92, 141, 147, 25, 106, 19, 239, 39, 128, 161, 188, 254, 28, 169, 229, 23, 179, 33, 158, 62, 21, 28, 154, 135, 114, 12, 96, 67, 183, 186, 111, 70, 193, 28, 40, 69, 176, 232, 185, 156, 223, 160 }, new byte[] { 149, 3, 201, 240, 72, 59, 31, 160, 243, 40, 13, 98, 181, 242, 174, 54, 243, 218, 201, 83, 45, 84, 193, 75, 110, 72, 101, 81, 149, 64, 133, 92, 130, 155, 86, 190, 116, 159, 109, 6, 178, 73, 10, 34, 32, 1, 39, 184, 195, 172, 60, 126, 135, 3, 209, 184, 82, 182, 125, 180, 53, 54, 65, 234, 68, 191, 48, 36, 77, 231, 191, 60, 141, 101, 204, 219, 101, 126, 76, 70, 123, 141, 39, 157, 76, 208, 123, 20, 253, 209, 242, 201, 198, 16, 154, 23, 206, 198, 229, 240, 91, 110, 71, 34, 114, 210, 58, 174, 99, 112, 241, 145, 191, 177, 26, 122, 252, 18, 237, 75, 155, 62, 251, 254, 212, 51, 16, 62 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 1, 1, 13, 29, 29, 362, DateTimeKind.Utc).AddTicks(9359), new byte[] { 133, 62, 95, 209, 28, 19, 178, 32, 127, 225, 119, 128, 168, 33, 162, 82, 143, 15, 180, 192, 53, 151, 63, 73, 91, 166, 209, 33, 150, 125, 236, 162, 8, 58, 214, 31, 116, 90, 176, 238, 74, 169, 15, 37, 222, 223, 208, 126, 204, 56, 115, 97, 80, 98, 44, 116, 64, 129, 156, 167, 57, 83, 133, 68 }, new byte[] { 194, 49, 203, 3, 212, 159, 200, 218, 94, 185, 232, 182, 71, 44, 15, 190, 46, 59, 163, 32, 119, 138, 225, 205, 229, 34, 4, 34, 188, 71, 61, 193, 52, 144, 54, 123, 131, 173, 210, 64, 210, 222, 140, 24, 55, 71, 244, 199, 121, 84, 63, 58, 64, 38, 177, 233, 183, 179, 93, 102, 214, 165, 90, 178, 18, 5, 159, 153, 151, 176, 170, 200, 114, 71, 181, 198, 99, 157, 132, 53, 86, 225, 191, 244, 197, 159, 208, 128, 175, 54, 228, 116, 98, 252, 229, 85, 242, 226, 95, 215, 128, 215, 241, 40, 50, 43, 37, 146, 145, 98, 154, 156, 187, 233, 53, 239, 49, 158, 22, 46, 210, 99, 30, 186, 0, 142, 44, 239 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Locations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Locations",
                type: "text",
                nullable: true);

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
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "District", "PostCode" },
                values: new object[] { null, null });

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
        }
    }
}
