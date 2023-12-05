using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetRazorPages.Pages;

public class NouvellePageModel : PageModel
{
    public string? Date { get; private set; }

    public void OnGet()
    {
        Date = DateTime.Now.ToString();
    }
}
