using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
