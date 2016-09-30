using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTest.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IHostingEnvironment env;

        public BaseController(IHostingEnvironment env)
        {
            this.env = env;
        }
        public IActionResult StaticView()
        {
            string className = ControllerContext.ActionDescriptor.ControllerName;
            System.Console.WriteLine(className);
            string actionName = ControllerContext.ActionDescriptor.ActionName+".html";
            System.Console.WriteLine($"{className}/{actionName}");
            return new PhysicalFileResult(Path.Combine(env.WebRootPath, className, actionName), "text/html");
        }
    }
}
