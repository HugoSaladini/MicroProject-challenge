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
            // Página inicial sem lógica de backend (tudo está no JS por enquanto)
        }
    }
}
