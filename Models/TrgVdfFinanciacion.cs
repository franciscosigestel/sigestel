using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfFinanciacion
{
    public int Idregistro { get; set; }

    public string Tiporeg { get; set; } = null!;

    public string Ciclo { get; set; } = null!;

    public string FactNo { get; set; } = null!;

    public string Telef { get; set; } = null!;

    public string TipoConcep { get; set; } = null!;

    public decimal Importe { get; set; }

    public string? Conciliacion { get; set; }

    public decimal? ImporteConciliacion { get; set; }

    public string? TelefOld { get; set; }
}
