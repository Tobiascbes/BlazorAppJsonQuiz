namespace BlazorAppJsonQuiz.Data;

public class QuizDto
{
    public string? Question { get; set; }
    public string[]? Answers { get; set; }
    public string? Description { get; set; }
    public int Correct { get; set; }
}
