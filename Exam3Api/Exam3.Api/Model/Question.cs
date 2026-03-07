namespace Exam3.Api.Model;

public class Question
{
    public int QuestionId { get; set; }
    public required string QuestionText { get; set; }
    public required string VariantA { get; set; }
    public required string VariantB { get; set; }
    public required string VariantC { get; set; }
    public required string Answer { get; set; }
}