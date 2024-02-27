using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfDetalleCuotas
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? DescripCuota { get; set; }

    public decimal? Importe { get; set; }

    public int? Cantidad { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public decimal? Descuento { get; set; }

    public short? Packsg { get; set; }

    public string? TelefOld { get; set; }
}
