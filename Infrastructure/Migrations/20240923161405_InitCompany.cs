using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_BusinessStream_BusinessStreamId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Company_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companys");

            migrationBuilder.RenameIndex(
                name: "IX_Company_BusinessStreamId",
                table: "Companys",
                newName: "IX_Companys_BusinessStreamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companys",
                table: "Companys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2158), new byte[] { 146, 15, 123, 240, 44, 151, 141, 228, 18, 115, 44, 245, 147, 59, 113, 72, 228, 132, 220, 29, 252, 26, 90, 131, 219, 0, 200, 179, 184, 254, 157, 133, 133, 120, 172, 184, 5, 184, 232, 235, 184, 130, 225, 226, 160, 26, 180, 241, 40, 23, 26, 5, 109, 51, 153, 89, 80, 35, 221, 91, 217, 37, 237, 104 }, new byte[] { 145, 13, 113, 156, 246, 128, 245, 47, 163, 127, 151, 88, 48, 208, 188, 211, 11, 70, 93, 239, 100, 38, 1, 200, 24, 23, 4, 49, 50, 18, 148, 112, 91, 10, 60, 95, 157, 18, 9, 71, 45, 34, 190, 169, 49, 5, 57, 26, 158, 43, 206, 139, 212, 168, 59, 87, 63, 208, 50, 235, 147, 18, 98, 180, 26, 141, 132, 91, 206, 221, 174, 169, 117, 134, 20, 129, 100, 122, 3, 67, 12, 171, 254, 221, 69, 151, 132, 145, 64, 29, 222, 201, 55, 165, 163, 35, 207, 150, 226, 202, 100, 44, 31, 250, 112, 226, 50, 203, 5, 99, 8, 76, 132, 150, 235, 211, 184, 131, 59, 210, 28, 36, 109, 225, 118, 21, 161, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2166), new byte[] { 18, 148, 131, 51, 243, 182, 203, 38, 18, 100, 20, 69, 184, 2, 26, 137, 190, 0, 5, 252, 72, 30, 65, 96, 221, 186, 221, 233, 152, 151, 247, 38, 181, 32, 221, 173, 190, 226, 193, 183, 108, 215, 79, 126, 152, 248, 187, 186, 255, 60, 86, 249, 155, 185, 166, 76, 138, 119, 131, 77, 255, 178, 2, 5 }, new byte[] { 191, 91, 157, 72, 103, 5, 86, 227, 223, 89, 223, 156, 101, 37, 242, 238, 122, 111, 58, 13, 143, 157, 110, 187, 27, 183, 22, 197, 220, 36, 194, 101, 19, 178, 110, 225, 98, 59, 69, 149, 188, 81, 208, 208, 124, 80, 209, 126, 241, 157, 32, 65, 162, 126, 168, 188, 191, 18, 57, 4, 146, 217, 37, 15, 34, 30, 185, 60, 253, 139, 215, 169, 21, 168, 252, 29, 222, 67, 9, 144, 83, 246, 224, 225, 79, 47, 37, 199, 255, 247, 231, 129, 206, 117, 216, 166, 170, 12, 83, 72, 169, 9, 10, 136, 26, 193, 116, 214, 149, 45, 177, 242, 51, 138, 42, 177, 12, 157, 198, 214, 223, 26, 79, 74, 115, 20, 198, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2168), new byte[] { 255, 212, 206, 187, 68, 178, 254, 73, 33, 101, 118, 208, 134, 21, 84, 77, 71, 154, 215, 227, 212, 164, 58, 179, 118, 12, 159, 159, 62, 31, 143, 10, 69, 18, 207, 134, 231, 76, 241, 41, 227, 253, 111, 167, 35, 223, 123, 62, 51, 25, 116, 193, 0, 103, 148, 196, 65, 22, 182, 75, 237, 50, 174, 78 }, new byte[] { 195, 221, 232, 185, 114, 148, 241, 60, 158, 90, 23, 112, 152, 31, 60, 37, 60, 3, 160, 22, 12, 89, 79, 248, 233, 180, 50, 107, 129, 93, 62, 215, 203, 133, 64, 30, 217, 161, 145, 223, 133, 227, 234, 38, 171, 107, 30, 249, 189, 19, 155, 33, 185, 142, 35, 192, 232, 117, 53, 249, 98, 53, 98, 11, 62, 112, 65, 92, 37, 89, 243, 195, 56, 46, 70, 150, 181, 173, 38, 6, 24, 64, 123, 229, 92, 22, 184, 245, 175, 104, 194, 13, 28, 84, 245, 94, 162, 211, 128, 24, 135, 168, 177, 67, 216, 14, 89, 214, 178, 238, 215, 56, 182, 183, 188, 85, 54, 44, 52, 184, 54, 74, 107, 223, 228, 32, 140, 58 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 14, 5, 334, DateTimeKind.Utc).AddTicks(2169), new byte[] { 71, 132, 89, 175, 129, 88, 235, 34, 64, 188, 166, 126, 218, 82, 243, 157, 228, 93, 112, 104, 185, 6, 13, 248, 188, 134, 26, 243, 46, 252, 210, 16, 233, 225, 225, 24, 254, 146, 220, 34, 225, 86, 115, 21, 239, 98, 24, 111, 68, 229, 35, 116, 233, 95, 193, 45, 250, 204, 43, 134, 172, 70, 118, 134 }, new byte[] { 166, 149, 133, 167, 158, 170, 142, 163, 236, 240, 6, 250, 12, 97, 38, 54, 65, 186, 248, 239, 101, 91, 67, 134, 114, 249, 2, 103, 76, 248, 177, 118, 41, 41, 236, 106, 206, 132, 132, 253, 147, 168, 120, 206, 17, 242, 115, 221, 45, 171, 93, 23, 80, 147, 117, 55, 13, 90, 9, 2, 90, 8, 214, 54, 167, 147, 196, 112, 132, 39, 19, 94, 66, 119, 128, 19, 105, 184, 192, 67, 62, 77, 117, 159, 72, 228, 116, 85, 177, 239, 185, 212, 93, 159, 223, 47, 119, 195, 115, 64, 51, 198, 1, 123, 74, 218, 120, 91, 219, 205, 39, 99, 8, 114, 227, 174, 53, 44, 66, 95, 212, 241, 184, 117, 49, 187, 107, 10 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Companys_BusinessStream_BusinessStreamId",
                table: "Companys",
                column: "BusinessStreamId",
                principalTable: "BusinessStream",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companys_BusinessStream_BusinessStreamId",
                table: "Companys");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Companys_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companys",
                table: "Companys");

            migrationBuilder.RenameTable(
                name: "Companys",
                newName: "Company");

            migrationBuilder.RenameIndex(
                name: "IX_Companys_BusinessStreamId",
                table: "Company",
                newName: "IX_Company_BusinessStreamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BusinessStream",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "JobLocations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "SkillSet",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 22, 17, 53, 9, 573, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8675), new byte[] { 175, 112, 52, 216, 94, 110, 195, 166, 199, 30, 191, 190, 148, 105, 23, 223, 58, 243, 127, 100, 104, 114, 244, 62, 228, 213, 101, 158, 136, 150, 167, 92, 100, 215, 150, 61, 208, 135, 199, 166, 30, 98, 58, 82, 34, 218, 173, 203, 180, 98, 105, 220, 43, 122, 69, 12, 198, 213, 17, 159, 194, 6, 75, 189 }, new byte[] { 172, 202, 131, 142, 145, 21, 215, 68, 50, 48, 250, 159, 226, 75, 149, 14, 118, 193, 3, 34, 209, 165, 208, 38, 158, 30, 208, 230, 132, 34, 130, 87, 177, 149, 241, 199, 15, 116, 117, 84, 204, 61, 252, 39, 92, 20, 119, 231, 128, 69, 233, 42, 218, 211, 1, 1, 179, 162, 201, 80, 162, 255, 214, 80, 219, 49, 245, 217, 204, 19, 43, 190, 195, 231, 234, 225, 23, 140, 81, 151, 94, 202, 247, 23, 194, 118, 117, 68, 16, 231, 103, 81, 148, 125, 139, 54, 127, 9, 160, 243, 48, 252, 24, 126, 205, 242, 254, 216, 116, 148, 202, 27, 243, 139, 216, 180, 96, 229, 191, 6, 79, 57, 204, 246, 20, 39, 238, 80 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8682), new byte[] { 134, 89, 118, 83, 217, 216, 183, 247, 87, 248, 74, 112, 64, 226, 190, 41, 210, 139, 107, 50, 249, 121, 223, 104, 54, 242, 155, 70, 233, 48, 93, 9, 157, 60, 200, 83, 30, 253, 68, 118, 201, 242, 135, 50, 87, 225, 190, 227, 41, 223, 42, 2, 178, 89, 75, 166, 7, 237, 95, 169, 137, 49, 203, 111 }, new byte[] { 108, 108, 131, 176, 40, 246, 116, 68, 45, 207, 246, 191, 152, 125, 183, 147, 196, 246, 179, 54, 2, 167, 22, 81, 173, 222, 169, 22, 220, 215, 189, 25, 221, 133, 249, 251, 93, 57, 242, 98, 168, 221, 27, 88, 163, 73, 151, 177, 232, 232, 89, 109, 170, 1, 6, 128, 222, 164, 166, 76, 80, 157, 113, 140, 5, 29, 11, 173, 118, 42, 141, 199, 22, 194, 65, 203, 57, 153, 54, 88, 112, 19, 153, 193, 120, 166, 48, 116, 57, 212, 5, 66, 179, 3, 113, 119, 210, 94, 7, 229, 93, 102, 210, 55, 194, 75, 213, 110, 52, 140, 154, 130, 151, 122, 142, 253, 197, 206, 153, 79, 224, 15, 52, 230, 235, 201, 90, 228 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8684), new byte[] { 39, 164, 171, 123, 76, 13, 198, 42, 154, 144, 251, 216, 35, 153, 195, 200, 251, 19, 240, 180, 41, 40, 135, 111, 204, 151, 165, 65, 239, 94, 49, 9, 25, 16, 143, 2, 123, 224, 18, 96, 43, 38, 180, 65, 70, 6, 120, 156, 71, 125, 154, 184, 117, 60, 147, 98, 5, 138, 129, 67, 109, 42, 156, 10 }, new byte[] { 108, 211, 113, 198, 207, 135, 243, 243, 203, 217, 92, 24, 200, 57, 154, 86, 16, 62, 3, 102, 176, 245, 127, 193, 122, 167, 244, 96, 31, 38, 37, 192, 199, 0, 204, 49, 220, 148, 237, 15, 180, 58, 126, 124, 44, 169, 28, 59, 115, 220, 2, 21, 241, 49, 102, 206, 40, 11, 6, 22, 169, 166, 221, 35, 249, 10, 135, 175, 250, 204, 232, 217, 228, 74, 24, 4, 67, 56, 51, 199, 118, 187, 241, 182, 96, 67, 66, 137, 74, 175, 3, 4, 224, 208, 4, 217, 56, 18, 196, 154, 176, 157, 86, 158, 114, 105, 23, 87, 17, 239, 185, 204, 39, 248, 100, 184, 124, 252, 228, 59, 207, 170, 112, 17, 54, 63, 34, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 53, 9, 572, DateTimeKind.Utc).AddTicks(8685), new byte[] { 31, 84, 48, 161, 251, 224, 244, 202, 115, 165, 253, 253, 209, 132, 81, 60, 140, 21, 78, 45, 205, 187, 216, 14, 72, 31, 100, 68, 214, 86, 205, 228, 157, 7, 26, 64, 124, 107, 99, 88, 121, 0, 38, 63, 95, 37, 139, 65, 25, 233, 148, 128, 52, 188, 19, 230, 20, 60, 24, 201, 37, 128, 177, 124 }, new byte[] { 215, 30, 2, 159, 204, 29, 97, 180, 251, 130, 191, 173, 94, 128, 105, 29, 136, 24, 66, 73, 3, 11, 99, 139, 134, 230, 159, 130, 63, 146, 197, 211, 55, 1, 48, 35, 112, 132, 182, 158, 155, 208, 181, 230, 191, 119, 203, 177, 210, 23, 58, 3, 107, 226, 241, 100, 29, 2, 32, 230, 248, 109, 51, 182, 53, 39, 104, 124, 10, 138, 22, 196, 62, 204, 162, 228, 109, 97, 181, 128, 85, 162, 177, 141, 54, 63, 21, 184, 54, 225, 146, 167, 164, 6, 204, 120, 132, 3, 130, 147, 142, 172, 54, 119, 3, 171, 247, 66, 176, 227, 73, 192, 2, 24, 128, 113, 102, 45, 219, 220, 62, 36, 120, 34, 171, 252, 5, 76 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Company_BusinessStream_BusinessStreamId",
                table: "Company",
                column: "BusinessStreamId",
                principalTable: "BusinessStream",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Company_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
