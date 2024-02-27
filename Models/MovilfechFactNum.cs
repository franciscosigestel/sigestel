using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MovilfechFactNum
{
    public string FechFactura { get; set; } = null!;

    public string Ntelefono { get; set; } = null!;

    public double? Importe { get; set; }

    public int? Annio { get; set; }

    public string? Mes { get; set; }
}
