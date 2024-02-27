using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class CfResmvConsumodatos
{
    public string? Nfactura { get; set; }

    public string? Ntelefono { get; set; }

    public string? Nombre { get; set; }

    public decimal? Sumaimporte { get; set; }

    public string Tipo { get; set; } = null!;
}
