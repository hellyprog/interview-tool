using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class TopicResultConfiguration : IEntityTypeConfiguration<TopicResult>
    {
        public void Configure(EntityTypeBuilder<TopicResult> builder)
        {
            builder.ToTable("TopicResults");

            builder.HasKey(x => x.TopicResultId);
            builder.Property(x => x.TopicResultId).HasColumnName("topic_result_id").IsRequired();
            builder.Property(x => x.Point).HasColumnName("point").IsRequired();
            builder.Property(x => x.ChapterResultId).HasColumnName("chapter_result_id").IsRequired();
            builder.Property(x => x.TopicId).HasColumnName("topic_id");

            builder.HasOne(x => x.Topic)
                .WithMany(x => x.TopicResults)
                .HasForeignKey(x => x.TopicId);

            builder.HasOne(x => x.ChapterResult)
                .WithMany(x => x.TopicResults)
                .HasForeignKey(x => x.ChapterResultId);
        }
    }
}
