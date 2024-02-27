using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ScttPaisesZonas
{
    public string CodPais { get; set; } = null!;

    public int IdOperador { get; set; }

    public string CodZona { get; set; } = null!;

    public int IdPaisZona { get; set; }

    public virtual ScctZonas ScctZonas { get; set; } = null!;
}
