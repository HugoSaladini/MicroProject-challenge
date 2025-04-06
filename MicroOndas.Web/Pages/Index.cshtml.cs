using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroOndas.Web.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Tempo { get; set; }

        [BindProperty]
        public int? Potencia { get; set; }

        public string? Status { get; set; }
        public string? Resultado { get; set; }

        public void OnGet()
        {
            // P�gina inicial sem l�gica de backend (tudo est� no JS por enquanto)
        }
    }
}
