using Microsoft.EntityFrameworkCore;
using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;

namespace MillionaireQuiz.Repositories.QuestionRepository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly QuizDbContext _dbContext;
        public QuestionRepository(QuizDbContext quizDbContext)
        {
            _dbContext = quizDbContext;

        }
        public List<Question> QuestionGetAll()
        {

            return _dbContext.Questions.ToList();
        }

        public Question QuestionGetById(int id)
        {

            //return _dbContext.Questions.FirstOrDefault(q => q.Id == id);
            return _dbContext.Questions.Include(q => q.Answers).FirstOrDefault(q => q.Id == id);
        }
    }
}
