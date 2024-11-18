using FluentLab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluentLab.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<UserProgress> UserProgress { get; set; }
        public DbSet<TestResult> TestResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка связей
            modelBuilder.Entity<Topic>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Topics)
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Test)
                .WithMany(t => t.Questions)
                .HasForeignKey(q => q.TestId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Topic)
                .WithMany(t => t.Questions)
                .HasForeignKey(q => q.TopicId);

            modelBuilder.Entity<Test>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tests)
                .HasForeignKey(t => t.CategoryId);
        }
    }

}
