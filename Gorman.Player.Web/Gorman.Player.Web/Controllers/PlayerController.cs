using System.Web.Mvc;

namespace Gorman.Player.Web.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }
    }
}