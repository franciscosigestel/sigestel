using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class NllamadasCorporativaImporte
{
    public DateTime? FechaFactura { get; set; }

    public string? FacturaInterna { get; set; }

    public double? Importe { get; set; }

    public string? Empresa { get; set; }

    public string TipoLlamadas { get; set; } = null!;

    public string TipoTrafico { get; set; } = null!;
}
