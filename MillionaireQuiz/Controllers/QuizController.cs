using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MillionaireQuiz.Models;
using MillionaireQuiz.Services;

namespace MillionaireQuiz.Controllers
{
    public class QuizController : Controller
    {
        private readonly ILogger<QuizController> _logger;
        private readonly IQuizService _service;

        public QuizController(ILogger<QuizController> logger, IQuizService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Start()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = _service.GetQuestionModel(1);

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(string selectAnswer, QuestionViewModel model)
        {
            var lastNumberQuestion = 12;

            if (_service.CorrectAnswer(selectAnswer, model))
            {
                if (model.NumberQuestion < lastNumberQuestion)
                {
                    return View(_service.GetNextQuestionModel(model));
                }
                else
                {
                    model.RewardCurrent = 1000000;
                    return View("Finish", model);
                }
            }
            else
            {
                model.RewardCurrent = 0;
                return View("Finish", model);
            }
        }

        public IActionResult Finish(QuestionViewModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}