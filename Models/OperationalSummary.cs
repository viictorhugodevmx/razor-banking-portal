namespace RazorBankingPortal.Models;

public class OperationalSummary
{
    public int TotalAccounts { get; set; }
    public int ActiveAccounts { get; set; }
    public int BlockedAccounts { get; set; }
    public int TotalTransfers { get; set; }
    public int CompletedTransfers { get; set; }
    public int PendingTransfers { get; set; }
    public int RejectedTransfers { get; set; }
    public decimal TotalTransferredAmount { get; set; }
    public string Currency { get; set; } = "MXN";
}
