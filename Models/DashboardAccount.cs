namespace RazorBankingPortal.Models;

public class DashboardAccount
{
    public string CustomerName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public decimal AvailableBalance { get; set; }
    public string Currency { get; set; } = "MXN";
    public int PendingTransfers { get; set; }
    public string RiskLevel { get; set; } = string.Empty;
}
