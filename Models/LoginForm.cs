using System.ComponentModel.DataAnnotations;

namespace RazorBankingPortal.Models;

public class LoginForm
{
    [Required(ErrorMessage = "Captura tu correo.")]
    [EmailAddress(ErrorMessage = "Captura un correo válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Captura tu contraseña.")]
    public string Password { get; set; } = string.Empty;
}
