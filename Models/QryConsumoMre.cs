using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryConsumoMre
{
    public int? IdEmpresa { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public string? DescripCuota { get; set; }

    public string? Fechainicio { get; set; }

    public string? Fechafin { get; set; }

    public decimal? SumaDeImporte { get; set; }

    public decimal? SumaDeDescuento { get; set; }

    public decimal? PenalVf { get; set; }
}
