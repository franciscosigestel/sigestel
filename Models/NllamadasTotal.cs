using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class NllamadasTotal
{
    public string Nsolicitado { get; set; } = null!;

    public string NumeroLlamado { get; set; } = null!;

    public double? Imp { get; set; }

    public string? FacturaInterna { get; set; }

    public DateTime? FechaFactura { get; set; }

    public string? Empresa { get; set; }

    public string TipoLlamadas { get; set; } = null!;

    public string TipoTrafico { get; set; } = null!;
}
