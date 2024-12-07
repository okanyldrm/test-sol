using Microsoft.AspNetCore.Mvc;
using test_class1;

namespace test_api.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("test")]
        public IActionResult GetData()
        {

            Testclass a = new Testclass();
            string aa = a.test;

            return Json(aa);
        }
    }
}
