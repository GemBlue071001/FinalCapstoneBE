using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Conversations_ConversationId1",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserConversations_Conversations_ConversationId1",
                table: "UserConversations");

            migrationBuilder.DropIndex(
                name: "IX_UserConversations_ConversationId1",
                table: "UserConversations");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ConversationId1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ConversationId1",
                table: "UserConversations");

            migrationBuilder.DropColumn(
                name: "ConversationId1",
                table: "Messages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(7160),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.AddColumn<int>(
                name: "CandidateStatus",
                table: "Candidates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(3615), new byte[] { 84, 156, 173, 76, 79, 2, 46, 97, 23, 8, 179, 19, 148, 210, 49, 83, 184, 158, 86, 251, 231, 183, 206, 33, 165, 17, 62, 170, 89, 63, 188, 220, 54, 102, 244, 198, 203, 12, 222, 162, 170, 254, 91, 141, 6, 241, 71, 42, 3, 100, 132, 8, 144, 196, 211, 220, 15, 79, 8, 2, 194, 218, 4, 148 }, new byte[] { 28, 237, 67, 253, 95, 27, 108, 33, 88, 179, 5, 147, 26, 44, 39, 126, 3, 15, 122, 246, 185, 61, 27, 208, 170, 158, 180, 152, 166, 225, 98, 18, 74, 84, 88, 141, 241, 203, 64, 230, 72, 40, 121, 165, 158, 49, 58, 231, 157, 9, 94, 222, 214, 54, 199, 62, 147, 18, 51, 140, 189, 81, 1, 149, 182, 208, 116, 183, 98, 37, 30, 17, 225, 97, 234, 227, 23, 237, 164, 213, 176, 157, 251, 2, 240, 137, 104, 194, 250, 25, 99, 130, 176, 10, 30, 23, 166, 188, 166, 212, 20, 76, 248, 251, 253, 68, 59, 11, 84, 84, 59, 90, 212, 169, 207, 25, 179, 170, 252, 125, 163, 231, 115, 88, 227, 23, 207, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(3621), new byte[] { 74, 103, 10, 164, 138, 238, 112, 176, 155, 50, 178, 223, 146, 146, 46, 216, 226, 6, 121, 109, 41, 36, 58, 38, 174, 24, 74, 247, 237, 160, 214, 167, 111, 58, 76, 120, 30, 27, 65, 252, 238, 106, 218, 200, 141, 227, 184, 85, 139, 113, 166, 162, 140, 243, 227, 143, 30, 244, 102, 31, 164, 3, 223, 135 }, new byte[] { 8, 162, 87, 83, 238, 62, 50, 56, 145, 133, 225, 239, 71, 118, 76, 210, 12, 113, 7, 225, 33, 24, 95, 110, 189, 69, 190, 247, 200, 50, 161, 24, 74, 140, 230, 188, 205, 206, 127, 208, 130, 253, 67, 8, 2, 120, 194, 209, 180, 33, 233, 183, 74, 49, 221, 132, 13, 221, 228, 187, 156, 175, 205, 1, 190, 147, 71, 27, 18, 141, 23, 105, 190, 161, 190, 110, 221, 125, 64, 224, 25, 178, 34, 241, 34, 181, 153, 100, 230, 51, 173, 157, 13, 241, 66, 196, 59, 138, 75, 255, 136, 51, 200, 59, 92, 32, 240, 75, 96, 25, 238, 172, 188, 225, 233, 221, 255, 164, 103, 170, 223, 54, 123, 133, 143, 213, 119, 132 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(3623), new byte[] { 3, 115, 166, 27, 26, 77, 54, 197, 195, 43, 197, 9, 131, 200, 205, 128, 117, 242, 239, 95, 111, 94, 230, 41, 223, 41, 167, 56, 126, 46, 207, 158, 141, 3, 3, 179, 142, 84, 127, 122, 152, 155, 248, 69, 92, 209, 126, 68, 50, 92, 225, 153, 35, 141, 56, 67, 31, 4, 247, 30, 75, 92, 126, 240 }, new byte[] { 98, 29, 143, 8, 246, 8, 80, 19, 105, 150, 175, 245, 69, 219, 166, 229, 180, 144, 13, 185, 234, 124, 138, 20, 162, 125, 220, 108, 57, 192, 147, 253, 44, 6, 165, 172, 255, 234, 214, 205, 118, 50, 46, 66, 15, 62, 3, 0, 241, 132, 211, 73, 25, 76, 172, 35, 118, 224, 231, 115, 180, 100, 239, 68, 223, 230, 0, 17, 106, 220, 0, 227, 57, 106, 97, 166, 74, 163, 214, 190, 15, 206, 107, 115, 182, 194, 86, 222, 168, 241, 209, 125, 138, 197, 40, 202, 156, 148, 150, 222, 194, 83, 229, 203, 135, 19, 246, 15, 102, 31, 227, 180, 244, 92, 254, 180, 179, 199, 18, 215, 163, 63, 229, 79, 49, 109, 28, 29 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(3624), new byte[] { 4, 249, 165, 132, 4, 130, 122, 126, 161, 70, 10, 96, 245, 198, 1, 234, 151, 36, 199, 149, 117, 85, 145, 73, 47, 237, 233, 144, 186, 222, 242, 48, 246, 94, 129, 150, 202, 46, 80, 223, 127, 222, 105, 219, 6, 214, 96, 183, 189, 167, 132, 52, 97, 222, 82, 10, 75, 13, 158, 37, 63, 133, 223, 183 }, new byte[] { 166, 80, 87, 202, 142, 138, 54, 207, 90, 8, 114, 147, 56, 160, 175, 108, 46, 189, 136, 125, 213, 24, 35, 212, 103, 111, 174, 104, 228, 53, 155, 219, 181, 106, 69, 6, 141, 12, 221, 63, 130, 116, 242, 251, 245, 212, 126, 91, 152, 156, 182, 106, 94, 243, 214, 132, 198, 143, 26, 218, 196, 238, 127, 36, 96, 117, 244, 203, 187, 211, 133, 187, 23, 248, 117, 208, 0, 118, 70, 90, 30, 48, 183, 171, 108, 137, 37, 205, 165, 131, 140, 118, 117, 146, 190, 99, 93, 230, 235, 178, 36, 39, 47, 183, 147, 26, 201, 184, 63, 11, 3, 219, 176, 208, 251, 220, 236, 193, 110, 153, 88, 87, 214, 76, 131, 183, 42, 43 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CandidateStatus",
                table: "Candidates");

            migrationBuilder.AddColumn<int>(
                name: "ConversationId1",
                table: "UserConversations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConversationId1",
                table: "Messages",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Candidates",
                type: "timestamp with time zone",
                nullable: true,
                defaultValue: new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 7, 27, 16, 34, 32, 580, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(1329), new byte[] { 182, 218, 95, 48, 236, 13, 14, 173, 41, 205, 161, 251, 183, 168, 179, 174, 78, 4, 98, 177, 79, 56, 159, 40, 66, 186, 152, 201, 55, 255, 229, 246, 165, 196, 244, 253, 243, 149, 234, 152, 185, 108, 6, 218, 205, 229, 126, 92, 71, 229, 136, 24, 45, 5, 156, 164, 156, 107, 43, 114, 65, 18, 182, 198 }, new byte[] { 184, 145, 238, 154, 213, 133, 63, 232, 53, 144, 6, 198, 105, 84, 20, 37, 80, 127, 77, 150, 12, 118, 90, 47, 87, 222, 255, 193, 70, 149, 225, 25, 129, 64, 36, 145, 21, 92, 162, 11, 56, 158, 209, 76, 69, 210, 18, 22, 206, 186, 197, 174, 38, 239, 111, 175, 38, 104, 141, 173, 117, 139, 221, 149, 110, 189, 76, 59, 248, 89, 49, 249, 135, 247, 84, 55, 146, 6, 76, 142, 82, 17, 248, 85, 95, 35, 222, 33, 184, 254, 250, 164, 59, 130, 20, 202, 250, 181, 192, 187, 207, 238, 182, 111, 211, 76, 236, 249, 93, 8, 213, 203, 111, 13, 244, 184, 241, 36, 157, 176, 251, 109, 14, 224, 29, 103, 183, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(1335), new byte[] { 110, 76, 202, 55, 65, 140, 21, 35, 117, 52, 225, 134, 135, 188, 96, 234, 70, 213, 167, 255, 48, 121, 97, 212, 55, 36, 7, 25, 61, 155, 183, 56, 255, 80, 119, 105, 93, 253, 242, 246, 194, 57, 245, 46, 220, 36, 103, 162, 43, 171, 173, 44, 90, 216, 154, 16, 145, 208, 236, 61, 204, 168, 170, 135 }, new byte[] { 154, 165, 197, 209, 120, 126, 161, 213, 145, 62, 156, 16, 24, 58, 218, 53, 63, 50, 158, 45, 117, 196, 51, 43, 219, 163, 114, 91, 226, 128, 186, 95, 231, 179, 54, 159, 11, 162, 178, 162, 10, 222, 108, 136, 100, 149, 43, 165, 49, 114, 55, 232, 207, 201, 173, 101, 253, 97, 176, 190, 75, 107, 199, 73, 21, 81, 192, 242, 220, 147, 154, 251, 17, 193, 235, 109, 39, 80, 152, 170, 62, 13, 124, 114, 204, 174, 88, 155, 204, 88, 163, 151, 127, 178, 30, 48, 121, 248, 91, 209, 47, 254, 150, 78, 21, 65, 220, 54, 201, 37, 122, 136, 240, 223, 72, 134, 254, 78, 36, 203, 7, 143, 200, 153, 241, 112, 104, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(1337), new byte[] { 103, 231, 51, 191, 193, 193, 250, 39, 74, 91, 224, 145, 185, 53, 90, 165, 136, 140, 78, 223, 221, 61, 160, 9, 141, 184, 68, 114, 79, 169, 135, 189, 12, 63, 135, 67, 130, 53, 33, 61, 2, 226, 71, 112, 60, 5, 101, 200, 137, 112, 70, 20, 71, 190, 108, 193, 252, 170, 57, 173, 63, 26, 63, 206 }, new byte[] { 123, 71, 63, 21, 118, 193, 197, 116, 229, 240, 96, 114, 141, 141, 125, 103, 103, 242, 73, 164, 54, 68, 205, 44, 166, 7, 41, 176, 196, 80, 22, 95, 229, 136, 160, 89, 75, 235, 175, 247, 136, 137, 244, 209, 22, 118, 110, 90, 195, 238, 183, 201, 157, 204, 90, 228, 174, 89, 15, 42, 45, 134, 181, 140, 143, 41, 57, 17, 236, 5, 135, 74, 138, 199, 29, 3, 20, 199, 241, 158, 21, 238, 235, 184, 37, 197, 15, 32, 188, 180, 75, 252, 152, 34, 221, 181, 252, 230, 206, 89, 64, 132, 218, 45, 159, 152, 160, 213, 171, 131, 100, 90, 214, 87, 81, 98, 235, 62, 163, 185, 167, 96, 156, 235, 117, 91, 150, 76 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 47, 28, 67, DateTimeKind.Utc).AddTicks(1339), new byte[] { 85, 126, 32, 51, 124, 215, 24, 163, 221, 38, 23, 15, 187, 73, 87, 205, 132, 65, 149, 21, 210, 185, 77, 119, 225, 78, 161, 132, 158, 82, 19, 230, 218, 6, 18, 122, 168, 92, 161, 75, 73, 139, 211, 137, 128, 64, 185, 118, 93, 22, 239, 252, 103, 203, 116, 201, 45, 164, 42, 231, 245, 147, 55, 182 }, new byte[] { 73, 174, 42, 72, 232, 35, 253, 124, 221, 88, 156, 113, 167, 196, 107, 173, 249, 234, 69, 157, 121, 50, 209, 37, 104, 238, 127, 214, 68, 146, 19, 89, 83, 212, 10, 43, 126, 127, 71, 5, 115, 191, 151, 170, 207, 48, 73, 126, 193, 164, 159, 16, 12, 59, 173, 152, 102, 64, 222, 134, 237, 223, 227, 100, 56, 180, 239, 21, 164, 109, 87, 135, 152, 226, 98, 69, 223, 163, 66, 194, 201, 65, 123, 113, 134, 64, 241, 183, 182, 122, 48, 64, 240, 184, 180, 39, 103, 191, 78, 193, 166, 201, 160, 55, 233, 248, 253, 41, 21, 203, 199, 150, 124, 209, 45, 242, 178, 27, 62, 78, 0, 174, 179, 131, 150, 110, 244, 152 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserConversations_ConversationId1",
                table: "UserConversations",
                column: "ConversationId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConversationId1",
                table: "Messages",
                column: "ConversationId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Conversations_ConversationId1",
                table: "Messages",
                column: "ConversationId1",
                principalTable: "Conversations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserConversations_Conversations_ConversationId1",
                table: "UserConversations",
                column: "ConversationId1",
                principalTable: "Conversations",
                principalColumn: "Id");
        }
    }
}
