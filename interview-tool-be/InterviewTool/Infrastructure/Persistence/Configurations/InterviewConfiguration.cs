using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.ToTable("Interviews");

            builder.HasKey(x => x.InterviewId);
            builder.Property(x => x.InterviewId).HasColumnName("interview_id").IsRequired();
            builder.Property(x => x.CandidateName).HasColumnName("candidate_name").IsRequired();
            builder.Property(x => x.IsFinished).HasColumnName("is_finished").IsRequired();

            builder.HasMany(x => x.ChapterResults)
                .WithOne(x => x.Interview)
                .HasForeignKey(x => x.InterviewId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
