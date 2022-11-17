namespace MillionaireQuiz.Models
{
    public class QuestionViewModel
    {
        public int NumberQuestion { get; set; }
        public string? Question { get; set; }
        public string? AnswerA { get; set; }
        public string? AnswerB { get; set; }
        public string? AnswerC { get; set; }
        public string? AnswerD { get; set; }
        public int RewardQuestion { get; set; }
        public int RewardCurrent { get; set; }
    }
}
