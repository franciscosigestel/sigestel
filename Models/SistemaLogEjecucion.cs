using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SistemaLogEjecucion
{
    public int IdLog { get; set; }

    public DateTime? FechaLog { get; set; }

    public string? Descripcion { get; set; }

    public bool? EjecucionCorrecta { get; set; }

    public string? ConsultaSql { get; set; }

    public long? NumeroRegistros { get; set; }
}
