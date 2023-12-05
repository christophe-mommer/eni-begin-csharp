using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC;

public class MonControleurController : Controller
{
    public IActionResult NouvellePage()
    {
        var model = new MonModele
        {
            Data = "depuis le contrôleur"
        };
        return View(model);
    }
}
