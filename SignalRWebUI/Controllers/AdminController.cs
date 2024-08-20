using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminLayout
        public IActionResult Index()
        {
            return View();
        }

    }
}
