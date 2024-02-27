using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfResumenFactura
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public decimal? BaseImp { get; set; }

    public string? TipoImp { get; set; }

    public string? Impuesto { get; set; }

    public decimal? Total { get; set; }

    public string? Porcentaje { get; set; }
}
