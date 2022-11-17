using MillionaireQuiz.Entities;
using MillionaireQuiz.Models;
using MillionaireQuiz.Repositories.AnswerRepository;
using MillionaireQuiz.Repositories.QuestionRepository;

namespace MillionaireQuiz.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public QuizService(IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }
        public QuestionViewModel GetQuestionModel(int questionId)
        {

            var question = _questionRepository.QuestionGetById(questionId);

            var answersTitle = question.Answers.Select(x => x.Title).ToList();

            var model = new QuestionViewModel()
            {
                NumberQuestion = question.Id,
                Question = question.Title,
                AnswerA = answersTitle[0],
                AnswerB = answersTitle[1],
                AnswerC = answersTitle[2],
                AnswerD = answersTitle[3],
                RewardQuestion = question.Reward
            };
            if (questionId == 1)
            {
                model.RewardCurrent = 0;
            }
            else model.RewardCurrent = _questionRepository.QuestionGetById(questionId - 1).Reward;
            return model;
        }


        public bool CorrectAnswer(string selectAnswer, QuestionViewModel model)
        {
            var correctAnswer = _answerRepository.AnswerGetById(model.NumberQuestion).Title;

            return selectAnswer == correctAnswer; 
        }

        public QuestionViewModel GetNextQuestionModel(QuestionViewModel model)
        {
            model.NumberQuestion++;
            var number = model.NumberQuestion;
            return GetQuestionModel(number);
        }
    }
}