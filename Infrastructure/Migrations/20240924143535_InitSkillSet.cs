using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitSkillSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_SkillSet_SkillSetId",
                table: "JobSkillSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSet_SkillSet_SkillSetId",
                table: "SeekerSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillSet",
                table: "SkillSet");

            migrationBuilder.RenameTable(
                name: "SkillSet",
                newName: "SkillSets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillSets",
                table: "SkillSets",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 14, 35, 35, 349, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5244), new byte[] { 192, 76, 246, 226, 117, 41, 178, 129, 191, 143, 255, 47, 63, 64, 59, 142, 98, 145, 111, 152, 105, 25, 229, 200, 216, 195, 207, 64, 48, 1, 252, 39, 53, 144, 129, 252, 74, 19, 18, 222, 148, 60, 168, 208, 14, 13, 118, 131, 95, 45, 24, 14, 220, 86, 49, 68, 255, 137, 210, 101, 146, 58, 178, 56 }, new byte[] { 113, 114, 239, 3, 223, 215, 186, 185, 171, 134, 8, 75, 10, 217, 55, 211, 76, 255, 207, 230, 245, 22, 130, 179, 165, 34, 0, 33, 188, 73, 89, 182, 237, 61, 221, 126, 189, 114, 55, 196, 196, 190, 32, 109, 123, 100, 204, 179, 254, 150, 205, 64, 78, 145, 63, 135, 44, 240, 101, 38, 131, 157, 155, 194, 13, 89, 35, 58, 245, 154, 233, 207, 37, 65, 112, 242, 198, 62, 0, 188, 142, 31, 6, 188, 179, 0, 225, 66, 153, 46, 228, 184, 117, 48, 190, 182, 90, 3, 148, 228, 185, 185, 85, 171, 166, 52, 75, 147, 188, 48, 35, 110, 154, 111, 74, 61, 105, 105, 147, 149, 159, 184, 5, 7, 148, 30, 92, 109 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5252), new byte[] { 248, 248, 2, 158, 12, 27, 170, 131, 211, 105, 159, 184, 215, 236, 87, 75, 22, 36, 29, 198, 0, 230, 117, 162, 114, 160, 77, 245, 202, 219, 49, 240, 243, 110, 46, 213, 125, 205, 16, 107, 86, 127, 45, 114, 56, 4, 88, 119, 64, 99, 103, 12, 245, 117, 199, 140, 33, 242, 101, 182, 183, 94, 237, 107 }, new byte[] { 184, 30, 78, 68, 85, 111, 20, 201, 55, 220, 16, 47, 76, 121, 245, 98, 32, 229, 39, 155, 183, 210, 72, 46, 236, 194, 20, 116, 228, 183, 254, 198, 193, 234, 99, 208, 234, 225, 16, 77, 205, 126, 48, 8, 65, 42, 14, 39, 140, 165, 218, 98, 101, 63, 150, 223, 58, 254, 54, 129, 187, 222, 105, 209, 213, 126, 75, 229, 204, 102, 104, 233, 26, 144, 169, 109, 47, 133, 38, 107, 204, 201, 107, 173, 187, 65, 175, 164, 81, 1, 96, 33, 156, 8, 185, 152, 216, 217, 98, 48, 136, 81, 117, 13, 124, 159, 237, 193, 20, 21, 195, 235, 95, 236, 93, 2, 50, 79, 27, 149, 35, 28, 25, 31, 176, 1, 143, 154 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5254), new byte[] { 27, 116, 115, 189, 68, 92, 72, 170, 125, 213, 78, 251, 202, 213, 241, 122, 100, 138, 99, 64, 109, 249, 74, 214, 96, 33, 64, 35, 95, 227, 238, 50, 242, 99, 142, 108, 247, 234, 159, 115, 175, 91, 63, 173, 72, 241, 161, 32, 78, 121, 24, 211, 5, 84, 202, 217, 132, 78, 250, 209, 18, 31, 198, 235 }, new byte[] { 3, 56, 5, 126, 255, 23, 65, 39, 209, 132, 240, 168, 101, 2, 234, 197, 188, 225, 233, 234, 17, 188, 26, 86, 204, 139, 143, 248, 121, 223, 162, 35, 20, 6, 32, 134, 96, 187, 157, 140, 30, 243, 178, 232, 205, 87, 123, 60, 211, 3, 212, 186, 48, 242, 53, 99, 66, 224, 196, 129, 23, 193, 169, 115, 61, 102, 113, 6, 170, 122, 39, 61, 179, 71, 232, 84, 131, 161, 89, 77, 115, 180, 201, 198, 119, 117, 73, 242, 187, 15, 125, 127, 167, 109, 164, 173, 27, 206, 130, 241, 155, 232, 101, 232, 136, 26, 81, 14, 119, 123, 53, 80, 159, 171, 112, 200, 139, 163, 165, 102, 212, 210, 150, 170, 236, 30, 151, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 35, 348, DateTimeKind.Utc).AddTicks(5255), new byte[] { 227, 37, 20, 110, 221, 36, 44, 113, 161, 112, 68, 245, 128, 143, 5, 214, 125, 98, 133, 49, 124, 110, 104, 205, 164, 157, 220, 37, 91, 98, 182, 151, 15, 168, 197, 150, 241, 150, 217, 112, 182, 145, 99, 10, 167, 180, 89, 167, 205, 184, 201, 11, 156, 219, 53, 123, 73, 12, 116, 156, 150, 101, 143, 14 }, new byte[] { 60, 104, 53, 0, 22, 38, 160, 173, 163, 165, 121, 76, 176, 104, 244, 130, 33, 68, 8, 181, 143, 89, 151, 65, 215, 46, 130, 156, 179, 240, 119, 102, 248, 23, 145, 140, 209, 210, 109, 253, 6, 14, 142, 75, 25, 22, 128, 70, 28, 201, 3, 206, 197, 207, 116, 29, 221, 20, 240, 10, 134, 185, 49, 147, 149, 113, 156, 200, 112, 180, 19, 64, 202, 218, 242, 147, 42, 245, 211, 83, 51, 36, 241, 98, 88, 161, 226, 54, 166, 183, 221, 79, 213, 254, 202, 79, 192, 87, 80, 75, 19, 173, 93, 15, 69, 71, 151, 237, 203, 224, 42, 135, 134, 96, 46, 180, 136, 52, 184, 149, 150, 200, 80, 100, 203, 128, 11, 12 } });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_SkillSets_SkillSetId",
                table: "JobSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSet_SkillSets_SkillSetId",
                table: "SeekerSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSkillSet_SkillSets_SkillSetId",
                table: "JobSkillSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SeekerSkillSet_SkillSets_SkillSetId",
                table: "SeekerSkillSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillSets",
                table: "SkillSets");

            migrationBuilder.RenameTable(
                name: "SkillSets",
                newName: "SkillSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillSet",
                table: "SkillSet",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 24, 11, 7, 12, 898, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3368), new byte[] { 103, 152, 158, 164, 56, 132, 230, 27, 120, 126, 173, 147, 230, 179, 219, 17, 171, 52, 175, 180, 156, 113, 87, 121, 64, 72, 152, 217, 18, 81, 5, 228, 94, 6, 116, 79, 127, 29, 73, 27, 60, 39, 233, 138, 134, 65, 9, 241, 16, 140, 195, 0, 140, 248, 170, 46, 126, 11, 55, 150, 213, 74, 218, 45 }, new byte[] { 220, 69, 170, 102, 28, 151, 219, 11, 90, 57, 62, 249, 51, 145, 134, 76, 245, 182, 42, 190, 43, 171, 244, 233, 11, 114, 212, 156, 19, 34, 224, 195, 217, 96, 26, 118, 74, 229, 0, 145, 27, 46, 200, 213, 208, 74, 117, 23, 20, 82, 56, 152, 66, 12, 234, 232, 17, 141, 14, 170, 13, 4, 61, 240, 152, 17, 147, 65, 147, 91, 113, 37, 223, 53, 32, 26, 56, 122, 92, 113, 132, 49, 113, 195, 160, 171, 186, 49, 93, 50, 9, 62, 118, 232, 210, 16, 233, 195, 235, 157, 194, 111, 89, 33, 42, 191, 112, 216, 220, 92, 73, 151, 81, 145, 80, 206, 153, 32, 124, 32, 35, 103, 165, 82, 171, 200, 98, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3380), new byte[] { 37, 113, 158, 61, 156, 231, 81, 23, 200, 87, 57, 97, 108, 19, 215, 187, 61, 124, 63, 74, 106, 96, 174, 129, 44, 52, 246, 16, 30, 72, 174, 194, 143, 18, 66, 123, 139, 133, 135, 32, 154, 232, 128, 82, 113, 165, 20, 55, 233, 45, 9, 184, 106, 239, 185, 75, 128, 225, 223, 54, 11, 191, 81, 97 }, new byte[] { 21, 72, 219, 61, 255, 211, 36, 82, 58, 110, 77, 153, 121, 158, 28, 232, 150, 176, 157, 27, 162, 124, 253, 196, 30, 183, 14, 6, 106, 234, 243, 49, 193, 29, 201, 130, 226, 157, 231, 207, 24, 248, 193, 11, 185, 29, 220, 121, 41, 30, 75, 145, 3, 195, 0, 25, 148, 154, 142, 48, 138, 16, 185, 87, 178, 9, 130, 164, 101, 187, 15, 90, 206, 26, 65, 67, 191, 53, 153, 31, 172, 0, 85, 208, 12, 199, 171, 216, 180, 160, 228, 138, 102, 174, 2, 198, 84, 88, 199, 116, 142, 220, 49, 24, 192, 216, 141, 152, 233, 45, 47, 143, 18, 40, 224, 130, 221, 121, 40, 228, 101, 6, 163, 156, 48, 40, 1, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3381), new byte[] { 243, 31, 187, 205, 4, 245, 174, 21, 6, 12, 52, 183, 112, 9, 49, 200, 242, 184, 191, 158, 96, 86, 4, 87, 223, 153, 109, 125, 45, 110, 197, 156, 24, 46, 137, 107, 188, 103, 27, 146, 211, 15, 228, 16, 19, 14, 243, 23, 171, 102, 195, 21, 247, 172, 153, 55, 211, 81, 89, 168, 48, 67, 221, 58 }, new byte[] { 182, 254, 162, 118, 35, 142, 198, 79, 123, 210, 2, 40, 185, 142, 234, 37, 140, 219, 55, 236, 115, 230, 215, 24, 112, 175, 173, 62, 224, 210, 0, 51, 228, 119, 67, 228, 138, 64, 0, 242, 226, 247, 211, 50, 225, 222, 227, 16, 224, 246, 126, 29, 205, 93, 31, 61, 27, 112, 128, 209, 56, 56, 26, 167, 110, 73, 135, 81, 119, 128, 38, 90, 127, 36, 82, 217, 137, 91, 195, 147, 101, 198, 62, 174, 60, 102, 166, 112, 250, 93, 83, 143, 249, 220, 159, 110, 117, 12, 133, 19, 210, 194, 43, 25, 248, 74, 54, 211, 249, 131, 8, 182, 202, 19, 92, 59, 41, 82, 125, 190, 201, 55, 184, 138, 92, 113, 228, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 7, 12, 897, DateTimeKind.Utc).AddTicks(3383), new byte[] { 67, 220, 234, 192, 11, 194, 8, 167, 81, 188, 93, 31, 166, 246, 225, 153, 168, 245, 67, 1, 4, 23, 64, 14, 155, 152, 135, 179, 25, 96, 37, 110, 238, 53, 175, 160, 152, 225, 138, 79, 241, 25, 21, 108, 155, 129, 73, 99, 51, 251, 1, 124, 28, 88, 136, 125, 1, 230, 80, 238, 13, 57, 131, 241 }, new byte[] { 234, 35, 210, 18, 255, 133, 50, 253, 72, 163, 102, 137, 107, 59, 95, 105, 72, 244, 22, 206, 48, 119, 25, 139, 7, 154, 165, 35, 185, 183, 222, 44, 18, 2, 163, 19, 188, 135, 230, 191, 35, 118, 28, 171, 108, 128, 151, 29, 10, 169, 8, 169, 60, 124, 13, 95, 31, 124, 28, 79, 109, 215, 136, 248, 224, 252, 116, 163, 163, 112, 182, 105, 156, 233, 171, 18, 225, 153, 51, 168, 101, 200, 215, 161, 101, 10, 58, 48, 167, 7, 84, 250, 210, 158, 132, 160, 60, 213, 104, 241, 185, 122, 105, 210, 167, 41, 186, 192, 167, 201, 214, 119, 41, 180, 206, 236, 189, 197, 93, 85, 53, 20, 1, 173, 105, 246, 215, 166 } });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkillSet_SkillSet_SkillSetId",
                table: "JobSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeekerSkillSet_SkillSet_SkillSetId",
                table: "SeekerSkillSet",
                column: "SkillSetId",
                principalTable: "SkillSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
