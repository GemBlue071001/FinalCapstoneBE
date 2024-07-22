﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifyTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "Assessments",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(954), new byte[] { 163, 87, 192, 18, 121, 204, 162, 218, 201, 222, 78, 185, 123, 116, 151, 232, 101, 181, 8, 54, 80, 31, 67, 124, 171, 138, 48, 231, 128, 22, 209, 133, 216, 234, 233, 145, 205, 105, 197, 199, 108, 168, 67, 70, 45, 119, 142, 73, 30, 178, 170, 137, 5, 78, 113, 29, 156, 56, 124, 102, 222, 119, 14, 5 }, new byte[] { 149, 95, 168, 247, 131, 201, 9, 113, 70, 234, 24, 177, 16, 121, 165, 142, 155, 236, 113, 237, 8, 193, 142, 130, 121, 143, 217, 99, 42, 241, 133, 20, 94, 106, 242, 210, 164, 28, 103, 65, 156, 164, 6, 182, 48, 201, 159, 134, 13, 25, 234, 143, 220, 66, 186, 40, 130, 62, 115, 8, 32, 217, 66, 241, 118, 183, 131, 206, 74, 195, 166, 44, 104, 148, 63, 61, 238, 171, 32, 49, 105, 76, 224, 20, 206, 101, 54, 5, 140, 243, 248, 187, 198, 102, 184, 23, 173, 92, 65, 254, 17, 189, 98, 33, 90, 241, 100, 28, 18, 21, 9, 173, 63, 198, 124, 157, 104, 107, 60, 180, 237, 232, 209, 103, 8, 70, 45, 248 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(962), new byte[] { 245, 114, 14, 78, 173, 169, 193, 175, 214, 206, 70, 165, 161, 27, 79, 43, 247, 62, 36, 155, 82, 159, 117, 149, 200, 200, 158, 76, 26, 178, 84, 179, 205, 181, 153, 229, 86, 246, 80, 28, 194, 130, 207, 238, 9, 189, 54, 92, 60, 192, 42, 46, 114, 230, 13, 12, 142, 40, 243, 81, 238, 201, 95, 159 }, new byte[] { 227, 33, 144, 140, 204, 130, 112, 101, 156, 162, 158, 176, 239, 147, 152, 251, 79, 114, 217, 106, 70, 6, 191, 37, 53, 64, 253, 16, 84, 225, 238, 156, 146, 211, 172, 80, 184, 28, 109, 60, 89, 88, 58, 216, 82, 136, 55, 21, 122, 83, 190, 194, 54, 5, 123, 212, 0, 121, 66, 182, 184, 140, 107, 242, 1, 27, 40, 61, 18, 147, 109, 97, 41, 113, 106, 29, 127, 126, 19, 230, 123, 143, 238, 244, 69, 113, 139, 147, 213, 184, 11, 26, 107, 176, 67, 152, 92, 114, 117, 113, 53, 53, 31, 208, 57, 94, 185, 91, 26, 175, 91, 94, 15, 32, 24, 74, 111, 175, 29, 30, 159, 204, 118, 211, 251, 69, 251, 55 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(964), new byte[] { 201, 113, 152, 15, 60, 108, 139, 136, 218, 55, 24, 79, 83, 192, 153, 175, 148, 7, 9, 167, 150, 206, 78, 201, 158, 246, 237, 147, 66, 137, 208, 43, 31, 109, 113, 107, 146, 5, 139, 217, 69, 222, 169, 65, 254, 252, 240, 136, 73, 161, 34, 52, 196, 215, 163, 34, 133, 240, 67, 96, 174, 112, 181, 3 }, new byte[] { 237, 191, 63, 166, 113, 11, 91, 148, 21, 3, 193, 143, 28, 92, 145, 181, 147, 177, 172, 123, 202, 210, 233, 61, 89, 133, 114, 240, 90, 144, 61, 192, 213, 101, 30, 41, 41, 90, 52, 244, 74, 60, 232, 3, 237, 189, 98, 129, 220, 90, 249, 241, 40, 161, 203, 137, 14, 6, 202, 172, 141, 73, 7, 227, 162, 225, 60, 195, 20, 22, 242, 198, 146, 90, 67, 242, 61, 1, 41, 75, 24, 114, 102, 239, 141, 128, 93, 84, 212, 202, 253, 159, 227, 232, 173, 134, 179, 202, 46, 16, 87, 84, 26, 204, 211, 123, 134, 144, 156, 107, 249, 99, 42, 96, 5, 127, 151, 111, 158, 102, 180, 189, 48, 73, 78, 96, 127, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(965), new byte[] { 81, 74, 235, 151, 222, 233, 99, 130, 222, 93, 18, 147, 126, 85, 250, 98, 164, 114, 32, 92, 62, 58, 220, 124, 231, 2, 7, 83, 75, 139, 106, 80, 215, 207, 238, 198, 154, 146, 20, 213, 155, 131, 209, 230, 164, 104, 175, 167, 138, 242, 193, 36, 13, 252, 12, 56, 117, 171, 158, 19, 174, 14, 35, 131 }, new byte[] { 236, 197, 63, 82, 29, 251, 139, 167, 241, 158, 143, 108, 54, 42, 32, 9, 157, 199, 53, 171, 25, 219, 125, 242, 195, 128, 11, 128, 247, 253, 247, 42, 90, 117, 35, 69, 149, 161, 143, 208, 252, 225, 227, 5, 211, 24, 0, 204, 237, 168, 95, 101, 125, 202, 174, 152, 124, 183, 200, 77, 19, 189, 56, 155, 21, 19, 191, 73, 38, 134, 75, 173, 254, 36, 206, 13, 173, 26, 188, 32, 44, 143, 223, 5, 170, 29, 156, 118, 235, 131, 117, 245, 174, 186, 222, 34, 57, 241, 227, 117, 147, 28, 231, 101, 38, 90, 95, 149, 86, 142, 151, 162, 220, 49, 17, 148, 15, 213, 243, 118, 108, 112, 57, 16, 166, 68, 213, 1 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Assessments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 13, 21, 13, 182, DateTimeKind.Utc).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(5964));

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
        }
    }
}