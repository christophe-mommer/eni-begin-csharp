using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetRazorPages.Pages
{
    public class NouvellePageModel : PageModel
    {
        public string Date { get; set; }

        public void OnGet()
        {
            Date = System.DateTime.Now.ToString();
        }
    }
}
