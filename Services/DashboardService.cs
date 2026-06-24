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

    public TransferResult CreateTransferResult(TransferRequest request)
    {
        return new TransferResult
        {
            ReferenceNumber = $"TRX-{DateTime.UtcNow:yyyyMMddHHmmss}",
            SourceAccountNumber = request.SourceAccountNumber,
            TargetAccountNumber = request.TargetAccountNumber.Trim().ToUpper(),
            Amount = request.Amount ?? 0,
            Currency = "MXN",
            Description = request.Description?.Trim() ?? string.Empty,
            CreatedAtUtc = DateTime.UtcNow
        };
    }

    public List<TransferHistoryItem> GetTransferHistory()
    {
        return new List<TransferHistoryItem>
        {
            new TransferHistoryItem
            {
                ReferenceNumber = "TRX-202606240001",
                SourceAccountNumber = "ACC-1001",
                TargetAccountNumber = "ACC-2001",
                Amount = 500.00m,
                Currency = "MXN",
                Status = "Completed",
                CreatedAtUtc = DateTime.UtcNow.AddHours(-2)
            },
            new TransferHistoryItem
            {
                ReferenceNumber = "TRX-202606230002",
                SourceAccountNumber = "ACC-1001",
                TargetAccountNumber = "ACC-9001",
                Amount = 1200.50m,
                Currency = "MXN",
                Status = "Pending",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-1)
            },
            new TransferHistoryItem
            {
                ReferenceNumber = "TRX-202606220003",
                SourceAccountNumber = "ACC-2001",
                TargetAccountNumber = "ACC-1001",
                Amount = 300.00m,
                Currency = "MXN",
                Status = "Rejected",
                CreatedAtUtc = DateTime.UtcNow.AddDays(-2)
            }
        };
    }


    public CustomerProfile GetCustomerProfile()
    {
        return new CustomerProfile
        {
            FullName = "Víctor Hugo Segundo Aguilar",
            CustomerNumber = "CUS-1001",
            Email = "victor@razorbanking.dev",
            PhoneNumber = "+52 961 000 0000",
            Segment = "Digital Banking",
            RiskLevel = "Low",
            CreatedAtUtc = DateTime.UtcNow.AddMonths(-8)
        };
    }


    public OperationalSummary GetOperationalSummary()
    {
        var accounts = GetAccounts();
        var transfers = GetTransferHistory();

        return new OperationalSummary
        {
            TotalAccounts = accounts.Count,
            ActiveAccounts = accounts.Count(account =>
                account.Status.Equals("Active", StringComparison.OrdinalIgnoreCase)),
            BlockedAccounts = accounts.Count(account =>
                account.Status.Equals("Blocked", StringComparison.OrdinalIgnoreCase)),
            TotalTransfers = transfers.Count,
            CompletedTransfers = transfers.Count(transfer =>
                transfer.Status.Equals("Completed", StringComparison.OrdinalIgnoreCase)),
            PendingTransfers = transfers.Count(transfer =>
                transfer.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase)),
            RejectedTransfers = transfers.Count(transfer =>
                transfer.Status.Equals("Rejected", StringComparison.OrdinalIgnoreCase)),
            TotalTransferredAmount = transfers.Sum(transfer => transfer.Amount),
            Currency = "MXN"
        };
    }

}
