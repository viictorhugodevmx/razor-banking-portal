using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class DetailModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public BankAccount? Account { get; set; }
    public bool AccountWasNotFound { get; set; }

    public DetailModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet(string accountNumber)
    {
        Account = _dashboardService
            .GetAccounts()
            .FirstOrDefault(account =>
                account.AccountNumber.Equals(
                    accountNumber?.Trim(),
                    StringComparison.OrdinalIgnoreCase
                )
            );

        AccountWasNotFound = Account is null;
    }
}
