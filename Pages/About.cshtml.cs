using Microsoft.AspNetCore.Mvc.RazorPages;

public class AboutModel : PageModel
{
    public List<string> CompletedFeatures { get; set; } = new();

    public void OnGet()
    {
        CompletedFeatures = new List<string>
        {
            "Dashboard financiero",
            "Listado y detalle de cuentas",
            "Formulario de transferencia con validaciones",
            "Comprobante reutilizable con Partial View",
            "Historial con filtros por query params",
            "Perfil del cliente",
            "Resumen operativo",
            "Alertas de riesgo",
            "Configuración de usuario",
            "Login visual simulado",
            "Acceso denegado",
            "Navbar con estado activo",
            "Estado vacío reutilizable"
        };
    }
}
