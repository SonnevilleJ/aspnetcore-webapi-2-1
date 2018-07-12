using Microsoft.AspNetCore.Mvc;

namespace TodoApi
{
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            return new {a = 5, b = "hi"};
        }
    }
}