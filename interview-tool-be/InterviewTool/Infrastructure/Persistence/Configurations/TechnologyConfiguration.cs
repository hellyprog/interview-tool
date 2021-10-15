using InterviewTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InterviewTool.Infrastructure.Persistence.Configurations
{
    public class TechnologyConfiguration : IEntityTypeConfiguration<Technology>
    {
        public void Configure(EntityTypeBuilder<Technology> builder)
        {
            builder.ToTable("Technologies");

            builder.HasKey(t => t.TechnologyId);
            builder.Property(t => t.TechnologyId).HasColumnName("technology_id").IsRequired();
            builder.Property(t => t.Name).HasColumnName("name").IsRequired();

            builder.HasMany(t => t.Topics)
                .WithOne(t => t.Technology)
                .HasForeignKey(t => t.TechnologyId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
