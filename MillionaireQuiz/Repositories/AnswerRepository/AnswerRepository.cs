using Microsoft.EntityFrameworkCore;
using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;

namespace MillionaireQuiz.Repositories.AnswerRepository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly QuizDbContext _dbContext;
        public AnswerRepository(QuizDbContext quizDbContext)
        {
            _dbContext = quizDbContext;

        }
        public List<Answer> AnswerGetAll(int questionId)
        {

            return _dbContext.Answers.Where(a => a.QuestionId == questionId).ToList();
        }

        public Answer AnswerGetById(int questionId)
        {

            return _dbContext.Answers.Where(a => a.CorrectAnswear == true).FirstOrDefault(a => a.QuestionId == questionId);
        }
    }
}