namespace RazorBankingPortal.Models;

public class BankAccount
{
    public string AccountNumber { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public string Currency { get; set; } = "MXN";
    public string Status { get; set; } = string.Empty;
    public string ProductType { get; set; } = string.Empty;
}
