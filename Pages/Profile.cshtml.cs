using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class ProfileModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public CustomerProfile Customer { get; set; } = new();

    public ProfileModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Customer = _dashboardService.GetCustomerProfile();
    }
}
