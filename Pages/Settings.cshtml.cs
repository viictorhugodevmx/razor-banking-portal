using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class SettingsModel : PageModel
{
    private readonly DashboardService _dashboardService;

    [BindProperty]
    public UserPreferences Preferences { get; set; } = new();

    public bool WasSaved { get; set; }
    public string ResultMessage { get; set; } = string.Empty;

    public SettingsModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Preferences = _dashboardService.GetUserPreferences();
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            ResultMessage = "Revisa la configuración seleccionada.";
            return;
        }

        Preferences = _dashboardService.SaveUserPreferences(Preferences);
        WasSaved = true;
        ResultMessage = "Preferencias guardadas correctamente.";
    }
}
