using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;

namespace MillionaireQuiz.Services
{
    public interface IQuizService
    {

        QuestionViewModel GetQuestionModel(int questionId);
        QuestionViewModel GetNextQuestionModel(QuestionViewModel model);
        bool CorrectAnswer(string selectAnswer, QuestionViewModel model);
    }
}