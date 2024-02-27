using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class SutProductosVbp
{
    public int IdPid { get; set; }

    public string? ProductId { get; set; }

    public string? ServiceId { get; set; }

    public string? ServiceDesc { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? EstadoPVbp { get; set; }

    public DateTime? FechaEstado { get; set; }
}
