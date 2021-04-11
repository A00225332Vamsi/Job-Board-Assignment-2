using JobSearchBoardA00225332.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SavedSearch> SavedSearches { get; set; }
        public DbSet<Candidate> Candidates { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }


    }
}
