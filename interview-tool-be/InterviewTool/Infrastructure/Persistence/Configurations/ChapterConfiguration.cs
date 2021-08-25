using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters");

            builder.HasKey(c => c.ChapterId);
            builder.Property(c => c.ChapterId).HasColumnName("chapter_id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("name").IsRequired();
            builder.Property(c => c.Weight).HasColumnName("weight").IsRequired();

            builder.HasMany(c => c.Topics)
                .WithOne(t => t.Chapter);
        }
    }
}
