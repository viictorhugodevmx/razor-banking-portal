namespace RazorBankingPortal.Models;

public class RecentMovement
{
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "MXN";
    public DateTime CreatedAtUtc { get; set; }
}
