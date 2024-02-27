using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class Agrupado700000
{
    public string TipoServicio { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;

    public string DomicilioTa { get; set; } = null!;

    public string PoblacionTa { get; set; } = null!;

    public string FechaAlta { get; set; } = null!;

    public string FechaBaja { get; set; } = null!;

    public DateTime? FechaFactura { get; set; }

    public string? FacturaInterna { get; set; }

    public string CodMulticonexion { get; set; } = null!;

    public string? CodMulticon { get; set; }
}
