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

    public List<RecentMovement> GetRecentMovements()
    {
        return new List<RecentMovement>
        {
            new RecentMovement
            {
                Type = "Deposit",
                Description = "Depósito nómina",
                Amount = 12500,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-2)
            },
            new RecentMovement
            {
                Type = "Withdrawal",
                Description = "Pago tarjeta digital",
                Amount = 850.75m,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-1)
            },
            new RecentMovement
            {
                Type = "Transfer",
                Description = "Transferencia SPEI recibida",
                Amount = 3200,
                Currency = "MXN",
                CreatedAtUtc = DateTime.UtcNow.AddHours(-8)
            }
        };
    }

    public List<BankAccount> GetAccounts()
    {
        return new List<BankAccount>
        {
            new BankAccount
            {
                AccountNumber = "ACC-1001",
                Alias = "Cuenta principal",
                Balance = 24750.80m,
                Currency = "MXN",
                Status = "Active",
                ProductType = "Digital checking"
            },
            new BankAccount
            {
                AccountNumber = "ACC-2001",
                Alias = "Ahorro fintech",
                Balance = 18300.50m,
                Currency = "MXN",
                Status = "Active",
                ProductType = "Savings"
            },
            new BankAccount
            {
                AccountNumber = "ACC-3001",
                Alias = "Cuenta bloqueada demo",
                Balance = 0,
                Currency = "MXN",
                Status = "Blocked",
                ProductType = "Risk review"
            }
        };
    }
}
