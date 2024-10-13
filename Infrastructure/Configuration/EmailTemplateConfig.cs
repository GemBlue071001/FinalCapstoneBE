using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class EmailTemplateConfig : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.HasKey(e => e.Id);

            // Seed an initial email template
            builder.HasData(
                new EmailTemplate
                {
                    Id = 1,
                    Name = "Job Opportunity Email",
                    EmailContent = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Job Opportunity - ${CompanyName}</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .email-container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            border: 1px solid #e0e0e0;
            padding: 20px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        .header {
            background-color: #af2e2f;
            color: white;
            padding: 10px;
            text-align: center;
        }
        .header img {
            max-width: 100px;
        }
        .content {
            padding: 20px;
            text-align: center;
        }
        .job-title {
            font-size: 18px;
            font-weight: bold;
            color: #2b2b2b;
        }
        .job-details {
            font-size: 14px;
            color: #555;
            margin: 10px 0;
        }
        .cta-button {
            display: inline-block;
            background-color: #d32f2f;
            color: white;
            padding: 10px 20px;
            text-decoration: none;
            border-radius: 5px;
            margin-top: 15px;
        }
        .footer {
            text-align: center;
            font-size: 12px;
            color: #999;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <div class=""email-container"">
        <div class=""header"">
            <p>Final Capstone</p>
        </div>
        <div class=""content"">
            <p>Hi ${Name},</p>
            <p>Based on your subscription, our Job Robot found a new ${CompanyName} job for you.</p>
            <p class=""job-title"">${JobTitle}</p>
            <p class=""job-details"">
                ${CompanyName} <br>
                Java - Cloud - Spring
            </p>
            <a href=""#"" class=""cta-button"">More ${CompanyName} Jobs</a>
        </div>
        <div class=""footer"">
            <p>By engaging with this email, you agree to <a href=""#"">Terms and Conditions</a> and <a href=""#"">Privacy Policy</a>.</p>
        </div>
    </div>
</body>
</html>"
                }
            );
        }
    }
}
