namespace RazorBankingPortal.Models;

public class TransferResult
{
    public string ReferenceNumber { get; set; } = string.Empty;
    public string SourceAccountNumber { get; set; } = string.Empty;
    public string TargetAccountNumber { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "MXN";
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}
