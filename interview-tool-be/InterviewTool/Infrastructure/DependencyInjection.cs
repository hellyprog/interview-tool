using InterviewTool.Domain.Repositories;
using InterviewTool.Infrastructure.Persistence;
using InterviewTool.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InterviewTool.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddTransient<IChapterRepository, ChapterRepository>();
            services.AddTransient<IChapterResultRepository, ChapterResultRepository>();
            services.AddTransient<IInterviewRepository, InterviewRepository>();
            services.AddTransient<ITechnologyRepository, TechnologyRepository>();
            services.AddTransient<ITopicRepository, TopicRepository>();
            services.AddTransient<ITopicResultRepository, TopicResultRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
