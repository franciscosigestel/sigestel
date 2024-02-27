using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfnResumen
{
    public string Ciclo { get; set; } = null!;

    public string FactNo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? CuotaMensual { get; set; }

    public string OtrasCuotas { get; set; } = null!;

    public string? Consumo { get; set; }

    public string? Descuentos { get; set; }

    public string? OtrosAbonos { get; set; }

    public string? OtrosCargos { get; set; }

    public string? Total { get; set; }
}
