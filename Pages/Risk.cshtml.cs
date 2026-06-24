using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class RiskModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public List<RiskAlert> Alerts { get; set; } = new();

    public RiskModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Alerts = _dashboardService.GetRiskAlerts();
    }
}
