using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Jobs_JobId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Jobs_JobId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_JobId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Users",
                newName: "CampaignJobId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_JobId",
                table: "Users",
                newName: "IX_Users_CampaignJobId");

            migrationBuilder.AddColumn<int>(
                name: "CampaignJobId",
                table: "Candidates",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 156, 74, 71, 143, 95, 91, 219, 206, 105, 30, 66, 216, 91, 185, 60, 253, 121, 191, 217, 95, 76, 149, 27, 245, 8, 252, 85, 136, 17, 145, 31, 55, 150, 99, 106, 78, 44, 150, 209, 226, 48, 78, 48, 73, 77, 237, 0, 217, 149, 138, 250, 142, 86, 243, 141, 64, 87, 43, 229, 151, 163, 254, 203 }, new byte[] { 77, 18, 106, 34, 96, 153, 65, 191, 15, 169, 61, 216, 100, 132, 225, 182, 43, 190, 153, 208, 56, 19, 16, 120, 46, 104, 202, 166, 21, 24, 166, 30, 170, 66, 34, 143, 160, 87, 211, 73, 180, 239, 18, 63, 182, 209, 199, 155, 69, 196, 33, 83, 170, 182, 183, 4, 182, 193, 18, 53, 207, 193, 25, 155, 180, 184, 33, 85, 82, 183, 145, 97, 115, 195, 194, 196, 195, 197, 217, 3, 121, 181, 184, 118, 180, 173, 232, 89, 193, 43, 25, 114, 205, 181, 179, 218, 114, 180, 42, 21, 151, 15, 141, 70, 214, 33, 6, 97, 247, 91, 157, 111, 184, 88, 248, 71, 67, 1, 0, 62, 145, 87, 41, 131, 41, 25, 134, 118 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 155, 11, 65, 123, 28, 173, 171, 125, 110, 250, 45, 192, 57, 164, 8, 178, 178, 68, 34, 253, 59, 190, 21, 76, 211, 94, 186, 213, 248, 110, 29, 250, 86, 16, 37, 77, 17, 244, 157, 79, 155, 44, 235, 231, 1, 166, 150, 193, 165, 207, 38, 133, 140, 168, 185, 223, 163, 125, 97, 196, 83, 202, 71 }, new byte[] { 36, 117, 138, 6, 205, 9, 77, 39, 147, 164, 213, 235, 86, 205, 149, 54, 41, 119, 57, 58, 243, 237, 71, 12, 128, 234, 198, 26, 217, 13, 53, 227, 18, 52, 70, 53, 171, 11, 63, 47, 86, 175, 51, 251, 141, 112, 243, 178, 224, 103, 227, 200, 23, 207, 251, 207, 103, 4, 104, 223, 252, 45, 206, 222, 42, 92, 5, 27, 156, 14, 173, 202, 251, 87, 97, 34, 21, 183, 202, 127, 7, 55, 191, 130, 10, 78, 146, 245, 166, 231, 126, 124, 135, 114, 119, 47, 244, 50, 71, 177, 84, 188, 227, 60, 201, 225, 4, 222, 211, 191, 14, 206, 250, 34, 104, 63, 209, 16, 132, 4, 33, 47, 224, 200, 174, 182, 46, 145 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 161, 174, 30, 244, 54, 40, 60, 31, 25, 255, 31, 71, 34, 102, 97, 210, 140, 182, 131, 92, 143, 123, 16, 122, 103, 221, 53, 32, 53, 103, 106, 22, 192, 103, 194, 117, 239, 90, 110, 175, 127, 129, 97, 127, 63, 196, 25, 151, 151, 101, 109, 34, 245, 102, 163, 193, 18, 214, 63, 199, 246, 183, 81 }, new byte[] { 200, 78, 173, 88, 30, 166, 158, 68, 60, 45, 30, 252, 86, 36, 119, 105, 197, 219, 96, 7, 46, 143, 52, 151, 121, 80, 186, 108, 166, 35, 110, 192, 205, 180, 9, 158, 198, 211, 19, 109, 231, 150, 54, 115, 102, 37, 234, 134, 152, 41, 84, 51, 19, 230, 243, 225, 194, 203, 46, 3, 220, 224, 65, 47, 167, 220, 254, 243, 102, 101, 182, 151, 106, 194, 55, 2, 143, 249, 168, 97, 185, 57, 235, 251, 222, 20, 175, 143, 250, 28, 206, 209, 81, 213, 234, 14, 141, 75, 176, 199, 245, 242, 29, 41, 144, 42, 120, 229, 175, 31, 220, 131, 21, 207, 241, 175, 186, 103, 3, 104, 41, 146, 118, 18, 38, 142, 162, 22 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 14, 177, 4, 153, 188, 243, 149, 85, 208, 232, 67, 128, 137, 33, 101, 197, 230, 215, 103, 236, 59, 223, 149, 152, 196, 168, 106, 192, 71, 254, 83, 166, 212, 147, 86, 241, 47, 1, 27, 239, 71, 148, 79, 139, 46, 172, 105, 242, 99, 72, 152, 175, 48, 208, 136, 57, 182, 213, 209, 16, 18, 235, 67, 154 }, new byte[] { 4, 224, 83, 157, 86, 11, 170, 222, 29, 128, 43, 2, 181, 85, 33, 243, 2, 207, 178, 193, 95, 36, 3, 50, 180, 38, 15, 109, 210, 95, 37, 112, 135, 117, 227, 78, 53, 242, 212, 39, 69, 88, 20, 1, 194, 98, 33, 56, 223, 61, 226, 88, 129, 252, 77, 146, 67, 168, 107, 159, 170, 81, 82, 200, 183, 156, 3, 250, 100, 77, 157, 148, 17, 118, 247, 107, 23, 0, 135, 210, 242, 151, 48, 250, 130, 101, 248, 141, 58, 11, 203, 125, 23, 14, 90, 148, 1, 228, 141, 31, 36, 229, 198, 94, 99, 246, 47, 28, 7, 134, 114, 252, 74, 165, 192, 155, 83, 250, 172, 19, 91, 224, 205, 167, 16, 155, 94, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CampaignJobId",
                table: "Candidates",
                column: "CampaignJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates",
                column: "CampaignJobId",
                principalTable: "CampaignJobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CampaignJobs_CampaignJobId",
                table: "Users",
                column: "CampaignJobId",
                principalTable: "CampaignJobs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_CampaignJobs_CampaignJobId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_CampaignJobs_CampaignJobId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_CampaignJobId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "CampaignJobId",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "CampaignJobId",
                table: "Users",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CampaignJobId",
                table: "Users",
                newName: "IX_Users_JobId");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Candidates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 57, 37, 224, 106, 194, 81, 96, 129, 179, 195, 202, 11, 97, 32, 7, 72, 27, 225, 229, 154, 90, 9, 110, 20, 229, 227, 123, 105, 163, 103, 56, 70, 138, 87, 8, 156, 226, 156, 11, 127, 4, 30, 231, 1, 122, 12, 158, 143, 156, 221, 53, 32, 247, 166, 78, 99, 56, 193, 147, 211, 109, 20, 28, 126 }, new byte[] { 12, 205, 109, 62, 66, 61, 59, 147, 100, 30, 225, 59, 200, 145, 78, 107, 35, 101, 81, 96, 176, 23, 144, 88, 36, 201, 8, 195, 86, 56, 117, 61, 107, 206, 122, 165, 216, 246, 107, 12, 53, 59, 154, 224, 130, 91, 239, 254, 181, 142, 116, 17, 82, 71, 156, 10, 247, 87, 226, 135, 120, 162, 173, 92, 31, 80, 115, 136, 169, 59, 62, 12, 31, 223, 150, 122, 159, 222, 100, 89, 51, 1, 87, 105, 68, 89, 127, 121, 23, 255, 226, 178, 249, 111, 122, 44, 30, 166, 63, 140, 207, 104, 85, 67, 94, 20, 202, 244, 219, 222, 138, 194, 61, 235, 67, 78, 114, 81, 32, 143, 99, 14, 105, 116, 149, 14, 182, 69 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 21, 120, 182, 16, 208, 86, 73, 31, 188, 5, 147, 202, 130, 157, 50, 26, 143, 177, 100, 11, 198, 241, 16, 123, 12, 181, 219, 193, 138, 234, 128, 51, 186, 202, 143, 98, 1, 179, 133, 141, 8, 8, 59, 215, 30, 225, 223, 8, 169, 189, 237, 170, 100, 242, 244, 218, 202, 55, 254, 107, 181, 228, 83 }, new byte[] { 164, 62, 15, 16, 78, 135, 211, 42, 29, 2, 254, 210, 154, 98, 207, 104, 231, 233, 41, 149, 79, 185, 13, 228, 79, 61, 250, 46, 116, 37, 77, 8, 56, 150, 169, 215, 88, 11, 181, 200, 192, 15, 236, 116, 61, 36, 84, 147, 232, 44, 154, 85, 157, 38, 204, 6, 168, 97, 232, 26, 36, 99, 110, 66, 210, 199, 219, 101, 212, 237, 72, 198, 67, 222, 124, 96, 104, 6, 166, 242, 44, 42, 121, 181, 68, 1, 3, 49, 246, 38, 194, 58, 17, 165, 64, 53, 65, 48, 82, 104, 194, 194, 76, 243, 195, 132, 220, 119, 37, 25, 190, 145, 218, 102, 184, 26, 45, 78, 87, 169, 63, 135, 109, 228, 249, 40, 163, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 195, 191, 172, 160, 175, 33, 60, 129, 28, 177, 166, 18, 63, 212, 199, 112, 43, 191, 121, 172, 233, 132, 10, 209, 149, 118, 46, 116, 229, 120, 35, 55, 37, 173, 254, 179, 89, 1, 39, 24, 38, 252, 144, 22, 0, 67, 98, 215, 68, 149, 169, 164, 171, 28, 248, 13, 191, 29, 232, 144, 8, 56, 254 }, new byte[] { 61, 235, 70, 13, 180, 241, 128, 54, 172, 220, 58, 123, 212, 66, 192, 225, 202, 238, 80, 232, 1, 175, 193, 63, 192, 239, 219, 101, 248, 229, 216, 47, 189, 189, 111, 249, 182, 114, 155, 242, 2, 137, 1, 121, 134, 67, 115, 97, 35, 229, 199, 13, 94, 58, 197, 24, 139, 48, 38, 6, 174, 112, 88, 215, 66, 158, 69, 134, 223, 212, 241, 171, 175, 180, 159, 78, 24, 202, 185, 124, 206, 41, 206, 52, 45, 18, 50, 47, 29, 109, 18, 200, 253, 237, 119, 157, 98, 233, 81, 217, 169, 113, 153, 10, 196, 134, 216, 173, 98, 199, 200, 2, 33, 46, 79, 111, 214, 1, 94, 5, 54, 87, 157, 102, 151, 34, 105, 140 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 69, 104, 255, 99, 188, 186, 161, 34, 231, 118, 49, 210, 114, 201, 67, 21, 141, 227, 79, 212, 187, 25, 14, 87, 69, 65, 56, 185, 151, 37, 48, 67, 8, 76, 221, 79, 100, 8, 120, 111, 248, 233, 91, 176, 71, 197, 67, 104, 162, 133, 103, 96, 56, 81, 79, 18, 172, 218, 68, 39, 86, 113, 147 }, new byte[] { 210, 145, 106, 109, 139, 96, 67, 51, 112, 142, 141, 202, 105, 11, 72, 171, 155, 1, 66, 83, 62, 159, 86, 253, 113, 24, 121, 173, 175, 156, 188, 53, 51, 89, 16, 221, 96, 47, 239, 85, 35, 94, 223, 4, 121, 101, 75, 191, 1, 83, 83, 201, 156, 202, 88, 206, 116, 186, 33, 12, 161, 197, 138, 79, 91, 214, 233, 241, 88, 250, 204, 197, 93, 221, 146, 183, 178, 41, 17, 215, 17, 250, 168, 106, 127, 55, 23, 124, 67, 139, 56, 25, 219, 1, 50, 128, 111, 152, 200, 236, 30, 64, 146, 28, 222, 240, 251, 17, 247, 53, 155, 215, 43, 57, 147, 250, 78, 203, 170, 254, 234, 166, 247, 75, 13, 189, 175, 67 } });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_JobId",
                table: "Candidates",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Jobs_JobId",
                table: "Candidates",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Jobs_JobId",
                table: "Users",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }
    }
}
