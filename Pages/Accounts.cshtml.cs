using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class AccountsModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public List<BankAccount> Accounts { get; set; } = new();

    public AccountsModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Accounts = _dashboardService.GetAccounts();
    }
}
