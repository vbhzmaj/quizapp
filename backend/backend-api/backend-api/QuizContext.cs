using Microsoft.EntityFrameworkCore;

namespace backend_api
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) {  }

        public DbSet<Models.Question> Questions { get; set; }
    }
}
