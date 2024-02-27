using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVozDatosFactura
{
    public string DescripcionCargo { get; set; } = null!;

    public string FechaEmision { get; set; } = null!;

    public string FechaPuestaCobro { get; set; } = null!;

    public double? ImporteMasPromociones { get; set; }

    public double? Importefactura { get; set; }

    public double? ImportePromociones { get; set; }

    public double? ImporteRedondeo { get; set; }

    public double? BaseImponible { get; set; }

    public string NivelImpositivo { get; set; } = null!;

    public double? TipoImpositivo { get; set; }

    public string? Empresa { get; set; }

    public string? Mes { get; set; }

    public int? Anio { get; set; }

    public string? TipoFactura { get; set; }

    public int? Mes2 { get; set; }
}
