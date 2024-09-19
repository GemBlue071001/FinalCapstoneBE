﻿using Application;
using Application.Repositories;
using Application.Repository;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IUserAccountRepository UserAccounts { get; }
        public IJobPostRepository JobPosts { get; }
        public ISeekerProfileRepository SeekerProfiles { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserAccounts = new UserAccountRepository(context);
            JobPosts = new JobPostRepository(context);
            SeekerProfiles = new SeekerProfileRepository(context);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
