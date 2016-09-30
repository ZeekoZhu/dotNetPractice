using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
