using Application.Interface;
using Application.Response;
using ClosedXML.Excel;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FileHandlingService : IFileHandlingService
    {
        public FileHandlingService()
        {

        }
        public async Task<ApiResponse> ImportExcel(IFormFile file)
        {
            ApiResponse apiResponse = new ApiResponse();
            if (file == null || file.Length == 0)
            {
                return apiResponse.SetBadRequest("File is empty");
            }
            List<JobPost> jobPosts = new List<JobPost>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var workbook = new XLWorkbook(stream))
                {
                    var worksheet = workbook.Worksheet(1); // First worksheet
                    var rows = worksheet.RangeUsed().RowsUsed();

                    foreach (var row in rows.Skip(1)) // Skip header row
                    {
                        //var record = new JobPost
                        //{
                        //    JobTitle = row.Cell(1).GetValue<string>(),
                        //    Salary = row.Cell(2).GetValue<decimal>(),
                        //    JobType = row.Cell(3).GetValue<JobType>(),
                        //    Company = row.Cell(4).GetValue<Company>(),

                        //    // Add more properties as needed
                        //};
                        //jobPosts.Add(record);
                        var a = row.Cell(1).GetValue<string>();
                    }
                }
            }
            return apiResponse.SetOk("Success");

        }

        public async Task<ApiResponse> UploadCVToAnalyze(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return new ApiResponse().SetBadRequest("File is empty");
            }

            if (file.ContentType != "application/pdf" && !file.FileName.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                return new ApiResponse().SetBadRequest("File must be a PDF");
            }


            return new ApiResponse().SetOk("Success");
        }
    }
}
