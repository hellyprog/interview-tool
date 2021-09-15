using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class ChapterResultConfiguration : IEntityTypeConfiguration<ChapterResult>
    {
        public void Configure(EntityTypeBuilder<ChapterResult> builder)
        {
            builder.ToTable("ChapterResults");

            builder.HasKey(x => x.ChapterResultId);
            builder.Property(x => x.ChapterResultId).HasColumnName("chapter_result_id").IsRequired();
            builder.Property(x => x.Point).HasColumnName("point").IsRequired();
            builder.Property(x => x.InterviewId).HasColumnName("interview_id").IsRequired();
            builder.Property(x => x.ChapterId).HasColumnName("chapter_id");

            builder.HasOne(x => x.Interview)
                .WithMany(x => x.ChapterResults)
                .HasForeignKey(x => x.InterviewId);

            builder.HasOne(x => x.Chapter)
                .WithMany(x => x.ChapterResults)
                .HasForeignKey(x => x.ChapterId);

            builder.HasMany(x => x.TopicResults)
                .WithOne(x => x.ChapterResult)
                .HasForeignKey(x => x.ChapterResultId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
