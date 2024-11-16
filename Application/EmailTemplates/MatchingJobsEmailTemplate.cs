namespace Application.EmailTemplates
{
    public static class MatchingJobsEmailTemplate
    {
        public const string MatchingJobs =
        @"<!DOCTYPE html>
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
            font-size: 16px;
            color: #555;
            margin: 10px 0;
        }.job-item-infor {
            font-size: 14px;
            color: black;
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
        .job-img{
            width: 100px;
            height: 100px;
        }
        .job-item{
            background-color: rgb(249, 254, 254);
            margin-bottom: 8px;
            border: 1px solid white;
            border-radius: 5px;
            padding-bottom: 20px;
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
            <p>Based on your CVs, our Job Robot found new matching jobs for you.</p>
            <div class=""job-list"">
                ${Jobs}
            </div>
            <a href=""#"" class=""cta-button"">More Jobs</a>
        </div>
        <div class=""footer"">
            <p>By engaging with this email, you agree to <a href=""#"">Terms and Conditions</a> and <a href=""#"">Privacy Policy</a>.</p>
        </div>
    </div>
</body>
</html>";

        public const string MathchingJob = @"<div class=""job-item"">
                    <p class=""job-title"">${JobTitle}</p>
                    <p class=""job-details"">
                        ${CompanyName} <br>
                    </p>
                    <img class=""job-img"" src=""${ImageURL}"" alt=""${JobTitle}""/>
                    <p class=""job-item-infor"">
                        Skills: ${JobSkillSets} <br>
                    </p>
                    <p class=""job-item-infor"">
                        Expired date: ${ExpiredDate}
                    </p>
                    <p class=""job-item-infor"">
                        ${Address}
                    </p>
                </div>";
    }
}
