using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;

namespace MillionaireQuiz.Repositories.QuestionRepository
{
    public interface IQuestionRepository
    {
        List<Question> QuestionGetAll();
        Question QuestionGetById(int id);
    }
}

