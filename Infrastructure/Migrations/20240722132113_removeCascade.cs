using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 22, 12, 49, 10, 942, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(3370), new byte[] { 92, 246, 101, 69, 181, 206, 16, 236, 99, 67, 2, 2, 254, 227, 72, 68, 33, 69, 88, 126, 77, 190, 225, 34, 108, 207, 106, 239, 101, 187, 47, 36, 192, 198, 153, 227, 142, 70, 71, 112, 103, 65, 42, 69, 118, 25, 255, 77, 162, 203, 147, 116, 217, 86, 205, 78, 53, 41, 65, 57, 105, 83, 226, 22 }, new byte[] { 182, 218, 0, 96, 24, 181, 139, 22, 88, 132, 7, 159, 31, 162, 191, 18, 143, 200, 214, 201, 230, 56, 45, 192, 223, 129, 64, 86, 55, 14, 67, 13, 50, 41, 118, 211, 240, 112, 86, 115, 82, 198, 125, 183, 124, 34, 42, 50, 232, 211, 169, 230, 33, 185, 95, 53, 166, 14, 15, 191, 110, 123, 236, 42, 241, 135, 150, 142, 39, 89, 18, 121, 170, 41, 246, 214, 88, 154, 6, 131, 165, 4, 202, 77, 82, 30, 166, 99, 165, 137, 142, 161, 178, 95, 59, 39, 233, 33, 44, 105, 22, 91, 159, 92, 219, 248, 118, 145, 254, 81, 173, 28, 50, 186, 99, 107, 246, 183, 145, 63, 248, 12, 151, 224, 97, 161, 165, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(3378), new byte[] { 34, 152, 37, 217, 181, 105, 38, 52, 65, 231, 22, 50, 58, 178, 67, 117, 129, 198, 198, 9, 175, 6, 144, 122, 101, 208, 237, 234, 46, 62, 87, 77, 177, 13, 122, 129, 190, 148, 164, 109, 30, 10, 80, 241, 199, 30, 84, 63, 247, 82, 126, 42, 4, 56, 240, 157, 23, 187, 83, 146, 248, 190, 224, 252 }, new byte[] { 210, 64, 56, 90, 20, 49, 118, 144, 104, 111, 196, 65, 207, 170, 199, 193, 222, 202, 54, 171, 52, 251, 109, 239, 255, 233, 249, 20, 26, 120, 224, 161, 114, 181, 27, 119, 49, 99, 99, 166, 179, 116, 155, 116, 69, 4, 3, 150, 145, 200, 62, 19, 152, 11, 181, 116, 111, 65, 179, 97, 193, 11, 55, 55, 254, 64, 186, 108, 33, 162, 147, 70, 14, 245, 174, 244, 222, 26, 238, 239, 81, 213, 36, 186, 224, 49, 22, 104, 85, 254, 126, 237, 186, 107, 158, 46, 197, 125, 183, 86, 204, 121, 215, 255, 245, 174, 191, 199, 112, 113, 17, 69, 175, 226, 82, 97, 244, 142, 232, 32, 144, 222, 139, 219, 98, 204, 49, 24 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(3380), new byte[] { 246, 146, 86, 68, 135, 8, 241, 110, 217, 6, 96, 79, 57, 104, 129, 149, 2, 174, 85, 33, 103, 96, 0, 240, 61, 130, 183, 41, 160, 208, 98, 48, 232, 238, 165, 156, 132, 246, 168, 40, 232, 137, 134, 6, 220, 102, 73, 63, 93, 17, 231, 169, 224, 82, 147, 106, 131, 44, 141, 141, 122, 19, 121, 124 }, new byte[] { 115, 74, 61, 40, 229, 45, 204, 63, 22, 111, 201, 60, 158, 35, 197, 53, 129, 202, 226, 157, 243, 112, 81, 89, 179, 20, 14, 94, 173, 240, 215, 15, 155, 155, 97, 232, 92, 207, 154, 71, 10, 210, 142, 98, 103, 74, 48, 213, 136, 121, 18, 213, 251, 130, 239, 183, 19, 108, 4, 147, 197, 61, 255, 223, 208, 45, 186, 180, 17, 144, 228, 218, 145, 107, 222, 202, 73, 92, 90, 224, 102, 150, 86, 168, 139, 250, 250, 195, 118, 205, 68, 214, 79, 60, 112, 110, 164, 36, 63, 85, 52, 11, 90, 175, 160, 240, 137, 102, 215, 209, 143, 53, 146, 208, 143, 216, 212, 52, 62, 244, 19, 173, 240, 52, 160, 140, 16, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(3381), new byte[] { 205, 143, 229, 64, 121, 100, 200, 180, 7, 233, 216, 237, 202, 29, 88, 49, 69, 246, 8, 115, 138, 1, 164, 126, 37, 14, 155, 51, 190, 140, 104, 16, 41, 204, 157, 96, 43, 240, 176, 125, 24, 1, 66, 225, 96, 113, 96, 54, 22, 5, 11, 25, 248, 236, 55, 103, 154, 127, 215, 105, 42, 55, 20, 93 }, new byte[] { 55, 232, 212, 108, 28, 131, 198, 85, 69, 243, 231, 79, 1, 220, 82, 185, 84, 250, 9, 248, 26, 170, 128, 14, 192, 211, 97, 100, 54, 33, 157, 154, 214, 148, 213, 45, 246, 115, 219, 217, 226, 68, 99, 0, 134, 104, 5, 110, 151, 221, 128, 143, 15, 251, 206, 83, 89, 228, 37, 53, 120, 251, 158, 113, 190, 255, 188, 211, 20, 237, 199, 201, 198, 208, 113, 120, 3, 118, 217, 108, 230, 180, 233, 174, 208, 169, 105, 191, 219, 98, 116, 42, 209, 157, 191, 36, 30, 101, 163, 106, 190, 225, 50, 147, 253, 22, 44, 109, 5, 207, 98, 76, 185, 214, 235, 16, 181, 7, 72, 44, 37, 42, 63, 142, 144, 155, 150, 145 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates",
                column: "CampaignJobId",
                principalTable: "CampaignJobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 12, 49, 10, 942, DateTimeKind.Utc).AddTicks(1290),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7573), new byte[] { 32, 191, 68, 77, 35, 46, 149, 133, 110, 136, 56, 90, 120, 227, 8, 125, 147, 43, 199, 170, 4, 144, 89, 117, 58, 93, 149, 86, 63, 63, 162, 129, 246, 149, 218, 14, 242, 73, 76, 22, 179, 1, 189, 13, 124, 5, 19, 148, 99, 234, 152, 47, 1, 9, 163, 9, 223, 110, 60, 170, 154, 245, 63, 95 }, new byte[] { 40, 176, 66, 3, 108, 177, 46, 44, 116, 27, 236, 200, 146, 232, 19, 89, 103, 179, 104, 54, 131, 60, 159, 125, 148, 177, 165, 111, 14, 127, 13, 64, 207, 159, 37, 22, 130, 206, 139, 63, 246, 196, 141, 55, 254, 249, 54, 130, 43, 27, 152, 188, 97, 142, 43, 108, 33, 90, 8, 71, 72, 243, 253, 245, 219, 70, 9, 40, 159, 79, 133, 202, 179, 77, 109, 246, 98, 74, 139, 62, 223, 210, 142, 34, 138, 187, 109, 44, 14, 18, 213, 160, 181, 68, 247, 16, 1, 165, 107, 170, 232, 2, 4, 4, 105, 56, 154, 188, 94, 89, 158, 109, 166, 219, 242, 32, 100, 103, 28, 213, 189, 22, 248, 12, 237, 117, 148, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7582), new byte[] { 206, 43, 184, 105, 160, 178, 64, 20, 29, 149, 2, 185, 61, 147, 116, 18, 225, 254, 101, 89, 194, 243, 128, 172, 92, 170, 63, 95, 11, 176, 222, 251, 122, 101, 174, 63, 91, 107, 18, 165, 110, 251, 31, 12, 106, 172, 225, 75, 206, 45, 195, 98, 109, 146, 66, 128, 27, 124, 63, 185, 49, 149, 221, 226 }, new byte[] { 124, 59, 27, 106, 20, 19, 171, 1, 43, 138, 59, 191, 232, 171, 231, 220, 188, 216, 10, 5, 89, 244, 8, 8, 219, 51, 31, 107, 84, 198, 78, 168, 68, 208, 189, 77, 51, 186, 74, 62, 63, 234, 94, 41, 6, 46, 61, 112, 49, 154, 12, 42, 125, 237, 33, 230, 0, 179, 102, 61, 244, 133, 115, 41, 216, 74, 229, 75, 224, 185, 113, 0, 200, 167, 243, 205, 190, 26, 99, 88, 153, 158, 158, 44, 97, 145, 127, 240, 131, 161, 35, 93, 109, 251, 116, 21, 59, 65, 81, 92, 146, 54, 131, 107, 152, 107, 189, 16, 156, 17, 75, 13, 110, 165, 121, 73, 239, 12, 88, 122, 213, 61, 11, 235, 235, 124, 123, 201 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7584), new byte[] { 213, 125, 248, 250, 191, 21, 159, 86, 188, 190, 2, 201, 99, 216, 23, 83, 251, 78, 110, 102, 102, 67, 20, 46, 127, 120, 155, 72, 94, 166, 30, 215, 59, 123, 50, 185, 119, 180, 89, 150, 226, 76, 85, 83, 82, 87, 7, 57, 93, 43, 85, 70, 35, 67, 187, 117, 211, 47, 32, 220, 162, 58, 253, 17 }, new byte[] { 161, 153, 60, 210, 175, 198, 186, 254, 38, 9, 82, 60, 165, 50, 204, 106, 162, 216, 66, 132, 75, 18, 239, 59, 142, 57, 60, 158, 62, 188, 102, 87, 187, 60, 46, 236, 100, 65, 120, 98, 95, 236, 165, 243, 168, 67, 186, 243, 107, 159, 208, 49, 91, 247, 94, 152, 130, 186, 140, 26, 17, 72, 137, 165, 103, 221, 104, 120, 186, 82, 152, 194, 199, 160, 46, 52, 198, 25, 201, 9, 226, 57, 249, 213, 184, 241, 34, 17, 72, 64, 49, 75, 222, 195, 18, 130, 176, 231, 255, 39, 204, 164, 250, 14, 190, 196, 128, 229, 208, 127, 55, 147, 129, 148, 84, 83, 53, 174, 135, 211, 182, 247, 144, 11, 89, 36, 211, 119 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 12, 49, 10, 941, DateTimeKind.Utc).AddTicks(7586), new byte[] { 244, 90, 201, 8, 42, 73, 91, 35, 159, 18, 61, 222, 1, 139, 84, 6, 44, 38, 40, 229, 156, 146, 188, 164, 214, 151, 157, 126, 60, 195, 113, 109, 194, 74, 88, 89, 139, 156, 223, 66, 71, 29, 187, 18, 141, 21, 216, 166, 85, 30, 61, 37, 47, 167, 71, 254, 165, 45, 140, 242, 63, 143, 201, 114 }, new byte[] { 239, 192, 81, 159, 70, 84, 221, 78, 55, 117, 18, 121, 15, 216, 64, 241, 231, 249, 93, 112, 185, 34, 19, 38, 120, 250, 190, 133, 9, 167, 70, 101, 36, 47, 6, 180, 227, 122, 139, 139, 253, 16, 246, 87, 229, 253, 125, 186, 156, 227, 19, 122, 245, 192, 127, 139, 160, 169, 196, 38, 75, 212, 186, 226, 238, 156, 20, 20, 180, 212, 38, 104, 220, 139, 101, 183, 214, 45, 23, 203, 137, 89, 77, 125, 15, 89, 189, 151, 175, 113, 182, 24, 117, 74, 80, 88, 104, 180, 89, 242, 102, 80, 93, 71, 29, 197, 13, 255, 21, 253, 167, 49, 113, 162, 226, 134, 98, 145, 254, 88, 82, 229, 141, 91, 90, 53, 241, 9 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates",
                column: "CampaignJobId",
                principalTable: "CampaignJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_Jobs_JobId",
                table: "JobTrainingPrograms",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "JobTrainingPrograms",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
