using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BlazorAppJsonQuiz.Data;

internal class JsonHandler
{
    private static string JsonFile = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));

    public static List<QuizDto> GetQuizDtos()
    {
        return JsonConvert.DeserializeObject<List<QuizDto>>(JsonFile)!;
    }
}
