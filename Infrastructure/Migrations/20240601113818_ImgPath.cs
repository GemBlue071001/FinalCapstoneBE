using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImgPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TrainingPrograms",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeOfWork",
                table: "TrainingPrograms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Requirements",
                table: "TrainingPrograms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "TrainingPrograms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "TrainingPrograms",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScopeOfWork",
                table: "Campaigns",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Requirements",
                table: "Campaigns",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Campaigns",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 144, 164, 171, 15, 171, 219, 120, 216, 196, 128, 41, 86, 103, 246, 192, 184, 65, 133, 171, 188, 217, 56, 110, 149, 196, 98, 71, 148, 7, 253, 248, 208, 248, 204, 21, 141, 225, 41, 75, 131, 191, 119, 24, 16, 56, 80, 96, 145, 41, 127, 90, 191, 131, 244, 242, 243, 111, 91, 168, 129, 158, 1, 206, 37 }, new byte[] { 154, 16, 47, 172, 193, 45, 243, 127, 178, 191, 192, 60, 23, 218, 255, 18, 36, 160, 85, 249, 195, 15, 254, 147, 242, 27, 45, 72, 209, 184, 144, 105, 128, 5, 113, 84, 12, 7, 42, 11, 195, 79, 216, 134, 119, 22, 252, 155, 79, 15, 201, 120, 195, 171, 156, 200, 113, 74, 18, 92, 251, 1, 83, 163, 23, 49, 126, 215, 199, 204, 101, 241, 232, 32, 229, 24, 105, 49, 214, 232, 131, 37, 23, 95, 129, 62, 139, 118, 44, 180, 154, 43, 133, 217, 76, 84, 52, 216, 94, 43, 29, 199, 118, 195, 72, 7, 214, 207, 50, 182, 133, 165, 156, 145, 103, 147, 85, 222, 210, 116, 63, 27, 77, 55, 34, 219, 214, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 158, 227, 79, 68, 196, 94, 229, 245, 6, 167, 117, 1, 210, 235, 219, 96, 74, 148, 75, 7, 1, 208, 114, 144, 212, 78, 126, 151, 13, 83, 83, 191, 91, 197, 170, 81, 40, 42, 136, 161, 146, 63, 18, 147, 102, 99, 102, 85, 136, 211, 240, 87, 45, 193, 247, 229, 1, 216, 87, 86, 225, 112, 168 }, new byte[] { 227, 77, 37, 236, 110, 84, 211, 115, 161, 255, 137, 161, 56, 96, 37, 45, 173, 50, 2, 18, 126, 81, 5, 2, 65, 124, 72, 112, 143, 210, 122, 63, 246, 92, 219, 183, 116, 1, 214, 7, 22, 125, 40, 230, 14, 178, 66, 157, 171, 80, 7, 81, 171, 24, 55, 134, 166, 190, 78, 54, 189, 37, 157, 205, 155, 189, 157, 148, 177, 183, 254, 194, 111, 156, 48, 35, 224, 222, 74, 129, 76, 173, 227, 131, 105, 121, 45, 58, 191, 152, 7, 110, 253, 112, 179, 124, 244, 35, 147, 232, 142, 203, 204, 88, 41, 36, 97, 240, 70, 171, 100, 221, 224, 5, 245, 234, 161, 53, 250, 227, 1, 248, 47, 245, 235, 162, 104, 86 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 109, 169, 197, 21, 242, 91, 201, 188, 174, 10, 168, 224, 234, 132, 107, 111, 18, 179, 12, 217, 116, 116, 183, 92, 107, 252, 196, 35, 41, 209, 39, 167, 72, 16, 126, 239, 84, 255, 76, 175, 160, 243, 3, 56, 87, 54, 220, 73, 62, 50, 117, 83, 210, 85, 48, 178, 231, 99, 248, 85, 177, 228, 131 }, new byte[] { 134, 54, 197, 75, 183, 159, 21, 94, 217, 88, 155, 111, 237, 188, 25, 110, 73, 149, 112, 126, 119, 0, 244, 100, 137, 69, 11, 190, 90, 186, 102, 243, 5, 125, 83, 93, 228, 203, 95, 18, 229, 225, 65, 254, 253, 245, 218, 62, 98, 220, 149, 5, 115, 7, 49, 181, 250, 62, 6, 13, 178, 129, 59, 187, 235, 144, 42, 65, 94, 130, 33, 37, 73, 68, 177, 164, 44, 74, 51, 2, 154, 141, 70, 8, 50, 38, 51, 235, 102, 102, 43, 59, 56, 197, 139, 84, 157, 46, 58, 41, 231, 160, 54, 61, 173, 53, 57, 86, 33, 103, 117, 129, 57, 151, 195, 233, 159, 229, 56, 74, 16, 83, 118, 255, 62, 206, 14, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 99, 69, 134, 19, 12, 154, 4, 24, 160, 62, 72, 203, 220, 153, 188, 190, 156, 79, 210, 61, 219, 232, 204, 71, 15, 32, 195, 106, 186, 164, 190, 252, 231, 142, 136, 221, 167, 109, 249, 142, 159, 252, 197, 209, 188, 103, 43, 230, 234, 187, 64, 229, 131, 93, 31, 18, 58, 7, 10, 32, 220, 191, 221 }, new byte[] { 133, 227, 90, 198, 89, 90, 126, 53, 54, 146, 252, 237, 39, 223, 193, 70, 61, 123, 173, 9, 241, 195, 82, 65, 115, 229, 108, 104, 91, 255, 15, 86, 230, 151, 208, 200, 118, 123, 36, 158, 226, 247, 237, 78, 209, 49, 115, 239, 0, 252, 211, 156, 173, 225, 124, 16, 108, 22, 145, 251, 73, 11, 70, 142, 0, 11, 153, 233, 75, 85, 205, 24, 87, 43, 114, 70, 179, 112, 187, 31, 175, 218, 156, 172, 143, 81, 115, 2, 216, 165, 24, 81, 203, 212, 253, 151, 245, 153, 64, 89, 235, 134, 81, 111, 245, 176, 35, 26, 38, 228, 171, 27, 63, 210, 106, 165, 218, 60, 120, 190, 125, 91, 166, 58, 17, 105, 31, 157 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Campaigns");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "TrainingPrograms",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScopeOfWork",
                table: "TrainingPrograms",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Requirements",
                table: "TrainingPrograms",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Benefits",
                table: "TrainingPrograms",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScopeOfWork",
                table: "Campaigns",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Requirements",
                table: "Campaigns",
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
                values: new object[] { new byte[] { 105, 215, 141, 246, 143, 177, 8, 132, 97, 35, 83, 161, 12, 114, 226, 157, 254, 121, 196, 143, 218, 74, 216, 121, 130, 60, 167, 64, 231, 198, 208, 252, 25, 104, 182, 85, 144, 36, 53, 248, 44, 54, 172, 5, 165, 144, 121, 19, 74, 5, 133, 23, 14, 180, 123, 212, 81, 157, 20, 164, 104, 255, 34, 100 }, new byte[] { 13, 109, 162, 195, 222, 109, 130, 99, 222, 196, 147, 138, 61, 101, 66, 19, 127, 229, 61, 16, 177, 17, 127, 110, 33, 119, 77, 186, 119, 250, 135, 39, 237, 11, 251, 152, 39, 101, 52, 83, 129, 144, 64, 120, 252, 120, 68, 27, 158, 54, 36, 79, 70, 139, 156, 45, 1, 137, 95, 109, 37, 128, 115, 11, 102, 154, 13, 26, 200, 119, 163, 56, 16, 155, 249, 236, 23, 146, 31, 158, 247, 190, 212, 225, 199, 246, 172, 158, 89, 214, 20, 208, 251, 255, 81, 45, 218, 14, 125, 19, 40, 216, 35, 84, 147, 204, 130, 220, 193, 158, 131, 96, 230, 69, 189, 190, 63, 116, 82, 165, 183, 119, 83, 114, 195, 211, 94, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 138, 103, 181, 107, 132, 151, 99, 211, 236, 66, 194, 128, 241, 65, 150, 31, 151, 244, 115, 224, 157, 186, 62, 122, 191, 150, 124, 196, 197, 96, 143, 228, 246, 80, 127, 126, 51, 156, 213, 181, 129, 188, 28, 252, 181, 12, 166, 116, 4, 103, 91, 77, 87, 198, 64, 156, 74, 213, 214, 57, 152, 12, 121 }, new byte[] { 74, 184, 155, 143, 179, 151, 28, 75, 242, 6, 42, 7, 102, 9, 203, 118, 132, 247, 139, 152, 25, 43, 4, 76, 124, 31, 228, 233, 112, 188, 251, 192, 230, 82, 156, 230, 167, 110, 172, 83, 43, 37, 25, 118, 233, 183, 135, 35, 87, 15, 103, 206, 176, 160, 7, 217, 225, 117, 67, 228, 221, 169, 183, 198, 224, 212, 87, 155, 29, 125, 223, 179, 210, 4, 173, 244, 136, 38, 187, 209, 122, 132, 237, 122, 24, 109, 178, 216, 77, 159, 67, 50, 36, 36, 219, 197, 191, 176, 37, 83, 144, 215, 233, 16, 232, 38, 33, 86, 130, 247, 230, 241, 96, 17, 19, 215, 151, 213, 169, 2, 244, 2, 236, 88, 55, 166, 186, 215 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 209, 190, 248, 199, 244, 144, 164, 195, 187, 241, 103, 114, 124, 190, 162, 11, 121, 117, 11, 195, 52, 205, 175, 222, 83, 222, 164, 109, 124, 214, 139, 46, 81, 42, 253, 190, 223, 199, 45, 56, 139, 249, 24, 83, 94, 101, 131, 74, 237, 49, 10, 82, 61, 29, 62, 73, 45, 151, 194, 32, 201, 34, 194, 37 }, new byte[] { 158, 1, 198, 60, 81, 46, 149, 35, 25, 235, 180, 75, 146, 168, 207, 10, 145, 157, 211, 101, 251, 213, 65, 42, 90, 234, 52, 247, 78, 76, 44, 51, 29, 140, 125, 1, 178, 145, 178, 180, 140, 121, 27, 10, 123, 175, 233, 12, 217, 114, 232, 236, 144, 229, 195, 160, 126, 231, 119, 57, 160, 57, 143, 137, 192, 21, 71, 224, 67, 82, 128, 76, 5, 2, 11, 68, 55, 204, 169, 247, 82, 209, 79, 8, 169, 147, 217, 144, 147, 2, 212, 155, 50, 216, 165, 111, 182, 22, 103, 218, 109, 175, 54, 147, 82, 58, 129, 115, 197, 32, 127, 170, 226, 141, 212, 78, 117, 58, 6, 170, 140, 32, 129, 129, 162, 190, 6, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 231, 89, 11, 6, 21, 190, 108, 76, 71, 180, 125, 145, 105, 173, 60, 190, 168, 108, 2, 150, 202, 35, 44, 137, 3, 65, 85, 67, 167, 240, 108, 41, 205, 234, 139, 85, 110, 110, 201, 133, 29, 124, 168, 147, 38, 52, 8, 204, 167, 129, 40, 117, 68, 40, 91, 172, 212, 93, 94, 49, 44, 146, 201, 190 }, new byte[] { 106, 253, 41, 87, 183, 56, 114, 164, 73, 231, 184, 162, 92, 51, 35, 156, 133, 242, 151, 81, 206, 73, 42, 39, 94, 244, 250, 59, 255, 200, 130, 125, 157, 164, 77, 96, 121, 195, 194, 99, 232, 57, 145, 210, 56, 10, 255, 210, 175, 202, 71, 91, 63, 158, 228, 186, 36, 200, 235, 254, 241, 139, 6, 255, 105, 242, 11, 38, 124, 121, 131, 221, 217, 225, 74, 233, 192, 205, 97, 31, 42, 206, 164, 234, 68, 87, 136, 73, 250, 51, 220, 147, 73, 213, 237, 209, 160, 109, 28, 23, 241, 17, 170, 65, 79, 46, 211, 181, 141, 175, 158, 133, 157, 230, 9, 195, 42, 100, 216, 230, 13, 48, 11, 217, 17, 47, 197, 242 } });
        }
    }
}
