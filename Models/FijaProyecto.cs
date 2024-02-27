using System;
using System.Collections.Generic;

namespace sigestel.Models;

public partial class FijaProyecto
{
    public string? NTelfConex { get; set; }

    public string? Cif { get; set; }

    public string? Estado { get; set; }

    public string? TipoProyecto { get; set; }

    public string? DescArea { get; set; }

    public string? Ush { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Expr1 { get; set; }

    public decimal? ImporteFija { get; set; }

    public string CodMulticonexion { get; set; } = null!;

    public string NComercial1 { get; set; } = null!;
}
