using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Candidate> candidates { get; set; }
        public DbSet<Models.AppearedCandidate> appearedCandidates { get; set; }

        public DbSet<Models.AppearedQuestionsDetails> AppearedQuestionsDetails{ get; set; }

        public DbSet<Models.Cleared> cleareds{ get; set; }
        public DbSet<Models.Question> questions{ get; set; }
        public DbSet<Models.QuestionOpt> questionOpts { get; set; }
        public DbSet<Models.Subject> subjects { get; set; }

    }
}
