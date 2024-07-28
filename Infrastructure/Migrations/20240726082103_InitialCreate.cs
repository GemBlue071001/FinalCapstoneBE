using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 26, 8, 21, 3, 214, DateTimeKind.Utc).AddTicks(1722),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    SendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ConversationId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ConversationId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_ConversationId1",
                        column: x => x.ConversationId1,
                        principalTable: "Conversations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserConversations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConversationId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ConversationId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserConversations_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserConversations_Conversations_ConversationId1",
                        column: x => x.ConversationId1,
                        principalTable: "Conversations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserConversations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 21, 3, 213, DateTimeKind.Utc).AddTicks(8880), new byte[] { 124, 215, 223, 0, 89, 247, 163, 204, 190, 222, 96, 198, 17, 141, 118, 221, 190, 119, 214, 174, 231, 116, 179, 164, 245, 136, 230, 149, 175, 171, 176, 176, 28, 152, 21, 186, 217, 250, 187, 143, 133, 246, 3, 83, 90, 169, 5, 168, 172, 67, 60, 88, 163, 175, 20, 143, 22, 185, 160, 116, 46, 128, 238, 207 }, new byte[] { 37, 143, 197, 242, 96, 192, 80, 25, 157, 60, 127, 181, 237, 191, 186, 244, 139, 226, 219, 51, 199, 225, 89, 63, 73, 194, 141, 109, 240, 209, 33, 154, 124, 112, 138, 112, 6, 74, 193, 111, 98, 251, 255, 81, 14, 131, 181, 93, 140, 160, 128, 103, 58, 95, 115, 223, 152, 103, 23, 12, 107, 161, 210, 184, 55, 100, 253, 126, 124, 198, 35, 205, 76, 117, 176, 95, 98, 205, 126, 158, 61, 152, 110, 200, 27, 207, 75, 171, 164, 178, 182, 151, 181, 101, 119, 91, 13, 92, 55, 16, 57, 30, 89, 163, 135, 129, 41, 62, 169, 29, 66, 216, 239, 20, 26, 183, 134, 117, 26, 221, 39, 199, 64, 199, 101, 19, 239, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 21, 3, 213, DateTimeKind.Utc).AddTicks(8887), new byte[] { 173, 60, 105, 180, 246, 223, 11, 173, 152, 132, 49, 10, 254, 205, 102, 214, 249, 243, 203, 175, 112, 4, 94, 75, 234, 0, 156, 227, 221, 8, 13, 25, 13, 14, 113, 119, 223, 219, 254, 34, 216, 163, 254, 138, 123, 166, 201, 189, 168, 32, 137, 127, 111, 88, 210, 240, 109, 151, 113, 114, 234, 49, 33, 210 }, new byte[] { 82, 232, 112, 29, 92, 32, 202, 220, 93, 149, 171, 14, 140, 38, 87, 44, 188, 227, 52, 5, 167, 116, 197, 0, 230, 226, 61, 236, 41, 85, 5, 46, 43, 177, 160, 55, 14, 240, 138, 75, 192, 42, 47, 254, 83, 100, 7, 59, 28, 174, 234, 40, 114, 36, 20, 84, 35, 163, 177, 112, 138, 162, 114, 9, 3, 195, 233, 151, 59, 220, 41, 123, 95, 40, 173, 27, 105, 189, 244, 205, 237, 58, 28, 85, 103, 123, 3, 153, 92, 62, 232, 188, 164, 227, 21, 119, 184, 73, 116, 210, 211, 14, 114, 247, 1, 77, 71, 242, 193, 160, 87, 26, 207, 159, 164, 163, 162, 211, 218, 140, 187, 41, 156, 104, 141, 103, 242, 217 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 21, 3, 213, DateTimeKind.Utc).AddTicks(8889), new byte[] { 71, 59, 181, 191, 152, 120, 11, 249, 6, 185, 36, 139, 206, 217, 45, 182, 104, 203, 92, 120, 110, 68, 203, 240, 27, 97, 15, 177, 242, 9, 160, 82, 6, 204, 219, 203, 29, 55, 179, 251, 192, 236, 127, 32, 203, 228, 98, 248, 89, 232, 191, 55, 123, 179, 183, 187, 251, 5, 207, 43, 246, 215, 85, 52 }, new byte[] { 214, 114, 110, 33, 217, 133, 245, 48, 75, 128, 209, 197, 134, 240, 168, 137, 200, 139, 0, 234, 244, 91, 156, 46, 128, 44, 16, 137, 171, 216, 76, 250, 16, 139, 227, 22, 43, 94, 248, 3, 44, 16, 148, 57, 38, 217, 142, 85, 232, 92, 56, 77, 226, 86, 228, 136, 39, 138, 229, 225, 235, 49, 122, 52, 178, 198, 7, 122, 232, 222, 13, 59, 197, 108, 219, 95, 95, 248, 24, 5, 91, 46, 49, 15, 20, 76, 213, 67, 89, 136, 155, 137, 109, 236, 181, 127, 43, 185, 223, 177, 67, 97, 46, 52, 99, 60, 101, 23, 244, 4, 63, 54, 141, 143, 20, 115, 46, 11, 219, 149, 99, 65, 146, 72, 88, 195, 122, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 21, 3, 213, DateTimeKind.Utc).AddTicks(8915), new byte[] { 201, 123, 195, 115, 209, 49, 158, 139, 162, 18, 126, 3, 140, 176, 184, 0, 215, 232, 153, 248, 76, 102, 42, 86, 254, 4, 139, 159, 244, 23, 0, 215, 24, 188, 148, 198, 175, 47, 89, 13, 85, 47, 75, 205, 250, 245, 55, 0, 207, 188, 194, 233, 140, 215, 244, 94, 40, 95, 219, 252, 160, 122, 70, 204 }, new byte[] { 171, 42, 239, 143, 166, 193, 28, 156, 191, 101, 98, 64, 193, 232, 167, 59, 171, 152, 182, 254, 114, 124, 16, 233, 164, 92, 119, 245, 222, 42, 114, 65, 157, 248, 47, 159, 80, 239, 189, 224, 19, 229, 205, 158, 176, 228, 114, 42, 172, 203, 10, 105, 14, 236, 66, 255, 134, 29, 26, 8, 51, 20, 80, 154, 190, 190, 154, 66, 111, 184, 155, 166, 174, 155, 140, 10, 223, 53, 231, 81, 31, 166, 167, 221, 19, 4, 103, 61, 162, 173, 14, 145, 225, 244, 22, 140, 200, 70, 70, 210, 124, 234, 229, 171, 100, 78, 173, 214, 160, 129, 22, 109, 201, 16, 16, 83, 217, 235, 147, 10, 146, 159, 233, 114, 137, 29, 140, 253 } });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId",
                table: "Messages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId1",
                table: "Messages",
                column: "ConversationId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_ConversationId",
                table: "UserConversations",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_ConversationId1",
                table: "UserConversations",
                column: "ConversationId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_UserId",
                table: "UserConversations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "UserConversations");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 22, 14, 28, 29, 106, DateTimeKind.Utc).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 26, 8, 21, 3, 214, DateTimeKind.Utc).AddTicks(1722));

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
    }
}
