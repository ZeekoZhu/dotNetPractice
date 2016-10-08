using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace WebTest.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IHostingEnvironment env) : base(env)
        {
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return StaticView();
        }
    }
}
