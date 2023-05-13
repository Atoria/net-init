using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public partial class UserTopicConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("UserProfile", "dbo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id);
            builder.Property(prop => prop.UserId);
            builder.Property(prop => prop.Phone);
            builder.Property(prop => prop.Name);
            builder.Property(prop => prop.Surname);
            builder.Property(prop => prop.Email);
        }
    }
}