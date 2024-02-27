using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class EstablecimientoLlamadas
{
    public int IdOperadora { get; set; }

    public string TablaParametro { get; set; } = null!;

    public string ValParametro { get; set; } = null!;

    public string Importe { get; set; } = null!;

    public string DescValParametro { get; set; } = null!;

    public int? IdEmpresa { get; set; }
}
