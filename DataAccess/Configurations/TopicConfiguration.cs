using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topic", "dbo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id);
            builder.Property(prop => prop.Name);
            builder.Property(prop => prop.Description);
            builder.Property(prop => prop.CreatedBy);
            builder.Property(prop => prop.CreatedAt);
            builder.Property(prop => prop.UpdatedAt);
            builder.Property(prop => prop.DeletedAt);
        }
    }
}