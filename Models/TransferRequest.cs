namespace RazorBankingPortal.Models;

public class TransferRequest
{
    public string SourceAccountNumber { get; set; } = string.Empty;
    public string TargetAccountNumber { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
}
