using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class LlamadasRdInteligente
{
    public string NComercial1 { get; set; } = null!;

    public int? DuracionLlamadasSeg { get; set; }

    public double? ImporteEstandar { get; set; }

    public int? Mes { get; set; }

    public int? Anio { get; set; }

    public string? Empresa { get; set; }
}
