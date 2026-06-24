# Razor Banking Portal

Proyecto del programa **Bankaool .NET Fintech Bridge Lab**.

Portal bancario frontend construido con **ASP.NET Core Razor Pages** para practicar vistas, formularios, navegación y renderizado del lado servidor.

## Stack

- .NET 8
- C#
- Razor Pages
- HTML
- CSS
- Bootstrap base del template
- DataAnnotations
- Partial Views

## Conceptos practicados

| Frontend JS/TS | Razor Pages |
|---|---|
| Template Pug/HBS/Blade | `.cshtml` |
| Component pequeño | Partial View |
| Props | `model` en partial |
| React Router / Angular Router | Routing por archivo en `Pages/` |
| Query params | `OnGet(string? status)` |
| Form submit | `OnPost()` |
| Form state | `[BindProperty]` |
| Validación declarativa | `DataAnnotations` |
| NavLink activo | `ViewContext.RouteData` |

## Features

- Dashboard financiero
- Cuentas
- Detalle de cuenta
- Nueva transferencia
- Validaciones de formulario
- Comprobante de transferencia
- Partial View reutilizable
- Historial de transferencias
- Filtro por estatus
- Estado vacío reutilizable
- Perfil del cliente
- Resumen operativo
- Alertas de riesgo
- Configuración
- Login visual
- Acceso denegado
- Navbar con ruta activa
- About / cierre

## Fix importante aplicado

Para evitar problemas de cultura decimal con `Range(typeof(decimal), "0.01", ...)`, el monto de transferencia quedó así:

```csharp
public decimal? Amount { get; set; }

Y la validación se hace manualmente en OnPost():

if (Transfer.Amount is null)
{
    ModelState.AddModelError("Transfer.Amount", "Captura el monto.");
}
else if (Transfer.Amount <= 0)
{
    ModelState.AddModelError("Transfer.Amount", "El monto debe ser mayor a cero.");
}

En el service se usa:

Amount = request.Amount ?? 0
Ejecutar
dotnet restore
dotnet build
dotnet run

Modo watch:

dotnet watch run
Cierre
razor-banking-portal · Paso 20 listo

