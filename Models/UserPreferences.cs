using System.ComponentModel.DataAnnotations;

namespace RazorBankingPortal.Models;

public class UserPreferences
{
    [Required(ErrorMessage = "Selecciona un idioma.")]
    public string Language { get; set; } = "es-MX";

    [Required(ErrorMessage = "Selecciona un tema.")]
    public string Theme { get; set; } = "Light";

    public bool EmailNotifications { get; set; }

    public bool TransferAlerts { get; set; }

    public bool RiskAlerts { get; set; }
}
