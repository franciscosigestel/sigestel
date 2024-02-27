using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngDesgloseFactura
{
    public string NFactura { get; set; } = null!;

    public string NTelefono { get; set; } = null!;

    public string? Tarifa { get; set; }

    public string? Cuotas { get; set; }

    public string? CargosBajoConsumo { get; set; }

    public string? Nacional { get; set; }

    public string? Internacional { get; set; }

    public string? Rpv { get; set; }

    public string? Mensajes { get; set; }

    public string? Datos { get; set; }

    public string? Roaming { get; set; }

    public string? Especiales { get; set; }

    public string? Importe { get; set; }
}
