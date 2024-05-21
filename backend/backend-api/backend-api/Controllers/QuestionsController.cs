using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[ApiController]
    public class QuestionsController : ControllerBase
    {


        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2"};
        //}

        [HttpPost]
        public void Post([FromBody]Models.Question question) 
        { 
            
        }
        
    }
}
