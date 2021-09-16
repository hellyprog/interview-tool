using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InterviewTool.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ChapterResult> ChapterResults { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicResult> TopicResults { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
