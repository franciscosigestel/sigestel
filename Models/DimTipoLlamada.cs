using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class DimTipoLlamada
{
    public int LlamadaKey { get; set; }

    public int? LlamadaPkey { get; set; }

    public string? LlamadaCod { get; set; }

    public string? LlamadaPcod { get; set; }

    public string? LlamadaDescripcion { get; set; }
}
