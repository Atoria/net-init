using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public partial class UserTopicConfiguration : IEntityTypeConfiguration<UserTopic>
    {
        public void Configure(EntityTypeBuilder<UserTopic> builder)
        {
            builder.ToTable("UserTopic", "dbo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id);
            builder.Property(prop => prop.TopicId);
            builder.Property(prop => prop.UserId);
        }
    }
}