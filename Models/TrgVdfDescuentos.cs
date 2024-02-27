using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfDescuentos
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? TipoDesc { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Porcent { get; set; }

    public decimal? Importe { get; set; }

    public string? Cuenta { get; set; }

    public string? FechaInicio { get; set; }

    public string? FechaFin { get; set; }

    public string? TelefOld { get; set; }
}
