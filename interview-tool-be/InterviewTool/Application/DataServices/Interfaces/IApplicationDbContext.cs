using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterviewTool.Application.DataServices.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ChapterResult> ChapterResults { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicResult> TopicResults { get; set; }
    }
}
