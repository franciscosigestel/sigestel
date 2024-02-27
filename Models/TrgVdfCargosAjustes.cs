using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfCargosAjustes
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Importe { get; set; }

    public string? TelefOld { get; set; }
}
