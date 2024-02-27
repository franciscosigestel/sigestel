using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimFactura
{
    public int FacturaKey { get; set; }

    public int? FacturaPkey { get; set; }

    public string? FacturaCod { get; set; }

    public string? FacturaPcod { get; set; }

    public string? FacturaDescripcion { get; set; }
}
