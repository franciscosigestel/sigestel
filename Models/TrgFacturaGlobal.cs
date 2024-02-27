using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgFacturaGlobal
{
    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string? Empresa { get; set; }

    public string? TipoFactura { get; set; }

    public double? Bimponible { get; set; }

    public int? Ppto { get; set; }
}
