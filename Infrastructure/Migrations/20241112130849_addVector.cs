using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Pgvector;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vector",
                table: "JobPosts");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:vector", ",,");

            migrationBuilder.AddColumn<Vector>(
                name: "Embedding",
                table: "JobPosts",
                type: "vector(500)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 484, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 484, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 13, 8, 49, 484, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(1741), new byte[] { 143, 173, 235, 194, 130, 181, 149, 138, 233, 79, 186, 196, 118, 74, 208, 39, 53, 192, 87, 190, 27, 47, 179, 19, 3, 1, 83, 214, 2, 50, 210, 90, 118, 182, 64, 121, 207, 187, 225, 146, 227, 91, 35, 22, 68, 33, 169, 251, 251, 193, 102, 151, 233, 177, 67, 251, 114, 97, 85, 146, 218, 60, 173, 6 }, new byte[] { 151, 180, 0, 52, 1, 218, 15, 138, 94, 199, 63, 215, 126, 47, 40, 202, 42, 176, 92, 58, 2, 87, 33, 202, 50, 174, 44, 70, 61, 220, 108, 238, 23, 199, 28, 195, 5, 105, 35, 0, 205, 220, 44, 58, 125, 231, 233, 176, 238, 165, 111, 25, 11, 65, 237, 225, 23, 115, 143, 36, 29, 80, 201, 198, 179, 12, 213, 246, 127, 153, 105, 220, 180, 171, 38, 207, 150, 20, 28, 251, 53, 212, 24, 76, 110, 195, 158, 173, 63, 101, 28, 11, 212, 183, 55, 206, 40, 118, 66, 128, 177, 100, 72, 113, 82, 80, 158, 244, 192, 87, 86, 245, 158, 213, 184, 216, 204, 24, 244, 168, 13, 255, 122, 156, 27, 148, 107, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(1752), new byte[] { 63, 36, 144, 243, 255, 129, 187, 178, 141, 36, 191, 28, 0, 46, 173, 44, 190, 19, 220, 85, 55, 96, 225, 166, 77, 205, 104, 42, 84, 163, 143, 66, 240, 203, 108, 235, 48, 32, 23, 202, 177, 2, 169, 45, 91, 163, 25, 142, 202, 177, 43, 15, 181, 119, 77, 87, 99, 134, 13, 11, 245, 95, 6, 16 }, new byte[] { 82, 31, 185, 156, 228, 219, 142, 186, 24, 73, 216, 51, 153, 80, 173, 130, 93, 218, 75, 192, 243, 171, 192, 108, 9, 140, 24, 223, 57, 50, 216, 109, 71, 171, 221, 140, 76, 70, 247, 77, 131, 90, 171, 180, 93, 97, 124, 206, 220, 151, 191, 202, 219, 13, 138, 234, 101, 183, 152, 147, 112, 24, 254, 94, 62, 249, 86, 231, 82, 0, 194, 72, 115, 194, 28, 238, 99, 99, 223, 107, 69, 81, 70, 93, 52, 11, 208, 112, 246, 240, 185, 254, 223, 122, 246, 211, 178, 119, 157, 158, 137, 149, 133, 165, 51, 249, 140, 225, 117, 130, 27, 206, 95, 28, 0, 58, 203, 211, 33, 145, 205, 10, 79, 68, 203, 253, 188, 253 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(1754), new byte[] { 71, 54, 10, 78, 11, 75, 217, 113, 157, 11, 68, 6, 107, 232, 78, 158, 198, 49, 111, 120, 143, 224, 140, 129, 101, 203, 51, 4, 36, 229, 14, 133, 202, 218, 227, 152, 202, 97, 176, 246, 81, 82, 135, 65, 106, 30, 36, 4, 121, 178, 95, 117, 78, 35, 242, 86, 252, 38, 27, 105, 225, 193, 94, 221 }, new byte[] { 129, 76, 247, 176, 143, 241, 114, 73, 73, 15, 93, 179, 46, 19, 111, 254, 21, 130, 78, 55, 179, 121, 112, 206, 44, 72, 200, 105, 31, 196, 199, 169, 218, 53, 147, 74, 119, 187, 239, 62, 20, 23, 241, 29, 204, 127, 148, 103, 105, 182, 235, 111, 235, 217, 20, 79, 95, 110, 139, 74, 42, 221, 36, 78, 16, 223, 37, 224, 157, 186, 186, 49, 183, 64, 122, 234, 33, 254, 175, 100, 39, 51, 249, 193, 201, 28, 243, 18, 211, 34, 10, 132, 13, 171, 251, 201, 84, 228, 17, 149, 126, 165, 3, 225, 193, 59, 238, 119, 175, 6, 96, 125, 207, 176, 186, 67, 30, 168, 23, 181, 63, 159, 242, 80, 139, 233, 92, 25 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 12, 13, 8, 49, 482, DateTimeKind.Utc).AddTicks(1755), new byte[] { 95, 85, 150, 188, 162, 161, 113, 92, 125, 174, 251, 207, 46, 227, 223, 83, 213, 17, 223, 7, 204, 17, 240, 226, 50, 175, 94, 1, 89, 97, 223, 110, 233, 254, 125, 229, 186, 81, 131, 179, 121, 237, 227, 23, 181, 2, 180, 39, 133, 229, 28, 86, 205, 55, 63, 17, 149, 102, 114, 137, 64, 26, 104, 146 }, new byte[] { 190, 93, 175, 209, 118, 202, 24, 104, 217, 204, 136, 33, 127, 113, 119, 154, 198, 26, 155, 155, 110, 171, 84, 90, 90, 99, 208, 38, 120, 215, 16, 35, 20, 104, 131, 34, 167, 53, 56, 43, 97, 135, 133, 138, 198, 11, 3, 205, 167, 89, 24, 168, 205, 106, 143, 167, 27, 85, 207, 30, 21, 59, 22, 227, 153, 82, 47, 168, 195, 113, 224, 13, 76, 107, 139, 41, 83, 221, 119, 186, 118, 245, 190, 210, 235, 104, 73, 95, 233, 214, 28, 138, 150, 181, 207, 83, 230, 221, 147, 149, 144, 60, 183, 181, 30, 228, 37, 230, 126, 188, 16, 122, 222, 112, 53, 118, 100, 98, 102, 153, 82, 141, 4, 170, 174, 205, 68, 104 } });

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_Embedding",
                table: "JobPosts",
                column: "Embedding")
                .Annotation("Npgsql:IndexMethod", "hnsw")
                .Annotation("Npgsql:IndexOperators", new[] { "vector_l2_ops" })
                .Annotation("Npgsql:StorageParameter:ef_construction", 64)
                .Annotation("Npgsql:StorageParameter:m", 16);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobPosts_Embedding",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Embedding",
                table: "JobPosts");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:vector", ",,");

            migrationBuilder.AddColumn<float[]>(
                name: "Vector",
                table: "JobPosts",
                type: "real[]",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 264, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 264, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 11, 16, 25, 22, 265, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7553), new byte[] { 98, 129, 80, 32, 90, 105, 248, 199, 94, 0, 79, 40, 144, 70, 90, 49, 124, 15, 132, 251, 216, 159, 49, 123, 185, 86, 25, 201, 143, 174, 151, 17, 6, 24, 246, 166, 52, 141, 94, 166, 109, 133, 104, 82, 190, 41, 19, 75, 92, 135, 23, 255, 185, 195, 0, 101, 98, 73, 34, 185, 126, 54, 141, 96 }, new byte[] { 81, 110, 204, 121, 2, 83, 9, 80, 160, 79, 136, 87, 107, 127, 61, 123, 147, 254, 168, 106, 94, 153, 10, 49, 129, 171, 117, 124, 122, 178, 161, 101, 34, 67, 30, 118, 164, 95, 229, 99, 13, 37, 104, 20, 145, 64, 177, 103, 95, 7, 88, 205, 252, 82, 229, 186, 139, 248, 238, 54, 170, 93, 143, 7, 85, 115, 34, 76, 171, 240, 65, 157, 83, 58, 150, 137, 237, 72, 209, 197, 115, 186, 163, 28, 60, 178, 179, 94, 201, 246, 67, 156, 11, 210, 108, 52, 242, 222, 102, 71, 27, 200, 180, 200, 128, 215, 97, 142, 109, 150, 135, 201, 96, 178, 15, 227, 167, 132, 14, 56, 39, 76, 118, 164, 162, 10, 9, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7561), new byte[] { 83, 254, 89, 175, 117, 118, 94, 175, 216, 113, 163, 177, 142, 114, 100, 34, 115, 173, 229, 210, 249, 227, 97, 124, 161, 157, 78, 166, 116, 10, 208, 7, 20, 75, 127, 107, 167, 251, 25, 86, 161, 48, 56, 36, 190, 80, 64, 84, 100, 3, 147, 16, 192, 65, 67, 241, 171, 175, 153, 110, 255, 49, 195, 199 }, new byte[] { 51, 35, 0, 242, 82, 253, 215, 230, 244, 30, 166, 195, 76, 15, 69, 214, 220, 166, 153, 218, 163, 204, 9, 153, 157, 87, 172, 31, 99, 214, 124, 78, 40, 26, 207, 76, 99, 140, 225, 44, 28, 160, 77, 233, 0, 237, 198, 33, 248, 169, 33, 11, 216, 100, 221, 156, 56, 82, 55, 152, 211, 8, 5, 25, 99, 36, 137, 49, 185, 143, 239, 180, 78, 48, 138, 143, 129, 45, 97, 128, 116, 142, 186, 78, 73, 169, 102, 127, 123, 63, 152, 247, 106, 14, 69, 190, 201, 232, 106, 121, 221, 152, 212, 75, 130, 93, 25, 245, 235, 100, 168, 152, 86, 79, 223, 210, 149, 2, 214, 208, 116, 149, 75, 73, 168, 27, 56, 7 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7563), new byte[] { 143, 198, 51, 148, 44, 64, 61, 128, 95, 64, 174, 24, 243, 71, 210, 240, 41, 7, 135, 39, 133, 53, 38, 247, 88, 17, 163, 157, 171, 69, 174, 53, 12, 116, 52, 182, 87, 79, 246, 114, 123, 166, 42, 202, 101, 174, 153, 118, 203, 105, 183, 227, 158, 163, 208, 176, 31, 103, 225, 131, 228, 229, 36, 250 }, new byte[] { 159, 227, 114, 242, 26, 186, 239, 214, 98, 34, 143, 239, 89, 182, 187, 157, 65, 152, 173, 221, 225, 120, 253, 166, 191, 4, 207, 113, 181, 217, 135, 90, 72, 194, 32, 101, 106, 176, 32, 53, 98, 140, 175, 79, 91, 7, 145, 172, 39, 57, 179, 208, 11, 96, 85, 160, 186, 40, 33, 235, 87, 3, 43, 124, 214, 217, 64, 186, 230, 188, 102, 215, 192, 28, 171, 207, 33, 123, 93, 169, 97, 161, 166, 116, 109, 29, 103, 74, 179, 225, 47, 202, 126, 58, 93, 151, 47, 98, 95, 40, 229, 179, 239, 97, 75, 29, 127, 19, 230, 70, 61, 181, 52, 199, 31, 134, 159, 23, 102, 228, 100, 189, 172, 118, 46, 196, 241, 92 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 25, 22, 263, DateTimeKind.Utc).AddTicks(7564), new byte[] { 4, 234, 176, 168, 95, 166, 9, 245, 77, 39, 241, 12, 95, 9, 140, 45, 228, 63, 99, 200, 3, 214, 3, 11, 87, 230, 196, 206, 144, 215, 115, 158, 87, 115, 76, 207, 160, 243, 240, 55, 234, 177, 174, 171, 37, 40, 228, 93, 45, 181, 186, 94, 222, 69, 116, 244, 41, 105, 110, 249, 157, 61, 182, 142 }, new byte[] { 224, 176, 62, 87, 196, 8, 209, 224, 170, 196, 2, 28, 115, 215, 1, 42, 53, 88, 36, 34, 43, 129, 87, 139, 142, 170, 210, 91, 234, 45, 74, 170, 171, 58, 167, 76, 174, 46, 195, 130, 211, 156, 50, 104, 69, 37, 70, 131, 226, 174, 31, 92, 153, 66, 164, 111, 185, 160, 71, 252, 234, 31, 6, 133, 12, 115, 235, 182, 57, 98, 18, 203, 216, 168, 174, 150, 142, 34, 118, 184, 90, 128, 228, 149, 34, 93, 225, 245, 58, 192, 41, 173, 90, 160, 250, 55, 200, 46, 121, 35, 190, 95, 197, 2, 155, 68, 9, 150, 242, 15, 5, 200, 225, 211, 246, 202, 137, 36, 234, 92, 44, 57, 80, 237, 226, 116, 83, 207 } });
        }
    }
}
