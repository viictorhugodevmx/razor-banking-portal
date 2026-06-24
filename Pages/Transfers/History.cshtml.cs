using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class HistoryModel : PageModel
{
    private readonly DashboardService _dashboardService;

    public List<TransferHistoryItem> Transfers { get; set; } = new();
    public string SelectedStatus { get; set; } = "All";

    public HistoryModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet(string? status)
    {
        SelectedStatus = string.IsNullOrWhiteSpace(status)
            ? "All"
            : status.Trim();

        var transfers = _dashboardService.GetTransferHistory();

        if (!SelectedStatus.Equals("All", StringComparison.OrdinalIgnoreCase))
        {
            transfers = transfers
                .Where(transfer =>
                    transfer.Status.Equals(SelectedStatus, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();
        }

        Transfers = transfers;
    }
}
