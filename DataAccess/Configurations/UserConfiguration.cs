using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id);
            builder.Property(prop => prop.Username);
            builder.Property(prop => prop.Image);
            builder.Property(prop => prop.CreatedAt);
            builder.Property(prop => prop.UpdatedAt);
            builder.Property(prop => prop.DeletedAt);
        }
    }
}