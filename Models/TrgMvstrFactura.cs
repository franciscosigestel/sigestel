using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgMvstrFactura
{
    public string Cif { get; set; } = null!;

    public double? BaseImponible { get; set; }

    public string FechFactura { get; set; } = null!;

    public string Impuesto { get; set; } = null!;

    public string LibNfactura { get; set; } = null!;

    public double? SumaTotal { get; set; }

    public string Tipo { get; set; } = null!;

    public double? TotalDescuentos { get; set; }

    public double? TotalVarios { get; set; }

    public double? TotalServicios { get; set; }

    public double? TotalCuotas { get; set; }

    public double? TotalPagar { get; set; }

    public string TipoContrato { get; set; } = null!;

    public string? Empresa { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }
}
