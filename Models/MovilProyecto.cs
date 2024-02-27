using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class MovilProyecto
{
    public string? NTelfConex { get; set; }

    public string? Cif { get; set; }

    public string? Estado { get; set; }

    public string? TipoProyecto { get; set; }

    public string? DescArea { get; set; }

    public string? Ush { get; set; }

    public string Tipo { get; set; } = null!;

    public string? TipoLinea { get; set; }

    public string Ntelefono { get; set; } = null!;

    public double? ImpMovil { get; set; }

    public int? Annio { get; set; }

    public string? Mes { get; set; }
}
