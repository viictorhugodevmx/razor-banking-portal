namespace RazorBankingPortal.Models;

public class CustomerProfile
{
    public string FullName { get; set; } = string.Empty;
    public string CustomerNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Segment { get; set; } = string.Empty;
    public string RiskLevel { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}
