using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVwVdfnResumen
{
    public string Ciclo { get; set; } = null!;

    public string FactNo { get; set; } = null!;

    public string? Telefono { get; set; }

    public decimal? CuotaMensual { get; set; }

    public decimal? OtrasCuotas { get; set; }

    public decimal? Consumo { get; set; }

    public decimal? Descuentos { get; set; }

    public decimal? OtrosAbonos { get; set; }

    public decimal? OtrosCargos { get; set; }

    public decimal? Total { get; set; }
}
