using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBankingPortal.Models;
using RazorBankingPortal.Services;

public class NewModel : PageModel
{
    private readonly DashboardService _dashboardService;

    [BindProperty]
    public TransferRequest Transfer { get; set; } = new();

    public List<BankAccount> Accounts { get; set; } = new();
    public bool WasSubmitted { get; set; }
    public string ResultMessage { get; set; } = string.Empty;
    public TransferResult? Result { get; set; }

    public NewModel(DashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    public void OnGet()
    {
        LoadAccounts();
    }

    public void OnPost()
    {
        LoadAccounts();

        if (Transfer.Amount <= 0)
        {
            ModelState.AddModelError("Transfer.Amount", "El monto debe ser mayor a cero.");
        }

        if (!ModelState.IsValid)
        {
            ResultMessage = "Revisa los datos del formulario.";
            return;
        }

        Result = _dashboardService.CreateTransferResult(Transfer);
        WasSubmitted = true;
        ResultMessage = "Transferencia simulada registrada correctamente.";
    }

    private void LoadAccounts()
    {
        Accounts = _dashboardService.GetAccounts();
    }
}
