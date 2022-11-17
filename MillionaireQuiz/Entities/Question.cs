namespace MillionaireQuiz.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Reward { get; set; }
        public ICollection<Answer>? Answers { get; set; }

    }
}