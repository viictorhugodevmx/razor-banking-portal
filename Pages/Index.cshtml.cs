using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class IndexModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public DashboardAccount Account { get; set; } = new();

    public IndexModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Account = _dashboardService.GetDashboardAccount();
    }
}
