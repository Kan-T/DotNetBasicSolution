using Microsoft.AspNetCore.Mvc;

namespace BasicAspApp.Controllers
{
    //[Route("attr")]
    [Route("[controller]")]
    public class AttrController
    {
        [Route("")]
        public string Phone()
        {
            return "+10086";
        }

        [Route("country")]
        public string Country()
        {
            return "中国";
        }
    }
}