namespace Exam3.Api.Dtos;

public class QuestionGetDto
{
    public int QuestionId { get; set; }
    public string Text { get; set; }
    public string VarinantA { get; set; }
    public string VarinantB { get; set; }
    public string VarinantC { get; set; }
}