using Exam3.Api.Model;
using Exam3.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam3.Api.Controller;

public class Controllers
    
    {
        [ApiController]
        [Route("/api/questions")]
        public class QuestionController : ControllerBase
        {
            private readonly QuestionService questionService;

            public QuestionController(QuestionService questionService)
            {
                this.questionService = questionService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(questionService.GetAll());
            }

            [HttpPost]
            public IActionResult Add(Question question)
            {
                return Ok(questionService.GetAdd(question));
            }

            [HttpDelete("{id}")]

            public IActionResult Delete(int id)
            
                {
                    questionService.Delete(id);
                    return Ok();
                }

            [HttpGet("random")]
            public IActionResult Random()
            {
                return Ok(questionService.GetRandomQuestion ());
            }

            [HttpGet("count")]
            public IActionResult Count()
            {
                return Ok(questionService.GetCount();
            }

            [HttpPost("solve")]
            public IActionResult Solve(int questionId, string answer)
            {
                return Ok(questionService.SolveQuestion(questionId, answer));
            }
            
        }
    }
