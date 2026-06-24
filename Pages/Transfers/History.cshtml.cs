using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class HistoryModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public List<TransferHistoryItem> Transfers { get; set; } = new();

    public HistoryModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        Transfers = _dashboardService.GetTransferHistory();
    }
}
