namespace RazorBankingPortal.Models;

public class RiskAlert
{
    public string AlertId { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Detail { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}
