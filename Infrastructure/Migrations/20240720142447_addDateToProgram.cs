﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDateToProgram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "TrainingPrograms",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "TrainingPrograms",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7217), new byte[] { 103, 188, 239, 174, 77, 236, 255, 57, 59, 80, 47, 203, 25, 41, 211, 137, 228, 249, 166, 41, 163, 117, 208, 215, 45, 80, 66, 143, 234, 58, 179, 117, 193, 252, 77, 220, 12, 33, 243, 175, 215, 64, 157, 144, 254, 213, 87, 199, 136, 120, 52, 194, 147, 184, 101, 120, 0, 179, 32, 149, 191, 94, 2, 114 }, new byte[] { 90, 226, 80, 228, 244, 116, 89, 137, 183, 58, 237, 177, 125, 150, 210, 148, 76, 217, 80, 226, 215, 40, 229, 104, 236, 242, 240, 57, 206, 200, 188, 23, 28, 156, 11, 168, 222, 97, 50, 100, 99, 125, 208, 92, 108, 3, 73, 185, 114, 41, 66, 230, 229, 78, 174, 74, 89, 58, 141, 49, 182, 112, 186, 57, 69, 114, 242, 172, 133, 143, 231, 155, 154, 41, 28, 42, 87, 233, 202, 210, 99, 20, 220, 127, 105, 55, 77, 147, 103, 36, 236, 44, 138, 215, 80, 52, 119, 31, 160, 196, 121, 245, 76, 91, 21, 104, 47, 196, 169, 61, 216, 54, 190, 139, 225, 11, 121, 212, 227, 60, 155, 7, 246, 5, 115, 109, 237, 27 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7224), new byte[] { 49, 181, 73, 136, 91, 125, 219, 185, 175, 16, 51, 125, 38, 101, 82, 225, 237, 248, 164, 124, 164, 15, 9, 160, 255, 116, 138, 156, 181, 51, 112, 115, 142, 137, 213, 17, 129, 8, 29, 152, 246, 138, 165, 62, 65, 131, 58, 130, 151, 165, 108, 56, 179, 137, 254, 152, 195, 161, 93, 232, 76, 12, 78, 215 }, new byte[] { 100, 201, 33, 219, 147, 240, 0, 22, 80, 136, 47, 75, 195, 129, 187, 79, 132, 78, 77, 17, 110, 84, 233, 44, 152, 163, 109, 22, 145, 5, 130, 252, 2, 150, 27, 213, 109, 120, 78, 145, 138, 139, 191, 171, 67, 251, 213, 81, 97, 193, 201, 181, 222, 225, 41, 41, 157, 161, 65, 248, 10, 58, 103, 214, 229, 154, 81, 141, 143, 125, 14, 50, 155, 67, 185, 75, 73, 245, 240, 237, 74, 28, 64, 112, 33, 95, 88, 205, 7, 129, 241, 236, 220, 195, 25, 49, 42, 182, 203, 88, 30, 111, 83, 200, 3, 166, 137, 149, 77, 59, 250, 10, 154, 144, 165, 6, 137, 85, 103, 146, 145, 74, 104, 20, 57, 125, 74, 51 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7227), new byte[] { 46, 88, 10, 194, 96, 216, 53, 208, 1, 67, 202, 68, 128, 85, 82, 242, 59, 56, 43, 208, 133, 116, 175, 31, 221, 69, 170, 201, 81, 2, 237, 59, 150, 132, 93, 144, 238, 117, 99, 108, 42, 162, 67, 240, 198, 67, 82, 241, 61, 82, 157, 96, 217, 227, 19, 251, 13, 45, 179, 184, 164, 197, 213, 76 }, new byte[] { 212, 201, 252, 40, 66, 177, 232, 78, 13, 144, 200, 218, 141, 203, 213, 238, 146, 218, 243, 204, 252, 187, 237, 72, 7, 57, 86, 247, 94, 94, 149, 193, 134, 103, 50, 245, 102, 186, 13, 92, 85, 105, 183, 79, 164, 235, 238, 87, 108, 183, 14, 55, 85, 20, 180, 15, 87, 43, 87, 194, 117, 43, 164, 165, 135, 226, 205, 157, 124, 223, 195, 153, 31, 151, 14, 54, 180, 210, 27, 119, 8, 50, 183, 209, 57, 200, 236, 226, 4, 103, 240, 86, 77, 143, 83, 190, 8, 231, 222, 7, 136, 69, 97, 168, 11, 26, 35, 17, 128, 130, 160, 0, 164, 120, 106, 202, 172, 211, 188, 88, 164, 163, 252, 22, 78, 202, 153, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 24, 46, 816, DateTimeKind.Utc).AddTicks(7228), new byte[] { 51, 140, 137, 158, 124, 118, 232, 95, 141, 100, 254, 105, 212, 37, 125, 38, 243, 232, 117, 231, 152, 52, 219, 217, 234, 130, 169, 40, 99, 16, 55, 252, 155, 143, 242, 186, 82, 0, 186, 253, 252, 42, 170, 155, 76, 4, 222, 49, 152, 244, 190, 161, 149, 51, 154, 239, 59, 239, 151, 139, 23, 126, 12, 138 }, new byte[] { 43, 188, 168, 31, 45, 255, 245, 7, 84, 177, 46, 200, 175, 124, 85, 128, 175, 134, 75, 241, 192, 157, 169, 129, 146, 108, 224, 167, 250, 9, 169, 107, 187, 69, 7, 140, 2, 169, 207, 221, 65, 149, 193, 216, 154, 67, 254, 187, 190, 250, 91, 130, 152, 83, 230, 24, 10, 219, 249, 138, 200, 174, 65, 132, 44, 97, 73, 181, 43, 5, 94, 130, 45, 39, 49, 153, 185, 12, 26, 97, 67, 85, 22, 90, 22, 78, 219, 84, 99, 243, 238, 82, 64, 75, 11, 74, 175, 73, 178, 253, 181, 240, 0, 186, 127, 177, 56, 193, 187, 224, 189, 5, 204, 201, 249, 211, 158, 19, 34, 165, 128, 250, 151, 237, 106, 202, 46, 249 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "TrainingPrograms");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 59, 42, 496, DateTimeKind.Utc).AddTicks(6758), new byte[] { 131, 168, 140, 104, 62, 255, 77, 220, 38, 34, 151, 42, 235, 219, 32, 252, 66, 68, 242, 238, 88, 60, 154, 251, 66, 117, 225, 201, 104, 205, 127, 25, 113, 64, 78, 157, 53, 123, 203, 216, 181, 246, 100, 21, 221, 250, 18, 126, 119, 129, 162, 114, 164, 129, 62, 194, 146, 107, 216, 60, 101, 74, 107, 244 }, new byte[] { 229, 165, 231, 72, 168, 232, 26, 224, 119, 206, 85, 122, 37, 183, 82, 33, 73, 233, 41, 0, 60, 84, 167, 224, 65, 22, 249, 36, 53, 101, 208, 83, 36, 19, 161, 215, 253, 92, 137, 240, 99, 11, 176, 154, 140, 46, 143, 145, 148, 96, 82, 178, 58, 102, 54, 180, 201, 219, 109, 72, 119, 173, 151, 106, 30, 64, 250, 212, 219, 232, 254, 221, 129, 230, 4, 162, 180, 173, 75, 66, 29, 61, 14, 11, 39, 37, 251, 241, 25, 114, 43, 188, 204, 71, 121, 235, 72, 85, 234, 251, 227, 211, 162, 59, 162, 49, 177, 91, 10, 11, 123, 212, 102, 172, 231, 90, 229, 83, 146, 235, 5, 0, 99, 107, 189, 189, 54, 228 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 59, 42, 496, DateTimeKind.Utc).AddTicks(6768), new byte[] { 112, 159, 19, 140, 132, 9, 230, 90, 13, 95, 201, 94, 38, 231, 253, 247, 156, 25, 66, 59, 233, 30, 131, 182, 239, 16, 233, 92, 140, 71, 248, 23, 69, 44, 85, 90, 233, 54, 136, 203, 229, 46, 180, 3, 158, 64, 159, 76, 73, 108, 204, 194, 184, 21, 229, 68, 93, 159, 6, 225, 66, 87, 81, 85 }, new byte[] { 247, 85, 176, 173, 99, 255, 133, 154, 161, 120, 106, 18, 184, 102, 114, 161, 224, 133, 90, 36, 165, 2, 176, 197, 75, 164, 223, 50, 178, 4, 130, 208, 238, 91, 117, 20, 169, 136, 200, 11, 156, 133, 9, 61, 84, 83, 69, 112, 135, 96, 222, 143, 160, 60, 240, 59, 24, 251, 236, 23, 70, 168, 235, 33, 140, 190, 145, 122, 146, 247, 79, 108, 153, 154, 51, 24, 65, 160, 44, 47, 166, 136, 102, 122, 245, 88, 203, 76, 239, 67, 150, 124, 92, 91, 76, 145, 224, 159, 35, 133, 119, 228, 121, 72, 62, 6, 230, 26, 214, 251, 172, 166, 244, 121, 65, 235, 47, 193, 148, 199, 106, 0, 112, 253, 148, 193, 170, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 59, 42, 496, DateTimeKind.Utc).AddTicks(6769), new byte[] { 204, 226, 228, 125, 6, 87, 214, 61, 173, 254, 228, 195, 221, 96, 158, 53, 118, 155, 250, 51, 26, 90, 148, 100, 177, 132, 245, 217, 64, 152, 30, 29, 78, 115, 68, 23, 10, 138, 129, 21, 192, 119, 190, 183, 133, 241, 30, 197, 154, 120, 76, 124, 152, 218, 67, 122, 176, 66, 207, 60, 108, 221, 160, 117 }, new byte[] { 66, 235, 224, 97, 196, 119, 121, 159, 27, 153, 99, 0, 161, 212, 43, 109, 213, 241, 90, 50, 7, 235, 232, 38, 132, 35, 64, 243, 5, 178, 181, 150, 181, 240, 212, 78, 54, 185, 27, 46, 210, 1, 42, 133, 162, 124, 26, 212, 156, 175, 246, 90, 36, 6, 119, 140, 55, 148, 248, 156, 125, 156, 236, 27, 201, 220, 40, 25, 215, 76, 119, 55, 31, 170, 241, 26, 209, 121, 217, 142, 134, 208, 254, 1, 144, 212, 203, 128, 199, 125, 252, 192, 127, 49, 109, 221, 51, 209, 23, 241, 237, 49, 234, 245, 201, 130, 245, 189, 86, 189, 152, 21, 218, 211, 182, 143, 209, 237, 85, 36, 214, 13, 30, 3, 30, 209, 91, 214 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 59, 42, 496, DateTimeKind.Utc).AddTicks(6771), new byte[] { 1, 239, 148, 199, 241, 254, 26, 70, 225, 190, 136, 142, 206, 1, 253, 13, 125, 179, 96, 146, 20, 235, 209, 186, 104, 47, 89, 47, 130, 120, 111, 230, 195, 85, 191, 187, 225, 211, 46, 240, 223, 152, 123, 215, 31, 237, 69, 205, 181, 152, 10, 253, 0, 130, 213, 97, 186, 88, 44, 152, 43, 148, 11, 21 }, new byte[] { 181, 77, 219, 10, 95, 123, 211, 172, 191, 97, 125, 182, 32, 211, 196, 191, 116, 247, 172, 219, 54, 201, 15, 157, 87, 161, 218, 23, 56, 204, 45, 41, 178, 79, 53, 140, 190, 196, 233, 136, 159, 121, 40, 160, 75, 167, 249, 143, 235, 103, 200, 209, 214, 147, 20, 15, 113, 138, 20, 114, 126, 83, 215, 149, 21, 63, 174, 253, 144, 32, 184, 65, 63, 131, 43, 20, 181, 46, 51, 76, 43, 247, 129, 42, 13, 71, 155, 15, 212, 59, 111, 116, 154, 176, 11, 212, 112, 3, 181, 124, 193, 234, 164, 118, 138, 132, 160, 161, 139, 112, 5, 203, 231, 146, 184, 95, 84, 194, 138, 192, 203, 115, 180, 11, 25, 122, 89, 183 } });
        }
    }
}
