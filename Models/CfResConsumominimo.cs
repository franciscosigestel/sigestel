using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CfResConsumominimo
{
    public string? FactNo { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public string? Tipo { get; set; }

    public decimal? SumaDeImporte { get; set; }

    public decimal? SumaDeImporteNeto { get; set; }

    public string Tipocons { get; set; } = null!;
}
