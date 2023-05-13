using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using System.Reflection;
using System.Linq;

namespace DataAccess
{
    public class ForumContext : DbContext
    {
        public ForumContext() { }

        public ForumContext(DbContextOptions<ForumContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        #region Tables
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserTopic> UserTopic { get; set; }
        #endregion

    }
}
