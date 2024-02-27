using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfCuenta
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public decimal? SaldoPend { get; set; }

    public decimal? TotalPagar { get; set; }

    public decimal? AbonoPend { get; set; }

    public decimal? TotalFactura { get; set; }
}
