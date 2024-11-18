using Application.Repositories;
using Application.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Company>> GetCompany()
        {
            IQueryable<Company> query = _context.Companys
                .Include(x => x.BusinessStream) // Include the BusinessStream
                .Select(x => new Company
                {
                    Address = x.Address,
                    BusinessStream = x.BusinessStream,
                    Id = x.Id,
                    WebsiteURL = x.WebsiteURL,
                    CompanyName = x.CompanyName,
                    City = x.City,
                    Country = x.Country,
                    EstablishedYear = x.EstablishedYear,
                    ImageUrl = x.ImageUrl,
                    NumberOfEmployees = x.NumberOfEmployees,
                    CompanyDescription = x.CompanyDescription,
                    BusinessStreamId = x.BusinessStreamId,
                    JobPosts = x.JobPosts.Select(jp => new JobPost
                    {
                        Benefits = jp.Benefits,
                        CompanyId = jp.CompanyId,
                        ExperienceRequired = jp.ExperienceRequired,
                        ImageURL = jp.ImageURL,
                        Id = jp.Id,
                        JobDescription = jp.JobDescription,
                        JobPostReviewStatus = jp.JobPostReviewStatus,
                        JobTitle = jp.JobTitle,
                        IsDeleted = jp.IsDeleted,
                        QualificationRequired = jp.QualificationRequired,
                        ExpiryDate = jp.ExpiryDate,
                        JobTypeId = jp.JobTypeId,
                        PostingDate = jp.PostingDate,
                        JobLocationId = jp.JobLocationId,
                        Salary = jp.Salary,
                        
                        // Exclude Embedding field
                    }).ToList() // Keep projection deferred, avoids immediate execution
                });

            return await query.ToListAsync(); // Executes a single query to load all data
        }

        public async Task<Company> GetCompanyByIdAsync(int companyId)
        {
            IQueryable<Company> query = _context.Companys
                .Include(c => c.JobPosts)
                .ThenInclude(x => x.JobSkillSets)
                .ThenInclude(x => x.SkillSet)
                .Where(x => x.Id == companyId)
                .Select(x => new Company
                {
                    Address = x.Address,
                    BusinessStream = x.BusinessStream,
                    Id = x.Id,
                    WebsiteURL = x.WebsiteURL,
                    CompanyName = x.CompanyName,
                    City = x.City,
                    Country = x.Country,
                    EstablishedYear = x.EstablishedYear,
                    ImageUrl = x.ImageUrl,
                    NumberOfEmployees = x.NumberOfEmployees,
                    CompanyDescription = x.CompanyDescription,
                    BusinessStreamId = x.BusinessStreamId,
                    JobPosts = x.JobPosts.Select(jp => new JobPost
                    {
                        Benefits = jp.Benefits,
                        CompanyId = jp.CompanyId,
                        ExperienceRequired = jp.ExperienceRequired,
                        ImageURL = jp.ImageURL,
                        Id = jp.Id,
                        JobDescription = jp.JobDescription,
                        JobPostReviewStatus = jp.JobPostReviewStatus,
                        JobTitle = jp.JobTitle,
                        IsDeleted = jp.IsDeleted,
                        QualificationRequired = jp.QualificationRequired,
                        ExpiryDate = jp.ExpiryDate,
                        JobTypeId = jp.JobTypeId,
                        PostingDate = jp.PostingDate,
                        JobLocationId = jp.JobLocationId,
                        Salary = jp.Salary,

                        // Exclude Embedding field
                    }).ToList() // Keep projection deferred, avoids immediate execution
                });

            return await query.FirstOrDefaultAsync(); // Executes a single query to load all data
        }
        public async Task<List<Company>> GetCompanyByNameAsync(string companyName)
        {
            IQueryable<Company> query = _context.Companys
                .Include(x => x.BusinessStream) // Include the BusinessStream
                .Include(x => x.JobPosts) // Include related JobPosts
                .Where(c => string.IsNullOrEmpty(companyName) ||
                            (!string.IsNullOrEmpty(c.CompanyName) && c.CompanyName.ToLower().Contains(companyName.ToLower()))) // Filter by companyName, or return all if empty
                .Select(x => new Company
                {
                    Address = x.Address,
                    BusinessStream = x.BusinessStream,
                    Id = x.Id,
                    WebsiteURL = x.WebsiteURL,
                    CompanyName = x.CompanyName,
                    City = x.City,
                    Country = x.Country,
                    EstablishedYear = x.EstablishedYear,
                    ImageUrl = x.ImageUrl,
                    NumberOfEmployees = x.NumberOfEmployees,
                    CompanyDescription = x.CompanyDescription,
                    BusinessStreamId = x.BusinessStreamId,
                    JobPosts = x.JobPosts.Select(jp => new JobPost
                    {
                        Benefits = jp.Benefits,
                        CompanyId = jp.CompanyId,
                        ExperienceRequired = jp.ExperienceRequired,
                        ImageURL = jp.ImageURL,
                        Id = jp.Id,
                        JobDescription = jp.JobDescription,
                        JobPostReviewStatus = jp.JobPostReviewStatus,
                        JobTitle = jp.JobTitle,
                        IsDeleted = jp.IsDeleted,
                        QualificationRequired = jp.QualificationRequired,
                        ExpiryDate = jp.ExpiryDate,
                        JobTypeId = jp.JobTypeId,
                        PostingDate = jp.PostingDate,
                        JobLocationId = jp.JobLocationId,
                        Salary = jp.Salary,
                    }).ToList() // Materialize the JobPosts projection
                });

            return await query.ToListAsync(); // Executes the query and returns the results as a list
        }




    }
}
