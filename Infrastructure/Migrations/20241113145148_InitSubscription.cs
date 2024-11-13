using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExpiredDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SubscriptionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PaymentAmount = table.Column<double>(type: "double precision", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 14, 51, 47, 920, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2241), new byte[] { 174, 211, 158, 143, 212, 43, 43, 148, 231, 94, 24, 17, 242, 145, 134, 76, 10, 155, 25, 249, 82, 135, 247, 70, 188, 251, 241, 254, 17, 180, 5, 97, 147, 11, 57, 155, 251, 17, 70, 33, 49, 26, 196, 8, 134, 132, 224, 2, 249, 140, 104, 255, 175, 64, 8, 240, 58, 172, 17, 45, 243, 178, 183, 161 }, new byte[] { 98, 33, 223, 66, 140, 105, 44, 148, 108, 159, 195, 215, 114, 63, 67, 139, 237, 116, 135, 129, 114, 78, 226, 10, 88, 158, 239, 181, 140, 92, 86, 212, 157, 87, 96, 183, 72, 73, 110, 187, 239, 119, 47, 241, 110, 31, 80, 111, 28, 127, 252, 213, 121, 250, 115, 110, 41, 135, 137, 159, 40, 191, 100, 99, 215, 159, 211, 24, 197, 102, 238, 248, 60, 223, 120, 119, 135, 20, 191, 158, 145, 31, 149, 103, 55, 183, 45, 173, 156, 56, 99, 247, 70, 98, 64, 88, 13, 243, 55, 161, 141, 135, 181, 185, 183, 24, 227, 10, 182, 57, 229, 227, 1, 98, 78, 143, 106, 192, 121, 141, 132, 218, 46, 68, 155, 216, 59, 21 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2249), new byte[] { 34, 47, 7, 139, 73, 119, 115, 141, 166, 144, 172, 26, 201, 15, 39, 177, 216, 62, 177, 133, 99, 79, 9, 14, 126, 126, 96, 158, 166, 91, 179, 85, 134, 187, 149, 71, 103, 65, 11, 174, 32, 67, 14, 171, 160, 34, 17, 245, 90, 57, 124, 205, 219, 218, 31, 16, 60, 180, 113, 99, 66, 42, 148, 20 }, new byte[] { 11, 11, 125, 152, 53, 73, 132, 221, 101, 99, 235, 248, 212, 37, 25, 230, 231, 16, 108, 190, 103, 132, 245, 150, 235, 6, 193, 76, 18, 222, 146, 75, 19, 62, 29, 3, 156, 188, 4, 205, 164, 183, 114, 142, 224, 109, 0, 224, 34, 31, 252, 181, 213, 181, 198, 116, 251, 141, 252, 248, 169, 85, 12, 99, 109, 198, 202, 90, 97, 41, 82, 232, 203, 40, 176, 153, 167, 61, 253, 88, 239, 188, 156, 182, 168, 176, 240, 110, 247, 150, 56, 134, 37, 121, 192, 6, 48, 165, 199, 108, 87, 70, 52, 66, 165, 1, 149, 103, 110, 192, 208, 28, 134, 178, 180, 195, 159, 66, 38, 34, 90, 220, 19, 184, 231, 234, 58, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2251), new byte[] { 138, 103, 56, 209, 128, 8, 38, 203, 127, 224, 18, 115, 81, 13, 62, 184, 244, 66, 7, 117, 29, 184, 141, 101, 205, 89, 187, 0, 48, 125, 247, 93, 16, 88, 121, 217, 176, 211, 132, 129, 13, 27, 161, 104, 206, 249, 160, 114, 232, 45, 9, 4, 158, 231, 140, 71, 202, 158, 178, 172, 225, 243, 217, 113 }, new byte[] { 177, 69, 27, 43, 182, 83, 157, 216, 119, 64, 43, 118, 4, 46, 160, 222, 4, 95, 122, 21, 149, 200, 4, 94, 201, 132, 80, 61, 156, 147, 246, 27, 213, 247, 27, 230, 83, 118, 160, 163, 141, 217, 34, 209, 243, 145, 60, 25, 47, 4, 70, 188, 163, 195, 208, 219, 172, 43, 132, 25, 98, 134, 134, 18, 155, 246, 182, 172, 250, 170, 82, 252, 126, 127, 27, 245, 238, 135, 14, 248, 91, 169, 89, 87, 148, 198, 57, 202, 195, 222, 96, 82, 76, 241, 133, 249, 158, 151, 59, 200, 163, 98, 229, 60, 45, 34, 5, 30, 236, 145, 199, 146, 33, 32, 210, 133, 162, 116, 98, 103, 20, 161, 151, 160, 39, 41, 201, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 51, 47, 919, DateTimeKind.Utc).AddTicks(2253), new byte[] { 33, 114, 54, 24, 187, 100, 159, 66, 13, 65, 58, 52, 213, 120, 252, 96, 106, 247, 132, 142, 137, 185, 189, 39, 153, 238, 64, 126, 239, 116, 51, 159, 230, 47, 151, 197, 219, 74, 223, 39, 30, 51, 90, 59, 53, 223, 0, 255, 250, 174, 120, 72, 128, 16, 132, 246, 61, 205, 147, 225, 144, 167, 60, 223 }, new byte[] { 72, 105, 6, 149, 253, 158, 198, 219, 186, 102, 113, 197, 178, 109, 240, 227, 151, 91, 139, 16, 99, 134, 232, 211, 141, 99, 7, 170, 45, 26, 22, 119, 46, 82, 126, 206, 27, 143, 195, 145, 9, 33, 40, 135, 51, 110, 10, 169, 216, 143, 222, 15, 83, 224, 171, 191, 72, 5, 108, 20, 151, 27, 190, 33, 224, 108, 109, 53, 215, 143, 176, 203, 51, 56, 43, 27, 58, 23, 50, 82, 36, 210, 237, 100, 225, 232, 59, 58, 107, 100, 54, 46, 135, 127, 51, 193, 129, 198, 13, 180, 73, 130, 242, 136, 250, 244, 65, 180, 132, 239, 28, 38, 190, 108, 8, 62, 55, 227, 216, 26, 160, 30, 26, 151, 215, 28, 199, 127 } });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

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
        }
    }
}
