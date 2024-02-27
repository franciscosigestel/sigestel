using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgTel977TipoTrafico
{
    public string AmbitoLlamada { get; set; } = null!;

    public string Fllamada { get; set; } = null!;

    public string Tarifa { get; set; } = null!;

    public string ImporteEstandar { get; set; } = null!;

    public string? Anio { get; set; }
}
