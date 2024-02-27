using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TmpTrgVdfResumenTelefono
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? FactNo { get; set; }

    public string? Ciclo { get; set; }

    public string? Cuenta { get; set; }

    public decimal? Cuotas { get; set; }

    public decimal? Descuento { get; set; }

    public string? Telef { get; set; }

    public string? PPreciosVoz { get; set; }

    public string? PPreciosDatos { get; set; }

    public string? Tipo { get; set; }

    public decimal? Importe { get; set; }

    public decimal? ImporteNeto { get; set; }

    public string? TelefOld { get; set; }
}
