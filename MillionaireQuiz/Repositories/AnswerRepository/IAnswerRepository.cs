using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;

namespace MillionaireQuiz.Repositories.AnswerRepository
{
    public interface IAnswerRepository
    {
        List<Answer> AnswerGetAll(int questionId);
        Answer AnswerGetById(int id);
    }
}

