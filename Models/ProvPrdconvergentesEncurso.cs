using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class ProvPrdconvergentesEncurso
{
    public int IdNumpc { get; set; }

    public int IdCatpc { get; set; }

    public string CodigoCatpc { get; set; } = null!;

    public int Idcolectivo { get; set; }

    public string Perfilusuario { get; set; } = null!;

    public DateTime FaltaPc { get; set; }

    public string EstadoPc { get; set; } = null!;

    public DateTime FestadoPc { get; set; }

    public DateTime? FcompletadoPc { get; set; }
}
