﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstimateTime = table.Column<int>(type: "integer", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActualTime = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 229, 104, 183, 154, 203, 17, 220, 61, 86, 23, 103, 117, 119, 201, 245, 220, 139, 103, 171, 78, 100, 199, 31, 6, 253, 92, 10, 115, 79, 166, 25, 48, 220, 182, 207, 158, 10, 231, 244, 3, 246, 163, 119, 13, 34, 253, 237, 212, 76, 3, 27, 144, 116, 10, 68, 231, 73, 176, 9, 111, 63, 53, 207 }, new byte[] { 142, 165, 203, 252, 127, 185, 0, 143, 65, 80, 1, 108, 76, 138, 162, 19, 116, 134, 25, 50, 201, 60, 152, 172, 106, 199, 249, 16, 97, 238, 150, 168, 163, 17, 146, 186, 237, 167, 231, 233, 55, 139, 143, 176, 73, 10, 6, 7, 31, 250, 163, 79, 4, 68, 109, 115, 206, 69, 107, 171, 14, 139, 123, 165, 66, 113, 44, 129, 113, 210, 241, 147, 53, 85, 155, 250, 196, 178, 212, 147, 169, 164, 8, 3, 186, 69, 58, 11, 255, 249, 64, 161, 231, 149, 80, 171, 72, 116, 152, 181, 108, 191, 233, 44, 116, 146, 39, 126, 81, 11, 132, 142, 183, 117, 111, 15, 212, 93, 155, 73, 112, 28, 51, 142, 33, 90, 234, 48 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 196, 230, 104, 2, 220, 162, 18, 193, 241, 110, 54, 0, 151, 155, 52, 79, 248, 39, 48, 123, 171, 37, 98, 241, 123, 222, 48, 71, 2, 151, 139, 73, 171, 215, 67, 185, 176, 187, 71, 49, 50, 217, 50, 116, 182, 243, 89, 173, 197, 43, 180, 54, 172, 56, 19, 25, 18, 46, 12, 155, 33, 178, 51, 10 }, new byte[] { 32, 119, 215, 96, 144, 32, 76, 75, 77, 162, 152, 197, 219, 62, 46, 94, 203, 213, 95, 189, 17, 7, 184, 117, 99, 231, 163, 191, 106, 62, 5, 137, 42, 87, 190, 46, 232, 249, 127, 26, 128, 109, 42, 128, 149, 240, 106, 249, 177, 115, 63, 33, 188, 148, 226, 10, 117, 132, 87, 119, 141, 120, 173, 11, 170, 235, 89, 138, 159, 198, 124, 90, 183, 36, 179, 47, 107, 17, 78, 55, 234, 17, 123, 43, 129, 51, 30, 231, 61, 86, 134, 160, 194, 182, 65, 7, 47, 219, 38, 174, 24, 237, 160, 224, 132, 143, 241, 106, 91, 197, 239, 216, 183, 90, 87, 4, 190, 188, 17, 26, 44, 147, 198, 197, 137, 19, 158, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 26, 46, 217, 126, 8, 83, 241, 145, 53, 155, 168, 14, 65, 19, 218, 18, 202, 227, 117, 189, 121, 69, 133, 104, 97, 208, 165, 80, 194, 94, 202, 132, 18, 90, 18, 198, 82, 140, 139, 21, 166, 61, 25, 53, 140, 52, 146, 31, 148, 46, 244, 108, 71, 2, 48, 12, 136, 207, 216, 59, 211, 207, 69 }, new byte[] { 48, 25, 45, 209, 29, 126, 151, 155, 37, 172, 179, 6, 153, 118, 183, 122, 205, 133, 2, 28, 252, 162, 183, 173, 216, 183, 219, 80, 244, 146, 17, 130, 80, 63, 196, 127, 78, 131, 167, 217, 21, 228, 196, 231, 127, 140, 243, 181, 124, 8, 80, 119, 115, 116, 188, 173, 97, 67, 211, 45, 37, 154, 194, 99, 89, 128, 228, 93, 9, 59, 212, 119, 211, 215, 82, 203, 173, 27, 42, 220, 172, 195, 88, 81, 119, 198, 128, 33, 245, 67, 81, 26, 31, 36, 58, 169, 2, 13, 52, 120, 176, 203, 248, 1, 66, 192, 211, 67, 164, 156, 118, 141, 109, 168, 73, 105, 172, 63, 247, 58, 62, 39, 93, 32, 248, 231, 181, 26 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 91, 4, 189, 212, 244, 150, 190, 103, 168, 35, 51, 45, 81, 168, 106, 33, 16, 240, 251, 126, 121, 15, 138, 167, 223, 71, 233, 28, 170, 187, 136, 173, 101, 24, 151, 240, 20, 247, 175, 176, 43, 131, 18, 131, 158, 4, 34, 145, 164, 128, 190, 26, 130, 77, 174, 195, 45, 85, 192, 92, 126, 140, 81 }, new byte[] { 143, 220, 177, 58, 217, 155, 249, 190, 12, 66, 220, 27, 230, 92, 253, 141, 161, 147, 163, 26, 104, 87, 179, 218, 252, 151, 80, 212, 229, 168, 10, 130, 113, 157, 79, 95, 125, 55, 228, 36, 186, 57, 251, 15, 35, 172, 110, 119, 41, 82, 14, 152, 228, 232, 52, 60, 25, 56, 108, 160, 226, 103, 20, 103, 255, 145, 15, 37, 73, 138, 97, 50, 109, 67, 145, 234, 166, 189, 166, 80, 49, 145, 135, 9, 245, 76, 14, 170, 21, 77, 215, 70, 156, 171, 110, 100, 135, 49, 168, 186, 24, 7, 0, 211, 220, 255, 209, 108, 255, 132, 65, 242, 0, 45, 24, 13, 65, 105, 67, 151, 52, 137, 243, 42, 88, 9, 59, 219 } });

            migrationBuilder.CreateIndex(
                name: "IX_Task_UserId",
                table: "Task",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 12, 101, 46, 94, 157, 58, 197, 17, 77, 118, 88, 171, 98, 25, 44, 181, 96, 191, 107, 237, 66, 236, 42, 213, 186, 166, 223, 2, 160, 91, 84, 122, 33, 222, 109, 155, 252, 209, 21, 143, 72, 80, 134, 227, 136, 136, 123, 131, 56, 194, 7, 242, 67, 238, 192, 105, 191, 198, 91, 149, 252, 67, 99 }, new byte[] { 129, 12, 15, 109, 252, 92, 64, 35, 221, 32, 173, 136, 122, 145, 4, 229, 218, 77, 109, 235, 24, 235, 24, 248, 13, 13, 194, 65, 14, 198, 17, 227, 211, 101, 170, 120, 213, 28, 3, 34, 249, 203, 204, 58, 227, 219, 18, 54, 63, 165, 92, 189, 222, 214, 30, 209, 13, 161, 75, 45, 25, 145, 193, 186, 226, 232, 161, 187, 107, 140, 148, 179, 198, 132, 89, 239, 34, 167, 180, 193, 243, 61, 84, 243, 185, 147, 234, 250, 32, 220, 217, 126, 219, 167, 195, 188, 14, 153, 217, 216, 178, 150, 190, 16, 236, 210, 224, 149, 248, 125, 145, 239, 157, 86, 35, 236, 186, 46, 39, 247, 92, 134, 153, 188, 253, 93, 99, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 42, 92, 218, 109, 44, 198, 117, 146, 232, 47, 92, 154, 98, 186, 71, 159, 75, 63, 139, 24, 158, 32, 9, 185, 95, 104, 120, 140, 107, 60, 252, 106, 253, 164, 109, 159, 168, 82, 24, 91, 98, 116, 34, 242, 31, 231, 65, 160, 106, 46, 146, 58, 19, 127, 185, 23, 237, 117, 195, 160, 124, 74, 74 }, new byte[] { 81, 136, 155, 216, 198, 241, 225, 34, 25, 110, 220, 220, 243, 204, 94, 89, 206, 235, 92, 198, 188, 205, 198, 143, 155, 127, 194, 25, 83, 147, 42, 62, 35, 184, 227, 193, 205, 138, 64, 249, 8, 67, 57, 25, 176, 31, 141, 136, 76, 165, 241, 175, 93, 237, 118, 144, 218, 145, 3, 160, 88, 205, 88, 157, 131, 115, 92, 115, 114, 183, 63, 39, 174, 35, 107, 12, 243, 138, 141, 57, 82, 146, 15, 47, 165, 80, 32, 185, 106, 200, 106, 206, 216, 11, 150, 67, 247, 195, 65, 120, 243, 238, 1, 92, 63, 207, 163, 65, 160, 109, 55, 176, 104, 121, 132, 202, 201, 59, 76, 212, 16, 98, 128, 117, 22, 238, 121, 40 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 179, 22, 188, 208, 86, 112, 166, 182, 112, 42, 202, 0, 141, 46, 18, 251, 116, 53, 88, 2, 233, 185, 123, 141, 118, 175, 154, 1, 21, 203, 163, 14, 232, 121, 175, 7, 173, 0, 123, 248, 136, 252, 18, 52, 50, 186, 53, 177, 89, 253, 161, 112, 190, 113, 142, 63, 63, 214, 120, 172, 22, 161, 105 }, new byte[] { 33, 76, 79, 27, 30, 86, 127, 67, 71, 165, 162, 48, 159, 146, 38, 52, 58, 100, 60, 225, 222, 78, 149, 11, 107, 211, 55, 175, 208, 58, 193, 48, 106, 148, 245, 164, 179, 127, 239, 44, 198, 147, 217, 49, 208, 123, 30, 160, 205, 103, 224, 195, 157, 107, 2, 178, 250, 125, 248, 17, 204, 138, 251, 9, 199, 32, 111, 196, 133, 208, 71, 111, 203, 65, 125, 178, 125, 239, 179, 13, 170, 180, 15, 239, 31, 42, 34, 129, 209, 151, 144, 65, 31, 30, 89, 108, 7, 53, 249, 170, 114, 151, 175, 213, 234, 0, 171, 31, 191, 133, 45, 115, 127, 144, 92, 87, 211, 67, 32, 46, 134, 90, 198, 19, 43, 215, 93, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 50, 37, 200, 40, 169, 240, 25, 223, 140, 55, 142, 197, 37, 46, 64, 180, 33, 205, 30, 187, 40, 5, 231, 48, 85, 119, 49, 232, 52, 34, 233, 133, 84, 230, 78, 46, 123, 234, 184, 24, 121, 82, 59, 242, 103, 188, 241, 124, 57, 152, 77, 78, 113, 73, 147, 216, 164, 53, 165, 163, 176, 249, 182 }, new byte[] { 191, 97, 85, 190, 96, 26, 86, 31, 17, 191, 100, 18, 39, 30, 192, 213, 148, 102, 9, 195, 214, 255, 250, 249, 213, 71, 108, 65, 61, 198, 151, 33, 41, 87, 229, 11, 49, 233, 36, 254, 31, 225, 12, 201, 126, 49, 162, 17, 129, 172, 122, 72, 230, 203, 135, 218, 220, 16, 241, 14, 144, 88, 75, 50, 79, 225, 170, 107, 193, 50, 105, 123, 233, 22, 47, 150, 35, 253, 7, 108, 18, 197, 138, 223, 28, 250, 217, 197, 114, 214, 221, 158, 119, 169, 85, 34, 152, 86, 39, 10, 224, 234, 197, 14, 61, 125, 90, 103, 199, 130, 122, 5, 8, 207, 99, 103, 15, 100, 84, 51, 164, 45, 236, 56, 131, 90, 47, 154 } });
        }
    }
}