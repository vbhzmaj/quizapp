using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[ApiController]
    public class QuestionsController : ControllerBase
    {
        readonly QuizContext _quizContext;
        public QuestionsController(QuizContext context) 
        {
            this._quizContext = context;
        }

        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return new Models.Question[] { 
                
                new Models.Question() {Text = "Hello"},
                new Models.Question() {Text = "Hi"}
            };
        }

        [HttpPost]
        public void Post([FromBody]Models.Question question) 
        {
            _quizContext.Questions.Add(new Models.Question() { Text = "test"});
            _quizContext.SaveChanges();
        }
        
    }
}
