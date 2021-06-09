using ASPNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetMVC.Controllers
{
    public class MonControleurController : Controller
    {
        public IActionResult NouvellePage()
        {
            var model = new MonModele();
            model.Data = "depuis le contrôleur";
            return View(model);
        }
    }
}