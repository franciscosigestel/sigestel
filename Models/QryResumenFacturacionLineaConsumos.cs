using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryResumenFacturacionLineaConsumos
{
    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public decimal? SumaDeImporte { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? SumaDeImporteNeto { get; set; }

    public int? IdEmpresa { get; set; }
}
