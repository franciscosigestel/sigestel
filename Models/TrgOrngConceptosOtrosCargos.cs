using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgOrngConceptosOtrosCargos
{
    public string NFactura { get; set; } = null!;

    public string? Concepto { get; set; }

    public string? NTelefono { get; set; }

    public string? Importe { get; set; }

    public string? ImporteTotal { get; set; }
}
