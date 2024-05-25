namespace backend_api.Models
{
    public class Question
    {
        
        public int Id { get; set; }
        public string? Qtext { get; set; }

        public string? CorrectAnswer { get; set; }

        public string? WrongAnswer1 { get; set; }

        public string? WrongAnswer2 { get; set; }

        public string? WrongAnswer3 { get; set; }
    }
}
