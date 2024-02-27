using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfResumenConcFact
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? NumServ { get; set; }

    public string? LblGrupo { get; set; }

    public string? LblTipo { get; set; }

    public int? NLlamadas { get; set; }

    public string? MinutosKb { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? ImporteNeto { get; set; }
}
