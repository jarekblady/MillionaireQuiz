using Microsoft.EntityFrameworkCore;

namespace MillionaireQuiz.Entities
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {

        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
            .Property(q => q.Title)
            .IsRequired();

            modelBuilder.Entity<Question>()
            .Property(q => q.Reward)
            .IsRequired();

            modelBuilder.Entity<Answer>()
            .Property(a => a.Title)
            .IsRequired();
            modelBuilder.Entity<Answer>()
            .Property(a => a.CorrectAnswear)
            .IsRequired();

        }

    }
}
