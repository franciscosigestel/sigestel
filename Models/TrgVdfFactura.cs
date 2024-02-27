using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfFactura
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? CuentaNo { get; set; }

    public string? FechaEmision { get; set; }

    public string? Titular { get; set; }

    public string? NifCif { get; set; }

    public string? LugarEmision { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public string? NumLineas { get; set; }
}
