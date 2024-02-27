using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class TrgVdfCompras
{
    public int Idregistro { get; set; }

    public string? Tiporeg { get; set; }

    public string? Ciclo { get; set; }

    public string? FactNo { get; set; }

    public string? Telef { get; set; }

    public string? FechaHora { get; set; }

    public string? Comercio { get; set; }

    public string? Producto { get; set; }

    public decimal? Importe { get; set; }

    public string? TelefOld { get; set; }
}
