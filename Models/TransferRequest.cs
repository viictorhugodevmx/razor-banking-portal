using System.ComponentModel.DataAnnotations;

namespace RazorBankingPortal.Models;

public class TransferRequest
{
    [Required(ErrorMessage = "Selecciona una cuenta origen.")]
    public string SourceAccountNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Captura una cuenta destino.")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "La cuenta destino debe tener entre 6 y 20 caracteres.")]
    public string TargetAccountNumber { get; set; } = string.Empty;

    public decimal? Amount { get; set; }

    [StringLength(80, ErrorMessage = "La descripción no puede superar 80 caracteres.")]
    public string? Description { get; set; }
}
