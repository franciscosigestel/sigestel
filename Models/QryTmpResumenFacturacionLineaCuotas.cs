using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryTmpResumenFacturacionLineaCuotas
{
    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public decimal? SumaDeImporte { get; set; }

    public decimal? SumaDeDescuento { get; set; }

    public decimal? Total { get; set; }
}
