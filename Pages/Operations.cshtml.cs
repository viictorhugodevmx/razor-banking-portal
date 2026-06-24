using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class OperationsModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public OperationalSummary Summary { get; set; } = new();

    public OperationsModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Summary = _dashboardService.GetOperationalSummary();
    }
}
