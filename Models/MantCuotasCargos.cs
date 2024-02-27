using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MantCuotasCargos
{
    public int IdOperadora { get; set; }

    public string CodTipoServicio { get; set; } = null!;

    public string Vigencia { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string CodigoExt { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double ImporteInicial { get; set; }

    public double ImportePeriodico { get; set; }

    public string Periodicidad { get; set; } = null!;

    public string? AgrupaConcepto { get; set; }

    public int? Multiplicar { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public int IdEmpresa { get; set; }
}
