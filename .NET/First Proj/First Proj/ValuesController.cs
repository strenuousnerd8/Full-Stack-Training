using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_Proj
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string details()
        {
            return "Let's goooooooooooooooooooooo!";
        }

        [HttpPost]
        public string about() {
            return "Anything!";
        }
    }
}
