using Newtonsoft.Json;
using static BlazorAppJsonQuiz.Data.GetQuiz;
using static System.Formats.Asn1.AsnWriter;

namespace BlazorAppJsonQuiz.Data;

public class GetQuiz
{
    public class Quiz
    {
        public string? Questions { get; set; }
        public string? Description { get; set; }
        public string[]? Answers { get; set; }
        public int? Correct { get; set;}
    }
    public class ApiResponse
    {
        public List<Quiz>? Quizs { get; set; }
    }

    public class GetJson
    {
        private static string JsonFile = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));

        public static List<QuizDto> GetQuizDtos()
        {
            return JsonConvert.DeserializeObject<List<QuizDto>>(JsonFile)!;
        }
    }
    public static List<QuizDto> GetItems()
    {

        foreach (QuizDto quizDto in quiz)
        {
          
        }

    }

}
