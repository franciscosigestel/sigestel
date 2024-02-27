using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryConsumoVozxLineayCiclo
{
    public int? IdEmpresa { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public decimal? SumaDeImporteNeto { get; set; }

    public string Tipocons { get; set; } = null!;
}
