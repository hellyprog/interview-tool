using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics");

            builder.HasKey(t => t.TopicId);
            builder.Property(t => t.TopicId).HasColumnName("topic_id").IsRequired();
            builder.Property(t => t.Name).HasColumnName("name").IsRequired();
            builder.Property(t => t.Weight).HasColumnName("weight").IsRequired();
            builder.Property(t => t.ChapterId).HasColumnName("chapter_id").IsRequired();

            builder.HasOne(t => t.Chapter)
                .WithMany(t => t.Topics)
                .HasForeignKey(t => t.ChapterId);

            builder.HasOne(t => t.Technology)
                .WithMany(t => t.Topics)
                .HasForeignKey(t => t.TechnologyId);

            builder.HasMany(x => x.TopicResults)
                .WithOne(x => x.Topic)
                .HasForeignKey(x => x.TopicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
