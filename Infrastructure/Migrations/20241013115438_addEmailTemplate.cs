using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addEmailTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EmailContent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.InsertData(
                table: "EmailTemplate",
                columns: new[] { "Id", "EmailContent", "Name" },
                values: new object[] { 1, "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Job Opportunity - ${CompanyName}</title>\r\n    <style>\r\n        body {\r\n            font-family: Arial, sans-serif;\r\n        }\r\n        .email-container {\r\n            width: 100%;\r\n            max-width: 600px;\r\n            margin: 0 auto;\r\n            border: 1px solid #e0e0e0;\r\n            padding: 20px;\r\n            box-shadow: 0 2px 5px rgba(0,0,0,0.1);\r\n        }\r\n        .header {\r\n            background-color: #af2e2f;\r\n            color: white;\r\n            padding: 10px;\r\n            text-align: center;\r\n        }\r\n        .header img {\r\n            max-width: 100px;\r\n        }\r\n        .content {\r\n            padding: 20px;\r\n            text-align: center;\r\n        }\r\n        .job-title {\r\n            font-size: 18px;\r\n            font-weight: bold;\r\n            color: #2b2b2b;\r\n        }\r\n        .job-details {\r\n            font-size: 14px;\r\n            color: #555;\r\n            margin: 10px 0;\r\n        }\r\n        .cta-button {\r\n            display: inline-block;\r\n            background-color: #d32f2f;\r\n            color: white;\r\n            padding: 10px 20px;\r\n            text-decoration: none;\r\n            border-radius: 5px;\r\n            margin-top: 15px;\r\n        }\r\n        .footer {\r\n            text-align: center;\r\n            font-size: 12px;\r\n            color: #999;\r\n            margin-top: 20px;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class=\"email-container\">\r\n        <div class=\"header\">\r\n            <p>Final Capstone</p>\r\n        </div>\r\n        <div class=\"content\">\r\n            <p>Hi ${Name},</p>\r\n            <p>Based on your subscription, our Job Robot found a new ${CompanyName} job for you.</p>\r\n            <p class=\"job-title\">${JobTitle}</p>\r\n            <p class=\"job-details\">\r\n                ${CompanyName} <br>\r\n                Java - Cloud - Spring\r\n            </p>\r\n            <a href=\"#\" class=\"cta-button\">More ${CompanyName} Jobs</a>\r\n        </div>\r\n        <div class=\"footer\">\r\n            <p>By engaging with this email, you agree to <a href=\"#\">Terms and Conditions</a> and <a href=\"#\">Privacy Policy</a>.</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>", "Job Opportunity Email" });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 11, 54, 37, 723, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(357), new byte[] { 23, 52, 124, 225, 120, 162, 11, 12, 71, 41, 7, 191, 48, 68, 147, 253, 143, 14, 76, 144, 22, 233, 126, 156, 133, 207, 221, 13, 100, 151, 54, 90, 198, 95, 137, 82, 0, 65, 45, 188, 208, 21, 115, 66, 97, 70, 74, 43, 200, 132, 203, 25, 146, 172, 65, 233, 65, 216, 28, 157, 184, 92, 151, 202 }, new byte[] { 196, 141, 23, 169, 79, 150, 16, 253, 93, 177, 137, 29, 94, 155, 120, 128, 65, 35, 220, 213, 89, 95, 55, 247, 216, 196, 173, 250, 127, 154, 216, 227, 99, 51, 242, 81, 157, 200, 181, 166, 43, 200, 75, 83, 194, 234, 149, 174, 132, 117, 18, 156, 230, 249, 70, 173, 230, 202, 228, 0, 250, 80, 19, 61, 226, 105, 165, 48, 13, 107, 64, 66, 77, 148, 16, 195, 203, 104, 246, 85, 24, 191, 189, 217, 244, 6, 67, 213, 96, 112, 70, 22, 7, 84, 214, 219, 11, 34, 121, 64, 86, 127, 253, 157, 25, 216, 154, 13, 98, 87, 229, 166, 55, 193, 185, 132, 54, 115, 163, 101, 122, 151, 34, 6, 181, 241, 252, 34 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(364), new byte[] { 192, 11, 254, 248, 73, 9, 155, 241, 246, 29, 91, 193, 90, 236, 217, 173, 127, 204, 55, 120, 230, 82, 49, 174, 4, 117, 80, 68, 242, 102, 149, 219, 6, 145, 108, 114, 3, 236, 174, 143, 143, 223, 34, 190, 248, 202, 146, 247, 169, 233, 31, 22, 62, 195, 223, 179, 238, 228, 67, 167, 113, 160, 112, 154 }, new byte[] { 178, 116, 147, 32, 219, 199, 235, 174, 215, 83, 24, 75, 220, 39, 233, 66, 101, 21, 227, 212, 136, 159, 157, 154, 71, 216, 234, 49, 56, 122, 148, 59, 117, 164, 60, 107, 200, 202, 14, 195, 185, 149, 128, 120, 161, 117, 43, 103, 177, 58, 197, 23, 181, 227, 230, 206, 133, 132, 55, 44, 202, 30, 108, 157, 232, 175, 199, 1, 142, 118, 165, 243, 64, 231, 147, 74, 1, 77, 245, 245, 110, 103, 68, 122, 117, 251, 168, 103, 61, 171, 250, 161, 38, 251, 48, 29, 10, 200, 197, 198, 241, 86, 139, 14, 216, 197, 226, 72, 83, 51, 164, 221, 145, 146, 24, 223, 21, 214, 6, 209, 185, 19, 225, 126, 244, 9, 60, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(366), new byte[] { 207, 152, 152, 104, 112, 122, 87, 38, 14, 33, 24, 168, 40, 213, 183, 190, 203, 97, 231, 171, 77, 10, 80, 131, 53, 204, 215, 6, 12, 206, 59, 51, 109, 210, 180, 228, 57, 227, 208, 168, 148, 108, 67, 225, 233, 96, 85, 73, 83, 198, 63, 87, 38, 162, 1, 140, 13, 2, 114, 240, 187, 180, 187, 45 }, new byte[] { 53, 45, 22, 151, 152, 126, 216, 113, 173, 241, 110, 238, 242, 86, 43, 66, 121, 78, 29, 47, 185, 79, 180, 45, 87, 154, 167, 253, 251, 207, 78, 192, 50, 195, 24, 182, 130, 130, 221, 55, 17, 171, 48, 30, 23, 43, 88, 66, 104, 196, 17, 93, 50, 26, 164, 105, 118, 219, 136, 32, 71, 191, 203, 59, 180, 224, 137, 215, 39, 67, 231, 153, 61, 105, 219, 188, 88, 89, 213, 59, 234, 125, 225, 100, 191, 156, 54, 149, 26, 143, 130, 69, 189, 143, 77, 68, 4, 219, 198, 214, 130, 26, 186, 130, 141, 185, 35, 168, 13, 93, 239, 16, 86, 14, 49, 14, 152, 151, 216, 92, 77, 242, 215, 197, 242, 154, 197, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 54, 37, 722, DateTimeKind.Utc).AddTicks(368), new byte[] { 130, 172, 102, 181, 182, 105, 98, 22, 116, 62, 249, 107, 112, 149, 121, 134, 65, 175, 111, 158, 148, 231, 30, 91, 7, 53, 105, 0, 209, 57, 96, 143, 10, 58, 43, 51, 147, 235, 168, 241, 95, 120, 171, 227, 124, 223, 98, 40, 127, 216, 224, 142, 58, 7, 99, 93, 250, 175, 81, 222, 208, 52, 214, 208 }, new byte[] { 113, 132, 158, 234, 62, 6, 104, 129, 1, 241, 235, 26, 20, 211, 179, 236, 100, 172, 2, 117, 89, 31, 144, 140, 84, 114, 247, 53, 167, 152, 179, 85, 140, 249, 41, 77, 150, 216, 231, 57, 85, 214, 168, 119, 195, 130, 141, 97, 98, 82, 90, 187, 167, 133, 25, 60, 244, 37, 22, 151, 87, 21, 46, 110, 117, 123, 94, 149, 40, 232, 89, 124, 172, 233, 177, 65, 133, 75, 106, 35, 240, 35, 148, 244, 203, 142, 35, 92, 0, 162, 65, 108, 221, 112, 45, 172, 232, 210, 46, 1, 72, 110, 88, 200, 237, 105, 98, 63, 20, 192, 227, 173, 220, 158, 209, 86, 117, 109, 71, 212, 103, 243, 14, 58, 15, 109, 167, 134 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.UpdateData(
                table: "BusinessStreams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 17, 8, 59, 942, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5772), new byte[] { 115, 126, 19, 90, 30, 100, 162, 242, 213, 162, 85, 17, 23, 197, 205, 229, 213, 131, 137, 180, 71, 221, 36, 7, 11, 171, 239, 167, 123, 215, 0, 188, 221, 167, 63, 97, 78, 181, 252, 53, 154, 127, 93, 254, 23, 86, 30, 27, 53, 113, 225, 226, 182, 138, 158, 170, 67, 62, 153, 155, 95, 116, 87, 56 }, new byte[] { 70, 218, 92, 107, 177, 7, 204, 51, 237, 195, 21, 56, 80, 136, 219, 69, 14, 94, 169, 211, 246, 167, 63, 155, 11, 87, 127, 85, 185, 181, 251, 248, 166, 170, 67, 4, 27, 174, 80, 235, 81, 44, 232, 72, 245, 166, 181, 231, 81, 244, 236, 5, 67, 77, 39, 123, 220, 160, 38, 67, 200, 17, 89, 213, 38, 49, 201, 158, 238, 204, 167, 72, 60, 173, 163, 121, 82, 210, 42, 219, 22, 209, 193, 192, 114, 36, 73, 88, 175, 96, 218, 146, 71, 196, 167, 71, 65, 247, 33, 106, 242, 70, 132, 107, 138, 213, 246, 70, 75, 142, 225, 56, 172, 26, 46, 252, 19, 17, 9, 177, 254, 46, 234, 163, 51, 109, 175, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5778), new byte[] { 79, 165, 141, 65, 121, 254, 70, 23, 107, 197, 209, 233, 140, 222, 203, 186, 150, 242, 234, 19, 106, 111, 68, 66, 211, 108, 92, 55, 232, 227, 219, 30, 203, 149, 169, 198, 178, 19, 180, 53, 165, 225, 112, 189, 100, 65, 23, 140, 26, 0, 220, 98, 157, 86, 77, 172, 74, 54, 24, 21, 223, 215, 63, 67 }, new byte[] { 194, 135, 248, 157, 134, 64, 7, 37, 2, 127, 15, 139, 10, 146, 193, 197, 193, 153, 104, 193, 123, 200, 100, 32, 45, 206, 137, 142, 99, 137, 176, 90, 125, 250, 204, 90, 128, 201, 139, 34, 104, 8, 120, 44, 176, 127, 129, 37, 39, 53, 137, 0, 75, 195, 192, 92, 207, 106, 9, 126, 234, 119, 119, 40, 187, 246, 213, 142, 215, 254, 44, 182, 183, 28, 85, 75, 110, 163, 130, 164, 109, 94, 214, 209, 33, 184, 162, 32, 225, 104, 195, 216, 168, 73, 214, 43, 126, 223, 178, 28, 15, 2, 169, 84, 32, 118, 153, 233, 82, 99, 80, 218, 184, 237, 101, 74, 52, 151, 234, 193, 222, 130, 150, 182, 76, 7, 206, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5780), new byte[] { 141, 224, 115, 127, 82, 163, 88, 63, 37, 184, 136, 199, 32, 50, 230, 68, 254, 172, 103, 105, 224, 140, 93, 162, 100, 249, 248, 32, 71, 110, 242, 188, 204, 174, 0, 48, 143, 176, 211, 188, 31, 222, 189, 198, 186, 178, 133, 112, 154, 173, 145, 1, 30, 86, 201, 129, 132, 194, 155, 156, 220, 150, 170, 68 }, new byte[] { 166, 209, 63, 33, 149, 157, 14, 184, 253, 93, 218, 94, 81, 57, 9, 92, 249, 58, 88, 100, 181, 125, 247, 110, 107, 70, 247, 130, 147, 51, 61, 218, 91, 170, 204, 240, 66, 123, 56, 72, 172, 23, 199, 197, 118, 203, 174, 223, 55, 209, 134, 163, 149, 19, 106, 2, 21, 12, 96, 210, 220, 108, 116, 221, 201, 93, 90, 35, 118, 127, 185, 30, 115, 55, 251, 21, 219, 107, 207, 251, 69, 183, 154, 153, 165, 125, 241, 225, 164, 162, 45, 54, 16, 210, 55, 161, 222, 111, 51, 209, 200, 222, 69, 31, 157, 141, 4, 162, 157, 48, 23, 68, 255, 127, 61, 228, 163, 217, 166, 185, 53, 35, 12, 255, 207, 248, 92, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 8, 59, 940, DateTimeKind.Utc).AddTicks(5781), new byte[] { 132, 224, 218, 120, 83, 112, 29, 85, 174, 20, 201, 85, 44, 236, 107, 40, 55, 2, 50, 59, 62, 240, 161, 31, 3, 57, 86, 106, 200, 173, 196, 63, 6, 241, 153, 212, 199, 158, 80, 249, 175, 115, 217, 222, 35, 216, 41, 154, 199, 114, 76, 39, 1, 156, 61, 28, 20, 192, 195, 19, 199, 196, 187, 48 }, new byte[] { 165, 63, 240, 203, 214, 47, 103, 2, 254, 178, 12, 167, 136, 22, 110, 46, 52, 107, 236, 43, 160, 130, 189, 63, 28, 193, 95, 157, 184, 188, 160, 205, 34, 118, 49, 238, 172, 30, 33, 131, 4, 99, 203, 119, 7, 177, 161, 13, 171, 92, 245, 31, 134, 195, 115, 15, 124, 91, 97, 147, 83, 143, 215, 5, 169, 245, 78, 162, 84, 243, 161, 202, 134, 253, 163, 240, 96, 186, 59, 114, 182, 168, 12, 201, 154, 220, 242, 127, 131, 224, 221, 140, 121, 50, 122, 140, 115, 128, 66, 49, 92, 151, 90, 211, 177, 23, 74, 175, 102, 75, 56, 84, 115, 187, 114, 203, 88, 135, 47, 205, 18, 44, 114, 120, 133, 142, 5, 99 } });
        }
    }
}
