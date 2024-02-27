using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class QryServiciosVodafoneFijo
{
    public int IdLinea { get; set; }

    public string Vfijo { get; set; } = null!;

    public string? Estado { get; set; }
}
