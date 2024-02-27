using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryTmpResumenFacturacion
{
    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public decimal? ImpCuota { get; set; }

    public decimal? DesCuota { get; set; }

    public decimal? ImpConsumo { get; set; }

    public decimal? DesConsumo { get; set; }

    public decimal? Total { get; set; }

    public int? IdEmpresa { get; set; }
}
