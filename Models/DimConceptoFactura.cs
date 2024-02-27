using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimConceptoFactura
{
    public int ConceptoKey { get; set; }

    public int? ConceptoPkey { get; set; }

    public string? ConceptoCod { get; set; }

    public string? ConceptoPcod { get; set; }

    public string? ConceptoDescripcion { get; set; }
}
