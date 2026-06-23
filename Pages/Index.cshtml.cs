using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string CustomerName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public decimal AvailableBalance { get; set; }
    public string Currency { get; set; } = "MXN";
    public int PendingTransfers { get; set; }
    public string RiskLevel { get; set; } = string.Empty;

    public void OnGet()
    {
        CustomerName = "Víctor Hugo Segundo Aguilar";
        AccountNumber = "ACC-1001";
        AvailableBalance = 24750.80m;
        Currency = "MXN";
        PendingTransfers = 3;
        RiskLevel = "Low";
    }
}
