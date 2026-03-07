using System.Text.Json;
using Exam3.Api.Dtos;
using Exam3.Api.Model;
namespace Exam3.Api.Services;

public class QuestionService
{ 
        
    
    private List<Question> questions;
    private string filePath ="questions.json";

    public QuestionService()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            questions = JsonSerializer.Deserialize<List<Question>>(json);
        }
        else
        {
            questions = new List<Question>();
        }

        private void Save()
        {
            var json = JsonSerializer.Serialize(questions);
            File.WriteAllText(filePath, json);
        }

        public List<Question> Getall()
        {
            return questions;
        }

        public Question Add(Question question)
        {
            question.QuestionId = question.Count + 1;
            Save();
            return question;
        }

        public void Delete(int id)
        {
            var question = questions.FirstOrDefault(x => x.QuestionId == id);
            if (question != null)
            {
                questions.Remove(question);
                Save();
            }
        }

        public QuestionGetDto GetRandomQuestion()
        {
            var rnd = new Random();
            var question = questions.[rnd.Next(0, questions.Count)];
            return new QuestionGetDto
            {
                QuestionId = question.QuestionId,
                Text = question.Text,
                VarinantA = question.VariantA,
                VarinantB = question.VariantB,
                VarinantC = question.VariantC
            };

            public SolveResultDto SolveQuestion(int questionId, string answer)
            {
                var q = questions.FirstOrDefault(x => x.QuestionId == questionId);
                return new SolveResultDto
                {
                    IsCorrect = q.Answer.ToLower() == answer.ToLower(),
                    CorrectAnswer = q.Answer.ToLower()
                };
            }
            public int GetCount()
            {
                return questions.Count;
            }
        }
            
    }
}
