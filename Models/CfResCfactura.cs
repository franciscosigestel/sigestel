using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CfResCfactura
{
    public string? FactNo { get; set; }

    public string? NumServ { get; set; }

    public string? LblGrupo { get; set; }

    public string? LblTipo { get; set; }

    public int? NLlamadas { get; set; }

    public string? MinutosKb { get; set; }

    public decimal? Importe { get; set; }

    public string? Titular { get; set; }

    public string? Ciclo { get; set; }
}
