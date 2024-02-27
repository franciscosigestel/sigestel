using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryConsumoMinimo
{
    public int? IdEmpresa { get; set; }

    public string? Ciclo { get; set; }

    public string? Telef2 { get; set; }

    public decimal? CvExigido { get; set; }

    public decimal? CvDescontado { get; set; }

    public decimal? CvPenalizacion { get; set; }

    public decimal? Totalvoz { get; set; }
}
