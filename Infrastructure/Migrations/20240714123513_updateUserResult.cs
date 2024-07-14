using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateUserResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserResults_ProgramKPI_ProgramKpiId",
                table: "UserResults");

            migrationBuilder.DropIndex(
                name: "IX_UserResults_ProgramKpiId",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "ProgramKpiId",
                table: "UserResults");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "UserResults",
                newName: "ProgramId");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "UserResults",
                newName: "Total");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "UserResults",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserResults",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserResults",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "UserResults",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserResults",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserResults",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "KPI",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "UserResultDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    UserResultId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResultDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserResultDetail_UserResults_UserResultId",
                        column: x => x.UserResultId,
                        principalTable: "UserResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 84, 252, 199, 152, 50, 213, 54, 27, 139, 88, 7, 240, 9, 73, 80, 156, 215, 192, 118, 31, 222, 43, 213, 191, 109, 255, 115, 245, 237, 0, 7, 88, 59, 225, 236, 116, 202, 63, 180, 132, 218, 39, 207, 50, 127, 199, 67, 100, 100, 83, 226, 227, 45, 101, 235, 95, 75, 178, 218, 0, 67, 72, 126 }, new byte[] { 168, 88, 235, 39, 146, 155, 88, 75, 123, 41, 241, 14, 196, 150, 114, 176, 64, 156, 178, 108, 57, 86, 182, 168, 125, 12, 100, 250, 78, 93, 186, 254, 189, 199, 19, 156, 13, 165, 162, 79, 92, 33, 141, 150, 81, 211, 189, 2, 152, 81, 13, 72, 46, 47, 230, 45, 102, 46, 63, 240, 241, 33, 23, 72, 158, 197, 144, 184, 39, 183, 136, 138, 23, 22, 141, 80, 8, 75, 136, 125, 24, 182, 129, 100, 36, 114, 108, 45, 250, 97, 207, 156, 155, 128, 78, 120, 54, 21, 36, 184, 111, 36, 41, 147, 78, 16, 21, 255, 228, 166, 207, 24, 69, 49, 39, 66, 49, 103, 67, 225, 38, 46, 41, 40, 35, 250, 195, 123 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 208, 94, 97, 58, 68, 68, 206, 134, 160, 228, 137, 162, 89, 40, 35, 226, 57, 25, 141, 54, 16, 104, 124, 86, 34, 87, 97, 211, 25, 136, 118, 219, 216, 21, 239, 85, 219, 21, 173, 23, 163, 131, 242, 243, 159, 237, 235, 210, 25, 135, 16, 151, 203, 221, 248, 10, 198, 83, 159, 154, 129, 167, 200 }, new byte[] { 34, 136, 115, 241, 13, 48, 35, 76, 206, 249, 22, 41, 168, 98, 20, 255, 192, 123, 215, 45, 61, 152, 233, 27, 191, 53, 162, 175, 24, 7, 92, 242, 31, 230, 161, 62, 189, 2, 69, 89, 252, 233, 99, 114, 206, 232, 151, 110, 157, 3, 79, 232, 203, 222, 115, 250, 248, 240, 85, 196, 25, 52, 221, 45, 55, 108, 32, 207, 139, 226, 188, 47, 190, 196, 222, 171, 78, 141, 113, 137, 198, 194, 186, 6, 183, 48, 186, 236, 191, 28, 22, 84, 61, 237, 102, 144, 221, 29, 221, 178, 74, 194, 97, 31, 149, 88, 119, 250, 56, 134, 42, 152, 137, 160, 194, 156, 100, 176, 163, 8, 133, 69, 79, 162, 111, 217, 116, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 51, 46, 143, 156, 85, 167, 76, 164, 93, 45, 253, 104, 26, 65, 31, 15, 165, 225, 194, 49, 38, 74, 37, 192, 58, 43, 77, 68, 108, 208, 111, 246, 76, 75, 33, 64, 10, 156, 140, 174, 21, 21, 193, 117, 61, 129, 230, 178, 19, 203, 76, 165, 125, 252, 210, 28, 107, 21, 213, 249, 202, 174, 141, 198 }, new byte[] { 67, 175, 127, 248, 213, 135, 185, 225, 115, 32, 57, 91, 46, 253, 30, 116, 69, 109, 211, 12, 64, 241, 115, 126, 117, 79, 9, 41, 201, 72, 71, 102, 130, 55, 149, 181, 81, 92, 113, 194, 86, 155, 194, 159, 14, 87, 251, 192, 197, 220, 144, 84, 222, 219, 18, 80, 62, 227, 175, 50, 198, 21, 77, 122, 0, 117, 148, 156, 131, 133, 151, 135, 86, 232, 232, 165, 129, 79, 93, 32, 42, 206, 5, 80, 215, 101, 128, 165, 87, 215, 72, 80, 207, 201, 242, 79, 149, 170, 76, 172, 239, 121, 58, 143, 121, 226, 165, 243, 28, 26, 172, 238, 223, 28, 85, 142, 137, 118, 194, 216, 254, 9, 85, 146, 190, 22, 175, 41 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 115, 78, 66, 234, 64, 91, 140, 158, 190, 97, 85, 16, 247, 147, 246, 62, 175, 159, 61, 213, 10, 244, 101, 75, 245, 242, 105, 96, 132, 45, 166, 48, 190, 29, 83, 18, 76, 144, 124, 196, 216, 149, 223, 161, 31, 246, 190, 210, 6, 251, 111, 98, 227, 43, 78, 24, 132, 244, 110, 63, 213, 230, 97, 194 }, new byte[] { 86, 152, 35, 72, 94, 195, 90, 40, 173, 12, 10, 95, 20, 32, 61, 162, 19, 202, 119, 156, 166, 25, 70, 180, 42, 76, 218, 118, 68, 109, 213, 118, 15, 16, 58, 54, 7, 92, 90, 66, 95, 150, 81, 133, 221, 198, 220, 187, 138, 141, 94, 72, 121, 2, 190, 36, 207, 70, 251, 69, 166, 169, 6, 30, 125, 107, 148, 59, 226, 6, 114, 166, 212, 93, 235, 71, 216, 119, 234, 186, 229, 200, 88, 102, 139, 233, 156, 249, 106, 41, 67, 20, 135, 189, 110, 182, 165, 97, 255, 204, 96, 205, 27, 23, 98, 69, 185, 34, 213, 182, 165, 14, 191, 218, 183, 164, 218, 88, 229, 83, 89, 215, 114, 95, 243, 31, 169, 177 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserResults_ProgramId",
                table: "UserResults",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResultDetail_UserResultId",
                table: "UserResultDetail",
                column: "UserResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserResults_TrainingPrograms_ProgramId",
                table: "UserResults",
                column: "ProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserResults_TrainingPrograms_ProgramId",
                table: "UserResults");

            migrationBuilder.DropTable(
                name: "UserResultDetail");

            migrationBuilder.DropIndex(
                name: "IX_UserResults_ProgramId",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserResults");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserResults");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "UserResults",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "UserResults",
                newName: "Weight");

            migrationBuilder.AddColumn<float>(
                name: "Grade",
                table: "UserResults",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ProgramKpiId",
                table: "UserResults",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "KPI",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 44, 110, 73, 139, 85, 155, 144, 81, 162, 12, 232, 129, 161, 229, 173, 44, 226, 200, 143, 21, 167, 124, 175, 241, 117, 109, 53, 44, 157, 243, 228, 65, 203, 165, 108, 173, 225, 235, 56, 135, 122, 4, 54, 219, 44, 79, 101, 13, 133, 244, 149, 200, 241, 37, 120, 167, 140, 225, 190, 39, 2, 121, 125, 64 }, new byte[] { 51, 45, 147, 236, 227, 72, 232, 230, 164, 184, 35, 19, 245, 191, 112, 98, 100, 216, 13, 255, 243, 217, 166, 55, 182, 219, 239, 135, 27, 86, 229, 25, 55, 208, 67, 48, 9, 113, 137, 203, 228, 11, 139, 31, 60, 46, 41, 165, 93, 23, 66, 153, 16, 11, 114, 45, 145, 9, 45, 54, 53, 1, 199, 142, 2, 190, 24, 28, 112, 128, 231, 242, 148, 249, 125, 124, 227, 146, 125, 200, 190, 200, 140, 40, 58, 245, 44, 242, 36, 145, 156, 181, 169, 61, 200, 170, 176, 219, 205, 116, 34, 109, 150, 204, 12, 101, 200, 30, 150, 166, 123, 251, 254, 204, 109, 128, 85, 62, 47, 245, 138, 50, 146, 45, 129, 128, 24, 196 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 232, 205, 51, 63, 110, 147, 152, 68, 144, 152, 178, 247, 148, 254, 7, 162, 90, 6, 52, 157, 178, 67, 105, 81, 24, 185, 100, 207, 157, 77, 250, 32, 19, 173, 40, 134, 145, 226, 44, 117, 56, 152, 36, 250, 251, 251, 116, 107, 56, 198, 230, 52, 83, 67, 78, 193, 115, 113, 235, 16, 187, 150, 156 }, new byte[] { 42, 100, 82, 144, 101, 2, 145, 164, 214, 103, 41, 191, 237, 45, 153, 186, 183, 62, 207, 215, 74, 121, 2, 136, 67, 149, 123, 38, 42, 16, 20, 125, 216, 34, 201, 127, 24, 5, 148, 74, 135, 159, 15, 154, 211, 24, 144, 195, 212, 173, 49, 191, 154, 253, 163, 26, 212, 7, 232, 220, 91, 114, 117, 59, 81, 213, 27, 28, 164, 70, 215, 68, 10, 137, 181, 201, 54, 203, 24, 62, 217, 188, 167, 94, 177, 8, 243, 43, 232, 54, 213, 248, 221, 107, 253, 216, 159, 125, 201, 175, 41, 206, 193, 48, 123, 16, 127, 14, 121, 140, 88, 124, 91, 182, 19, 33, 197, 131, 246, 151, 167, 125, 141, 67, 153, 26, 11, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 86, 222, 10, 245, 235, 244, 105, 158, 181, 236, 59, 26, 65, 45, 147, 75, 125, 235, 237, 186, 214, 112, 94, 201, 80, 31, 86, 249, 213, 85, 228, 153, 230, 205, 214, 128, 129, 217, 110, 90, 43, 207, 149, 119, 251, 121, 203, 32, 39, 206, 23, 29, 6, 128, 36, 203, 74, 14, 6, 177, 35, 98, 3 }, new byte[] { 164, 207, 110, 240, 189, 139, 90, 147, 146, 194, 133, 223, 153, 111, 211, 26, 144, 248, 95, 12, 150, 138, 1, 235, 33, 184, 3, 3, 253, 128, 48, 218, 10, 12, 23, 45, 103, 196, 149, 52, 127, 184, 238, 129, 216, 214, 35, 182, 186, 0, 246, 225, 70, 16, 182, 177, 146, 85, 75, 147, 20, 240, 15, 3, 196, 135, 136, 219, 218, 196, 177, 195, 14, 49, 140, 90, 33, 174, 174, 18, 174, 30, 25, 90, 170, 157, 254, 58, 224, 169, 163, 200, 42, 64, 122, 132, 198, 182, 16, 31, 216, 195, 45, 184, 211, 43, 160, 218, 162, 206, 180, 96, 219, 251, 228, 36, 6, 183, 4, 149, 177, 12, 55, 85, 5, 153, 84, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 24, 229, 27, 208, 118, 177, 62, 39, 196, 10, 146, 157, 56, 177, 116, 41, 165, 253, 194, 138, 236, 90, 173, 185, 137, 225, 104, 29, 140, 238, 44, 186, 169, 105, 134, 145, 226, 37, 230, 133, 172, 73, 78, 143, 232, 26, 26, 212, 38, 233, 247, 39, 108, 99, 117, 208, 181, 67, 49, 214, 218, 144, 44, 27 }, new byte[] { 27, 41, 111, 42, 115, 85, 116, 65, 49, 145, 29, 169, 144, 46, 149, 11, 18, 208, 220, 71, 244, 140, 49, 31, 23, 96, 66, 120, 107, 157, 123, 224, 52, 243, 12, 39, 209, 38, 58, 230, 26, 87, 231, 5, 208, 244, 157, 141, 25, 255, 161, 229, 54, 159, 193, 127, 220, 48, 150, 214, 17, 253, 245, 83, 243, 150, 57, 115, 36, 121, 225, 63, 104, 140, 248, 84, 11, 191, 209, 45, 149, 144, 53, 243, 86, 150, 194, 218, 254, 111, 250, 102, 78, 183, 179, 150, 170, 236, 8, 252, 188, 129, 173, 67, 174, 171, 60, 54, 59, 127, 62, 147, 159, 216, 18, 230, 230, 45, 2, 196, 14, 14, 73, 222, 221, 146, 120, 74 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserResults_ProgramKpiId",
                table: "UserResults",
                column: "ProgramKpiId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserResults_ProgramKPI_ProgramKpiId",
                table: "UserResults",
                column: "ProgramKpiId",
                principalTable: "ProgramKPI",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
