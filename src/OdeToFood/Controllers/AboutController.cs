using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[Controller]/[Action]")]
    public class AboutController
    {
        //Route("phone") or
        //[Route("[Action]")]
        public string Phone()
        {
            return "2552218";
        }

        //[Route("Adress")
        //[Route("[Action]")]
        public string Address()
        {
            return "Bezawada";
        }
    }
}
