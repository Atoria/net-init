using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment", "dbo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id);
            builder.Property(prop => prop.TopicId);
            builder.Property(prop => prop.UserComment);
            builder.Property(prop => prop.CreatedBy);
            builder.Property(prop => prop.CreatedAt);
            builder.Property(prop => prop.UpdatedAt);
            builder.Property(prop => prop.DeletedAt);
        }
    }
}