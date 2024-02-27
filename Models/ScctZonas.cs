using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ScctZonas
{
    public int IdOperador { get; set; }

    public string CodZona { get; set; } = null!;

    public string DesZona { get; set; } = null!;

    public string DesOperador { get; set; } = null!;

    public string? CodTipoTrafico { get; set; }

    public string? DesTipoTrafico { get; set; }

    public string? TipoZona { get; set; }
}
