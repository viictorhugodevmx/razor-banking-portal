using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;

public class LoginModel : PageModel
{
    [BindProperty]
    public LoginForm Login { get; set; } = new();

    public string ResultMessage { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            ResultMessage = "Revisa tus credenciales.";
            return Page();
        }

        var isValidUser =
            Login.Email.Equals("victor@razorbanking.dev", StringComparison.OrdinalIgnoreCase)
            && Login.Password == "Password123";

        if (!isValidUser)
        {
            ResultMessage = "Correo o contraseña incorrectos.";
            return Page();
        }

        return RedirectToPage("/Index");
    }
}
