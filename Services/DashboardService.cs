using RazorBankingPortal.Models;

namespace RazorBankingPortal.Services;

public class DashboardService
{
    public DashboardAccount GetDashboardAccount()
    {
        return new DashboardAccount
        {
            CustomerName = "Víctor Hugo Segundo Aguilar",
            AccountNumber = "ACC-1001",
            AvailableBalance = 24750.80m,
            Currency = "MXN",
            PendingTransfers = 3,
            RiskLevel = "Low"
        };
    }
}
